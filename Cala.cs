using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant
{
    internal class Cala
    {

        public string Name { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

        public Cala(string name, int count, int price)
        {
            Name = name;
            Count = count;
            Price = price;
        }
        public override string ToString()
        {
            return $"product name is {Name} and count of product in storage id {Count} and price : {Price}";
        }

    }
}
