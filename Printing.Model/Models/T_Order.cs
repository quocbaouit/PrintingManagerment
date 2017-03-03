using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Model
{
    public class T_Order
    {
        public T_Order()
        {
            T_Quittance = new Collection<T_Quittance>();
            T_ReceiptVoucher = new Collection<T_ReceiptVoucher>();
            T_OrderDetail = new Collection<T_OrderDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public double SubTotal { get; set; }
        public bool IsPayment { get; set; }
        public bool IsApproval { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public double? HasPay { get; set; }
        public int CreatedForUser { get; set; }
        public bool? HasTax { get; set; }
        public string OrderView { get; set; }
        public int IsDelivery { get; set; }
        public int PaymentMethol { get; set; }

        public virtual T_Customer T_Customer { get; set; }
        public virtual T_User T_User { get; set; }
        public virtual Collection<T_Quittance> T_Quittance { get; set; }
        public virtual Collection<T_ReceiptVoucher> T_ReceiptVoucher { get; set; }
        public virtual Collection<T_OrderDetail> T_OrderDetail { get; set; }
    }
}
