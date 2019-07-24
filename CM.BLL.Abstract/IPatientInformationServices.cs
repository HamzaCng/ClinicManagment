using CM.Entities;
using CommonType.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BLL.Abstract
{
    public interface IPatientInformationServices
    {
        ServicesResult<List<PatientInformation>> GetPatientInformation();
        ServicesResult<PatientInformation> Get(Guid PatientID);
        ServicesResult Add(PatientInformation patientInformation);
    }
}
