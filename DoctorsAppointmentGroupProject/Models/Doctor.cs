using System.ComponentModel.DataAnnotations;

namespace DoctorsAppointmentGroupProject.Models
{
    public class Doctor
    {
        [Key] public int DoctorID { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required] public string Specialization { get; set; }
        [Required, EmailAddress] public string Email { get; set; }
        [Required, Phone] public string Phone { get; set; }
        [Required] public string LicenseNumber { get; set; }
        [Required] public DoctorStatus Status { get; set; }
        [Range(0, double.MaxValue)] public double ConsultationFee { get; set; }
        public string? EducationalInfo { get; set; }
        public string? CareerInfo { get; set; }
    }
    public enum DoctorStatus
    {
        Active,
        Inactive,
        Suspended
    }
}