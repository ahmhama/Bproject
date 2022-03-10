using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class HealthOffice
    {
        [Key]
        public int HealthOfficeId { get; set; } 

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(100)]
        public string address { get; set; }

        [StringLength(30)]
        public string email { get; set; }

        [StringLength(20)]
        public string number { get; set; }
        
        [ForeignKey("MinistryAdministrator")]
        public int MinisrtAdminId { get; set; }
        public MinistryAdministrator MinistryAdministrator { get; set; }
        public ICollection<Doctor> doctors { get; set; }
    }
}