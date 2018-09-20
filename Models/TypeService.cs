using System;

namespace Citricosoft.Models
{
    public class TypeService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateDeleted { get; set; }
        public bool Status { get; set; }
    }
}