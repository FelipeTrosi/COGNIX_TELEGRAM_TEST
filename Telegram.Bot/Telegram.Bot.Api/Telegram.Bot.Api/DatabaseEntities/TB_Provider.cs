using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Provider
    {
        public TB_Provider()
        {
            TB_BOMs = new HashSet<TB_BOM>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string Phone { get; set; }
        public int IsActived { get; set; }

        public virtual ICollection<TB_BOM> TB_BOMs { get; set; }
    }
}
