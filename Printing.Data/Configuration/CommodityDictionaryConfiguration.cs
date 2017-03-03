using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Configuration
{
    public class CommodityDictionaryConfiguration : EntityTypeConfiguration<T_CommodityDictionary>
    {
        public CommodityDictionaryConfiguration()
        {
            //ToTable("T_CommodityDictionary");
            //Property(g => g.Name).IsRequired().HasMaxLength(50);
            
        }
    }
}
