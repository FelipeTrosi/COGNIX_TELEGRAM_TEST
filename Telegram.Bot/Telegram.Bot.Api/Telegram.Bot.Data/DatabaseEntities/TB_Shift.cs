using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Shift
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? AvailableTime { get; set; }
        public string StartedHour { get; set; }
        public string FinishedHour { get; set; }
        public string IntervalStartTime { get; set; }
        public string IntervalFinishedTime { get; set; }
        public int IsActived { get; set; }
    }
}
