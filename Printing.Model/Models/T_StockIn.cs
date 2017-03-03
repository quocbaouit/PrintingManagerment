using System;
using System.Collections.ObjectModel;

namespace PrintingManager.Model
{
    public class T_StockIn
    {
        public T_StockIn()
        {
            T_StockInDetail = new Collection<T_StockInDetail>();
        }

        public int Id { get; set; }
        public int PartnerId { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public DateTime? StockInDate { get; set; }
        public double SubTotal { get; set; }
        public bool IsPayment { get; set; }
        public bool IsApproval { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual T_Partner T_Partner { get; set; }
        public virtual Collection<T_StockInDetail> T_StockInDetail { get; set; }
    }
}
