class Doctor
{
    public string Name { get; private set; }
    public int ID { get; private set; }
    public List<Appointment> Schedule { get; private set; } = new List<Appointment>();

    // Constructor to initialize a doctor
    public Doctor(string name, int id)
    {
        Name = name;
        ID = id;
    }

    // Method to add an appointment to the doctor's schedule
    public void AddAppointment(Appointment appointment)
    {
        Schedule.Add(appointment);
    }

    // Method to display the doctor's schedule
    public void DisplaySchedule()
    {
        Console.WriteLine($"Schedule for Dr. {Name}:");
        foreach (var appointment in Schedule)
        {
            Console.WriteLine($" - {appointment.AppointmentDate}: {appointment.Patient.Name} ({appointment.Status})");
        }
    }
}
