using MediatR;

namespace Oroox.SubSuppliers.Modules.User.Commands
{
    public class CreateUserCommand : IRequest<CreateUserCommandResponse>
    {
        public string Name { get; set; }
    }
}