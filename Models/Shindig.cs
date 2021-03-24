using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Events.Models
{
    public class Shindig
    {
        public long ShindigID { get; set; }
        public DateTime DateOfEvent { get; set; }
        public short Openings { get; set; }
        public string ShindigName { get; set; }
        public string ShindigType { get; set; }
        public string ShindigDescription { get; set; }

    }
}
