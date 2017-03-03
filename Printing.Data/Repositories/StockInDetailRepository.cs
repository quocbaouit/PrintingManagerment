using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class StockInDetailRepository : RepositoryBase<T_StockInDetail>, IStockInDetailRepository
    {
        public StockInDetailRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IStockInDetailRepository : IRepository<T_StockInDetail>
    {

    }
}
