using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CCM.Entity.Mappings
{
    public class DateInformationMapping : EntityTypeConfiguration<DateInformation>
    {
        public DateInformationMapping()
        {
            Property(r => r.Date).IsRequired();
            Property(r => r.Hour).IsRequired();
            Property(r => r.Department).IsRequired();
            Property(r => r.StatusEnum).IsRequired();
            Property(r => r.PaidEnum).IsRequired();           

            HasRequired(h => h.PatientInformation).WithMany(r => r.Dates).HasForeignKey(h => h.PatientID).WillCascadeOnDelete(false);
            HasRequired(d => d.DoctorInformation).WithMany(r => r.Dates).HasForeignKey(d => d.DoctorID).WillCascadeOnDelete(false);
        }
    }
}
