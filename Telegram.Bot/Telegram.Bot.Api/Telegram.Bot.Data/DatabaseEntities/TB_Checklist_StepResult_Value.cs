using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Checklist_StepResult_Value
    {
        public long Id { get; set; }
        public int SampleNumber { get; set; }
        public string SampleValue { get; set; }
        public long? ChecklistStepResultId { get; set; }

        public virtual TB_Checklist_StepResult ChecklistStepResult { get; set; }
    }
}
