﻿using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Market;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Market
{
    public class ItemsGetListOfAvailableDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Market;
        public byte MethodId => (byte) EMethodId.ItemsGetListOfAvailable;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            return new ItemsGetListOfAvailableRequest();
        }
    }
}