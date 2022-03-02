using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_MaterialLocation
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IsActived { get; set; }
    }
}
