using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class ButtonGroupTypeExtensions
{
    internal static string? ToClass(this ButtonGroupType type)
    {
        return type switch
        {
            ButtonGroupType.Group => "btn-group",
            ButtonGroupType.VerticalGroup => "btn-group-vertical",
            ButtonGroupType.Toolbar => "btn-toolbar",
            _ => null
        };
    }
}