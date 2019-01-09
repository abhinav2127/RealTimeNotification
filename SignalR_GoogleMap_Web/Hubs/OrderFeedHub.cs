using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using SignalR_GoogleMap_Sqlite.Model;
using SignalR_GoogleMap_Sqlite.Repository;
using System.Collections.Generic;

namespace SignalR_GoogleMap_Web.Hubs
{
    public class OrderFeedHub : Hub
    {
        private readonly ISqliteProvider _provider;
        public OrderFeedHub(ISqliteProvider provider)
        {
            _provider=provider;
        }
        public async Task<List<Order>> SendOrderDetail()
        {
            return _provider.GetAll();
        }
    }
}