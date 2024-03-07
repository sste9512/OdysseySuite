// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmPathManager
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Kotortool_Legacy;

public class frmPathManager : Form
{
    [AccessedThroughProperty("btnKotorPath")]
    private Button _btnKotorPath;

    [AccessedThroughProperty("TabControl1")]
    private TabControl _TabControl1;

    [AccessedThroughProperty("btnCancel")] private Button _btnCancel;
    [AccessedThroughProperty("TabPage1")] private TabPage _TabPage1;

    [AccessedThroughProperty("btnAutoDetectKotor2")]
    private Button _btnAutoDetectKotor2;

    [AccessedThroughProperty("ToolTip1")] private ToolTip _ToolTip1;
    [AccessedThroughProperty("TabPage2")] private TabPage _TabPage2;

    [AccessedThroughProperty("tbModuleExportPath")]
    private TextBox _tbModuleExportPath;

    [AccessedThroughProperty("tbKotorPath")]
    private TextBox _tbKotorPath;

    [AccessedThroughProperty("Label3")] private Label _Label3;
    [AccessedThroughProperty("Label14")] private Label _Label14;
    [AccessedThroughProperty("TabPage3")] private TabPage _TabPage3;

    [AccessedThroughProperty("btnAutoDetectKotor1")]
    private Button _btnAutoDetectKotor1;

    [AccessedThroughProperty("tbKotorPath2")]
    private TextBox _tbKotorPath2;

    [AccessedThroughProperty("btnModuleExportPath")]
    private Button _btnModuleExportPath;

    [AccessedThroughProperty("Label15")] private Label _Label15;
    [AccessedThroughProperty("btnOK")] private Button _btnOK;
    [AccessedThroughProperty("Label7")] private Label _Label7;

    [AccessedThroughProperty("btnKotorPath2")]
    private Button _btnKotorPath2;

    [AccessedThroughProperty("Label6")] private Label _Label6;

    [AccessedThroughProperty("tbImportPath")]
    private TextBox _tbImportPath;

    [AccessedThroughProperty("btnImageViewerPath")]
    private Button _btnImageViewerPath;

    [AccessedThroughProperty("tbImageViewerPath")]
    private TextBox _tbImageViewerPath;

    [AccessedThroughProperty("tbSavePath")]
    private TextBox _tbSavePath;

    [AccessedThroughProperty("btnSavePath")]
    private Button _btnSavePath;

    [AccessedThroughProperty("Label5")] private Label _Label5;

    [AccessedThroughProperty("btnImportPath")]
    private Button _btnImportPath;

    private IContainer components;
    private Options options;

    public frmPathManager()
    {
            InitializeComponent();
            CreateNew();
        }

