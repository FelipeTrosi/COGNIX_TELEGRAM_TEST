using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Retentive
    {
        public long Id { get; set; }
        public long WorkstationId { get; set; }
        public long ProductionId { get; set; }
        public long UserId { get; set; }
        public long ProductionLossRecordId { get; set; }
        public int? ProductionTime { get; set; }
        public int? StopTime { get; set; }
        public int? Status { get; set; }
    }
}
