namespace K6.UI.Enums;

[Flags]
public enum Side
{
    Top = 1 << 0,
    Bottom = 1 << 1,
    Start = 1 << 2,
    End = 1 << 3,
    Horizontal = Start | End,
    Vertical = Top | Bottom
}