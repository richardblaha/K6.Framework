using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class TargetExtensions
{
    internal static string? ToAttributeValue(this Target target)
    {
        return target switch
        {
            Target.Blank => "_blank",
            Target.Parent => "_parent",
            Target.Self => "_self",
            Target.Top => "_top",
            _ => null
        };
    }
}