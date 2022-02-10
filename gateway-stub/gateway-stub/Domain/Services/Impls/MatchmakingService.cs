using GatewayStub.Domain.Data;

namespace GatewayStub.Domain.Services.Impls
{
    public class MatchmakingService : IMatchmakingService
    {
        private readonly IDataContext _dataContext;

        public MatchmakingService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        
        
    }
}