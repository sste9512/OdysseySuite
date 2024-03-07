using System.ComponentModel;
using System.Diagnostics;

namespace Kotortool_Legacy.Application.Interfaces;

public interface IExternalApplicationRunner
{
    public Task Run(string fileName, string arguments);
}

public class BaseApplicationRunner : IExternalApplicationRunner
{
    private readonly IInternalServiceFactory _internalServiceFactory;

    public BaseApplicationRunner(IInternalServiceFactory internalServiceFactory)
    {
        _internalServiceFactory = internalServiceFactory;
    }
    
    public Task Run(string fileName, string arguments)
    {
        var process = new Process
        {
            Site = null,
            MaxWorkingSet = default,
            MinWorkingSet = default,
            PriorityBoostEnabled = false,
            PriorityClass = (ProcessPriorityClass)0,
            ProcessorAffinity = default,
            StartInfo =
            {
                FileName = fileName + " ",
                Arguments = arguments
            },
            SynchronizingObject = default,
            EnableRaisingEvents = false,
        };

        process.OutputDataReceived += (sender, args) => { };

        process.ErrorDataReceived += (sender, args) => { };

        process.Exited += (sender, args) => { };

        process.Start();

        return Task.CompletedTask;
    }
}

public sealed class Site : ISite
{
    public IComponent Component { get; }
    public IContainer Container { get; }
    public bool DesignMode { get; }
    public string Name { get; set; }
   
    
    public object GetService(Type serviceType)
    {
        throw new NotImplementedException();
    }
}


public sealed class Synchronizing : ISynchronizeInvoke
{

    public Synchronizing()
    {
        
    }
    
    public IAsyncResult BeginInvoke(Delegate method, object[] args)
    {
        throw new NotImplementedException();
    }

    public object EndInvoke(IAsyncResult result)
    {
        throw new NotImplementedException();
    }

    public object Invoke(Delegate method, object[] args)
    {
        throw new NotImplementedException();
    }

    public bool InvokeRequired { get; }
}