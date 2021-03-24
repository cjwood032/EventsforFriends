using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Events.Models
{
    public class Shindig
    {
        [Key]
        public long ShindigID { get; set; }
        [Required]
        [Display(Name = "Date")]
        public DateTime DateOfEvent { get; set; }
        [Required]
        [Display(Name = "Total Spots")]
        public short Openings { get; set; }
        [Display(Name = "Filled Spots")]
        public short AvailableSpots { get; set; }
        [Required]
        [Display(Name ="Shindig Name")]
        public string ShindigName { get; set; }
        public string ShindigType { get; set; } //I think this is the interest.
        [Display(Name = "Shindig Description")]
        public string ShindigDescription { get; set; }
        public long interestID { get; set; }
        [Display(Name = "Shindig Type")]
        public virtual Interest Interest { get; set; }
        public long OwnerID { get; set; }
        [Display(Name = "Host Name")]
        public virtual User host { get; set; }
        public string Location { get; set; }

    }
}
