using System;
using System.Collections.ObjectModel;

namespace PrintingManager.Model
{
    public class T_Partner
    {
        public T_Partner()
        {
            T_StockIn = new Collection<T_StockIn>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string TaxCode { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Collection<T_StockIn> T_StockIn { get; set; }
    }
}
