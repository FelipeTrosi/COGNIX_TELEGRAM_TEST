using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Checklist_StepResult_Tightening
    {
        public long Id { get; set; }
        public long? ExternalId { get; set; }
        public DateTime? DateTime { get; set; }
        public string SerialNumber { get; set; }
        public int? JobNum { get; set; }
        public int? PsetNumber { get; set; }
        public string PsetName { get; set; }
        public int? BatchSize { get; set; }
        public int? BatchCount { get; set; }
        public int? Automatic { get; set; }
        public int? ExpectedTorqueStatus { get; set; }
        public string UniteMeasureTorque { get; set; }
        public float? TorqueMin { get; set; }
        public float? TorqueMax { get; set; }
        public float? TorqueValue { get; set; }
        public int? TorqueStatus { get; set; }
        public float? AngleMin { get; set; }
        public float? AngleMax { get; set; }
        public float? AngleValue { get; set; }
        public int? AngleStatus { get; set; }
        public int? TighteningStatus { get; set; }
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
