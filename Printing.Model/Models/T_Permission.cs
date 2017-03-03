using System;
using System.Collections.ObjectModel;

namespace PrintingManager.Model
{
    public class T_Permission
    {
        public T_Permission()
        {
            T_RolePermission = new Collection<T_RolePermission>();
        }

        public int Id { get; set; }
        public int FeatureId { get; set; }
        public int PermissionTypeId { get; set; }
        public string SystemName { get; set; }
        public string PermissionName { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDefault { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual T_Feature T_Feature { get; set; }
        public virtual Collection<T_RolePermission> T_RolePermission { get; set; }
    }
}
