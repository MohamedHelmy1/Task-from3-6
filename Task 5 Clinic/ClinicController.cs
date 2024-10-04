class ClinicController
{
    private Clinic clinic;

    // Constructor to initialize the controller
    public ClinicController()
    {
        clinic = new Clinic();
    }

    // Method to add a patient
    public void AddPatient(string name, int id, string phoneNumber)
    {
        var patient = new Patient(name, id, phoneNumber);
        clinic.AddPatient(patient);
        Console.WriteLine($"Patient {name} added.");
    }

    // Method to add a doctor
    public void AddDoctor(string name, int id)
    {
        var doctor = new Doctor(name, id);
        clinic.AddDoctor(doctor);
        Console.WriteLine($"Doctor {name} added.");
    }

    // Method to create an appointment
    public void CreateAppointment(int patientId, int doctorId, DateTime appointmentDate)
    {
        clinic.CreateAppointment(patientId, doctorId, appointmentDate);
    }

    // Method to approve an appointment
    public void ApproveAppointment(int doctorId, DateTime appointmentDate)
    {
        clinic.ApproveAppointment(doctorId, appointmentDate);
    }

    // Method to display doctor's schedule
    public void DisplayDoctorSchedule(int doctorId)
    {
        var doctor = clinic.Doctors.Find(d => d.ID == doctorId);
        if (doctor != null)
        {
            doctor.DisplaySchedule();
        }
        else
        {
            Console.WriteLine("Doctor not found.");
        }
    }
}
