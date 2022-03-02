using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Workbox
    {
        public TB_Workbox()
        {
            TB_Workstations = new HashSet<TB_Workstation>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int Status { get; set; }
        public long WorklineId { get; set; }

        public virtual TB_Workline Workline { get; set; }
        public virtual ICollection<TB_Workstation> TB_Workstations { get; set; }
    }
}
