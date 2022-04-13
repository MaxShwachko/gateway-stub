using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Test;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
	public class UpgradeBattlePassTypeHandler : IContractRequestHandler
	{
		public byte AgentId => (byte) EAgentId.Test;
		public byte MethodId => (byte) EMethodId.UpgradeBattlePassType;

		private readonly IWebSocketWrapper _socket;
		private readonly IDataContext _dataContext;

		public UpgradeBattlePassTypeHandler(IWebSocketWrapper socket, IDataContext dataContext)
		{
			_socket = socket;
			_dataContext = dataContext;
		}

		public async Task Handle(IContractRequestData request)
		{
			var upgradeBattlePassTypeRequest = (UpgradeBattlePassTypeRequest) request;
			Console.WriteLine("UpgradeBattlePassType message received");
			await _socket.Send(new UpgradeBattlePassTypeResponse(EGatewayErrorCode.Success, upgradeBattlePassTypeRequest.Type));
		}
	}
}