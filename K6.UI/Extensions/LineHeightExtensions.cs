using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class LineHeightExtensions
{
    internal static string? ToClass(this LineHeight height)
    {
        return height switch
        {
            LineHeight.Small => "lh-sm",
            LineHeight.Normal => "lh-base",
            LineHeight.Large => "lh-lg",
            LineHeight.Full => "lh-1",
            _ => null
        };
    }
}