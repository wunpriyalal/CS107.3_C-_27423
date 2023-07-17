using System;

namespace Q8
{
    internal class Program
    {

class Animal
        {
            public void Display()
            {
                Console.WriteLine("I am an animal");
            }
        }

        class Dog : Animal
        {
            public void DisplayDog()
            {
                Console.WriteLine("I have four legs");
            }
        }
            static void Main()
            {
                Animal animal = new Animal();
                animal.Display();

                Dog dog = new Dog();
                dog.Display();
                dog.DisplayDog();
            }
        }

    }