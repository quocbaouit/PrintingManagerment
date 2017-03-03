using System;

namespace PrintingManager.Model
{
    public class T_StockInDetail
    {
        public int Id { get; set; }
        public int StockInId { get; set; }
        public int MaterialId { get; set; }
        public double Quantity { get; set; }
        public double? Price { get; set; }
        public double SubTotal { get; set; }
        public string Description { get; set; }
        public int? Index { get; set; }
        public string MateriaName { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
       

        public virtual T_Material T_Material { get; set; }
        public virtual T_StockIn T_StockIn { get; set; }
    }
}
