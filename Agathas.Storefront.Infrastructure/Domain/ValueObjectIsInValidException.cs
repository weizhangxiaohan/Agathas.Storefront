using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Infrastructure.Domain
{
    public class ValueObjectIsInValidException : Exception
    {
        public ValueObjectIsInValidException(string message)
            : base(message)
        {

        }
    }
}
