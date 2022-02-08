using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_SOLIDPrinciple.Classes
{
    public class StudentDataCapture
    {
        public static Student Capture()
        {
            Student student = new Student();

            //Asking for basic information
            Console.WriteLine("What is your first name: ");
            student.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            student.LastName = Console.ReadLine();

            return student;
        }
    }
}
