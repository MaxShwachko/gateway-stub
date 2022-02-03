using System.Threading.Tasks;

namespace GatewayStub.Core.Exchange
{
    public interface IContractRequestHandler
    {
        byte AgentId { get; }
        byte MethodId { get; }

        Task Handle(IContractRequestData request);
    }
}