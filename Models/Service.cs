using System;

namespace Citricosoft.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Technology { get; set; }
        public int TypeServiceId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateDeleted { get; set; }
        public string Icon { get; set; }
        public bool Status { get; set; }
    }
}