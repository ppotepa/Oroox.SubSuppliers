using MediatR;

namespace Oroox.SubSuppliers.Modules.User
{
    public class TestRequest : IRequest<TestRequestCommandResponse>
    {
        public string Name { get; set; }
    }
}