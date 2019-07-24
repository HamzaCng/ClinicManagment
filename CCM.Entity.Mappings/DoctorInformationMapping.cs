using CM.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCM.Entity.Mappings
{
    public class DoctorInformationMapping : EntityTypeConfiguration<DoctorInformation>
    {
        public DoctorInformationMapping()
        {
            Property(d => d.TC).HasMaxLength(11).IsRequired();
            Property(d => d.FirstName).HasMaxLength(30).IsRequired();
            Property(d => d.LastName).HasMaxLength(30).IsRequired();
            Property(d => d.GenderEnums).IsRequired();
            Property(d => d.Phone).HasMaxLength(11).IsRequired();
            Property(d => d.Email).HasMaxLength(50).IsRequired();
            Property(d => d.Department).HasMaxLength(30).IsRequired();
            Property(d => d.Fee).IsRequired();

            HasMany(r => r.Dates).WithRequired(d => d.DoctorInformation).HasForeignKey(d => d.DoctorID).WillCascadeOnDelete(false);
        }
    }
}
