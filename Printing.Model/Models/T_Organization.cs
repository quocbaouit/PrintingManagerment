using System;
using System.Collections.ObjectModel;

namespace PrintingManager.Model
{
    public class T_Organization
    {
        public T_Organization()
        {
            T_Position = new Collection<T_Position>();
            T_Staff = new Collection<T_Staff>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int? OrderIndex { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime CreatedDate { get; set; }      
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedUser { get; set; }

        public virtual Collection<T_Position> T_Position { get; set; }
        public virtual Collection<T_Staff> T_Staff { get; set; }
    }
}
