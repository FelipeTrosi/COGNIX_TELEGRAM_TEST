using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Workflow_Result_StatusLog
    {
        public long Id { get; set; }
        public int Status { get; set; }
        public DateTime DateTime { get; set; }
        public long UserId { get; set; }
        public long WorkflowResultId { get; set; }

        public virtual TB_User User { get; set; }
        public virtual TB_Workflow_Result WorkflowResult { get; set; }
    }
}
