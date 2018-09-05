using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfaTechnologies.Exceptions
{

    [Serializable]
    public class EntityExistsException : Exception
    {
        public EntityExistsException() { }
        public EntityExistsException(string message) : base(message) { }
        public EntityExistsException(string message, Exception inner) : base(message, inner) { }
        protected EntityExistsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
