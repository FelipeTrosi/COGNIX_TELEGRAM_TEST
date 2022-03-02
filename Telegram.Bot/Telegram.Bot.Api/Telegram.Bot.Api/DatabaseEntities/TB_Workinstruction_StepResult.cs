using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Workinstruction_StepResult
    {
        public TB_Workinstruction_StepResult()
        {
            TB_Workinstruction_StepResult_Codes = new HashSet<TB_Workinstruction_StepResult_Code>();
            TB_Workinstruction_StepResult_IOs = new HashSet<TB_Workinstruction_StepResult_IO>();
            TB_Workinstruction_StepResult_StatusLogs = new HashSet<TB_Workinstruction_StepResult_StatusLog>();
            TB_Workinstruction_StepResult_Tests = new HashSet<TB_Workinstruction_StepResult_Test>();
            TB_Workinstruction_StepResult_Torques = new HashSet<TB_Workinstruction_StepResult_Torque>();
        }

        public long Id { get; set; }
        public string StepId { get; set; }
        public string WorkinstructionId { get; set; }
        public int WorkinstructionRevision { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public DateTime StartedDateTime { get; set; }
        public DateTime? FinishedDateTime { get; set; }
        public long WorkstationId { get; set; }
        public long UserId { get; set; }
        public long WorkflowResultId { get; set; }

        public virtual TB_User User { get; set; }
        public virtual TB_Workflow_Result WorkflowResult { get; set; }
        public virtual TB_Workstation Workstation { get; set; }
        public virtual ICollection<TB_Workinstruction_StepResult_Code> TB_Workinstruction_StepResult_Codes { get; set; }
        public virtual ICollection<TB_Workinstruction_StepResult_IO> TB_Workinstruction_StepResult_IOs { get; set; }
        public virtual ICollection<TB_Workinstruction_StepResult_StatusLog> TB_Workinstruction_StepResult_StatusLogs { get; set; }
        public virtual ICollection<TB_Workinstruction_StepResult_Test> TB_Workinstruction_StepResult_Tests { get; set; }
        public virtual ICollection<TB_Workinstruction_StepResult_Torque> TB_Workinstruction_StepResult_Torques { get; set; }
    }
}
