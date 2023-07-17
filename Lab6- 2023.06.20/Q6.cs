using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
            static void Main()
            {
                Console.WriteLine("Enter the size of the array:");
                int size = Convert.ToInt32(Console.ReadLine());

                MyClass myClass = new MyClass();
                int[] array = myClass.CreateArray(size);

                Console.WriteLine("Enter values for the array:");

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Value {i + 1}: ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    array[i] = value;
                    array[i + 1] = 0;
                }

                Console.WriteLine("\nValues in the array:");

                foreach (int num in array)
                {
                    Console.WriteLine(num);
                }
            }
        }

        class MyClass
        {
            public int[] CreateArray(int size)
            {
                return new int[size];
            }
        }

    }
