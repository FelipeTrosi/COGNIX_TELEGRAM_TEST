using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Checklist_StepResult_View
    {
        public long Id { get; set; }
        public DateTime? DateTime { get; set; }
        public int? BatchSize { get; set; }
        public int? BatchCount { get; set; }
        public int? VisualStatus { get; set; }
        public string Tag { get; set; }
        public string EvidenceText { get; set; }
        public string EvidenceFileId { get; set; }
        public long? ChecklistStepResultId { get; set; }

        public virtual TB_Checklist_StepResult ChecklistStepResult { get; set; }
    }
}
