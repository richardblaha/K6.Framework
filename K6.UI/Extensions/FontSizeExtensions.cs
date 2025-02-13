using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class FontSizeExtensions
{
    internal static string? ToClass(this FontSize size)
    {
        return size switch
        {
            FontSize.x1 => "fs-1",
            FontSize.x2 => "fs-2",
            FontSize.x3 => "fs-3",
            FontSize.x4 => "fs-4",
            FontSize.x5 => "fs-5",
            FontSize.x6 => "fs-6",
            _ => null
        };
    }
}