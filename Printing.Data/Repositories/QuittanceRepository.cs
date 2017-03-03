using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class QuittanceRepository : RepositoryBase<T_Quittance>, IQuittanceRepository
    {
        public QuittanceRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IQuittanceRepository : IRepository<T_Quittance>
    {

    }
}
