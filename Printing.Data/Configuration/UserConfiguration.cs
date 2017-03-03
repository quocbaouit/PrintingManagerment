using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<T_User>
    {
        public UserConfiguration()
        {
            ToTable("T_User");
            Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
