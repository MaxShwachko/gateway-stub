using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
	public class PurchaseBattlePassExperienceToLevelupHandler : IContractRequestHandler
	{
		public byte AgentId => (byte) EAgentId.Test;
		public byte MethodId => (byte) EMethodId.PurchaseBattlePassExperienceToLevelup;

		private readonly IWebSocketWrapper _socket;
		private readonly IDataContext _dataContext;

		public PurchaseBattlePassExperienceToLevelupHandler(IWebSocketWrapper socket, IDataContext dataContext)
		{
			_socket = socket;
			_dataContext = dataContext;
		}

		public async Task Handle(IContractRequestData request)
		{
			Console.WriteLine("PurchaseBattlePassExperienceToLevelup message received");
			await _socket.Send(new PurchaseBattlePassExperienceToLevelupResponse(EGatewayErrorCode.Success));
		}
	}
}