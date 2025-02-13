using K6.UI.Enums;
using K6.UI.Helpers;

namespace K6.UI.Extensions;

internal static class AlignExtensions
{
    internal static string ToClass(this IList<(Screen?, Align)> list)
    {
        var classes = new List<string>();

        foreach (var (screen, align) in list)
        {
            classes.Add($"align-items{screen.ToClass()}-{align.ToString().ToLower()}");
        }

        return ClassHelper.Combine(classes.ToArray());
    }

    internal static string? ToDropdownMenuClass(this Align align)
    {
        return align switch
        {
            Align.Start => "dropdown-menu-start",
            Align.Center => null,
            Align.End => "dropdown-menu-end",
            _ => null
        };
    }
}