using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class BreakpointExtensions
{
    internal static string? ToContainerClass(this Breakpoint breakpoint)
    {
        return breakpoint switch
        {
            Breakpoint.XS => "container",
            Breakpoint.SM => "container-sm",
            Breakpoint.MD => "container-md",
            Breakpoint.LG => "container-lg",
            Breakpoint.XL => "container-xl",
            Breakpoint.XXL => "container-xxl",
            Breakpoint.Fluid => "container-fluid",
            _ => null
        };
    }

    internal static string? ToOffcanvasClass(this Breakpoint breakpoint)
    {
        return breakpoint switch
        {
            Breakpoint.XS => "offcanvas",
            Breakpoint.SM => "offcanvas-sm",
            Breakpoint.MD => "offcanvas-md",
            Breakpoint.LG => "offcanvas-lg",
            Breakpoint.XL => "offcanvas-xl",
            Breakpoint.XXL => "offcanvas-xxl",
            _ => null
        };
    }
}