using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Configuration
{
    public class UserRoleConfiguration : EntityTypeConfiguration<T_UserRole>
    {
        public UserRoleConfiguration()
        {
            //ToTable("T_UserRole");
            //Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
