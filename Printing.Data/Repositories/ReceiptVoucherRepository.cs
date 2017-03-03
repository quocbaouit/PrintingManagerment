using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class ReceiptVoucherRepository : RepositoryBase<T_ReceiptVoucher>, IReceiptVoucherRepository
    {
        public ReceiptVoucherRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IReceiptVoucherRepository : IRepository<T_ReceiptVoucher>
    {

    }
}
