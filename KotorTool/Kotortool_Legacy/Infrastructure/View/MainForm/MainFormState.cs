using System.Collections;
using Kotortool_Legacy.API;
using Kotortool_Legacy.Application.Interfaces;

namespace Kotortool_Legacy.Infrastructure.View.MainForm;

public sealed class MainFormState : IDisposable
{
    public Guid Id { get; set; }
    
    // can go into app settings
    public string GRootPath;
        
    public ChitinKey Gk1ChitinKey;
    public ChitinKey Gk2ChitinKey;
        
    public BIFFArchive Gk1TemplatesBif;
    public BIFFArchive Gk2TemplatesBif;

    private WeakReference<Form> _mainform;
    
    public MainForm MainFormAccessor => _mainform.TryGetTarget(out var form) ? (MainForm) form : null;

    
    // Turn this into state
    public ArrayList[,] _biffEntryListArray;
    public ArrayList[] _biffEntries;
    public byte[] _buffer;
    public Options CurrentSettings;
    public bool _hasK1;
    public bool _hasK2;
    public int _gAbbbIndex;

    public Project Project { get; set; }
    
    public MainFormState(Project project)
    {
        Id = Guid.NewGuid();
        Project = project;
    }

    public MainFormState Register(MainForm mainForm)
    {
        _mainform = new WeakReference<Form>(mainForm);

        return this;
    }

    public override string ToString()
    {
        return $"{nameof(_biffEntryListArray)}: {_biffEntryListArray}, {nameof(_biffEntries)}: {_biffEntries}, {nameof(_buffer)}: {_buffer}: {nameof(_hasK1)}: {_hasK1}, {nameof(_hasK2)}: {_hasK2},  {nameof(_gAbbbIndex)}: {_gAbbbIndex}, {nameof(Id)}: {Id}";
    }

    public void Dispose()
    {
        MainFormAccessor?.Dispose();
    }
}