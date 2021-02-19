using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlans
{
    public class Person
    {
        public Person() { }

        protected double _height;
        protected int _age;
        protected string _firstName;
        protected string _lastName;
        protected string _hairColor;

        public string GetDescription()
        {
            return $"{_firstName} {_lastName} is {_age} years old, " +
                $"is approximately {_height} feet tall, " +
                $"and has {_hairColor} hair.";
        }

        public int GetAge()
        {
            return _age;
        }
    }
}
