using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.ListeriaStorage;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
	public class InventoryGetItemScrollsCountHandler : IContractRequestHandler
	{
		public byte AgentId => (byte) EAgentId.Test;
		public byte MethodId => (byte) EMethodId.InventoryGetItemScrollsCount;

		private readonly IWebSocketWrapper _socket;
		private readonly IDataContext _dataContext;

		public InventoryGetItemScrollsCountHandler(IWebSocketWrapper socket, IDataContext dataContext)
		{
			_socket = socket;
			_dataContext = dataContext;
		}

		public async Task Handle(IContractRequestData request)
		{
			Console.WriteLine("InventoryGetItemScrollsCount message received");
			var scrollsAmount = _dataContext.Equipment.ItemScrollsAmount;
			await _socket.Send(new InventoryGetItemScrollsCountResponse(EGatewayErrorCode.Success, scrollsAmount));
		}
	}
}