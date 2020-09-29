using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_Decisons
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Please enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            if (age <= 0)
            {
                Console.WriteLine("How are you typing if you're not born yet?");
                Console.ReadLine();
            }
            else if (age <= 5)
            {
                Console.WriteLine("You are a toddler");
                Console.ReadLine();
            }

            else if (age <= 10)
            {
                Console.WriteLine("You are a child");
                Console.ReadLine();
            }
            else if (age <= 12)
            {
                Console.WriteLine("You are a preteen");
                Console.ReadLine();
            }
            else if (age < 18)
            {
                Console.WriteLine("You are a teen");
                Console.ReadLine();
            }
            else if (age <= 65)
            {
                Console.WriteLine("You are an adult");
                Console.ReadLine();
            }
            else if (age >= 65)
            {
                Console.WriteLine("Enjoy your seniors discount!");
                Console.ReadLine();
            }

        }
    }
}
