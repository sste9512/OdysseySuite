using Kotortool_Legacy.Application.Implementations;
using Kotortool_Legacy.Infrastructure.View.ProjectSelection;

namespace Kotortool_Legacy;

internal sealed class Program
{
    [STAThread]
    public static void Main(string[] cmdArgs)
    {

        
        /*
        var builder = new HostBuilder()
            /*.ConfigureContainer<ContainerBuilder>(x =>
            {
                 /*x.RegisterType(x =>
                    new ConfigurationBuilder<IScopedSetting>()
                        .UseJsonFile("")
                        .Build()));#2#


                /*services.AddMassTransit(x =>
                {
                    x.SetKebabCaseEndpointNameFormatter();
                    x.SetInMemorySagaRepositoryProvider();

                    var entryAssembly = Assembly.GetEntryAssembly();

                    x.AddPublishObserver<SuperObserver>();
                    x.AddConsumers(entryAssembly);
                    x.AddSagaStateMachines(entryAssembly);
                    x.AddSagas(entryAssembly);
                    x.AddActivities(entryAssembly);

                    x.UsingInMemory((context, cfg) => { cfg.ConfigureEndpoints(context); });
                });#2#

                
            })#1#
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.AddJsonFile("appsettings.json", true, true);
                config.AddEnvironmentVariables();
                config.AddCommandLine(cmdArgs);
            })
            .ConfigureLogging(log =>
            {
                /*log.AddJsonConsole(options =>
                {
                    options.IncludeScopes = true;
                    options.TimestampFormat = "HH:mm:ss ";
                    options.JsonWriterOptions = new JsonWriterOptions
                    {
                        Indented = true
                    };
                });#1#
            })
            .ConfigureServices((hostContext, services) =>
            {
                services.AddMetrics();

                /*
                 *
                 *  Inner Settings, registered as Scoped
                 *
                 #1#
                services.AddScoped(x =>
                    new ConfigurationBuilder<IScopedSetting>()
                        .UseJsonFile("")
                        .Build());


                /*services.AddMassTransit(x =>
                {
                    x.SetKebabCaseEndpointNameFormatter();
                    x.SetInMemorySagaRepositoryProvider();

                    var entryAssembly = Assembly.GetEntryAssembly();

                    x.AddPublishObserver<SuperObserver>();
                    x.AddConsumers(entryAssembly);
                    x.AddSagaStateMachines(entryAssembly);
                    x.AddSagas(entryAssembly);
                    x.AddActivities(entryAssembly);

                    x.UsingInMemory((context, cfg) => { cfg.ConfigureEndpoints(context); });
                });#1#

                /*services.AddSingleton<IErrorAggregationStore, BaseErrorAggregationStore>();

                services.AddSingleton<IEventBus, BaseEventBus>();

                services.AddSingleton<IApplicationInfo, BaseApplicationInfo>(x => new BaseApplicationInfo());

                //serviceCollection.AddSingleton<IApplicationCache, BaseApplicationCache>(x => new BaseApplicationCache(x.GetRequiredService<ILoggerFactory>()));

                services.AddSingleton<EncryptionService>();

                services.AddSingleton<IDocumentStore, DocumentStore>(x =>
                    new DocumentStore(new LiteDatabase(@"MyData.db")));

                services.AddMediatR(cfg =>
                {
                    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                    cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
                    cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehaviour<,>));
                    cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
                    cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
                });

                services.AddSingleton(new AutofacInternalFactory());
                services.AddScoped<TreeViewBuilder>();

                services.AddSingleton<IInternalServiceFactory, InternalServiceFactory>(x =>
                    new InternalServiceFactory(x));

                services.AddScoped<ProjectSelectionScreen>();

                services.AddScoped<MainForm>();

                services.AddScoped<ApplicationContext>();

                services.AddScoped<IProjectManager, BaseProjectManager>();

                services.AddScoped<IUser, CurrentUser>();
                
                services.AddScoped<Options>(x => UserSettings.GetSettings(AppDomain.CurrentDomain.BaseDirectory));

                services.AddTransient<GenericNode>();
                services.AddTransient<RimNode>();
                services.AddTransient<ErfNode>();
                services.AddTransient<BiffNode>();
                services.AddTransient<NodeContext>();#1#
            });
        

        var application = builder.Build();
        */

        var factory = Singleton<AutofacInternalFactory>.GetInstance();
       

        System.Windows.Forms.Application.EnableVisualStyles();
        System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
        System.Windows.Forms.Application.Run(factory.Create<ProjectSelectionScreen>());
       
    }
}

internal interface IScopedSetting
{
}