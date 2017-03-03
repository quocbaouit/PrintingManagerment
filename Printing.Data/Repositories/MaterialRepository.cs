using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class MaterialRepository : RepositoryBase<T_Material>, IMaterialRepository
    {
        public MaterialRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Category GetCategoryByName(string categoryName)
        {
            var category = this.DbContext.Categories.Where(c => c.Name == categoryName).FirstOrDefault();

            return category;
        }

        public override void Update(T_Material entity)
        {
            entity.UpatedDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IMaterialRepository : IRepository<T_Material>
    {
        Category GetCategoryByName(string categoryName);
    }
}
