// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmItemPropertyEditor
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmItemPropertyEditor : frmParent
{
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbxPropertyName")]
  private ComboBox _cmbxPropertyName;
  [AccessedThroughProperty("cmbxSubtype")]
  private ComboBox _cmbxSubtype;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("btnDebug")]
  private Button _btnDebug;
  [AccessedThroughProperty("cmbxUpgrade")]
  private ComboBox _cmbxUpgrade;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("lblSubtypeDesc")]
  private Label _lblSubtypeDesc;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("lblValueDesc")]
  private Label _lblValueDesc;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("lblParam1Desc")]
  private Label _lblParam1Desc;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("lblParam2Desc")]
  private Label _lblParam2Desc;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("tbParam2tableresref")]
  private TextBox _tbParam2tableresref;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("label99")]
  private Label _label99;
  [AccessedThroughProperty("tbParam1tableresref")]
  private TextBox _tbParam1tableresref;
  [AccessedThroughProperty("cmbxParam1Value")]
  private ComboBox _cmbxParam1Value;
  [AccessedThroughProperty("nudPercentChance")]
  private NumericUpDown _nudPercentChance;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("lblParam1")]
  private Label _lblParam1;
  [AccessedThroughProperty("lblCostTable")]
  private Label _lblCostTable;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("cmbxCostValue")]
  private ComboBox _cmbxCostValue;
  [AccessedThroughProperty("lblParam2")]
  private Label _lblParam2;
  [AccessedThroughProperty("cmbxParam2Value")]
  private ComboBox _cmbxParam2Value;
  [AccessedThroughProperty("tbParam2resref")]
  private TextBox _tbParam2resref;
  [AccessedThroughProperty("tbParam1resref")]
  private TextBox _tbParam1resref;
  [AccessedThroughProperty("tbCostTableName")]
  private TextBox _tbCostTableName;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("tbStatus")]
  private TextBox _tbStatus;
  [AccessedThroughProperty("tbSubtyperesref")]
  private TextBox _tbSubtyperesref;
  [AccessedThroughProperty("tbCostTableID")]
  private TextBox _tbCostTableID;
  private IContainer components;
  private UserSettings usetting;
  public clsDialogTlk g_clsDialogTlk;
  public ChitinKey GChitinKey;
  private Cls2Da itempropdef;
  private Cls2Da iprp_costtable;
  private Cls2Da iprp_paramtable;
  private Cls2Da iprp_abilities;
  private Cls2Da appearance;
  private Cls2Da classes;
  private Cls2Da feat;
  private Cls2Da iprp_acmodtype;
  private Cls2Da iprp_aligngrp;
  private Cls2Da iprp_ammotype;
  private Cls2Da iprp_combatdam;
  private Cls2Da iprp_damagetype;
  private Cls2Da iprp_immunity;
  private Cls2Da iprp_monsterhit;
  private Cls2Da iprp_onhit;
  private Cls2Da iprp_protection;
  private Cls2Da iprp_saveelement;
  private Cls2Da iprp_savingthrow;
  private Cls2Da iprp_walk;
  private Cls2Da racialtypes;
  private Cls2Da skills;
  private Cls2Da spells;
  private Cls2Da traps;
  public bool g_bCmbxPropertyHasParam1ResRef;
  public int CostTableValue;
  public string CostTableID;
  public string CostTableName;
  public string Param1Desc;
  public string Param2Desc;
  public int CostValue;
  private bool debug;

  public frmItemPropertyEditor(int KotorVerIndex)
  {
      Load += new EventHandler(frm_Load);
      Closing += new CancelEventHandler(frm_Closing);
      usetting = new UserSettings();
      g_bCmbxPropertyHasParam1ResRef = false;
      debug = false;
      InitializeComponent();
      CurrentSettings = UserSettings.GetSettings();
      KotorVersionIndex = KotorVerIndex;
      g_clsDialogTlk = new clsDialogTlk(CurrentSettings.KotorLocation(KotorVerIndex) + "\\dialog.tlk");
      GChitinKey = new ChitinKey(CurrentSettings.KeyFileLocation(KotorVerIndex));
      Load2DAs();
      FillComboBoxFrom2DA(cmbxPropertyName, "name", itempropdef, g_clsDialogTlk);
      FillComboBoxFrom2DA(cmbxUpgrade, "label", ReadCls2DA("upgrade", GChitinKey));
      cmbxUpgrade.Items.Insert(0, "(None - default)");
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
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

  internal virtual Label Label5
  {
    get => _Label5;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label5 == null)
          ;
        _Label5 = value;
        if (_Label5 == null)
          ;
      }
  }

  internal virtual Button btnOK
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnOK == null)
          ;
        _btnOK = value;
        if (_btnOK == null)
          ;
      }
    get => _btnOK;
  }

  internal virtual Button btnCancel
  {
    get => _btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnCancel == null)
          ;
        _btnCancel = value;
        if (_btnCancel == null)
          ;
      }
  }

  internal virtual ComboBox cmbxPropertyName
  {
    get => _cmbxPropertyName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxPropertyName != null)
          _cmbxPropertyName.SelectedIndexChanged -= new EventHandler(cmbxPropertyName_SelectedIndexChanged);
        _cmbxPropertyName = value;
        if (_cmbxPropertyName == null)
          return;
        _cmbxPropertyName.SelectedIndexChanged += new EventHandler(cmbxPropertyName_SelectedIndexChanged);
      }
  }

  internal virtual ComboBox cmbxSubtype
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxSubtype != null)
          _cmbxSubtype.SelectedIndexChanged -= new EventHandler(cmbxSubtype_SelectedIndexChanged);
        _cmbxSubtype = value;
        if (_cmbxSubtype == null)
          return;
        _cmbxSubtype.SelectedIndexChanged += new EventHandler(cmbxSubtype_SelectedIndexChanged);
      }
    get => _cmbxSubtype;
  }

  internal virtual ComboBox cmbxParam1Value
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxParam1Value != null)
          _cmbxParam1Value.SelectedIndexChanged -= new EventHandler(cmbxParam1Value_SelectedIndexChanged);
        _cmbxParam1Value = value;
        if (_cmbxParam1Value == null)
          return;
        _cmbxParam1Value.SelectedIndexChanged += new EventHandler(cmbxParam1Value_SelectedIndexChanged);
      }
    get => _cmbxParam1Value;
  }

  internal virtual NumericUpDown nudPercentChance
  {
    get => _nudPercentChance;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudPercentChance == null)
          ;
        _nudPercentChance = value;
        if (_nudPercentChance == null)
          ;
      }
  }

  internal virtual Label lblParam1
  {
    get => _lblParam1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblParam1 == null)
          ;
        _lblParam1 = value;
        if (_lblParam1 == null)
          ;
      }
  }

  internal virtual Label lblCostTable
  {
    get => _lblCostTable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblCostTable == null)
          ;
        _lblCostTable = value;
        if (_lblCostTable == null)
          ;
      }
  }

  internal virtual ComboBox cmbxCostValue
  {
    get => _cmbxCostValue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxCostValue != null)
          _cmbxCostValue.SelectedIndexChanged -= new EventHandler(cmbxCostValue_SelectedIndexChanged);
        _cmbxCostValue = value;
        if (_cmbxCostValue == null)
          return;
        _cmbxCostValue.SelectedIndexChanged += new EventHandler(cmbxCostValue_SelectedIndexChanged);
      }
  }

  internal virtual Label lblParam2
  {
    get => _lblParam2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblParam2 == null)
          ;
        _lblParam2 = value;
        if (_lblParam2 == null)
          ;
      }
  }

  internal virtual ComboBox cmbxParam2Value
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxParam2Value != null)
          _cmbxParam2Value.SelectedIndexChanged -= new EventHandler(cmbxParam2Value_SelectedIndexChanged);
        _cmbxParam2Value = value;
        if (_cmbxParam2Value == null)
          return;
        _cmbxParam2Value.SelectedIndexChanged += new EventHandler(cmbxParam2Value_SelectedIndexChanged);
      }
    get => _cmbxParam2Value;
  }

  internal virtual TextBox tbStatus
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbStatus == null)
          ;
        _tbStatus = value;
        if (_tbStatus == null)
          ;
      }
    get => _tbStatus;
  }

  internal virtual TextBox tbSubtyperesref
  {
    get => _tbSubtyperesref;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbSubtyperesref == null)
          ;
        _tbSubtyperesref = value;
        if (_tbSubtyperesref == null)
          ;
      }
  }

  internal virtual TextBox tbCostTableID
  {
    get => _tbCostTableID;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCostTableID == null)
          ;
        _tbCostTableID = value;
        if (_tbCostTableID == null)
          ;
      }
  }

  internal virtual TextBox tbCostTableName
  {
    get => _tbCostTableName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCostTableName == null)
          ;
        _tbCostTableName = value;
        if (_tbCostTableName == null)
          ;
      }
  }

  internal virtual TextBox tbParam1resref
  {
    get => _tbParam1resref;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbParam1resref == null)
          ;
        _tbParam1resref = value;
        if (_tbParam1resref == null)
          ;
      }
  }

  internal virtual TextBox tbParam2resref
  {
    get => _tbParam2resref;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbParam2resref == null)
          ;
        _tbParam2resref = value;
        if (_tbParam2resref == null)
          ;
      }
  }

  internal virtual Label Label3
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label3 == null)
          ;
        _Label3 = value;
        if (_Label3 == null)
          ;
      }
    get => _Label3;
  }

  internal virtual Label Label4
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label4 == null)
          ;
        _Label4 = value;
        if (_Label4 == null)
          ;
      }
    get => _Label4;
  }

  internal virtual Label Label6
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label6 == null)
          ;
        _Label6 = value;
        if (_Label6 == null)
          ;
      }
    get => _Label6;
  }

  internal virtual Label Label7
  {
    get => _Label7;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label7 == null)
          ;
        _Label7 = value;
        if (_Label7 == null)
          ;
      }
  }

  internal virtual Label Label8
  {
    get => _Label8;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label8 == null)
          ;
        _Label8 = value;
        if (_Label8 == null)
          ;
      }
  }

  internal virtual TextBox tbParam1tableresref
  {
    get => _tbParam1tableresref;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbParam1tableresref == null)
          ;
        _tbParam1tableresref = value;
        if (_tbParam1tableresref == null)
          ;
      }
  }

  internal virtual Label label99
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_label99 == null)
          ;
        _label99 = value;
        if (_label99 == null)
          ;
      }
    get => _label99;
  }

  internal virtual TextBox tbParam2tableresref
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbParam2tableresref == null)
          ;
        _tbParam2tableresref = value;
        if (_tbParam2tableresref == null)
          ;
      }
    get => _tbParam2tableresref;
  }

  internal virtual Label Label10
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label10 == null)
          ;
        _Label10 = value;
        if (_Label10 == null)
          ;
      }
    get => _Label10;
  }

  internal virtual Label lblParam2Desc
  {
    get => _lblParam2Desc;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblParam2Desc == null)
          ;
        _lblParam2Desc = value;
        if (_lblParam2Desc == null)
          ;
      }
  }

  internal virtual Label lblParam1Desc
  {
    get => _lblParam1Desc;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblParam1Desc == null)
          ;
        _lblParam1Desc = value;
        if (_lblParam1Desc == null)
          ;
      }
  }

  internal virtual Label lblValueDesc
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblValueDesc == null)
          ;
        _lblValueDesc = value;
        if (_lblValueDesc == null)
          ;
      }
    get => _lblValueDesc;
  }

  internal virtual Label lblSubtypeDesc
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblSubtypeDesc == null)
          ;
        _lblSubtypeDesc = value;
        if (_lblSubtypeDesc == null)
          ;
      }
    get => _lblSubtypeDesc;
  }

  internal virtual Button btnDebug
  {
    get => _btnDebug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnDebug != null)
          _btnDebug.Click -= new EventHandler(btnDebug_Click);
        _btnDebug = value;
        if (_btnDebug == null)
          return;
        _btnDebug.Click += new EventHandler(btnDebug_Click);
      }
  }

  internal virtual ComboBox cmbxUpgrade
  {
    get => _cmbxUpgrade;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxUpgrade == null)
          ;
        _cmbxUpgrade = value;
        if (_cmbxUpgrade == null)
          ;
      }
  }

  internal virtual Label Label9
  {
    get => _Label9;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label9 == null)
          ;
        _Label9 = value;
        if (_Label9 == null)
          ;
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmItemPropertyEditor));
      cmbxPropertyName = new ComboBox();
      cmbxSubtype = new ComboBox();
      cmbxParam1Value = new ComboBox();
      Label1 = new Label();
      Label2 = new Label();
      lblParam1 = new Label();
      nudPercentChance = new NumericUpDown();
      Label5 = new Label();
      btnOK = new Button();
      this.btnCancel = new Button();
      lblCostTable = new Label();
      cmbxCostValue = new ComboBox();
      lblParam2 = new Label();
      cmbxParam2Value = new ComboBox();
      tbStatus = new TextBox();
      tbSubtyperesref = new TextBox();
      tbCostTableID = new TextBox();
      tbCostTableName = new TextBox();
      tbParam1resref = new TextBox();
      tbParam2resref = new TextBox();
      Label3 = new Label();
      Label4 = new Label();
      Label6 = new Label();
      Label7 = new Label();
      Label8 = new Label();
      tbParam1tableresref = new TextBox();
      label99 = new Label();
      tbParam2tableresref = new TextBox();
      Label10 = new Label();
      lblParam2Desc = new Label();
      lblParam1Desc = new Label();
      lblValueDesc = new Label();
      lblSubtypeDesc = new Label();
      btnDebug = new Button();
      cmbxUpgrade = new ComboBox();
      Label9 = new Label();
      nudPercentChance.BeginInit();
      SuspendLayout();
      cmbxPropertyName.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxPropertyName1 = cmbxPropertyName;
      Point point1 = new Point(24, 40);
      Point point2 = point1;
      cmbxPropertyName1.Location = point2;
      cmbxPropertyName.MaxDropDownItems = 15;
      cmbxPropertyName.Name = "cmbxPropertyName";
      ComboBox cmbxPropertyName2 = cmbxPropertyName;
      Size size1 = new Size(232, 21);
      Size size2 = size1;
      cmbxPropertyName2.Size = size2;
      cmbxPropertyName.TabIndex = 0;
      cmbxSubtype.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxSubtype.Enabled = false;
      ComboBox cmbxSubtype1 = cmbxSubtype;
      point1 = new Point(24, 88);
      Point point3 = point1;
      cmbxSubtype1.Location = point3;
      cmbxSubtype.MaxDropDownItems = 12;
      cmbxSubtype.Name = "cmbxSubtype";
      ComboBox cmbxSubtype2 = cmbxSubtype;
      size1 = new Size(232, 21);
      Size size3 = size1;
      cmbxSubtype2.Size = size3;
      cmbxSubtype.TabIndex = 1;
      cmbxParam1Value.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxParam1Value.Enabled = false;
      ComboBox cmbxParam1Value1 = cmbxParam1Value;
      point1 = new Point(280, 40);
      Point point4 = point1;
      cmbxParam1Value1.Location = point4;
      cmbxParam1Value.MaxDropDownItems = 15;
      cmbxParam1Value.Name = "cmbxParam1Value";
      ComboBox cmbxParam1Value2 = cmbxParam1Value;
      size1 = new Size(216, 21);
      Size size4 = size1;
      cmbxParam1Value2.Size = size4;
      cmbxParam1Value.TabIndex = 3;
      Label label1_1 = Label1;
      point1 = new Point(24, 24);
      Point point5 = point1;
      label1_1.Location = point5;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(120, 16);
      Size size5 = size1;
      label1_2.Size = size5;
      Label1.TabIndex = 1;
      Label1.Text = "Property Name";
      Label label2_1 = Label2;
      point1 = new Point(24, 72);
      Point point6 = point1;
      label2_1.Location = point6;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(48, 16);
      Size size6 = size1;
      label2_2.Size = size6;
      Label2.TabIndex = 1;
      Label2.Text = "Subtype";
      Label lblParam1_1 = lblParam1;
      point1 = new Point(280, 24);
      Point point7 = point1;
      lblParam1_1.Location = point7;
      lblParam1.Name = "lblParam1";
      Label lblParam1_2 = lblParam1;
      size1 = new Size(48, 16);
      Size size7 = size1;
      lblParam1_2.Size = size7;
      lblParam1.TabIndex = 1;
      lblParam1.Text = "Param 1";
      NumericUpDown nudPercentChance1 = nudPercentChance;
      point1 = new Point(64, 184);
      Point point8 = point1;
      nudPercentChance1.Location = point8;
      nudPercentChance.Name = "nudPercentChance";
      NumericUpDown nudPercentChance2 = nudPercentChance;
      size1 = new Size(40, 20);
      Size size8 = size1;
      nudPercentChance2.Size = size8;
      nudPercentChance.TabIndex = 5;
      nudPercentChance.Value = new Decimal(new int[4]
      {
        100,
        0,
        0,
        0
      });
      Label label5_1 = Label5;
      point1 = new Point(24, 168);
      Point point9 = point1;
      label5_1.Location = point9;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(136, 16);
      Size size9 = size1;
      label5_2.Size = size9;
      Label5.TabIndex = 1;
      Label5.Text = "% Chance of Appearance";
      btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnOK.DialogResult = DialogResult.OK;
      Button btnOk = btnOK;
      point1 = new Point(312, 232);
      Point point10 = point1;
      btnOk.Location = point10;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 6;
      btnOK.Text = "OK";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(408, 232);
      Point point11 = point1;
      btnCancel.Location = point11;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      Label lblCostTable1 = lblCostTable;
      point1 = new Point(24, 120);
      Point point12 = point1;
      lblCostTable1.Location = point12;
      lblCostTable.Name = "lblCostTable";
      Label lblCostTable2 = lblCostTable;
      size1 = new Size(40, 16);
      Size size10 = size1;
      lblCostTable2.Size = size10;
      lblCostTable.TabIndex = 1;
      lblCostTable.Text = "Value";
      cmbxCostValue.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxCostValue.Enabled = false;
      ComboBox cmbxCostValue1 = cmbxCostValue;
      point1 = new Point(24, 136);
      Point point13 = point1;
      cmbxCostValue1.Location = point13;
      cmbxCostValue.Name = "cmbxCostValue";
      ComboBox cmbxCostValue2 = cmbxCostValue;
      size1 = new Size(232, 21);
      Size size11 = size1;
      cmbxCostValue2.Size = size11;
      cmbxCostValue.TabIndex = 2;
      Label lblParam2_1 = lblParam2;
      point1 = new Point(280, 72);
      Point point14 = point1;
      lblParam2_1.Location = point14;
      lblParam2.Name = "lblParam2";
      Label lblParam2_2 = lblParam2;
      size1 = new Size(48, 16);
      Size size12 = size1;
      lblParam2_2.Size = size12;
      lblParam2.TabIndex = 1;
      lblParam2.Text = "Param 2";
      cmbxParam2Value.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxParam2Value.Enabled = false;
      ComboBox cmbxParam2Value1 = cmbxParam2Value;
      point1 = new Point(280, 88);
      Point point15 = point1;
      cmbxParam2Value1.Location = point15;
      cmbxParam2Value.MaxDropDownItems = 12;
      cmbxParam2Value.Name = "cmbxParam2Value";
      ComboBox cmbxParam2Value2 = cmbxParam2Value;
      size1 = new Size(216, 21);
      Size size13 = size1;
      cmbxParam2Value2.Size = size13;
      cmbxParam2Value.TabIndex = 4;
      TextBox tbStatus1 = tbStatus;
      point1 = new Point(16, 312);
      Point point16 = point1;
      tbStatus1.Location = point16;
      tbStatus.Name = "tbStatus";
      TextBox tbStatus2 = tbStatus;
      size1 = new Size(488, 20);
      Size size14 = size1;
      tbStatus2.Size = size14;
      tbStatus.TabIndex = 4;
      tbStatus.TabStop = false;
      tbStatus.Text = "";
      TextBox tbSubtyperesref1 = tbSubtyperesref;
      point1 = new Point(552, 24);
      Point point17 = point1;
      tbSubtyperesref1.Location = point17;
      tbSubtyperesref.Name = "tbSubtyperesref";
      TextBox tbSubtyperesref2 = tbSubtyperesref;
      size1 = new Size(144, 20);
      Size size15 = size1;
      tbSubtyperesref2.Size = size15;
      tbSubtyperesref.TabIndex = 5;
      tbSubtyperesref.TabStop = false;
      tbSubtyperesref.Text = "";
      TextBox tbCostTableId1 = tbCostTableID;
      point1 = new Point(552, 72);
      Point point18 = point1;
      tbCostTableId1.Location = point18;
      tbCostTableID.Name = "tbCostTableID";
      TextBox tbCostTableId2 = tbCostTableID;
      size1 = new Size(144, 20);
      Size size16 = size1;
      tbCostTableId2.Size = size16;
      tbCostTableID.TabIndex = 5;
      tbCostTableID.TabStop = false;
      tbCostTableID.Text = "";
      TextBox tbCostTableName1 = tbCostTableName;
      point1 = new Point(552, 120);
      Point point19 = point1;
      tbCostTableName1.Location = point19;
      tbCostTableName.Name = "tbCostTableName";
      TextBox tbCostTableName2 = tbCostTableName;
      size1 = new Size(144, 20);
      Size size17 = size1;
      tbCostTableName2.Size = size17;
      tbCostTableName.TabIndex = 5;
      tbCostTableName.TabStop = false;
      tbCostTableName.Text = "";
      TextBox tbParam1resref1 = tbParam1resref;
      point1 = new Point(552, 168);
      Point point20 = point1;
      tbParam1resref1.Location = point20;
      tbParam1resref.Name = "tbParam1resref";
      TextBox tbParam1resref2 = tbParam1resref;
      size1 = new Size(144, 20);
      Size size18 = size1;
      tbParam1resref2.Size = size18;
      tbParam1resref.TabIndex = 5;
      tbParam1resref.TabStop = false;
      tbParam1resref.Text = "";
      TextBox tbParam2resref1 = tbParam2resref;
      point1 = new Point(552, 264);
      Point point21 = point1;
      tbParam2resref1.Location = point21;
      tbParam2resref.Name = "tbParam2resref";
      TextBox tbParam2resref2 = tbParam2resref;
      size1 = new Size(144, 20);
      Size size19 = size1;
      tbParam2resref2.Size = size19;
      tbParam2resref.TabIndex = 5;
      tbParam2resref.TabStop = false;
      tbParam2resref.Text = "";
      Label label3_1 = Label3;
      point1 = new Point(552, 8);
      Point point22 = point1;
      label3_1.Location = point22;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(120, 16);
      Size size20 = size1;
      label3_2.Size = size20;
      Label3.TabIndex = 1;
      Label3.Text = "Subtyperesref";
      Label label4_1 = Label4;
      point1 = new Point(552, 56);
      Point point23 = point1;
      label4_1.Location = point23;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(120, 16);
      Size size21 = size1;
      label4_2.Size = size21;
      Label4.TabIndex = 1;
      Label4.Text = "CostTableID";
      Label label6_1 = Label6;
      point1 = new Point(552, 104);
      Point point24 = point1;
      label6_1.Location = point24;
      Label6.Name = "Label6";
      Label label6_2 = Label6;
      size1 = new Size(120, 16);
      Size size22 = size1;
      label6_2.Size = size22;
      Label6.TabIndex = 1;
      Label6.Text = "CostTableName";
      Label label7_1 = Label7;
      point1 = new Point(552, 152);
      Point point25 = point1;
      label7_1.Location = point25;
      Label7.Name = "Label7";
      Label label7_2 = Label7;
      size1 = new Size(120, 16);
      Size size23 = size1;
      label7_2.Size = size23;
      Label7.TabIndex = 1;
      Label7.Text = "Param1resref";
      Label label8_1 = Label8;
      point1 = new Point(552, 248);
      Point point26 = point1;
      label8_1.Location = point26;
      Label8.Name = "Label8";
      Label label8_2 = Label8;
      size1 = new Size(120, 16);
      Size size24 = size1;
      label8_2.Size = size24;
      Label8.TabIndex = 1;
      Label8.Text = "Param2resref";
      TextBox param1tableresref1 = tbParam1tableresref;
      point1 = new Point(552, 216);
      Point point27 = point1;
      param1tableresref1.Location = point27;
      tbParam1tableresref.Name = "tbParam1tableresref";
      TextBox param1tableresref2 = tbParam1tableresref;
      size1 = new Size(144, 20);
      Size size25 = size1;
      param1tableresref2.Size = size25;
      tbParam1tableresref.TabIndex = 5;
      tbParam1tableresref.TabStop = false;
      tbParam1tableresref.Text = "";
      Label label99_1 = label99;
      point1 = new Point(552, 200);
      Point point28 = point1;
      label99_1.Location = point28;
      label99.Name = "label99";
      Label label99_2 = label99;
      size1 = new Size(120, 16);
      Size size26 = size1;
      label99_2.Size = size26;
      label99.TabIndex = 1;
      label99.Text = "Param1tableresref";
      TextBox param2tableresref1 = tbParam2tableresref;
      point1 = new Point(552, 312);
      Point point29 = point1;
      param2tableresref1.Location = point29;
      tbParam2tableresref.Name = "tbParam2tableresref";
      TextBox param2tableresref2 = tbParam2tableresref;
      size1 = new Size(144, 20);
      Size size27 = size1;
      param2tableresref2.Size = size27;
      tbParam2tableresref.TabIndex = 5;
      tbParam2tableresref.TabStop = false;
      tbParam2tableresref.Text = "";
      Label label10_1 = Label10;
      point1 = new Point(552, 296);
      Point point30 = point1;
      label10_1.Location = point30;
      Label10.Name = "Label10";
      Label label10_2 = Label10;
      size1 = new Size(120, 16);
      Size size28 = size1;
      label10_2.Size = size28;
      Label10.TabIndex = 1;
      Label10.Text = "Param2tableresref";
      Label lblParam2Desc1 = lblParam2Desc;
      point1 = new Point(344, 72);
      Point point31 = point1;
      lblParam2Desc1.Location = point31;
      lblParam2Desc.Name = "lblParam2Desc";
      Label lblParam2Desc2 = lblParam2Desc;
      size1 = new Size(104, 16);
      Size size29 = size1;
      lblParam2Desc2.Size = size29;
      lblParam2Desc.TabIndex = 1;
      Label lblParam1Desc1 = lblParam1Desc;
      point1 = new Point(344, 24);
      Point point32 = point1;
      lblParam1Desc1.Location = point32;
      lblParam1Desc.Name = "lblParam1Desc";
      Label lblParam1Desc2 = lblParam1Desc;
      size1 = new Size(104, 16);
      Size size30 = size1;
      lblParam1Desc2.Size = size30;
      lblParam1Desc.TabIndex = 1;
      Label lblValueDesc1 = lblValueDesc;
      point1 = new Point(88, 120);
      Point point33 = point1;
      lblValueDesc1.Location = point33;
      lblValueDesc.Name = "lblValueDesc";
      Label lblValueDesc2 = lblValueDesc;
      size1 = new Size(136, 16);
      Size size31 = size1;
      lblValueDesc2.Size = size31;
      lblValueDesc.TabIndex = 1;
      Label lblSubtypeDesc1 = lblSubtypeDesc;
      point1 = new Point(88, 72);
      Point point34 = point1;
      lblSubtypeDesc1.Location = point34;
      lblSubtypeDesc.Name = "lblSubtypeDesc";
      Label lblSubtypeDesc2 = lblSubtypeDesc;
      size1 = new Size(136, 16);
      Size size32 = size1;
      lblSubtypeDesc2.Size = size32;
      lblSubtypeDesc.TabIndex = 1;
      btnDebug.FlatStyle = FlatStyle.Flat;
      btnDebug.ForeColor = SystemColors.Control;
      Button btnDebug1 = btnDebug;
      point1 = new Point(0, 0);
      Point point35 = point1;
      btnDebug1.Location = point35;
      btnDebug.Name = "btnDebug";
      Button btnDebug2 = btnDebug;
      size1 = new Size(8, 8);
      Size size33 = size1;
      btnDebug2.Size = size33;
      btnDebug.TabIndex = 8;
      btnDebug.TabStop = false;
      cmbxUpgrade.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxUpgrade.Enabled = false;
      ComboBox cmbxUpgrade1 = cmbxUpgrade;
      point1 = new Point(280, 136);
      Point point36 = point1;
      cmbxUpgrade1.Location = point36;
      cmbxUpgrade.Name = "cmbxUpgrade";
      ComboBox cmbxUpgrade2 = cmbxUpgrade;
      size1 = new Size(216, 21);
      Size size34 = size1;
      cmbxUpgrade2.Size = size34;
      cmbxUpgrade.TabIndex = 4;
      Label label9_1 = Label9;
      point1 = new Point(280, 120);
      Point point37 = point1;
      label9_1.Location = point37;
      Label9.Name = "Label9";
      Label label9_2 = Label9;
      size1 = new Size(160, 16);
      Size size35 = size1;
      label9_2.Size = size35;
      Label9.TabIndex = 1;
      Label9.Text = "Upgrade required to activate";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(512, 269);
      ClientSize = size1;
      Controls.Add(btnDebug);
      Controls.Add(tbSubtyperesref);
      Controls.Add(tbStatus);
      Controls.Add(btnOK);
      Controls.Add(nudPercentChance);
      Controls.Add(Label1);
      Controls.Add(cmbxPropertyName);
      Controls.Add(cmbxSubtype);
      Controls.Add(cmbxParam1Value);
      Controls.Add(Label2);
      Controls.Add(lblParam1);
      Controls.Add(Label5);
      Controls.Add(this.btnCancel);
      Controls.Add(lblCostTable);
      Controls.Add(cmbxCostValue);
      Controls.Add(lblParam2);
      Controls.Add(cmbxParam2Value);
      Controls.Add(tbCostTableID);
      Controls.Add(tbCostTableName);
      Controls.Add(tbParam1resref);
      Controls.Add(tbParam2resref);
      Controls.Add(Label3);
      Controls.Add(Label4);
      Controls.Add(Label6);
      Controls.Add(Label7);
      Controls.Add(Label8);
      Controls.Add(tbParam1tableresref);
      Controls.Add(label99);
      Controls.Add(tbParam2tableresref);
      Controls.Add(Label10);
      Controls.Add(lblParam2Desc);
      Controls.Add(lblParam1Desc);
      Controls.Add(lblValueDesc);
      Controls.Add(lblSubtypeDesc);
      Controls.Add(cmbxUpgrade);
      Controls.Add(Label9);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      MaximizeBox = false;
      MinimizeBox = false;
      size1 = new Size(520, 296);
      MinimumSize = size1;
      Name = nameof (frmItemPropertyEditor);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Item Property Editor";
      nudPercentChance.EndInit();
      ResumeLayout(false);
    }

  private void frm_Load(object sender, EventArgs e)
  {
      PositionWindow(Name);
      btnOK.Enabled = ValidateForm();
    }

  private void frm_Closing(object sender, CancelEventArgs e) => SaveSettings(Name);

  public frmItemPropertyEditor(
    int PropertyID,
    int SubtypeID,
    int CostTableID,
    int CostTableValue,
    int Param1ID,
    int Param1Value,
    int Param2ID,
    int Param2Value,
    int KotorVerIndex)
    : this(KotorVerIndex)
  {
      cmbxPropertyName.SelectedIndex = PropertyID;
      if (cmbxSubtype.Items.Count > 0)
        cmbxSubtype.SelectedIndex = SubtypeID;
      cmbxCostValue.SelectedIndex = CostTableValue;
    }

  private void FillComboBoxFrom2DA(
    ComboBox cmbx,
    string colName,
    Cls2Da TwoDA,
    clsDialogTlk DialogTlk = null)
  {
      cmbx.Items.Clear();
      if (DialogTlk != null)
      {
        int rowsUpperBound = TwoDA.RowsUpperBound;
        int rowNumber = 0;
        while (rowNumber <= rowsUpperBound)
        {
          object indiceData = TwoDA.GetIndiceData(rowNumber, colName);
          if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)))
            cmbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData)));
          else
            cmbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData));
          checked { ++rowNumber; }
        }
      }
      else
      {
        int rowsUpperBound = TwoDA.RowsUpperBound;
        int rowNumber = 0;
        while (rowNumber <= rowsUpperBound)
        {
          cmbx.Items.Add(TwoDA.GetIndiceData(rowNumber, colName));
          checked { ++rowNumber; }
        }
      }
    }

  public Cls2Da ReadCls2DA(string TwoDAName, ChitinKey ChitinKey)
  {
      bool flag = true;
      byte[] numArray = new byte[] { };
      if (CurrentSettings.bUseOverrideFiles)
      {
        string path = CurrentSettings.KotorLocation(KotorVersionIndex) + "\\override\\" + TwoDAName + ".2da";
        try
        {
          if (File.Exists(path))
          {
            FileStream fileStream = new FileStream(path, FileMode.Open);
            numArray = new byte[checked ((int) fileStream.Length + 1)];
            fileStream.Read(numArray, 0, checked ((int) fileStream.Length));
            fileStream.Close();
            flag = false;
            Console.WriteLine("Read " + TwoDAName + ".2da from override");
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Console.WriteLine("Could not load " + path + " in " + GetType().Name);
          ProjectData.ClearProjectError();
        }
      }
      if (flag)
      {
        int resIdForResRef = ChitinKey.FindResIdForResRef(TwoDAName, 2017);
        numArray = BIFFArchive.GetBIFFResource(CurrentSettings.KotorLocation(KotorVersionIndex) + "\\" + ChitinKey.BiffList[resIdForResRef >> 20].Filename, resIdForResRef).Data;
        Console.WriteLine("Read " + TwoDAName + ".2da from 2da.bif");
      }
      return new Cls2Da(numArray);
    }

  public void Load2DAs()
  {
      itempropdef = ReadCls2DA("itempropdef", GChitinKey);
      iprp_costtable = ReadCls2DA("iprp_costtable", GChitinKey);
      iprp_paramtable = ReadCls2DA("iprp_paramtable", GChitinKey);
    }

  private void cmbxPropertyName_SelectedIndexChanged(object sender, EventArgs e)
  {
      string indiceData1 = itempropdef.GetIndiceData(cmbxPropertyName.SelectedIndex, "subtyperesref");
      string indiceData2 = itempropdef.GetIndiceData(cmbxPropertyName.SelectedIndex, "costtableresref");
      string indiceData3 = itempropdef.GetIndiceData(cmbxPropertyName.SelectedIndex, "param1resref");
      CostTableID = indiceData2;
      CostTableName = !(StringType.StrCmp(indiceData2, "****", false) == 0 | StringType.StrCmp(indiceData2, "0", false) == 0) ? iprp_costtable.GetIndiceData(IntegerType.FromString(indiceData2), "label") : "None";
      cmbxParam1Value.Enabled = false;
      cmbxParam1Value.Items.Clear();
      cmbxParam2Value.Enabled = false;
      cmbxParam2Value.Items.Clear();
      tbCostTableID.Text = indiceData2;
      tbCostTableName.Text = CostTableName;
      tbSubtyperesref.Text = indiceData1;
      lblValueDesc.Text = "(" + Strings.Replace(CostTableName, "_", " ") + ")";
      if (StringType.StrCmp(indiceData1, "****", false) == 0)
      {
        cmbxSubtype.Enabled = false;
        cmbxSubtype.Items.Clear();
        lblSubtypeDesc.Text = "(None)";
        if (StringType.StrCmp(indiceData2, "0", false) != 0)
        {
          FillComboBoxFrom2DA(cmbxCostValue, "name", ReadCls2DA(iprp_costtable.GetIndiceData(IntegerType.FromString(indiceData2), "name"), GChitinKey), g_clsDialogTlk);
          cmbxCostValue.Enabled = true;
          tbStatus.Text = "cmbxCostValue specifies CostValue";
        }
        else
        {
          cmbxCostValue.Enabled = false;
          cmbxCostValue.Items.Clear();
          tbStatus.Text = "No cost value needed";
          CostValue = 0;
        }
      }
      else
      {
        string str = Strings.Mid(indiceData1, checked (Strings.InStr(indiceData1, "_") + 1));
        lblSubtypeDesc.Text = "(" + Strings.UCase(Strings.Mid(str, 1, 1)) + Strings.LCase(Strings.Mid(str, 2)) + ")";
        Cls2Da TwoDA = ReadCls2DA(indiceData1, GChitinKey);
        if (StringType.StrCmp(indiceData1, "Appearance", false) == 0)
          FillComboBoxFrom2DA(cmbxSubtype, "label", TwoDA);
        else
          FillComboBoxFrom2DA(cmbxSubtype, "name", TwoDA, g_clsDialogTlk);
        cmbxSubtype.Enabled = true;
        if (StringType.StrCmp(indiceData2, "****", false) == 0 || StringType.StrCmp(indiceData2, "0", false) == 0)
        {
          cmbxCostValue.Enabled = false;
          cmbxCostValue.Items.Clear();
          tbStatus.Text = "cmbxSubtype specifies CostValue";
        }
        else
        {
          FillComboBoxFrom2DA(cmbxCostValue, "name", ReadCls2DA(iprp_costtable.GetIndiceData(IntegerType.FromString(indiceData2), "name"), GChitinKey), g_clsDialogTlk);
          cmbxCostValue.Enabled = true;
          tbStatus.Text = "cmbxCostValue specifies CostValue";
        }
      }
      if (StringType.StrCmp(indiceData3, "****", false) == 0)
      {
        cmbxParam1Value.Enabled = false;
        cmbxParam1Value.Items.Clear();
        g_bCmbxPropertyHasParam1ResRef = false;
        tbParam1tableresref.Text = "None";
        lblParam1Desc.Text = "(None)";
      }
      else
      {
        cmbxParam1Value.Enabled = true;
        int rowNumber = IntegerType.FromString(indiceData3);
        string indiceData4 = iprp_paramtable.GetIndiceData(rowNumber, "tableresref");
        FillComboBoxFrom2DA(cmbxParam1Value, "name", ReadCls2DA(indiceData4, GChitinKey), g_clsDialogTlk);
        g_bCmbxPropertyHasParam1ResRef = true;
        tbParam1tableresref.Text = indiceData4;
        Param1Desc = iprp_paramtable.GetIndiceData(rowNumber, "label");
        lblParam1Desc.Text = "(" + Param1Desc + ")";
        tbParam1resref.Text = indiceData3;
      }
      cmbxUpgrade.Enabled = true;
      cmbxUpgrade.SelectedIndex = 0;
      btnOK.Enabled = ValidateForm();
    }

  private void cmbxSubtype_SelectedIndexChanged(object sender, EventArgs e)
  {
      if (g_bCmbxPropertyHasParam1ResRef)
        return;
      Cls2Da cls2Da = ReadCls2DA(itempropdef.GetIndiceData(cmbxPropertyName.SelectedIndex, "subtyperesref"), GChitinKey);
      bool flag1 = false;
      int columnUpperBound1 = cls2Da.ColumnUpperBound;
      int index1 = 0;
      while (index1 <= columnUpperBound1)
      {
        if (StringType.StrCmp(Strings.LCase(cls2Da.ColNames[index1]), "param1resref", false) == 0)
        {
          flag1 = true;
          break;
        }
        checked { ++index1; }
      }
      if (flag1)
      {
        string indiceData1 = cls2Da.GetIndiceData(cmbxSubtype.SelectedIndex, "param1resref");
        tbParam1resref.Text = indiceData1;
        if (StringType.StrCmp(indiceData1, "****", false) == 0)
        {
          cmbxParam1Value.Enabled = false;
          cmbxParam1Value.Items.Clear();
          tbParam1tableresref.Text = "None";
          lblParam1Desc.Text = "(None)";
        }
        else
        {
          cmbxParam1Value.Enabled = true;
          int rowNumber = IntegerType.FromString(indiceData1);
          string indiceData2 = iprp_paramtable.GetIndiceData(rowNumber, "tableresref");
          FillComboBoxFrom2DA(cmbxParam1Value, "name", ReadCls2DA(indiceData2, GChitinKey), g_clsDialogTlk);
          tbParam1tableresref.Text = indiceData2;
          Param1Desc = iprp_paramtable.GetIndiceData(rowNumber, "label");
          lblParam1Desc.Text = "(" + Param1Desc + ")";
        }
      }
      else
      {
        cmbxParam1Value.Enabled = false;
        cmbxParam1Value.Items.Clear();
      }
      bool flag2 = false;
      int columnUpperBound2 = cls2Da.ColumnUpperBound;
      int index2 = 0;
      while (index2 <= columnUpperBound2)
      {
        if (StringType.StrCmp(Strings.LCase(cls2Da.ColNames[index2]), "param2resref", false) == 0)
        {
          flag2 = true;
          break;
        }
        checked { ++index2; }
      }
      if (flag2)
      {
        string indiceData3 = cls2Da.GetIndiceData(cmbxSubtype.SelectedIndex, "param2resref");
        tbParam2resref.Text = indiceData3;
        if (StringType.StrCmp(indiceData3, "****", false) == 0)
        {
          cmbxParam2Value.Enabled = false;
          cmbxParam2Value.Items.Clear();
          tbParam1tableresref.Text = "None";
          lblParam2Desc.Text = "(None)";
        }
        else
        {
          cmbxParam2Value.Enabled = true;
          int rowNumber = IntegerType.FromString(indiceData3);
          string indiceData4 = iprp_paramtable.GetIndiceData(rowNumber, "tableresref");
          FillComboBoxFrom2DA(cmbxParam2Value, "name", ReadCls2DA(indiceData4, GChitinKey), g_clsDialogTlk);
          tbParam2tableresref.Text = indiceData4;
          Param2Desc = iprp_paramtable.GetIndiceData(rowNumber, "label");
          lblParam2Desc.Text = "(" + Param2Desc + ")";
        }
      }
      else
      {
        cmbxParam2Value.Enabled = false;
        cmbxParam2Value.Items.Clear();
      }
      btnOK.Enabled = ValidateForm();
    }

  private bool ValidateForm() => cmbxPropertyName.SelectedIndex != -1 && !(cmbxSubtype.Enabled & cmbxSubtype.SelectedIndex == -1) && !(cmbxCostValue.Enabled & cmbxCostValue.SelectedIndex == -1) && !(cmbxParam1Value.Enabled & cmbxParam1Value.SelectedIndex == -1) && !(cmbxParam2Value.Enabled & cmbxParam2Value.SelectedIndex == -1);

  private void btnDebug_Click(object sender, EventArgs e)
  {
      if (debug)
      {
        Size size = new Size(520, 296);
        Size = size;
        size = new Size(520, 296);
        MaximumSize = size;
        size = new Size(520, 296);
        MinimumSize = size;
        debug = false;
      }
      else
      {
        Size size = new Size(720, 376);
        MaximumSize = size;
        size = new Size(720, 376);
        MinimumSize = size;
        size = new Size(720, 376);
        Size = size;
        debug = true;
      }
    }

  private void cmbxCostValue_SelectedIndexChanged(object sender, EventArgs e) => btnOK.Enabled = ValidateForm();

  private void cmbxParam1Value_SelectedIndexChanged(object sender, EventArgs e) => btnOK.Enabled = ValidateForm();

  private void cmbxParam2Value_SelectedIndexChanged(object sender, EventArgs e) => btnOK.Enabled = ValidateForm();
}