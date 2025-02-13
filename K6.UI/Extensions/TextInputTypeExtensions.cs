using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class TextInputTypeExtensions
{
    internal static string? ToHtml(this TextInputType type)
    {
        return type switch
        {
            TextInputType.Text => "text",
            TextInputType.Password => "password",
            TextInputType.Email => "email",
            TextInputType.Phone => "tel",
            TextInputType.Url => "url",
            _ => null
        };
    }
}