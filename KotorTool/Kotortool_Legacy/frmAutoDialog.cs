// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmAutoDialog
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Timer = System.Timers.Timer;

namespace Kotortool_Legacy;

public class frmAutoDialog : Form
{
    [AccessedThroughProperty("Label1")] private Label _Label1;
    [AccessedThroughProperty("Timer1")] private Timer _Timer1;
    private IContainer components;
    private string filepath;

    public frmAutoDialog()
    {
        Load += new EventHandler(frmAutoDialog_Load);
        Closing += new CancelEventHandler(frmAutoDialog_Closing);
        filepath = FrmMain.CurrentSettings.defaultKotORLocation + @"\override\ft_watch.dlg";
        InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    internal virtual Timer Timer1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_Timer1 != null)
                _Timer1.Tick -= new EventHandler(Timer1_Tick);
            _Timer1 = value;
            if (_Timer1 == null)
                return;
            _Timer1.Tick += new EventHandler(Timer1_Tick);
        }
        get => _Timer1;
    }

    internal virtual Label Label1
    {
        get => _Label1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_Label1 == null)
                ;
            _Label1 = value;
            if (_Label1 == null)
                ;
        }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
        components = new Container();
        ResourceManager resourceManager = new ResourceManager(typeof(frmAutoDialog));
        Timer1 = new Timer(components);
        Label1 = new Label();
        SuspendLayout();
        Timer1.Interval = 10000;
        Label1.Location = new Point(32, 24);
        Label1.Name = "Label1";
        Label label1 = Label1;
        Size size1 = new Size(224, 40);
        Size size2 = size1;
        label1.Size = size2;
        Label1.TabIndex = 0;
        Label1.Text =
            "The time is being sent to the custom.dlg file in your SW:KotOR Override folder every 10 seconds. Close this window to stop.";
        size1 = new Size(5, 13);
        AutoScaleBaseSize = size1;
        size1 = new Size(292, 93);
        ClientSize = size1;
        Controls.Add(Label1);
        Icon = (Icon)resourceManager.GetObject("$this.Icon");
        Name = nameof(frmAutoDialog);
        Text = "Auto Dialog";
        ResumeLayout(false);
    }

    private void SetDLGData()
    {
        ClsGff clsGff = new ClsGff(new FileStream(filepath, FileMode.Open), 0);
        DateTime now = DateAndTime.Now;
        clsGff.SetEnglishCExoLocSubStringEntry("EntryList(0).Text", "The time is " + now.ToLongTimeString());
        clsGff.WriteFile(filepath, "DLG");
    }

    private void Button1_Click(object sender, EventArgs e) => SetDLGData();

    private void Timer1_Tick(object sender, EventArgs e) => SetDLGData();

    private void frmAutoDialog_Load(object sender, EventArgs e) => Timer1.Enabled = true;

    private void frmAutoDialog_Closing(object sender, CancelEventArgs e) => Timer1.Enabled = false;
}