using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Relatives
    {
        [Key]
        public int RelativeId { get; set; }

        [StringLength(20)]
        public string firstName { get; set; }

        [StringLength(20)]
        public string lastName { get; set; }
        
        [StringLength(20)]
        public string gender { get; set; }
        
        [StringLength(50)]
        public string address { get; set; }

        [StringLength(20)]
        public string number { get; set; }

        [StringLength(30)]
        public string email { get; set; }
        
        public List<Child> Children { get; set; }

    }
}