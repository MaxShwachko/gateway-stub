using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Test;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Test
{
    public class LevelupHeroDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.Test;
        public byte MethodId => (byte) EMethodId.LevelupHero;

        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var heroId = reader.ReadInt32();

            return new LevelupHeroRequest(heroId);
        }
    }
}