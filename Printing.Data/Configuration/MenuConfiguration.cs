using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Configuration
{
    public class MenuConfiguration : EntityTypeConfiguration<T_Menu>
    {
        public MenuConfiguration()
        {
            //ToTable("T_Menu");
            //Property(g => g.Name).IsRequired().HasMaxLength(50);
            //Property(g => g.Price).IsRequired().HasPrecision(8, 2);
            //Property(g => g.CategoryID).IsRequired();
        }
    }
}
