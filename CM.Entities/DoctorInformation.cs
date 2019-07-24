using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Entities
{
    public class DoctorInformation : EntityBase
    {
        public string TC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte GenderEnums { get; set; }
        public string Department { get; set; }

        public decimal Fee { get; set; } //Doktorun Seans ücreti, Muayene ücretinin ödenme kontrolü DateInformation'da Enum olarak saklanmakta.
        public string Phone { get; set; }
        public string Email { get; set; }


        public ICollection<DateInformation> Dates { get; set; }
    }
}
