using System;

namespace Citricosoft.Models
{
    public class IpDomain
    {
        public int Id { get; set; }
        public string NumberId { get; set; }
        public string Version { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateDeleted { get; set; }
        public bool Status { get; set; }
    }
}