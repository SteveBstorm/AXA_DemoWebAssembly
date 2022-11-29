using DemoWebAssembly.Client.Services;
using Microsoft.AspNetCore.Components;

namespace DemoWebAssembly.Client.Pages
{
    public class Demo1Base : ComponentBase, IAsyncDisposable
    {
        [Parameter]
        public int id { get; set; }
        [Inject]
        public FakeDataContext MyService { get; set; }
        public int Nombre { get; set; }
        public string SelectedItem { get; set; }

        public void ChangeValue(string s)
        {
            SelectedItem = s;
        }

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
