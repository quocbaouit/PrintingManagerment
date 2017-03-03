using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class UserFormularRepository : RepositoryBase<Gadget>, IUserFormularRepository
    {
        public UserFormularRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IUserFormularRepository : IRepository<Gadget>
    {

    }
}
