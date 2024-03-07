// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmSoundChooser
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmSoundChooser : Form
{
    [AccessedThroughProperty("btnCancel")] private Button _btnCancel;

    [AccessedThroughProperty("lblSoundCount")]
    private Label _lblSoundCount;

    [AccessedThroughProperty("btnOK")] private Button _btnOK;
    [AccessedThroughProperty("Label1")] private Label _Label1;

    [AccessedThroughProperty("cmbxFilter")]
    private ComboBox _cmbxFilter;

    [AccessedThroughProperty("btnPlaySound")]
    private Button _btnPlaySound;

    [AccessedThroughProperty("tbFilter")] private TextBox _tbFilter;
    [AccessedThroughProperty("Label3")] private Label _Label3;

    [AccessedThroughProperty("chkbLookStreamSounds")]
    private CheckBox _chkbLookStreamSounds;

    [AccessedThroughProperty("btnStopSound")]
    private Button _btnStopSound;

    [AccessedThroughProperty("lbSounds")] private ListBox _lbSounds;

    [AccessedThroughProperty("chkbLookSoundsBif")]
    private CheckBox _chkbLookSoundsBif;

    [AccessedThroughProperty("Label2")] private Label _Label2;
    private IContainer components;
    private ArrayList FilterList;
    private Hashtable _soundBifFilesHash;
    private Hashtable _StreamSoundsFilesHash;
    private ListBox.SelectedObjectCollection _selected;

    public frmSoundChooser()
    {
            Load += new EventHandler(frmSoundChooser_Load);
            FilterList = new ArrayList();
            InitializeComponent();
            SetUpcmbxFilter();
        }

    protected override void Dispose(bool disposing)
    {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

    internal virtual Button btnPlaySound
    {
        get => _btnPlaySound;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnPlaySound != null)
                    _btnPlaySound.Click -= new EventHandler(btnPlaySound_Click);
                _btnPlaySound = value;
                if (_btnPlaySound == null)
                    return;
                _btnPlaySound.Click += new EventHandler(btnPlaySound_Click);
            }
    }

    internal virtual Button btnStopSound
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnStopSound != null)
                    _btnStopSound.Click -= new EventHandler(btnStopSound_Click);
                _btnStopSound = value;
                if (_btnStopSound == null)
                    return;
                _btnStopSound.Click += new EventHandler(btnStopSound_Click);
            }
        get => _btnStopSound;
    }

    internal virtual ListBox lbSounds
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_lbSounds != null)
                    _lbSounds.SelectedIndexChanged -= new EventHandler(lbSounds_SelectedIndexChanged);
                _lbSounds = value;
                if (_lbSounds == null)
                    return;
                _lbSounds.SelectedIndexChanged += new EventHandler(lbSounds_SelectedIndexChanged);
            }
        get => _lbSounds;
    }

    internal virtual CheckBox chkbLookSoundsBif
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbLookSoundsBif != null)
                    _chkbLookSoundsBif.CheckedChanged -= new EventHandler(LookForSoundsChkBxsChanged);
                _chkbLookSoundsBif = value;
                if (_chkbLookSoundsBif == null)
                    return;
                _chkbLookSoundsBif.CheckedChanged += new EventHandler(LookForSoundsChkBxsChanged);
            }
        get => _chkbLookSoundsBif;
    }

    internal virtual CheckBox chkbLookStreamSounds
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbLookStreamSounds != null)
                    _chkbLookStreamSounds.CheckedChanged -= new EventHandler(LookForSoundsChkBxsChanged);
                _chkbLookStreamSounds = value;
                if (_chkbLookStreamSounds == null)
                    return;
                _chkbLookStreamSounds.CheckedChanged += new EventHandler(LookForSoundsChkBxsChanged);
            }
        get => _chkbLookStreamSounds;
    }

    internal virtual TextBox tbFilter
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbFilter != null)
                    _tbFilter.TextChanged -= new EventHandler(tbFilter_TextChanged);
                _tbFilter = value;
                if (_tbFilter == null)
                    return;
                _tbFilter.TextChanged += new EventHandler(tbFilter_TextChanged);
            }
        get => _tbFilter;
    }

    internal virtual ComboBox cmbxFilter
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_cmbxFilter != null)
                    _cmbxFilter.SelectedIndexChanged -= new EventHandler(cmbxFilter_SelectedIndexChanged);
                _cmbxFilter = value;
                if (_cmbxFilter == null)
                    return;
                _cmbxFilter.SelectedIndexChanged += new EventHandler(cmbxFilter_SelectedIndexChanged);
            }
        get => _cmbxFilter;
    }

    internal virtual Label lblSoundCount
    {
        get => _lblSoundCount;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_lblSoundCount == null)
                    ;
                _lblSoundCount = value;
                if (_lblSoundCount == null)
                    ;
            }
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

    internal virtual Label Label1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label1 == null)
                    ;
                _Label1 = value;
                if (_Label1 == null)
                    ;
            }
        get => _Label1;
    }

    internal virtual Label Label3
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label3 == null)
                    ;
                _Label3 = value;
                if (_Label3 == null)
                    ;
            }
        get => _Label3;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
            ResourceManager resourceManager = new ResourceManager(typeof(frmSoundChooser));
            btnPlaySound = new Button();
            btnStopSound = new Button();
            lbSounds = new ListBox();
            chkbLookSoundsBif = new CheckBox();
            chkbLookStreamSounds = new CheckBox();
            tbFilter = new TextBox();
            cmbxFilter = new ComboBox();
            lblSoundCount = new Label();
            Label2 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            Label1 = new Label();
            Label3 = new Label();
            SuspendLayout();
            btnPlaySound.Enabled = false;
            Button btnPlaySound1 = btnPlaySound;
            Point point1 = new Point(184, 8);
            Point point2 = point1;
            btnPlaySound1.Location = point2;
            btnPlaySound.Name = "btnPlaySound";
            Button btnPlaySound2 = btnPlaySound;
            Size size1 = new Size(80, 23);
            Size size2 = size1;
            btnPlaySound2.Size = size2;
            btnPlaySound.TabIndex = 21;
            btnPlaySound.Text = "Play Sound";
            btnStopSound.Enabled = false;
            Button btnStopSound1 = btnStopSound;
            point1 = new Point(272, 8);
            Point point3 = point1;
            btnStopSound1.Location = point3;
            btnStopSound.Name = "btnStopSound";
            Button btnStopSound2 = btnStopSound;
            size1 = new Size(80, 23);
            Size size3 = size1;
            btnStopSound2.Size = size3;
            btnStopSound.TabIndex = 20;
            btnStopSound.Text = "Stop";
            lbSounds.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListBox lbSounds1 = lbSounds;
            point1 = new Point(16, 40);
            Point point4 = point1;
            lbSounds1.Location = point4;
            lbSounds.MultiColumn = true;
            lbSounds.Name = "lbSounds";
            lbSounds.SelectionMode = SelectionMode.MultiExtended;
            ListBox lbSounds2 = lbSounds;
            size1 = new Size(496, 160);
            Size size4 = size1;
            lbSounds2.Size = size4;
            lbSounds.TabIndex = 22;
            chkbLookSoundsBif.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkbLookSoundsBif.Checked = true;
            chkbLookSoundsBif.CheckState = CheckState.Checked;
            CheckBox chkbLookSoundsBif1 = chkbLookSoundsBif;
            point1 = new Point(32, 240);
            Point point5 = point1;
            chkbLookSoundsBif1.Location = point5;
            chkbLookSoundsBif.Name = "chkbLookSoundsBif";
            CheckBox chkbLookSoundsBif2 = chkbLookSoundsBif;
            size1 = new Size(104, 16);
            Size size5 = size1;
            chkbLookSoundsBif2.Size = size5;
            chkbLookSoundsBif.TabIndex = 23;
            chkbLookSoundsBif.Text = "Sounds.bif";
            chkbLookStreamSounds.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkbLookStreamSounds.Checked = true;
            chkbLookStreamSounds.CheckState = CheckState.Checked;
            CheckBox lookStreamSounds1 = chkbLookStreamSounds;
            point1 = new Point(32, 264);
            Point point6 = point1;
            lookStreamSounds1.Location = point6;
            chkbLookStreamSounds.Name = "chkbLookStreamSounds";
            CheckBox lookStreamSounds2 = chkbLookStreamSounds;
            size1 = new Size(104, 16);
            Size size6 = size1;
            lookStreamSounds2.Size = size6;
            chkbLookStreamSounds.TabIndex = 23;
            chkbLookStreamSounds.Text = "StreamSounds";
            tbFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TextBox tbFilter1 = tbFilter;
            point1 = new Point(208, 232);
            Point point7 = point1;
            tbFilter1.Location = point7;
            tbFilter.Name = "tbFilter";
            TextBox tbFilter2 = tbFilter;
            size1 = new Size(136, 20);
            Size size7 = size1;
            tbFilter2.Size = size7;
            tbFilter.TabIndex = 24;
            tbFilter.Text = "";
            cmbxFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmbxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox cmbxFilter1 = cmbxFilter;
            point1 = new Point(208, 280);
            Point point8 = point1;
            cmbxFilter1.Location = point8;
            cmbxFilter.MaxDropDownItems = 16;
            cmbxFilter.Name = "cmbxFilter";
            ComboBox cmbxFilter2 = cmbxFilter;
            size1 = new Size(200, 21);
            Size size8 = size1;
            cmbxFilter2.Size = size8;
            cmbxFilter.TabIndex = 25;
            lblSoundCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSoundCount.ForeColor = SystemColors.Highlight;
            Label lblSoundCount1 = lblSoundCount;
            point1 = new Point(408, 12);
            Point point9 = point1;
            lblSoundCount1.Location = point9;
            lblSoundCount.Name = "lblSoundCount";
            Label lblSoundCount2 = lblSoundCount;
            size1 = new Size(100, 16);
            Size size9 = size1;
            lblSoundCount2.Size = size9;
            lblSoundCount.TabIndex = 26;
            Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label label2_1 = Label2;
            point1 = new Point(32, 216);
            Point point10 = point1;
            label2_1.Location = point10;
            Label2.Name = "Label2";
            Label label2_2 = Label2;
            size1 = new Size(112, 16);
            Size size10 = size1;
            label2_2.Size = size10;
            Label2.TabIndex = 26;
            Label2.Text = "Show sounds from:";
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.DialogResult = DialogResult.OK;
            Button btnOk1 = btnOK;
            point1 = new Point(432, 224);
            Point point11 = point1;
            btnOk1.Location = point11;
            btnOK.Name = "btnOK";
            Button btnOk2 = btnOK;
            size1 = new Size(80, 23);
            Size size11 = size1;
            btnOk2.Size = size11;
            btnOK.TabIndex = 21;
            btnOK.Text = "OK";
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            Button btnCancel1 = btnCancel;
            point1 = new Point(432, 272);
            Point point12 = point1;
            btnCancel1.Location = point12;
            btnCancel.Name = "btnCancel";
            Button btnCancel2 = btnCancel;
            size1 = new Size(80, 23);
            Size size12 = size1;
            btnCancel2.Size = size12;
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Label label1_1 = Label1;
            point1 = new Point(208, 216);
            Point point13 = point1;
            label1_1.Location = point13;
            Label1.Name = "Label1";
            Label label1_2 = Label1;
            size1 = new Size(112, 16);
            Size size13 = size1;
            label1_2.Size = size13;
            Label1.TabIndex = 26;
            Label1.Text = "Name Filter";
            Label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Label label3_1 = Label3;
            point1 = new Point(208, 264);
            Point point14 = point1;
            label3_1.Location = point14;
            Label3.Name = "Label3";
            Label label3_2 = Label3;
            size1 = new Size(112, 16);
            Size size14 = size1;
            label3_2.Size = size14;
            Label3.TabIndex = 26;
            Label3.Text = "Sound Type Filter";
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            CancelButton = btnCancel;
            size1 = new Size(536, 309);
            ClientSize = size1;
            Controls.Add(lblSoundCount);
            Controls.Add(cmbxFilter);
            Controls.Add(tbFilter);
            Controls.Add(chkbLookSoundsBif);
            Controls.Add(lbSounds);
            Controls.Add(btnPlaySound);
            Controls.Add(btnStopSound);
            Controls.Add(chkbLookStreamSounds);
            Controls.Add(Label2);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(Label1);
            Controls.Add(Label3);
            Icon = (Icon)resourceManager.GetObject("$this.Icon");
            size1 = new Size(504, 232);
            MinimumSize = size1;
            Name = nameof(frmSoundChooser);
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Sound Selector";
            ResumeLayout(false);
        }

    private void btnPlaySound_Click(object sender, EventArgs e)
    {
            if (!((frmUTS_Editor)Owner).PlaySound(
                    StringType.FromObject(ObjectType.StrCatObj(lbSounds.SelectedItem, ".wav"))))
                return;
            btnPlaySound.Enabled = false;
            btnStopSound.Enabled = true;
        }

    private void lbSounds_SelectedIndexChanged(object sender, EventArgs e) => btnPlaySound.Enabled =
        !((frmUTS_Editor)Owner).IsSoundPlaying() && lbSounds.SelectedIndices.Count > 0;

    public Hashtable SoundBifFilesHash
    {
        get => _soundBifFilesHash;
        set
        {
                _soundBifFilesHash = value;
                AddSoundFileHashesToLB();
            }
    }

    public Hashtable StreamSoundsFilesHash
    {
        get => _StreamSoundsFilesHash;
        set
        {
                _StreamSoundsFilesHash = value;
                AddSoundFileHashesToLB();
            }
    }

    public ListBox.SelectedObjectCollection SelectedSounds => lbSounds.SelectedItems;

    private void tbFilter_TextChanged(object sender, EventArgs e) => AddSoundFileHashesToLB();

    private void cmbxFilter_SelectedIndexChanged(object sender, EventArgs e) => AddSoundFileHashesToLB();

    private void AddSoundFileHashesToLB()
    {
            lbSounds.BeginUpdate();
            lbSounds.Items.Clear();
            FilterItem selectedItem = (FilterItem)cmbxFilter.SelectedItem;
            if (_soundBifFilesHash != null && chkbLookSoundsBif.Checked)
            {
                foreach (object obj in _soundBifFilesHash)
                {
                    DictionaryEntry dictionaryEntry =
                        (DictionaryEntry)(obj ?? Activator.CreateInstance(typeof(DictionaryEntry)));
                    if ((StringType.StrCmp(selectedItem._filter, "", false) == 0 ||
                         StringType.StrCmp(selectedItem._filter, "", false) != 0 &&
                         dictionaryEntry.Key.ToString().StartsWith(selectedItem._filter)) &&
                        dictionaryEntry.Key.ToString().IndexOf(tbFilter.Text) > -1)
                        lbSounds.Items.Add(dictionaryEntry.Key.ToString().Replace(".wav", ""));
                }
            }

            if (_StreamSoundsFilesHash != null && chkbLookStreamSounds.Checked)
            {
                foreach (object obj in _StreamSoundsFilesHash)
                {
                    DictionaryEntry dictionaryEntry =
                        (DictionaryEntry)(obj ?? Activator.CreateInstance(typeof(DictionaryEntry)));
                    if ((StringType.StrCmp(selectedItem._filter, "", false) == 0 ||
                         StringType.StrCmp(selectedItem._filter, "", false) != 0 &&
                         dictionaryEntry.Key.ToString().StartsWith(selectedItem._filter)) &&
                        dictionaryEntry.Key.ToString().IndexOf(tbFilter.Text) > -1)
                        lbSounds.Items.Add(dictionaryEntry.Key.ToString().Replace(".wav", ""));
                }
            }

            lbSounds.Sorted = true;
            lbSounds.EndUpdate();
            lblSoundCount.Text = StringType.FromInteger(lbSounds.Items.Count) + " Sound";
            if (lbSounds.Items.Count <= 1 && lbSounds.Items.Count != 0)
                return;
            lblSoundCount.Text += "s";
        }

    private void LookForSoundsChkBxsChanged(object sender, EventArgs e) => AddSoundFileHashesToLB();

    private void SetUpcmbxFilter()
    {
            FilterList.Add(new FilterItem("Ambient - Single shot", "as_"));
            FilterList.Add(new FilterItem("Ambient - Looping", "al_"));
            FilterList.Add(new FilterItem("Animals - Single shot", "as_an_"));
            FilterList.Add(new FilterItem("Electronic - Single shot", "as_el_"));
            FilterList.Add(new FilterItem("Environment - Single shot", "as_en_"));
            FilterList.Add(new FilterItem("Mechanical - Single shot", "as_me_"));
            FilterList.Add(new FilterItem("Natural - Single shot", "as_nt_"));
            FilterList.Add(new FilterItem("Other - Single shot", "as_ot_"));
            FilterList.Add(new FilterItem("People - Single shot", "as_pl_"));
            FilterList.Add(new FilterItem("Visual Effects - Single shot", "as_en_"));
            FilterList.Add(new FilterItem("Animals - Looping", "al_an_"));
            FilterList.Add(new FilterItem("Electronic - Looping", "al_el_"));
            FilterList.Add(new FilterItem("Environment - Looping", "al_en_"));
            FilterList.Add(new FilterItem("Mechanical - Looping", "al_me_"));
            FilterList.Add(new FilterItem("Natural - Looping", "al_nt_"));
            FilterList.Add(new FilterItem("Other - Looping", "al_ot_"));
            FilterList.Add(new FilterItem("People - Looping", "al_pl_"));
            FilterList.Add(new FilterItem("Visual Effects - Looping", "al_en_"));
            FilterList.Add(new FilterItem("All Files", ""));
            ((ListControl)cmbxFilter).DataSource = FilterList;
        }

    private void OwnerStoppedPlaying()
    {
            btnPlaySound.Enabled = true;
            btnStopSound.Enabled = false;
        }

    private void btnStopSound_Click(object sender, EventArgs e)
    {
            ((frmUTS_Editor)Owner).StopSound();
            OwnerStoppedPlaying();
        }

    private void frmSoundChooser_Load(object sender, EventArgs e) => ((frmUTS_Editor)Owner).StoppedPlaying +=
        new frmUTS_Editor.StoppedPlayingEventHandler(OwnerStoppedPlaying);

    private class FilterItem
    {
        public string _Text;
        public string _filter;

        public override string ToString() => _Text;

        public FilterItem()
        {
            }

        public FilterItem(string Text, string Filter)
        {
                _Text = Text;
                _filter = Filter;
            }
    }
}