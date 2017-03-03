using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Configuration
{
    public class FeatureConfiguration : EntityTypeConfiguration<T_Feature>
    {
        public FeatureConfiguration()
        {
           // ToTable("T_Feature");
           // Property(g => g.Name).IsRequired().HasMaxLength(50);
           //// Property(g => g.Price).IsRequired().HasPrecision(8, 2);
           // Property(g => g.CategoryID).IsRequired();
        }
    }
}
