using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW2
{
    public class Person
    {
        public string Name;
        public int Height;

        public Person()
        {
            Name = string.Empty;
            Height = 0;
        }

        public Person(string name, int height)
        {
            Name = name;
            Height = height;
        }

        public override string ToString()
        {
            return Name + ", рост: " + Height;
        }
    }
}
