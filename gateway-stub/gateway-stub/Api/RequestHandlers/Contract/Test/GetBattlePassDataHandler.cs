using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
	public class GetBattlePassDataHandler : IContractRequestHandler
	{
		public byte AgentId => (byte) EAgentId.Test;
		public byte MethodId => (byte) EMethodId.GetBattlePassData;

		private readonly IWebSocketWrapper _socket;
		private readonly IDataContext _dataContext;

		public GetBattlePassDataHandler(IWebSocketWrapper socket, IDataContext dataContext)
		{
			_socket = socket;
			_dataContext = dataContext;
		}

		public async Task Handle(IContractRequestData request)
		{
			Console.WriteLine("GetBattlePassData message received");
			var battlePassProgression = _dataContext.BattlePass.Progression;
			var userRewards = _dataContext.BattlePass.UserRewards;
			await _socket.Send(new GetBattlePassDataResponse(EGatewayErrorCode.Success, battlePassProgression, userRewards));
		}
	}
}