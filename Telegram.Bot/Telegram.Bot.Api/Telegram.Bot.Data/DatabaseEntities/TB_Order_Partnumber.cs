using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Order_Partnumber
    {
        public long Id { get; set; }
        public string Partnumber { get; set; }
        public long OrderId { get; set; }

        public virtual TB_Order Order { get; set; }
    }
}
