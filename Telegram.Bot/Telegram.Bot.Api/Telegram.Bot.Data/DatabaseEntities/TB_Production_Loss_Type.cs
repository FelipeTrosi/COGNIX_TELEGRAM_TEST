using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Production_Loss_Type
    {
        public TB_Production_Loss_Type()
        {
            TB_Production_Losses = new HashSet<TB_Production_Loss>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public int? Status { get; set; }
        public string Color { get; set; }

        public virtual ICollection<TB_Production_Loss> TB_Production_Losses { get; set; }
    }
}
