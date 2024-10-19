using Microsoft.AspNetCore.SignalR;
using PKHeX.Core;
namespace santacrab2.github.io
{
    public class SysbotHub : Hub
    {
        public async Task sendConvert(ShowdownSet set)
        {

            await Clients.User("sysb").SendAsync("Convert", set);
        }
        public async Task ReceiveConvert(PKM pk)
        {
            await Clients.User("site").SendAsync("DLPK", pk);
        }
    }
}
