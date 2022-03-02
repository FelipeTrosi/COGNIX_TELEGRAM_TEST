using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Graph
    {
        public long GraphID { get; set; }
        public long TighteningID { get; set; }
        public long SystemID { get; set; }
        public DateTime TimeStamp { get; set; }
        public long GraphType { get; set; }
        public float SampleTime { get; set; }
        public string GraphValues { get; set; }
        public long? BoltID { get; set; }
        public int? CURVAPADRAO { get; set; }
    }
}
