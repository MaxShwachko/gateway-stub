namespace GatewayStub.Domain.Models.Dao
{
    public class SessionDao
    {
        public string AccessToken;
        public int ExpiresIn;
        public int RefreshExpiresIn;
        public string RefreshToken;
        public string TokenType;
        public byte NotBeforePolicy;
        public string SessionState;
        public string Scope;
        public string UserId;
        public string IdToken;
    }
}