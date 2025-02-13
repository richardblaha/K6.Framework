using K6.UI.Enums;

namespace K6.UI.Extensions;

public static class BackgroundOpacityExtensions
{
    public static string? ToClass(this Opacity opacity)
    {
        return opacity switch
        {
            Opacity._0 => "bg-opacity-0",
            Opacity._25 => "bg-opacity-25",
            Opacity._50 => "bg-opacity-50",
            Opacity._75 => "bg-opacity-75",
            Opacity._100 => "bg-opacity-100",
            _ => null
        };
    }
}