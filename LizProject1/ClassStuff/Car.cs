using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizProject1
{
    public class Car : Vehicle
    {
        protected string _color;
        protected string _make;
        protected string _model;
        protected int _year;

        public string SummarizeCar()
        {
            return $"This car is a(n) {_color} {_make} {_model} and was made in {_year}. ";
        }
        public Car(string newColor)
        {
            _color = newColor;
            _make = "Ford";
            _model = "Fiesta";
            _year = 2013;
            _usesGas = true;
            _fourWheels = true;
        }
        public string FullSummaryCar()
        {
            return $"{SummarizeVehicle()} {SummarizeCar()}";
        }
    }

    
}
