using System;
using System.Collections.ObjectModel;

namespace PrintingManager.Model
{
    public class T_Product
    {
        public T_Product()
        {
            T_OrderDetail = new Collection<T_OrderDetail>();
            T_UserProduct = new Collection<T_UserProduct>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductTypeId { get; set; }
        public int? Inventory { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        

        public virtual T_ProductType T_ProductType { get; set; }
        public virtual Collection<T_OrderDetail> T_OrderDetail { get; set; }
        public virtual Collection<T_UserProduct> T_UserProduct { get; set; }
    }
}
