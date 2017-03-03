using System;
using System.Collections.ObjectModel;

namespace PrintingManager.Model
{
    public class T_ElementFormular
    {
        public T_ElementFormular()
        {
            T_FormularDetail = new Collection<T_FormularDetail>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double DefaultValue { get; set; }
        public bool IsSystem { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Collection<T_FormularDetail> T_FormularDetail { get; set; }
    }
}
