﻿using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
    public class GetScrollsResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Test;
        public override byte MethodId => (byte) EMethodId.GetScrolls;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly int Amount;

        public GetScrollsResponse(EGatewayErrorCode errorCode, int amount)
        {
            ErrorCode = errorCode;
            Amount = amount;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(Amount);
        }
    }
}