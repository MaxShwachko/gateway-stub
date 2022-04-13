using GatewayStub.Core.Exchange;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Requests.Contract.Test
{
	public class UpgradeBattlePassTypeRequest : IContractRequestData
	{
		public EBattlePassType Type;

		public UpgradeBattlePassTypeRequest(EBattlePassType type)
		{
			Type = type;
		}
	}
}