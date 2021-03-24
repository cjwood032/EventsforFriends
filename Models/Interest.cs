using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Events.Models
{
    public class Interest
    {
        [Key]
        public long InterestID { get; set; }
        [Required]
        [Display(Name ="Interest")]
        public string InterestName { get; set; }
        [Required]
        [Display(Name ="In-Person Only?")]
        public bool InPerson { get; set; }
        public Nullable<long> UserID { get; set; } //Set null to get list?
    }
}
