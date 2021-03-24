using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Events.Models
{
    public class Interest
    {
        [Key]
        public long InterestID { get; set; }
        [Required]
        public string InterestName { get; set; }
        [Required]
        public bool InPerson { get; set; }
        public Nullable<long> UserID { get; set; } //Set null to get list?
    }
}
