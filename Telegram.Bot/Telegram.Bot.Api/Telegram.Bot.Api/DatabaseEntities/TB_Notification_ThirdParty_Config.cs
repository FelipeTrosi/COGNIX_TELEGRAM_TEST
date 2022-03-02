using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Notification_ThirdParty_Config
    {
        public long Id { get; set; }
        public string ThirdPartyAppName { get; set; }
        public int ThirdPartyId { get; set; }
        public long UserId { get; set; }

        public virtual TB_User User { get; set; }
    }
}
