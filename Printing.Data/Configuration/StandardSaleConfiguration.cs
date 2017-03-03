using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Configuration
{
    public class StandardSaleConfiguration : EntityTypeConfiguration<T_StandardSale>
    {
        public StandardSaleConfiguration()
        {
            ToTable("T_StandardSale");
            //Property(g => g.Name).IsRequired().HasMaxLength(50);
            //Property(g => g.Price).IsRequired().HasPrecision(8, 2);
            //Property(g => g.CategoryID).IsRequired();
        }
    }
}
