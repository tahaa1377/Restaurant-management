using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant
{
    internal class Employe
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }
       
        public Employe(string name, string family, int age) {
        
            Name = name;
            Family = family;
            Age = age;

        }

        public override string ToString()
        {
            return $"employe name : {Name} {Family} and age : {Age}";
        }

    }
}
