using System;
using System.Collections.ObjectModel;

namespace PrintingManager.Model
{
    public class T_Material
    {
        public T_Material()
        {
            T_StockInDetail = new Collection<T_StockInDetail>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Inventory { get; set; }
        public int MaterialTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual T_MaterialType T_MaterialType { get; set; }
        public virtual Collection<T_StockInDetail> T_StockInDetail { get; set; }
    }
}
