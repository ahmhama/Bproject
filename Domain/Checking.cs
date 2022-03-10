using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Checking    // this table compination of Child & diseases & doctors
    {
        public int ChildId { get; set; }
        public Child Child { get; set; }
        public int DiseasesId { get; set; }
        public Diseases diseases { get; set; }
        public Doctor doctor { get; set; }
        public int doctorId { get; set; }

        //-----------------------------------------------------------------------//

        [StringLength(200)]
        public string CheckResultDescription { get; set; }

        public decimal Weight { get; set; }

        public decimal Height { get; set; }

        public DateTime date { get; set; }


    }
}