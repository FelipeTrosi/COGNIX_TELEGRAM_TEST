using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_QualityWorkplan_Dimensional
    {
        public long Id { get; set; }
        public int BatchSize { get; set; }
        public int BatchCount { get; set; }
        public double Value { get; set; }
        public int Status { get; set; }
        public long QualityWorkplanStepResultId { get; set; }

        public virtual TB_QualityWorkplan_StepResult QualityWorkplanStepResult { get; set; }
    }
}
