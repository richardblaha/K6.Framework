using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class FontStyleExtensions
{
    internal static string? ToClass(this FontStyle style)
    {
        return style switch
        {
            FontStyle.Normal => "fst-normal",
            FontStyle.Italic => "fst-italic",
            _ => null
        };
    }
}