using System.Diagnostics;
using Kotortool_Legacy.Application.Implementations;
using Kotortool_Legacy.Application.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Kotortool_Legacy.Infrastructure.View.MainForm;

public abstract class AppComponent 
{
    private readonly AutofacInternalFactory _internalServiceFactory;
    private readonly ILogger<AppForm> _logger;
    private readonly IErrorAggregationStore _errorAggregationStore;
    private readonly ISender _sender;

    protected AppComponent(AutofacInternalFactory internalServiceFactory)
    {
        _internalServiceFactory = internalServiceFactory;
        _logger = _internalServiceFactory.Create<ILogger<AppForm>>();
        _errorAggregationStore = _internalServiceFactory.Create<IErrorAggregationStore>();
        _sender = _internalServiceFactory.Create<ISender>();
    }
    
    protected T Resolve<T>()
    {
        return _internalServiceFactory.Create<T>();
    }
    
    protected void ShowError(string message)
    {
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public void CaptureError(Exception exception, string[] reasons)
    {
        _errorAggregationStore.AddError(exception.Message, exception, reasons);
        var trace = new StackTrace(exception, true);
        var frame = trace.GetFrames().Last();
        var lineNumber = frame.GetFileLineNumber();
        var fileName = frame.GetFileName();
        var message = $"Error: {exception.Message} at {fileName}:{lineNumber}";
        _logger.LogError(message);
    }
    
    protected async Task<T> Send<T>(IRequest<T> request)
    {
        return await _sender.Send(request);
    }
}