using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
	public class ClaimAllOldBattlePassRewardsHandler : IContractRequestHandler
	{
		public byte AgentId => (byte) EAgentId.Test;
		public byte MethodId => (byte) EMethodId.ClaimAllOldBattlePassRewards;

		private readonly IWebSocketWrapper _socket;
		private readonly IDataContext _dataContext;

		public ClaimAllOldBattlePassRewardsHandler(IWebSocketWrapper socket, IDataContext dataContext)
		{
			_socket = socket;
			_dataContext = dataContext;
		}

		public async Task Handle(IContractRequestData request)
		{
			Console.WriteLine("ClaimAllOldBattlePassRewards message received");
			var oldRewards = _dataContext.BattlePass.OldRewards;
			await _socket.Send(new ClaimAllOldBattlePassRewardsResponse(EGatewayErrorCode.Success, oldRewards));
		}
	}
}