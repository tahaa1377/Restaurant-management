using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant
{
    internal class Factor
    {
        public Food food { get; set; }
        public int price { get; set; }
        public Customer customer { get; set; }


        public Factor(Food food, int price, Customer customer)
        {
            this.food = food;
            this.price = price;
            this.customer = customer;
        }

        public override string ToString()
        {
            return food +" "+price;
        }
    }
}
