using System.Threading.Tasks;

namespace GatewayStub.Core.Exchange
{
    public interface IRequestHandler
    {
        byte Header { get; }

        Task Handle(IRequest request);
    }
}