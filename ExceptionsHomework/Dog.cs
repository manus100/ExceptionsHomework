using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExceptions;

namespace ExceptionsHomework
{
    class Dog
    {
        /*
         * Having the class Dog with Age and Name properties, add the next changes:

        - throw ArgumentException for negative age 
        - throw ApplicationException for age greater than 100
        - throw ApplicationException for name length lower than 2

        Then create a dog object in Main method using object initializer to set up the age and name. Watch for expected exceptions and send a friendly message to the user with the exception.
        */

        private string name;
        private int age;

        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length >= 2)
                {
                    name = value;
                }
                else
                {
                    throw new InvalidDogNameException();
                }
            }
        } 

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else if(value > 100)
                {
                    throw new InvalidAgeException();
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}
