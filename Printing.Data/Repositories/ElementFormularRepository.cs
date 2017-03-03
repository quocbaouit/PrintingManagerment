﻿using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class ElementFormularRepository : RepositoryBase<T_ElementFormular>, IElementFormularRepository
    {
        public ElementFormularRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IElementFormularRepository : IRepository<T_ElementFormular>
    {

    }
}