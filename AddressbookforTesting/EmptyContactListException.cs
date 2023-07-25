using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookforTesting
{
    public class EmptyContactListException : Exception
    {
        public EmptyContactListException(string message) : base(message) { }


    }
}
