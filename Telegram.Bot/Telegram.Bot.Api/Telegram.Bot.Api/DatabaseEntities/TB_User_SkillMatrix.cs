using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_User_SkillMatrix
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long? WorkstationId { get; set; }
        public long? ProductId { get; set; }
        public int LevelAcess { get; set; }

        public virtual TB_Product Product { get; set; }
        public virtual TB_User User { get; set; }
        public virtual TB_Workstation Workstation { get; set; }
    }
}
