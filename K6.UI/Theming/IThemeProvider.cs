using K6.UI.Enums;

namespace K6.UI.Theming;

public interface IThemeProvider
{
    Theme CurrentTheme { get; set; }
    ThemeMode CurrentMode { get; set; }
}