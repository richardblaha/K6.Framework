using System.Text;

namespace K6.UI.Helpers;

public static class IdHelper
{
    public static string Random(string? prefix = null, int length = 4)
    {
        if (length <= 0)
        {
            throw new ArgumentException(@"Length must be greater than zero.", nameof(length));
        }

        if (prefix != null && !prefix.EndsWith("_"))
        {
            prefix += "_";
        }

        var resultLength = length + (prefix?.Length ?? 0);
        var stringBuilder = new StringBuilder(prefix, resultLength);

        while (stringBuilder.Length < resultLength)
        {
            stringBuilder.Append(Guid.NewGuid().ToString("N"));
        }

        return stringBuilder.ToString(0, resultLength);
    }
}