using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
   public class InvalidDogNameException : InvalidDogException
    {
        public InvalidDogNameException(string message = "Dog name should have at least 2 characters") : base(message)
        {

        }
    }
}
