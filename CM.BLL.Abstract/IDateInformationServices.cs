using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.Entities;
using CommonType.Classes;

namespace CM.BLL.Abstract
{
    public interface IDateInformationServices
    {
        ServicesResult<List<DateInformation>> GetDateInformation();
        ServicesResult<DateInformation> Get(Guid DateInformationID);
        ServicesResult Add(DateInformation dateInformation);
    }
}
