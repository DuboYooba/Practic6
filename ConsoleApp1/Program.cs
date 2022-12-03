using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {45, 59, 12, 60, 1, 47, 1428, 925 };
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + " ");
            int max = 0;
            for (int i = 0; i < myArray.Length; ++i)
                if (myArray[i] > myArray[max])
                    max = i;
            myArray[0] ^= myArray[max];
            myArray[max] ^= myArray[0];
            myArray[0] ^= myArray[max];
            Console.Write("\n-------------------------\n");
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + " ");
            Console.Write("\n");
        }   
    }
}
