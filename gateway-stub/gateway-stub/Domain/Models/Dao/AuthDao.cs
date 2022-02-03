namespace GatewayStub.Domain.Models.Dao
{
    public class AuthDao
    {
        public bool AssignProviderAccountToDeviceIdSuccess;
        public bool ConfirmPasswordSuccess;
        public bool AuthDeleteEmailSuccess;
        public bool EmptyMethodSuccess;
        public bool LogoutSuccess;
        public bool ResentConfirmationMailSuccess;
        public bool ResetPasswordSuccess;
        public bool SendRequestToResetPasswordSuccess;
        public string PasswordHash;
        public string EmailHash;
        public SessionDao Session;
    }
}