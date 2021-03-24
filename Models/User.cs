using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Events.Models
{
    public class User
    {
        [Key]
        public long UserID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserEmail { get; set; }
        public IEnumerable<Interest> UserInterests { get; set; }
        public IEnumerable<Interest> AllInterests { get; set; }
        public Boolean Admin { get; set; }
        public Boolean Host { get; set; }
        public string UserCode { get; set; }

    }
}
