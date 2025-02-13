using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class SideExtensions
{
    internal static string? ToClass(this Side? side)
    {
        return side switch
        {
            Side.Top => "-t",
            Side.Bottom => "-b",
            Side.Start => "-s",
            Side.End => "-e",
            Side.Horizontal => "-x",
            Side.Vertical => "-y",
            _ => null
        };
    }
}