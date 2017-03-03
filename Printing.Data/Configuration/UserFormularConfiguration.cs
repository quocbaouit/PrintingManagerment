using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Configuration
{
    public class UserFormularConfiguration : EntityTypeConfiguration<T_UserFormular>
    {
        public UserFormularConfiguration()
        {
            ToTable("T_UserFormular");
           // Property(c => c./Name).IsRequired().HasMaxLength(50);
        }
    }
}
