using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using CM.BLL.Abstract;
using CM.DataAccessLayer;
using Core.DataAccess.SqlServer.EntityFramework;
using Ninject.Modules;

namespace CM.BLL.IOC.Module
{
    public class BLLModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IDoctorInformationServices>().To<DoctorInformationServices>();
            Bind<IPatientDetailServices>().To<PatientDetailServices>();
            Bind<IPatientInformationServices>().To<PatientInformationServices>();
            Bind<IDateInformationServices>().To<DateInformationServices>();

            List<INinjectModule> modules = new List<INinjectModule>();
            modules.Add(new DalModule());
            Kernel.Load(modules);
        }
    }
}
