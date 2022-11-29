using Microsoft.AspNetCore.Components;

namespace DemoWebAssembly.Client.Pages
{
    public partial class SousComposant
    {
        [Parameter]
        public string Param { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }
    }
}
