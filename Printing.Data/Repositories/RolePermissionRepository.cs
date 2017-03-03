using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class RolePermission : RepositoryBase<T_RolePermission>, IRolePermission
    {
        public RolePermission(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IRolePermission : IRepository<T_RolePermission>
    {

    }
}
