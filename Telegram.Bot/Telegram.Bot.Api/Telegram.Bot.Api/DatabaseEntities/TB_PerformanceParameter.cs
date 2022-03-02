using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_PerformanceParameter
    {
        public TB_PerformanceParameter()
        {
            TB_LocationParameters = new HashSet<TB_LocationParameter>();
        }

        public long Id { get; set; }
        public long PerfomedOEEShift { get; set; }

        public virtual ICollection<TB_LocationParameter> TB_LocationParameters { get; set; }
    }
}
