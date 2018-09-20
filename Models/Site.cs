using System;

namespace Citricosoft.Models
{
    public class Site
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Empresa { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateDeleted { get; set; }
        public string Sector { get; set; }
        public bool Status { get; set; }
    }
}