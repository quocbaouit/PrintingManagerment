using System;
using System.Collections.ObjectModel;

namespace PrintingManager.Model
{
    public class T_Position
    {
        public T_Position()
        {
            T_Staff = new Collection<T_Staff>();
            T_User = new Collection<T_User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int OrganizationId { get; set; }
        public int CreatedUser { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }      
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual T_Organization T_Organization { get; set; }
        public virtual Collection<T_Staff> T_Staff { get; set; }
        public virtual Collection<T_User> T_User { get; set; }
    }
}
