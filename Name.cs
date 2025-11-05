using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW2
{
    public class Name
    {
        public string LastName;
        public string FirstName;
        public string MiddleName;

        public Name()
        {
            LastName = string.Empty;
            FirstName = string.Empty;
            MiddleName = string.Empty;
        }

        public Name(string firstName)
        {
            FirstName = firstName;
            LastName = string.Empty;
            MiddleName = string.Empty;
        }

        public Name(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = string.Empty;
        }

        public Name(string lastName, string firstName, string middleName)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
        }

        public override string ToString()
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(LastName))
            {
                result += LastName + " ";
            }

            if (!string.IsNullOrEmpty(FirstName))
            {
                result += FirstName + " ";
            }

            if (!string.IsNullOrEmpty(MiddleName))
            {
                result += MiddleName + " ";
            }

            return result;
        }
    }
}
