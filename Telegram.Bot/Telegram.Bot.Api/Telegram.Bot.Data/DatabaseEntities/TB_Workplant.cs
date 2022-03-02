using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Workplant
    {
        public TB_Workplant()
        {
            TB_Wokareas = new HashSet<TB_Wokarea>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int Status { get; set; }

        public virtual ICollection<TB_Wokarea> TB_Wokareas { get; set; }
    }
}
