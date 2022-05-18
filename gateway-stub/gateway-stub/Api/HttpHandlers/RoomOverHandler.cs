using System;
using System.Threading.Tasks;
using GatewayStub.Core.Exchange;
using GatewayStub.Domain.Data;
using Microsoft.AspNetCore.Http;

namespace GatewayStub.Api.HttpHandlers
{
    public class RoomOverHandler : IHttpHandler
    {
        private readonly IDataContext _dataContext;
        public string Route => "over";

        public RoomOverHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task<int> Handle(HttpRequest request)
        {
            Console.WriteLine("RoomOverHandler handle");
            return Task.FromResult(StatusCodes.Status200OK);
        }
    }
}