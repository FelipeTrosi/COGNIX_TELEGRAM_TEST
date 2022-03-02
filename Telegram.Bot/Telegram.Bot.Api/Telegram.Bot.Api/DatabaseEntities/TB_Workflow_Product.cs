using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Workflow_Product
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string WorkflowId { get; set; }

        public virtual TB_Product Product { get; set; }
    }
}
