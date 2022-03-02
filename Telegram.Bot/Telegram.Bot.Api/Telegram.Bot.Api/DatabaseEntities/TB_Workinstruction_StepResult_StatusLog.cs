using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Workinstruction_StepResult_StatusLog
    {
        public long Id { get; set; }
        public int Status { get; set; }
        public DateTime DateTime { get; set; }
        public long UserId { get; set; }
        public long WorkinstructionStepResultId { get; set; }

        public virtual TB_User User { get; set; }
        public virtual TB_Workinstruction_StepResult WorkinstructionStepResult { get; set; }
    }
}
