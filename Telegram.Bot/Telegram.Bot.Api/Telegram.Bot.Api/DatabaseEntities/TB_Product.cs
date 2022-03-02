using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Product
    {
        public TB_Product()
        {
            TB_Orders = new HashSet<TB_Order>();
            TB_Product_BOMs = new HashSet<TB_Product_BOM>();
            TB_User_SkillMatrices = new HashSet<TB_User_SkillMatrix>();
            TB_Workflow_Products = new HashSet<TB_Workflow_Product>();
        }

        public long Id { get; set; }
        public long? ClientId { get; set; }
        public string Code { get; set; }
        public string ClientCode { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public TimeSpan? CycleTime { get; set; }
        public int RevisionNumber { get; set; }
        public int IsActived { get; set; }
        public long? ProductAuxId { get; set; }

        public virtual TB_Client Client { get; set; }
        public virtual TB_Product_Aux ProductAux { get; set; }
        public virtual ICollection<TB_Order> TB_Orders { get; set; }
        public virtual ICollection<TB_Product_BOM> TB_Product_BOMs { get; set; }
        public virtual ICollection<TB_User_SkillMatrix> TB_User_SkillMatrices { get; set; }
        public virtual ICollection<TB_Workflow_Product> TB_Workflow_Products { get; set; }
    }
}
