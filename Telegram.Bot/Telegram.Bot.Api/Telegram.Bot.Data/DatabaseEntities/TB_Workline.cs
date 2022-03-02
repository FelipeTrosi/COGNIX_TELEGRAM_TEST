using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Workline
    {
        public TB_Workline()
        {
            TB_Equipments = new HashSet<TB_Equipment>();
            TB_Workboxes = new HashSet<TB_Workbox>();
            TB_Workline_Configurations = new HashSet<TB_Workline_Configuration>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int Status { get; set; }
        public long WorkareaId { get; set; }

        public virtual TB_Wokarea Workarea { get; set; }
        public virtual ICollection<TB_Equipment> TB_Equipments { get; set; }
        public virtual ICollection<TB_Workbox> TB_Workboxes { get; set; }
        public virtual ICollection<TB_Workline_Configuration> TB_Workline_Configurations { get; set; }
    }
}
