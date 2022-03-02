using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Telegram.Bot.Api.Models
{
    public class TelegramError
    {
        public TelegramError() =>
            DateTimeError = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        public string DateTimeError { get; private set; }
        public string Exception { get; set; }
    }

    public static class Errors
    {
        public static List<TelegramError> Erros { get; set; } = new List<TelegramError>();
    }
}
