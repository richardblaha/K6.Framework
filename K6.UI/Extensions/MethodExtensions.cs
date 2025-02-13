using HttpMethod = K6.UI.Enums.HttpMethod;

namespace K6.UI.Extensions;

internal static class MethodExtensions
{
    internal static string? ToHtml(this HttpMethod httpMethod)
    {
        return httpMethod switch
        {
            HttpMethod.Get => "get",
            HttpMethod.Post => "post",
            HttpMethod.Put => "put",
            HttpMethod.Delete => "delete",
            _ => null
        };
    }
}