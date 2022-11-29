using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;


namespace DemoWebAssembly.Client.Pages
{
    public partial class Chat
    {
        [Inject]
        public NavigationManager _nav {get; set; }
        public List<string> Messages { get; set; }

        public string NewMessage { get; set; }

        protected HubConnection _hub;
        protected override async Task OnInitializedAsync()
        {
            Messages = new List<string>();

            _hub = new HubConnectionBuilder()
                .WithUrl("https://localhost:7184/chat").Build();

            _hub.On<string>("receiveMessage", 
                (message) => { Messages.Add(message);
                    Console.WriteLine(message);
                    StateHasChanged();
                });

            
            await _hub.StartAsync();
            //await _hub.SendAsync("JoinGroup", "mongroup");
        }

        public async void SendMessage()
        {
            Console.WriteLine(NewMessage);
            await _hub.SendAsync("SendMessage", NewMessage);

            StateHasChanged();
        }
    }
}
