using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class VaccineTransaction
    {

        public int ChildId { get; set; }

        public Child Child { get; set; }

        public int doctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int VaccineId { get; set; }
        public Vaccine Vaccine { get; set; }

        public DateTime Date { get; set; }

        public DateTime DueDate { get; set; }
    }
}