using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorApp1.Pages;

public partial class Index
{
    [Inject] public required IJSRuntime JSRuntime { get; init; }
    protected override void OnAfterRender(bool firstRender)
    {
        JSRuntime.InvokeVoidAsync("reactRender");
        base.OnAfterRender(firstRender);
    }
}