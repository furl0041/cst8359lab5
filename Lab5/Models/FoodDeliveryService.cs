using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models
{
    public class FoodDeliveryService
    {
        // Id - Not database generated, manually assigned
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Registration Number")]
        [Required]
        public string Id { get; set; }

        // Title with validation
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        // Fee as currency/money
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Fee { get; set; }

        // Navigation property - One Service can have many Subscriptions
        public ICollection<Subscription> Subscriptions { get; set; }
    }
}