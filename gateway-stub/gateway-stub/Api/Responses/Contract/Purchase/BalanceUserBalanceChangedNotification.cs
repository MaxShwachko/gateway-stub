using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Purchase
{
    public class BalanceUserBalanceChangedNotification : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Purchase;
        public override byte MethodId => (byte) EMethodId.BalanceUserBalanceChangedNotification;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly string CurrencyType;
        public readonly string Amount;
        public readonly string TransactionHash;
        public readonly string Balance;
        public readonly string BlockId;
 
        public BalanceUserBalanceChangedNotification(EGatewayErrorCode errorCode, string currencyType, string amount, string transactionHash, string balance, string blockId)
        {
            ErrorCode = errorCode;
            CurrencyType = currencyType;
            Amount = amount;
            TransactionHash = transactionHash;
            Balance = balance;
            BlockId = blockId;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(CurrencyType);
            writer.Write(Amount);
            writer.Write(TransactionHash);
            writer.Write(Balance);
            writer.Write(BlockId);
        }
    }
}