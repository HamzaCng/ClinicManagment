using CM.BLL.Abstract;
using CM.Entities;
using CommonType.Classes;
using CommonType.Enums;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BLL
{
    public class PatientInformationServices : IPatientInformationServices
    {
        IUnitOfWork _uow;
        public PatientInformationServices(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public ServicesResult Add(PatientInformation patientInformation)
        {
            patientInformation.ID = Guid.NewGuid();
            _uow.GetRepository<PatientInformation>().Add(patientInformation);
            int ess = _uow.Save();
            if (ess > 0)
            {
                return new ServicesResult("Kayıt başarılıdır", ResultState.Success);
            }
            return new ServicesResult("Beklenmedik bir hata oluştu.", ResultState.Error);
        }

        public ServicesResult<PatientInformation> Get(Guid PatientID)
        {
            throw new NotImplementedException();
        }

        public ServicesResult<List<PatientInformation>> GetPatientInformation()
        {
            List<PatientInformation> patientInformations = _uow.GetRepository<PatientInformation>().GetList();
            return new ServicesResult<List<PatientInformation>>("Okuma Başarılı.", ResultState.Success, patientInformations);
        }
    }
}
