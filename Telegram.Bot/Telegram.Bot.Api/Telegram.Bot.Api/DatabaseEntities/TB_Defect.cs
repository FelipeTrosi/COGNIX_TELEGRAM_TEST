using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Defect
    {
        public long Id { get; set; }
        public long OrderProductionId { get; set; }
        public long UserId { get; set; }
        public DateTime DateTime { get; set; }
        public string Comment { get; set; }
        public long WorkplanResultStepId { get; set; }
        public long DefectTypeId { get; set; }

        public virtual TB_Defect_Type DefectType { get; set; }
        public virtual TB_Order_Production OrderProduction { get; set; }
        public virtual TB_User User { get; set; }
        public virtual TB_QualityWorkplan_StepResult WorkplanResultStep { get; set; }
    }
}
