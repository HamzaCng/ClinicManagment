using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.Entities;
using CCM.Entity.Mappings;


namespace CM.DataAccessLayer
{
    public class ClinicManagementDbContext : DbContext
    {
        public ClinicManagementDbContext():base("server=.;database=ClinicManagmentDb;Trusted_Connection=true")
        {
                
        }

        public DbSet<DoctorInformation> DoctorInformations { get; set; }
        public DbSet<PatientInformation> PatientInformations{ get; set; }
        public DbSet<PatientDetail> PatientDetails { get; set; }
        public DbSet<DateInformation> DateInformations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DoctorInformationMapping());
            modelBuilder.Configurations.Add(new PatientInformationMapping());
            modelBuilder.Configurations.Add(new PatientDetailMapping());
            base.OnModelCreating(modelBuilder); 
        }
    }
}
