using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Chat.Hubs
{

    public class ChatHub : Hub
    {
        /// <summary>
        /// 发送信息
        /// </summary>
        /// <param name="user"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public async Task SendMsg(string user, string msg)
        {
            await Clients.All.SendAsync("ReceiveMsg", user, msg);
        }

    }
}
