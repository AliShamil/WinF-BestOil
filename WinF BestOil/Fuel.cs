using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinF_BestOil
{
    internal class Fuel
    {
        private string? _name;
        private double _price;

        public string? Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    MessageBox.Show("Name cannot be null or whitespace!");

                _name = value;
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                    MessageBox.Show("Invalid Price!");

                _price = value;
            }
        }

        public Fuel(string? name, double price)
        {
            Name=name;
            Price=price;
        }
    }
}
