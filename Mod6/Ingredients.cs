using System;

namespace Mod6
{
    public class Ingredients
    {
        
        private string _ingredient, _measurement;
        private double _quantity;

        public Ingredients(string ingredient, double quantity, string measurement)
        {
            _ingredient = ingredient;
            _quantity = quantity;
            _measurement = measurement;
        }

        public void SetName(string ingredient)
        {
            ingredient = _ingredient;
        }

        public void SetQuantity(double quantity)
        {
            quantity = _quantity;
        }

        public void SetMeasure(string measurement)
        {
            measurement = _measurement;
        }

        public string GetName()
        {
            return _ingredient;
        }

        public double GetQuantity()
        {
            return _quantity;
        }

        public string GetMeasure()
        {
            return _measurement;
        }

        public string Print()
        {
            return $"{_quantity} {_measurement} of {_ingredient}";
        }
    }
}