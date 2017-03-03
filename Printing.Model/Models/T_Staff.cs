using System;

namespace PrintingManager.Model
{
    public class T_Staff
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int OrganizationId { get; set; }
        public int PositionId { get; set; }
        public string Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDay { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public DateTime? StartDate { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? UpatedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual T_Organization T_Organization { get; set; }
        public virtual T_Position T_Position { get; set; }
    }
}
