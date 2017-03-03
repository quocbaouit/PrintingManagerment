using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class TimingRepository : RepositoryBase<T_Timing>, ITimingRepository
    {
        public TimingRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface ITimingRepository : IRepository<T_Timing>
    {

    }
}
