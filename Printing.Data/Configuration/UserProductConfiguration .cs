using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Configuration
{
    public class UserProductConfiguration : EntityTypeConfiguration<T_UserProduct>
    {
        public UserProductConfiguration()
        {
            //ToTable("T_UserProduct");
            //Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
