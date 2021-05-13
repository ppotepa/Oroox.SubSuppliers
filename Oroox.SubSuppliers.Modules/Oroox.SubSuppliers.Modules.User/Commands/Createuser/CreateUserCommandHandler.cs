using MediatR;
using Serilog;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.User.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserCommandResponse>
    {
        private readonly ILogger logger;
        public CreateUserCommandHandler(ILogger logger)
        {
            this.logger = logger;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            await Task.Delay(100);
            return new CreateUserCommandResponse();
        }
    }
}