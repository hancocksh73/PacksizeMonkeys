using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys
{
    public class NumberLessThanOneException : Exception
    {
        public NumberLessThanOneException() : base() { }
        public NumberLessThanOneException(string message) : base(message) { }
        public NumberLessThanOneException(string message, Exception innerException) : base(message, innerException) { }
        public NumberLessThanOneException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
