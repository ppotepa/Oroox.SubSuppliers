using MediatR;
using Serilog;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.User.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserCommandResponse>
    {
        private readonly ILogger logger;
        private readonly IMediator mediator;

        public CreateUserCommandHandler(ILogger logger, IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            await this.mediator.Publish(new UserAccountCreated(request));
            return new CreateUserCommandResponse();
        }
    }
}