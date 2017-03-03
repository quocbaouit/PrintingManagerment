using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        PrintingEntities Init();
    }
}
