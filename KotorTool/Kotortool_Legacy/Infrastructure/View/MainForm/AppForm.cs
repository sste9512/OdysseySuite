using Autofac;
using MediatR;

namespace Kotortool_Legacy.Infrastructure.View.MainForm;


public class AppForm : Form
{
    private WeakReference<AppForm> _parentForm;
    private List<WeakReference<AppForm>> _forms = new();
    private ComponentActions ComponentActions { get; } = new();


    protected T Resolve<T>()
    {
        return ComponentActions.Resolve<T>();
    }

    public Task DispatchEvents(params BaseEvent[] events)
    {
        return ComponentActions.DispatchEvents(events);
    }

    protected ILifetimeScope ResolveScoped()
    {
        return ComponentActions.ResolveScoped();
    }

    protected void CaptureError(Exception exception, string[] reasons)
    {
        ComponentActions.CaptureError(exception, reasons);
    }

    protected Task<T> Send<T>(IRequest<T> request)
    {
        return ComponentActions.Send(request);
    }

    protected override void OnActivated(EventArgs e)
    {
        Console.WriteLine(e.GetType().ToString());
        base.OnActivated(e);
    }

    protected override void InitLayout()
    {
        Console.WriteLine("InitLayout");
        base.InitLayout();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        Console.WriteLine(e.GetType().ToString());
        
        base.OnFormClosing(e);
    }


    protected void Navigate<T>() where T : AppForm
    {
        var form = ComponentActions.Resolve<T>();
        form.Show();
    }
    
    
    protected void ShowError(string message)
    {
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public void Attach(params AppForm[] appForms)
    {
        _parentForm = new WeakReference<AppForm>(this);
        foreach (var item in appForms)
        {
            _forms.Add(new WeakReference<AppForm>(item));
        }
    }

    public void Detach()
    {
        _parentForm = null;
        var item = _forms.FirstOrDefault(x => x.TryGetTarget(out var form) && form == this);
        _forms.Remove(item);
    }
    
    public AppForm ParentForm => _parentForm.TryGetTarget(out var form) ? form : default;
    
    public AppForm[] Forms => _forms.ConvertAll(x => x.TryGetTarget(out var form) ? form : default).ToArray();
    
    public void AccessForm(Action<AppForm> action)
    {
        if (_parentForm.TryGetTarget(out var parentform))
        {
            parentform.AccessForm(action);
        }

        foreach (var form in Forms)
        {
            form.AccessForm(action);
        }
    }
    
    public IEnumerable<T> Query<T>(Func<AppForm, T> action)
    {
        var list = new List<T>();
        
        if (_parentForm.TryGetTarget(out var parentform))
        {
            list.Add(action(parentform));
        }

        foreach (var form in Forms)
        {
            list.AddRange(form.Query<T>(action));
        }

        return list;
    }
}