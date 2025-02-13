using K6.UI.Enums;

namespace K6.UI.Extensions;

public static class ThemeModeExtensions
{
    public static string? ToDataBsTheme(this ThemeMode mode)
    {
        return mode switch
        {
            ThemeMode.Auto => null,
            ThemeMode.Light => "data-bs-theme=\"light\"",
            ThemeMode.Dark => "data-bs-theme=\"dark\"",
            _ => null
        };
    }
}