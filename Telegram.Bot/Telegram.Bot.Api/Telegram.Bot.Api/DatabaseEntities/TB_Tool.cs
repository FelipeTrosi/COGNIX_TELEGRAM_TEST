using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Tool
    {
        public TB_Tool()
        {
            TB_Checklist_StepResult_Codes = new HashSet<TB_Checklist_StepResult_Code>();
            TB_Checklist_StepResult_Dimensionals = new HashSet<TB_Checklist_StepResult_Dimensional>();
            TB_Checklist_StepResult_Tightenings = new HashSet<TB_Checklist_StepResult_Tightening>();
            TB_Workinstruction_StepResult_Torques = new HashSet<TB_Workinstruction_StepResult_Torque>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IsActived { get; set; }
        public int? Pset { get; set; }
        public long? EquipmentId { get; set; }
        public long? ToolAutomatedId { get; set; }

        public virtual TB_Equipment Equipment { get; set; }
        public virtual TB_Tool_Automated ToolAutomated { get; set; }
        public virtual ICollection<TB_Checklist_StepResult_Code> TB_Checklist_StepResult_Codes { get; set; }
        public virtual ICollection<TB_Checklist_StepResult_Dimensional> TB_Checklist_StepResult_Dimensionals { get; set; }
        public virtual ICollection<TB_Checklist_StepResult_Tightening> TB_Checklist_StepResult_Tightenings { get; set; }
        public virtual ICollection<TB_Workinstruction_StepResult_Torque> TB_Workinstruction_StepResult_Torques { get; set; }
    }
}
