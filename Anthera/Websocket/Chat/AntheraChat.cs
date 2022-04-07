using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Anthera_API.Websocket.Chat
{

    public class AntheraChat : Hub
    {
        private readonly string _antheraChatbot;

        public AntheraChat()
        {
            _antheraChatbot = "Anthera Bot";
        }

        public async Task JoinRoom(UserConnection userConnection)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, userConnection.Channel);

            await Clients.Group(userConnection.Channel)
                .SendAsync("RecieveMessage", _antheraChatbot, $"{userConnection.User} has joined {userConnection.Channel}");
        }
    }
}
