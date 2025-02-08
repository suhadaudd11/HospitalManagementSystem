namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; } // Unique identifier
        public string Name { get; set; } // Doctor's full name
        public string Specialization { get; set; } // e.g., Cardiologist, General Physician
        public string ContactNumber { get; set; } // Phone number
        public string Email { get; set; } // Email address
        public int ExperienceYears { get; set; } // Years of experience
        public string Qualification { get; set; } // Degrees and certifications

        // Navigation Properties
        public ICollection<Appointment> Appointments { get; set; }

    }
}







