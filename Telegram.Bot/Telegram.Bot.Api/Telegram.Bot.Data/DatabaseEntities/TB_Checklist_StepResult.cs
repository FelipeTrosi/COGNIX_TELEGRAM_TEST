using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Checklist_StepResult
    {
        public TB_Checklist_StepResult()
        {
            TB_Checklist_StepResult_Codes = new HashSet<TB_Checklist_StepResult_Code>();
            TB_Checklist_StepResult_Dimensionals = new HashSet<TB_Checklist_StepResult_Dimensional>();
            TB_Checklist_StepResult_Tightenings = new HashSet<TB_Checklist_StepResult_Tightening>();
            TB_Checklist_StepResult_Values = new HashSet<TB_Checklist_StepResult_Value>();
            TB_Checklist_StepResult_Views = new HashSet<TB_Checklist_StepResult_View>();
        }

        public long Id { get; set; }
        public string SerialNumber { get; set; }
        public DateTime? StartedDateTime { get; set; }
        public DateTime? FinishedDateTime { get; set; }
        public int? Status { get; set; }
        public int? StepType { get; set; }
        public int? StepNumber { get; set; }
        public string StepCode { get; set; }
        public string StepName { get; set; }
        public int? BatchSize { get; set; }
        public long? ChecklistResultWorkstationId { get; set; }
        public long? UserId { get; set; }

        public virtual TB_Checklist_Result_Workstation ChecklistResultWorkstation { get; set; }
        public virtual TB_User User { get; set; }
        public virtual ICollection<TB_Checklist_StepResult_Code> TB_Checklist_StepResult_Codes { get; set; }
        public virtual ICollection<TB_Checklist_StepResult_Dimensional> TB_Checklist_StepResult_Dimensionals { get; set; }
        public virtual ICollection<TB_Checklist_StepResult_Tightening> TB_Checklist_StepResult_Tightenings { get; set; }
        public virtual ICollection<TB_Checklist_StepResult_Value> TB_Checklist_StepResult_Values { get; set; }
        public virtual ICollection<TB_Checklist_StepResult_View> TB_Checklist_StepResult_Views { get; set; }
    }
}
