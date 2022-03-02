using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Wokarea
    {
        public TB_Wokarea()
        {
            TB_Worklines = new HashSet<TB_Workline>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int Status { get; set; }
        public long WorkplantId { get; set; }

        public virtual TB_Workplant Workplant { get; set; }
        public virtual ICollection<TB_Workline> TB_Worklines { get; set; }
    }
}
