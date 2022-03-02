using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Api.DatabaseEntities;
using Telegram.Bot.Api.Services;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Api.Controllers
{
    //[ApiController]
    //[Route("api/[controller]")]
    public class WebhookController : ControllerBase
    {
        private readonly TelegramBot _bot;
        private readonly DatabaseContext _sql;
        public WebhookController()
        {
            _bot = new TelegramBot();
            _sql = new DatabaseContext();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromServices] HandleUpdateService handleUpdateService,
                                              [FromBody] Update update)
        {
            await handleUpdateService.EchoAsync(update);
            return Ok();
        }

        public async Task<IActionResult> SendMessage()
        {
            await BotHelper.BotClient.SendTextMessageAsync(1673565024, "Test Message");
         
            return Ok();
        }
    }
}
