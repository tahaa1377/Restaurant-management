using System.Security.Claims;

namespace resturant
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("well come to resturant");

            List<Employe> employes = new List<Employe>();
            List<Factor> factories = new List<Factor>();
            List<Food> foods = new List<Food>();
            List<Customer> customers = new List<Customer>();

            while (true)
            {
                Console.WriteLine("1- add Employe");
                Console.WriteLine("2- add Cala");
                Console.WriteLine("3- add food");
                Console.WriteLine("4- Customer");
                Console.WriteLine("5- show menu");
                Console.WriteLine("6- show storage");
                Console.WriteLine("7- factor customer");
                Console.WriteLine("8- show Employes");

                string n = Console.ReadLine();

                if (n.Equals("1"))
                {
                    string name = Console.ReadLine();
                    string family = Console.ReadLine();
                    int age = Convert.ToInt32(Console.ReadLine());

                    employes.Add(new Employe(name, family, age));
                }
                else if (n.Equals("2"))
                {

                    string name = Console.ReadLine();

                    int number = Convert.ToInt32(Console.ReadLine());
                    int price = Convert.ToInt32(Console.ReadLine());


                    Storage.calas.Add(new Cala(name,number,price));

 

                }
                else if (n.Equals("3"))
                {
                    string name = Console.ReadLine();
                    int price = Convert.ToInt32(Console.ReadLine());
                    foods.Add(new Food(name, price));

                }
                else if (n.Equals("4"))
                {

                    int code = Convert.ToInt32(Console.ReadLine());
                    Customer customer1 = new Customer(code);

                    customers.Add(customer1);

                }
                else if (n.Equals("5"))
                {

                    foreach (var item in foods)
                    {
                        Console.WriteLine(item);
                    }

                }
                else if (n.Equals("6"))
                {


                    Console.WriteLine("list of cala in storage : ");
                    foreach (var item in Storage.calas)
                    {
                        Console.WriteLine(item);
                    }

                }
                else if (n.Equals("7"))
                {
                    string name = Console.ReadLine();
                    int price = Convert.ToInt32(Console.ReadLine());

                    int code = Convert.ToInt32(Console.ReadLine());
                    Customer customer1 = new Customer(code);

                    factories.Add(new Factor(new Food(name,price), price, customer1));

                    foreach (var item in factories)
                    {
                        Console.WriteLine(item);
                    }

                }
                else if (n.Equals("8"))
                {

                    foreach (var item in employes)
                    {

                        Console.WriteLine(item);

                    }
                }
            }

        }
    }
}