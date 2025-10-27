using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class Customer
    {
        // Primary Key
        public int Id { get; set; }

        // Last Name with validation
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        // First Name with validation
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        // Birth Date with formatting
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        // Calculated property - Full Name
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        // Navigation property - One Customer can have many Subscriptions
        public ICollection<Subscription> Subscriptions { get; set; }
    }
}