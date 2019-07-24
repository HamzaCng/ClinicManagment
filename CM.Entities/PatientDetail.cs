using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Entities
{
    public class PatientDetail : EntityBase
    {
        public string Document { get; set; }
        public string Notes { get; set; }
        public string Diagnosis { get; set; }
        public Guid PatientID { get; set; }

        public PatientInformation PatientInformation { get; set; }
    }
}
