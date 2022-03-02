using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Order_StatusLog
    {
        public long Id { get; set; }
        public int Status { get; set; }
        public DateTime DateTime { get; set; }
        public long UserId { get; set; }
        public long OrderId { get; set; }

        public virtual TB_Order Order { get; set; }
        public virtual TB_User User { get; set; }
    }
}
