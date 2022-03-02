using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Tool_Automated
    {
        public TB_Tool_Automated()
        {
            TB_Tools = new HashSet<TB_Tool>();
        }

        public long Id { get; set; }
        public int EnableVC { get; set; }
        public string Classifier { get; set; }
        public double XPosition { get; set; }
        public double YPosition { get; set; }

        public virtual ICollection<TB_Tool> TB_Tools { get; set; }
    }
}
