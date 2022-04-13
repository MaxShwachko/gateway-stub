using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
	public class GetCurrentBattlePassExperienceHandler : IContractRequestHandler
	{
		public byte AgentId => (byte) EAgentId.Test;
		public byte MethodId => (byte) EMethodId.GetCurrentBattlePassExperience;

		private readonly IWebSocketWrapper _socket;
		private readonly IDataContext _dataContext;

		public GetCurrentBattlePassExperienceHandler(IWebSocketWrapper socket, IDataContext dataContext)
		{
			_socket = socket;
			_dataContext = dataContext;
		}

		public async Task Handle(IContractRequestData request)
		{
			Console.WriteLine("GetCurrentBattlePassExperience message received");
			var scrollsAmount = _dataContext.Equipment.ItemScrollsAmount;
			await _socket.Send(new GetCurrentBattlePassExperienceResponse(EGatewayErrorCode.Success, scrollsAmount));
		}
	}
}