using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Department
    {
        public TB_Department()
        {
            TB_Users = new HashSet<TB_User>();
            TB_Workline_Configurations = new HashSet<TB_Workline_Configuration>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public int IsActived { get; set; }

        public virtual ICollection<TB_User> TB_Users { get; set; }
        public virtual ICollection<TB_Workline_Configuration> TB_Workline_Configurations { get; set; }
    }
}
