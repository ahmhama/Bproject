using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Child
    {
        [Key]
        public int ChildId { get; set; }

        [StringLength(20)]
        public string ChildFirstName { get; set; }

        [StringLength(20)]
        public string ChildMiniName { get; set; }

        [StringLength(20)]
        public string ChildLastName { get; set; }


        [StringLength(20)]
        public string ChildGender { get; set; }

        public DateTime ChildBirthDate { get; set; }

        [StringLength(100)]
        public string ChildAddress { get; set; }
        public int RelativeId { get; set; }
        public Relatives relatives { get; set; }
        public ICollection<Checking> Checking { get; set; } 
        public ICollection<Event> Events { get; set; } 
        public ICollection<VaccineTransaction> VaccineTransactions { get; set; } 
    }
}
