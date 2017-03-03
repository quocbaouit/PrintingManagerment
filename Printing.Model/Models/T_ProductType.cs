using System;
using System.Collections.ObjectModel;

namespace PrintingManager.Model
{
    public class T_ProductType
    {
        public T_ProductType()
        {
            T_Product = new Collection<T_Product>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Collection<T_Product> T_Product { get; set; }
    }
}
