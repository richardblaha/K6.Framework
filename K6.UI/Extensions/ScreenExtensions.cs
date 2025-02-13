using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class ScreenExtensions
{
    internal static string? ToClass(this Screen? screen)
    {
        return screen switch
        {
            Screen.XS => "-xs",
            Screen.SM => "-sm",
            Screen.MD => "-md",
            Screen.LG => "-lg",
            Screen.XL => "-xl",
            Screen.XXL => "-xxl",
            _ => null
        };
    }
}