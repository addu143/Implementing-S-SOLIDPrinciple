using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_SOLIDPrinciple.Classes
{
    public class StudentCreator
    {
        public static void Create(Student student)
        {
            Console.WriteLine($"Student {student.FirstName} has created");
        }
    }
}
