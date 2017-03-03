using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class RoLeRepository : RepositoryBase<T_RoLe>, IRoLeRepository
    {
        public RoLeRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IRoLeRepository : IRepository<T_RoLe>
    {

    }
}
