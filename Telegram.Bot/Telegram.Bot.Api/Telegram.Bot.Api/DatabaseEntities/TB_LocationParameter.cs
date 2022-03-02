using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_LocationParameter
    {
        public long Id { get; set; }
        public long AvaliableParameterId { get; set; }
        public long MaintenanceParameterId { get; set; }
        public long ManPowerParameterId { get; set; }
        public long ProductionParameterId { get; set; }
        public long PerfomanceParameterId { get; set; }
        public int IsActived { get; set; }

        public virtual TB_AvaliableParameter AvaliableParameter { get; set; }
        public virtual TB_MaintenanceParameter MaintenanceParameter { get; set; }
        public virtual TB_ManPowerParameter ManPowerParameter { get; set; }
        public virtual TB_PerformanceParameter PerfomanceParameter { get; set; }
        public virtual TB_ProductionParameter ProductionParameter { get; set; }
    }
}
