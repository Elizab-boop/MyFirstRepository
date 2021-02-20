using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizProject1
{
    public class SubClass : BaseClass
    {
        public override void functionOne()
        {
            Console.WriteLine("This is function one.");
        }

        public override string functionTwo()
        {
            return "This is function two.";
        }
    }
}
