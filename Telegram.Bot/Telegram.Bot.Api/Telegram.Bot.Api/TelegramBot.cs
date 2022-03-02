using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Api.Controllers;
using Telegram.Bot.Api.DatabaseEntities;
using Telegram.Bot.Api.Models;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Api
{
    public class TelegramBot
    {
        public static TelegramBotClient botClient = new TelegramBotClient("2145005876:AAFN5SIZh3wStLZAmX4rL--rP0VDsHIOMbM");
        //public static TelegramBotClient botClient = new TelegramBotClient("5128322032:AAGKKiVHastTspgWGytY_AqFxCB9RJz8KDs");
        //public static TelegramBotClient botClient = new TelegramBotClient("5259390115:AAH64x6C_WPoTiXaS2y8SqYZyI234JyByZ0");
        private CancellationToken ct = new CancellationToken();
        private readonly DatabaseContext _sql;

        public TelegramBot() =>
            _sql = new DatabaseContext();

        public void InitiateBot()
        {
            using var cts = new CancellationTokenSource();

            ReceiverOptions receiverOptions = new ReceiverOptions() { AllowedUpdates = { } };

            botClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken: cts.Token);

            //cts.Cancel();

        }

        public async Task EchoAsync(Update update)
        {
            var handler = update.Type switch
            {
                UpdateType.Message => BotOnMessageReceived(update.Message!),
                UpdateType.EditedMessage => BotOnMessageReceived(update.EditedMessage!),
                UpdateType.CallbackQuery => BotOnCallbackQueryReceived(update.CallbackQuery!),
                UpdateType.InlineQuery => BotOnInlineQueryReceived(update.InlineQuery!),
                UpdateType.ChosenInlineResult => BotOnChosenInlineResultReceived(update.ChosenInlineResult!),
                _ => UnknownUpdateHandlerAsync(update)
            };

            try
            {
                await handler;
            }
            catch (Exception exception)
            {
                await HandleErrorAsync(botClient, exception, ct);
            }
        }

        private async Task BotOnMessageReceived(Message message)
        {
            Console.WriteLine("Receive message type: {messageType}", message.Type);
            if (message.Type != MessageType.Text)
                return;

            var action = message.Text!.Split(' ')[0] switch
            {
                "/inline" => SendInlineKeyboard(botClient, message),
                "/keyboard" => SendReplyKeyboard(botClient, message),
                "/remove" => RemoveKeyboard(botClient, message),
                "/photo" => SendFile(botClient, message),
                "/request" => RequestContactAndLocation(botClient, message),
                _ => Usage(botClient, message)
            };
            Message sentMessage = await action;
            Console.WriteLine("The message was sent with id: {sentMessageId}", sentMessage.MessageId);

            // Send inline keyboard
            // You can process responses in BotOnCallbackQueryReceived handler
            static async Task<Message> SendInlineKeyboard(ITelegramBotClient bot, Message message)
            {
                await bot.SendChatActionAsync(message.Chat.Id, ChatAction.Typing);

                // Simulate longer running task
                await Task.Delay(500);

                InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(
                    new[]
                    {
                    // first row
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData("1.1", "11"),
                        InlineKeyboardButton.WithCallbackData("1.2", "12"),
                    },
                    // second row
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData("2.1", "21"),
                        InlineKeyboardButton.WithCallbackData("2.2", "22"),
                    },
                    });

                return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
                                                      text: "Choose",
                                                      replyMarkup: inlineKeyboard);
            }

            static async Task<Message> SendReplyKeyboard(ITelegramBotClient bot, Message message)
            {
                ReplyKeyboardMarkup replyKeyboardMarkup = new ReplyKeyboardMarkup(
                    new[]
                    {
                        new KeyboardButton[] { "1.1", "1.2" },
                        new KeyboardButton[] { "2.1", "2.2" },
                    })
                {
                    ResizeKeyboard = true
                };

                return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
                                                      text: "Choose",
                                                      replyMarkup: replyKeyboardMarkup);
            }

            static async Task<Message> RemoveKeyboard(ITelegramBotClient bot, Message message)
            {
                return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
                                                      text: "Removing keyboard",
                                                      replyMarkup: new ReplyKeyboardRemove());
            }

            static async Task<Message> SendFile(ITelegramBotClient bot, Message message)
            {
                await bot.SendChatActionAsync(message.Chat.Id, ChatAction.UploadPhoto);

                const string filePath = @"Files/tux.png";
                using FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                var fileName = filePath.Split(Path.DirectorySeparatorChar).Last();

                return await bot.SendPhotoAsync(chatId: message.Chat.Id,
                                                photo: new InputOnlineFile(fileStream, fileName),
                                                caption: "Nice Picture");
            }

            static async Task<Message> RequestContactAndLocation(ITelegramBotClient bot, Message message)
            {
                ReplyKeyboardMarkup RequestReplyKeyboard = new ReplyKeyboardMarkup(
                    new[]
                    {
                    KeyboardButton.WithRequestLocation("Location"),
                    KeyboardButton.WithRequestContact("Contact"),
                    });

                return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
                                                      text: "Who or Where are you?",
                                                      replyMarkup: RequestReplyKeyboard);
            }

            static async Task<Message> Usage(ITelegramBotClient bot, Message message)
            {
                const string usage = "Usage:\n" +
                                     "/inline   - send inline keyboard\n" +
                                     "/keyboard - send custom keyboard\n" +
                                     "/remove   - remove custom keyboard\n" +
                                     "/photo    - send a photo\n" +
                                     "/request  - request location or contact";

                return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
                                                      text: usage,
                                                      replyMarkup: new ReplyKeyboardRemove());
            }
        }

        private async Task BotOnCallbackQueryReceived(CallbackQuery callbackQuery)
        {
            await botClient.AnswerCallbackQueryAsync(
                callbackQueryId: callbackQuery.Id,
                text: $"Received {callbackQuery.Data}");

            await botClient.SendTextMessageAsync(
                chatId: callbackQuery.Message.Chat.Id,
                text: $"Received {callbackQuery.Data}");
        }

        #region Inline Mode

        private async Task BotOnInlineQueryReceived(InlineQuery inlineQuery)
        {
            Console.WriteLine("Received inline query from: {inlineQueryFromId}", inlineQuery.From.Id);

            InlineQueryResult[] results = {
            // displayed result
            new InlineQueryResultArticle(
                id: "3",
                title: "TgBots",
                inputMessageContent: new InputTextMessageContent(
                    "hello"
                )
            )
        };

            await botClient.AnswerInlineQueryAsync(inlineQueryId: inlineQuery.Id,
                                                    results: results,
                                                    isPersonal: true,
                                                    cacheTime: 0);
        }

        private Task BotOnChosenInlineResultReceived(ChosenInlineResult chosenInlineResult)
        {
            Console.WriteLine("Received inline result: {chosenInlineResultId}", chosenInlineResult.ResultId);
            return Task.CompletedTask;
        }

        #endregion

        private Task UnknownUpdateHandlerAsync(Update update)
        {
            Console.WriteLine("Unknown update type: {updateType}", update.Type);
            return Task.CompletedTask;
        }

        Task HandleErrorAsync(ITelegramBotClient telegramClient, Exception exception, CancellationToken cancellationToken)
        {
            try
            {
                //var ErrorMessage = exception switch
                //{
                //    ApiRequestException apiRequestException => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                //    _ => exception.ToString()
                //};

                Errors.Erros.Add(new TelegramError
                {
                    Exception = $@"Exception: {exception.Message}

InnerException: {exception.InnerException?.Message}"
                });
                return Task.CompletedTask;
            }
            catch (Exception)
            {
                return Task.CompletedTask;
            }

        }

        async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            try
            {
                //WebhookController controller = new WebhookController();
                //await controller.SendMessage(update);

                if (update.Message.Type == MessageType.Text)
                {
                    if (update.Message.Text == "/start")
                    {
                        string welcomeMessage = @$"Olá {update.Message.Chat.Username}. Bem vindo as notificações LSM. Como posso ajudar ?";

                        ReplyKeyboardMarkup replyKeyboardMarkup =
                            new ReplyKeyboardMarkup(
                                new[]
                                {
                                                new KeyboardButton[]
                                                {
                                                    "Começar a receber notificações via Telegram.",
                                                },
                                                new KeyboardButton[]
                                                {
                                                    "Sair"
                                                },
                                }
                                )
                            {
                                OneTimeKeyboard = true,
                                Selective = true,
                                ResizeKeyboard = true,
                            };

                        await botClient.SendTextMessageAsync(update.Message.Chat.Id, welcomeMessage, replyToMessageId: update.Message.MessageId, replyMarkup: replyKeyboardMarkup);
                    }
                    else if (update.Message.Text.Contains("/register"))
                    {
                        IEnumerable<string> sensitiveData = update.Message.Text.Replace("/register", "").Replace(":", "").Split(";").Select(q => q.Trim());

                        string login = sensitiveData.FirstOrDefault();
                        if (string.IsNullOrEmpty(login))
                            await botClient.SendTextMessageAsync(update.Message.Chat.Id, @$"Não foi possível identificar o usuário informado", replyToMessageId: update.Message.MessageId);

                        string pass = sensitiveData.LastOrDefault();
                        if (string.IsNullOrEmpty(pass))
                            await botClient.SendTextMessageAsync(update.Message.Chat.Id, @$"Não foi possível identificar a senha informado", replyToMessageId: update.Message.MessageId);

                        TB_User user = _sql.TB_Users.FirstOrDefault(q => q.Username == login && q.Password == pass);

                        if (user == null)
                            await botClient.SendTextMessageAsync(update.Message.Chat.Id, @$"Usuário ou senha inválida.", replyToMessageId: update.Message.MessageId);
                        else
                        {
                            await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Configurando usuários para notificações...");

                            TB_Notification_ThirdParty_Config thirdPartyConfig = _sql.TB_Notification_ThirdParty_Configs.Where(q => q.UserId == user.Id && q.ThirdPartyAppName == "Telegram").FirstOrDefault();

                            if (thirdPartyConfig == null)
                            {
                                thirdPartyConfig = new TB_Notification_ThirdParty_Config
                                {
                                    ThirdPartyAppName = "Telegram",
                                    UserId = user.Id
                                };

                                _sql.TB_Notification_ThirdParty_Configs.Add(thirdPartyConfig);
                            }

                            thirdPartyConfig.ThirdPartyId = (int)update.Message.Chat.Id;
                            _sql.SaveChanges();

                            await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Agora você está pronto para receber as notificações via Telegram !");
                        }
                    }
                    else if (update.Message.Text == "Começar a receber notificações via Telegram.")
                    {
                        string welcomeMessage = @"Muito bem. Primeiro preciso saber quem voce é ...
                Digite seu usuário e senha de acesso ao LSM.
                Não se preocupe, você está em um espaço seguro.
                E.g: /register: usuario;senha'";

                        await botClient.SendTextMessageAsync(update.Message.Chat.Id, welcomeMessage, replyToMessageId: update.Message.MessageId);
                    }
                    else if (update.Message.Text == "Sair")
                    {
                        await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Tudo bem. Obrigado.", replyToMessageId: update.Message.MessageId);
                    }
                    else
                    {
                        await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Desculpe, Não entendi o que você gostaria de fazer.", replyToMessageId: update.Message.MessageId);
                    }
                }
            }
            catch (Exception e)
            {
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, @$"Ocorreu uma exceção na comunicação com o Telegram:

Exception: {e.Message}

InnerException: {e.InnerException?.Message}");

            }
        }

        public async Task SendTextMessageAsync(long chatId, string message, int? replyToMessageId = null, ReplyKeyboardMarkup replyMarkup = null) =>
            await botClient.SendTextMessageAsync(chatId, message, replyToMessageId: replyToMessageId, replyMarkup: replyMarkup);
    }
}
