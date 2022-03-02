using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Workline_PitchTime
    {
        public long Id { get; set; }
        public TimeSpan PitchTime { get; set; }
        public long WorklineId { get; set; }
    }
}
