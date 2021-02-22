using System;

namespace Builder.Domain.Exceptions
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
    public class BuilderDomainException : Exception
    {
        public BuilderDomainException()
        { }

        public BuilderDomainException(string message)
            : base(message)
        { }

        public BuilderDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}