using System;

namespace Project2.Core
{
    class Cardiologist : Doctor
    {
        public int ExperienceYears { get; set; }

        public Cardiologist(
            string name,
            string license,
            int experienceYears
        ) : base(name, "Cardiologist", license)
        {
            ExperienceYears = experienceYears;
        }

        public void DisplayDetails()
        {
            
            Console.WriteLine("Doc Name: " + Name);
            Console.WriteLine("Specialization: " + Specialization);
            Console.WriteLine("License Number: " + LicenseNumber);
            Console.WriteLine("Exp Years: " + ExperienceYears);

           
            Console.WriteLine("Total Doc: " + Doctor.TotalDoctors);
        }
    }
}
