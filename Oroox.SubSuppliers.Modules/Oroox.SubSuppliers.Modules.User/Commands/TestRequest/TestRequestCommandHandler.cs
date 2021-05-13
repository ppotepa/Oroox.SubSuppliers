using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.User
{
    public class TestRequestCommandHandler : IRequestHandler<TestRequest, TestRequestCommandResponse>
    {
        private readonly ILogger<TestRequest> logger;
        public TestRequestCommandHandler(ILogger<TestRequest> logger)
        {
            this.logger = logger;
        }

        public async Task<TestRequestCommandResponse> Handle(TestRequest request, CancellationToken cancellationToken)
        {
            logger.LogInformation("TestRequestCommandHandler");
            await Task.Delay(new Random().Next(10, 100));
            return new TestRequestCommandResponse();
        }
    }
}