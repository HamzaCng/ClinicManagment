using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.Entities;
using CommonType.Classes;

namespace CM.BLL.Abstract

{
    public interface IDoctorInformationServices
    {
        ServicesResult<List<DoctorInformation>> GetDoctorInformation();
        ServicesResult<DoctorInformation> Get(Guid DoctorID);        
        ServicesResult Add(DoctorInformation doctorInformation);

   
        
    }
}
