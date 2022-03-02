using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Schema_Measurement
    {
        public long Id { get; set; }
        public string SchemaName { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
    }
}
