﻿using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.ListeriaStorage;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.ListeriaStorage
{
    public class InventoryGetLootboxesListDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.ListeriaStorage;
        public byte MethodId => (byte) EMethodId.InventoryGetLootboxesList;

        public IContractRequestData ReadRequest(ByteReader reader)
        {
            return new InventoryGetLootboxesListRequest();
        }
    }
}