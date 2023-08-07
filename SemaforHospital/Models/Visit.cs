using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Semafor_Hospital_Registrastion_System.Models
{
    public class Visit
    {
        [Key]
        public int? visit_id { get; set; }
        public int patient_id { get; set; }
        public DateTime visit_date { get; set; }
        public string doctor_name { get; set; }
        public string complaint { get; set; }
        public string form_of_treatment { get; set; }

        public Patient Patient { get; set; } 
    }
}
