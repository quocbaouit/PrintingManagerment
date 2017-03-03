using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class ProductTypeRepository : RepositoryBase<T_ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IProductTypeRepository : IRepository<T_ProductType>
    {

    }
}
