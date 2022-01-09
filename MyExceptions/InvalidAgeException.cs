using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
  public  class InvalidAgeException : InvalidDogException
    {
        public InvalidAgeException(string message="Maximmum accepted value for age is 100"): base(message)
        {

        }
    }
}
