using System;

namespace PrintingManager.Model
{
    public class T_Menu
    {
        public int Id { get; set; }
        public int MenuCategoryId { get; set; }
        public string MenuName { get; set; }
        public int OrderIndex { get; set; }
        public string Link { get; set; }
        public bool IsShow { get; set; }
        public bool IsViewIcon { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual T_MenuCategory T_MenuCategory { get; set; }
    }
}
