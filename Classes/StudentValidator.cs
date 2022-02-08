using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_SOLIDPrinciple.Classes
{
    public class StudentValidator
    {
        public static bool Validate(Student student)
        {
            //Validations
            if (string.IsNullOrWhiteSpace(student.FirstName))
            {
                Messages.DisplayErrorMessage("First name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(student.LastName))
            {
                Messages.DisplayErrorMessage("Last name");
                return false;
            }

            return true;
        }
    }
}
