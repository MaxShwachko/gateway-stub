using System;
using System.Linq;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.ListeriaStorage;
using GatewayStub.Api.Requests.Contract.Test;
using GatewayStub.Api.Responses.Contract.ListeriaStorage;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.ListeriaStorage
{
	public class ItemLevelUpHandler : IContractRequestHandler
	{
		public byte AgentId => (byte) EAgentId.ListeriaStorage;
		public byte MethodId => (byte) EMethodId.InventoryEndpointsLevelUp;

		private readonly IWebSocketWrapper _socket;
		private readonly IDataContext _dataContext;

		public ItemLevelUpHandler(IWebSocketWrapper socket, IDataContext dataContext)
		{
			_socket = socket;
			_dataContext = dataContext;
		}

		public async Task Handle(IContractRequestData request)
		{
			var itemLevelUpRequest = (ItemLevelUpRequest) request;
			Console.WriteLine("ItemLevelUpHandler message received");
			var itemDto = _dataContext.Equipment.Equipment.FirstOrDefault(h => h.BindingUid == itemLevelUpRequest.ItemUid);
			await _socket.Send(new ItemLevelUpResponse(EGatewayErrorCode.Success, true));
			await _socket.Send(new EquipmentEndpointsUpdatedItemNotification(EGatewayErrorCode.Success, itemDto));
		}
	}
}