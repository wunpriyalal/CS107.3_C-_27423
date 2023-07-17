using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter the value: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("The scalar/linear summation of the array is: " ,sum);
            Console.ReadLine();
        }
    }
}