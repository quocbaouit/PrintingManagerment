using System;
namespace PrintingManager.Model
{
    public class T_ErrorLog
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string ModuleName { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
        public bool IsFix { get; set; }
        public string ErrorCaption { get; set; }
        public string ErrorClass { get; set; }
        public string ErrorMethod { get; set; }
        public string StrackTrace { get; set; }
        public string IpError { get; set; }
        public string ActionError { get; set; }
        public string TargetSite { get; set; }
    }
}
