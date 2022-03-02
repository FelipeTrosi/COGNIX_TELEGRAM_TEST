using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Workstation
    {
        public TB_Workstation()
        {
            TB_Assistance_Requests = new HashSet<TB_Assistance_Request>();
            TB_Checklist_Result_Workstations = new HashSet<TB_Checklist_Result_Workstation>();
            TB_Equipments = new HashSet<TB_Equipment>();
            TB_Production_Loss_Records = new HashSet<TB_Production_Loss_Record>();
            TB_QualityWorkplan_StepResults = new HashSet<TB_QualityWorkplan_StepResult>();
            TB_User_SkillMatrices = new HashSet<TB_User_SkillMatrix>();
            TB_Workflow_Results = new HashSet<TB_Workflow_Result>();
            TB_Workinstruction_StepResults = new HashSet<TB_Workinstruction_StepResult>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int Status { get; set; }
        public long WorkboxId { get; set; }

        public virtual TB_Workbox Workbox { get; set; }
        public virtual ICollection<TB_Assistance_Request> TB_Assistance_Requests { get; set; }
        public virtual ICollection<TB_Checklist_Result_Workstation> TB_Checklist_Result_Workstations { get; set; }
        public virtual ICollection<TB_Equipment> TB_Equipments { get; set; }
        public virtual ICollection<TB_Production_Loss_Record> TB_Production_Loss_Records { get; set; }
        public virtual ICollection<TB_QualityWorkplan_StepResult> TB_QualityWorkplan_StepResults { get; set; }
        public virtual ICollection<TB_User_SkillMatrix> TB_User_SkillMatrices { get; set; }
        public virtual ICollection<TB_Workflow_Result> TB_Workflow_Results { get; set; }
        public virtual ICollection<TB_Workinstruction_StepResult> TB_Workinstruction_StepResults { get; set; }
    }
}
