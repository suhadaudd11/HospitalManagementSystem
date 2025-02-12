namespace HospitalManagementSystem.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; } // Unique identifier
        public int PatientId { get; set; } // Foreign key to Patient
        public int DoctorId { get; set; } // Foreign key to Doctor
        public DateTime AppointmentDate { get; set; } // Date and time of appointment
        public string? Status { get; set; } // Scheduled, Completed, Cancelled
        public string? Remarks { get; set; } // Any additional information

        // Navigation Properties
        public required Patient Patient { get; set; }
        public required Doctor Doctor { get; set; }
    }
}






