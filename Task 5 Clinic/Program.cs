using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ClinicController controller = new ClinicController();

        // Adding doctors
        controller.AddDoctor("Ahmed", 1);
        controller.AddDoctor("Sara", 2);

        // Adding patients
        controller.AddPatient("John Doe", 101, "123-456-7890");
        controller.AddPatient("Jane Smith", 102, "098-765-4321");

        // Creating appointments
        controller.CreateAppointment(101, 1, new DateTime(2024, 10, 10, 10, 0, 0));
        controller.CreateAppointment(102, 1, new DateTime(2024, 10, 10, 11, 0, 0));

        // Approving an appointment
        controller.ApproveAppointment(1, new DateTime(2024, 10, 10, 10, 0, 0));

        // Displaying doctor's schedule
        controller.DisplayDoctorSchedule(1);
    }
}
