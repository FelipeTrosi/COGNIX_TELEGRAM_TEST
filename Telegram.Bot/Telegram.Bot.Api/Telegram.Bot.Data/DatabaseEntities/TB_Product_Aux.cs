using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Product_Aux
    {
        public TB_Product_Aux()
        {
            TB_Products = new HashSet<TB_Product>();
        }

        public long Id { get; set; }
        public string Prefix { get; set; }
        public string Separator { get; set; }
        public string Suffix { get; set; }

        public virtual ICollection<TB_Product> TB_Products { get; set; }
    }
}
