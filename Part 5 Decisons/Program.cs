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
            Console.WriteLine("Enter a hurricane category that you'd like to learn about");
            int caseSwitch;
            Int32.TryParse(Console.ReadLine(), out caseSwitch);
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Category 1 hurricanes have a speed of 74mph-95mph (119kmph-153kmph)");
                    break;
                case 2:
                    Console.WriteLine("Category 2 hurricanes have a speed of 96mph-110mph (154kmph-177kmph)");
                    break;
                case 3:
                    Console.WriteLine("Category 3 hurricanes have a speed of 111mph-130mph (178kmph-209kmph)");
                    break;
                case 4:
                    Console.WriteLine("Category 4 hurricanes have a speed of 131mph-155mph (210kmph-249kmph)");
                    break;
                case 5:
                    Console.WriteLine("Category 5 hurricanes have a speed of 155mph (250kmph) or greater");
                    break;
                default:
                    Console.WriteLine("That is not a hurricane category");
                    break;
            }

            Random generator = new Random();
            int compNum = generator.Next(2, 7);
            int userNum;
            int difference;
            Console.WriteLine($"Please type a number larger than: {compNum}");
            userNum = Convert.ToInt32(Console.ReadLine());
            difference = userNum % compNum;

            if (difference > 1)
                Console.WriteLine("That is not divisible");
            else
            {
                difference = 0;
                Console.WriteLine("That is divisible");
            }

            Console.ReadLine();

        }
    }
}
