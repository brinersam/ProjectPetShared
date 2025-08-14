using System.Runtime.Serialization;

namespace ProjectPet.SharedKernel.Exceptions;
[Serializable]
public class DomainEventException : Exception
{
    public DomainEventException(string message)
        : base(message)
    { }

    protected DomainEventException(SerializationInfo info, StreamingContext ctxt)
        : base(info, ctxt)
    { }
}