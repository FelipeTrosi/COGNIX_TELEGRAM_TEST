using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Checklist_Result_Workstation
    {
        public TB_Checklist_Result_Workstation()
        {
            TB_Checklist_StepResults = new HashSet<TB_Checklist_StepResult>();
        }

        public long Id { get; set; }
        public string SerialNumber { get; set; }
        public DateTime? StartedDateTime { get; set; }
        public DateTime? FinishedDateTime { get; set; }
        public int? Status { get; set; }
        public int ChecklistType { get; set; }
        public string ChecklistCode { get; set; }
        public string ChecklistName { get; set; }
        public string ChecklistId { get; set; }
        public long? WorkstationId { get; set; }
        public long? OrderProductionId { get; set; }
        public long? UserId { get; set; }

        public virtual TB_Order_Production OrderProduction { get; set; }
        public virtual TB_User User { get; set; }
        public virtual TB_Workstation Workstation { get; set; }
        public virtual ICollection<TB_Checklist_StepResult> TB_Checklist_StepResults { get; set; }
    }
}
