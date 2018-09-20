using System;

namespace Citricosoft.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Int16 CellPhone { get; set; }
        public DateTime BirthDay { get; set; }
        public string Skill { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateDeleted { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }


    }
}