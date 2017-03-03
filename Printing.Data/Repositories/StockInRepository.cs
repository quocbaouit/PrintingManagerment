using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class StockIn : RepositoryBase<T_StockIn>, IStockIn
    {
        public StockIn(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IStockIn : IRepository<T_StockIn>
    {

    }
}
