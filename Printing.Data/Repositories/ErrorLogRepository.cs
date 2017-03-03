using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class ErrorLogRepository : RepositoryBase<T_ErrorLog>, IErrorLogRepository
    {
        public ErrorLogRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Category GetCategoryByName(string categoryName)
        {
            var category = this.DbContext.Categories.Where(c => c.Name == categoryName).FirstOrDefault();

            return category;
        }

        public override void Update(T_ErrorLog entity)
        {
            entity.CreateDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IErrorLogRepository : IRepository<T_ErrorLog>
    {
        Category GetCategoryByName(string categoryName);
    }
}
