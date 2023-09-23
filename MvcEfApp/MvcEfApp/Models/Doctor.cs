using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcEfApp.Models
{
    public class Doctor
    {
        [Key]
        [Column("doctorno")]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3,ErrorMessage ="Name must be between 3 and 20")]
        public string Name { get; set; }
        [Required]
        public string Speciality { get; set; }=String.Empty;
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]

        public Decimal VisitingFees { get; set; }
        [Required]
        [Column(TypeName ="numeric(18,2)")]
        public long PhoneNumber { get; set; }
    }
}
