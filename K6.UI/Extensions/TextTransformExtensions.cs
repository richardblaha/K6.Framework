using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class TextTransformExtensions
{
    internal static string? ToClass(this TextTransform transform)
    {
        return transform switch
        {
            TextTransform.Lowercase => "text-lowercase",
            TextTransform.Uppercase => "text-uppercase",
            TextTransform.Capitalize => "text-capitalize",
            _ => null
        };
    }
}