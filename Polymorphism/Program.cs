using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Display();
            Display(10);
            Display('d');
            
        }

        public static void Display()
        {
            Console.WriteLine("No data");
        }

        public static void Display(int x)
        {
            Console.WriteLine("Printing x value "+x);
            
        }

        public static void Display(char ch)
        {

        }
    }
}
