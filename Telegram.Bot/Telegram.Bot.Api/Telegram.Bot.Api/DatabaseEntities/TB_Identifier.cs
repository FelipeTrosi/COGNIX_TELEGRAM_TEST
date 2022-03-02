using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Identifier
    {
        public long InsertResultID { get; set; }
        public string Identifier1 { get; set; }
        public string Identifier2 { get; set; }
        public string Identifier3 { get; set; }
        public string Identifier4 { get; set; }
        public string seq { get; set; }
        public string modelo { get; set; }
        public int? UserID { get; set; }
    }
}
