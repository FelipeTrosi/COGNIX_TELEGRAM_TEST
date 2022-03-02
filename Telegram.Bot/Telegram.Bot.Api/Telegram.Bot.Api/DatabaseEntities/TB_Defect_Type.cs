using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Defect_Type
    {
        public TB_Defect_Type()
        {
            TB_Defects = new HashSet<TB_Defect>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public string Groups { get; set; }

        public virtual ICollection<TB_Defect> TB_Defects { get; set; }
    }
}
