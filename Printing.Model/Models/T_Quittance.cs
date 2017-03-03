using System;

namespace PrintingManager.Model
{
    public class T_Quittance
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Note { get; set; }
        public double? Money { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual T_Customer T_Customer { get; set; }
        public virtual T_Order T_Order { get; set; }
    }
}
