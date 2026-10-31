using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Models
{
    public class OrganizerProfile
    {
        public int OrganizerProfileId { get; set; }
        public String Biography { get; set; }
        public String Website { get; set; }
        public String Logo { get; set; }
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }

    }
}
