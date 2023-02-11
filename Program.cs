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
                Console.WriteLine("9- show foods");

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

               /*     string name = Console.ReadLine();
                    int number = Convert.ToInt32(Console.ReadLine());
                    Class c = new Class(name, number);

                    classes.Add(c);
                    Console.WriteLine("new Class added");*/

                }
                else if (n.Equals("4"))
                {
              /*      int code = Convert.ToInt32(Console.ReadLine());

                    foreach (var item in teachers)
                    {
                        if (item.TeacherCode == code)
                        {
                            Console.WriteLine(item.calculate_salary());
                        }
                    }*/

                }
                else if (n.Equals("5"))
                {

                /*    int code = Convert.ToInt32(Console.ReadLine());

                    foreach (var item in students)
                    {
                        if (item.studentId == code)
                        {
                            Console.WriteLine(item.student_shahrie());
                        }
                    }*/

                }
                else if (n.Equals("6"))
                {

                    Console.WriteLine("employes of cala in storage : ");
                    foreach (var item in Storage.calas)
                    {
                        Console.WriteLine(item);
                    }

                }
                else if (n.Equals("7"))
                {

                   /* foreach (var item in teachers)
                    {

                        Console.WriteLine(item);

                    }*/
                }else if (n.Equals("8"))
                {

                    foreach (var item in employes)
                    {

                        Console.WriteLine(item);

                    }
                }else if (n.Equals("9"))
                {

                    foreach (var item in foods)
                    {
                        Console.WriteLine(item);
                    }
                }
            }



        

           
            foods.Add(new Food("pizza",80000));
            foods.Add(new Food("kabab",50000));
            foods.Add(new Food("berger",46000));
            foods.Add(new Food("chicken",65000));
            foods.Add(new Food("fish",78000));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("menu employes : ");
          

            Console.WriteLine("--------------------------------------");

         
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