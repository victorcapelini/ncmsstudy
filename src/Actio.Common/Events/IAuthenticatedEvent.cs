using System;

namespace Actio.Common.Events
{
    public interface IAuthenticatedEvent
    {
        public Guid Id { get; }
    }
}