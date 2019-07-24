using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Entities
{
    public class PatientInformation : EntityBase
    {
        public string TC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte GenderEnums { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<PatientDetail> Details { get; set; } 
        public ICollection<DateInformation> Dates { get; set; }
    }
}
