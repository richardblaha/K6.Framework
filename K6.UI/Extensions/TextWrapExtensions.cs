using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class TextWrapExtensions
{
    internal static string? ToClass(this TextWrap wrap)
    {
        return wrap switch
        {
            TextWrap.Wrap => "text-wrap",
            TextWrap.DoNotWrap => "text-nowrap",
            _ => null
        };
    }
}