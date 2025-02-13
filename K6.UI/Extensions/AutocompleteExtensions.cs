using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class AutocompleteExtensions
{
    internal static string? ToAttributeValue(this Autocomplete autocomplete)
    {
        return autocomplete switch
        {
            Autocomplete.On => "on",
            Autocomplete.Off => "off",
            _ => null
        };
    }
}