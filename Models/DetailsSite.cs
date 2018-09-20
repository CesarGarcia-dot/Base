using System;

namespace Citricosoft.Models
{
    public class DetailsSite
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int DomainId { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateDeleted { get; set; }

    }
}