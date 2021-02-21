using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizProject1
{
    class Gecko : Reptile 
    {
        protected string _color;

        public string SummarizeGecko()
        {
            return $"This Gecko is {_color} and enjoys sunbathing.";
        }

        public Gecko(string newColor)
        {
            _color = newColor;
            _species = "Leopard Gecko";
            _gender = "female";
            _diet = "crickets";
            _age = 2;
            _weight = 1;
            _egg = true;
            _fourLeg = true; 
        }

        public override string MakeMouthSound() 
        {
            return "Blep!"; 
        }

        public string FullSummaryGecko()
        {
            return $"{SummarizeAnimal()}\n{SummarizeReptile()}\n{SummarizeGecko()}\n{MakeMouthSound()}";
        }

    }
}
