using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizProject1
{
    public class SubClass : BaseClass, Interfaces.Interface1 
    {
        public override void functionOne()
        {
            Console.WriteLine("This is function one.");
        }

        public override string functionTwo()
        {
            return "This is function two.";
        }

        public int ReturnInt()
        {
            throw new NotImplementedException();
        }

        public void ReturnNothing()
        {
            throw new NotImplementedException();
        }

        public string ReturnString()
        {
            throw new NotImplementedException();
        }
    }
}
