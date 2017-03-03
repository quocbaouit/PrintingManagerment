using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class StandardSaleRepository : RepositoryBase<T_StandardSale>, IStandardSaleRepository
    {
        public StandardSaleRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IStandardSaleRepository : IRepository<T_StandardSale>
    {

    }
}
