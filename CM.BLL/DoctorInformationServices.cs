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
    public class DoctorInformationServices : IDoctorInformationServices
    {
        IUnitOfWork _uow;
        public DoctorInformationServices(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public ServicesResult Add(DoctorInformation doctorInformation)
        {
            doctorInformation.ID = Guid.NewGuid();
            _uow.GetRepository<DoctorInformation>().Add(doctorInformation);
            int ess = _uow.Save();

            if (ess > 0)
            {
                return new ServicesResult("Kayıt işlemi başarılı.", ResultState.Success);
            }

            return new ServicesResult("Bir hata nedeniyle kayıt gerçekleşmedi.", ResultState.Error);
        }
        
        public ServicesResult<DoctorInformation> Get(Guid DoctorID)
        {
            throw new NotImplementedException();
        }

        public ServicesResult<List<DoctorInformation>> GetDoctorInformation()
        {
            List<DoctorInformation> doctorInformations = _uow.GetRepository<DoctorInformation>().GetList();
            return new ServicesResult<List<DoctorInformation>>("Okuma işlemei başarılı.", ResultState.Success, doctorInformations);
        }
    }
}
