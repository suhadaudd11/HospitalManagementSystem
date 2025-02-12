namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; } // Unique identifier
        public string? Name { get; set; } // Doctor's full name
        public string? Specialization { get; set; } // e.g., Cardiologist, General Physician
        public string? ContactNumber { get; set; } // Phone number
        public required string Email { get; set; } // Email address
        public int? ExperienceYears { get; set; } // Years of experience
        public string? Qualification { get; set; } // Degrees and certifications

        // Navigation Properties
        public required ICollection<Appointment> Appointments { get; set; }

    }
}







