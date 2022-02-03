using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Lobby
{
    public class UserUpdateProfileImageRequest : IContractRequestData
    {
        public readonly byte Image;

        public UserUpdateProfileImageRequest(byte image)
        {
            Image = image;
        }
    }
}