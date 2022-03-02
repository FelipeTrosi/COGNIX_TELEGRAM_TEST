using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Order
    {
        public TB_Order()
        {
            TB_Order_Partnumbers = new HashSet<TB_Order_Partnumber>();
            TB_Order_Productions = new HashSet<TB_Order_Production>();
            TB_Order_StatusLogs = new HashSet<TB_Order_StatusLog>();
        }

        public long Id { get; set; }
        public long? ProductId { get; set; }
        public long? ClientId { get; set; }
        public int IsCKD { get; set; }
        public int IsPriority { get; set; }
        public int IsPrototype { get; set; }
        public string OrderNumber { get; set; }
        public long? OrderSequence { get; set; }
        public DateTime? RequestDate { get; set; }
        public int? QtyExpected { get; set; }
        public int? QtyReleased { get; set; }
        public int Status { get; set; }
        public string RackCode { get; set; }
        public string RackPosition { get; set; }
        public string SalesOrder { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public string VINNumber { get; set; }
        public string SerialNumber { get; set; }
        public int Source { get; set; }

        public virtual TB_Client Client { get; set; }
        public virtual TB_Product Product { get; set; }
        public virtual ICollection<TB_Order_Partnumber> TB_Order_Partnumbers { get; set; }
        public virtual ICollection<TB_Order_Production> TB_Order_Productions { get; set; }
        public virtual ICollection<TB_Order_StatusLog> TB_Order_StatusLogs { get; set; }
    }
}
