using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class ScaleExtensions
{
    internal static string? ToButtonClass(this Scale scale)
    {
        return scale switch
        {
            Scale.Small => "btn-sm",
            Scale.Normal => null,
            Scale.Large => "btn-lg",
            _ => null
        };
    }

    internal static string? ToInputClass(this Scale scale)
    {
        return scale switch
        {
            Scale.Small => "form-control-sm",
            Scale.Normal => null,
            Scale.Large => "form-control-lg",
            _ => null
        };
    }
}