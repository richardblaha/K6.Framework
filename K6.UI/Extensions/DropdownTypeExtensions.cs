using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class DropdownTypeExtensions
{
    internal static string? ToClass(this DropdownType dropdownType, Align? align = null)
    {
        return dropdownType switch
        {
            DropdownType.Dropdown => align is Align.Center ? "dropdown-center" : "dropdown",
            DropdownType.Dropup => align is Align.Center ? "dropup-center" : "dropup",
            DropdownType.Dropstart => "dropstart",
            DropdownType.Dropend => "dropend",
            _ => null
        };
    }
}