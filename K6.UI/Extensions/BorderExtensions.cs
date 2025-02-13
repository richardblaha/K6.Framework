using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class BorderExtensions
{
    internal static string? ToClass(this BorderType borderType)
    {
        return borderType switch
        {
            BorderType.Default => null,
            BorderType.Rounded => "rounded",
            BorderType.RoundedTop => "rounded-top",
            BorderType.RoundedBottom => "rounded-bottom",
            BorderType.RoundedStart => "rounded-start",
            BorderType.RoundedEnd => "rounded-end",
            BorderType.Circle => "rounded-circle",
            BorderType.Pill => "rounded-pill",
            _ => null
        };
    }
}