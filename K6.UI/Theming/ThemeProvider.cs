using K6.UI.Enums;

using Microsoft.Extensions.Options;

namespace K6.UI.Theming;

public class ThemeProvider(IOptions<ThemeOptions> options) : IThemeProvider
{
    public Theme CurrentTheme { get; set; } = options.Value.Theme;
    public ThemeMode CurrentMode { get; set; } = options.Value.Mode;
}