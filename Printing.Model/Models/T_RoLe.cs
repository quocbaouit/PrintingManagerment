using System;
using System.Collections.ObjectModel;

namespace PrintingManager.Model
{
    public class T_RoLe
    {
        public T_RoLe()
        {
            T_RolePermission = new Collection<T_RolePermission>();
            T_UserRole = new Collection<T_UserRole>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public string Decription { get; set; }
        public bool IsSystem { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Collection<T_RolePermission> T_RolePermission { get; set; }
        public virtual Collection<T_UserRole> T_UserRole { get; set; }
    }
}
