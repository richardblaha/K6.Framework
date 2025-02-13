using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class TextTypeExtensions
{
    internal static string? ToClass(this TextType type)
    {
        return type switch
        {
            TextType.Default => null,
            TextType.Headline1 => "h1",
            TextType.Headline2 => "h2",
            TextType.Headline3 => "h3",
            TextType.Headline4 => "h4",
            TextType.Headline5 => "h5",
            TextType.Headline6 => "h6",
            TextType.Display1 => "display-1",
            TextType.Display2 => "display-2",
            TextType.Display3 => "display-3",
            TextType.Display4 => "display-4",
            TextType.Display5 => "display-5",
            TextType.Display6 => "display-6",
            TextType.Paragraph => null,
            TextType.Lead => "lead",
            TextType.Blockquote => "blockquote",
            TextType.Monospace => "font-monospace",
            TextType.Code => "font-monospace",
            _ => null
        };
    }
}