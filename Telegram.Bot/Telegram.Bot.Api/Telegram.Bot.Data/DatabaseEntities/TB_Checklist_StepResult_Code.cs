using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Checklist_StepResult_Code
    {
        public long Id { get; set; }
        public long? ExternalId { get; set; }
        public DateTime? DateTime { get; set; }
        public int? JobNum { get; set; }
        public int? BatchSize { get; set; }
        public int? BatchCount { get; set; }
        public int? CodeToCompare { get; set; }
        public string ExpectedCode { get; set; }
        public string FormatCode { get; set; }
        public string CodeLoteInfo { get; set; }
        public int? StatusCode { get; set; }
        public string Tag { get; set; }
        public string EvidenceText { get; set; }
        public string EvidenceFileId { get; set; }
        public long? EquipamentId { get; set; }
        public long? ToolId { get; set; }
        public long? ChecklistStepResultId { get; set; }

        public virtual TB_Checklist_StepResult ChecklistStepResult { get; set; }
        public virtual TB_Equipment Equipament { get; set; }
        public virtual TB_Tool Tool { get; set; }
    }
}
