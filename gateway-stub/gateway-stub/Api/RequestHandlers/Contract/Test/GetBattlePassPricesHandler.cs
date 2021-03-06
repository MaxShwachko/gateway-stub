using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
	public class GetBattlePassPricesHandler : IContractRequestHandler
	{
		public byte AgentId => (byte) EAgentId.Test;
		public byte MethodId => (byte) EMethodId.GetBattlePassPrices;

		private readonly IWebSocketWrapper _socket;
		private readonly IDataContext _dataContext;

		public GetBattlePassPricesHandler(IWebSocketWrapper socket, IDataContext dataContext)
		{
			_socket = socket;
			_dataContext = dataContext;
		}

		public async Task Handle(IContractRequestData request)
		{
			Console.WriteLine("GetBattlePassPrices message received");
			var battlePassPrices = _dataContext.BattlePass.Prices;
			await _socket.Send(new GetBattlePassPricesResponse(EGatewayErrorCode.Success, battlePassPrices));
		}
	}
}