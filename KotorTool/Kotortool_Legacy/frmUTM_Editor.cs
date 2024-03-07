// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmUTM_Editor
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmUTM_Editor : frmParent
{
  [AccessedThroughProperty("btnSetNameLang")]
  private Button _btnSetNameLang;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("TabPage2")]
  private TabPage _TabPage2;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("TabPage1")]
  private TabPage _TabPage1;
  [AccessedThroughProperty("btnEditOnOpenStore")]
  private Button _btnEditOnOpenStore;
  [AccessedThroughProperty("TabControl1")]
  private TabControl _TabControl1;
  [AccessedThroughProperty("btnInventory")]
  private Button _btnInventory;
  [AccessedThroughProperty("btnDebug")]
  private Button _btnDebug;
  [AccessedThroughProperty("tbComment")]
  private TextBox _tbComment;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("cmbxBuySellType")]
  private ComboBox _cmbxBuySellType;
  [AccessedThroughProperty("tbID")]
  private TextBox _tbID;
  [AccessedThroughProperty("tbResRef")]
  private TextBox _tbResRef;
  [AccessedThroughProperty("tbLocName")]
  private TextBox _tbLocName;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("nudMarkDown")]
  private NumericUpDown _nudMarkDown;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("nudMarkUp")]
  private NumericUpDown _nudMarkUp;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("tbTag")]
  private TextBox _tbTag;
  [AccessedThroughProperty("tbOnOpenStore")]
  private TextBox _tbOnOpenStore;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  private IContainer components;
  public clsUTM UTM;
  public clsDialogTlk g_clsDialogTlk;
  private int DescriptionLang;
  private int NameLang;
  private bool m_bSaveGameMode;

  public frmUTM_Editor()
  {
      Load += new EventHandler(frmUTM_Editor_Load);
      Closing += new CancelEventHandler(frmUTM_Editor_Closing);
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
    [MethodImpl(MethodImplOptions.Synchronized)] set
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
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnCancel != null)
          _btnCancel.Click -= new EventHandler(btnCancel_Click);
        _btnCancel = value;
        if (_btnCancel == null)
          return;
        _btnCancel.Click += new EventHandler(btnCancel_Click);
      }
  }

  internal virtual Button btnInventory
  {
    get => _btnInventory;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnInventory != null)
          _btnInventory.Click -= new EventHandler(btnInventory_Click);
        _btnInventory = value;
        if (_btnInventory == null)
          return;
        _btnInventory.Click += new EventHandler(btnInventory_Click);
      }
  }

  internal virtual Button btnSetNameLang
  {
    get => _btnSetNameLang;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSetNameLang != null)
          _btnSetNameLang.Click -= new EventHandler(btnSetNameLang_Click);
        _btnSetNameLang = value;
        if (_btnSetNameLang == null)
          return;
        _btnSetNameLang.Click += new EventHandler(btnSetNameLang_Click);
      }
  }

  internal virtual TextBox tbTag
  {
    get => _tbTag;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTag == null)
          ;
        _tbTag = value;
        if (_tbTag == null)
          ;
      }
  }

  internal virtual TextBox tbLocName
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbLocName == null)
          ;
        _tbLocName = value;
        if (_tbLocName == null)
          ;
      }
    get => _tbLocName;
  }

  internal virtual Label Label1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label1 == null)
          ;
        _Label1 = value;
        if (_Label1 == null)
          ;
      }
    get => _Label1;
  }

  internal virtual Label Label2
  {
    get => _Label2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label2 == null)
          ;
        _Label2 = value;
        if (_Label2 == null)
          ;
      }
  }

  internal virtual Label Label3
  {
    get => _Label3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label3 == null)
          ;
        _Label3 = value;
        if (_Label3 == null)
          ;
      }
  }

  internal virtual Label Label8
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label8 == null)
          ;
        _Label8 = value;
        if (_Label8 == null)
          ;
      }
    get => _Label8;
  }

  internal virtual Label Label12
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label12 == null)
          ;
        _Label12 = value;
        if (_Label12 == null)
          ;
      }
    get => _Label12;
  }

  internal virtual Label Label4
  {
    get => _Label4;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label4 == null)
          ;
        _Label4 = value;
        if (_Label4 == null)
          ;
      }
  }

  internal virtual Label Label5
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label5 == null)
          ;
        _Label5 = value;
        if (_Label5 == null)
          ;
      }
    get => _Label5;
  }

  internal virtual TabControl TabControl1
  {
    get => _TabControl1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
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
    get => _TabPage1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPage1 == null)
          ;
        _TabPage1 = value;
        if (_TabPage1 == null)
          ;
      }
  }

  internal virtual TabPage TabPage2
  {
    get => _TabPage2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPage2 == null)
          ;
        _TabPage2 = value;
        if (_TabPage2 == null)
          ;
      }
  }

  internal virtual TextBox tbComment
  {
    get => _tbComment;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbComment == null)
          ;
        _tbComment = value;
        if (_tbComment == null)
          ;
      }
  }

  internal virtual NumericUpDown nudMarkDown
  {
    get => _nudMarkDown;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudMarkDown == null)
          ;
        _nudMarkDown = value;
        if (_nudMarkDown == null)
          ;
      }
  }

  internal virtual NumericUpDown nudMarkUp
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudMarkUp == null)
          ;
        _nudMarkUp = value;
        if (_nudMarkUp == null)
          ;
      }
    get => _nudMarkUp;
  }

  internal virtual TextBox tbOnOpenStore
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnOpenStore == null)
          ;
        _tbOnOpenStore = value;
        if (_tbOnOpenStore == null)
          ;
      }
    get => _tbOnOpenStore;
  }

  internal virtual TextBox tbID
  {
    get => _tbID;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbID == null)
          ;
        _tbID = value;
        if (_tbID == null)
          ;
      }
  }

  internal virtual Label Label6
  {
    get => _Label6;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label6 == null)
          ;
        _Label6 = value;
        if (_Label6 == null)
          ;
      }
  }

  internal virtual TextBox tbResRef
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbResRef == null)
          ;
        _tbResRef = value;
        if (_tbResRef == null)
          ;
      }
    get => _tbResRef;
  }

  internal virtual Button btnDebug
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
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

  internal virtual ComboBox cmbxBuySellType
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxBuySellType == null)
          ;
        _cmbxBuySellType = value;
        if (_cmbxBuySellType == null)
          ;
      }
    get => _cmbxBuySellType;
  }

  internal virtual Button btnEditOnOpenStore
  {
    get => _btnEditOnOpenStore;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnOpenStore != null)
          _btnEditOnOpenStore.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnOpenStore = value;
        if (_btnEditOnOpenStore == null)
          return;
        _btnEditOnOpenStore.Click += new EventHandler(btnEditScript_Click);
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      this.btnSave = new Button();
      this.btnCancel = new Button();
      btnInventory = new Button();
      btnSetNameLang = new Button();
      tbTag = new TextBox();
      tbLocName = new TextBox();
      Label1 = new Label();
      Label2 = new Label();
      Label3 = new Label();
      nudMarkDown = new NumericUpDown();
      Label8 = new Label();
      nudMarkUp = new NumericUpDown();
      Label12 = new Label();
      Label4 = new Label();
      tbOnOpenStore = new TextBox();
      Label5 = new Label();
      tbID = new TextBox();
      TabControl1 = new TabControl();
      TabPage1 = new TabPage();
      cmbxBuySellType = new ComboBox();
      Label6 = new Label();
      tbResRef = new TextBox();
      TabPage2 = new TabPage();
      tbComment = new TextBox();
      btnDebug = new Button();
      btnEditOnOpenStore = new Button();
      nudMarkDown.BeginInit();
      nudMarkUp.BeginInit();
      TabControl1.SuspendLayout();
      TabPage1.SuspendLayout();
      TabPage2.SuspendLayout();
      SuspendLayout();
      this.btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnSave = this.btnSave;
      Point point1 = new Point(312, 360);
      Point point2 = point1;
      btnSave.Location = point2;
      this.btnSave.Name = "btnSave";
      this.btnSave.TabIndex = 10;
      this.btnSave.Text = "&Save";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(408, 360);
      Point point3 = point1;
      btnCancel.Location = point3;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 11;
      this.btnCancel.Text = "&Cancel";
      btnInventory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Button btnInventory1 = btnInventory;
      point1 = new Point(16, 360);
      Point point4 = point1;
      btnInventory1.Location = point4;
      btnInventory.Name = "btnInventory";
      Button btnInventory2 = btnInventory;
      Size size1 = new Size(72, 24);
      Size size2 = size1;
      btnInventory2.Size = size2;
      btnInventory.TabIndex = 12;
      btnInventory.Text = "&Inventory";
      Button btnSetNameLang1 = btnSetNameLang;
      point1 = new Point(336, 50);
      Point point5 = point1;
      btnSetNameLang1.Location = point5;
      btnSetNameLang.Name = "btnSetNameLang";
      Button btnSetNameLang2 = btnSetNameLang;
      size1 = new Size(88, 23);
      Size size3 = size1;
      btnSetNameLang2.Size = size3;
      btnSetNameLang.TabIndex = 2;
      btnSetNameLang.Text = "Set Language";
      TextBox tbTag1 = tbTag;
      point1 = new Point(120, 82);
      Point point6 = point1;
      tbTag1.Location = point6;
      tbTag.Name = "tbTag";
      TextBox tbTag2 = tbTag;
      size1 = new Size(200, 20);
      Size size4 = size1;
      tbTag2.Size = size4;
      tbTag.TabIndex = 3;
      tbTag.Text = "";
      TextBox tbLocName1 = tbLocName;
      point1 = new Point(120, 50);
      Point point7 = point1;
      tbLocName1.Location = point7;
      tbLocName.Name = "tbLocName";
      TextBox tbLocName2 = tbLocName;
      size1 = new Size(200, 20);
      Size size5 = size1;
      tbLocName2.Size = size5;
      tbLocName.TabIndex = 1;
      tbLocName.Text = "";
      Label label1_1 = Label1;
      point1 = new Point(9, 49);
      Point point8 = point1;
      label1_1.Location = point8;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(100, 16);
      Size size6 = size1;
      label1_2.Size = size6;
      Label1.TabIndex = 13;
      Label1.Text = "LocName";
      Label1.TextAlign = ContentAlignment.MiddleRight;
      Label label2_1 = Label2;
      point1 = new Point(7, 81);
      Point point9 = point1;
      label2_1.Location = point9;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(100, 16);
      Size size7 = size1;
      label2_2.Size = size7;
      Label2.TabIndex = 14;
      Label2.Text = "Tag";
      Label2.TextAlign = ContentAlignment.MiddleRight;
      Label label3_1 = Label3;
      point1 = new Point(29, 113);
      Point point10 = point1;
      label3_1.Location = point10;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(80, 16);
      Size size8 = size1;
      label3_2.Size = size8;
      Label3.TabIndex = 14;
      Label3.Text = "Buy/Sell Flag";
      Label3.TextAlign = ContentAlignment.MiddleRight;
      NumericUpDown nudMarkDown1 = nudMarkDown;
      point1 = new Point(120, 178);
      Point point11 = point1;
      nudMarkDown1.Location = point11;
      NumericUpDown nudMarkDown2 = nudMarkDown;
      Decimal num1 = new Decimal(new int[4]
      {
        99999,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      nudMarkDown2.Maximum = num2;
      nudMarkDown.Name = "nudMarkDown";
      nudMarkDown.RightToLeft = RightToLeft.No;
      NumericUpDown nudMarkDown3 = nudMarkDown;
      size1 = new Size(80, 20);
      Size size9 = size1;
      nudMarkDown3.Size = size9;
      nudMarkDown.TabIndex = 6;
      nudMarkDown.TextAlign = HorizontalAlignment.Right;
      Label label8_1 = Label8;
      point1 = new Point(21, 177);
      Point point12 = point1;
      label8_1.Location = point12;
      Label8.Name = "Label8";
      Label label8_2 = Label8;
      size1 = new Size(88, 16);
      Size size10 = size1;
      label8_2.Size = size10;
      Label8.TabIndex = 18;
      Label8.Text = "Mark Down";
      Label8.TextAlign = ContentAlignment.MiddleRight;
      NumericUpDown nudMarkUp1 = nudMarkUp;
      point1 = new Point(120, 146);
      Point point13 = point1;
      nudMarkUp1.Location = point13;
      NumericUpDown nudMarkUp2 = nudMarkUp;
      num1 = new Decimal(new int[4]{ 1000000, 0, 0, 0 });
      Decimal num3 = num1;
      nudMarkUp2.Maximum = num3;
      nudMarkUp.Name = "nudMarkUp";
      nudMarkUp.RightToLeft = RightToLeft.No;
      NumericUpDown nudMarkUp3 = nudMarkUp;
      size1 = new Size(80, 20);
      Size size11 = size1;
      nudMarkUp3.Size = size11;
      nudMarkUp.TabIndex = 5;
      nudMarkUp.TextAlign = HorizontalAlignment.Right;
      Label label12_1 = Label12;
      point1 = new Point(21, 145);
      Point point14 = point1;
      label12_1.Location = point14;
      Label12.Name = "Label12";
      Label label12_2 = Label12;
      size1 = new Size(88, 16);
      Size size12 = size1;
      label12_2.Size = size12;
      Label12.TabIndex = 19;
      Label12.Text = "Mark Up";
      Label12.TextAlign = ContentAlignment.MiddleRight;
      Label label4_1 = Label4;
      point1 = new Point(-7, 212);
      Point point15 = point1;
      label4_1.Location = point15;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(123, 16);
      Size size13 = size1;
      label4_2.Size = size13;
      Label4.TabIndex = 14;
      Label4.Text = "OnOpenStore Script";
      Label4.TextAlign = ContentAlignment.MiddleRight;
      TextBox tbOnOpenStore1 = tbOnOpenStore;
      point1 = new Point(120, 210);
      Point point16 = point1;
      tbOnOpenStore1.Location = point16;
      tbOnOpenStore.MaxLength = 16;
      tbOnOpenStore.Name = "tbOnOpenStore";
      TextBox tbOnOpenStore2 = tbOnOpenStore;
      size1 = new Size(144, 20);
      Size size14 = size1;
      tbOnOpenStore2.Size = size14;
      tbOnOpenStore.TabIndex = 7;
      tbOnOpenStore.Text = "";
      Label label5_1 = Label5;
      point1 = new Point(37, 241);
      Point point17 = point1;
      label5_1.Location = point17;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(72, 16);
      Size size15 = size1;
      label5_2.Size = size15;
      Label5.TabIndex = 14;
      Label5.Text = "ID";
      Label5.TextAlign = ContentAlignment.MiddleRight;
      TextBox tbId1 = tbID;
      point1 = new Point(120, 242);
      Point point18 = point1;
      tbId1.Location = point18;
      tbID.MaxLength = 16;
      tbID.Name = "tbID";
      TextBox tbId2 = tbID;
      size1 = new Size(48, 20);
      Size size16 = size1;
      tbId2.Size = size16;
      tbID.TabIndex = 8;
      tbID.Text = "";
      TabControl1.Controls.Add(TabPage1);
      TabControl1.Controls.Add(TabPage2);
      TabControl tabControl1_1 = TabControl1;
      point1 = new Point(16, 16);
      Point point19 = point1;
      tabControl1_1.Location = point19;
      TabControl1.Name = "TabControl1";
      TabControl1.SelectedIndex = 0;
      TabControl tabControl1_2 = TabControl1;
      size1 = new Size(464, 320);
      Size size17 = size1;
      tabControl1_2.Size = size17;
      TabControl1.TabIndex = 22;
      TabPage1.Controls.Add(btnEditOnOpenStore);
      TabPage1.Controls.Add(cmbxBuySellType);
      TabPage1.Controls.Add(Label5);
      TabPage1.Controls.Add(tbID);
      TabPage1.Controls.Add(Label3);
      TabPage1.Controls.Add(Label12);
      TabPage1.Controls.Add(nudMarkUp);
      TabPage1.Controls.Add(Label8);
      TabPage1.Controls.Add(nudMarkDown);
      TabPage1.Controls.Add(Label2);
      TabPage1.Controls.Add(Label1);
      TabPage1.Controls.Add(tbLocName);
      TabPage1.Controls.Add(tbTag);
      TabPage1.Controls.Add(btnSetNameLang);
      TabPage1.Controls.Add(Label4);
      TabPage1.Controls.Add(tbOnOpenStore);
      TabPage1.Controls.Add(Label6);
      TabPage1.Controls.Add(tbResRef);
      TabPage tabPage1_1 = TabPage1;
      point1 = new Point(4, 22);
      Point point20 = point1;
      ((Control) tabPage1_1).Location = point20;
      TabPage1.Name = "TabPage1";
      TabPage tabPage1_2 = TabPage1;
      size1 = new Size(456, 294);
      Size size18 = size1;
      tabPage1_2.Size = size18;
      TabPage1.TabIndex = 0;
      TabPage1.Text = "Basic";
      cmbxBuySellType.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxBuySellType.Items.AddRange(new object[3]
      {
        "Only buys",
        "Only sells",
        "Buys and Sells"
      });
      ComboBox cmbxBuySellType1 = cmbxBuySellType;
      point1 = new Point(120, 112);
      Point point21 = point1;
      cmbxBuySellType1.Location = point21;
      cmbxBuySellType.Name = "cmbxBuySellType";
      ComboBox cmbxBuySellType2 = cmbxBuySellType;
      size1 = new Size(104, 21);
      Size size19 = size1;
      cmbxBuySellType2.Size = size19;
      cmbxBuySellType.TabIndex = 4;
      Label label6_1 = Label6;
      point1 = new Point(-11, 18);
      Point point22 = point1;
      label6_1.Location = point22;
      Label6.Name = "Label6";
      Label label6_2 = Label6;
      size1 = new Size(123, 16);
      Size size20 = size1;
      label6_2.Size = size20;
      Label6.TabIndex = 14;
      Label6.Text = "ResRef";
      Label6.TextAlign = ContentAlignment.MiddleRight;
      tbResRef.CharacterCasing = CharacterCasing.Lower;
      TextBox tbResRef1 = tbResRef;
      point1 = new Point(120, 16);
      Point point23 = point1;
      tbResRef1.Location = point23;
      tbResRef.MaxLength = 16;
      tbResRef.Name = "tbResRef";
      TextBox tbResRef2 = tbResRef;
      size1 = new Size(144, 20);
      Size size21 = size1;
      tbResRef2.Size = size21;
      tbResRef.TabIndex = 0;
      tbResRef.Text = "";
      TabPage2.Controls.Add(tbComment);
      TabPage tabPage2_1 = TabPage2;
      point1 = new Point(4, 22);
      Point point24 = point1;
      ((Control) tabPage2_1).Location = point24;
      TabPage2.Name = "TabPage2";
      TabPage tabPage2_2 = TabPage2;
      size1 = new Size(456, 294);
      Size size22 = size1;
      tabPage2_2.Size = size22;
      TabPage2.TabIndex = 1;
      TabPage2.Text = "Comments";
      TextBox tbComment1 = tbComment;
      point1 = new Point(8, 8);
      Point point25 = point1;
      tbComment1.Location = point25;
      tbComment.Multiline = true;
      tbComment.Name = "tbComment";
      TextBox tbComment2 = tbComment;
      size1 = new Size(440, 304);
      Size size23 = size1;
      tbComment2.Size = size23;
      tbComment.TabIndex = 1;
      tbComment.Text = "";
      btnDebug.FlatStyle = FlatStyle.Flat;
      btnDebug.ForeColor = SystemColors.Control;
      Button btnDebug1 = btnDebug;
      point1 = new Point(0, 0);
      Point point26 = point1;
      btnDebug1.Location = point26;
      btnDebug.Name = "btnDebug";
      Button btnDebug2 = btnDebug;
      size1 = new Size(8, 9);
      Size size24 = size1;
      btnDebug2.Size = size24;
      btnDebug.TabIndex = 23;
      btnDebug.TabStop = false;
      Button btnEditOnOpenStore1 = btnEditOnOpenStore;
      point1 = new Point(280, 208);
      Point point27 = point1;
      btnEditOnOpenStore1.Location = point27;
      btnEditOnOpenStore.Name = "btnEditOnOpenStore";
      Button btnEditOnOpenStore2 = btnEditOnOpenStore;
      size1 = new Size(32, 23);
      Size size25 = size1;
      btnEditOnOpenStore2.Size = size25;
      btnEditOnOpenStore.TabIndex = 36;
      btnEditOnOpenStore.Text = "Edit";
      btnEditOnOpenStore.TextAlign = ContentAlignment.MiddleLeft;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = this.btnCancel;
      size1 = new Size(496, 397);
      ClientSize = size1;
      Controls.Add(btnDebug);
      Controls.Add(TabControl1);
      Controls.Add(this.btnSave);
      Controls.Add(this.btnCancel);
      Controls.Add(btnInventory);
      Name = nameof (frmUTM_Editor);
      Text = "Merchant Editor - KotOR";
      nudMarkDown.EndInit();
      nudMarkUp.EndInit();
      TabControl1.ResumeLayout(false);
      TabPage1.ResumeLayout(false);
      TabPage2.ResumeLayout(false);
      ResumeLayout(false);
    }

  public frmUTM_Editor(
    clsUTM UTMClass,
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
      MDefaultTitleText = "Merchant Editor - KotOR ";
      Text = MDefaultTitleText;
      if (KotorVerIndex == 0)
        Text += "I";
      else
        Text += "II";
      CurrentSettings = UserSettings.GetSettings();
      g_clsDialogTlk = new clsDialogTlk(CurrentSettings.KotorLocation(KotorVerIndex) + "\\dialog.tlk");
      UTM = UTMClass;
      KotorVersionIndex = KotorVerIndex;
      Setup();
    }

  private void btnCancel_Click(object sender, EventArgs e) => Close();

  public void Setup()
  {
      UTM.SetTextBoxFromCExoLocStringNodeValue(tbLocName, "LocName");
      UTM.SetTextBoxToNodeValue(tbTag, "Tag");
      UTM.SetTextBoxToNodeValue(tbResRef, "ResRef");
      UTM.SetTextBoxToNodeValue(tbOnOpenStore, "OnOpenStore");
      cmbxBuySellType.SelectedIndex = checked (IntegerType.FromObject(UTM.GetNodeValue("BuySellFlag")) - 1);
      UTM.SetTextBoxToNodeValue(tbID, "ID");
      UTM.SetNumericUpDownToNodeValue(nudMarkUp, "MarkUp");
      UTM.SetNumericUpDownToNodeValue(nudMarkDown, "MarkDown");
      UTM.SetTextBoxToNodeValue(tbComment, "Comment");
    }

  private void SetGFFNodeValues()
  {
      UTM.SetCExoLocStringNodeValueFromTextBox(tbLocName, "LocName", NameLang);
      UTM.SetNodeValueFromTextBox(tbTag, "Tag");
      UTM.SetNodeValueFromTextBox(tbResRef, "ResRef");
      UTM.SetNodeValueFromTextBox(tbOnOpenStore, "OnOpenStore");
      UTM.SetNodeValue("BuySellFlag", checked (cmbxBuySellType.SelectedIndex + 1));
      UTM.SetNodeValueFromTextBox(tbID, "ID");
      UTM.SetNodeValueFromTextBox(tbComment, "Comment");
    }

  private void btnInventory_Click(object sender, EventArgs e)
  {
      frmInventoryEditor frmInventoryEditor = new frmInventoryEditor(KotorVersionIndex);
      int num1 = checked (UTM.GetListItemCount("ItemList") - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        string ResRef = StringType.FromObject(UTM.GetNodeValue("ItemList(" + StringType.FromInteger(num2) + ").InventoryRes"));
        bool Dropable = !UTM.VerifyNodeExists("ItemList(" + StringType.FromInteger(num2) + ").Dropable") || ObjectType.ObjTst(UTM.GetNodeValue("ItemList(" + StringType.FromInteger(num2) + ").Dropable"), 1, false) == 0;
        frmInventoryEditor.AddPackItem(ResRef, Dropable);
        checked { ++num2; }
      }
      frmInventoryEditor.SetFormName(tbResRef.Text + ".utm");
      frmInventoryEditor.ConfigureForPlaceableEditorUse();
      if (frmInventoryEditor.ShowDialog() != DialogResult.OK)
        return;
      int FieldValue = 0;
      UTM.ClearListElements("ItemList");
      try
      {
        foreach (InventoryItem packItems in frmInventoryEditor.GetPackItemsList())
        {
          int quantity = packItems._Quantity;
          int num3 = 1;
          while (num3 <= quantity)
          {
            GffStruct @struct = new GffStruct();
            @struct.type = FieldValue;
            @struct.fieldCount = 4;
            @struct.fields = new GFF_Field[4];
            @struct.fields[0] = new GFF_Field(GFFField.GFF_CResRef, "InventoryRes", packItems._ResRef);
            @struct.fields[1] = new GFF_Field(GFFField.GFF_word, "Repos_PosX", FieldValue);
            @struct.fields[2] = new GFF_Field(GFFField.GFF_word, "Repos_PosY", 0);
            @struct.fields[3] = new GFF_Field(GFFField.GFF_byte, "Dropable", 1);
            if (!UTM.VerifyNodeExists("ItemList"))
              UTM.CreateList("", "ItemList");
            UTM.AddListElement("ItemList", @struct);
            checked { ++FieldValue; }
            checked { ++num3; }
          }
        }
      }
      finally
      {
        
      }
    }

  private void btnSave_Click(object sender, EventArgs e)
  {
      SetGFFNodeValues();
      if (!m_bSaveGameMode)
      {
        MEditingFilePath = StringType.FromObject(FrmMain.GetFilePath("save", CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(MEditingFilePath) + ".utm", "", ""));
        if (StringType.StrCmp(MEditingFilePath, "", false) == 0)
          return;
      }
      UTM.WriteFile(MEditingFilePath, "UTM");
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
      frmTextEditor.Filename = tbResRef.Text + ".utm";
      frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
      frmTextEditor.RTFMode = true;
      frmTextEditor.tbGeneric.Rtf = UTM.ToString();
      frmTextEditor.tbGeneric.SelectionLength = 0;
      frmTextEditor.Show();
    }

  private void frmUTM_Editor_Load(object sender, EventArgs e) => PositionWindow(GetType().Name);

  private void frmUTM_Editor_Closing(object sender, CancelEventArgs e) => SaveSettings(GetType().Name);

  public void SetFormName(string Name) => Text = "Merchant Editor - " + Name;

  private void btnEditScript_Click(object sender, EventArgs e) => Utils.EditScriptForTextBox((Button) sender, MEditingFilePath, KotorVersionIndex);
}