using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class PositionRepository : RepositoryBase<T_Position>, IPositionRepository
    {
        public PositionRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IPositionRepository : IRepository<T_Position>
    {

    }
}
