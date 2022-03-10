using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class VaccineCamping
    {
        [Key]
        public int VaccineCampingId { get; set; }


        [StringLength(50)]
        public string VaccineCampingName { get; set; }

        [StringLength(200)]
        public string VaccineCampingDescription { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        [ForeignKey("MinistryAdministrator")]
        public int adminId { get; set; }

        public MinistryAdministrator MinistryAdministrators { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}