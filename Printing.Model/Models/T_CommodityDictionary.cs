using System;

namespace PrintingManager.Model
{
    public class T_CommodityDictionary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CommodityId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
