using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Equipment
    {
        public TB_Equipment()
        {
            TB_Checklist_StepResult_Codes = new HashSet<TB_Checklist_StepResult_Code>();
            TB_Checklist_StepResult_Dimensionals = new HashSet<TB_Checklist_StepResult_Dimensional>();
            TB_Checklist_StepResult_Tightenings = new HashSet<TB_Checklist_StepResult_Tightening>();
            TB_Equipment_PLC_Tags = new HashSet<TB_Equipment_PLC_Tag>();
            TB_Tools = new HashSet<TB_Tool>();
            TB_Workinstruction_StepResult_Torques = new HashSet<TB_Workinstruction_StepResult_Torque>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ServerAddress { get; set; }
        public string PortAddress { get; set; }
        public int? Protocol { get; set; }
        public int IsActived { get; set; }
        public int Type { get; set; }
        public string NetworkIP { get; set; }
        public string NetworkMask { get; set; }
        public string NetworkGateway { get; set; }
        public string NetworkPort { get; set; }
        public string NetworkMacAddress { get; set; }
        public string UnitMeasure { get; set; }
        public long? WorkstationId { get; set; }
        public long? WorklineId { get; set; }

        public virtual TB_Workline Workline { get; set; }
        public virtual TB_Workstation Workstation { get; set; }
        public virtual ICollection<TB_Checklist_StepResult_Code> TB_Checklist_StepResult_Codes { get; set; }
        public virtual ICollection<TB_Checklist_StepResult_Dimensional> TB_Checklist_StepResult_Dimensionals { get; set; }
        public virtual ICollection<TB_Checklist_StepResult_Tightening> TB_Checklist_StepResult_Tightenings { get; set; }
        public virtual ICollection<TB_Equipment_PLC_Tag> TB_Equipment_PLC_Tags { get; set; }
        public virtual ICollection<TB_Tool> TB_Tools { get; set; }
        public virtual ICollection<TB_Workinstruction_StepResult_Torque> TB_Workinstruction_StepResult_Torques { get; set; }
    }
}
