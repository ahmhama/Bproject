using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Vaccine
    {
        [Key]
        public int VaccineId { get; set; }

        [StringLength(30)]
        public string VaccineAge { get; set; }
        public DateTime DateTime { get; set; }

        [StringLength(50)]
        public string VaccineName { get; set; }

        [StringLength(50)]
        public string diseasesName { get; set; }

        [StringLength(50)]
        public string DoseRoute { get; set; }

        public ICollection<VaccineTransaction> VaccineTranasaction { get; set; }
    }
}