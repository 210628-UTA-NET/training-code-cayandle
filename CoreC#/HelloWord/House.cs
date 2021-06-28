using System;

namespace HouseFunction
{
    public class House
    {
        private string _color;
        private int _price;
        //Constructor
        public House()
        {
            Console.WriteLine("That constructor of this class was used");
            _color = "Red";
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public string getColor()
        {
            return _color;
        }
    }
}