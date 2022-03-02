using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Notification_Message
    {
        public long Id { get; set; }
        public long CreatedUserId { get; set; }
        public string MessageText { get; set; }
        public long MentionedUserId { get; set; }
        public DateTime DateTime { get; set; }
        public int StatusMessage { get; set; }
        public int SourceId { get; set; }
        public long ExternalId { get; set; }

        public virtual TB_User CreatedUser { get; set; }
        public virtual TB_User MentionedUser { get; set; }
    }
}
