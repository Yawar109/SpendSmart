using System.ComponentModel.DataAnnotations;

namespace SpendSmart.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public Decimal Value { get; set; }

        [Required(ErrorMessage = "na kro bhiee")]
        public string? Description { get; set; }
    }
}
