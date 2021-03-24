using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Events.Models
{
    public class Participant
    {
        public long ParticipantID { get; set; }
        public long ShindigID { get; set; }
        public long UserID { get; set; }
    }
}
