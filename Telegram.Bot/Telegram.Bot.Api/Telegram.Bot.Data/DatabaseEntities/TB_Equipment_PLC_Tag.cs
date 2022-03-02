using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Equipment_PLC_Tag
    {
        public long Id { get; set; }
        public string TagName { get; set; }
        public string Address { get; set; }
        public int DataType { get; set; }
        public long? EquipamentId { get; set; }

        public virtual TB_Equipment Equipament { get; set; }
    }
}
