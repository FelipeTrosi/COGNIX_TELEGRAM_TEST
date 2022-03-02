using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_MaintenanceParameter
    {
        public TB_MaintenanceParameter()
        {
            TB_LocationParameters = new HashSet<TB_LocationParameter>();
        }

        public long Id { get; set; }
        public long MTBF { get; set; }
        public long MTTR { get; set; }
        public long ManHoursByUser { get; set; }

        public virtual ICollection<TB_LocationParameter> TB_LocationParameters { get; set; }
    }
}
