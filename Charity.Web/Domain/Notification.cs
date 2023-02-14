using System.Collections.Generic;

namespace Charity.Web.Domain
{
    public class Notification : Entity
    {
        public long Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public virtual ICollection<UserNotification> Users { get; set; } = new List<UserNotification>();
    }
}