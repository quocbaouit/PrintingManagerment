using System;
using System.Collections.ObjectModel;

namespace PrintingManager.Model
{
    public class T_Customer
    {
        public T_Customer()
        {
            T_Order = new Collection<T_Order>();
            T_Quittance = new Collection<T_Quittance>();
            T_ReceiptVoucher = new Collection<T_ReceiptVoucher>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string TaxCode { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CompanyName { get; set; }

        public virtual Collection<T_Order> T_Order { get; set; }
        public virtual Collection<T_Quittance> T_Quittance { get; set; }
        public virtual Collection<T_ReceiptVoucher> T_ReceiptVoucher { get; set; }
    }
}
