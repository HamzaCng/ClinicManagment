using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Entities
{
    public class DateInformation : EntityBase
    {
        public DateTime Date { get; set; }
        public string Hour { get; set; }
        public string Department { get; set; }
        public byte StatusEnum { get; set; }
        public byte PaidEnum { get; set; }

        public Guid PatientID { get; set; }
        public Guid DoctorID { get; set; }


        public PatientInformation PatientInformation { get; set; }
        public DoctorInformation DoctorInformation { get; set; }
    }
}
