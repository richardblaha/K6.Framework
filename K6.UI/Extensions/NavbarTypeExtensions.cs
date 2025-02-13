using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class NavbarTypeExtensions
{
    internal static string? ToClass(this NavbarType type)
    {
        return type switch
        {
            NavbarType.Static => null,
            NavbarType.FixedTop => "fixed-top",
            NavbarType.FixedBottom => "fixed-bottom",
            NavbarType.StickyTop => "sticky-top",
            NavbarType.StickyBottom => "sticky-bottom",
            _ => null
        };
    }
}