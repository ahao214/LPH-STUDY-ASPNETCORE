using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;

namespace BlazorApp3.Components
{
    public partial class Dummy
    {
        private string? ClassString => CssBuilder.Default("btn").AddClass(Color, !string.IsNullOrEmpty(Color)).Build();

        [Parameter]
        public string? Color { get; set; }

        private void OnClick()
        {
            System.Console.WriteLine("button click");
        }


    }
}