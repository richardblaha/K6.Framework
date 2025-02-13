using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class FontWeightExtensions
{
    internal static string? ToClass(this FontWeight weight)
    {
        return weight switch
        {
            FontWeight.Light => "fw-light",
            FontWeight.Lighter => "fw-lighter",
            FontWeight.Normal => "fw-normal",
            FontWeight.Medium => "fw-medium",
            FontWeight.SemiBold => "fw-semi-bold",
            FontWeight.Bold => "fw-bold",
            FontWeight.Bolder => "fw-bolder",
            _ => null
        };
    }
}