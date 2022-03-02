using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_QualityWorkplan_StepResult
    {
        public TB_QualityWorkplan_StepResult()
        {
            TB_Defects = new HashSet<TB_Defect>();
            TB_QualityWorkplan_Codes = new HashSet<TB_QualityWorkplan_Code>();
            TB_QualityWorkplan_Dimensionals = new HashSet<TB_QualityWorkplan_Dimensional>();
            TB_QualityWorkplan_StepResult_StatusLogs = new HashSet<TB_QualityWorkplan_StepResult_StatusLog>();
        }

        public long Id { get; set; }
        public string WorkplanId { get; set; }
        public string StepId { get; set; }
        public int WorkplanRevision { get; set; }
        public long WorkstationId { get; set; }
        public int Type { get; set; }
        public int SubType { get; set; }
        public int Status { get; set; }
        public long UserId { get; set; }
        public DateTime? StartedDateTime { get; set; }
        public DateTime? FinishedDateTime { get; set; }
        public long WorkflowResultId { get; set; }

        public virtual TB_User User { get; set; }
        public virtual TB_Workflow_Result WorkflowResult { get; set; }
        public virtual TB_Workstation Workstation { get; set; }
        public virtual ICollection<TB_Defect> TB_Defects { get; set; }
        public virtual ICollection<TB_QualityWorkplan_Code> TB_QualityWorkplan_Codes { get; set; }
        public virtual ICollection<TB_QualityWorkplan_Dimensional> TB_QualityWorkplan_Dimensionals { get; set; }
        public virtual ICollection<TB_QualityWorkplan_StepResult_StatusLog> TB_QualityWorkplan_StepResult_StatusLogs { get; set; }
    }
}
