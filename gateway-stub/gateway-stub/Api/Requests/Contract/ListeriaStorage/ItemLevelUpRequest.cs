using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.ListeriaStorage
{
	public class ItemLevelUpRequest : IContractRequestData
	{
		public readonly int ItemUid;

		public ItemLevelUpRequest(int itemUid)
		{
			ItemUid = itemUid;
		}
	}
}