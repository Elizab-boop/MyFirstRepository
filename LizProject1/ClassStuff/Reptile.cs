using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizProject1
{
    public class Reptile : Animal 
    {
        protected bool _egg;
        protected bool _fourLeg;



        public string SummarizeReptile()
        {
            string eggMessage;

            if (_egg)
            {
                eggMessage = "hatches from an egg";
            }
            else
            {
                eggMessage = "is born live";
            }

            string legMessage;

            if (_fourLeg)
            {
                legMessage = "has four legs";
            }
            else
            {
                legMessage = "has no legs";
            }

            return $"This reptile {eggMessage} and {legMessage}.";
        }

    }
}
