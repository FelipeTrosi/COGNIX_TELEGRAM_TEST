using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_OP_Alarm
    {
        public long InsertAlarmtID { get; set; }
        public long SystemID { get; set; }
        public long GroupID { get; set; }
        public long SpindleID { get; set; }
        public DateTime TimeStamp { get; set; }
        public int AlarmStatus { get; set; }
        public string ErrorCode { get; set; }
        public int? ControllerReadyStatus { get; set; }
        public int? ToolReadyStatus { get; set; }
        public long? EventID { get; set; }
    }
}
