using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_BOM
    {
        public TB_BOM()
        {
            InverseParentMaterial = new HashSet<TB_BOM>();
            TB_Product_BOMs = new HashSet<TB_Product_BOM>();
        }

        public long Id { get; set; }
        public long? ProviderId { get; set; }
        public long? ParentMaterialId { get; set; }
        public int Level { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public float Qty { get; set; }
        public int PurchaseMode { get; set; }
        public int? RevisionNumber { get; set; }
        public int? IsActived { get; set; }

        public virtual TB_BOM ParentMaterial { get; set; }
        public virtual TB_Provider Provider { get; set; }
        public virtual ICollection<TB_BOM> InverseParentMaterial { get; set; }
        public virtual ICollection<TB_Product_BOM> TB_Product_BOMs { get; set; }
    }
}
