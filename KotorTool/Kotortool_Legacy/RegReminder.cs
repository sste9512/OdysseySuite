using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Timer = System.Timers.Timer;

namespace Kotortool_Legacy;

public class RegReminder : Form
{
    [AccessedThroughProperty("lblRegHeader")]
    private Label _lblRegHeader;

    [AccessedThroughProperty("Label1")] private Label _Label1;
    [AccessedThroughProperty("Label2")] private Label _Label2;
    [AccessedThroughProperty("Button1")] private Button _Button1;

    [AccessedThroughProperty("lblTimeMsg")]
    private Label _lblTimeMsg;

    [AccessedThroughProperty("Button2")] private Button _Button2;
    [AccessedThroughProperty("Timer1")] private Timer _Timer1;
    private IContainer components;
    private object m_sec;
    public string btnClicked;

    public RegReminder()
    {
        Load += new EventHandler(RegReminder_Load);
        m_sec = 10;
        InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    internal virtual Label lblRegHeader
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_lblRegHeader == null)
                ;
            _lblRegHeader = value;
            if (_lblRegHeader == null)
                ;
        }
        get => _lblRegHeader;
    }

    internal virtual Label Label2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_Label2 == null)
                ;
            _Label2 = value;
            if (_Label2 == null)
                ;
        }
        get => _Label2;
    }

    internal virtual Button Button1
    {
        get => _Button1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_Button1 != null)
                _Button1.Click -= new EventHandler(Button1_Click);
            _Button1 = value;
            if (_Button1 == null)
                return;
            _Button1.Click += new EventHandler(Button1_Click);
        }
    }

    internal virtual Timer Timer1
    {
        get => _Timer1;
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
    }

    internal virtual Label lblTimeMsg
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_lblTimeMsg == null)
                ;
            _lblTimeMsg = value;
            if (_lblTimeMsg == null)
                ;
        }
        get => _lblTimeMsg;
    }

    internal virtual Button Button2
    {
        get => _Button2;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_Button2 != null)
                _Button2.Click -= new EventHandler(Button2_Click);
            _Button2 = value;
            if (_Button2 == null)
                return;
            _Button2.Click += new EventHandler(Button2_Click);
        }
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
        ResourceManager resourceManager = new ResourceManager(typeof(RegReminder));
        lblRegHeader = new Label();
        Label2 = new Label();
        lblTimeMsg = new Label();
        Button1 = new Button();
        Timer1 = new Timer(components);
        Button2 = new Button();
        Label1 = new Label();
        SuspendLayout();
        lblRegHeader.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
        Label lblRegHeader1 = lblRegHeader;
        Point point1 = new Point(15, 32);
        Point point2 = point1;
        lblRegHeader1.Location = point2;
        lblRegHeader.Name = "lblRegHeader";
        Label lblRegHeader2 = lblRegHeader;
        Size size1 = new Size(300, 23);
        Size size2 = size1;
        lblRegHeader2.Size = size2;
        lblRegHeader.TabIndex = 0;
        lblRegHeader.Text = "This copy of Kotor Tool is not registered";
        lblRegHeader.TextAlign = ContentAlignment.MiddleCenter;
        Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
        Label label2_1 = Label2;
        point1 = new Point(16, 72);
        Point point3 = point1;
        label2_1.Location = point3;
        Label2.Name = "Label2";
        Label label2_2 = Label2;
        size1 = new Size(288, 48);
        Size size3 = size1;
        label2_2.Size = size3;
        Label2.TabIndex = 0;
        Label2.Text = "Registration removes this nag screen and unlocks additional features";
        Label2.TextAlign = ContentAlignment.TopCenter;
        lblTimeMsg.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
        Label lblTimeMsg1 = lblTimeMsg;
        point1 = new Point(80, 192);
        Point point4 = point1;
        lblTimeMsg1.Location = point4;
        lblTimeMsg.Name = "lblTimeMsg";
        Label lblTimeMsg2 = lblTimeMsg;
        size1 = new Size(144, 23);
        Size size4 = size1;
        lblTimeMsg2.Size = size4;
        lblTimeMsg.TabIndex = 0;
        lblTimeMsg.Text = "Please wait .. ";
        Button1.Enabled = false;
        Button button1 = Button1;
        point1 = new Point(72, 240);
        Point point5 = point1;
        button1.Location = point5;
        Button1.Name = "Button1";
        Button1.TabIndex = 1;
        Button1.Text = "OK";
        Timer1.Interval = 800;
        Button button2 = Button2;
        point1 = new Point(176, 240);
        Point point6 = point1;
        button2.Location = point6;
        Button2.Name = "Button2";
        Button2.TabIndex = 2;
        Button2.Text = "Cancel";
        Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
        Label label1_1 = Label1;
        point1 = new Point(16, 128);
        Point point7 = point1;
        label1_1.Location = point7;
        Label1.Name = "Label1";
        Label label1_2 = Label1;
        size1 = new Size(312, 48);
        Size size5 = size1;
        label1_2.Size = size5;
        Label1.TabIndex = 3;
        Label1.Text = "Use the Registration option on the Help menu to start the registration process";
        Label1.TextAlign = ContentAlignment.TopCenter;
        size1 = new Size(5, 13);
        AutoScaleBaseSize = size1;
        size1 = new Size(336, 304);
        ClientSize = size1;
        ControlBox = false;
        Controls.Add(Label1);
        Controls.Add(Button2);
        Controls.Add(Button1);
        Controls.Add(lblRegHeader);
        Controls.Add(Label2);
        Controls.Add(lblTimeMsg);
        Icon = (Icon)resourceManager.GetObject("$this.Icon");
        size1 = new Size(328, 312);
        MinimumSize = size1;
        Name = nameof(RegReminder);
        ShowInTaskbar = false;
        SizeGripStyle = SizeGripStyle.Hide;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Reminder";
        TopMost = true;
        ResumeLayout(false);
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
        lblTimeMsg.Text = StringType.FromObject(ObjectType.StrCatObj("Please wait ... ", m_sec));
        m_sec = ObjectType.SubObj(m_sec, 1);
        if (ObjectType.ObjTst(m_sec, -1, false) != 0)
            return;
        Timer1.Stop();
        Button1.Enabled = true;
    }

    private void RegReminder_Load(object sender, EventArgs e)
    {
        lblTimeMsg.Text = "Please wait ... 10";
        Timer1.Start();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
        if (ObjectType.ObjTst(m_sec, 0, false) > 0)
            return;
        DialogResult = DialogResult.OK;
        btnClicked = "OK";
    }

    private void Button2_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        btnClicked = "Cancel";
    }
}