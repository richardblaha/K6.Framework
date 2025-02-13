using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class JustifyExtensions
{
    internal static string ToClass(this IList<(Screen?, Justify)> list)
    {
        var classes = new List<string>();
        foreach (var (screen, justify) in list)
        {
            classes.Add($"justify-content{screen.ToClass()}-{justify.ToString().ToLower()}");
        }

        return string.Join(
            " ",
            classes
        );
    }
}