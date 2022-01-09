using System;
using MyExceptions;

namespace ExceptionsHomework
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
               // Dog myDog = new Dog("A",3);
               // Dog myDog = new Dog("Azorel", 101);
                Dog myDog = new Dog("Azorel", -5);
            }
            catch (InvalidDogNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch  (System.ArgumentException)
            {
                Console.WriteLine("Age should be a positive number");
            }

            finally
            {
                Console.WriteLine("Great! It really works!");
            }
        }
    }
}
