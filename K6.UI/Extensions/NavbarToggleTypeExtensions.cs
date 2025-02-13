using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class NavbarToggleTypeExtensions
{
    internal static string? ToAttributeValue(this NavbarToggleType navbarToggleType)
    {
        return navbarToggleType switch
        {
            NavbarToggleType.Collapse => "collapse",
            NavbarToggleType.Offcanvas => "offcanvas",
            _ => null
        };
    }
}