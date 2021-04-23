using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events.Models
{
    public class User
    {
        [Key]
        public long UserID { get; set; }
        [Required]
        [Index("IX_Names", 1, IsUnique = true)]
        [MaxLength(40, ErrorMessage = "Name cannot be more than 40 characters")]
        [MinLength(2, ErrorMessage = "Name must be more than a single character")]
        public string UserName { get; set; }
        [Required]
        [Index("IX_Names", 2, IsUnique = true)]
        [MaxLength(40, ErrorMessage = "Email cannot be more than 40 characters")]
        [MinLength(2, ErrorMessage = "Email must be more than a single character")]
        public string UserEmail { get; set; }
        public IEnumerable<Interest> UserInterests { get; set; }
        public short PersonCount { get; set; }
        public Boolean Admin { get; set; }
        public Boolean Host { get; set; }
        public string UserCode { get; set; } // join code

    }
}
