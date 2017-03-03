using System;

namespace PrintingManager.Model
{
    public class T_FormularDetail
    {
        public int Id { get; set; }
        public int Index { get; set; }
        public int FormularId { get; set; }
        public int? ElementFormularId { get; set; }
        public string Prefix { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public int? DeletedUser { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual T_ElementFormular T_ElementFormular { get; set; }
        public virtual T_Formular T_Formular { get; set; }
    }
}
