using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Workinstruction_StepResult_Test
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal MinValue { get; set; }
        public decimal Value { get; set; }
        public decimal MaxValue { get; set; }
        public int ExpectedStatus { get; set; }
        public int CollectedStatus { get; set; }
        public string Unit { get; set; }
        public long WorkinstructionStepResultId { get; set; }

        public virtual TB_Workinstruction_StepResult WorkinstructionStepResult { get; set; }
    }
}
