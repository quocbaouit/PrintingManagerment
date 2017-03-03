using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class FormularDetailRepository : RepositoryBase<T_FormularDetail>, IFormularDetailRepository
    {
        public FormularDetailRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IFormularDetailRepository : IRepository<T_FormularDetail>
    {

    }
}
