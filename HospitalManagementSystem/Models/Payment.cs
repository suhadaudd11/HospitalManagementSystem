namespace HospitalManagementSystem.Models
{
    public class Payment
    {
        public int PaymentId { get; set; } // Unique identifier
        public int PatientId { get; set; } // Foreign key to Patient
        public decimal Amount { get; set; } // Amount paid
        public DateTime PaymentDate { get; set; } // Date of payment
        public string PaymentMethod { get; set; } // e.g., Cash, Credit Card, Online
        public string ReceiptNumber { get; set; } // Receipt identifier
        public string Remarks { get; set; } // Any additional notes

        // Navigation Properties
        public Patient Patient { get; set; }
    }
}




