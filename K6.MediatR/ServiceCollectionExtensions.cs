using K6.Application;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace K6.MediatR;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBus(this IServiceCollection services)
    {
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssembly(typeof(MediatRBus).Assembly);
        });

        services.AddScoped<IBus, MediatRBus>();

        services.AddScoped(typeof(IRequestHandler<>), typeof(CommandRequestHandler<>));
        services.AddScoped(typeof(IRequestHandler<,>), typeof(CommandRequestHandler<,>));
        services.AddScoped(typeof(IRequestHandler<,>), typeof(QueryRequestHandler<,>));
        services.AddScoped(typeof(INotificationHandler<>), typeof(EventNotificationHandler<>));

        return services;
    }
}