// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmResourceTypeSelector
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmResourceTypeSelector : Form
{
    [AccessedThroughProperty("btnClear")] private Button _btnClear;

    [AccessedThroughProperty("btnSelectAll")]
    private Button _btnSelectAll;

    [AccessedThroughProperty("btnCancel")] private Button _btnCancel;
    [AccessedThroughProperty("chkbNCS")] private CheckBox _chkbNCS;
    [AccessedThroughProperty("btnOK")] private Button _btnOK;
    [AccessedThroughProperty("chkbUTP")] private CheckBox _chkbUTP;
    [AccessedThroughProperty("chkbUTS")] private CheckBox _chkbUTS;
    [AccessedThroughProperty("chkbUTE")] private CheckBox _chkbUTE;
    [AccessedThroughProperty("chkbUTW")] private CheckBox _chkbUTW;
    [AccessedThroughProperty("chkbPTH")] private CheckBox _chkbPTH;
    [AccessedThroughProperty("chkbGIT")] private CheckBox _chkbGIT;
    [AccessedThroughProperty("chkbUTC")] private CheckBox _chkbUTC;
    [AccessedThroughProperty("chkbARE")] private CheckBox _chkbARE;
    [AccessedThroughProperty("chkbUTT")] private CheckBox _chkbUTT;
    [AccessedThroughProperty("chkbIFO")] private CheckBox _chkbIFO;
    [AccessedThroughProperty("Label1")] private Label _Label1;
    [AccessedThroughProperty("chkbUTM")] private CheckBox _chkbUTM;
    [AccessedThroughProperty("chkbUTD")] private CheckBox _chkbUTD;
    private IContainer components;

    public frmResourceTypeSelector() => InitializeComponent();

    protected override void Dispose(bool disposing)
    {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

    internal virtual CheckBox chkbGIT
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbGIT == null)
                    ;
                _chkbGIT = value;
                if (_chkbGIT == null)
                    ;
            }
        get => _chkbGIT;
    }

    internal virtual CheckBox chkbARE
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbARE == null)
                    ;
                _chkbARE = value;
                if (_chkbARE == null)
                    ;
            }
        get => _chkbARE;
    }

    internal virtual CheckBox chkbIFO
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbIFO == null)
                    ;
                _chkbIFO = value;
                if (_chkbIFO == null)
                    ;
            }
        get => _chkbIFO;
    }

    internal virtual CheckBox chkbPTH
    {
        get => _chkbPTH;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbPTH == null)
                    ;
                _chkbPTH = value;
                if (_chkbPTH == null)
                    ;
            }
    }

    internal virtual CheckBox chkbUTD
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbUTD == null)
                    ;
                _chkbUTD = value;
                if (_chkbUTD == null)
                    ;
            }
        get => _chkbUTD;
    }

    internal virtual CheckBox chkbUTM
    {
        get => _chkbUTM;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbUTM == null)
                    ;
                _chkbUTM = value;
                if (_chkbUTM == null)
                    ;
            }
    }

    internal virtual CheckBox chkbUTT
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbUTT == null)
                    ;
                _chkbUTT = value;
                if (_chkbUTT == null)
                    ;
            }
        get => _chkbUTT;
    }

    internal virtual CheckBox chkbUTC
    {
        get => _chkbUTC;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbUTC == null)
                    ;
                _chkbUTC = value;
                if (_chkbUTC == null)
                    ;
            }
    }

    internal virtual CheckBox chkbUTW
    {
        get => _chkbUTW;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbUTW == null)
                    ;
                _chkbUTW = value;
                if (_chkbUTW == null)
                    ;
            }
    }

    internal virtual CheckBox chkbUTE
    {
        get => _chkbUTE;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbUTE == null)
                    ;
                _chkbUTE = value;
                if (_chkbUTE == null)
                    ;
            }
    }

    internal virtual CheckBox chkbUTS
    {
        get => _chkbUTS;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbUTS == null)
                    ;
                _chkbUTS = value;
                if (_chkbUTS == null)
                    ;
            }
    }

    internal virtual CheckBox chkbUTP
    {
        get => _chkbUTP;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbUTP == null)
                    ;
                _chkbUTP = value;
                if (_chkbUTP == null)
                    ;
            }
    }

    internal virtual Button btnOK
    {
        get => _btnOK;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnOK == null)
                    ;
                _btnOK = value;
                if (_btnOK == null)
                    ;
            }
    }

    internal virtual Button btnCancel
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnCancel == null)
                    ;
                _btnCancel = value;
                if (_btnCancel == null)
                    ;
            }
        get => _btnCancel;
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

    internal virtual CheckBox chkbNCS
    {
        get => _chkbNCS;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbNCS == null)
                    ;
                _chkbNCS = value;
                if (_chkbNCS == null)
                    ;
            }
    }

    internal virtual Button btnSelectAll
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnSelectAll != null)
                    _btnSelectAll.Click -= new EventHandler(btnSelectAll_Click);
                _btnSelectAll = value;
                if (_btnSelectAll == null)
                    return;
                _btnSelectAll.Click += new EventHandler(btnSelectAll_Click);
            }
        get => _btnSelectAll;
    }

    internal virtual Button btnClear
    {
        get => _btnClear;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnClear != null)
                    _btnClear.Click -= new EventHandler(btnClear_Click);
                _btnClear = value;
                if (_btnClear == null)
                    return;
                _btnClear.Click += new EventHandler(btnClear_Click);
            }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
            ResourceManager resourceManager = new ResourceManager(typeof(frmResourceTypeSelector));
            chkbGIT = new CheckBox();
            chkbARE = new CheckBox();
            chkbIFO = new CheckBox();
            chkbPTH = new CheckBox();
            chkbUTD = new CheckBox();
            chkbUTM = new CheckBox();
            chkbUTT = new CheckBox();
            chkbUTC = new CheckBox();
            chkbUTW = new CheckBox();
            chkbUTE = new CheckBox();
            chkbUTS = new CheckBox();
            chkbNCS = new CheckBox();
            chkbUTP = new CheckBox();
            btnOK = new Button();
            this.btnCancel = new Button();
            Label1 = new Label();
            this.btnSelectAll = new Button();
            this.btnClear = new Button();
            SuspendLayout();
            chkbGIT.Checked = true;
            chkbGIT.CheckState = CheckState.Checked;
            CheckBox chkbGit1 = chkbGIT;
            Point point1 = new Point(40, 48);
            Point point2 = point1;
            chkbGit1.Location = point2;
            chkbGIT.Name = "chkbGIT";
            CheckBox chkbGit2 = chkbGIT;
            Size size1 = new Size(152, 16);
            Size size2 = size1;
            chkbGit2.Size = size2;
            chkbGIT.TabIndex = 0;
            chkbGIT.Text = "Dynamic Module Info";
            chkbARE.Checked = true;
            chkbARE.CheckState = CheckState.Checked;
            CheckBox chkbAre1 = chkbARE;
            point1 = new Point(40, 72);
            Point point3 = point1;
            chkbAre1.Location = point3;
            chkbARE.Name = "chkbARE";
            CheckBox chkbAre2 = chkbARE;
            size1 = new Size(152, 16);
            Size size3 = size1;
            chkbAre2.Size = size3;
            chkbARE.TabIndex = 1;
            chkbARE.Text = "Static Module Info";
            chkbIFO.Checked = true;
            chkbIFO.CheckState = CheckState.Checked;
            CheckBox chkbIfo1 = chkbIFO;
            point1 = new Point(40, 96);
            Point point4 = point1;
            chkbIfo1.Location = point4;
            chkbIFO.Name = "chkbIFO";
            CheckBox chkbIfo2 = chkbIFO;
            size1 = new Size(152, 16);
            Size size4 = size1;
            chkbIfo2.Size = size4;
            chkbIFO.TabIndex = 2;
            chkbIFO.Text = "Module.ifo";
            chkbPTH.Checked = true;
            chkbPTH.CheckState = CheckState.Checked;
            CheckBox chkbPth1 = chkbPTH;
            point1 = new Point(40, 120);
            Point point5 = point1;
            chkbPth1.Location = point5;
            chkbPTH.Name = "chkbPTH";
            CheckBox chkbPth2 = chkbPTH;
            size1 = new Size(152, 16);
            Size size5 = size1;
            chkbPth2.Size = size5;
            chkbPTH.TabIndex = 3;
            chkbPTH.Text = "Path Info";
            chkbUTD.Checked = true;
            chkbUTD.CheckState = CheckState.Checked;
            CheckBox chkbUtd1 = chkbUTD;
            point1 = new Point(208, 48);
            Point point6 = point1;
            chkbUtd1.Location = point6;
            chkbUTD.Name = "chkbUTD";
            CheckBox chkbUtd2 = chkbUTD;
            size1 = new Size(120, 16);
            Size size6 = size1;
            chkbUtd2.Size = size6;
            chkbUTD.TabIndex = 4;
            chkbUTD.Text = "Doors";
            CheckBox chkbUtm1 = chkbUTM;
            point1 = new Point(208, 144);
            Point point7 = point1;
            chkbUtm1.Location = point7;
            chkbUTM.Name = "chkbUTM";
            CheckBox chkbUtm2 = chkbUTM;
            size1 = new Size(120, 16);
            Size size7 = size1;
            chkbUtm2.Size = size7;
            chkbUTM.TabIndex = 8;
            chkbUTM.Text = "Merchants";
            CheckBox chkbUtt1 = chkbUTT;
            point1 = new Point(208, 168);
            Point point8 = point1;
            chkbUtt1.Location = point8;
            chkbUTT.Name = "chkbUTT";
            CheckBox chkbUtt2 = chkbUTT;
            size1 = new Size(120, 16);
            Size size8 = size1;
            chkbUtt2.Size = size8;
            chkbUTT.TabIndex = 9;
            chkbUTT.Text = "Triggers";
            CheckBox chkbUtc1 = chkbUTC;
            point1 = new Point(208, 120);
            Point point9 = point1;
            chkbUtc1.Location = point9;
            chkbUTC.Name = "chkbUTC";
            CheckBox chkbUtc2 = chkbUTC;
            size1 = new Size(120, 16);
            Size size9 = size1;
            chkbUtc2.Size = size9;
            chkbUTC.TabIndex = 7;
            chkbUTC.Text = "Creatures";
            CheckBox chkbUtw1 = chkbUTW;
            point1 = new Point(208, 96);
            Point point10 = point1;
            chkbUtw1.Location = point10;
            chkbUTW.Name = "chkbUTW";
            CheckBox chkbUtw2 = chkbUTW;
            size1 = new Size(120, 16);
            Size size10 = size1;
            chkbUtw2.Size = size10;
            chkbUTW.TabIndex = 6;
            chkbUTW.Text = "Waypoints";
            CheckBox chkbUte1 = chkbUTE;
            point1 = new Point(208, 192);
            Point point11 = point1;
            chkbUte1.Location = point11;
            chkbUTE.Name = "chkbUTE";
            CheckBox chkbUte2 = chkbUTE;
            size1 = new Size(120, 16);
            Size size11 = size1;
            chkbUte2.Size = size11;
            chkbUTE.TabIndex = 10;
            chkbUTE.Text = "Encounters";
            CheckBox chkbUts1 = chkbUTS;
            point1 = new Point(208, 216);
            Point point12 = point1;
            chkbUts1.Location = point12;
            chkbUTS.Name = "chkbUTS";
            CheckBox chkbUts2 = chkbUTS;
            size1 = new Size(120, 16);
            Size size12 = size1;
            chkbUts2.Size = size12;
            chkbUTS.TabIndex = 11;
            chkbUTS.Text = "Sounds";
            CheckBox chkbNcs1 = chkbNCS;
            point1 = new Point(208, 240);
            Point point13 = point1;
            chkbNcs1.Location = point13;
            chkbNCS.Name = "chkbNCS";
            CheckBox chkbNcs2 = chkbNCS;
            size1 = new Size(120, 16);
            Size size13 = size1;
            chkbNcs2.Size = size13;
            chkbNCS.TabIndex = 12;
            chkbNCS.Text = "Compiled Scripts";
            chkbUTP.Checked = true;
            chkbUTP.CheckState = CheckState.Checked;
            CheckBox chkbUtp1 = chkbUTP;
            point1 = new Point(208, 72);
            Point point14 = point1;
            chkbUtp1.Location = point14;
            chkbUTP.Name = "chkbUTP";
            CheckBox chkbUtp2 = chkbUTP;
            size1 = new Size(120, 16);
            Size size14 = size1;
            chkbUtp2.Size = size14;
            chkbUTP.TabIndex = 5;
            chkbUTP.Text = "Placeables";
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.DialogResult = DialogResult.OK;
            Button btnOk = btnOK;
            point1 = new Point(160, 288);
            Point point15 = point1;
            btnOk.Location = point15;
            btnOK.Name = "btnOK";
            btnOK.TabIndex = 13;
            btnOK.Text = "Next >>";
            this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnCancel.DialogResult = DialogResult.Cancel;
            Button btnCancel = this.btnCancel;
            point1 = new Point(256, 288);
            Point point16 = point1;
            btnCancel.Location = point16;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            Label label1_1 = Label1;
            point1 = new Point(88, 16);
            Point point17 = point1;
            label1_1.Location = point17;
            Label1.Name = "Label1";
            Label label1_2 = Label1;
            size1 = new Size(208, 16);
            Size size15 = size1;
            label1_2.Size = size15;
            Label1.TabIndex = 5;
            Label1.Text = "Select the resource types to extract:";
            this.btnSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button btnSelectAll = this.btnSelectAll;
            point1 = new Point(48, 184);
            Point point18 = point1;
            btnSelectAll.Location = point18;
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.TabIndex = 14;
            this.btnSelectAll.Text = "Select All";
            this.btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button btnClear = this.btnClear;
            point1 = new Point(48, 216);
            Point point19 = point1;
            btnClear.Location = point19;
            this.btnClear.Name = "btnClear";
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            AcceptButton = btnOK;
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            CancelButton = this.btnCancel;
            size1 = new Size(360, 325);
            ClientSize = size1;
            Controls.Add(Label1);
            Controls.Add(btnOK);
            Controls.Add(chkbPTH);
            Controls.Add(chkbUTD);
            Controls.Add(chkbUTM);
            Controls.Add(chkbGIT);
            Controls.Add(chkbARE);
            Controls.Add(chkbIFO);
            Controls.Add(chkbUTT);
            Controls.Add(chkbUTC);
            Controls.Add(chkbUTW);
            Controls.Add(chkbUTE);
            Controls.Add(chkbUTS);
            Controls.Add(chkbNCS);
            Controls.Add(chkbUTP);
            Controls.Add(this.btnCancel);
            Controls.Add(this.btnSelectAll);
            Controls.Add(this.btnClear);
            Icon = (Icon)resourceManager.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = nameof(frmResourceTypeSelector);
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Resource Type Selector";
            ResumeLayout(false);
        }

    public Hashtable SelectedResTypes
    {
        get
        {
                Hashtable selectedResTypes = new Hashtable();
                if (chkbARE.Checked)
                    selectedResTypes.Add(FrmMain.GetIdForRsrcType("are"), 0);
                if (chkbGIT.Checked)
                    selectedResTypes.Add(FrmMain.GetIdForRsrcType("git"), 0);
                if (chkbIFO.Checked)
                    selectedResTypes.Add(FrmMain.GetIdForRsrcType("ifo"), 0);
                if (chkbNCS.Checked)
                    selectedResTypes.Add(FrmMain.GetIdForRsrcType("ncs"), 0);
                if (chkbPTH.Checked)
                    selectedResTypes.Add(FrmMain.GetIdForRsrcType("pth"), 0);
                if (chkbUTC.Checked)
                    selectedResTypes.Add(FrmMain.GetIdForRsrcType("utc"), 0);
                if (chkbUTD.Checked)
                    selectedResTypes.Add(FrmMain.GetIdForRsrcType("utd"), 0);
                if (chkbUTE.Checked)
                    selectedResTypes.Add(FrmMain.GetIdForRsrcType("ute"), 0);
                if (chkbUTM.Checked)
                    selectedResTypes.Add(FrmMain.GetIdForRsrcType("utm"), 0);
                if (chkbUTP.Checked)
                    selectedResTypes.Add(FrmMain.GetIdForRsrcType("utp"), 0);
                if (chkbUTS.Checked)
                    selectedResTypes.Add(FrmMain.GetIdForRsrcType("uts"), 0);
                if (chkbUTT.Checked)
                    selectedResTypes.Add(FrmMain.GetIdForRsrcType("utt"), 0);
                if (chkbUTW.Checked)
                    selectedResTypes.Add(FrmMain.GetIdForRsrcType("utw"), 0);
                if (selectedResTypes.Count == 0)
                    selectedResTypes = null;
                return selectedResTypes;
            }
    }

    private void btnSelectAll_Click(object sender, EventArgs e) => SetCheckboxesState(true);

    private void btnClear_Click(object sender, EventArgs e) => SetCheckboxesState(false);

    private void SetCheckboxesState(bool @checked)
    {
            chkbARE.Checked = @checked;
            chkbGIT.Checked = @checked;
            chkbIFO.Checked = @checked;
            chkbNCS.Checked = @checked;
            chkbPTH.Checked = @checked;
            chkbUTC.Checked = @checked;
            chkbUTD.Checked = @checked;
            chkbUTE.Checked = @checked;
            chkbUTM.Checked = @checked;
            chkbUTP.Checked = @checked;
            chkbUTS.Checked = @checked;
            chkbUTT.Checked = @checked;
            chkbUTW.Checked = @checked;
        }
}