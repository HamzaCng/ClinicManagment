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
    public class PatientDetailServices : IPatientDetailServices
    {
        IUnitOfWork _uow;
        public PatientDetailServices(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public ServicesResult Add(PatientDetail patientDetail)
        {
            patientDetail.ID = Guid.NewGuid();
            _uow.GetRepository<PatientDetail>().Add(patientDetail);
            int ess = _uow.Save();
            if (ess > 0)
            {
                return new ServicesResult("Kayıt başarılıdır", ResultState.Success);
            }
            return new ServicesResult("Beklenmedik bir hata oluştu.", ResultState.Error);
        }

        public ServicesResult<PatientDetail> Get(Guid PatientID)
        {
            throw new NotImplementedException();
        }

        public ServicesResult<List<PatientDetail>> GetPatientDetail()
        {
            List<PatientDetail> patientDetails = _uow.GetRepository<PatientDetail>().GetList();
            return new ServicesResult<List<PatientDetail>>("Okuma işlemi başarılı.", ResultState.Success, patientDetails);            
        }
    }
}
