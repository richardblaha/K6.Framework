using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class DisplayExtensions
{
    internal static string? ToClass(this Display display)
    {
        return display switch
        {
            Display.None => "-none",
            Display.Inline => "-inline",
            Display.Block => "-block",
            Display.InlineFlex => "-inline-flex",
            Display.Flex => "-flex",
            _ => null
        };
    }
}