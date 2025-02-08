namespace HospitalManagementSystem.Models
{
    public class Staff
    {
        public int StaffId { get; set; } // Unique identifier
        public string Name { get; set; } // Staff's full name
        public string Role { get; set; } // e.g., Nurse, Receptionist, Technician
        public string ContactNumber { get; set; } // Phone number
        public string Email { get; set; } // Email address
        public string Department { get; set; } // Department they belong to
        public DateTime HireDate { get; set; } // Date of joining
    }
}





