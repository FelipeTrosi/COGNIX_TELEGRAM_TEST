using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Workflow_Result
    {
        public TB_Workflow_Result()
        {
            TB_QualityWorkplan_StepResults = new HashSet<TB_QualityWorkplan_StepResult>();
            TB_Workflow_Result_StatusLogs = new HashSet<TB_Workflow_Result_StatusLog>();
            TB_Workinstruction_StepResults = new HashSet<TB_Workinstruction_StepResult>();
        }

        public long Id { get; set; }
        public long UserId { get; set; }
        public long WorkstationId { get; set; }
        public string WorkflowId { get; set; }
        public int WorkflowRevision { get; set; }
        public string InstructionId { get; set; }
        public int InstructionType { get; set; }
        public int InstructionRevision { get; set; }
        public int TaskNumber { get; set; }
        public string OperationId { get; set; }
        public DateTime? StartedDateTime { get; set; }
        public DateTime? FinishedDateTime { get; set; }
        public long ProductionId { get; set; }
        public int Status { get; set; }

        public virtual TB_Order_Production Production { get; set; }
        public virtual TB_User User { get; set; }
        public virtual TB_Workstation Workstation { get; set; }
        public virtual ICollection<TB_QualityWorkplan_StepResult> TB_QualityWorkplan_StepResults { get; set; }
        public virtual ICollection<TB_Workflow_Result_StatusLog> TB_Workflow_Result_StatusLogs { get; set; }
        public virtual ICollection<TB_Workinstruction_StepResult> TB_Workinstruction_StepResults { get; set; }
    }
}
