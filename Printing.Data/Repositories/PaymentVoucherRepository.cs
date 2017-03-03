using PrintingManager.Data.Infrastructure;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data.Repositories
{
    public class PaymentVoucherRepository : RepositoryBase<T_PaymentVoucher>, IPaymentVoucherRepository
    {
        public PaymentVoucherRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Category GetCategoryByName(string categoryName)
        {
            var category = this.DbContext.Categories.Where(c => c.Name == categoryName).FirstOrDefault();

            return category;
        }

        public override void Update(T_PaymentVoucher entity)
        {
            entity.UpdatedDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IPaymentVoucherRepository : IRepository<T_PaymentVoucher>
    {
        Category GetCategoryByName(string categoryName);
    }
}
