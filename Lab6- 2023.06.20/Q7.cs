using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
            static void Main()
            {
                Console.WriteLine("Enter the size of the arrays:");
                int size = Convert.ToInt32(Console.ReadLine());

                int[] array1 = new int[size];
                int[] array2 = new int[size];

                Console.WriteLine("Enter values for the first array:");

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Value {i + 1}: ");
                    array1[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Enter values for the second array:");

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Value {i + 1}: ");
                    array2[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Scalar Sum
                int scalarSum = 0;
                for (int i = 0; i < size; i++)
                {
                    scalarSum += array1[i] + array2[i];
                }

                // Vector Sum
                int[] vectorSum = new int[size];
                for (int i = 0; i < size; i++)
                {
                    vectorSum[i] = array1[i] + array2[i];
                }

                // Vector Product
                int[] vectorProduct = new int[size];
                for (int i = 0; i < size; i++)
                {
                    vectorProduct[i] = array1[i] * array2[i];
                }

                // Scalar Product
                int scalarProduct = 0;
                for (int i = 0; i < size; i++)
                {
                    scalarProduct += array1[i] * array2[i];
                }

                Console.WriteLine("\nScalar Sum: " + scalarSum);
                Console.WriteLine("Vector Sum:");
                DisplayArray(vectorSum);
                Console.WriteLine("Vector Product:");
                DisplayArray(vectorProduct);
                Console.WriteLine("Scalar Product: " + scalarProduct);
            }

            static void DisplayArray(int[] array)
            {
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }

    }
