using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Workinstruction_StepResult_Torque
    {
        public long Id { get; set; }
        public long TighteningId { get; set; }
        public DateTime DateTime { get; set; }
        public long TighteningStatus { get; set; }
        public int JobNumber { get; set; }
        public int PsetNumber { get; set; }
        public string Tags { get; set; }
        public long EquipmentId { get; set; }
        public long ToolId { get; set; }
        public decimal TorqueMin { get; set; }
        public decimal TorqueValue { get; set; }
        public decimal TorqueMax { get; set; }
        public decimal AngleMin { get; set; }
        public decimal AngleValue { get; set; }
        public decimal AngleMax { get; set; }
        public string BoltId { get; set; }
        public long WorkinstructionStepResultId { get; set; }

        public virtual TB_Equipment Equipment { get; set; }
        public virtual TB_Tool Tool { get; set; }
        public virtual TB_Workinstruction_StepResult WorkinstructionStepResult { get; set; }
    }
}
