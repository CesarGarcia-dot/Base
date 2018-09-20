using System;

namespace Citricosoft.Models
{
    public class Domain
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public int IpDomainId { get; set; }
        public string Version { get; set; }
        public string DNS { get; set; }
        public string SubDNS { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateDeleted { get; set; }

    }
}