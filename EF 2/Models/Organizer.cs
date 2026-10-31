using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Models
{
    [Table("EventOrganizers")]
    public class Organizer
    {
        public int OrganizerId { get; set; }
        [Required]

        [MaxLength(100)]
        public String Name { get; set; }
        [MaxLength(150)]
        public String ? CompanyName { get; set; }
        public String  Status { get; set; }

        public OrganizerProfile OrganizerProfile { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
