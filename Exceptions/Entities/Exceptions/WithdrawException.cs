using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Entities.Exceptions
{
    class WithdrawException: ApplicationException
    {
        public WithdrawException(string message) : base(message)
        {

        }
    }
}
