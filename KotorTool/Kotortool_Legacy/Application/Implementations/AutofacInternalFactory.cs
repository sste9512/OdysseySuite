using System.Diagnostics;
using Autofac;
using Kotortool_Legacy.Application.Interfaces;
using Kotortool_Legacy.Infrastructure;
using Kotortool_Legacy.Infrastructure.TreeView;
using Kotortool_Legacy.Infrastructure.View.MainForm;
using Kotortool_Legacy.Infrastructure.View.ProjectSelection;
using LiteDB;
using MediatR.Extensions.Autofac.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection.Builder;
using Microsoft.Extensions.Logging;
using IContainer = System.ComponentModel.IContainer;

namespace Kotortool_Legacy.Application.Implementations;

public sealed class AutofacInternalFactory : IInternalServiceFactory
{
    private readonly Autofac.IContainer _container;

    public AutofacInternalFactory()
    {
        var containerBuilder = new ContainerBuilder();

        containerBuilder.RegisterType<BaseErrorAggregationStore>().As<IErrorAggregationStore>();

        containerBuilder.RegisterType<BaseEventBus>().As<IEventBus>();

        containerBuilder.RegisterCallback(x =>
        {
            foreach (var item in containerBuilder.Properties.Keys)
            {
                Console.WriteLine(item);
            }
        });

        

        //services.AddSingleton<IApplicationInfo, BaseApplicationInfo>(x => new BaseApplicationInfo());

        //serviceCollection.AddSingleton<IApplicationCache, BaseApplicationCache>(x => new BaseApplicationCache(containerBuilder.GetRequiredService<ILoggerFactory>()));

        containerBuilder.RegisterType<EncryptionService>();

        containerBuilder.Register(x => new LiteDatabase(@"MyData.db")).As<ILiteDatabase>();
        containerBuilder.RegisterType<DocumentStore>().As<IDocumentStore>();

        containerBuilder.RegisterType<ProjectSelectionScreen>();

        containerBuilder.RegisterType<MainForm>();

        containerBuilder.RegisterType<ApplicationContext>();

        containerBuilder.RegisterType<BaseProjectManager>().As<IProjectManager>();

        containerBuilder.RegisterType<CurrentUser>().As<IUser>();
        
        // ... more registrations
        containerBuilder.RegisterInstance(new LoggerFactory())
            .As<ILoggerFactory>();

        containerBuilder.RegisterGeneric(typeof(Logger<>))
            .As(typeof(ILogger<>))
            .SingleInstance();

        containerBuilder.Register<Options>(x => UserSettings.GetSettings(AppDomain.CurrentDomain.BaseDirectory));

        containerBuilder.RegisterType<GenericNode>();
        containerBuilder.RegisterType<RimNode>();
        containerBuilder.RegisterType<ErfNode>();
        containerBuilder.RegisterType<BiffNode>();
        containerBuilder.RegisterType<NodeContext>();
        containerBuilder.Register(x => this);

        var configuration = MediatRConfigurationBuilder
            .Create(typeof(Program).Assembly)
            .WithRegistrationScope(RegistrationScope.Scoped)
            .WithAllOpenGenericHandlerTypesRegistered()
            .Build();
        
        containerBuilder.RegisterMediatR(configuration);

        _container = containerBuilder.Build();
    }

    public ILifetimeScope ResolveScoped()
    {
        return _container.BeginLifetimeScope();
    }

    public DiagnosticListener DiagnosticSource => _container.DiagnosticSource;

    public Task<T> CreateAsync<T>()
    {
        return Task.FromResult(_container.Resolve<T>());
    }

    public T Create<T>(string name = default)
    {
        return _container.Resolve<T>();
    }
}