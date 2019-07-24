using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CCM.Entity.Mappings
{
    public class PatientDetailMapping : EntityTypeConfiguration<PatientDetail>
    {
        public PatientDetailMapping()
        {
            HasRequired(h => h.PatientInformation).WithMany(d => d.Details).HasForeignKey(h => h.PatientID).WillCascadeOnDelete(false);
        }
    }
}
