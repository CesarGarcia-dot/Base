using System;

namespace Citricosoft.Models
{
    public class RegisterPass
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string PasswordSite { get; set; }
        public int SiteId { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public DateTime DateDeleted { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Status { get; set; }

    }
}