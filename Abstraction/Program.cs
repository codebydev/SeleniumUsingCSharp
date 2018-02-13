using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Mammal();
            a.Move();

            a = new Birds();
            a.Move();
        }
    }

    abstract class Animal
    {
        protected int x;
        public abstract void Move();        
    }

    class Mammal:Animal
    {
        public override void Move()
        {
            Console.WriteLine("Mammal runs");
        }
    }

    class Birds: Animal
    {
        public override void Move()
        {
            Console.WriteLine("Birds fly");
        }
    }
}
