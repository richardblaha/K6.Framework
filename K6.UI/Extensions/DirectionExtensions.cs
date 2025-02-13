using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class DirectionExtensions
{
    internal static string? ToClass(this Direction direction)
    {
        return direction switch
        {
            Direction.Column => "-column",
            Direction.ColumnReverse => "-column-reverse",
            Direction.Row => "-row",
            Direction.RowReverse => "-row-reverse",
            _ => null
        };
    }
}