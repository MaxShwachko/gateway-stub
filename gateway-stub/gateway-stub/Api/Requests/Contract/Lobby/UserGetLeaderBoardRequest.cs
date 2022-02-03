using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Lobby
{
    public class UserGetLeaderBoardRequest : IContractRequestData
    {
        public readonly short Page;

        public UserGetLeaderBoardRequest(short page)
        {
            Page = page;
        }
    }
}