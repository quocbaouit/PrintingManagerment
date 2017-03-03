using System;

namespace PrintingManager.Model
{
    public class T_UserFormular
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FormularId { get; set; }
        public string Formular { get; set; }
        public string FormularValue { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual T_Formular T_Formular { get; set; }
        public virtual T_User T_User { get; set; }
    }
}
