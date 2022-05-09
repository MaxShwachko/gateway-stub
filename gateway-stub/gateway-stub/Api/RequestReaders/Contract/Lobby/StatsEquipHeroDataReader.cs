using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Lobby;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Lobby
{
    public class StatsEquipHeroDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.HeroesEndpointsEquipHero;

        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var bindingUid = reader.ReadInt32();

            return new StatsEquipHeroRequest(bindingUid);
        }
    }
}