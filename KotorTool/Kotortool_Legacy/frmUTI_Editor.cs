// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmUTI_Editor
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmUTI_Editor : frmParent
{
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("tabpagProperties")]
  private TabPage _tabpagProperties;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("btnDebug")]
  private Button _btnDebug;
  [AccessedThroughProperty("tabpagDescription")]
  private TabPage _tabpagDescription;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("TabControl1")]
  private TabControl _TabControl1;
  [AccessedThroughProperty("tbTemplateResRef")]
  private TextBox _tbTemplateResRef;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("tabpagComments")]
  private TabPage _tabpagComments;
  [AccessedThroughProperty("ToolTip1")]
  private ToolTip _ToolTip1;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("chkbStolen")]
  private CheckBox _chkbStolen;
  [AccessedThroughProperty("tbUnidentifiedDescription")]
  private TextBox _tbUnidentifiedDescription;
  [AccessedThroughProperty("tbLocalizedName")]
  private TextBox _tbLocalizedName;
  [AccessedThroughProperty("nudCost")]
  private NumericUpDown _nudCost;
  [AccessedThroughProperty("nudAdditionalCost")]
  private NumericUpDown _nudAdditionalCost;
  [AccessedThroughProperty("tbIdentifiedDescription")]
  private TextBox _tbIdentifiedDescription;
  [AccessedThroughProperty("nudModelVariation")]
  private NumericUpDown _nudModelVariation;
  [AccessedThroughProperty("nudStackSize")]
  private NumericUpDown _nudStackSize;
  [AccessedThroughProperty("cmbxBaseItem")]
  private ComboBox _cmbxBaseItem;
  [AccessedThroughProperty("dgProperties")]
  private DataGrid _dgProperties;
  [AccessedThroughProperty("chkbIdentified")]
  private CheckBox _chkbIdentified;
  [AccessedThroughProperty("nudPaletteID")]
  private NumericUpDown _nudPaletteID;
  [AccessedThroughProperty("nudTextureVariation")]
  private NumericUpDown _nudTextureVariation;
  [AccessedThroughProperty("nudCharges")]
  private NumericUpDown _nudCharges;
  [AccessedThroughProperty("lblBodyVariation")]
  private Label _lblBodyVariation;
  [AccessedThroughProperty("nudBodyVariation")]
  private NumericUpDown _nudBodyVariation;
  [AccessedThroughProperty("btnLoadXML")]
  private Button _btnLoadXML;
  [AccessedThroughProperty("btnSaveXML")]
  private Button _btnSaveXML;
  [AccessedThroughProperty("btnSetUnidentDescLang")]
  private Button _btnSetUnidentDescLang;
  [AccessedThroughProperty("btnSetIdentDescLang")]
  private Button _btnSetIdentDescLang;
  [AccessedThroughProperty("lblUpgradeLevel")]
  private Label _lblUpgradeLevel;
  [AccessedThroughProperty("nudUpgradeLevel")]
  private NumericUpDown _nudUpgradeLevel;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("tbTag")]
  private TextBox _tbTag;
  [AccessedThroughProperty("lblTextureVariation")]
  private Label _lblTextureVariation;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("chkbPlotItem")]
  private CheckBox _chkbPlotItem;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("tbComment")]
  private TextBox _tbComment;
  [AccessedThroughProperty("tabpagGeneral")]
  private TabPage _tabpagGeneral;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("Label33")]
  private Label _Label33;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  private IContainer components;
  public clsUTI UTI;
  public clsDialogTlk g_clsDialogTlk;
  public ChitinKey GChitinKey;
  private DataTable dt;
  private DataView DView;
  public int UnidentDescLang;
  public int IdentDescLang;
  private Hashtable htOverrideFiles;
  private bool m_bSaveGameMode;
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
  private Cls2Da iprp_pc;

  public frmUTI_Editor()
  {
      Load += new EventHandler(frmUTI_Editor_Load);
      Closing += new CancelEventHandler(frmUTI_Editor_Closing);
      dt = new DataTable();
      htOverrideFiles = new Hashtable();
      m_bSaveGameMode = false;
      InitializeComponent();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual TabControl TabControl1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabControl1 == null)
          ;
        _TabControl1 = value;
        if (_TabControl1 == null)
          ;
      }
    get => _TabControl1;
  }

  internal virtual TabPage tabpagGeneral
  {
    get => _tabpagGeneral;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagGeneral == null)
          ;
        _tabpagGeneral = value;
        if (_tabpagGeneral == null)
          ;
      }
  }

  internal virtual TabPage tabpagProperties
  {
    get => _tabpagProperties;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagProperties == null)
          ;
        _tabpagProperties = value;
        if (_tabpagProperties == null)
          ;
      }
  }

  internal virtual TabPage tabpagDescription
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagDescription == null)
          ;
        _tabpagDescription = value;
        if (_tabpagDescription == null)
          ;
      }
    get => _tabpagDescription;
  }

  internal virtual TabPage tabpagComments
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagComments == null)
          ;
        _tabpagComments = value;
        if (_tabpagComments == null)
          ;
      }
    get => _tabpagComments;
  }

  internal virtual CheckBox chkbPlotItem
  {
    get => _chkbPlotItem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbPlotItem == null)
          ;
        _chkbPlotItem = value;
        if (_chkbPlotItem == null)
          ;
      }
  }

  internal virtual CheckBox chkbStolen
  {
    get => _chkbStolen;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbStolen == null)
          ;
        _chkbStolen = value;
        if (_chkbStolen == null)
          ;
      }
  }

  internal virtual Label Label1
  {
    get => _Label1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label1 == null)
          ;
        _Label1 = value;
        if (_Label1 == null)
          ;
      }
  }

  internal virtual Label Label2
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label2 == null)
          ;
        _Label2 = value;
        if (_Label2 == null)
          ;
      }
    get => _Label2;
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

  internal virtual TextBox tbUnidentifiedDescription
  {
    get => _tbUnidentifiedDescription;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbUnidentifiedDescription == null)
          ;
        _tbUnidentifiedDescription = value;
        if (_tbUnidentifiedDescription == null)
          ;
      }
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

  internal virtual TextBox tbLocalizedName
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbLocalizedName == null)
          ;
        _tbLocalizedName = value;
        if (_tbLocalizedName == null)
          ;
      }
    get => _tbLocalizedName;
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

  internal virtual NumericUpDown nudCost
  {
    get => _nudCost;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudCost == null)
          ;
        _nudCost = value;
        if (_nudCost == null)
          ;
      }
  }

  internal virtual NumericUpDown nudAdditionalCost
  {
    get => _nudAdditionalCost;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudAdditionalCost == null)
          ;
        _nudAdditionalCost = value;
        if (_nudAdditionalCost == null)
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

  internal virtual TextBox tbTemplateResRef
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTemplateResRef == null)
          ;
        _tbTemplateResRef = value;
        if (_tbTemplateResRef == null)
          ;
      }
    get => _tbTemplateResRef;
  }

  internal virtual Label Label9
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label9 == null)
          ;
        _Label9 = value;
        if (_Label9 == null)
          ;
      }
    get => _Label9;
  }

  internal virtual TextBox tbIdentifiedDescription
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbIdentifiedDescription == null)
          ;
        _tbIdentifiedDescription = value;
        if (_tbIdentifiedDescription == null)
          ;
      }
    get => _tbIdentifiedDescription;
  }

  internal virtual Label Label33
  {
    get => _Label33;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label33 == null)
          ;
        _Label33 = value;
        if (_Label33 == null)
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

  internal virtual NumericUpDown nudModelVariation
  {
    get => _nudModelVariation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudModelVariation == null)
          ;
        _nudModelVariation = value;
        if (_nudModelVariation == null)
          ;
      }
  }

  internal virtual NumericUpDown nudStackSize
  {
    get => _nudStackSize;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudStackSize == null)
          ;
        _nudStackSize = value;
        if (_nudStackSize == null)
          ;
      }
  }

  internal virtual Label Label10
  {
    get => _Label10;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label10 == null)
          ;
        _Label10 = value;
        if (_Label10 == null)
          ;
      }
  }

  internal virtual ComboBox cmbxBaseItem
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxBaseItem == null)
          ;
        _cmbxBaseItem = value;
        if (_cmbxBaseItem == null)
          ;
      }
    get => _cmbxBaseItem;
  }

  internal virtual DataGrid dgProperties
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_dgProperties != null)
          _dgProperties.DoubleClick -= new EventHandler(dgProperties_DoubleClick);
        _dgProperties = value;
        if (_dgProperties == null)
          return;
        _dgProperties.DoubleClick += new EventHandler(dgProperties_DoubleClick);
      }
    get => _dgProperties;
  }

  internal virtual CheckBox chkbIdentified
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbIdentified == null)
          ;
        _chkbIdentified = value;
        if (_chkbIdentified == null)
          ;
      }
    get => _chkbIdentified;
  }

  internal virtual NumericUpDown nudPaletteID
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudPaletteID == null)
          ;
        _nudPaletteID = value;
        if (_nudPaletteID == null)
          ;
      }
    get => _nudPaletteID;
  }

  internal virtual Label Label11
  {
    get => _Label11;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label11 == null)
          ;
        _Label11 = value;
        if (_Label11 == null)
          ;
      }
  }

  internal virtual NumericUpDown nudTextureVariation
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudTextureVariation == null)
          ;
        _nudTextureVariation = value;
        if (_nudTextureVariation == null)
          ;
      }
    get => _nudTextureVariation;
  }

  internal virtual NumericUpDown nudCharges
  {
    get => _nudCharges;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudCharges == null)
          ;
        _nudCharges = value;
        if (_nudCharges == null)
          ;
      }
  }

  internal virtual NumericUpDown nudBodyVariation
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudBodyVariation == null)
          ;
        _nudBodyVariation = value;
        if (_nudBodyVariation == null)
          ;
      }
    get => _nudBodyVariation;
  }

  internal virtual Label Label12
  {
    get => _Label12;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label12 == null)
          ;
        _Label12 = value;
        if (_Label12 == null)
          ;
      }
  }

  internal virtual Label lblTextureVariation
  {
    get => _lblTextureVariation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblTextureVariation == null)
          ;
        _lblTextureVariation = value;
        if (_lblTextureVariation == null)
          ;
      }
  }

  internal virtual Label lblBodyVariation
  {
    get => _lblBodyVariation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblBodyVariation == null)
          ;
        _lblBodyVariation = value;
        if (_lblBodyVariation == null)
          ;
      }
  }

  internal virtual Button btnCancel
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnCancel != null)
          _btnCancel.Click -= new EventHandler(btnCancel_Click);
        _btnCancel = value;
        if (_btnCancel == null)
          return;
        _btnCancel.Click += new EventHandler(btnCancel_Click);
      }
    get => _btnCancel;
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

  internal virtual Button btnLoadXML
  {
    get => _btnLoadXML;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnLoadXML != null)
          _btnLoadXML.Click -= new EventHandler(btnLoadXML_Click);
        _btnLoadXML = value;
        if (_btnLoadXML == null)
          return;
        _btnLoadXML.Click += new EventHandler(btnLoadXML_Click);
      }
  }

  internal virtual Button btnSaveXML
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSaveXML != null)
          _btnSaveXML.Click -= new EventHandler(btnSaveXML_Click);
        _btnSaveXML = value;
        if (_btnSaveXML == null)
          return;
        _btnSaveXML.Click += new EventHandler(btnSaveXML_Click);
      }
    get => _btnSaveXML;
  }

  internal virtual Button btnSetUnidentDescLang
  {
    get => _btnSetUnidentDescLang;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSetUnidentDescLang != null)
          _btnSetUnidentDescLang.Click -= new EventHandler(btnSetUnidentDescLang_Click);
        _btnSetUnidentDescLang = value;
        if (_btnSetUnidentDescLang == null)
          return;
        _btnSetUnidentDescLang.Click += new EventHandler(btnSetUnidentDescLang_Click);
      }
  }

  internal virtual Button btnSetIdentDescLang
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSetIdentDescLang != null)
          _btnSetIdentDescLang.Click -= new EventHandler(btnSetIdentDescLang_Click);
        _btnSetIdentDescLang = value;
        if (_btnSetIdentDescLang == null)
          return;
        _btnSetIdentDescLang.Click += new EventHandler(btnSetIdentDescLang_Click);
      }
    get => _btnSetIdentDescLang;
  }

  internal virtual ToolTip ToolTip1
  {
    get => _ToolTip1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolTip1 == null)
          ;
        _ToolTip1 = value;
        if (_ToolTip1 == null)
          ;
      }
  }

  internal virtual Label lblUpgradeLevel
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblUpgradeLevel == null)
          ;
        _lblUpgradeLevel = value;
        if (_lblUpgradeLevel == null)
          ;
      }
    get => _lblUpgradeLevel;
  }

  internal virtual NumericUpDown nudUpgradeLevel
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudUpgradeLevel == null)
          ;
        _nudUpgradeLevel = value;
        if (_nudUpgradeLevel == null)
          ;
      }
    get => _nudUpgradeLevel;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      components = new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (frmUTI_Editor));
      TabControl1 = new TabControl();
      tabpagGeneral = new TabPage();
      cmbxBaseItem = new ComboBox();
      nudCost = new NumericUpDown();
      Label1 = new Label();
      tbTag = new TextBox();
      chkbPlotItem = new CheckBox();
      this.chkbStolen = new CheckBox();
      Label2 = new Label();
      Label3 = new Label();
      nudAdditionalCost = new NumericUpDown();
      Label5 = new Label();
      nudTextureVariation = new NumericUpDown();
      nudModelVariation = new NumericUpDown();
      nudStackSize = new NumericUpDown();
      lblTextureVariation = new Label();
      Label8 = new Label();
      tbTemplateResRef = new TextBox();
      Label9 = new Label();
      Label10 = new Label();
      nudPaletteID = new NumericUpDown();
      Label11 = new Label();
      nudCharges = new NumericUpDown();
      nudBodyVariation = new NumericUpDown();
      Label12 = new Label();
      lblBodyVariation = new Label();
      lblUpgradeLevel = new Label();
      nudUpgradeLevel = new NumericUpDown();
      tabpagProperties = new TabPage();
      btnLoadXML = new Button();
      dgProperties = new DataGrid();
      btnSaveXML = new Button();
      tabpagDescription = new TabPage();
      btnSetUnidentDescLang = new Button();
      chkbIdentified = new CheckBox();
      tbLocalizedName = new TextBox();
      Label4 = new Label();
      tbUnidentifiedDescription = new TextBox();
      tbIdentifiedDescription = new TextBox();
      Label33 = new Label();
      Label6 = new Label();
      btnSetIdentDescLang = new Button();
      tabpagComments = new TabPage();
      tbComment = new TextBox();
      this.btnSave = new Button();
      this.btnCancel = new Button();
      btnDebug = new Button();
      ToolTip1 = new ToolTip(components);
      TabControl1.SuspendLayout();
      tabpagGeneral.SuspendLayout();
      nudCost.BeginInit();
      nudAdditionalCost.BeginInit();
      nudTextureVariation.BeginInit();
      nudModelVariation.BeginInit();
      nudStackSize.BeginInit();
      nudPaletteID.BeginInit();
      nudCharges.BeginInit();
      nudBodyVariation.BeginInit();
      nudUpgradeLevel.BeginInit();
      tabpagProperties.SuspendLayout();
      dgProperties.BeginInit();
      tabpagDescription.SuspendLayout();
      tabpagComments.SuspendLayout();
      SuspendLayout();
      TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TabControl1.Controls.Add(tabpagGeneral);
      TabControl1.Controls.Add(tabpagProperties);
      TabControl1.Controls.Add(tabpagDescription);
      TabControl1.Controls.Add(tabpagComments);
      TabControl tabControl1_1 = TabControl1;
      Size size1 = new Size(49, 18);
      Size size2 = size1;
      tabControl1_1.ItemSize = size2;
      TabControl tabControl1_2 = TabControl1;
      Point point1 = new Point(8, 32);
      Point point2 = point1;
      tabControl1_2.Location = point2;
      TabControl1.Name = "TabControl1";
      TabControl1.SelectedIndex = 0;
      TabControl tabControl1_3 = TabControl1;
      size1 = new Size(488, 312);
      Size size3 = size1;
      tabControl1_3.Size = size3;
      TabControl1.TabIndex = 0;
      tabpagGeneral.Controls.Add(cmbxBaseItem);
      tabpagGeneral.Controls.Add(nudCost);
      tabpagGeneral.Controls.Add(Label1);
      tabpagGeneral.Controls.Add(tbTag);
      tabpagGeneral.Controls.Add(chkbPlotItem);
      tabpagGeneral.Controls.Add(this.chkbStolen);
      tabpagGeneral.Controls.Add(Label2);
      tabpagGeneral.Controls.Add(Label3);
      tabpagGeneral.Controls.Add(nudAdditionalCost);
      tabpagGeneral.Controls.Add(Label5);
      tabpagGeneral.Controls.Add(nudTextureVariation);
      tabpagGeneral.Controls.Add(nudModelVariation);
      tabpagGeneral.Controls.Add(nudStackSize);
      tabpagGeneral.Controls.Add(lblTextureVariation);
      tabpagGeneral.Controls.Add(Label8);
      tabpagGeneral.Controls.Add(tbTemplateResRef);
      tabpagGeneral.Controls.Add(Label9);
      tabpagGeneral.Controls.Add(Label10);
      tabpagGeneral.Controls.Add(nudPaletteID);
      tabpagGeneral.Controls.Add(Label11);
      tabpagGeneral.Controls.Add(nudCharges);
      tabpagGeneral.Controls.Add(nudBodyVariation);
      tabpagGeneral.Controls.Add(Label12);
      tabpagGeneral.Controls.Add(lblBodyVariation);
      tabpagGeneral.Controls.Add(lblUpgradeLevel);
      tabpagGeneral.Controls.Add(nudUpgradeLevel);
      TabPage tabpagGeneral1 = tabpagGeneral;
      point1 = new Point(4, 22);
      Point point3 = point1;
      ((Control) tabpagGeneral1).Location = point3;
      tabpagGeneral.Name = "tabpagGeneral";
      TabPage tabpagGeneral2 = tabpagGeneral;
      size1 = new Size(480, 286);
      Size size4 = size1;
      tabpagGeneral2.Size = size4;
      tabpagGeneral.TabIndex = 0;
      tabpagGeneral.Text = "General";
      cmbxBaseItem.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxBaseItem1 = cmbxBaseItem;
      point1 = new Point(109, 98);
      Point point4 = point1;
      cmbxBaseItem1.Location = point4;
      cmbxBaseItem.Name = "cmbxBaseItem";
      ComboBox cmbxBaseItem2 = cmbxBaseItem;
      size1 = new Size(184, 21);
      Size size5 = size1;
      cmbxBaseItem2.Size = size5;
      cmbxBaseItem.TabIndex = 4;
      NumericUpDown nudCost1 = nudCost;
      point1 = new Point(109, 136);
      Point point5 = point1;
      nudCost1.Location = point5;
      NumericUpDown nudCost2 = nudCost;
      Decimal num1 = new Decimal(new int[4]
      {
        99999,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      nudCost2.Maximum = num2;
      nudCost.Name = "nudCost";
      nudCost.RightToLeft = RightToLeft.No;
      NumericUpDown nudCost3 = nudCost;
      size1 = new Size(64, 20);
      Size size6 = size1;
      nudCost3.Size = size6;
      nudCost.TabIndex = 3;
      nudCost.TextAlign = HorizontalAlignment.Right;
      Label label1_1 = Label1;
      point1 = new Point(16, 62);
      Point point6 = point1;
      label1_1.Location = point6;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(80, 16);
      Size size7 = size1;
      label1_2.Size = size7;
      Label1.TabIndex = 2;
      Label1.Text = "Tag";
      Label1.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbTag1 = tbTag;
      point1 = new Point(109, 60);
      Point point7 = point1;
      tbTag1.Location = point7;
      tbTag.Name = "tbTag";
      TextBox tbTag2 = tbTag;
      size1 = new Size(168, 20);
      Size size8 = size1;
      tbTag2.Size = size8;
      tbTag.TabIndex = 1;
      tbTag.Text = "";
      CheckBox chkbPlotItem1 = chkbPlotItem;
      point1 = new Point(344, 21);
      Point point8 = point1;
      chkbPlotItem1.Location = point8;
      chkbPlotItem.Name = "chkbPlotItem";
      CheckBox chkbPlotItem2 = chkbPlotItem;
      size1 = new Size(72, 24);
      Size size9 = size1;
      chkbPlotItem2.Size = size9;
      chkbPlotItem.TabIndex = 0;
      chkbPlotItem.Text = "Plot item";
      CheckBox chkbStolen = this.chkbStolen;
      point1 = new Point(344, 58);
      Point point9 = point1;
      chkbStolen.Location = point9;
      this.chkbStolen.Name = "chkbStolen";
      this.chkbStolen.TabIndex = 0;
      this.chkbStolen.Text = "Stolen";
      Label label2_1 = Label2;
      point1 = new Point(16, 176);
      Point point10 = point1;
      label2_1.Location = point10;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(80, 16);
      Size size10 = size1;
      label2_2.Size = size10;
      Label2.TabIndex = 2;
      Label2.Text = "Additional Cost";
      Label2.TextAlign = ContentAlignment.MiddleLeft;
      Label label3_1 = Label3;
      point1 = new Point(16, 138);
      Point point11 = point1;
      label3_1.Location = point11;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(80, 16);
      Size size11 = size1;
      label3_2.Size = size11;
      Label3.TabIndex = 2;
      Label3.Text = "Cost";
      Label3.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudAdditionalCost1 = nudAdditionalCost;
      point1 = new Point(109, 174);
      Point point12 = point1;
      nudAdditionalCost1.Location = point12;
      NumericUpDown nudAdditionalCost2 = nudAdditionalCost;
      num1 = new Decimal(new int[4]{ 99999, 0, 0, 0 });
      Decimal num3 = num1;
      nudAdditionalCost2.Maximum = num3;
      nudAdditionalCost.Name = "nudAdditionalCost";
      nudAdditionalCost.RightToLeft = RightToLeft.No;
      NumericUpDown nudAdditionalCost3 = nudAdditionalCost;
      size1 = new Size(64, 20);
      Size size12 = size1;
      nudAdditionalCost3.Size = size12;
      nudAdditionalCost.TabIndex = 3;
      nudAdditionalCost.TextAlign = HorizontalAlignment.Right;
      Label label5_1 = Label5;
      point1 = new Point(312, 176);
      Point point13 = point1;
      label5_1.Location = point13;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(88, 16);
      Size size13 = size1;
      label5_2.Size = size13;
      Label5.TabIndex = 2;
      Label5.Text = "Model Variation";
      Label5.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown textureVariation1 = nudTextureVariation;
      point1 = new Point(408, 248);
      Point point14 = point1;
      textureVariation1.Location = point14;
      NumericUpDown textureVariation2 = nudTextureVariation;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num4 = num1;
      textureVariation2.Maximum = num4;
      nudTextureVariation.Name = "nudTextureVariation";
      nudTextureVariation.RightToLeft = RightToLeft.No;
      NumericUpDown textureVariation3 = nudTextureVariation;
      size1 = new Size(48, 20);
      Size size14 = size1;
      textureVariation3.Size = size14;
      nudTextureVariation.TabIndex = 3;
      nudTextureVariation.TextAlign = HorizontalAlignment.Right;
      nudTextureVariation.Visible = false;
      NumericUpDown nudModelVariation1 = nudModelVariation;
      point1 = new Point(408, 174);
      Point point15 = point1;
      nudModelVariation1.Location = point15;
      NumericUpDown nudModelVariation2 = nudModelVariation;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num5 = num1;
      nudModelVariation2.Maximum = num5;
      nudModelVariation.Name = "nudModelVariation";
      nudModelVariation.RightToLeft = RightToLeft.No;
      NumericUpDown nudModelVariation3 = nudModelVariation;
      size1 = new Size(48, 20);
      Size size15 = size1;
      nudModelVariation3.Size = size15;
      nudModelVariation.TabIndex = 3;
      nudModelVariation.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudStackSize1 = nudStackSize;
      point1 = new Point(408, 136);
      Point point16 = point1;
      nudStackSize1.Location = point16;
      NumericUpDown nudStackSize2 = nudStackSize;
      num1 = new Decimal(new int[4]{ 99999, 0, 0, 0 });
      Decimal num6 = num1;
      nudStackSize2.Maximum = num6;
      nudStackSize.Name = "nudStackSize";
      nudStackSize.RightToLeft = RightToLeft.No;
      NumericUpDown nudStackSize3 = nudStackSize;
      size1 = new Size(48, 20);
      Size size16 = size1;
      nudStackSize3.Size = size16;
      nudStackSize.TabIndex = 3;
      nudStackSize.TextAlign = HorizontalAlignment.Right;
      Label textureVariation4 = lblTextureVariation;
      point1 = new Point(312, 250);
      Point point17 = point1;
      textureVariation4.Location = point17;
      lblTextureVariation.Name = "lblTextureVariation";
      Label textureVariation5 = lblTextureVariation;
      size1 = new Size(96, 16);
      Size size17 = size1;
      textureVariation5.Size = size17;
      lblTextureVariation.TabIndex = 2;
      lblTextureVariation.Text = "Texture Variation";
      lblTextureVariation.TextAlign = ContentAlignment.MiddleLeft;
      lblTextureVariation.Visible = false;
      Label label8_1 = Label8;
      point1 = new Point(312, 138);
      Point point18 = point1;
      label8_1.Location = point18;
      Label8.Name = "Label8";
      Label label8_2 = Label8;
      size1 = new Size(88, 16);
      Size size18 = size1;
      label8_2.Size = size18;
      Label8.TabIndex = 2;
      Label8.Text = "Stack Size";
      Label8.TextAlign = ContentAlignment.MiddleLeft;
      tbTemplateResRef.CharacterCasing = CharacterCasing.Lower;
      TextBox tbTemplateResRef1 = tbTemplateResRef;
      point1 = new Point(109, 23);
      Point point19 = point1;
      tbTemplateResRef1.Location = point19;
      tbTemplateResRef.MaxLength = 16;
      tbTemplateResRef.Name = "tbTemplateResRef";
      TextBox tbTemplateResRef2 = tbTemplateResRef;
      size1 = new Size(168, 20);
      Size size19 = size1;
      tbTemplateResRef2.Size = size19;
      tbTemplateResRef.TabIndex = 1;
      tbTemplateResRef.Text = "";
      Label label9_1 = Label9;
      point1 = new Point(16, 24);
      Point point20 = point1;
      label9_1.Location = point20;
      Label9.Name = "Label9";
      Label label9_2 = Label9;
      size1 = new Size(96, 16);
      Size size20 = size1;
      label9_2.Size = size20;
      Label9.TabIndex = 2;
      Label9.Text = "Template ResRef";
      Label9.TextAlign = ContentAlignment.MiddleLeft;
      Label label10_1 = Label10;
      point1 = new Point(16, 100);
      Point point21 = point1;
      label10_1.Location = point21;
      Label10.Name = "Label10";
      Label label10_2 = Label10;
      size1 = new Size(80, 16);
      Size size21 = size1;
      label10_2.Size = size21;
      Label10.TabIndex = 2;
      Label10.Text = "Base Item";
      Label10.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudPaletteId1 = nudPaletteID;
      point1 = new Point(125, 211);
      Point point22 = point1;
      nudPaletteId1.Location = point22;
      NumericUpDown nudPaletteId2 = nudPaletteID;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num7 = num1;
      nudPaletteId2.Maximum = num7;
      nudPaletteID.Name = "nudPaletteID";
      nudPaletteID.RightToLeft = RightToLeft.No;
      NumericUpDown nudPaletteId3 = nudPaletteID;
      size1 = new Size(48, 20);
      Size size22 = size1;
      nudPaletteId3.Size = size22;
      nudPaletteID.TabIndex = 3;
      nudPaletteID.TextAlign = HorizontalAlignment.Right;
      Label label11_1 = Label11;
      point1 = new Point(16, 213);
      Point point23 = point1;
      label11_1.Location = point23;
      Label11.Name = "Label11";
      Label label11_2 = Label11;
      size1 = new Size(80, 16);
      Size size23 = size1;
      label11_2.Size = size23;
      Label11.TabIndex = 2;
      Label11.Text = "Palette ID";
      Label11.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudCharges1 = nudCharges;
      point1 = new Point(408, 98);
      Point point24 = point1;
      nudCharges1.Location = point24;
      NumericUpDown nudCharges2 = nudCharges;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num8 = num1;
      nudCharges2.Maximum = num8;
      nudCharges.Name = "nudCharges";
      nudCharges.RightToLeft = RightToLeft.No;
      NumericUpDown nudCharges3 = nudCharges;
      size1 = new Size(48, 20);
      Size size24 = size1;
      nudCharges3.Size = size24;
      nudCharges.TabIndex = 3;
      nudCharges.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudBodyVariation1 = nudBodyVariation;
      point1 = new Point(408, 211);
      Point point25 = point1;
      nudBodyVariation1.Location = point25;
      NumericUpDown nudBodyVariation2 = nudBodyVariation;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num9 = num1;
      nudBodyVariation2.Maximum = num9;
      nudBodyVariation.Name = "nudBodyVariation";
      nudBodyVariation.RightToLeft = RightToLeft.No;
      NumericUpDown nudBodyVariation3 = nudBodyVariation;
      size1 = new Size(48, 20);
      Size size25 = size1;
      nudBodyVariation3.Size = size25;
      nudBodyVariation.TabIndex = 3;
      nudBodyVariation.TextAlign = HorizontalAlignment.Right;
      nudBodyVariation.Visible = false;
      Label label12_1 = Label12;
      point1 = new Point(312, 100);
      Point point26 = point1;
      label12_1.Location = point26;
      Label12.Name = "Label12";
      Label label12_2 = Label12;
      size1 = new Size(88, 16);
      Size size26 = size1;
      label12_2.Size = size26;
      Label12.TabIndex = 2;
      Label12.Text = "Charges";
      Label12.TextAlign = ContentAlignment.MiddleLeft;
      Label lblBodyVariation1 = lblBodyVariation;
      point1 = new Point(312, 213);
      Point point27 = point1;
      lblBodyVariation1.Location = point27;
      lblBodyVariation.Name = "lblBodyVariation";
      Label lblBodyVariation2 = lblBodyVariation;
      size1 = new Size(88, 16);
      Size size27 = size1;
      lblBodyVariation2.Size = size27;
      lblBodyVariation.TabIndex = 2;
      lblBodyVariation.Text = "Body Variation";
      lblBodyVariation.TextAlign = ContentAlignment.MiddleLeft;
      lblBodyVariation.Visible = false;
      Label lblUpgradeLevel1 = lblUpgradeLevel;
      point1 = new Point(16, 250);
      Point point28 = point1;
      lblUpgradeLevel1.Location = point28;
      lblUpgradeLevel.Name = "lblUpgradeLevel";
      Label lblUpgradeLevel2 = lblUpgradeLevel;
      size1 = new Size(80, 16);
      Size size28 = size1;
      lblUpgradeLevel2.Size = size28;
      lblUpgradeLevel.TabIndex = 2;
      lblUpgradeLevel.Text = "Upgrade Level";
      lblUpgradeLevel.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudUpgradeLevel1 = nudUpgradeLevel;
      point1 = new Point(125, 248);
      Point point29 = point1;
      nudUpgradeLevel1.Location = point29;
      NumericUpDown nudUpgradeLevel2 = nudUpgradeLevel;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num10 = num1;
      nudUpgradeLevel2.Maximum = num10;
      nudUpgradeLevel.Name = "nudUpgradeLevel";
      nudUpgradeLevel.RightToLeft = RightToLeft.No;
      NumericUpDown nudUpgradeLevel3 = nudUpgradeLevel;
      size1 = new Size(48, 20);
      Size size29 = size1;
      nudUpgradeLevel3.Size = size29;
      nudUpgradeLevel.TabIndex = 3;
      nudUpgradeLevel.TextAlign = HorizontalAlignment.Right;
      tabpagProperties.Controls.Add(btnLoadXML);
      tabpagProperties.Controls.Add(dgProperties);
      tabpagProperties.Controls.Add(btnSaveXML);
      TabPage tabpagProperties1 = tabpagProperties;
      point1 = new Point(4, 22);
      Point point30 = point1;
      ((Control) tabpagProperties1).Location = point30;
      tabpagProperties.Name = "tabpagProperties";
      TabPage tabpagProperties2 = tabpagProperties;
      size1 = new Size(480, 286);
      Size size30 = size1;
      tabpagProperties2.Size = size30;
      tabpagProperties.TabIndex = 1;
      tabpagProperties.Text = "Properties";
      btnLoadXML.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnLoadXml = btnLoadXML;
      point1 = new Point(288, 248);
      Point point31 = point1;
      btnLoadXml.Location = point31;
      btnLoadXML.Name = "btnLoadXML";
      btnLoadXML.TabIndex = 4;
      btnLoadXML.Text = "Load XML";
      dgProperties.AllowSorting = false;
      dgProperties.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      dgProperties.DataMember = "";
      dgProperties.HeaderForeColor = SystemColors.ControlText;
      DataGrid dgProperties1 = dgProperties;
      point1 = new Point(8, 16);
      Point point32 = point1;
      dgProperties1.Location = point32;
      dgProperties.Name = "dgProperties";
      DataGrid dgProperties2 = dgProperties;
      size1 = new Size(464, 208);
      Size size31 = size1;
      dgProperties2.Size = size31;
      dgProperties.TabIndex = 0;
      ToolTip1.SetToolTip(dgProperties, "Double-click on the row header to edit an existing entry or on the '*\" row header to add a new entry");
      btnSaveXML.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnSaveXml = btnSaveXML;
      point1 = new Point(384, 248);
      Point point33 = point1;
      btnSaveXml.Location = point33;
      btnSaveXML.Name = "btnSaveXML";
      btnSaveXML.TabIndex = 4;
      btnSaveXML.Text = "Save XML";
      tabpagDescription.Controls.Add(btnSetUnidentDescLang);
      tabpagDescription.Controls.Add(chkbIdentified);
      tabpagDescription.Controls.Add(tbLocalizedName);
      tabpagDescription.Controls.Add(Label4);
      tabpagDescription.Controls.Add(tbUnidentifiedDescription);
      tabpagDescription.Controls.Add(tbIdentifiedDescription);
      tabpagDescription.Controls.Add(Label33);
      tabpagDescription.Controls.Add(Label6);
      tabpagDescription.Controls.Add(btnSetIdentDescLang);
      TabPage tabpagDescription1 = tabpagDescription;
      point1 = new Point(4, 22);
      Point point34 = point1;
      ((Control) tabpagDescription1).Location = point34;
      tabpagDescription.Name = "tabpagDescription";
      TabPage tabpagDescription2 = tabpagDescription;
      size1 = new Size(480, 286);
      Size size32 = size1;
      tabpagDescription2.Size = size32;
      tabpagDescription.TabIndex = 2;
      tabpagDescription.Text = "Description";
      Button setUnidentDescLang1 = btnSetUnidentDescLang;
      point1 = new Point(128, 248);
      Point point35 = point1;
      setUnidentDescLang1.Location = point35;
      btnSetUnidentDescLang.Name = "btnSetUnidentDescLang";
      Button setUnidentDescLang2 = btnSetUnidentDescLang;
      size1 = new Size(88, 23);
      Size size33 = size1;
      setUnidentDescLang2.Size = size33;
      btnSetUnidentDescLang.TabIndex = 4;
      btnSetUnidentDescLang.Text = "Set Language";
      CheckBox chkbIdentified1 = chkbIdentified;
      point1 = new Point(328, 40);
      Point point36 = point1;
      chkbIdentified1.Location = point36;
      chkbIdentified.Name = "chkbIdentified";
      CheckBox chkbIdentified2 = chkbIdentified;
      size1 = new Size(72, 24);
      Size size34 = size1;
      chkbIdentified2.Size = size34;
      chkbIdentified.TabIndex = 3;
      chkbIdentified.Text = "Identified";
      TextBox tbLocalizedName1 = tbLocalizedName;
      point1 = new Point(24, 40);
      Point point37 = point1;
      tbLocalizedName1.Location = point37;
      tbLocalizedName.Name = "tbLocalizedName";
      TextBox tbLocalizedName2 = tbLocalizedName;
      size1 = new Size(256, 20);
      Size size35 = size1;
      tbLocalizedName2.Size = size35;
      tbLocalizedName.TabIndex = 2;
      tbLocalizedName.Text = "";
      Label label4_1 = Label4;
      point1 = new Point(24, 88);
      Point point38 = point1;
      label4_1.Location = point38;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(136, 16);
      Size size36 = size1;
      label4_2.Size = size36;
      Label4.TabIndex = 1;
      Label4.Text = "Unidentified Description";
      Label4.TextAlign = ContentAlignment.MiddleLeft;
      TextBox unidentifiedDescription1 = tbUnidentifiedDescription;
      point1 = new Point(24, 112);
      Point point39 = point1;
      unidentifiedDescription1.Location = point39;
      tbUnidentifiedDescription.Multiline = true;
      tbUnidentifiedDescription.Name = "tbUnidentifiedDescription";
      tbUnidentifiedDescription.ScrollBars = ScrollBars.Vertical;
      TextBox unidentifiedDescription2 = tbUnidentifiedDescription;
      size1 = new Size(192, 120);
      Size size37 = size1;
      unidentifiedDescription2.Size = size37;
      tbUnidentifiedDescription.TabIndex = 0;
      tbUnidentifiedDescription.Text = "";
      tbIdentifiedDescription.BackColor = SystemColors.Info;
      TextBox identifiedDescription1 = tbIdentifiedDescription;
      point1 = new Point(272, 112);
      Point point40 = point1;
      identifiedDescription1.Location = point40;
      tbIdentifiedDescription.Multiline = true;
      tbIdentifiedDescription.Name = "tbIdentifiedDescription";
      tbIdentifiedDescription.ScrollBars = ScrollBars.Vertical;
      TextBox identifiedDescription2 = tbIdentifiedDescription;
      size1 = new Size(192, 120);
      Size size38 = size1;
      identifiedDescription2.Size = size38;
      tbIdentifiedDescription.TabIndex = 0;
      tbIdentifiedDescription.Text = "";
      Label label33_1 = Label33;
      point1 = new Point(272, 88);
      Point point41 = point1;
      label33_1.Location = point41;
      Label33.Name = "Label33";
      Label label33_2 = Label33;
      size1 = new Size(136, 16);
      Size size39 = size1;
      label33_2.Size = size39;
      Label33.TabIndex = 1;
      Label33.Text = "Identified Description";
      Label33.TextAlign = ContentAlignment.MiddleLeft;
      Label label6_1 = Label6;
      point1 = new Point(24, 16);
      Point point42 = point1;
      label6_1.Location = point42;
      Label6.Name = "Label6";
      Label label6_2 = Label6;
      size1 = new Size(136, 16);
      Size size40 = size1;
      label6_2.Size = size40;
      Label6.TabIndex = 1;
      Label6.Text = "Name";
      Label6.TextAlign = ContentAlignment.MiddleLeft;
      Button setIdentDescLang1 = btnSetIdentDescLang;
      point1 = new Point(376, 248);
      Point point43 = point1;
      setIdentDescLang1.Location = point43;
      btnSetIdentDescLang.Name = "btnSetIdentDescLang";
      Button setIdentDescLang2 = btnSetIdentDescLang;
      size1 = new Size(88, 23);
      Size size41 = size1;
      setIdentDescLang2.Size = size41;
      btnSetIdentDescLang.TabIndex = 4;
      btnSetIdentDescLang.Text = "Set Language";
      tabpagComments.Controls.Add(tbComment);
      TabPage tabpagComments1 = tabpagComments;
      point1 = new Point(4, 22);
      Point point44 = point1;
      ((Control) tabpagComments1).Location = point44;
      tabpagComments.Name = "tabpagComments";
      TabPage tabpagComments2 = tabpagComments;
      size1 = new Size(480, 286);
      Size size42 = size1;
      tabpagComments2.Size = size42;
      tabpagComments.TabIndex = 3;
      tabpagComments.Text = "Comment";
      tbComment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TextBox tbComment1 = tbComment;
      point1 = new Point(8, 8);
      Point point45 = point1;
      tbComment1.Location = point45;
      tbComment.Multiline = true;
      tbComment.Name = "tbComment";
      TextBox tbComment2 = tbComment;
      size1 = new Size(464, 272);
      Size size43 = size1;
      tbComment2.Size = size43;
      tbComment.TabIndex = 0;
      tbComment.Text = "";
      this.btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnSave = this.btnSave;
      point1 = new Point(304, 360);
      Point point46 = point1;
      btnSave.Location = point46;
      this.btnSave.Name = "btnSave";
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "&Save";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(408, 360);
      Point point47 = point1;
      btnCancel.Location = point47;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "&Cancel";
      btnDebug.FlatStyle = FlatStyle.Flat;
      btnDebug.ForeColor = SystemColors.Control;
      Button btnDebug1 = btnDebug;
      point1 = new Point(0, 0);
      Point point48 = point1;
      btnDebug1.Location = point48;
      btnDebug.Name = "btnDebug";
      Button btnDebug2 = btnDebug;
      size1 = new Size(8, 8);
      Size size44 = size1;
      btnDebug2.Size = size44;
      btnDebug.TabIndex = 2;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = this.btnCancel;
      size1 = new Size(512, 397);
      ClientSize = size1;
      Controls.Add(btnDebug);
      Controls.Add(this.btnSave);
      Controls.Add(TabControl1);
      Controls.Add(this.btnCancel);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      size1 = new Size(520, 424);
      MinimumSize = size1;
      Name = nameof (frmUTI_Editor);
      SizeGripStyle = SizeGripStyle.Show;
      Text = "Item Editor - KotOR ";
      TabControl1.ResumeLayout(false);
      tabpagGeneral.ResumeLayout(false);
      nudCost.EndInit();
      nudAdditionalCost.EndInit();
      nudTextureVariation.EndInit();
      nudModelVariation.EndInit();
      nudStackSize.EndInit();
      nudPaletteID.EndInit();
      nudCharges.EndInit();
      nudBodyVariation.EndInit();
      nudUpgradeLevel.EndInit();
      tabpagProperties.ResumeLayout(false);
      dgProperties.EndInit();
      tabpagDescription.ResumeLayout(false);
      tabpagComments.ResumeLayout(false);
      ResumeLayout(false);
    }

  public frmUTI_Editor(
    clsUTI UTIClass,
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
      MDefaultTitleText = "Item Editor - KotOR ";
      Text = MDefaultTitleText;
      if (KotorVerIndex == 0)
        Text += "I";
      else
        Text += "II";
      CurrentSettings = UserSettings.GetSettings();
      g_clsDialogTlk = new clsDialogTlk(CurrentSettings.KotorLocation(KotorVerIndex) + "\\dialog.tlk");
      UTI = UTIClass;
      KotorVersionIndex = KotorVerIndex;
      Setup();
      if (htOverrideFiles.Keys.Count <= 0 || Interaction.MsgBox("The loaded file used some data from files in the Override folder\n\n           Click OK to view the files used.", MsgBoxStyle.OkCancel | MsgBoxStyle.Information, "Override files used") != MsgBoxResult.Ok)
        return;
      frmOverrideFilesUsed overrideFilesUsed = new frmOverrideFilesUsed();
      foreach (object htOverrideFile in htOverrideFiles)
      {
        DictionaryEntry dictionaryEntry = (DictionaryEntry) (htOverrideFile ?? Activator.CreateInstance(typeof (DictionaryEntry)));
        overrideFilesUsed.lbOverrideFiles.Items.Add(RuntimeHelpers.GetObjectValue(dictionaryEntry.Key));
      }
      int num = (int) overrideFilesUsed.ShowDialog(this);
    }

  public void Setup()
  {
      GChitinKey = new ChitinKey(CurrentSettings.KeyFileLocation(KotorVersionIndex));
      UTI.SetTextBoxToNodeValue(tbTemplateResRef, "TemplateResRef");
      UTI.SetTextBoxToNodeValue(tbTag, "Tag");
      UTI.SetNumericUpDownToUIntNodeValue(nudCost, "Cost");
      UTI.SetNumericUpDownToUIntNodeValue(nudAdditionalCost, "AddCost");
      UTI.SetNumericUpDownToNodeValue(nudModelVariation, "ModelVariation");
      UTI.SetNumericUpDownToNodeValue(nudCharges, "Charges");
      UTI.SetNumericUpDownToUIntNodeValue(nudStackSize, "StackSize");
      chkbPlotItem.Checked = BooleanType.FromObject(UTI.GetNodeValue("Plot"));
      chkbStolen.Checked = BooleanType.FromObject(UTI.GetNodeValue("Stolen"));
      UTI.SetNumericUpDownToNodeValue(nudPaletteID, "PaletteID");
      if (UTI.VerifyNodeExists("TextureVar"))
      {
        UTI.SetNumericUpDownToNodeValue(nudTextureVariation, "TextureVar");
        nudTextureVariation.Visible = true;
        lblTextureVariation.Visible = true;
      }
      if (UTI.VerifyNodeExists("BodyVariation"))
      {
        UTI.SetNumericUpDownToNodeValue(nudBodyVariation, "BodyVariation");
        nudBodyVariation.Visible = true;
        lblBodyVariation.Visible = true;
      }
      if (UTI.VerifyNodeExists("UpgradeLevel"))
      {
        UTI.SetNumericUpDownToNodeValue(nudBodyVariation, "UpgradeLevel");
        nudUpgradeLevel.Visible = true;
        lblUpgradeLevel.Visible = true;
      }
      BuildDataTable();
      BuildDataGrid();
      ReadPropsAndLoadGrid();
      UTI.SetTextBoxFromCExoLocStringNodeValue(tbLocalizedName, "LocalizedName", g_clsDialogTlk);
      UTI.SetTextBoxFromCExoLocStringNodeValue(tbUnidentifiedDescription, "Description", g_clsDialogTlk);
      UnidentDescLang = IntegerType.FromObject(UTI.GetCExoLocStringLanguage("Description"));
      tbUnidentifiedDescription.Text = Strings.Replace(tbUnidentifiedDescription.Text, "\n", "\r\n");
      UTI.SetTextBoxFromCExoLocStringNodeValue(tbIdentifiedDescription, "DescIdentified", g_clsDialogTlk);
      IdentDescLang = IntegerType.FromObject(UTI.GetCExoLocStringLanguage("DescIdentified"));
      tbIdentifiedDescription.Text = Strings.Replace(tbIdentifiedDescription.Text, "\n", "\r\n");
      chkbIdentified.Checked = BooleanType.FromObject(UTI.GetNodeValue("Identified"));
      UTI.SetTextBoxToNodeValue(tbComment, "Comment");
      BuildComboBoxes();
      UTI.SyncComboBox(cmbxBaseItem, "BaseItem");
      if (UTI.SyncComboBox(cmbxBaseItem, "BaseItem"))
        return;
      int num = (int) Interaction.MsgBox("One or more drop down menus could not be set.\n\nThis occurs when the file's index value for a menu exceeds the number of items on the menu itself.\n\nMenus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error");
    }

  public void BuildComboBoxes() => BuildBaseItemComboBox();

  public void BuildBaseItemComboBox()
  {
      BIFFArchive biffArchive1 = new BIFFArchive();
      BIFFArchive biffArchive2 = new BIFFArchive(new FileStream(CurrentSettings.KotorLocation(KotorVersionIndex) + "\\data\\templates.bif", FileMode.Open));
      bool flag = true;
      byte[] numArray = new byte[] { };
      if (CurrentSettings.bUseOverrideFiles)
      {
        string path = CurrentSettings.KotorLocation(KotorVersionIndex) + "\\override\\baseitems.2da";
        try
        {
          if (File.Exists(path))
          {
            FileStream fileStream = new FileStream(path, FileMode.Open);
            numArray = new byte[checked ((int) fileStream.Length + 1)];
            fileStream.Read(numArray, 0, checked ((int) fileStream.Length));
            fileStream.Close();
            flag = false;
            Console.WriteLine("Read baseitems.2da from override");
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
        int resIdForResRef = GChitinKey.FindResIdForResRef("baseitems", 2017);
        numArray = BIFFArchive.GetBIFFResource(CurrentSettings.KotorLocation(KotorVersionIndex) + "\\" + GChitinKey.BiffList[resIdForResRef >> 20].Filename, resIdForResRef).Data;
        Console.WriteLine("Read baseitems.2da from 2da.bif");
      }
      ArrayList namesAndTypesList = new ClsBaseItems2Da(numArray).GetItemNamesAndTypesList(g_clsDialogTlk);
      try
      {
        foreach (TreeBaseItem treeBaseItem in namesAndTypesList)
          cmbxBaseItem.Items.Add(treeBaseItem._name);
      }
      finally
      {
        
      }
    }

  private void SetGFFNodeValues()
  {
      UTI.SetNodeValueFromComboBox(cmbxBaseItem, "BaseItem");
      UTI.SetNodeValueFromTextBox(tbTemplateResRef, "TemplateResRef");
      UTI.SetNodeValueFromTextBox(tbTag, "Tag");
      UTI.SetNumericUpDownToUIntNodeValue(nudCost, "Cost");
      UTI.SetNodeValueFromNumericUpDown(nudAdditionalCost, "AddCost");
      if (UTI.VerifyNodeExists("ModelVariation"))
        UTI.SetNodeValueFromNumericUpDown(nudModelVariation, "ModelVariation");
      UTI.SetNodeValueFromNumericUpDown(nudCharges, "Charges");
      UTI.SetNodeValueFromNumericUpDown(nudStackSize, "StackSize");
      UTI.SetNodeValue("Plot", chkbPlotItem.Checked);
      UTI.SetNodeValue("Stolen", chkbStolen.Checked);
      UTI.SetNodeValueFromNumericUpDown(nudPaletteID, "PaletteID");
      if (UTI.VerifyNodeExists("TextureVar"))
        UTI.SetNodeValueFromNumericUpDown(nudTextureVariation, "TextureVar");
      if (UTI.VerifyNodeExists("BodyVariation"))
        UTI.SetNodeValueFromNumericUpDown(nudBodyVariation, "BodyVariation");
      if (UTI.VerifyNodeExists("UpgradeLevel"))
        UTI.SetNodeValueFromNumericUpDown(nudBodyVariation, "UpgradeLevel");
      if (!UTI.VerifyNodeExists("PropertiesList"))
        UTI.CreateList("", "PropertiesList");
      else
        UTI.ClearListElements("PropertiesList");
      try
      {
        foreach (DataRow row in (InternalDataCollectionBase) dt.Rows)
        {
          GffStruct @struct = new GffStruct();
          @struct.type = 0;
          @struct.fieldCount = 7;
          if (ObjectType.ObjTst(row["Param2ID"], -1, false) != 0)
            checked { @struct.fieldCount += 2; }
          if (ObjectType.ObjTst(row["UpgradeID"], -1, false) != 0)
            checked { ++@struct.fieldCount; }
          @struct.fields = new GFF_Field[checked (@struct.fieldCount - 1 + 1)];
          @struct.fields[0] = new GFF_Field(GFFField.GFF_word, "PropertyName", IntegerType.FromObject(row["PropertyID"]));
          @struct.fields[1] = new GFF_Field(GFFField.GFF_word, "Subtype", IntegerType.FromObject(row["SubtypeID"]));
          @struct.fields[2] = new GFF_Field(GFFField.GFF_byte, "CostTable", IntegerType.FromObject(row["CostTableID"]));
          @struct.fields[3] = new GFF_Field(GFFField.GFF_word, "CostValue", IntegerType.FromObject(row["CostValueID"]));
          @struct.fields[4] = new GFF_Field(GFFField.GFF_byte, "Param1", IntegerType.FromObject(row["Param1ID"]));
          @struct.fields[5] = new GFF_Field(GFFField.GFF_byte, "Param1Value", IntegerType.FromObject(row["Param1ValueID"]));
          int index1 = 6;
          if (ObjectType.ObjTst(row["Param2ID"], -1, false) != 0)
          {
            @struct.fields[index1] = new GFF_Field(GFFField.GFF_byte, "Param2", IntegerType.FromObject(row["Param2ID"]));
            int index2 = checked (index1 + 1);
            @struct.fields[index2] = new GFF_Field(GFFField.GFF_byte, "Param2Value", IntegerType.FromObject(row["Param2ValueID"]));
            index1 = checked (index2 + 1);
          }
          if (ObjectType.ObjTst(row["UpgradeID"], -1, false) != 0)
          {
            @struct.fields[index1] = new GFF_Field(GFFField.GFF_byte, "UpgradeType", IntegerType.FromObject(row["UpgradeID"]));
            checked { ++index1; }
          }
          @struct.fields[index1] = new GFF_Field(GFFField.GFF_byte, "ChanceAppear", IntegerType.FromObject(row["% Chance of Appearance"]));
          UTI.AddListElement("PropertiesList", @struct);
        }
      }
      finally
      {
       
      }
      UTI.SetNodeValue("Identified", chkbIdentified.Checked);
      UTI.SetCExoLocStringNodeValueFromTextBox(tbLocalizedName, "LocalizedName");
      TextBox TB = new TextBox();
      TB.Text = Strings.Replace(tbUnidentifiedDescription.Text, "\r\n", "\n");
      UTI.SetCExoLocStringNodeValueFromTextBox(TB, "Description", UnidentDescLang);
      TB.Text = Strings.Replace(tbIdentifiedDescription.Text, "\r\n", "\n");
      UTI.SetCExoLocStringNodeValueFromTextBox(TB, "DescIdentified", IdentDescLang);
      UTI.SetNodeValueFromTextBox(tbComment, "Comment");
    }

  public Cls2Da ReadCls2DA(string TwoDAName)
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
        int resIdForResRef = GChitinKey.FindResIdForResRef(TwoDAName, 2017);
        numArray = BIFFArchive.GetBIFFResource(CurrentSettings.KotorLocation(KotorVersionIndex) + "\\" + GChitinKey.BiffList[resIdForResRef >> 20].Filename, resIdForResRef).Data;
      }
      return new Cls2Da(numArray);
    }

  public Cls2Da GetCls2DA(string TwoDAName)
  {
      string sLeft = Strings.LCase(TwoDAName);
      if (StringType.StrCmp(sLeft, "iprp_abilities", false) == 0)
      {
        if (iprp_abilities == null)
          iprp_abilities = ReadCls2DA("iprp_abilities");
        return iprp_abilities;
      }
      if (StringType.StrCmp(sLeft, "appearance", false) == 0)
      {
        if (appearance == null)
          appearance = ReadCls2DA("appearance");
        return appearance;
      }
      if (StringType.StrCmp(sLeft, "classes", false) == 0)
      {
        if (classes == null)
          classes = ReadCls2DA("classes");
        return classes;
      }
      if (StringType.StrCmp(sLeft, "feat", false) == 0)
      {
        if (feat == null)
          feat = ReadCls2DA("feat");
        return feat;
      }
      if (StringType.StrCmp(sLeft, "iprp_acmodtype", false) == 0)
      {
        if (iprp_acmodtype == null)
          iprp_acmodtype = ReadCls2DA("iprp_acmodtype");
        return iprp_acmodtype;
      }
      if (StringType.StrCmp(sLeft, "iprp_aligngrp", false) == 0)
      {
        if (iprp_aligngrp == null)
          iprp_aligngrp = ReadCls2DA("iprp_aligngrp");
        return iprp_aligngrp;
      }
      if (StringType.StrCmp(sLeft, "iprp_ammotype", false) == 0)
      {
        if (iprp_ammotype == null)
          iprp_ammotype = ReadCls2DA("iprp_ammotype");
        return iprp_ammotype;
      }
      if (StringType.StrCmp(sLeft, "iprp_combatdam", false) == 0)
      {
        if (iprp_combatdam == null)
          iprp_combatdam = ReadCls2DA("iprp_combatdam");
        return iprp_combatdam;
      }
      if (StringType.StrCmp(sLeft, "iprp_damagetype", false) == 0)
      {
        if (iprp_damagetype == null)
          iprp_damagetype = ReadCls2DA("iprp_damagetype");
        return iprp_damagetype;
      }
      if (StringType.StrCmp(sLeft, "iprp_immunity", false) == 0)
      {
        if (iprp_immunity == null)
          iprp_immunity = ReadCls2DA("iprp_immunity");
        return iprp_immunity;
      }
      if (StringType.StrCmp(sLeft, "iprp_monsterhit", false) == 0)
      {
        if (iprp_monsterhit == null)
          iprp_monsterhit = ReadCls2DA("iprp_monsterhit");
        return iprp_monsterhit;
      }
      if (StringType.StrCmp(sLeft, "iprp_onhit", false) == 0)
      {
        if (iprp_onhit == null)
          iprp_onhit = ReadCls2DA("iprp_onhit");
        return iprp_onhit;
      }
      if (StringType.StrCmp(sLeft, "iprp_protection", false) == 0)
      {
        if (iprp_protection == null)
          iprp_protection = ReadCls2DA("iprp_protection");
        return iprp_protection;
      }
      if (StringType.StrCmp(sLeft, "iprp_saveelement", false) == 0)
      {
        if (iprp_saveelement == null)
          iprp_saveelement = ReadCls2DA("iprp_saveelement");
        return iprp_saveelement;
      }
      if (StringType.StrCmp(sLeft, "iprp_savingthrow", false) == 0)
      {
        if (iprp_savingthrow == null)
          iprp_savingthrow = ReadCls2DA("iprp_savingthrow");
        return iprp_savingthrow;
      }
      if (StringType.StrCmp(sLeft, "iprp_walk", false) == 0)
      {
        if (iprp_walk == null)
          iprp_walk = ReadCls2DA("iprp_walk");
        return iprp_walk;
      }
      if (StringType.StrCmp(sLeft, "racialtypes", false) == 0)
      {
        if (racialtypes == null)
          racialtypes = ReadCls2DA("racialtypes");
        return racialtypes;
      }
      if (StringType.StrCmp(sLeft, "skills", false) == 0)
      {
        if (skills == null)
          skills = ReadCls2DA("skills");
        return skills;
      }
      if (StringType.StrCmp(sLeft, "spells", false) == 0)
      {
        if (spells == null)
          spells = ReadCls2DA("spells");
        return spells;
      }
      if (StringType.StrCmp(sLeft, "traps", false) == 0)
      {
        if (traps == null)
          traps = ReadCls2DA("traps");
        return traps;
      }
      if (StringType.StrCmp(sLeft, "iprp_pc", false) == 0)
      {
        if (iprp_pc == null)
          iprp_pc = ReadCls2DA("iprp_pc");
        return iprp_pc;
      }
      Console.WriteLine("UTI Editor: 2DA file needed for lookup loaded directly - " + TwoDAName);
      return ReadCls2DA(TwoDAName);
    }

  public void Load2DAs()
  {
      itempropdef = ReadCls2DA("itempropdef");
      iprp_costtable = ReadCls2DA("iprp_costtable");
      iprp_paramtable = ReadCls2DA("iprp_paramtable");
    }

  public void BuildDataTable()
  {
      dt.Columns.Add(new DataColumn("Property", typeof (string))
      {
        DefaultValue = ""
      });
      dt.Columns.Add(new DataColumn("Subtype", typeof (string))
      {
        DefaultValue = ""
      });
      dt.Columns.Add(new DataColumn("CostTable", typeof (string))
      {
        DefaultValue = ""
      });
      dt.Columns.Add(new DataColumn("CostValue", typeof (string))
      {
        DefaultValue = ""
      });
      dt.Columns.Add(new DataColumn("Param1", typeof (string)));
      dt.Columns.Add(new DataColumn("Param1Value", typeof (string)));
      dt.Columns.Add(new DataColumn("Param2", typeof (string)));
      dt.Columns.Add(new DataColumn("Param2Value", typeof (string)));
      dt.Columns.Add(new DataColumn("Upgrade", typeof (string))
      {
        DefaultValue = ""
      });
      dt.Columns.Add(new DataColumn("% Chance of Appearance", typeof (string))
      {
        DefaultValue = 100
      });
      dt.Columns.Add(new DataColumn("PropertyID", typeof (int))
      {
        DefaultValue = 0
      });
      dt.Columns.Add(new DataColumn("SubtypeID", typeof (int))
      {
        DefaultValue = 0
      });
      dt.Columns.Add(new DataColumn("CostTableID", typeof (int))
      {
        DefaultValue = 0
      });
      dt.Columns.Add(new DataColumn("CostValueID", typeof (int))
      {
        DefaultValue = 0
      });
      dt.Columns.Add(new DataColumn("Param1ID", typeof (int))
      {
        DefaultValue = -1
      });
      dt.Columns.Add(new DataColumn("Param1ValueID", typeof (int)));
      dt.Columns.Add(new DataColumn("Param2ID", typeof (int))
      {
        DefaultValue = -1
      });
      dt.Columns.Add(new DataColumn("Param2ValueID", typeof (int)));
      dt.Columns.Add(new DataColumn("UpgradeID", typeof (int))
      {
        DefaultValue = -1
      });
    }

  public void BuildDataGrid()
  {
      DView = dt.DefaultView;
      DView.AllowDelete = true;
      DView.AllowNew = true;
      DView.AllowEdit = false;
      DataGridTableStyle table = new DataGridTableStyle();
      dgProperties.TableStyles.Clear();
      table.MappingName = dt.TableName;
      table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
      DataGridTextBoxColumn column1 = new DataGridTextBoxColumn();
      column1.MappingName = "Property";
      column1.HeaderText = "Property";
      column1.NullText = "";
      table.GridColumnStyles.Add(column1);
      DataGridTextBoxColumn column2 = new DataGridTextBoxColumn();
      column2.MappingName = "Subtype";
      column2.HeaderText = "Subtype";
      column2.NullText = "";
      table.GridColumnStyles.Add(column2);
      DataGridTextBoxColumn column3 = new DataGridTextBoxColumn();
      column3.MappingName = "CostTable";
      column3.HeaderText = "CostTable";
      column3.NullText = "";
      table.GridColumnStyles.Add(column3);
      DataGridTextBoxColumn column4 = new DataGridTextBoxColumn();
      column4.MappingName = "CostValue";
      column4.HeaderText = "CostValue";
      column4.NullText = "";
      table.GridColumnStyles.Add(column4);
      DataGridTextBoxColumn column5 = new DataGridTextBoxColumn();
      column5.MappingName = "Param1";
      column5.HeaderText = "Param1";
      column5.NullText = "";
      table.GridColumnStyles.Add(column5);
      DataGridTextBoxColumn column6 = new DataGridTextBoxColumn();
      column6.MappingName = "Param1Value";
      column6.HeaderText = "Param1Value";
      column6.NullText = "";
      table.GridColumnStyles.Add(column6);
      DataGridTextBoxColumn column7 = new DataGridTextBoxColumn();
      column7.MappingName = "Param2";
      column7.HeaderText = "Param2";
      column7.NullText = "";
      table.GridColumnStyles.Add(column7);
      DataGridTextBoxColumn column8 = new DataGridTextBoxColumn();
      column8.MappingName = "Param2Value";
      column8.HeaderText = "Param2Value";
      column8.NullText = "";
      table.GridColumnStyles.Add(column8);
      DataGridTextBoxColumn column9 = new DataGridTextBoxColumn();
      column9.MappingName = "Upgrade";
      column9.HeaderText = "Upgrade";
      column9.NullText = "";
      table.GridColumnStyles.Add(column9);
      DataGridTextBoxColumn column10 = new DataGridTextBoxColumn();
      column10.MappingName = "% Chance of Appearance";
      column10.HeaderText = "% Chance of Appearance";
      column10.NullText = "";
      table.GridColumnStyles.Add(column10);
      DataGridTextBoxColumn column11 = new DataGridTextBoxColumn();
      column11.MappingName = "PropertyID";
      column11.HeaderText = "PropertyID";
      column11.NullText = "";
      column11.TextBox.ReadOnly = true;
      table.GridColumnStyles.Add(column11);
      DataGridTextBoxColumn column12 = new DataGridTextBoxColumn();
      column12.MappingName = "SubtypeID";
      column12.HeaderText = "SubtypeID";
      column12.NullText = "";
      column12.TextBox.ReadOnly = true;
      table.GridColumnStyles.Add(column12);
      DataGridTextBoxColumn column13 = new DataGridTextBoxColumn();
      column13.MappingName = "CostTableID";
      column13.HeaderText = "CostTableID";
      column13.NullText = "";
      table.GridColumnStyles.Add(column13);
      DataGridTextBoxColumn column14 = new DataGridTextBoxColumn();
      column14.MappingName = "CostValueID";
      column14.HeaderText = "CostValueID";
      column14.NullText = "";
      table.GridColumnStyles.Add(column14);
      DataGridTextBoxColumn column15 = new DataGridTextBoxColumn();
      column15.MappingName = "Param1ID";
      column15.HeaderText = "Param1ID";
      column15.NullText = "";
      table.GridColumnStyles.Add(column15);
      DataGridTextBoxColumn column16 = new DataGridTextBoxColumn();
      column16.MappingName = "Param1ValueID";
      column16.HeaderText = "Param1ValueID";
      column16.NullText = "";
      table.GridColumnStyles.Add(column16);
      DataGridTextBoxColumn column17 = new DataGridTextBoxColumn();
      column17.MappingName = "Param2ID";
      column17.HeaderText = "Param2ID";
      column17.NullText = "";
      table.GridColumnStyles.Add(column17);
      DataGridTextBoxColumn column18 = new DataGridTextBoxColumn();
      column18.MappingName = "Param2ValueID";
      column18.HeaderText = "Param2ValueID";
      column18.NullText = "";
      table.GridColumnStyles.Add(column18);
      DataGridTextBoxColumn column19 = new DataGridTextBoxColumn();
      column19.MappingName = "UpgradeID";
      column19.HeaderText = "UpgradeID";
      column19.NullText = "";
      table.GridColumnStyles.Add(column19);
      dgProperties.TableStyles.Add(table);
      dgProperties.SetDataBinding(DView, null);
      dgProperties.CaptionVisible = false;
    }

  public void AutoSizeColumns()
  {
      int num1 = checked (dt.Columns.Count - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        dgProperties.TableStyles[0].GridColumnStyles[num2].Width = GetColWidth(num2, dt.Columns[num2].Caption);
        checked { ++num2; }
      }
    }

  protected int GetColWidth(int col, string DisplayName)
  {
      int count = ((DataView) dgProperties.DataSource).Count;
      Graphics graphics = Graphics.FromHwnd(Handle);
      StringFormat format = new StringFormat(StringFormat.GenericTypographic);
      float num1 = graphics.MeasureString(DisplayName, Font, 500, format).Width;
      try
      {
        int num2 = checked (count - 1);
        int rowIndex = 0;
        while (rowIndex <= num2)
        {
          SizeF sizeF = graphics.MeasureString(dgProperties[rowIndex, col].ToString(), Font, 500, format);
          if (sizeF.Width > (double) num1)
            num1 = sizeF.Width;
          checked { ++rowIndex; }
        }
        graphics.Dispose();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        num1 = 75f;
        ProjectData.ClearProjectError();
      }
      return checked ((int) Math.Round(num1 + 10f));
    }

  private void ReadPropsAndLoadGrid()
  {
      if (!UTI.VerifyNodeExists("PropertiesList"))
        return;
      int listItemCount = UTI.GetListItemCount("PropertiesList");
      if (listItemCount > 0)
        Load2DAs();
      int num1 = checked (listItemCount - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        DataRow row = dt.NewRow();
        int int32_1 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(num2) + ").PropertyName")));
        row["PropertyID"] = int32_1;
        string str1 = g_clsDialogTlk.GetString(IntegerType.FromString(itempropdef.GetIndiceData(int32_1, "name")));
        row["Property"] = str1;
        string indiceData1 = itempropdef.GetIndiceData(int32_1, "subtyperesref");
        if (StringType.StrCmp(indiceData1, "****", false) != 0)
        {
          int int32_2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(num2) + ").Subtype")));
          row["SubtypeID"] = int32_2;
          object obj = StringType.StrCmp(indiceData1, "Appearance", false) != 0 ? GetCls2DA(indiceData1).GetIndiceData(int32_2, "name") : (object) GetCls2DA(indiceData1).GetIndiceData(int32_2, "label");
          string str2 = !Information.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) ? (!obj.GetType().Name.EndsWith("String") ? "Error: Unknown type" : obj.ToString()) : g_clsDialogTlk.GetString(IntegerType.FromObject(obj));
          row["Subtype"] = str2;
        }
        int rowNumber1 = IntegerType.FromObject(UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(num2) + ").CostTable"));
        row["CostTableID"] = rowNumber1;
        string indiceData2 = iprp_costtable.GetIndiceData(rowNumber1, "label");
        row["CostTable"] = indiceData2;
        string indiceData3 = iprp_costtable.GetIndiceData(rowNumber1, "name");
        int rowNumber2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(num2) + ").CostValue")));
        row["CostValueID"] = rowNumber2;
        if (StringType.StrCmp(indiceData3, "IPRP_BASE1", false) != 0)
        {
          indiceData3 = g_clsDialogTlk.GetString(IntegerType.FromString(ReadCls2DA(indiceData3).GetIndiceData(rowNumber2, "name")));
          row["CostValue"] = indiceData3;
        }
        else
          row["CostValue"] = "n/a";
        object objectValue1 = RuntimeHelpers.GetObjectValue(UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(num2) + ").Param1"));
        if (objectValue1 == null || ObjectType.ObjTst(objectValue1, (int) byte.MaxValue, false) == 0)
        {
          row["Param1"] = "n/a";
          if (ObjectType.ObjTst(objectValue1, (int) byte.MaxValue, false) == 0)
            row["Param1ID"] = RuntimeHelpers.GetObjectValue(objectValue1);
          object objectValue2 = RuntimeHelpers.GetObjectValue(UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(num2) + ").Param1Value"));
          if (objectValue2 == null)
          {
            row["Param1Value"] = "n/a";
            row["Param1ValueID"] = -1;
          }
          else
            row["Param1ValueID"] = RuntimeHelpers.GetObjectValue(objectValue2);
        }
        else
        {
          rowNumber2 = IntegerType.FromObject(objectValue1);
          row["Param1ID"] = rowNumber2;
          string str3 = g_clsDialogTlk.GetString(IntegerType.FromString(iprp_paramtable.GetIndiceData(rowNumber2, "name")));
          row["Param1"] = str3;
          indiceData3 = iprp_paramtable.GetIndiceData(rowNumber2, "tableresref");
          object objectValue3 = RuntimeHelpers.GetObjectValue(UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(num2) + ").Param1Value"));
          if (objectValue3 == null)
          {
            row["Param1Value"] = "n/a";
          }
          else
          {
            rowNumber2 = IntegerType.FromObject(objectValue3);
            row["Param1ValueID"] = rowNumber2;
            indiceData3 = g_clsDialogTlk.GetString(IntegerType.FromString(ReadCls2DA(indiceData3).GetIndiceData(rowNumber2, "name")));
            row["Param1Value"] = indiceData3;
          }
        }
        object objectValue4 = RuntimeHelpers.GetObjectValue(UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(num2) + ").Param2"));
        if (objectValue4 == null || ObjectType.ObjTst(objectValue4, (int) byte.MaxValue, false) == 0)
        {
          row["Param2"] = "n/a";
          if (ObjectType.ObjTst(objectValue4, (int) byte.MaxValue, false) == 0)
            row["Param2ID"] = RuntimeHelpers.GetObjectValue(objectValue4);
          object objectValue5 = RuntimeHelpers.GetObjectValue(UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(num2) + ").Param2Value"));
          if (objectValue5 == null)
          {
            row["Param2Value"] = "n/a";
            row["Param2ValueID"] = -1;
          }
          else
          {
            row["Param2ValueID"] = RuntimeHelpers.GetObjectValue(objectValue5);
            row["Param2ValueID"] = rowNumber2;
            string str4 = g_clsDialogTlk.GetString(IntegerType.FromString(ReadCls2DA(indiceData3).GetIndiceData(rowNumber2, "name")));
            row["Param2Value"] = str4;
          }
        }
        else
        {
          int rowNumber3 = IntegerType.FromObject(objectValue4);
          row["Param2ID"] = rowNumber3;
          string str5 = g_clsDialogTlk.GetString(IntegerType.FromString(iprp_paramtable.GetIndiceData(rowNumber3, "name")));
          row["Param2"] = str5;
          string indiceData4 = iprp_paramtable.GetIndiceData(rowNumber3, "tableresref");
          object objectValue6 = RuntimeHelpers.GetObjectValue(UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(num2) + ").Param2Value"));
          if (objectValue6 == null)
          {
            row["Param2Value"] = "n/a";
          }
          else
          {
            int rowNumber4 = IntegerType.FromObject(objectValue6);
            row["Param2ValueID"] = rowNumber4;
            string str6 = g_clsDialogTlk.GetString(IntegerType.FromString(ReadCls2DA(indiceData4).GetIndiceData(rowNumber4, "name")));
            row["Param2Value"] = str6;
          }
        }
        if (UTI.VerifyNodeExists("PropertiesList(" + StringType.FromInteger(num2) + ").UpgradeType"))
        {
          int rowNumber5 = IntegerType.FromObject(UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(num2) + ").UpgradeType"));
          row["UpgradeID"] = rowNumber5;
          row["Upgrade"] = Strings.Replace(ReadCls2DA("Upgrade").GetIndiceData(rowNumber5, "label"), "_", " ");
        }
        else
        {
          row["UpgradeID"] = -1;
          row["Upgrade"] = "n/a";
        }
        object objectValue7 = RuntimeHelpers.GetObjectValue(UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(num2) + ").ChanceAppear"));
        row["% Chance of Appearance"] = objectValue7 != null ? RuntimeHelpers.GetObjectValue(objectValue7) : "n/a";
        dt.Rows.Add(row);
        checked { ++num2; }
      }
      AutoSizeColumns();
    }

  private void dgProperties_DoubleClick(object sender, EventArgs e)
  {
      Cursor current = Cursor.Current;
      DataGrid dataGrid = (DataGrid) sender;
      DataGrid.HitTestInfo hitTestInfo = dataGrid.HitTest(dataGrid.PointToClient(MousePosition).X, dataGrid.PointToClient(MousePosition).Y);
      if (hitTestInfo.Type == DataGrid.HitTestType.RowHeader)
      {
        frmItemPropertyEditor itemPropertyEditor = new frmItemPropertyEditor(KotorVersionIndex);
        if (IsLastRow(hitTestInfo.Row))
        {
          itemPropertyEditor.btnOK.Text = "Add";
          int num = (int) itemPropertyEditor.ShowDialog(this);
          //Application.DoEvents();
          if (itemPropertyEditor.DialogResult == DialogResult.OK)
          {
            DataRow row = dt.NewRow();
            row["Property"] = RuntimeHelpers.GetObjectValue(itemPropertyEditor.cmbxPropertyName.SelectedItem);
            row["Subtype"] = RuntimeHelpers.GetObjectValue(itemPropertyEditor.cmbxSubtype.SelectedItem);
            row["CostTable"] = itemPropertyEditor.CostTableName;
            if (!itemPropertyEditor.cmbxParam1Value.Enabled)
            {
              row["Param1"] = "n/a";
              row["Param1ID"] = (int) byte.MaxValue;
              row["Param1Value"] = "(none)";
              row["Param1ValueID"] = 0;
            }
            else
            {
              row["Param1"] = itemPropertyEditor.Param1Desc;
              row["Param1ID"] = IntegerType.FromString(itemPropertyEditor.tbParam1resref.Text);
              row["Param1Value"] = RuntimeHelpers.GetObjectValue(itemPropertyEditor.cmbxParam1Value.SelectedItem);
              row["Param1ValueID"] = itemPropertyEditor.cmbxParam1Value.SelectedIndex;
            }
            if (!itemPropertyEditor.cmbxParam2Value.Enabled)
            {
              row["Param2"] = "n/a";
              row["Param2ID"] = -1;
              row["Param2Value"] = "(none)";
              row["Param2ValueID"] = -1;
            }
            else
            {
              row["Param2"] = itemPropertyEditor.Param2Desc;
              row["Param2ID"] = IntegerType.FromString(itemPropertyEditor.tbParam2resref.Text);
              row["Param2Value"] = RuntimeHelpers.GetObjectValue(itemPropertyEditor.cmbxParam2Value.SelectedItem);
              row["Param2ValueID"] = itemPropertyEditor.cmbxParam2Value.SelectedIndex;
            }
            if (itemPropertyEditor.cmbxUpgrade.SelectedIndex > 0)
            {
              row["UpgradeID"] = checked (itemPropertyEditor.cmbxUpgrade.SelectedIndex - 1);
              row["Upgrade"] = RuntimeHelpers.GetObjectValue(itemPropertyEditor.cmbxUpgrade.SelectedItem);
            }
            row["PropertyID"] = itemPropertyEditor.cmbxPropertyName.SelectedIndex;
            row["SubtypeID"] = itemPropertyEditor.cmbxSubtype.Enabled ? itemPropertyEditor.cmbxSubtype.SelectedIndex : (object) 0;
            row["CostTableID"] = StringType.StrCmp(itemPropertyEditor.CostTableID, "****", false) != 0 ? itemPropertyEditor.CostTableID : (object) 0;
            if ((!itemPropertyEditor.cmbxSubtype.Enabled | StringType.StrCmp(itemPropertyEditor.CostTableID, "****", false) == 0) & !itemPropertyEditor.cmbxCostValue.Enabled)
            {
              row["CostValue"] = 0;
              row["CostValueID"] = 0;
            }
            else if (itemPropertyEditor.cmbxSubtype.Enabled & !itemPropertyEditor.cmbxCostValue.Enabled)
            {
              row["CostValue"] = RuntimeHelpers.GetObjectValue(itemPropertyEditor.cmbxSubtype.SelectedItem);
              row["CostValueID"] = itemPropertyEditor.cmbxSubtype.SelectedIndex;
            }
            else
            {
              row["CostValue"] = RuntimeHelpers.GetObjectValue(itemPropertyEditor.cmbxCostValue.SelectedItem);
              row["CostValueID"] = itemPropertyEditor.cmbxCostValue.SelectedIndex;
            }
            row["% Chance of Appearance"] = itemPropertyEditor.nudPercentChance.Value;
            dt.Rows.Add(row);
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Current = current;
          }
        }
        else
        {
          itemPropertyEditor.btnOK.Text = "Update";
          DataRow row = dt.DefaultView[hitTestInfo.Row].Row;
          itemPropertyEditor.cmbxPropertyName.SelectedIndex = IntegerType.FromObject(row["PropertyID"]);
          if (itemPropertyEditor.cmbxSubtype.Items.Count > 0)
            itemPropertyEditor.cmbxSubtype.SelectedIndex = IntegerType.FromObject(row["SubtypeID"]);
          if (itemPropertyEditor.cmbxCostValue.Items.Count > 0)
            itemPropertyEditor.cmbxCostValue.SelectedIndex = IntegerType.FromObject(row["CostValueID"]);
          if (IntegerType.FromObject(row["Param1ID"]) != byte.MaxValue)
            itemPropertyEditor.cmbxParam1Value.SelectedIndex = IntegerType.FromObject(row["Param1ValueID"]);
          if (IntegerType.FromObject(row["Param2ID"]) != -1)
            itemPropertyEditor.cmbxParam2Value.SelectedIndex = IntegerType.FromObject(row["Param2ValueID"]);
          if (IntegerType.FromObject(row["UpgradeID"]) != -1)
            itemPropertyEditor.cmbxUpgrade.SelectedIndex = checked (IntegerType.FromObject(row["UpgradeID"]) + 1);
          dataGrid.UnSelect(checked (dataGrid.CurrentRowIndex + 1));
          int num = (int) itemPropertyEditor.ShowDialog(this);
          //Application.DoEvents();
          if (itemPropertyEditor.DialogResult == DialogResult.OK)
          {
            SetDataTableReadOnlyState(false);
            row["Property"] = RuntimeHelpers.GetObjectValue(itemPropertyEditor.cmbxPropertyName.SelectedItem);
            row["Subtype"] = RuntimeHelpers.GetObjectValue(itemPropertyEditor.cmbxSubtype.SelectedItem);
            row["CostTable"] = itemPropertyEditor.CostTableName;
            if (!itemPropertyEditor.cmbxParam1Value.Enabled)
            {
              row["Param1"] = "n/a";
              row["Param1ID"] = (int) byte.MaxValue;
              row["Param1Value"] = "(none)";
              row["Param1ValueID"] = 0;
            }
            else
            {
              row["Param1"] = itemPropertyEditor.Param1Desc;
              row["Param1ID"] = IntegerType.FromString(itemPropertyEditor.tbParam1resref.Text);
              row["Param1Value"] = RuntimeHelpers.GetObjectValue(itemPropertyEditor.cmbxParam1Value.SelectedItem);
              row["Param1ValueID"] = itemPropertyEditor.cmbxParam1Value.SelectedIndex;
            }
            if (!itemPropertyEditor.cmbxParam2Value.Enabled)
            {
              row["Param2"] = "n/a";
              row["Param2ID"] = -1;
              row["Param2Value"] = "(none)";
              row["Param2ValueID"] = -1;
            }
            else
            {
              row["Param2"] = itemPropertyEditor.Param2Desc;
              row["Param2ID"] = IntegerType.FromString(itemPropertyEditor.tbParam2resref.Text);
              row["Param2Value"] = RuntimeHelpers.GetObjectValue(itemPropertyEditor.cmbxParam2Value.SelectedItem);
              row["Param2ValueID"] = itemPropertyEditor.cmbxParam2Value.SelectedIndex;
            }
            if (itemPropertyEditor.cmbxUpgrade.SelectedIndex > 0)
            {
              row["UpgradeID"] = checked (itemPropertyEditor.cmbxUpgrade.SelectedIndex - 1);
              row["Upgrade"] = Strings.Replace(StringType.FromObject(itemPropertyEditor.cmbxUpgrade.SelectedItem), "_", " ");
            }
            else
            {
              row["UpgradeID"] = -1;
              row["Upgrade"] = "n/a";
            }
            row["PropertyID"] = itemPropertyEditor.cmbxPropertyName.SelectedIndex;
            row["SubtypeID"] = itemPropertyEditor.cmbxSubtype.Enabled ? itemPropertyEditor.cmbxSubtype.SelectedIndex : (object) 0;
            row["CostTableID"] = StringType.StrCmp(itemPropertyEditor.CostTableID, "****", false) != 0 ? itemPropertyEditor.CostTableID : (object) 0;
            if ((!itemPropertyEditor.cmbxSubtype.Enabled | StringType.StrCmp(itemPropertyEditor.CostTableID, "****", false) == 0) & !itemPropertyEditor.cmbxCostValue.Enabled)
            {
              row["CostValue"] = 0;
              row["CostValueID"] = 0;
            }
            else if (itemPropertyEditor.cmbxSubtype.Enabled & !itemPropertyEditor.cmbxCostValue.Enabled)
            {
              row["CostValue"] = RuntimeHelpers.GetObjectValue(itemPropertyEditor.cmbxSubtype.SelectedItem);
              row["CostValueID"] = itemPropertyEditor.cmbxSubtype.SelectedIndex;
            }
            else
            {
              row["CostValue"] = RuntimeHelpers.GetObjectValue(itemPropertyEditor.cmbxCostValue.SelectedItem);
              row["CostValueID"] = itemPropertyEditor.cmbxCostValue.SelectedIndex;
            }
            row["% Chance of Appearance"] = itemPropertyEditor.nudPercentChance.Value;
            SetDataTableReadOnlyState(true);
            dataGrid.Select(hitTestInfo.Row);
          }
        }
      }
      AutoSizeColumns();
    }

  protected bool IsLastRow(int row)
  {
      bool flag;
      try
      {
        dgProperties.Select(checked (row + 1));
        dgProperties.UnSelect(checked (row + 1));
        flag = false;
      }
      catch (IndexOutOfRangeException ex)
      {
        ProjectData.SetProjectError(ex);
        flag = true;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

  protected void SetDataTableReadOnlyState(bool ReadOnlyState)
  {
      int num = checked (dt.Columns.Count - 1);
      int index = 0;
      while (index <= num)
      {
        dt.Columns[index].ReadOnly = ReadOnlyState;
        checked { ++index; }
      }
    }

  private void btnCancel_Click(object sender, EventArgs e) => Close();

  private void frmUTI_Editor_Load(object sender, EventArgs e) => PositionWindow(Name);

  private void frmUTI_Editor_Closing(object sender, CancelEventArgs e) => SaveSettings(Name);

  public void SetFormName(string Name) => Text = "Item Editor - " + Name;

  private void btnSave_Click(object sender, EventArgs e)
  {
      SetGFFNodeValues();
      if (!m_bSaveGameMode)
      {
        MEditingFilePath = StringType.FromObject(FrmMain.GetFilePath("save", CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(MEditingFilePath) + ".uti", "", ""));
        if (StringType.StrCmp(MEditingFilePath, "", false) == 0)
          return;
      }
      UTI.WriteFile(MEditingFilePath, "UTI");
      if (!m_bSaveGameMode)
        return;
      Close();
    }

  private void btnDebug_Click(object sender, EventArgs e)
  {
      frmTextEditor frmTextEditor = new frmTextEditor();
      frmTextEditor.Filename = tbTag.Text;
      frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
      frmTextEditor.RTFMode = true;
      frmTextEditor.tbGeneric.Rtf = UTI.ToString();
      frmTextEditor.tbGeneric.SelectionLength = 0;
      frmTextEditor.Show();
    }

  private void btnLoadXML_Click(object sender, EventArgs e)
  {
      string str = StringType.FromObject(FrmMain.GetFilePath("load", CurrentSettings.defaultImportLocation, "", "Load Properties (XML) file...", "xml"));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      DataSet dataSet = new DataSet("Kotor_ItemProperties_File");
      int num = (int) dataSet.ReadXml(str);
      dt = dataSet.Tables[0];
      dataSet.Tables.Remove(dt);
      dataSet.Dispose();
      DView = dt.DefaultView;
      dgProperties.SetDataBinding(DView, null);
      BuildDataGrid();
      AutoSizeColumns();
    }

  private void btnSaveXML_Click(object sender, EventArgs e)
  {
      string str = StringType.FromObject(FrmMain.GetFilePath("save", CurrentSettings.defaultSaveLocation, tbTemplateResRef.Text + ".xml", "Save Properties (XML) file...", "xml"));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      DataSet dataSet = new DataSet("Kotor_ItemProperties_File");
      dataSet.Tables.Add(dt);
      dataSet.WriteXml(str);
      dataSet.Tables.Remove(dt);
      dataSet.Dispose();
    }

  private void btnSetUnidentDescLang_Click(object sender, EventArgs e)
  {
      frmCExoLocStringLanguagePicker stringLanguagePicker = new frmCExoLocStringLanguagePicker(UnidentDescLang);
      if (stringLanguagePicker.ShowDialog(this) != DialogResult.OK)
        return;
      UnidentDescLang = stringLanguagePicker.LanguageID;
    }

  private void btnSetIdentDescLang_Click(object sender, EventArgs e)
  {
      frmCExoLocStringLanguagePicker stringLanguagePicker = new frmCExoLocStringLanguagePicker(IdentDescLang);
      if (stringLanguagePicker.ShowDialog(this) != DialogResult.OK)
        return;
      IdentDescLang = stringLanguagePicker.LanguageID;
    }
}