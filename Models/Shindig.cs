using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Events.Models
{
    public class Shindig
    {
        [Key]
        public long ShindigID { get; set; }
        [Required]
        public DateTime DateOfEvent { get; set; }
        [Required]
        public short Openings { get; set; }
        public short AvailableSpots { get; set; }
        [Required]
        public string ShindigName { get; set; }
        public string ShindigType { get; set; } //I think this is the interest.
        public string ShindigDescription { get; set; }
        public long interestID { get; set; }
        public virtual Interest interest { get; set; }
        public long OwnerID { get; set; }
        public virtual User host { get; set; }
        public string Location { get; set; }

    }
}
