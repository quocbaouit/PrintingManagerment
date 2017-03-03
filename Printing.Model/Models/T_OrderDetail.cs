using System;

namespace PrintingManager.Model
{
    public class T_OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CommodityId { get; set; }
        public string CommodityName { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }
        public decimal? Quantity { get; set; }
        public double? Price { get; set; }
        public double SubTotal { get; set; }
        public string Description { get; set; }
        public int? DesignUser { get; set; }
        public int? DesignStatus { get; set; }
        public int? PrintUser { get; set; }
        public int? PrintStatus { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DesignFrom { get; set; }
        public DateTime? DesignTo { get; set; }
        public DateTime? PrintFrom { get; set; }
        public DateTime? PrintTo { get; set; }
        public string FileName { get; set; }
        public string DesignDescription { get; set; }
        public string PrintDescription { get; set; }
        public int Index { get; set; }
        public string DesignView { get; set; }
        public string PrintView { get; set; }
        public decimal? Square { get; set; }
        public decimal? SumSquare { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual T_Order T_Order { get; set; }
        public virtual T_Product T_Product { get; set; }
        public virtual T_User T_User { get; set; }
        public virtual T_User T_User1 { get; set; }
    }
}
