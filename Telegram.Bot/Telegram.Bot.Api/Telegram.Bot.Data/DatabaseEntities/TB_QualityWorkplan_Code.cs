using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_QualityWorkplan_Code
    {
        public long Id { get; set; }
        public double BatchSize { get; set; }
        public int BatchCount { get; set; }
        public string CodeExpected { get; set; }
        public string CodeReaded { get; set; }
        public int Status { get; set; }
        public long QualityWorkplanStepResultId { get; set; }

        public virtual TB_QualityWorkplan_StepResult QualityWorkplanStepResult { get; set; }
    }
}
