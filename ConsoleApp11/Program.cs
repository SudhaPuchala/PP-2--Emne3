using System.ComponentModel.Design;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Virtual_Pet leoTheCat = new Virtual_Pet("Leo",12, "cat",true);
            Console.WriteLine("Pet 1");
            leoTheCat.Greet();
            leoTheCat.Sleep();
            leoTheCat.Eat("some dry food");
            Console.WriteLine("");

          

            Virtual_Pet parrotTheBird = new Virtual_Pet("Parrot", 12, "bird", false);
            Console.WriteLine("Pet 2");
            parrotTheBird.Greet();
            parrotTheBird.Sleep();
            parrotTheBird.Eat("  a fruit");
            Console.WriteLine("");
            

            bool isRunning = true;
            while (isRunning) 
            {
                Menu(leoTheCat, parrotTheBird, isRunning);
            }


            static void Menu(Virtual_Pet leoThecat, Virtual_Pet parrotTheBird,bool isRunning)
            {
                Console.WriteLine("Welcome to Virtual Pet Simulator");
                Console.WriteLine("1. Choose the pet");
                Console.WriteLine("2. Feed the pet");
                Console.WriteLine("3. Play with the pet");
                Console.WriteLine("4. Parrot talks");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice:");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Choose your pet:");
                        Console.WriteLine("1.Leo(Cat)");
                        Console.WriteLine("2.Parrot(Bird)");
                        var petChoice = Console.ReadLine();

                        if (petChoice == "1")
                        {
                            leoThecat.Greet();
                        }
                        else if (petChoice == "2")
                        {
                            parrotTheBird.Greet();

                        }
                        else
                        {
                            Console.WriteLine("Invalid pet choice");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter the food for leo:");
                        var foodLeo = Console.ReadLine();
                        leoThecat.Eat(foodLeo);
                        break;

                    case "3":
                        leoThecat.Play();
                        break;

                    case "4":
                        parrotTheBird.Talk();
                        break;

                    case "5":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Incorrect choice");

                        break;


                }
            }


        }
    }
}
