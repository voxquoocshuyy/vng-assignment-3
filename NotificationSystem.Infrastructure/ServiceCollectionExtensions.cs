using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NotificationSystem.Core.Events;
using NotificationSystem.Core.Handlers;
using NotificationSystem.Core.Publishers;
using NotificationSystem.Core.Services;

namespace NotificationSystem.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddNotificationSystem(this IServiceCollection services)
    {
        services.AddMediatR(typeof(NotificationEvent));
        services.AddTransient<NotificationPublisher>();
        services.AddScoped<INotificationHandler<NotificationEvent>, NotificationEventHandler>();
        services.AddScoped<NotificationService>();
        return services;
    }
}