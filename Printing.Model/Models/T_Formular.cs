using System;
using System.Collections.ObjectModel;

namespace PrintingManager.Model
{
    public class T_Formular
    {
        public T_Formular()
        {
            T_FormularDetail = new Collection<T_FormularDetail>();
            T_UserFormular = new Collection<T_UserFormular>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Formular { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public int? DeletedUser { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Collection<T_FormularDetail> T_FormularDetail { get; set; }
        public virtual Collection<T_UserFormular> T_UserFormular { get; set; }
    }
}
