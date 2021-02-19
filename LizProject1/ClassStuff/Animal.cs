using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizProject1
{
    public class Animal
    {
        protected string _species;
        protected string _gender;
        protected string _diet;
        protected double _age;
        protected double _weight;

        public string SummarizeAnimal()
        {
            return $"This animal is a(n) {_species}, is {_gender}, {_age} years old, weighs {_weight} pounds, and eats {_diet}.";
        }
    }
}
