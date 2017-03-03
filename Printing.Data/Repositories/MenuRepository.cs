using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class MenuRepository : RepositoryBase<T_Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Category GetCategoryByName(string categoryName)
        {
            var category = this.DbContext.Categories.Where(c => c.Name == categoryName).FirstOrDefault();

            return category;
        }

        public override void Update(T_Menu entity)
        {
            entity.UpatedDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IMenuRepository : IRepository<T_Menu>
    {
        Category GetCategoryByName(string categoryName);
    }
}
