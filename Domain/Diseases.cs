using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Diseases
    {
        [Key]
        public int DiseaseId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string sideEffect { get; set; }
        
        [StringLength(20)]
        public string vaccineName { get; set; }
        
        public ICollection<Checking> Checking { get; set; } 
    }
}