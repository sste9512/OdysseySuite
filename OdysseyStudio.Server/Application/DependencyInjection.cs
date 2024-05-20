using System.Reflection;
using FluentValidation;
using MediatR;
using OdysseyStudio.Server.Application.Common.Behaviours;
using OdysseyStudio.Server.Application.Interfaces;
using OdysseyStudio.Server.Application.Services;

namespace OdysseyStudio.Server.Application;

public static class DependencyInjectionApplication
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddMediatR(cfg => {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
        });

        services.AddScoped<IApplicationFactory, ApplicationFactory>(x => new ApplicationFactory(x));
        
        return services;
    }
}
