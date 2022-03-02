using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_ProductionParameter
    {
        public TB_ProductionParameter()
        {
            TB_LocationParameters = new HashSet<TB_LocationParameter>();
        }

        public long Id { get; set; }
        public double TaktTime { get; set; }
        public long PlannedShift { get; set; }

        public virtual ICollection<TB_LocationParameter> TB_LocationParameters { get; set; }
    }
}
