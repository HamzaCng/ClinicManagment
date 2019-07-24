using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CM.DataAccessLayer
{
    public class DalModule : NinjectModule
    {   
        public override void Load()
        {
            Kernel.Bind<DbContext>().To<ClinicManagementDbContext>();
        }
    }
}
