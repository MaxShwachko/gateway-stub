using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Auth
{
    public class AuthCreateRequestToConfirmEmailRequest : IContractRequestData
    {
        public readonly string Email;
        public readonly string ReferralCode;

        public AuthCreateRequestToConfirmEmailRequest(string email, string referralCode)
        {
            Email = email;
            ReferralCode = referralCode;
        }
    }
}