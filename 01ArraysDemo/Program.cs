using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            // Collection of elements having the same name, same size, stored sequentially
            // index is zero based 
            // refernce type 

            int[] arr = new int[4];

            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;

            for(int i=0;i<4;i++)
                Console.WriteLine(arr[i]);

            string[] coutries = new string[] {"India","China","Singapore" };

        }
    }
}
