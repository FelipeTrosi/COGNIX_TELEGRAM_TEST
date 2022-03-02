using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_AvaliableParameter
    {
        public TB_AvaliableParameter()
        {
            TB_LocationParameters = new HashSet<TB_LocationParameter>();
        }

        public long Id { get; set; }
        public long TotalWorkDays { get; set; }

        public virtual ICollection<TB_LocationParameter> TB_LocationParameters { get; set; }
    }
}
