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
    public class DateInformationServices : IDateInformationServices
    {
        IUnitOfWork _uow;
        public DateInformationServices(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public ServicesResult Add(DateInformation dateInformation)
        {
            dateInformation.ID = Guid.NewGuid();
            _uow.GetRepository<DateInformation>().Add(dateInformation);
            int ess = _uow.Save();

            if(ess > 0)
            {
                return new ServicesResult("Kayıt işlemi başarılı." , ResultState.Success);     
            }

            return new ServicesResult("Bir hata nedeniyle kayıt gerçekleşmedi.", ResultState.Error);
        }

        public ServicesResult<DateInformation> Get(Guid DateInformationID)
        {
            throw new NotImplementedException();
        }

        public ServicesResult<List<DateInformation>> GetDateInformation()
        {
            List<DateInformation> dateInformations = _uow.GetRepository<DateInformation>().GetList();
            return new ServicesResult<List<DateInformation>>("Okuma işlemei başarılı.", ResultState.Success, dateInformations);
        }
    }
}
