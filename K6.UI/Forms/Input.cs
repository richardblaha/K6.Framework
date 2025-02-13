using System.Linq.Expressions;

using K6.UI.Enums;
using K6.UI.Helpers;

using Microsoft.AspNetCore.Components;

namespace K6.UI.Forms;

public abstract class Input<TValue> : ComponentBase
{
    [Parameter]
    public string Id { get; set; } = IdHelper.Random(nameof(Input<TValue>));

    [Parameter]
    public string? Name { get; set; }

    [Parameter]
    public Expression<Func<TValue>>? For { get; set; }

    [Parameter]
    public string? Label { get; set; }

    [Parameter]
    public string? Placeholder { get; set; }

    [Parameter]
    public Scale? Size { get; set; }

    [Parameter]
    public bool ReadOnly { get; set; }

    [Parameter]
    public bool Disabled { get; set; }

    [Parameter]
    public TValue? Value { get; set; }

    [Parameter]
    public EventCallback<TValue> ValueChanged { get; set; }
}
