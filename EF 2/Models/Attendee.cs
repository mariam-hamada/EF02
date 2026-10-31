using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Models
{
    public class Attendee
    {
        public int AttendeeId { get; set; }
        [Required]
        [MaxLength(150)]
        public String FullName { get; set; }
        [Required]
        [MaxLength(200)]
        public String  Email { get; set; }
        [Required]
        [MaxLength(150)]
        public String Street { get; set; }
        [Required]
        [MaxLength(100)]
        public String City { get; set; }
        [Required]
        [MaxLength(100)]
        public String Country { get; set; }
        [Column("ZipCode")]
        [Required]
        [MaxLength(20)]
        public String PostalCode { get; set; }

        [NotMapped]
        public string FullAddress =>
             $"{Street}, {City}, {Country}, {PostalCode}";
        public Badge Badge { get; set; }
    }
}
