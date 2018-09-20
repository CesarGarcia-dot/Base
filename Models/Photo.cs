using System;

namespace Citricosoft.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Approved { get; set; }
        public bool Status { get; set; }


    }
}