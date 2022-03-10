using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [StringLength(20)]
        public string firstName { get; set; }

        [StringLength(10)]
        public string lastName { get; set; }

        [StringLength(20)]
        public string gender { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(20)]
        public string number { get; set; }

        [StringLength(20)]
        public string Email { get; set; }

        [StringLength(50)]
        public string specilization { get; set; }
        public int HealthOfficeId { get; set; }
        public HealthOffice HealthOffices { get; set; }
        public ICollection<Checking> Checking { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<VaccineTransaction> VaccineTransaction { get; set; }
    }
}