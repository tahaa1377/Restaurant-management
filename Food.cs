using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant
{
    internal class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Food(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"food name is : {Name} and price is {Price}";
        }
    }
}
