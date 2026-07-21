using System;

namespace Practicle_01
{
    class Student
    {
        public int AdmissionId;
        public string Name;
        public int Semester;
        public string Branch;

        private double Fees;
        private bool IsScholarship;
        private const double ScholarshipRate = 0.10; // 10%

        public void AcceptDetail()
        {
            Console.Write("Enter Student Admission ID: ");
            AdmissionId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Student Fees: ");
            Fees = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Student Branch: ");
            Branch = Console.ReadLine();

            Console.Write("Enter Student Semester: ");
            Semester = Convert.ToInt32(Console.ReadLine());
        }

        public void CalculateFees()
        {
            if (Fees >= 50000)
            {
                IsScholarship = true;

                double discount = Fees * ScholarshipRate;
                Fees = Fees - discount;

                Console.WriteLine("\nCongratulations! You got the Scholarship.");
                Console.WriteLine("Scholarship Amount : " + discount);
            }
            else
            {
                IsScholarship = false;

                Console.WriteLine("\nSorry! You are not eligible for Scholarship.");
                Console.WriteLine("Scholarship is available only for fees of ₹50,000 or above.");
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n--------- Student Details ---------");
            Console.WriteLine("Admission ID : " + AdmissionId);
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("Semester     : " + Semester);
            Console.WriteLine("Branch       : " + Branch);
            Console.WriteLine("Final Fees   : " + Fees);
            Console.WriteLine("Scholarship  : " + (IsScholarship ? "Yes" : "No"));
        }

        static void Main(string[] args)
        {
            char choice;

            do
            {
                Console.Clear();

                Student s = new Student();

                s.AcceptDetail();
                s.CalculateFees();
                s.DisplayDetails();

                Console.WriteLine("\nPress Y to enter another student or any other key to exit.");
                choice = Convert.ToChar(Console.ReadLine());

            } while (choice == 'Y' || choice == 'y');

            Console.WriteLine("\nThank You!");
            Console.ReadKey();
        }
    }
}



