using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class __LogApplication
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public DateTime DateTime { get; set; }
        public int EventType { get; set; }
        public string StateId { get; set; }
        public string StateName { get; set; }
        public string OriginalState { get; set; }
        public string ChangedState { get; set; }

        public virtual TB_User User { get; set; }
    }
}
