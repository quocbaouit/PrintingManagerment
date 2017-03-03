using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class RemindRepository : RepositoryBase<T__Remind>, IRemindRepository
    {
        public RemindRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Category GetCategoryByName(string categoryName)
        {
            var category = this.DbContext.Categories.Where(c => c.Name == categoryName).FirstOrDefault();

            return category;
        }

        public override void Update(T__Remind entity)
        {
            entity.UpatedDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IRemindRepository : IRepository<T__Remind>
    {
        Category GetCategoryByName(string categoryName);
    }
}
