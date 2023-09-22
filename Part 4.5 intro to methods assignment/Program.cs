using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4._5_intro_to_methods_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bat();
            Frog();
        }
        public static void Bat()
        {
            Console.WriteLine("        _   ,_,   _");
            Console.WriteLine("       / `'=) (='` \\");
            Console.WriteLine("      /.-.-.\\ /.-.-.\\ ");
            Console.WriteLine("      `      \"      `");
        }
        public static void Frog()
        {
            Console.WriteLine("              _");
            Console.WriteLine("  __   ___.--'_`.");
            Console.WriteLine(" ( _`.'. -   'o` )");
            Console.WriteLine(" _\\.'_'      _.-'");
            Console.WriteLine("( \\`. )    //\\`");
            Console.WriteLine(" \\_`-'`---'\\\\__,");
            Console.WriteLine("  \\`        `-\\");
            Console.WriteLine("   `");
        }
    }
}
