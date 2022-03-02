using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_User_Permission
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Module { get; set; }
        public string AcessLevel { get; set; }

        public virtual TB_User User { get; set; }
    }
}
