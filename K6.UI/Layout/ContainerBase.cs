using K6.UI.Enums;
using K6.UI.Extensions;
using K6.UI.Helpers;

using Microsoft.AspNetCore.Components;

namespace K6.UI.Layout;

public abstract class ContainerBase : ComponentBase
{
    [Parameter] public IList<(Screen?, Display)>? Display { get; set; }

    [Parameter] public Color? Color { get; set; }

    [Parameter] public (Color?, bool, Opacity?) Background { get; set; }

    [Parameter] public (BorderType?, Color?, Width?, IList<(Placement?, bool?)>?) Border { get; set; }

    [Parameter] public IList<(Screen?, Align)>? Align { get; set; }

    [Parameter] public IList<(Screen?, Justify)>? Justify { get; set; }

    [Parameter] public IList<(Screen?, Side?, Width)>? Margin { get; set; }

    [Parameter] public IList<(Screen?, Side?, Width)>? Padding { get; set; }

    [Parameter] public IList<(Screen?, bool)>? Fill { get; set; }

    [Parameter] public IList<(Screen?, bool)>? Grow { get; set; }

    [Parameter] public IList<(Screen?, bool)>? Shrink { get; set; }

    [Parameter] public string? Class { get; set; }

    [Parameter] public RenderFragment? ChildContent { get; set; }

    protected string? GetMarginClass()
    {
        return GetClass("m", Margin);
    }

    protected string? GetPaddingClass()
    {
        return GetClass("p", Padding);
    }

    protected string? GetFillClass()
    {
        if (Fill is null)
            return null;

        var classes = new List<string>();
        foreach (var (screen, fill) in Fill)
        {
            if (fill)
                classes.Add($"flex{screen.ToClass()}-fill");
        }

        return ClassHelper.Combine(classes.ToArray());
    }

    protected string? GetShrinkClass()
    {
        if (Shrink is null)
            return null;

        var classes = new List<string>();
        foreach (var (screen, shrink) in Shrink)
        {
            classes.Add(shrink ? $"flex{screen.ToClass()}-shrink-1" : $"flex{screen.ToClass()}-shrink-0");
        }

        return ClassHelper.Combine(classes.ToArray());
    }

    protected string? GetGrowClass()
    {
        if (Grow is null)
            return null;

        var classes = new List<string>();
        foreach (var (screen, grow) in Grow)
        {
            classes.Add(grow ? $"flex{screen.ToClass()}-grow-1" : $"flex{screen.ToClass()}-grow-0");
        }

        return ClassHelper.Combine(classes.ToArray());
    }

    protected string GetBackgroundClass()
    {
        return ClassHelper.Combine(
            Color.HasValue ? Background.Item1?.ToBgClass() : Background.Item1?.ToTextBgClass(),
            Background.Item2 ? "bg-gradient" : null,
            Background.Item3?.ToClass()
        );
    }

    protected string GetBorderClass()
    {
        return ClassHelper.Combine(
            Border.Item1?.ToClass(),
            Border.Item2?.ToBorderClass(),
            Border.Item3?.ToClass(),
            GetBorderClass(Border.Item4)
        );
    }

    private string? GetBorderClass(IList<(Placement?, bool?)>? values)
    {
        if (values is null)
            return null;

        var classes = new List<string?> { "border" };
        foreach (var (placement, visible) in values)
        {
            classes.Add(placement?.ToBorderClass(visible));
        }

        return ClassHelper.Combine(classes.ToArray());
    }

    private string? GetClass(string prefix, IList<(Screen?, Side?, Width)>? values)
    {
        if (values is null)
        {
            return null;
        }

        var classes = new List<string>();
        foreach (var (screen, side, width) in values)
        {
            classes.Add($"{prefix}{side.ToClass()}{screen.ToClass()}-{width.ToClass()}");
        }

        return string.Join(" ", classes);
    }
}