namespace GatewayStub.Api.Enums
{
    public enum HandshakeErrorCode : byte
    {
        WrongVersion = 1,
        InvalidSessionToken = 2,
        OtherError = 3
    }
}