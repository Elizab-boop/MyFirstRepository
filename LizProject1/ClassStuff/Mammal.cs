using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizProject1
{
    public class Mammal : Animal
    {
        protected bool _hasFur;
        protected bool _hasHair;
        protected bool _isTwoLegged;
        protected bool _canSwim;

        public string SummarizeMammal()
        {
            string furMessage;

            if (_hasFur)
            {
                furMessage = "has fur";
            }
            else if (_hasHair)
            {
                furMessage = "has hair";
            }
            else
            {
                furMessage = "has no hair or fur";
            }

            string legMessage;

            if (_isTwoLegged)
            {
                legMessage = "has two legs";
            }
            else
            {
                legMessage = "has four legs";
            }

            string swimMessage;

            if (_canSwim)
            {
                swimMessage = "can swim";
            }
            else
            {
                swimMessage = "cannot swim";
            }

            return $"This mammal {furMessage}, {legMessage} and {swimMessage}.";
        }

    }
}
