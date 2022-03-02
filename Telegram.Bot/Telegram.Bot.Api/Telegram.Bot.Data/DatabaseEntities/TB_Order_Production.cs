using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Order_Production
    {
        public TB_Order_Production()
        {
            TB_Checklist_Result_Workstations = new HashSet<TB_Checklist_Result_Workstation>();
            TB_Defects = new HashSet<TB_Defect>();
            TB_Order_Production_StatusLogs = new HashSet<TB_Order_Production_StatusLog>();
            TB_Production_Loss_Records = new HashSet<TB_Production_Loss_Record>();
            TB_Workflow_Results = new HashSet<TB_Workflow_Result>();
        }

        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? OrderId { get; set; }
        public string SerialNumber { get; set; }
        public long? ProductionSequence { get; set; }
        public DateTime? StartedDateTime { get; set; }
        public DateTime? FinishedDateTime { get; set; }
        public int Status { get; set; }
        public int? QtyProduced { get; set; }
        public DateTime? ScheduleDate { get; set; }

        public virtual TB_Order Order { get; set; }
        public virtual TB_User User { get; set; }
        public virtual ICollection<TB_Checklist_Result_Workstation> TB_Checklist_Result_Workstations { get; set; }
        public virtual ICollection<TB_Defect> TB_Defects { get; set; }
        public virtual ICollection<TB_Order_Production_StatusLog> TB_Order_Production_StatusLogs { get; set; }
        public virtual ICollection<TB_Production_Loss_Record> TB_Production_Loss_Records { get; set; }
        public virtual ICollection<TB_Workflow_Result> TB_Workflow_Results { get; set; }
    }
}
