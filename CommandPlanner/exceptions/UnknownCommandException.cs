// -----------------------------------------------------------------------
// <copyright file="UnknownCommandException.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace CommandPlanner.exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class UnknownCommandException : System.ApplicationException
    {
        public UnknownCommandException() { }
        public UnknownCommandException(string message) { }
        public UnknownCommandException(string message, System.Exception inner) { }

        // Constructor needed for serialization 
        // when exception propagates from a remoting server to the client.
        protected UnknownCommandException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}
