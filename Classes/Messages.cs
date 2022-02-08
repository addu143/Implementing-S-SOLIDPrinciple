using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_SOLIDPrinciple.Classes
{
    public class Messages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the application");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DisplayErrorMessage(string field)
        {
            Console.WriteLine($"{field} is required");
        }
    }
}
