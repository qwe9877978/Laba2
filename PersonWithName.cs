using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW2
{
    public class PersonWithName
    {
        public Name PersonName;
        public int Height;

        public PersonWithName()
        {
            PersonName = new Name();
            Height = 0;
        }

        public PersonWithName(Name name, int height)
        {
            PersonName = name;
            Height = height;
        }

        public PersonWithName(string firstName, int height)
        {
            PersonName = new Name(firstName);
            Height = height;
        }

        public PersonWithName(string lastName, string firstName, int height)
        {
            PersonName = new Name(lastName, firstName);
            Height = height;
        }

        public PersonWithName(string lastName, string firstName, string middleName, int height)
        {
            PersonName = new Name(lastName, firstName, middleName);
            Height = height;
        }

        public override string ToString()
        {
            return PersonName.ToString() + ", рост: " + Height;
        }
    }
}
