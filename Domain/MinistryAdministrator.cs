using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class MinistryAdministrator
    {
        [Key]
        public int adminId { get; set; }

        [StringLength(20)]
        public string firstName { get; set; }


        [StringLength(20)]
        public string lastName { get; set; }

        [StringLength(20)]
        public string gender { get; set; }

        [StringLength(20)]
        public string email { get; set; }

        [StringLength(20)]
        public string number { get; set; }

        public ICollection<HealthOffice> HealthOffices { get; set; }
        public ICollection<VaccineCamping> VaccineCamping { get; set; }    
    }
}