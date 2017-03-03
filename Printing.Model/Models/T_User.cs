using System;
using System.Collections.ObjectModel;

namespace PrintingManager.Model
{
    public class T_User
    {
        public T_User()
        {
            T_Order = new Collection<T_Order>();
            T_OrderDetail = new Collection<T_OrderDetail>();
            T_OrderDetail1 = new Collection<T_OrderDetail>();
            T_UserFormular = new Collection<T_UserFormular>();
        }

        public int Id { get; set; }
        public int PositionId { get; set; }
        public int? OrganizationId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool IsLock { get; set; }
        public bool IsRequireChangePW { get; set; }
        public bool IsForgotPassword { get; set; }
        public string NoteForgotPassword { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public DateTime? LockedTime { get; set; }
        public string LastName { get; set; }
        public string FisrtName { get; set; }
        public bool IsDeleted { get; set; }        
        public bool? IsOwner { get; set; }
        public string Mobile { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ColorString { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Collection<T_Order> T_Order { get; set; }
        public virtual T_Position T_Position { get; set; }
        public virtual Collection<T_OrderDetail> T_OrderDetail { get; set; }
        public virtual Collection<T_OrderDetail> T_OrderDetail1 { get; set; }
        public virtual Collection<T_UserFormular> T_UserFormular { get; set; }
    }
}
