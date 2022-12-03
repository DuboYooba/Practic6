using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива до числа: ");
            int size = int.Parse(Console.ReadLine());
            int[] myArray = Enumerable.Range(1, size).ToArray();
            for (int i = 0; i < myArray.Length; i++) 
            {
                Console.Write(myArray[i]+ "  " );
            }
            Console.Write("\nВведите число: ");
            int number = int.Parse(Console.ReadLine());
            while (Enumerable.Range(1, size).Contains(number))
            {
                number -= 1;
                Console.WriteLine($"Число {number} x2 {number * 2}");
            }
            
            
        }
    }
}
