class Clinic
{
    public List<Patient> Patients { get; private set; } = new List<Patient>();
    public List<Doctor> Doctors { get; private set; } = new List<Doctor>();

    // Method to add a patient
    public void AddPatient(Patient patient)
    {
        Patients.Add(patient);
    }

    // Method to add a doctor
    public void AddDoctor(Doctor doctor)
    {
        Doctors.Add(doctor);
    }

    // Method to create an appointment
    public void CreateAppointment(int patientId, int doctorId, DateTime appointmentDate)
    {
        var patient = Patients.Find(p => p.ID == patientId);
        var doctor = Doctors.Find(d => d.ID == doctorId);

        if (patient != null && doctor != null)
        {
            var appointment = new Appointment(patient, appointmentDate);
            doctor.AddAppointment(appointment);
            Console.WriteLine($"Appointment created for {patient.Name} with Dr. {doctor.Name} on {appointmentDate}");
        }
        else
        {
            Console.WriteLine("Invalid patient or doctor ID.");
        }
    }

    // Method to approve an appointment
    public void ApproveAppointment(int doctorId, DateTime appointmentDate)
    {
        var doctor = Doctors.Find(d => d.ID == doctorId);
        if (doctor != null)
        {
            var appointment = doctor.Schedule.Find(a => a.AppointmentDate == appointmentDate);
            if (appointment != null && appointment.Status == "Pending")
            {
                appointment.Approve();
                Console.WriteLine($"Appointment for {appointment.Patient.Name} has been approved.");
            }
            else
            {
                Console.WriteLine("Appointment not found or already approved.");
            }
        }
        else
        {
            Console.WriteLine("Doctor not found.");
        }
    }
}
