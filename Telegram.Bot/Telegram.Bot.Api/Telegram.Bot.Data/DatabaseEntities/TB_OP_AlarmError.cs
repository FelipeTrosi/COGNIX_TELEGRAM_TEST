using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_OP_AlarmError
    {
        public long IDError { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorText { get; set; }
        public string ErrorType { get; set; }
    }
}
