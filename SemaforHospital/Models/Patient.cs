using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semafor_Hospital_Registrastion_System.Models
{
    public class Patient
    {
        public int? id { get; set; }

        public long id_no { get; set; }
        public string name_surname { get; set; }
        public DateTime birth_date { get; set; }
        public List<Visit> Visits { get; set; } 




    }
}
