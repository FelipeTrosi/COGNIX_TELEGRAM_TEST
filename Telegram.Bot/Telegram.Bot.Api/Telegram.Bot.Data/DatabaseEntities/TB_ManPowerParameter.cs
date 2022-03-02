using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_ManPowerParameter
    {
        public TB_ManPowerParameter()
        {
            TB_LocationParameters = new HashSet<TB_LocationParameter>();
        }

        public long Id { get; set; }
        public long ManHoursByUser { get; set; }
        public int AbsenceTolerance { get; set; }

        public virtual ICollection<TB_LocationParameter> TB_LocationParameters { get; set; }
    }
}
