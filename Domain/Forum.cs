using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Web.Domain
{
    public class Forum : Entity
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        // organization.Name.ToLower().Replace(" ", "-");
        [ScaffoldColumn(false)]
        public string Slug { get; set; } = string.Empty;

        [DataType(DataType.Text)]
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<Topic> Topics { get; set; } = new List<Topic>();
    }
}