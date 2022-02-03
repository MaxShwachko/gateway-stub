namespace GatewayStub.Api.Enums
{
    public enum EGatewayErrorCode
    {
        UnknownError               = -1,
        Success                    = 0,
        CodeIsAlreadyUsed          = 7,
        InvalidConfirmationCode    = 5233,
        UserDoesntExists           = 5425,
        AccessDenied               = 5666,
        PasswordMinLength          = 6273,
        AlreadySent                = 6291,
        SessionsError              = 6435,
        InvalidCredentials         = 8560,
        ExpiredLink                = 16661,
        UserAlreadyExists          = 18514,
        InvalidToken               = 25873,
        NotEnoughPermissions       = 28952,
        WrongToken                 = 30752,
        CodeExpired                = 31013,
        Unauthorized               = 33056,
        InvalidRefreshToken        = 1601813,
        DeleteUser                 = 2437657,
        PromoInternalError         = 2720273,
        CodeNotExists              = 4473108,
        UnconfirmedEmail           = 4522516,
        UserAttemptsExhausted      = 5263895,
        AlreadyBanned              = 5538064,
        AuthInternalError          = 9785625

    }
}