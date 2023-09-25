using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Part_4._5_intro_to_methods_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Console.WriteLine("Look at my pets.");
            Console.WriteLine();
            Bat();
            Frog();
            Duck();
            Knockknockjoke(generator.Next(1, 11));
        }
        public static void Bat()
        {
            Console.WriteLine("My pet bat.");
            Console.WriteLine("  _   ,_,   _");
            Console.WriteLine(" / `'=) (='` \\");
            Console.WriteLine("/.-.-.\\ /.-.-.\\ ");
            Console.WriteLine("`      \"      `");
        }
        public static void Frog()
        {
            Console.WriteLine("My pet frog.");
            Console.WriteLine("              _");
            Console.WriteLine("  __   ___.--'_`.");
            Console.WriteLine(" ( _`.'. -   'o` )");
            Console.WriteLine(" _\\.'_'      _.-'");
            Console.WriteLine("( \\`. )    //\\`");
            Console.WriteLine(" \\_`-'`---'\\\\__,");
            Console.WriteLine("  \\`        `-\\");
            Console.WriteLine("   `");
        }
        public static void Duck()
        {
            Console.WriteLine("My pet duck.");
            Console.WriteLine("      ,~~.");
            Console.WriteLine("     (  O )-_,");
            Console.WriteLine("(\\___ )=='-'");
            Console.WriteLine(" \\ .   ) )");
            Console.WriteLine("  \\_`-'_/   ");
        }
        public static void Knockknockjoke(int joke)
        {
            if (joke == 1)
            {
                Console.WriteLine("Knock knock.");
                Console.WriteLine("Who's there?" + Console.ReadLine());
                Console.WriteLine("Boo.");
                Console.WriteLine("Boo who?" + Console.ReadLine());
                Console.WriteLine("Don't cry it's just a joke.");
            }
            if (joke == 2)
            {
                Console.WriteLine("Knock knock.");
                Console.WriteLine("Who's there?" + Console.ReadLine());
                Console.WriteLine("Oldest.");
                Console.WriteLine("Oldest who?" + Console.ReadLine());
                Console.WriteLine("Oldest knocking wears me out.");
            }
            if (joke == 3)
            {
                Console.WriteLine("Knock knock.");
                Console.WriteLine("Who's there?" + Console.ReadLine());
                Console.WriteLine("Owls.");
                Console.WriteLine("Owls who?" + Console.ReadLine());
                Console.WriteLine("They sure do!");
            }
            if (joke == 4)
            {
                Console.WriteLine("Knock knock.");
                Console.WriteLine("Who's there?" + Console.ReadLine());
                Console.WriteLine("Cargo.");
                Console.WriteLine("Cargo who?" + Console.ReadLine());
                Console.WriteLine("Car go BEEP BEEP!");
            }
            if (joke == 5)
            {
                Console.WriteLine("Knock knock.");
                Console.WriteLine("Who's there?" + Console.ReadLine());
                Console.WriteLine("Kenya.");
                Console.WriteLine("Kenya who?" + Console.ReadLine());
                Console.WriteLine("Kenya open the door?");
            }
            if (joke == 6)
            {
                Console.WriteLine("Knock knock.");
                Console.WriteLine("Who's there?" + Console.ReadLine());
                Console.WriteLine("I eat mop");
                Console.WriteLine("I eat mop who?" + Console.ReadLine());
                Console.WriteLine("Ew.");
            }
            if (joke == 7)
            {
                Console.WriteLine("Knock knock.");
                Console.WriteLine("Who's there?" + Console.ReadLine());
                Console.WriteLine("To");
                Console.WriteLine("To who?" + Console.ReadLine());
                Console.WriteLine("It's to whom.");
            }
            if (joke == 8)
            {
                Console.WriteLine("Knock knock.");
                Console.WriteLine("Who's there?" + Console.ReadLine());
                Console.WriteLine("Dejav");
                Console.WriteLine("Dejav who?" + Console.ReadLine());
                Console.WriteLine("Knock knock.");
            }
            if (joke == 9)
            {
                Console.WriteLine("Knock knock.");
                Console.WriteLine("Who's there?" + Console.ReadLine());
                Console.WriteLine("Art");
                Console.WriteLine("Art who?" + Console.ReadLine());
                Console.WriteLine("R2D2!");
            }
            if (joke == 10)
            {
                Console.WriteLine("Knock knock.");
                Console.WriteLine("Who's there?" + Console.ReadLine());
                Console.WriteLine("Hutch");
                Console.WriteLine("Hutch who?" + Console.ReadLine());
                Console.WriteLine("Bless you!");
            }
        }
    }
}
