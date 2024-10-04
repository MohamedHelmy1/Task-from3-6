class Appointment
{
    public Patient Patient { get; private set; }
    public DateTime AppointmentDate { get; private set; }
    public string Status { get; set; } // Pending, Approved, Completed, Canceled

    // Constructor to initialize an appointment
    public Appointment(Patient patient, DateTime appointmentDate)
    {
        Patient = patient;
        AppointmentDate = appointmentDate;
        Status = "Pending"; // Default status
    }

    // Method to approve the appointment
    public void Approve()
    {
        Status = "Approved";
    }

    // Method to complete the appointment
    public void Complete()
    {
        Status = "Completed";
    }

    // Method to cancel the appointment
    public void Cancel()
    {
        Status = "Canceled";
    }
}
