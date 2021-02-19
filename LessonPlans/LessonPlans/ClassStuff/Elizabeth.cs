using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlans
{
    public class Elizabeth : Person
    {
        private bool _isGay;
        public Elizabeth()
        {
            _age = 27;
            _height = 5.7;
            _firstName = "Liz";
            _lastName = "Foxxy";
            _hairColor = "Brown";
            _isGay = true;
        }

        public string GetHairColor()
        {
            return _hairColor;
        }

        public string SummarizeElizabeth()
        {
            string sexualPreference;

            if (_isGay)
            {
                sexualPreference = "Elizabeth likes women.";
            }
            else
            {
                sexualPreference = "Elizabeth likes men.";
            }


            return $"{_firstName} {_lastName} is {_age} years old, " +
                $"is approximately {_height} feet tall, " +
                $"and has {_hairColor} hair. {sexualPreference}";
        }
    }
}