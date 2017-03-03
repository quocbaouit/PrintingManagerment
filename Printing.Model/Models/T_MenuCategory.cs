using System;
using System.Collections.ObjectModel;

namespace PrintingManager.Model
{
    public class T_MenuCategory
    {
        public T_MenuCategory()
        {
            T_Menu = new Collection<T_Menu>();
        }
        public int Id { get; set; }
        public string Category { get; set; }
        public string Position { get; set; }
        public int OrderIndex { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public bool IsViewIcon { get; set; }
        public string Link { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Collection<T_Menu> T_Menu { get; set; }
    }
}
