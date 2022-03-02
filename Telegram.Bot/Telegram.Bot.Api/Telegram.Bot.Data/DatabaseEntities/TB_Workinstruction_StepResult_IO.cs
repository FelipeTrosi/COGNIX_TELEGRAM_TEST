using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Workinstruction_StepResult_IO
    {
        public long Id { get; set; }
        public long TagId { get; set; }
        public string Value { get; set; }
        public DateTime DateTime { get; set; }
        public long WorkinstructionStepResultId { get; set; }

        public virtual TB_Workinstruction_StepResult WorkinstructionStepResult { get; set; }
    }
}
