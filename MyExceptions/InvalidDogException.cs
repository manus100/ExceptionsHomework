using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
  public  class InvalidDogException : ApplicationException
    {
        public InvalidDogException(string message = "Invalid dog") : base(message)
        {

        }
    }
}
