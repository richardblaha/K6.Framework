using K6.UI.Enums;

namespace K6.UI.Extensions;

public static class IconSizeExtensions
{
    public static string? ToClass(this IconSize size)
    {
        return size switch
        {
            IconSize.Half => "icon-size-half",
            IconSize.Full => null,
            IconSize.Double => "icon-size-double",
            IconSize.Triple => "icon-size-triple",
            IconSize.Quadruple => "icon-size-quadruple",
            _ => null
        };
    }
}