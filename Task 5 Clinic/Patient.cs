public class Patient
{
    public string Name { get; private set; }
    public int ID { get; private set; }
    public string PhoneNumber { get; private set; }

    // Constructor to initialize a patient
    public Patient(string name, int id, string phoneNumber)
    {
        Name = name;
        ID = id;
        PhoneNumber = phoneNumber;
    }
}
