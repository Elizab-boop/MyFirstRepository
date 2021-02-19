using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizProject1
{
    public class Vehicle
    {
        protected bool _usesGas;
        protected bool _fourWheels;
        public string SummarizeVehicle()
        {
            string fuelMessage;

            if (_usesGas)
            {
                fuelMessage = "runs on gasoline";
            }
            else
            {
                fuelMessage = "runs on diesel fuel";
            }

            string wheelMessage;

            if (_fourWheels)
            {
                wheelMessage = "has four wheels";
            }
            else
            {
                wheelMessage = "has two wheels";
            }
            return $"This vehical {fuelMessage} and {wheelMessage}.";

        }
    }
    

}
