using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcEfApp.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be between 3 and 20")]
        public string Name { get; set; }=String.Empty;
        public string City { get; set; } = String.Empty;
        public DateTime DateOfBirth { get; set; }
        [Column(TypeName ="numeric(18,0")]
        public decimal PhoneNumber { get; set; }
    }
}
