using K6.UI.Theming;

using Microsoft.Extensions.DependencyInjection;

namespace K6.UI.Extensions;

public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddK6UI(this IServiceCollection services)
    {
        return services.AddK6UI<ThemeProvider>();
    }

    public static IServiceCollection AddK6UI<TThemeProvider>(this IServiceCollection services)
        where TThemeProvider : class, IThemeProvider
    {
        services.AddLocalization();

        services.AddSingleton<IThemeProvider, TThemeProvider>();

        return services;
    }
}