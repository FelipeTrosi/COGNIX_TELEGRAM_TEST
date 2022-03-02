using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Api.Models;
using Telegram.Bot.Types.Enums;

namespace Telegram.Bot.Api.Services
{
    public class ConfigureWebhook : IHostedService
    {
        private readonly ILogger<ConfigureWebhook> _logger;
        private readonly IServiceProvider _services;
        private readonly Models.TelegramConfiguration _botConfig;

        public ConfigureWebhook(ILogger<ConfigureWebhook> logger,
                                IServiceProvider serviceProvider,
                                IConfiguration configuration)
        {
            _logger = logger;
            _services = serviceProvider;
            _botConfig = configuration.GetSection("TelegramConfiguration").Get<TelegramConfiguration>();
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = _services.CreateScope();
            var botClient = scope.ServiceProvider.GetRequiredService<ITelegramBotClient>();

            BotHelper.BotClient = botClient;

            var webhookAddress = @$"{_botConfig.HostAddress}/bot/{_botConfig.BotToken}";
            _logger.LogInformation("Setting webhook: {webhookAddress}", webhookAddress);

            await botClient.SetWebhookAsync(
                url: webhookAddress,
                allowedUpdates: Array.Empty<UpdateType>(),
                cancellationToken: cancellationToken);

           var a =  botClient.GetWebhookInfoAsync();
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            using var scope = _services.CreateScope();
            var botClient = scope.ServiceProvider.GetRequiredService<ITelegramBotClient>();

            // Remove webhook upon app shutdown
            _logger.LogInformation("Removing webhook");
            await botClient.DeleteWebhookAsync(cancellationToken: cancellationToken);
        }
    }
}
