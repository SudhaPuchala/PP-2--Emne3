using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Virtual_Pet
    {
        public string FullName;
        public int Age;
        public string Species;
        public bool IsAwake;


        public Virtual_Pet(string petName, int petAge, string petSpecies, bool petIsAwake)
        {
            FullName = petName;
            Age = petAge;
            Species = petSpecies;
            IsAwake = petIsAwake;

        }

        public void Greet()
        {
            Console.WriteLine($" My name is{FullName}, {Species}");
            Console.WriteLine($" I am {Age} years old");
            Console.WriteLine($" Is awake?{IsAwake}");
        }

        public void Sleep()
        {
            IsAwake = false;

            Console.WriteLine($"{FullName} is now happily snoring,,,,");
        }

        public void Eat(string foodName)
        {
            Console.WriteLine($"{FullName} is now eating{foodName}");
        }

        public void Play()
        {
            Console.WriteLine($"{FullName} is now happily playing");

        }
        public void Talk()
        {
            Console.WriteLine($"{FullName} is chirping happily!");
        }



    }

}
