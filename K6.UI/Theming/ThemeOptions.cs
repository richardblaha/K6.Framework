using K6.UI.Enums;

namespace K6.UI.Theming;

public class ThemeOptions
{
    public Theme Theme { get; set; } = Themes.K6;
    public ThemeMode Mode { get; set; } = ThemeMode.Auto;
}