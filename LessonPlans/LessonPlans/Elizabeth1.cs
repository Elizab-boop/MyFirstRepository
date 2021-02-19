using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlans
{
    public class Elizabeth1
    {
        private int age = 27;
        public Elizabeth1()
        {

        }

        public Elizabeth1(int newAge)
        {
            age = newAge;
        }

        public void DisplayAge()
        {
            Console.WriteLine($"Elizabeth is {age} years old");
        }
    }
}
