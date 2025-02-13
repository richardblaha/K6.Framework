using Microsoft.AspNetCore.Components;

namespace K6.UI.Dialogs
{
    public abstract class Modal<TModel> : ComponentBase
    {
        [Parameter] public TModel? Model { get; set; }
        [Parameter] public RenderFragment? ChildContent { get; set; }
    }
}