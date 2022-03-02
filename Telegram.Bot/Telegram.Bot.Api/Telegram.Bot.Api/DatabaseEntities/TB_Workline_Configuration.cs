using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Workline_Configuration
    {
        public long Id { get; set; }
        public long TaktTime { get; set; }
        public int ManualModeForced { get; set; }
        public int? QtyProductionExpected { get; set; }
        public int? QtyProductionRealized { get; set; }
        public long WorklineId { get; set; }
        public long? DepartmentId { get; set; }
        public int ForceSequence { get; set; }

        public virtual TB_Department Department { get; set; }
        public virtual TB_Workline Workline { get; set; }
    }
}
