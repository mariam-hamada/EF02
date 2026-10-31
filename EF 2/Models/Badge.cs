using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Models
{
    public class Badge
    {
        public int BadgeId { get; set; }
        public int BadgeNmber { get; set; }
        public DateTime IssueDate { get; set; }
        public String Tier { get; set; }
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
    }
}
