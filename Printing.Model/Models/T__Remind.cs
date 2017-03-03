using System;

namespace PrintingManager.Model
{
    public class T__Remind
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RemaindForUser { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime? CompletedDate { get; set; }
        public bool IsApproval { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
