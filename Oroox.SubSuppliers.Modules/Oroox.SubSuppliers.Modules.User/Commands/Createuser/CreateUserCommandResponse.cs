using System;

namespace Oroox.SubSuppliers.Modules.User.Commands
{
    public class CreateUserCommandResponse
    {
        public Guid Guid => System.Guid.NewGuid();
    }
}