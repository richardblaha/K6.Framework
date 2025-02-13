using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class StackTypeExtensions
{
    internal static string? ToClass(this StackType stackType)
    {
        return stackType switch
        {
            StackType.Vertical => "vstack",
            StackType.Horizontal => "hstack",
            _ => null
        };
    }
}