using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo2 d = new Demo2();
            d.Show();
        }
    }

    class Demo1
    {
        public void Show()
        {
            Console.WriteLine("Show method");
        }
    }

    class Demo2:Demo1
    {

    }
}
