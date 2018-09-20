using System;

namespace Citricosoft.Models
{
    public class Pay
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int CostumerId { get; set; }
        public decimal Monto { get; set; }
        public bool Cancel { get; set; }
        public bool Debe { get; set; }
        public decimal MontoDeber { get; set; }
        public DateTime DateService { get; set; }
        public string CurrentService { get; set; }
        public bool EndService { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateDeleted { get; set; }
        public bool Status { get; set; }

    }
}