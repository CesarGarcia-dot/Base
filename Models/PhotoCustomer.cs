namespace Citricosoft.Models
{
    public class PhotoCustomer
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string PhotoUrl { get; set; }
        public bool Status { get; set; }
    }
}