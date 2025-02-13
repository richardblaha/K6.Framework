using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class PlacementExtensions
{
    internal static string? ToOffcanvasClass(this Placement placement)
    {
        return placement switch
        {
            Placement.Start => "offcanvas-start",
            Placement.End => "offcanvas-end",
            Placement.Top => "offcanvas-top",
            Placement.Bottom => "offcanvas-bottom",
            _ => null
        };
    }

    internal static string? ToBorderClass(this Placement placement, bool? visible)
    {
        var suffix = visible is false ? "-0" : null;
        return placement switch
        {
            Placement.Start => $"border-start{suffix}",
            Placement.End => $"border-end{suffix}",
            Placement.Top => $"border-top{suffix}",
            Placement.Bottom => $"border-bottom{suffix}",
            _ => null
        };
    }
}