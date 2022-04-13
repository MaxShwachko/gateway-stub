using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
	public class GetBattlePassSeasonInfoHandler : IContractRequestHandler
	{
		public byte AgentId => (byte) EAgentId.Test;
		public byte MethodId => (byte) EMethodId.GetBattlePassSeasonInfo;

		private readonly IWebSocketWrapper _socket;
		private readonly IDataContext _dataContext;

		public GetBattlePassSeasonInfoHandler(IWebSocketWrapper socket, IDataContext dataContext)
		{
			_socket = socket;
			_dataContext = dataContext;
		}

		public async Task Handle(IContractRequestData request)
		{
			Console.WriteLine("GetBattlePassSeasonInfo message received");
			var currentBattlePassSeason = _dataContext.BattlePass.CurrentSeason;
			await _socket.Send(new GetBattlePassSeasonInfoResponse(EGatewayErrorCode.Success, currentBattlePassSeason));
		}
	}
}