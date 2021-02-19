using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizProject1
{
    public class Bunny : Mammal
    {
        protected string _color;

        public string SummarizeBunny()
        {
            return $"This garbage Bunny is {_color} and only likes red cabbage.";
        }

        public Bunny(string newColor)
        {
            _color = newColor;
            _species = "Netherland Dwarf Rabbit";
            _gender = "male";
            _diet = "red cabbage";
            _age = 4;
            _weight = 2;
            _hasFur = true;
            _hasHair = false;
            _isTwoLegged = false;
            _canSwim = false;
        }
        public string FullSummaryBunny()
        {
            return $"{SummarizeAnimal()}\n{SummarizeMammal()}\n{SummarizeBunny()}";
        }
            
    }
}
