using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Assistance_Request
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public int Type { get; set; }
        public string Occurrence { get; set; }
        public string Action { get; set; }
        public DateTime RequestDateTime { get; set; }
        public DateTime? RecognizedDateTime { get; set; }
        public DateTime? FinishedDateTime { get; set; }
        public int? Status { get; set; }
        public long? UserRequestId { get; set; }
        public long? UserRecognizedId { get; set; }
        public long? UserFinishedId { get; set; }
        public long? WorkstationId { get; set; }

        public virtual TB_User UserFinished { get; set; }
        public virtual TB_User UserRecognized { get; set; }
        public virtual TB_User UserRequest { get; set; }
        public virtual TB_Workstation Workstation { get; set; }
    }
}
