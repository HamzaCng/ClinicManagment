using CM.Entities;
using CommonType.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BLL.Abstract
{
    public interface IPatientDetailServices
    {
        ServicesResult<List<PatientDetail>> GetPatientDetail();
        ServicesResult<PatientDetail> Get(Guid PatientID);
        ServicesResult Add(PatientDetail patientDetail);
    }
}
