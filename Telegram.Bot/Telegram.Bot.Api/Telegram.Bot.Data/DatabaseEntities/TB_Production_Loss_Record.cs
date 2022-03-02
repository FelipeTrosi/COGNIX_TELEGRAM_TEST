using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Production_Loss_Record
    {
        public long Id { get; set; }
        public string SerialNumber { get; set; }
        public DateTime? StartedDateTime { get; set; }
        public DateTime? FinishedDateTime { get; set; }
        public long ProductionLossId { get; set; }
        public long UserId { get; set; }
        public long WorkstationId { get; set; }
        public long? ProductionId { get; set; }
        public int? Status { get; set; }
        public long? Duration { get; set; }

        public virtual TB_Order_Production Production { get; set; }
        public virtual TB_Production_Loss ProductionLoss { get; set; }
        public virtual TB_User User { get; set; }
        public virtual TB_Workstation Workstation { get; set; }
    }
}
