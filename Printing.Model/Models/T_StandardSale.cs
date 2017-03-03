using System;

namespace PrintingManager.Model
{
    public class T_StandardSale
    {
        public int Id { get; set; }
        public double BaseSalary { get; set; }
        public double Sales { get; set; }
        public decimal? Percent { get; set; }
        public double Bonus { get; set; }
        public double IncomeTotal { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
