using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        PrintingEntities dbContext;

        public PrintingEntities Init()
        {
            return dbContext ?? (dbContext = new PrintingEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
