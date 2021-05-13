using MediatR;

namespace Oroox.SubSuppliers.Modules.User.Commands
{
    public class UserAccountCreated : INotification
    {
        private readonly CreateUserCommand command;
        public UserAccountCreated(CreateUserCommand command)
        {
            this.command = command;
        }
    }

    public class CreateUserCommand : IRequest<CreateUserCommandResponse>
    {
        public string Name { get; set; }
    }
}