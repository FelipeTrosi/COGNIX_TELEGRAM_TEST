using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Product_BOM
    {
        public long Id { get; set; }
        public long? ProductId { get; set; }
        public long? BOMId { get; set; }
        public float Qty { get; set; }
        public int IsActived { get; set; }

        public virtual TB_BOM BOM { get; set; }
        public virtual TB_Product Product { get; set; }
    }
}
