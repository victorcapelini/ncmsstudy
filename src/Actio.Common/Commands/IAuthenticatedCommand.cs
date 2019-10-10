using System;

namespace Actio.Common.Commands
{
    public interface IAuthenticatedCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}