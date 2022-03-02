using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Production_Loss
    {
        public TB_Production_Loss()
        {
            TB_Production_Loss_Records = new HashSet<TB_Production_Loss_Record>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public long? ProductionLossTypeId { get; set; }
        public int Status { get; set; }

        public virtual TB_Production_Loss_Type ProductionLossType { get; set; }
        public virtual ICollection<TB_Production_Loss_Record> TB_Production_Loss_Records { get; set; }
    }
}
