using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmUTW_Editor : frmParent
{
    [AccessedThroughProperty("Label2")] private Label _Label2;

    [AccessedThroughProperty("tbTemplateResRef")]
    private TextBox _tbTemplateResRef;

    [AccessedThroughProperty("tbName")] private TextBox _tbName;

    [AccessedThroughProperty("chkbMapNoteEnabled")]
    private CheckBox _chkbMapNoteEnabled;

    [AccessedThroughProperty("tbComment")] private TextBox _tbComment;
    [AccessedThroughProperty("btnSave")] private Button _btnSave;
    [AccessedThroughProperty("Label9")] private Label _Label9;
    [AccessedThroughProperty("Label1")] private Label _Label1;

    [AccessedThroughProperty("tbWpMapNote")]
    private TextBox _tbWpMapNote;

    [AccessedThroughProperty("chkbHasMapNote")]
    private CheckBox _chkbHasMapNote;

    [AccessedThroughProperty("btnDebug")] private Button _btnDebug;
    [AccessedThroughProperty("Label3")] private Label _Label3;

    [AccessedThroughProperty("tbWpDescription")]
    private TextBox _tbWpDescription;

    [AccessedThroughProperty("Label11")] private Label _Label11;
    [AccessedThroughProperty("btnCancel")] private Button _btnCancel;

    [AccessedThroughProperty("btnSetNameLang")]
    private Button _btnSetNameLang;

    [AccessedThroughProperty("Label57")] private Label _Label57;
    [AccessedThroughProperty("Label12")] private Label _Label12;
    [AccessedThroughProperty("tbTag")] private TextBox _tbTag;

    [AccessedThroughProperty("tbWPLinkedTo")]
    private TextBox _tbWPLinkedTo;

    private IContainer components;
    public clsUTW UTW;
    public clsDialogTlk g_clsDialogTlk;
    private int NameLang;
    private bool ComboBoxSettingError;
    private bool m_bSaveGameMode;

    public frmUTW_Editor()
    {
            Load += new EventHandler(frmUTW_Editor_Load);
            Closing += new CancelEventHandler(frmUTW_Editor_Closing);
            ComboBoxSettingError = false;
            m_bSaveGameMode = false;
            InitializeComponent();
        }

    protected override void Dispose(bool disposing)
    {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

    internal virtual Button btnSave
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnSave != null)
                    _btnSave.Click -= new EventHandler(btnSave_Click);
                _btnSave = value;
                if (_btnSave == null)
                    return;
                _btnSave.Click += new EventHandler(btnSave_Click);
            }
        get => _btnSave;
    }

    internal virtual Button btnCancel
    {
        get => _btnCancel;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnCancel != null)
                    _btnCancel.Click -= new EventHandler(btnCancel_Click);
                _btnCancel = value;
                if (_btnCancel == null)
                    return;
                _btnCancel.Click += new EventHandler(btnCancel_Click);
            }
    }

    internal virtual Button btnSetNameLang
    {
        get => _btnSetNameLang;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnSetNameLang != null)
                    _btnSetNameLang.Click -= new EventHandler(btnSetNameLang_Click);
                _btnSetNameLang = value;
                if (_btnSetNameLang == null)
                    return;
                _btnSetNameLang.Click += new EventHandler(btnSetNameLang_Click);
            }
    }

    internal virtual Button btnDebug
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnDebug != null)
                    _btnDebug.Click -= new EventHandler(btnDebug_Click);
                _btnDebug = value;
                if (_btnDebug == null)
                    return;
                _btnDebug.Click += new EventHandler(btnDebug_Click);
            }
        get => _btnDebug;
    }

    internal virtual TextBox tbName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbName == null)
                    ;
                _tbName = value;
                if (_tbName == null)
                    ;
            }
        get => _tbName;
    }

    internal virtual Label Label11
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label11 == null)
                    ;
                _Label11 = value;
                if (_Label11 == null)
                    ;
            }
        get => _Label11;
    }

    internal virtual TextBox tbTemplateResRef
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbTemplateResRef == null)
                    ;
                _tbTemplateResRef = value;
                if (_tbTemplateResRef == null)
                    ;
            }
        get => _tbTemplateResRef;
    }

    internal virtual Label Label57
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label57 == null)
                    ;
                _Label57 = value;
                if (_Label57 == null)
                    ;
            }
        get => _Label57;
    }

    internal virtual TextBox tbTag
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbTag == null)
                    ;
                _tbTag = value;
                if (_tbTag == null)
                    ;
            }
        get => _tbTag;
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

    internal virtual TextBox tbComment
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbComment == null)
                    ;
                _tbComment = value;
                if (_tbComment == null)
                    ;
            }
        get => _tbComment;
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

    internal virtual CheckBox chkbHasMapNote
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbHasMapNote == null)
                    ;
                _chkbHasMapNote = value;
                if (_chkbHasMapNote == null)
                    ;
            }
        get => _chkbHasMapNote;
    }

    internal virtual Label Label9
    {
        get => _Label9;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label9 == null)
                    ;
                _Label9 = value;
                if (_Label9 == null)
                    ;
            }
    }

    internal virtual TextBox tbWPLinkedTo
    {
        get => _tbWPLinkedTo;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbWPLinkedTo == null)
                    ;
                _tbWPLinkedTo = value;
                if (_tbWPLinkedTo == null)
                    ;
            }
    }

    internal virtual TextBox tbWpDescription
    {
        get => _tbWpDescription;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbWpDescription == null)
                    ;
                _tbWpDescription = value;
                if (_tbWpDescription == null)
                    ;
            }
    }

    internal virtual TextBox tbWpMapNote
    {
        get => _tbWpMapNote;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbWpMapNote == null)
                    ;
                _tbWpMapNote = value;
                if (_tbWpMapNote == null)
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

    internal virtual Label Label12
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label12 == null)
                    ;
                _Label12 = value;
                if (_Label12 == null)
                    ;
            }
        get => _Label12;
    }

    internal virtual CheckBox chkbMapNoteEnabled
    {
        get => _chkbMapNoteEnabled;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbMapNoteEnabled == null)
                    ;
                _chkbMapNoteEnabled = value;
                if (_chkbMapNoteEnabled == null)
                    ;
            }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
            this.btnSave = new Button();
            this.btnCancel = new Button();
            btnSetNameLang = new Button();
            btnDebug = new Button();
            tbName = new TextBox();
            Label11 = new Label();
            tbTemplateResRef = new TextBox();
            Label57 = new Label();
            tbTag = new TextBox();
            Label2 = new Label();
            tbComment = new TextBox();
            Label1 = new Label();
            chkbHasMapNote = new CheckBox();
            Label9 = new Label();
            tbWPLinkedTo = new TextBox();
            tbWpDescription = new TextBox();
            tbWpMapNote = new TextBox();
            Label3 = new Label();
            Label12 = new Label();
            chkbMapNoteEnabled = new CheckBox();
            SuspendLayout();
            this.btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button btnSave = this.btnSave;
            Point point1 = new Point(288, 416);
            Point point2 = point1;
            btnSave.Location = point2;
            this.btnSave.Name = "btnSave";
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnCancel.DialogResult = DialogResult.Cancel;
            Button btnCancel = this.btnCancel;
            point1 = new Point(384, 416);
            Point point3 = point1;
            btnCancel.Location = point3;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            btnSetNameLang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button btnSetNameLang1 = btnSetNameLang;
            point1 = new Point(40, 416);
            Point point4 = point1;
            btnSetNameLang1.Location = point4;
            btnSetNameLang.Name = "btnSetNameLang";
            Button btnSetNameLang2 = btnSetNameLang;
            Size size1 = new Size(88, 23);
            Size size2 = size1;
            btnSetNameLang2.Size = size2;
            btnSetNameLang.TabIndex = 7;
            btnSetNameLang.Text = "Set Language";
            btnDebug.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDebug.FlatStyle = FlatStyle.Flat;
            btnDebug.ForeColor = SystemColors.Control;
            Button btnDebug1 = btnDebug;
            point1 = new Point(0, 88);
            Point point5 = point1;
            btnDebug1.Location = point5;
            btnDebug.Name = "btnDebug";
            Button btnDebug2 = btnDebug;
            size1 = new Size(8, 8);
            Size size3 = size1;
            btnDebug2.Size = size3;
            btnDebug.TabIndex = 18;
            btnDebug.TabStop = false;
            TextBox tbName1 = tbName;
            point1 = new Point(168, 56);
            Point point6 = point1;
            tbName1.Location = point6;
            tbName.Name = "tbName";
            TextBox tbName2 = tbName;
            size1 = new Size(176, 20);
            Size size4 = size1;
            tbName2.Size = size4;
            tbName.TabIndex = 19;
            tbName.Text = "";
            Label label11_1 = Label11;
            point1 = new Point(56, 56);
            Point point7 = point1;
            label11_1.Location = point7;
            Label11.Name = "Label11";
            Label label11_2 = Label11;
            size1 = new Size(100, 16);
            Size size5 = size1;
            label11_2.Size = size5;
            Label11.TabIndex = 20;
            Label11.Text = "Name";
            Label11.TextAlign = ContentAlignment.MiddleLeft;
            tbTemplateResRef.CharacterCasing = CharacterCasing.Lower;
            TextBox tbTemplateResRef1 = tbTemplateResRef;
            point1 = new Point(168, 24);
            Point point8 = point1;
            tbTemplateResRef1.Location = point8;
            tbTemplateResRef.MaxLength = 16;
            tbTemplateResRef.Name = "tbTemplateResRef";
            TextBox tbTemplateResRef2 = tbTemplateResRef;
            size1 = new Size(176, 20);
            Size size6 = size1;
            tbTemplateResRef2.Size = size6;
            tbTemplateResRef.TabIndex = 22;
            tbTemplateResRef.Text = "";
            Label label57_1 = Label57;
            point1 = new Point(56, 24);
            Point point9 = point1;
            label57_1.Location = point9;
            Label57.Name = "Label57";
            Label label57_2 = Label57;
            size1 = new Size(100, 18);
            Size size7 = size1;
            label57_2.Size = size7;
            Label57.TabIndex = 21;
            Label57.Text = "Template ResRef";
            Label57.TextAlign = ContentAlignment.MiddleLeft;
            TextBox tbTag1 = tbTag;
            point1 = new Point(168, 88);
            Point point10 = point1;
            tbTag1.Location = point10;
            tbTag.Name = "tbTag";
            TextBox tbTag2 = tbTag;
            size1 = new Size(176, 20);
            Size size8 = size1;
            tbTag2.Size = size8;
            tbTag.TabIndex = 24;
            tbTag.Text = "";
            Label label2_1 = Label2;
            point1 = new Point(56, 88);
            Point point11 = point1;
            label2_1.Location = point11;
            Label2.Name = "Label2";
            Label label2_2 = Label2;
            size1 = new Size(100, 16);
            Size size9 = size1;
            label2_2.Size = size9;
            Label2.TabIndex = 23;
            Label2.Text = "Tag";
            Label2.TextAlign = ContentAlignment.MiddleLeft;
            tbComment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox tbComment1 = tbComment;
            point1 = new Point(168, 336);
            Point point12 = point1;
            tbComment1.Location = point12;
            tbComment.Multiline = true;
            tbComment.Name = "tbComment";
            tbComment.ScrollBars = ScrollBars.Vertical;
            TextBox tbComment2 = tbComment;
            size1 = new Size(296, 48);
            Size size10 = size1;
            tbComment2.Size = size10;
            tbComment.TabIndex = 25;
            tbComment.Text = "";
            Label label1_1 = Label1;
            point1 = new Point(56, 344);
            Point point13 = point1;
            label1_1.Location = point13;
            Label1.Name = "Label1";
            Label label1_2 = Label1;
            size1 = new Size(88, 16);
            Size size11 = size1;
            label1_2.Size = size11;
            Label1.TabIndex = 23;
            Label1.Text = "Comment";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            CheckBox chkbHasMapNote1 = chkbHasMapNote;
            point1 = new Point(168, 224);
            Point point14 = point1;
            chkbHasMapNote1.Location = point14;
            chkbHasMapNote.Name = "chkbHasMapNote";
            CheckBox chkbHasMapNote2 = chkbHasMapNote;
            size1 = new Size(192, 24);
            Size size12 = size1;
            chkbHasMapNote2.Size = size12;
            chkbHasMapNote.TabIndex = 33;
            chkbHasMapNote.Text = "Waypoint Contains a Map Note";
            Label label9_1 = Label9;
            point1 = new Point(56, 120);
            Point point15 = point1;
            label9_1.Location = point15;
            Label9.Name = "Label9";
            Label label9_2 = Label9;
            size1 = new Size(100, 16);
            Size size13 = size1;
            label9_2.Size = size13;
            Label9.TabIndex = 31;
            Label9.Text = "Linked To";
            Label9.TextAlign = ContentAlignment.MiddleLeft;
            TextBox tbWpLinkedTo1 = tbWPLinkedTo;
            point1 = new Point(168, 120);
            Point point16 = point1;
            tbWpLinkedTo1.Location = point16;
            tbWPLinkedTo.Name = "tbWPLinkedTo";
            TextBox tbWpLinkedTo2 = tbWPLinkedTo;
            size1 = new Size(208, 20);
            Size size14 = size1;
            tbWpLinkedTo2.Size = size14;
            tbWPLinkedTo.TabIndex = 28;
            tbWPLinkedTo.Text = "";
            tbWpDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox tbWpDescription1 = tbWpDescription;
            point1 = new Point(168, 160);
            Point point17 = point1;
            tbWpDescription1.Location = point17;
            tbWpDescription.Multiline = true;
            tbWpDescription.Name = "tbWpDescription";
            tbWpDescription.ScrollBars = ScrollBars.Vertical;
            TextBox tbWpDescription2 = tbWpDescription;
            size1 = new Size(296, 48);
            Size size15 = size1;
            tbWpDescription2.Size = size15;
            tbWpDescription.TabIndex = 26;
            tbWpDescription.Text = "";
            tbWpMapNote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox tbWpMapNote1 = tbWpMapNote;
            point1 = new Point(168, 264);
            Point point18 = point1;
            tbWpMapNote1.Location = point18;
            tbWpMapNote.Multiline = true;
            tbWpMapNote.Name = "tbWpMapNote";
            tbWpMapNote.ScrollBars = ScrollBars.Vertical;
            TextBox tbWpMapNote2 = tbWpMapNote;
            size1 = new Size(296, 48);
            Size size16 = size1;
            tbWpMapNote2.Size = size16;
            tbWpMapNote.TabIndex = 27;
            tbWpMapNote.Text = "";
            Label label3_1 = Label3;
            point1 = new Point(56, 160);
            Point point19 = point1;
            label3_1.Location = point19;
            Label3.Name = "Label3";
            Label label3_2 = Label3;
            size1 = new Size(100, 16);
            Size size17 = size1;
            label3_2.Size = size17;
            Label3.TabIndex = 29;
            Label3.Text = "Description";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            Label label12_1 = Label12;
            point1 = new Point(56, 264);
            Point point20 = point1;
            label12_1.Location = point20;
            Label12.Name = "Label12";
            Label label12_2 = Label12;
            size1 = new Size(80, 16);
            Size size18 = size1;
            label12_2.Size = size18;
            Label12.TabIndex = 30;
            Label12.Text = "Map Note";
            Label12.TextAlign = ContentAlignment.MiddleLeft;
            CheckBox chkbMapNoteEnabled1 = chkbMapNoteEnabled;
            point1 = new Point(360, 224);
            Point point21 = point1;
            chkbMapNoteEnabled1.Location = point21;
            chkbMapNoteEnabled.Name = "chkbMapNoteEnabled";
            CheckBox chkbMapNoteEnabled2 = chkbMapNoteEnabled;
            size1 = new Size(128, 24);
            Size size19 = size1;
            chkbMapNoteEnabled2.Size = size19;
            chkbMapNoteEnabled.TabIndex = 32;
            chkbMapNoteEnabled.Text = "Map Note Enabled";
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            size1 = new Size(488, 461);
            ClientSize = size1;
            Controls.Add(chkbHasMapNote);
            Controls.Add(Label9);
            Controls.Add(tbWPLinkedTo);
            Controls.Add(tbWpDescription);
            Controls.Add(tbWpMapNote);
            Controls.Add(Label3);
            Controls.Add(Label12);
            Controls.Add(chkbMapNoteEnabled);
            Controls.Add(tbComment);
            Controls.Add(tbTag);
            Controls.Add(Label2);
            Controls.Add(tbTemplateResRef);
            Controls.Add(Label57);
            Controls.Add(tbName);
            Controls.Add(Label11);
            Controls.Add(btnDebug);
            Controls.Add(btnSetNameLang);
            Controls.Add(this.btnSave);
            Controls.Add(this.btnCancel);
            Controls.Add(Label1);
            size1 = new Size(496, 488);
            MinimumSize = size1;
            Name = nameof(frmUTW_Editor);
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Waypoint Editor";
            ResumeLayout(false);
        }

    public frmUTW_Editor(
        clsUTW UTWClass,
        int KotorVerIndex,
        bool IsDirectEdit = false,
        string EditingPath = "")
        : this()
    {
            if (IsDirectEdit)
            {
                m_bSaveGameMode = true;
                MEditingFilePath = EditingPath;
            }

            MDefaultTitleText = "Waypoint Editor - KotOR ";
            Text = MDefaultTitleText;
            if (KotorVerIndex == 0)
                Text += "I";
            else
                Text += "II";
            CurrentSettings = UserSettings.GetSettings();
            g_clsDialogTlk = new clsDialogTlk(CurrentSettings.KotorLocation(KotorVerIndex) + "\\dialog.tlk");
            UTW = UTWClass;
            KotorVersionIndex = KotorVerIndex;
            Setup();
        }

    private void btnCancel_Click(object sender, EventArgs e) => Close();

    public void Setup()
    {
            UTW.SetTextBoxToNodeValue(tbTemplateResRef, "TemplateResRef");
            UTW.SetTextBoxFromCExoLocStringNodeValue(tbName, "LocalizedName");
            UTW.SetTextBoxToNodeValue(tbTag, "Tag");
            UTW.SetTextBoxToNodeValue(tbWPLinkedTo, "LinkedTo");
            UTW.SetTextBoxFromCExoLocStringNodeValue(tbWpDescription, "Description");
            if (UTW.VerifyNodeExists("MapNote"))
                UTW.SetTextBoxFromCExoLocStringNodeValue(tbWpMapNote, "MapNote");
            chkbHasMapNote.Checked = BooleanType.FromObject(UTW.GetNodeValue("HasMapNote"));
            chkbMapNoteEnabled.Checked = BooleanType.FromObject(UTW.GetNodeValue("MapNoteEnabled"));
            UTW.SetTextBoxToNodeValue(tbComment, "Comment");
        }

    private void SetGffNodeValues()
    {
            UTW.SetNodeValueFromTextBox(tbTemplateResRef, "TemplateResRef");
            UTW.SetCExoLocStringNodeValueFromTextBox(tbName, "LocalizedName", NameLang);
            UTW.SetNodeValueFromTextBox(tbTag, "Tag");
            UTW.SetNodeValueFromTextBox(tbWPLinkedTo, "LinkedTo");
            UTW.SetCExoLocStringNodeValueFromTextBox(tbWpDescription, "Description", NameLang);
            if (UTW.VerifyNodeExists("MapNote"))
                UTW.SetCExoLocStringNodeValueFromTextBox(tbWpMapNote, "MapNote", NameLang);
            UTW.SetNodeValue("HasMapNote", chkbHasMapNote.Checked);
            UTW.SetNodeValue("MapNoteEnabled", chkbMapNoteEnabled.Checked);
            UTW.SetNodeValueFromTextBox(tbComment, "Comment");
        }

    private void btnSave_Click(object sender, EventArgs e)
    {
            SetGffNodeValues();
            if (!m_bSaveGameMode)
            {
                MEditingFilePath = StringType.FromObject(FrmMain.GetFilePath("save",
                    CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(MEditingFilePath) + ".utw",
                    "", ""));
                if (StringType.StrCmp(MEditingFilePath, "", false) == 0)
                    return;
            }

            UTW.WriteFile(MEditingFilePath, "UTW");
            if (!m_bSaveGameMode)
                return;
            Close();
        }

    private void btnSetNameLang_Click(object sender, EventArgs e)
    {
            frmCExoLocStringLanguagePicker stringLanguagePicker = new frmCExoLocStringLanguagePicker(NameLang);
            if (stringLanguagePicker.ShowDialog(this) != DialogResult.OK)
                return;
            NameLang = stringLanguagePicker.LanguageID;
        }

    private void btnDebug_Click(object sender, EventArgs e)
    {
            frmTextEditor frmTextEditor = new frmTextEditor();
            frmTextEditor.Filename = tbName.Text + ".utt";
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
            frmTextEditor.RTFMode = true;
            frmTextEditor.tbGeneric.Rtf = UTW.ToString();
            frmTextEditor.tbGeneric.SelectionLength = 0;
            frmTextEditor.Show();
        }

    private void frmUTW_Editor_Load(object sender, EventArgs e) => PositionWindow(GetType().Name);

    private void frmUTW_Editor_Closing(object sender, CancelEventArgs e) => SaveSettings(GetType().Name);

    public void SetFormName(string Name) => Text = "Waypoint Editor - " + Name;
}