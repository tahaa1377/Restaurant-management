namespace resturant
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("well come to resturant");

            List<Employe> list = new List<Employe>();

            Storage.calas.Add(new Cala("meat",10,10000));
            Storage.calas.Add(new Cala("rice",40,34000));
            Storage.calas.Add(new Cala("fish",90,55000));
            Storage.calas.Add(new Cala("chicken",50,61000));
            Storage.calas.Add(new Cala("cola",30,8000));
        
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("list of cala in storage : ");
            foreach(var item in Storage.calas)
            {
                Console.WriteLine(item);
            }

            list.Add(new Employe("ali","alavi",40));
            list.Add(new Employe("sanaz","sarvi",30));
            list.Add(new Employe("parsa","dehdashti",34));
            list.Add(new Employe("ahmad","ahmadi",51));
            
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("employe information : ");
            foreach(var item in list) 
            { 
            Console.WriteLine($"{item}");
            }

            List<Food> foods = new List<Food>();
            foods.Add(new Food("pizza",80000));
            foods.Add(new Food("kabab",50000));
            foods.Add(new Food("berger",46000));
            foods.Add(new Food("chicken",65000));
            foods.Add(new Food("fish",78000));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("menu list : ");
            foreach(var item in foods)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------------");

            List<Factor> factories = new List<Factor>();
            Customer customer1 = new Customer(100);
            Customer customer2 = new Customer(200);
            Customer customer3 = new Customer(300);

            factories.Add(new Factor(new Food("pizza", 80000), 80000,customer1));
            factories.Add(new Factor(new Food("kabab", 50000), 50000, customer2));
            factories.Add(new Factor(new Food("fish", 78000), 78000, customer3));

            foreach(var item in factories)
            {
                Console.WriteLine(item);
            }
        }
    }
}