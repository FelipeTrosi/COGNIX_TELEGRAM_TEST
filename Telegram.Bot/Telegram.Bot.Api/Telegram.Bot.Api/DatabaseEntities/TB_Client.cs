using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Client
    {
        public TB_Client()
        {
            TB_Orders = new HashSet<TB_Order>();
            TB_Products = new HashSet<TB_Product>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int IsActived { get; set; }

        public virtual ICollection<TB_Order> TB_Orders { get; set; }
        public virtual ICollection<TB_Product> TB_Products { get; set; }
    }
}
