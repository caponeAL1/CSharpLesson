using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcEfApp.Models
{
    public class Appointment
    {

        [Key]
        [Column("appointmentno")]
        public int Id { get; set; }
        [Required]
        public int PatientID { get; set; }
        [Required]
        public string DoctorId { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
