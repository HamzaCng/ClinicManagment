using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CM.Entities;

namespace CCM.Entity.Mappings
{
    public class PatientInformationMapping : EntityTypeConfiguration<PatientInformation>
    {
        public PatientInformationMapping()
        {
            Property(h => h.TC).HasMaxLength(11).IsRequired();
            Property(h => h.FirstName).HasMaxLength(30).IsRequired();
            Property(h => h.LastName).HasMaxLength(30).IsRequired();
            Property(h => h.GenderEnums).IsRequired();
            Property(h => h.DateofBirth).IsRequired();
            Property(h => h.Phone).HasMaxLength(11).IsRequired();

            HasMany(h => h.Details).WithRequired(hb => hb.PatientInformation).HasForeignKey(h => h.PatientID).WillCascadeOnDelete(false);
            HasMany(r => r.Dates).WithRequired(hb => hb.PatientInformation).HasForeignKey(h => h.PatientID).WillCascadeOnDelete(false);
        }
    }
}
