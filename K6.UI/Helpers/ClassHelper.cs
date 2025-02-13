namespace K6.UI.Helpers;

public static class ClassHelper
{
    public static string Combine(params string?[] classes)
    {
        return string.Join(
            " ",
            string.Join(" ", classes)
                .Split(" ", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .Distinct()
        );
    }
}