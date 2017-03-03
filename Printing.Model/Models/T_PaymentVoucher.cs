using System;

namespace PrintingManager.Model
{
    public class T_PaymentVoucher
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Note { get; set; }
        public double Money { get; set; }
        public int? Debit { get; set; }
        public int? Credit { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }  
        public string ReceiptName { get; set; }
        public string ReceiptAddress { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
