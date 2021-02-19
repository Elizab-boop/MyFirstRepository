using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizProject1
{
    public class Walter
    {
        int Age = 29;

        public Walter()
        {

        }

        public Walter(int newAge)
        {
            Age = newAge;
        }

        public void DisplayAge()
        {
            Console.WriteLine($"Walter is {Age} years old.");
        }
    }
}
