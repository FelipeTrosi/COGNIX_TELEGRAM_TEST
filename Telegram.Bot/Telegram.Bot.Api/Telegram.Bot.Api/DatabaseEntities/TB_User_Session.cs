using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_User_Session
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Hostname { get; set; }
        public DateTime LoginTime { get; set; }
        public int Status { get; set; }

        public virtual TB_User User { get; set; }
    }
}
