using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Web.Domain
{
    public class MeetingMember : Entity
    {
        public string MemberId { get; set; } = string.Empty;
        public virtual Member? Member { get; set; }

        public long MeetingId { get; set; }
        public virtual Meeting? Meeting { get; set; }
    }
}