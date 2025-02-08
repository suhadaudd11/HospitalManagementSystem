using Microsoft.AspNetCore.Authorization;

namespace HospitalManagementSystem.Models
{
    public class Patient
    {
        public int PatientId { get; set; } // Unique identifier
        public string Name { get; set; } // Patient's full name
        public string Gender { get; set; } // Male/Female/Other
        public DateTime DateOfBirth { get; set; } // Date of birth
        public string Address { get; set; } // Address of the patient
        public string ContactNumber { get; set; } // Phone number
        public string Email { get; set; } // Email address
        public string MedicalHistory { get; set; } // Brief medical history

        // Navigation Properties
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}











