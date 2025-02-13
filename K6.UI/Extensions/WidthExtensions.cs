using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class WidthExtensions
{
    internal static string? ToClass(this Width width)
    {
        return width switch
        {
            Width.Width0 => "0",
            Width.Width1 => "1",
            Width.Width2 => "2",
            Width.Width3 => "3",
            Width.Width4 => "4",
            Width.Width5 => "5",
            _ => null
        };
    }
}