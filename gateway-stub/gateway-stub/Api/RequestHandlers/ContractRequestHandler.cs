using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests;
using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestHandlers
{
    public class  ContractRequestHandler : IRequestHandler
    {
        public byte Header => (byte) EHeader.Contract;

        private Dictionary<Tuple<byte, byte>, IContractRequestHandler> _handlers;

        public ContractRequestHandler(IEnumerable<IContractRequestHandler> handlers)
        {
            _handlers = handlers.ToDictionary(handler => new Tuple<byte, byte>(handler.AgentId, handler.MethodId));
        }

        public async Task Handle(IRequest request)
        {
            var contractRequest = (ContractRequest) request;
            var key = new Tuple<byte, byte>(contractRequest.AgentId, contractRequest.MethodId);
            if (!_handlers.ContainsKey(key))
            {
                Console.WriteLine($"No handler for contract message with agentId = {contractRequest.AgentId} and methodId = {contractRequest.MethodId}");
                return;
            }

            var handler = _handlers[key];
            await handler.Handle(contractRequest.Data);
        }
    }
}