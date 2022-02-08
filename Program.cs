using S_SOLIDPrinciple.Classes;
using System;

namespace S_SOLIDPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WITHOUT SRP Code
            //CodeWithoutSingleResponsibility();

            //WITH SRP Code
            CodeSingleResponsibility();
        }

        public static void CodeSingleResponsibility()
        {
            //Standard Messages
            Messages.WelcomeMessage();
            Student student = StudentDataCapture.Capture();
            bool isValidate = StudentValidator.Validate(student);
            if (!isValidate) 
            {
                Messages.EndApplication();
                return;
            }
            StudentCreator.Create(student);          
            Messages.EndApplication();
        }

        public static void CodeWithoutSingleResponsibility()
        {
            //Standard Messages
            Console.WriteLine("Welcome to the application");

            //Creating Student
            Student student = new Student();

            //Asking for basic information
            Console.WriteLine("What is your first name: ");
            student.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            student.LastName = Console.ReadLine();

            //Validations
            if (string.IsNullOrWhiteSpace(student.FirstName))
            {
                Console.WriteLine("First name is required");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(student.LastName))
            {
                Console.WriteLine("Last name is required");
                Console.ReadLine();
                return;
            }

            //Create student
            Console.WriteLine($"Student {student.FirstName} has created");
            Console.ReadLine();

        }
    }
}
