using System;

namespace PrintingManager.Model
{
    public class T_RolePermission
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int FeatureId { get; set; }
        public int PermissionId { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual T_Feature T_Feature { get; set; }
        public virtual T_Permission T_Permission { get; set; }
        public virtual T_RoLe T_RoLe { get; set; }
    }
}
