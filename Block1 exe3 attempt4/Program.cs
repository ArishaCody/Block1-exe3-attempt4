using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1_exe3_attempt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string location;
            string zodiacSign;
            string profession;

            Console.Write("What is your name?");
            name = Console.ReadLine();
            Console.Write("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Where are you from?");
            location = Console.ReadLine();
            Console.Write("What is your zodiac sign?");
            zodiacSign = Console.ReadLine();
            Console.Write("What is your profession?");
            profession = Console.ReadLine();

            Console.WriteLine("Your name is- " + name + "." + "Your age-" + age + "." + "Are you from- " + location + "." + "Your zodiac sign is-" + zodiacSign + "." + "Your profession is- " + profession + ".");

        }
    }
}