    protected override void Dispose(bool disposing)
    {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

    internal virtual Label Label7
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label7 == null)
                    ;
                _Label7 = value;
                if (_Label7 == null)
                    ;
            }
        get => _Label7;
    }

    internal virtual TextBox tbKotorPath
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbKotorPath == null)
                    ;
                _tbKotorPath = value;
                if (_tbKotorPath == null)
                    ;
            }
        get => _tbKotorPath;
    }

    internal virtual Button btnKotorPath
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnKotorPath != null)
                    _btnKotorPath.Click -= new EventHandler(btnKotorPath_Click);
                _btnKotorPath = value;
                if (_btnKotorPath == null)
                    return;
                _btnKotorPath.Click += new EventHandler(btnKotorPath_Click);
            }
        get => _btnKotorPath;
    }

    internal virtual Button btnOK
    {
        get => _btnOK;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnOK != null)
                    _btnOK.Click -= new EventHandler(btnOK_Click);
                _btnOK = value;
                if (_btnOK == null)
                    return;
                _btnOK.Click += new EventHandler(btnOK_Click);
            }
    }

    internal virtual Button btnCancel
    {
        get => _btnCancel;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnCancel == null)
                    ;
                _btnCancel = value;
                if (_btnCancel == null)
                    ;
            }
    }

    internal virtual ToolTip ToolTip1
    {
        get => _ToolTip1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_ToolTip1 == null)
                    ;
                _ToolTip1 = value;
                if (_ToolTip1 == null)
                    ;
            }
    }

    internal virtual TabControl TabControl1
    {
        get => _TabControl1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TabControl1 == null)
                    ;
                _TabControl1 = value;
                if (_TabControl1 == null)
                    ;
            }
    }

    internal virtual TabPage TabPage1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TabPage1 == null)
                    ;
                _TabPage1 = value;
                if (_TabPage1 == null)
                    ;
            }
        get => _TabPage1;
    }

    internal virtual TabPage TabPage2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TabPage2 == null)
                    ;
                _TabPage2 = value;
                if (_TabPage2 == null)
                    ;
            }
        get => _TabPage2;
    }

    internal virtual Label Label14
    {
        get => _Label14;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label14 == null)
                    ;
                _Label14 = value;
                if (_Label14 == null)
                    ;
            }
    }

    internal virtual TextBox tbKotorPath2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbKotorPath2 == null)
                    ;
                _tbKotorPath2 = value;
                if (_tbKotorPath2 == null)
                    ;
            }
        get => _tbKotorPath2;
    }

    internal virtual Label Label6
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label6 == null)
                    ;
                _Label6 = value;
                if (_Label6 == null)
                    ;
            }
        get => _Label6;
    }

    internal virtual Button btnImportPath
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnImportPath != null)
                    _btnImportPath.Click -= new EventHandler(btnImportPath_Click);
                _btnImportPath = value;
                if (_btnImportPath == null)
                    return;
                _btnImportPath.Click += new EventHandler(btnImportPath_Click);
            }
        get => _btnImportPath;
    }

    internal virtual Button btnSavePath
    {
        get => _btnSavePath;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnSavePath != null)
                    _btnSavePath.Click -= new EventHandler(btnSavePath_Click);
                _btnSavePath = value;
                if (_btnSavePath == null)
                    return;
                _btnSavePath.Click += new EventHandler(btnSavePath_Click);
            }
    }

    internal virtual TextBox tbSavePath
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbSavePath == null)
                    ;
                _tbSavePath = value;
                if (_tbSavePath == null)
                    ;
            }
        get => _tbSavePath;
    }

    internal virtual Label Label5
    {
        get => _Label5;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label5 == null)
                    ;
                _Label5 = value;
                if (_Label5 == null)
                    ;
            }
    }

    internal virtual Label Label3
    {
        get => _Label3;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label3 == null)
                    ;
                _Label3 = value;
                if (_Label3 == null)
                    ;
            }
    }

    internal virtual TextBox tbImageViewerPath
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbImageViewerPath == null)
                    ;
                _tbImageViewerPath = value;
                if (_tbImageViewerPath == null)
                    ;
            }
        get => _tbImageViewerPath;
    }

    internal virtual Button btnImageViewerPath
    {
        get => _btnImageViewerPath;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnImageViewerPath != null)
                    _btnImageViewerPath.Click -= new EventHandler(btnImageViewerPath_Click);
                _btnImageViewerPath = value;
                if (_btnImageViewerPath == null)
                    return;
                _btnImageViewerPath.Click += new EventHandler(btnImageViewerPath_Click);
            }
    }

    internal virtual TextBox tbImportPath
    {
        get => _tbImportPath;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbImportPath == null)
                    ;
                _tbImportPath = value;
                if (_tbImportPath == null)
                    ;
            }
    }

    internal virtual Button btnKotorPath2
    {
        get => _btnKotorPath2;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnKotorPath2 != null)
                    _btnKotorPath2.Click -= new EventHandler(btnKotorPath2_Click);
                _btnKotorPath2 = value;
                if (_btnKotorPath2 == null)
                    return;
                _btnKotorPath2.Click += new EventHandler(btnKotorPath2_Click);
            }
    }

    internal virtual Button btnAutoDetectKotor1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnAutoDetectKotor1 != null)
                    _btnAutoDetectKotor1.Click -= new EventHandler(btnAutoDetectKotor1_Click);
                _btnAutoDetectKotor1 = value;
                if (_btnAutoDetectKotor1 == null)
                    return;
                _btnAutoDetectKotor1.Click += new EventHandler(btnAutoDetectKotor1_Click);
            }
        get => _btnAutoDetectKotor1;
    }

    internal virtual Button btnAutoDetectKotor2
    {
        get => _btnAutoDetectKotor2;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnAutoDetectKotor2 != null)
                    _btnAutoDetectKotor2.Click -= new EventHandler(btnAutoDetectKotor2_Click);
                _btnAutoDetectKotor2 = value;
                if (_btnAutoDetectKotor2 == null)
                    return;
                _btnAutoDetectKotor2.Click += new EventHandler(btnAutoDetectKotor2_Click);
            }
    }

    internal virtual TabPage TabPage3
    {
        get => _TabPage3;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TabPage3 == null)
                    ;
                _TabPage3 = value;
                if (_TabPage3 == null)
                    ;
            }
    }

    internal virtual Label Label15
    {
        get => _Label15;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label15 == null)
                    ;
                _Label15 = value;
                if (_Label15 == null)
                    ;
            }
    }

    internal virtual TextBox tbModuleExportPath
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbModuleExportPath == null)
                    ;
                _tbModuleExportPath = value;
                if (_tbModuleExportPath == null)
                    ;
            }
        get => _tbModuleExportPath;
    }

    internal virtual Button btnModuleExportPath
    {
        get => _btnModuleExportPath;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnModuleExportPath != null)
                    _btnModuleExportPath.Click -= new EventHandler(btnModuleExportPath_Click);
                _btnModuleExportPath = value;
                if (_btnModuleExportPath == null)
                    return;
                _btnModuleExportPath.Click += new EventHandler(btnModuleExportPath_Click);
            }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
            components = new Container();
            ResourceManager resourceManager = new ResourceManager(typeof(frmPathManager));
            tbKotorPath = new TextBox();
            Label7 = new Label();
            btnKotorPath = new Button();
            btnOK = new Button();
            this.btnCancel = new Button();
            ToolTip1 = new ToolTip(components);
            this.btnKotorPath2 = new Button();
            btnSavePath = new Button();
            btnImageViewerPath = new Button();
            btnModuleExportPath = new Button();
            TabControl1 = new TabControl();
            TabPage1 = new TabPage();
            btnAutoDetectKotor1 = new Button();
            TabPage2 = new TabPage();
            btnAutoDetectKotor2 = new Button();
            Label14 = new Label();
            this.tbKotorPath2 = new TextBox();
            TabPage3 = new TabPage();
            Label6 = new Label();
            btnImportPath = new Button();
            tbSavePath = new TextBox();
            Label5 = new Label();
            Label3 = new Label();
            tbImageViewerPath = new TextBox();
            tbImportPath = new TextBox();
            Label15 = new Label();
            tbModuleExportPath = new TextBox();
            TabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage2.SuspendLayout();
            TabPage3.SuspendLayout();
            SuspendLayout();
            tbKotorPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox tbKotorPath1 = tbKotorPath;
            Point point1 = new Point(128, 16);
            Point point2 = point1;
            tbKotorPath1.Location = point2;
            tbKotorPath.Name = "tbKotorPath";
            TextBox tbKotorPath2 = tbKotorPath;
            Size size1 = new Size(336, 20);
            Size size2 = size1;
            tbKotorPath2.Size = size2;
            tbKotorPath.TabIndex = 0;
            tbKotorPath.Text = "";
            Label label7_1 = Label7;
            point1 = new Point(32, 16);
            Point point3 = point1;
            label7_1.Location = point3;
            Label7.Name = "Label7";
            Label label7_2 = Label7;
            size1 = new Size(88, 16);
            Size size3 = size1;
            label7_2.Size = size3;
            Label7.TabIndex = 12;
            Label7.Text = "KotOR root path";
            btnKotorPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button btnKotorPath1 = btnKotorPath;
            point1 = new Point(488, 16);
            Point point4 = point1;
            btnKotorPath1.Location = point4;
            btnKotorPath.Name = "btnKotorPath";
            Button btnKotorPath2 = btnKotorPath;
            size1 = new Size(24, 20);
            Size size4 = size1;
            btnKotorPath2.Size = size4;
            btnKotorPath.TabIndex = 2;
            btnKotorPath.Text = "...";
            ToolTip1.SetToolTip(btnKotorPath, "Click to select a new root path for your KotOR installation");
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.DialogResult = DialogResult.OK;
            Button btnOk = btnOK;
            point1 = new Point(376, 208);
            Point point5 = point1;
            btnOk.Location = point5;
            btnOK.Name = "btnOK";
            btnOK.TabIndex = 19;
            btnOK.Text = "OK";
            this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnCancel.DialogResult = DialogResult.Cancel;
            Button btnCancel = this.btnCancel;
            point1 = new Point(464, 208);
            Point point6 = point1;
            btnCancel.Location = point6;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnKotorPath2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button btnKotorPath2_1 = this.btnKotorPath2;
            point1 = new Point(488, 16);
            Point point7 = point1;
            btnKotorPath2_1.Location = point7;
            this.btnKotorPath2.Name = "btnKotorPath2";
            Button btnKotorPath2_2 = this.btnKotorPath2;
            size1 = new Size(24, 20);
            Size size5 = size1;
            btnKotorPath2_2.Size = size5;
            this.btnKotorPath2.TabIndex = 22;
            this.btnKotorPath2.Text = "...";
            ToolTip1.SetToolTip(this.btnKotorPath2, "Click to select a new root path for your KotOR installation");
            btnSavePath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button btnSavePath1 = btnSavePath;
            point1 = new Point(488, 48);
            Point point8 = point1;
            btnSavePath1.Location = point8;
            btnSavePath.Name = "btnSavePath";
            Button btnSavePath2 = btnSavePath;
            size1 = new Size(24, 20);
            Size size6 = size1;
            btnSavePath2.Size = size6;
            btnSavePath.TabIndex = 16;
            btnSavePath.Text = "...";
            ToolTip1.SetToolTip(btnSavePath, "Click to select a new path for saving extracted files");
            btnImageViewerPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button btnImageViewerPath1 = btnImageViewerPath;
            point1 = new Point(488, 80);
            Point point9 = point1;
            btnImageViewerPath1.Location = point9;
            btnImageViewerPath.Name = "btnImageViewerPath";
            Button btnImageViewerPath2 = btnImageViewerPath;
            size1 = new Size(24, 20);
            Size size7 = size1;
            btnImageViewerPath2.Size = size7;
            btnImageViewerPath.TabIndex = 18;
            btnImageViewerPath.Text = "...";
            ToolTip1.SetToolTip(btnImageViewerPath, "Click to select a new path for the KotOR override directory");
            btnModuleExportPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button moduleExportPath1 = btnModuleExportPath;
            point1 = new Point(488, 112);
            Point point10 = point1;
            moduleExportPath1.Location = point10;
            btnModuleExportPath.Name = "btnModuleExportPath";
            Button moduleExportPath2 = btnModuleExportPath;
            size1 = new Size(24, 20);
            Size size8 = size1;
            moduleExportPath2.Size = size8;
            btnModuleExportPath.TabIndex = 18;
            btnModuleExportPath.Text = "...";
            ToolTip1.SetToolTip(btnModuleExportPath, "Click to select a new path for the KotOR override directory");
            TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Controls.Add(TabPage3);
            TabControl tabControl1_1 = TabControl1;
            point1 = new Point(24, 16);
            Point point11 = point1;
            tabControl1_1.Location = point11;
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl tabControl1_2 = TabControl1;
            size1 = new Size(544, 176);
            Size size9 = size1;
            tabControl1_2.Size = size9;
            TabControl1.TabIndex = 21;
            TabPage1.Controls.Add(btnAutoDetectKotor1);
            TabPage1.Controls.Add(Label7);
            TabPage1.Controls.Add(btnKotorPath);
            TabPage1.Controls.Add(tbKotorPath);
            TabPage tabPage1_1 = TabPage1;
            point1 = new Point(4, 22);
            Point point12 = point1;
            ((Control)tabPage1_1).Location = point12;
            TabPage1.Name = "TabPage1";
            TabPage tabPage1_2 = TabPage1;
            size1 = new Size(536, 150);
            Size size10 = size1;
            tabPage1_2.Size = size10;
            TabPage1.TabIndex = 0;
            TabPage1.Text = "SW:KotOR";
            btnAutoDetectKotor1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button autoDetectKotor1_1 = btnAutoDetectKotor1;
            point1 = new Point(328, 56);
            Point point13 = point1;
            autoDetectKotor1_1.Location = point13;
            btnAutoDetectKotor1.Name = "btnAutoDetectKotor1";
            Button autoDetectKotor1_2 = btnAutoDetectKotor1;
            size1 = new Size(136, 23);
            Size size11 = size1;
            autoDetectKotor1_2.Size = size11;
            btnAutoDetectKotor1.TabIndex = 13;
            btnAutoDetectKotor1.Text = "Auto Detect KotOR";
            TabPage2.Controls.Add(btnAutoDetectKotor2);
            TabPage2.Controls.Add(Label14);
            TabPage2.Controls.Add(this.btnKotorPath2);
            TabPage2.Controls.Add(this.tbKotorPath2);
            TabPage tabPage2_1 = TabPage2;
            point1 = new Point(4, 22);
            Point point14 = point1;
            ((Control)tabPage2_1).Location = point14;
            TabPage2.Name = "TabPage2";
            TabPage tabPage2_2 = TabPage2;
            size1 = new Size(536, 150);
            Size size12 = size1;
            tabPage2_2.Size = size12;
            TabPage2.TabIndex = 1;
            TabPage2.Text = "SW:Kotor II TSL";
            btnAutoDetectKotor2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button autoDetectKotor2_1 = btnAutoDetectKotor2;
            point1 = new Point(328, 56);
            Point point15 = point1;
            autoDetectKotor2_1.Location = point15;
            btnAutoDetectKotor2.Name = "btnAutoDetectKotor2";
            Button autoDetectKotor2_2 = btnAutoDetectKotor2;
            size1 = new Size(136, 23);
            Size size13 = size1;
            autoDetectKotor2_2.Size = size13;
            btnAutoDetectKotor2.TabIndex = 41;
            btnAutoDetectKotor2.Text = "Auto Detect KotOR II";
            Label label14_1 = Label14;
            point1 = new Point(8, 16);
            Point point16 = point1;
            label14_1.Location = point16;
            Label14.Name = "Label14";
            Label label14_2 = Label14;
            size1 = new Size(112, 16);
            Size size14 = size1;
            label14_2.Size = size14;
            Label14.TabIndex = 40;
            Label14.Text = "KotOR:TSL root path";
            this.tbKotorPath2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox tbKotorPath2_1 = this.tbKotorPath2;
            point1 = new Point(128, 16);
            Point point17 = point1;
            tbKotorPath2_1.Location = point17;
            this.tbKotorPath2.Name = "tbKotorPath2";
            TextBox tbKotorPath2_2 = this.tbKotorPath2;
            size1 = new Size(336, 20);
            Size size15 = size1;
            tbKotorPath2_2.Size = size15;
            this.tbKotorPath2.TabIndex = 19;
            this.tbKotorPath2.Text = "";
            TabPage3.Controls.Add(Label6);
            TabPage3.Controls.Add(btnImportPath);
            TabPage3.Controls.Add(tbSavePath);
            TabPage3.Controls.Add(Label5);
            TabPage3.Controls.Add(Label3);
            TabPage3.Controls.Add(tbImageViewerPath);
            TabPage3.Controls.Add(tbImportPath);
            TabPage3.Controls.Add(btnSavePath);
            TabPage3.Controls.Add(btnImageViewerPath);
            TabPage3.Controls.Add(Label15);
            TabPage3.Controls.Add(tbModuleExportPath);
            TabPage3.Controls.Add(btnModuleExportPath);
            TabPage tabPage3_1 = TabPage3;
            point1 = new Point(4, 22);
            Point point18 = point1;
            ((Control)tabPage3_1).Location = point18;
            TabPage3.Name = "TabPage3";
            TabPage tabPage3_2 = TabPage3;
            size1 = new Size(536, 150);
            Size size16 = size1;
            tabPage3_2.Size = size16;
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Other Paths";
            Label label6_1 = Label6;
            point1 = new Point(24, 48);
            Point point19 = point1;
            label6_1.Location = point19;
            Label6.Name = "Label6";
            Label label6_2 = Label6;
            size1 = new Size(88, 16);
            Size size17 = size1;
            label6_2.Size = size17;
            Label6.TabIndex = 10;
            Label6.Text = "Save path";
            btnImportPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button btnImportPath1 = btnImportPath;
            point1 = new Point(488, 16);
            Point point20 = point1;
            btnImportPath1.Location = point20;
            btnImportPath.Name = "btnImportPath";
            Button btnImportPath2 = btnImportPath;
            size1 = new Size(24, 20);
            Size size18 = size1;
            btnImportPath2.Size = size18;
            btnImportPath.TabIndex = 14;
            btnImportPath.Text = "...";
            tbSavePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox tbSavePath1 = tbSavePath;
            point1 = new Point(128, 48);
            Point point21 = point1;
            tbSavePath1.Location = point21;
            tbSavePath.Name = "tbSavePath";
            TextBox tbSavePath2 = tbSavePath;
            size1 = new Size(336, 20);
            Size size19 = size1;
            tbSavePath2.Size = size19;
            tbSavePath.TabIndex = 15;
            tbSavePath.Text = "";
            Label label5_1 = Label5;
            point1 = new Point(24, 16);
            Point point22 = point1;
            label5_1.Location = point22;
            Label5.Name = "Label5";
            Label label5_2 = Label5;
            size1 = new Size(88, 16);
            Size size20 = size1;
            label5_2.Size = size20;
            Label5.TabIndex = 8;
            Label5.Text = "Import path";
            Label label3_1 = Label3;
            point1 = new Point(24, 80);
            Point point23 = point1;
            label3_1.Location = point23;
            Label3.Name = "Label3";
            Label label3_2 = Label3;
            size1 = new Size(96, 16);
            Size size21 = size1;
            label3_2.Size = size21;
            Label3.TabIndex = 4;
            Label3.Text = "Image Viewer path";
            tbImageViewerPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox tbImageViewerPath1 = tbImageViewerPath;
            point1 = new Point(128, 80);
            Point point24 = point1;
            tbImageViewerPath1.Location = point24;
            tbImageViewerPath.Name = "tbImageViewerPath";
            TextBox tbImageViewerPath2 = tbImageViewerPath;
            size1 = new Size(336, 20);
            Size size22 = size1;
            tbImageViewerPath2.Size = size22;
            tbImageViewerPath.TabIndex = 17;
            tbImageViewerPath.Text = "";
            tbImportPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox tbImportPath1 = tbImportPath;
            point1 = new Point(128, 16);
            Point point25 = point1;
            tbImportPath1.Location = point25;
            tbImportPath.Name = "tbImportPath";
            TextBox tbImportPath2 = tbImportPath;
            size1 = new Size(336, 20);
            Size size23 = size1;
            tbImportPath2.Size = size23;
            tbImportPath.TabIndex = 13;
            tbImportPath.Text = "";
            Label label15_1 = Label15;
            point1 = new Point(24, 112);
            Point point26 = point1;
            label15_1.Location = point26;
            Label15.Name = "Label15";
            Label label15_2 = Label15;
            size1 = new Size(96, 16);
            Size size24 = size1;
            label15_2.Size = size24;
            Label15.TabIndex = 4;
            Label15.Text = "Model Export path";
            tbModuleExportPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox moduleExportPath3 = tbModuleExportPath;
            point1 = new Point(128, 112);
            Point point27 = point1;
            moduleExportPath3.Location = point27;
            tbModuleExportPath.Name = "tbModuleExportPath";
            TextBox moduleExportPath4 = tbModuleExportPath;
            size1 = new Size(336, 20);
            Size size25 = size1;
            moduleExportPath4.Size = size25;
            tbModuleExportPath.TabIndex = 17;
            tbModuleExportPath.Text = "";
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            size1 = new Size(592, 245);
            ClientSize = size1;
            Controls.Add(TabControl1);
            Controls.Add(btnOK);
            Controls.Add(this.btnCancel);
            Icon = (Icon)resourceManager.GetObject("$this.Icon");
            MaximizeBox = false;
            size1 = new Size(1600, 376);
            MaximumSize = size1;
            MinimizeBox = false;
            size1 = new Size(600, 272);
            MinimumSize = size1;
            Name = nameof(frmPathManager);
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Path Manager";
            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage2.ResumeLayout(false);
            TabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

    public void CreateNew()
    {
            options = UserSettings.GetSettings();
            tbKotorPath.Text = options.KotorLocation(0);
            tbKotorPath2.Text = options.KotorLocation(1);
            tbImportPath.Text = options.defaultImportLocation;
            tbSavePath.Text = options.defaultSaveLocation;
            tbImageViewerPath.Text = options.ImageViewerLocation;
            tbModuleExportPath.Text = options.ModelExportLocation;
        }

    private void btnOK_Click(object sender, EventArgs e)
    {
            options.defaultKotORLocation = tbKotorPath.Text;
            options.defaultKotORLocation2 = tbKotorPath2.Text;
            options.defaultImportLocation = tbImportPath.Text;
            options.defaultSaveLocation = tbSavePath.Text;
            options.ImageViewerLocation = tbImageViewerPath.Text;
            options.ModelExportLocation = tbModuleExportPath.Text;
            UserSettings.SaveSettings(options);
        }

    private void BrowseForFolder(ref TextBox fld)
    {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Locate folder";
            folderBrowserDialog.SelectedPath = fld.Text;
            folderBrowserDialog.ShowNewFolderButton = false;
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            fld.Text = folderBrowserDialog.SelectedPath;
        }

    private void BrowseForFile(ref TextBox fld)
    {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Chitin.key file...";
            openFileDialog.Filter = "Chitin files (*.key)|*.key";
            openFileDialog.InitialDirectory = fld.Text;
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FileName = "chitin.key";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            fld.Text = openFileDialog.FileName;
        }

    private void BrowseForApp(ref TextBox fld)
    {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Program file...";
            openFileDialog.Filter = "Image Viewer Application (*.exe)|*.exe";
            if (StringType.StrCmp(fld.Text, "", false) != 0)
                openFileDialog.InitialDirectory = Strings.Mid(fld.Text, 1, fld.Text.LastIndexOf("\\"));
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;
            if (StringType.StrCmp(fld.Text, "", false) != 0)
                openFileDialog.FileName = Strings.Mid(fld.Text, checked(fld.Text.LastIndexOf("\\") + 2));
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            fld.Text = openFileDialog.FileName;
        }

    private void btnKotorPath_Click(object sender, EventArgs e)
    {
            TextBox tbKotorPath = this.tbKotorPath;
            BrowseForFolder(ref tbKotorPath);
            this.tbKotorPath = tbKotorPath;
        }

    private void btnImageViewerPath_Click(object sender, EventArgs e)
    {
            TextBox tbImageViewerPath = this.tbImageViewerPath;
            BrowseForApp(ref tbImageViewerPath);
            this.tbImageViewerPath = tbImageViewerPath;
        }

    private void btnImportPath_Click(object sender, EventArgs e)
    {
            TextBox tbImportPath = this.tbImportPath;
            BrowseForFolder(ref tbImportPath);
            this.tbImportPath = tbImportPath;
        }

    private void btnSavePath_Click(object sender, EventArgs e)
    {
            TextBox tbSavePath = this.tbSavePath;
            BrowseForFolder(ref tbSavePath);
            this.tbSavePath = tbSavePath;
        }

    private void btnKotorPath2_Click(object sender, EventArgs e)
    {
            TextBox tbKotorPath2 = this.tbKotorPath2;
            BrowseForFolder(ref tbKotorPath2);
            this.tbKotorPath2 = tbKotorPath2;
        }

    public void btnAutoDetectKotor1_Click(object sender, EventArgs e)
    {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("software\\Bioware\\SW\\KOTOR");
            if (registryKey == null)
            {
                int num = (int)Interaction.MsgBox(
                    "KotOR I not detected in registry. You mau still enter paths manually", MsgBoxStyle.Critical,
                    "Registry value not found");
            }
            else
                tbKotorPath.Text = StringType.FromObject(registryKey.GetValue("path"));
        }

    public void btnAutoDetectKotor2_Click(object sender, EventArgs e)
    {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("software\\LucasArts\\KotOR2");
            if (registryKey == null)
            {
                int num = (int)Interaction.MsgBox(
                    "KotOR II not detected in registry. You mau still enter paths manually", MsgBoxStyle.Critical,
                    "Registry value not found");
            }
            else
                tbKotorPath2.Text = StringType.FromObject(registryKey.GetValue("path"));
        }

    private void btnModuleExportPath_Click(object sender, EventArgs e)
    {
            TextBox moduleExportPath = tbModuleExportPath;
            BrowseForFolder(ref moduleExportPath);
            tbModuleExportPath = moduleExportPath;
        }
}