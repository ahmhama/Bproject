using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Event
    {

        public int ChildId { get; set; }
        public Child Child { get; set; }
        public int doctorId { get; set; }
        public Doctor doctor { get; set; }
        public int VaccineCampingId { get; set; }
        public VaccineCamping VaccineCamping { get; set; }

        public DateTime Date { get; set; }
    }
}