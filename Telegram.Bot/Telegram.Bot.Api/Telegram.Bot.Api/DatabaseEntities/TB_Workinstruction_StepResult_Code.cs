using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Workinstruction_StepResult_Code
    {
        public long Id { get; set; }
        public int BatchSize { get; set; }
        public int BatchCount { get; set; }
        public string ExpectedCode { get; set; }
        public string ReadedCode { get; set; }
        public int Status { get; set; }
        public long WorkinstructionStepResultId { get; set; }

        public virtual TB_Workinstruction_StepResult WorkinstructionStepResult { get; set; }
    }
}
