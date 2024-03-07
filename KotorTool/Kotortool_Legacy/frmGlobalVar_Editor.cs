// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmGlobalVar_Editor
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmGlobalVar_Editor : frmParent
{
  [AccessedThroughProperty("MainMenu1")]
  private MainMenu _MainMenu1;
  [AccessedThroughProperty("sbpString")]
  private StatusBarPanel _sbpString;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("ToolStripMenuItem2")]
  private ToolStripMenuItem _ToolStripMenuItem2;
  [AccessedThroughProperty("sbpLabel")]
  private StatusBarPanel _sbpLabel;
  [AccessedThroughProperty("dgBoolGlobals")]
  private DataGrid _dgBoolGlobals;
  [AccessedThroughProperty("dgNumericGlobals")]
  private DataGrid _dgNumericGlobals;
  [AccessedThroughProperty("TabControl1")]
  private TabControl _TabControl1;
  [AccessedThroughProperty("sbpNumeric")]
  private StatusBarPanel _sbpNumeric;
  [AccessedThroughProperty("TabPage4")]
  private TabPage _TabPage4;
  [AccessedThroughProperty("TabPage1")]
  private TabPage _TabPage1;
  [AccessedThroughProperty("dgStringGlobals")]
  private DataGrid _dgStringGlobals;
  [AccessedThroughProperty("TabPage2")]
  private TabPage _TabPage2;
  [AccessedThroughProperty("miOpenFirst")]
  private ToolStripMenuItem _miOpenFirst;
  [AccessedThroughProperty("miOpenCompare")]
  private ToolStripMenuItem _miOpenCompare;
  [AccessedThroughProperty("sbpBool")]
  private StatusBarPanel _sbpBool;
  [AccessedThroughProperty("miShowOnlyDiffs")]
  private ToolStripMenuItem _miShowOnlyDiffs;
  [AccessedThroughProperty("ToolStripMenuItem1")]
  private ToolStripMenuItem _ToolStripMenuItem1;
  [AccessedThroughProperty("lblFile1")]
  private Label _lblFile1;
  [AccessedThroughProperty("lblFile2")]
  private Label _lblFile2;
  [AccessedThroughProperty("StatusBar")]
  private StatusBar _StatusBar;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("miSave")]
  private ToolStripMenuItem _miSave;
  [AccessedThroughProperty("ToolStripMenuItem6")]
  private ToolStripMenuItem _ToolStripMenuItem6;
  [AccessedThroughProperty("miQuit")]
  private ToolStripMenuItem _miQuit;
  private IContainer components;
  public clsGlobalVars Globals;
  public clsGlobalVars Globals_Compare;
  public clsDialogTlk g_clsDialogTlk;
  public ChitinKey GChitinKey;
  private DataTable dtBool;
  private DataTable dtNumeric;
  private DataTable dtString;
  private string g_savePath;
  private bool bTablesAndGridsBuilt;
  private bool bShowOnlyDiffs;
  private byte[] BoolArray;
  private byte[] NumericArray;

  public frmGlobalVar_Editor()
  {
      Load += new EventHandler(frmGlobalVar_Editor_Load);
      Closing += new CancelEventHandler(frmGlobalVar_Editor_Closing);
      dtBool = new DataTable();
      dtNumeric = new DataTable();
      dtString = new DataTable();
      bTablesAndGridsBuilt = false;
      BoolArray = new byte[103];
      NumericArray = new byte[369];
      InitializeComponent();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual DataGrid dgBoolGlobals
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_dgBoolGlobals == null)
          ;
        _dgBoolGlobals = value;
        if (_dgBoolGlobals == null)
          ;
      }
    get => _dgBoolGlobals;
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

  internal virtual DataGrid dgNumericGlobals
  {
    get => _dgNumericGlobals;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_dgNumericGlobals != null)
          _dgNumericGlobals.CurrentCellChanged -= new EventHandler(dgNumericGlobals_CurrentCellChanged);
        _dgNumericGlobals = value;
        if (_dgNumericGlobals == null)
          return;
        _dgNumericGlobals.CurrentCellChanged += new EventHandler(dgNumericGlobals_CurrentCellChanged);
      }
  }

  internal virtual TabPage TabPage4
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPage4 == null)
          ;
        _TabPage4 = value;
        if (_TabPage4 == null)
          ;
      }
    get => _TabPage4;
  }

  internal virtual DataGrid dgStringGlobals
  {
    get => _dgStringGlobals;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_dgStringGlobals == null)
          ;
        _dgStringGlobals = value;
        if (_dgStringGlobals == null)
          ;
      }
  }

  internal virtual MainMenu MainMenu1
  {
    get => _MainMenu1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_MainMenu1 == null)
          ;
        _MainMenu1 = value;
        if (_MainMenu1 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem1
  {
    get => _ToolStripMenuItem1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem1 == null)
          ;
        _ToolStripMenuItem1 = value;
        if (_ToolStripMenuItem1 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem miOpenFirst
  {
    get => _miOpenFirst;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miOpenFirst != null)
          _miOpenFirst.Click -= new EventHandler(miOpenFirst_Click);
        _miOpenFirst = value;
        if (_miOpenFirst == null)
          return;
        _miOpenFirst.Click += new EventHandler(miOpenFirst_Click);
      }
  }

  internal virtual ToolStripMenuItem miOpenCompare
  {
    get => _miOpenCompare;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miOpenCompare != null)
          _miOpenCompare.Click -= new EventHandler(miOpenCompare_Click);
        _miOpenCompare = value;
        if (_miOpenCompare == null)
          return;
        _miOpenCompare.Click += new EventHandler(miOpenCompare_Click);
      }
  }

  internal virtual ToolStripMenuItem miSave
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miSave != null)
          _miSave.Click -= new EventHandler(miSave_Click);
        _miSave = value;
        if (_miSave == null)
          return;
        _miSave.Click += new EventHandler(miSave_Click);
      }
    get => _miSave;
  }

  internal virtual ToolStripMenuItem miQuit
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miQuit != null)
          _miQuit.Click -= new EventHandler(miQuit_Click);
        _miQuit = value;
        if (_miQuit == null)
          return;
        _miQuit.Click += new EventHandler(miQuit_Click);
      }
    get => _miQuit;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem6
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem6 == null)
          ;
        _ToolStripMenuItem6 = value;
        if (_ToolStripMenuItem6 == null)
          ;
      }
    get => _ToolStripMenuItem6;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem2
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem2 == null)
          ;
        _ToolStripMenuItem2 = value;
        if (_ToolStripMenuItem2 == null)
          ;
      }
    get => _ToolStripMenuItem2;
  }

  internal virtual ToolStripMenuItem miShowOnlyDiffs
  {
    get => _miShowOnlyDiffs;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miShowOnlyDiffs != null)
          _miShowOnlyDiffs.Click -= new EventHandler(miShowOnlyDiffs_Click);
        _miShowOnlyDiffs = value;
        if (_miShowOnlyDiffs == null)
          return;
        _miShowOnlyDiffs.Click += new EventHandler(miShowOnlyDiffs_Click);
      }
  }

  internal virtual Label lblFile1
  {
    get => _lblFile1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblFile1 == null)
          ;
        _lblFile1 = value;
        if (_lblFile1 == null)
          ;
      }
  }

  internal virtual Label lblFile2
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblFile2 == null)
          ;
        _lblFile2 = value;
        if (_lblFile2 == null)
          ;
      }
    get => _lblFile2;
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

  internal virtual StatusBar StatusBar
  {
    get => _StatusBar;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_StatusBar == null)
          ;
        _StatusBar = value;
        if (_StatusBar == null)
          ;
      }
  }

  internal virtual StatusBarPanel sbpBool
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_sbpBool == null)
          ;
        _sbpBool = value;
        if (_sbpBool == null)
          ;
      }
    get => _sbpBool;
  }

  internal virtual StatusBarPanel sbpNumeric
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_sbpNumeric == null)
          ;
        _sbpNumeric = value;
        if (_sbpNumeric == null)
          ;
      }
    get => _sbpNumeric;
  }

  internal virtual StatusBarPanel sbpString
  {
    get => _sbpString;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_sbpString == null)
          ;
        _sbpString = value;
        if (_sbpString == null)
          ;
      }
  }

  internal virtual StatusBarPanel sbpLabel
  {
    get => _sbpLabel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_sbpLabel == null)
          ;
        _sbpLabel = value;
        if (_sbpLabel == null)
          ;
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      dgBoolGlobals = new DataGrid();
      TabControl1 = new TabControl();
      TabPage1 = new TabPage();
      TabPage2 = new TabPage();
      dgNumericGlobals = new DataGrid();
      TabPage4 = new TabPage();
      dgStringGlobals = new DataGrid();
      MainMenu1 = new MainMenu();
      ToolStripMenuItem1 = new ToolStripMenuItem();
      miOpenFirst = new ToolStripMenuItem();
      miOpenCompare = new ToolStripMenuItem();
      miSave = new ToolStripMenuItem();
      ToolStripMenuItem6 = new ToolStripMenuItem();
      miQuit = new ToolStripMenuItem();
      ToolStripMenuItem2 = new ToolStripMenuItem();
      miShowOnlyDiffs = new ToolStripMenuItem();
      lblFile1 = new Label();
      lblFile2 = new Label();
      Label1 = new Label();
      Label2 = new Label();
      StatusBar = new StatusBar();
      sbpLabel = new StatusBarPanel();
      sbpBool = new StatusBarPanel();
      sbpNumeric = new StatusBarPanel();
      sbpString = new StatusBarPanel();
      dgBoolGlobals.BeginInit();
      TabControl1.SuspendLayout();
      TabPage1.SuspendLayout();
      TabPage2.SuspendLayout();
      dgNumericGlobals.BeginInit();
      TabPage4.SuspendLayout();
      dgStringGlobals.BeginInit();
      sbpLabel.BeginInit();
      sbpBool.BeginInit();
      sbpNumeric.BeginInit();
      sbpString.BeginInit();
      SuspendLayout();
      dgBoolGlobals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      dgBoolGlobals.DataMember = "";
      dgBoolGlobals.HeaderForeColor = SystemColors.ControlText;
      DataGrid dgBoolGlobals1 = dgBoolGlobals;
      Point point1 = new Point(8, 8);
      Point point2 = point1;
      dgBoolGlobals1.Location = point2;
      dgBoolGlobals.Name = "dgBoolGlobals";
      DataGrid dgBoolGlobals2 = dgBoolGlobals;
      Size size1 = new Size(408, 448);
      Size size2 = size1;
      dgBoolGlobals2.Size = size2;
      dgBoolGlobals.TabIndex = 0;
      TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TabControl1.Controls.Add(TabPage1);
      TabControl1.Controls.Add(TabPage2);
      TabControl1.Controls.Add(TabPage4);
      TabControl tabControl1_1 = TabControl1;
      point1 = new Point(8, 8);
      Point point3 = point1;
      tabControl1_1.Location = point3;
      TabControl1.Name = "TabControl1";
      TabControl1.SelectedIndex = 0;
      TabControl tabControl1_2 = TabControl1;
      size1 = new Size(432, 488);
      Size size3 = size1;
      tabControl1_2.Size = size3;
      TabControl1.TabIndex = 1;
      TabPage1.Controls.Add(dgBoolGlobals);
      TabPage tabPage1_1 = TabPage1;
      point1 = new Point(4, 22);
      Point point4 = point1;
      ((Control) tabPage1_1).Location = point4;
      TabPage1.Name = "TabPage1";
      TabPage tabPage1_2 = TabPage1;
      size1 = new Size(424, 462);
      Size size4 = size1;
      tabPage1_2.Size = size4;
      TabPage1.TabIndex = 0;
      TabPage1.Text = "Boolean Globals";
      TabPage2.Controls.Add(dgNumericGlobals);
      TabPage tabPage2_1 = TabPage2;
      point1 = new Point(4, 22);
      Point point5 = point1;
      ((Control) tabPage2_1).Location = point5;
      TabPage2.Name = "TabPage2";
      TabPage tabPage2_2 = TabPage2;
      size1 = new Size(424, 462);
      Size size5 = size1;
      tabPage2_2.Size = size5;
      TabPage2.TabIndex = 1;
      TabPage2.Text = "Numeric Globals";
      dgNumericGlobals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      dgNumericGlobals.DataMember = "";
      dgNumericGlobals.HeaderForeColor = SystemColors.ControlText;
      DataGrid dgNumericGlobals1 = dgNumericGlobals;
      point1 = new Point(8, 8);
      Point point6 = point1;
      dgNumericGlobals1.Location = point6;
      dgNumericGlobals.Name = "dgNumericGlobals";
      DataGrid dgNumericGlobals2 = dgNumericGlobals;
      size1 = new Size(408, 448);
      Size size6 = size1;
      dgNumericGlobals2.Size = size6;
      dgNumericGlobals.TabIndex = 0;
      TabPage4.Controls.Add(dgStringGlobals);
      TabPage tabPage4_1 = TabPage4;
      point1 = new Point(4, 22);
      Point point7 = point1;
      ((Control) tabPage4_1).Location = point7;
      TabPage4.Name = "TabPage4";
      TabPage tabPage4_2 = TabPage4;
      size1 = new Size(424, 462);
      Size size7 = size1;
      tabPage4_2.Size = size7;
      TabPage4.TabIndex = 3;
      TabPage4.Text = "String Globals";
      dgStringGlobals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      dgStringGlobals.DataMember = "";
      dgStringGlobals.HeaderForeColor = SystemColors.ControlText;
      DataGrid dgStringGlobals1 = dgStringGlobals;
      point1 = new Point(8, 8);
      Point point8 = point1;
      dgStringGlobals1.Location = point8;
      dgStringGlobals.Name = "dgStringGlobals";
      DataGrid dgStringGlobals2 = dgStringGlobals;
      size1 = new Size(408, 448);
      Size size8 = size1;
      dgStringGlobals2.Size = size8;
      dgStringGlobals.TabIndex = 1;
      MainMenu1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[2]
      {
        ToolStripMenuItem1,
        ToolStripMenuItem2
      });
      ToolStripMenuItem1.Index = 0;
      ToolStripMenuItem1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[5]
      {
        miOpenFirst,
        miOpenCompare,
        miSave,
        ToolStripMenuItem6,
        miQuit
      });
      ToolStripMenuItem1.Text = "&File";
      miOpenFirst.Index = 0;
      miOpenFirst.Shortcut = Shortcut.CtrlO;
      miOpenFirst.Text = "&Open...";
      miOpenCompare.Enabled = false;
      miOpenCompare.Index = 1;
      miOpenCompare.Text = "Open File to &Compare...";
      miSave.Index = 2;
      miSave.Shortcut = Shortcut.CtrlS;
      miSave.Text = "&Save";
      ToolStripMenuItem6.Index = 3;
      ToolStripMenuItem6.Text = "-";
      miQuit.Index = 4;
      miQuit.Shortcut = Shortcut.CtrlQ;
      miQuit.Text = "&Quit";
      ToolStripMenuItem2.Index = 1;
      ToolStripMenuItem2.ToolStripMenuItems.AddRange(new ToolStripMenuItem[1]
      {
        miShowOnlyDiffs
      });
      ToolStripMenuItem2.Text = "&View";
      miShowOnlyDiffs.Enabled = false;
      miShowOnlyDiffs.Index = 0;
      miShowOnlyDiffs.Text = "&Show only differences";
      lblFile1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      lblFile1.BackColor = SystemColors.ActiveCaptionText;
      lblFile1.BorderStyle = BorderStyle.Fixed3D;
      Label lblFile1_1 = lblFile1;
      point1 = new Point(72, 8);
      Point point9 = point1;
      lblFile1_1.Location = point9;
      lblFile1.Name = "lblFile1";
      Label lblFile1_2 = lblFile1;
      size1 = new Size(352, 16);
      Size size9 = size1;
      lblFile1_2.Size = size9;
      lblFile1.TabIndex = 2;
      lblFile2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      lblFile2.BackColor = SystemColors.ActiveCaptionText;
      lblFile2.BorderStyle = BorderStyle.Fixed3D;
      Label lblFile2_1 = lblFile2;
      point1 = new Point(72, 32);
      Point point10 = point1;
      lblFile2_1.Location = point10;
      lblFile2.Name = "lblFile2";
      Label lblFile2_2 = lblFile2;
      size1 = new Size(352, 16);
      Size size10 = size1;
      lblFile2_2.Size = size10;
      lblFile2.TabIndex = 2;
      Label label1_1 = Label1;
      point1 = new Point(25, 8);
      Point point11 = point1;
      label1_1.Location = point11;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(48, 16);
      Size size11 = size1;
      label1_2.Size = size11;
      Label1.TabIndex = 3;
      Label1.Text = "Viewing:";
      Label label2_1 = Label2;
      point1 = new Point(12, 32);
      Point point12 = point1;
      label2_1.Location = point12;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(64, 16);
      Size size12 = size1;
      label2_2.Size = size12;
      Label2.TabIndex = 3;
      Label2.Text = "Comparing:";
      StatusBar statusBar1 = StatusBar;
      point1 = new Point(0, 507);
      Point point13 = point1;
      statusBar1.Location = point13;
      StatusBar.Name = "StatusBar";
      StatusBar.Panels.AddRange(new StatusBarPanel[4]
      {
        sbpLabel,
        sbpBool,
        sbpNumeric,
        sbpString
      });
      StatusBar.ShowPanels = true;
      StatusBar statusBar2 = StatusBar;
      size1 = new Size(448, 22);
      Size size13 = size1;
      statusBar2.Size = size13;
      StatusBar.SizingGrip = false;
      StatusBar.TabIndex = 4;
      StatusBar.Text = "StatusBar";
      StatusBar.Visible = false;
      sbpLabel.AutoSize = StatusBarPanelAutoSize.Contents;
      sbpLabel.BorderStyle = StatusBarPanelBorderStyle.None;
      sbpLabel.Text = "Differences";
      sbpLabel.Width = 72;
      sbpBool.Alignment = HorizontalAlignment.Right;
      sbpBool.ToolTipText = "Number of differences in Boolean Globals";
      sbpBool.Width = 50;
      sbpNumeric.Alignment = HorizontalAlignment.Right;
      sbpNumeric.ToolTipText = "Number of differences in Numeric Globals";
      sbpNumeric.Width = 50;
      sbpString.Alignment = HorizontalAlignment.Right;
      sbpString.ToolTipText = "Number of differences in String Globals";
      sbpString.Width = 50;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(448, 529);
      ClientSize = size1;
      Controls.Add(StatusBar);
      Controls.Add(TabControl1);
      Controls.Add(lblFile1);
      Controls.Add(Label1);
      Controls.Add(lblFile2);
      Controls.Add(Label2);
      Menu = MainMenu1;
      Name = nameof (frmGlobalVar_Editor);
      SizeGripStyle = SizeGripStyle.Show;
      StartPosition = FormStartPosition.Manual;
      Text = "Global Variable Editor";
      dgBoolGlobals.EndInit();
      TabControl1.ResumeLayout(false);
      TabPage1.ResumeLayout(false);
      TabPage2.ResumeLayout(false);
      dgNumericGlobals.EndInit();
      TabPage4.ResumeLayout(false);
      dgStringGlobals.EndInit();
      sbpLabel.EndInit();
      sbpBool.EndInit();
      sbpNumeric.EndInit();
      sbpString.EndInit();
      ResumeLayout(false);
    }

  public frmGlobalVar_Editor(clsGlobalVars GlobalsClass, int KotorVerIndex)
    : this()
  {
      Globals = GlobalsClass;
      KotorVersionIndex = KotorVerIndex;
      BuildTablesAndGrids();
      FillGrids();
    }

  public frmGlobalVar_Editor(clsGlobalVars GlobalsClass, string filepath, int KotorVerIndex)
    : this(GlobalsClass, KotorVerIndex)
  {
      g_savePath = filepath;
      Text = "Global Variable Editor  -  " + Strings.Mid(filepath, checked (Strings.InStrRev(filepath, "\\") + 1));
      lblFile1.Text = filepath + "\\GLOBALVARS.res";
      TabControl1.Location = new Point(8, 32);
      TabControl1.Size = new Size(432, 488);
      miOpenCompare.Enabled = true;
    }

  public void FillGlobalVarArrays()
  {
      BoolArray = (byte[]) LateBinding.LateGet(Globals.GetNodeValue("ValBoolean"), null, "bytes", new object[0], null, null);
      NumericArray = (byte[]) LateBinding.LateGet(Globals.GetNodeValue("ValNumber"), null, "bytes", new object[0], null, null);
    }

  private void BuildTablesAndGrids()
  {
      BuildBoolDataTable();
      BuildBoolDataGrid();
      BuildNumericDataTable();
      BuildNumericDataGrid();
      BuildStringDataTable();
      BuildStringDataGrid();
      bTablesAndGridsBuilt = true;
    }

  private void ClearTables()
  {
      dtBool.Rows.Clear();
      dtNumeric.Rows.Clear();
      dtString.Rows.Clear();
    }

  public void FillGrids()
  {
      TabControl1.SuspendLayout();
      TabPage1.SuspendLayout();
      TabPage2.SuspendLayout();
      TabPage4.SuspendLayout();
      dgBoolGlobals.SuspendLayout();
      dgNumericGlobals.SuspendLayout();
      dgStringGlobals.SuspendLayout();
      FillGlobalVarArrays();
      int num1 = checked (Globals.GetListItemCount("CatBoolean") - 1);
      int bitnum = 0;
      while (bitnum <= num1)
      {
        DataRow row = dtBool.NewRow();
        row[0] = RuntimeHelpers.GetObjectValue(Globals.GetNodeValue("CatBoolean(" + StringType.FromInteger(bitnum) + ").Name"));
        row[1] = GetBit(bitnum, BoolArray);
        dtBool.Rows.Add(row);
        checked { ++bitnum; }
      }
      AutoSizeColumns(dgBoolGlobals, dtBool);
      int num2 = checked (Globals.GetListItemCount("CatNumber") - 1);
      int index = 0;
      while (index <= num2)
      {
        DataRow row = dtNumeric.NewRow();
        row[0] = RuntimeHelpers.GetObjectValue(Globals.GetNodeValue("CatNumber(" + StringType.FromInteger(index) + ").Name"));
        row[1] = NumericArray[index];
        dtNumeric.Rows.Add(row);
        checked { ++index; }
      }
      AutoSizeColumns(dgNumericGlobals, dtNumeric);
      int num3 = checked (Globals.GetListItemCount("CatString") - 1);
      int num4 = 0;
      while (num4 <= num3)
      {
        DataRow row = dtString.NewRow();
        row[0] = RuntimeHelpers.GetObjectValue(Globals.GetNodeValue("CatString(" + StringType.FromInteger(num4) + ").Name"));
        row[1] = RuntimeHelpers.GetObjectValue(Globals.GetNodeValue("ValString(" + StringType.FromInteger(num4) + ").String"));
        dtString.Rows.Add(row);
        checked { ++num4; }
      }
      AutoSizeColumns(dgStringGlobals, dtString);
      dgBoolGlobals.ResumeLayout();
      dgNumericGlobals.ResumeLayout();
      dgStringGlobals.ResumeLayout();
      TabPage1.ResumeLayout();
      TabPage2.ResumeLayout();
      TabPage4.ResumeLayout();
      TabControl1.ResumeLayout();
    }

  private bool GetBit(int bitnum, byte[] BooleanArray)
  {
      int index = checked ((int) Math.Round(Conversion.Int(Math.Floor(bitnum / 8.0))));
      return (BooleanArray[index] & (ulong) checked ((long) Math.Round(Math.Pow(2.0, checked (bitnum - index * 8))))) > 0UL;
    }

  private void SetBit(int bitnum, bool state, byte[] BooleanArray)
  {
      int index = checked ((int) Math.Round(Conversion.Int(Math.Floor(bitnum / 8.0))));
      byte boolean = BooleanArray[index];
      byte num1;
      if (state)
      {
        num1 = checked ((byte) (boolean | (long) Math.Round(Math.Pow(2.0, checked (bitnum - index * 8)))));
      }
      else
      {
        byte num2 = checked ((byte) Math.Round(byte.MaxValue - Math.Pow(2.0, checked (bitnum - index * 8))));
        num1 = (byte) (boolean & num2);
      }
      BooleanArray[index] = num1;
    }

  private void SetFilterState(bool active)
  {
      if (active)
      {
        StatusBar.Visible = true;
        dtBool.AcceptChanges();
        dtNumeric.AcceptChanges();
        dtString.AcceptChanges();
        ((DataView) dgBoolGlobals.DataSource).RowFilter = "Active <> Active_Compare";
        sbpBool.Text = StringType.FromInteger(((DataView) dgBoolGlobals.DataSource).Count);
        int num1 = 0;
        int num2 = checked (num1 + ((DataView) dgBoolGlobals.DataSource).Count);
        ((DataView) dgNumericGlobals.DataSource).RowFilter = "Value <> Value_Compare";
        sbpNumeric.Text = StringType.FromInteger(((DataView) dgNumericGlobals.DataSource).Count);
        int num3 = checked (num2 + ((DataView) dgNumericGlobals.DataSource).Count);
        ((DataView) dgStringGlobals.DataSource).RowFilter = "Value <> Value_Compare";
        sbpString.Text = StringType.FromInteger(((DataView) dgStringGlobals.DataSource).Count);
        if (checked (num3 + ((DataView) dgStringGlobals.DataSource).Count) != 0)
          return;
        int num4 = (int) Interaction.MsgBox("Files are identical", MsgBoxStyle.Information, "Note");
      }
      else
      {
        StatusBar.Visible = false;
        ((DataView) dgBoolGlobals.DataSource).RowFilter = "";
        ((DataView) dgNumericGlobals.DataSource).RowFilter = "";
        ((DataView) dgStringGlobals.DataSource).RowFilter = "";
      }
    }

  private void SaveFormData()
  {
      int num1 = checked (Globals.GetListItemCount("CatBoolean") - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        SetBit(num2, BooleanType.FromObject(dgBoolGlobals[num2, 1]), BoolArray);
        checked { ++num2; }
      }
      LateBinding.LateSetComplex(Globals.GetNodeValue("ValBoolean"), null, "bytes", new object[1]
      {
        BoolArray
      }, null, false, true);
      int num3 = checked (Globals.GetListItemCount("CatNumber") - 1);
      int rowIndex1 = 0;
      while (rowIndex1 <= num3)
      {
        NumericArray[rowIndex1] = ByteType.FromObject(dgNumericGlobals[rowIndex1, 1]);
        checked { ++rowIndex1; }
      }
      LateBinding.LateSetComplex(Globals.GetNodeValue("ValNumber"), null, "bytes", new object[1]
      {
        NumericArray
      }, null, false, true);
      int num4 = checked (Globals.GetListItemCount("CatString") - 1);
      int rowIndex2 = 0;
      while (rowIndex2 <= num4)
      {
        Globals.SetNodeValue("CatString(" + StringType.FromInteger(rowIndex2) + ").Name", RuntimeHelpers.GetObjectValue(dgStringGlobals[rowIndex2, 0]));
        Globals.SetNodeValue("ValString(" + StringType.FromInteger(rowIndex2) + ").String", RuntimeHelpers.GetObjectValue(dgStringGlobals[rowIndex2, 1]));
        checked { ++rowIndex2; }
      }
      if (StringType.StrCmp(g_savePath, "", false) == 0)
        g_savePath = UserSettings.GetSettings().defaultSaveLocation;
      string str = StringType.FromObject(FrmMain.GetFilePath("save", g_savePath, "GLOBALVARS.res", "Save Global Variables Table file...", "res"));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      Globals.WriteFile(str, "GVT");
    }

  public void BuildBoolDataTable()
  {
      dtBool.Columns.Add(new DataColumn("Variable", typeof (string)));
      dtBool.Columns.Add(new DataColumn("Active", typeof (bool))
      {
        DefaultValue = false
      });
      dtBool.Columns.Add(new DataColumn("Active_Compare", typeof (bool))
      {
        DefaultValue = false
      });
    }

  public void BuildBoolDataGrid()
  {
      dtBool.DefaultView.AllowDelete = false;
      dtBool.DefaultView.AllowNew = false;
      dtBool.DefaultView.AllowEdit = true;
      DataGridTableStyle table = new DataGridTableStyle();
      dgBoolGlobals.TableStyles.Clear();
      table.MappingName = dtBool.TableName;
      table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
      DataGridTextBoxColumn column1 = new DataGridTextBoxColumn();
      column1.MappingName = "Variable";
      column1.HeaderText = "Variable";
      column1.ReadOnly = true;
      table.GridColumnStyles.Add(column1);
      DataGridBoolColumn column2 = new DataGridBoolColumn();
      column2.MappingName = "Active";
      column2.HeaderText = "Active";
      column2.AllowNull = false;
      table.GridColumnStyles.Add(column2);
      DataGridBoolColumn column3 = new DataGridBoolColumn();
      column3.MappingName = "Active_Compare_off";
      column3.HeaderText = "Active (Compare)";
      column3.AllowNull = false;
      table.GridColumnStyles.Add(column3);
      dgBoolGlobals.TableStyles.Add(table);
      dgBoolGlobals.SetDataBinding(dtBool.DefaultView, null);
      dgBoolGlobals.CaptionVisible = false;
    }

  public void BuildNumericDataTable()
  {
      dtNumeric.Columns.Add(new DataColumn("Variable", typeof (string)));
      dtNumeric.Columns.Add(new DataColumn("Value", typeof (byte)));
      dtNumeric.Columns.Add(new DataColumn("Value_Compare", typeof (byte)));
    }

  public void BuildNumericDataGrid()
  {
      dtNumeric.DefaultView.AllowDelete = false;
      dtNumeric.DefaultView.AllowNew = false;
      dtNumeric.DefaultView.AllowEdit = true;
      DataGridTableStyle table = new DataGridTableStyle();
      dgNumericGlobals.TableStyles.Clear();
      table.MappingName = dtNumeric.TableName;
      table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
      DataGridTextBoxColumn column1 = new DataGridTextBoxColumn();
      column1.MappingName = "Variable";
      column1.HeaderText = "Variable";
      column1.ReadOnly = true;
      table.GridColumnStyles.Add(column1);
      DataGridTextBoxColumn column2 = new DataGridTextBoxColumn();
      column2.MappingName = "Value";
      column2.HeaderText = "Value";
      table.GridColumnStyles.Add(column2);
      DataGridTextBoxColumn column3 = new DataGridTextBoxColumn();
      column3.MappingName = "Value_Compare_off";
      column3.HeaderText = "Value (Compare)";
      table.GridColumnStyles.Add(column3);
      dgNumericGlobals.TableStyles.Add(table);
      dgNumericGlobals.SetDataBinding(dtNumeric.DefaultView, null);
      dgNumericGlobals.CaptionVisible = false;
    }

  public void BuildStringDataTable()
  {
      dtString.Columns.Add(new DataColumn("Variable", typeof (string)));
      dtString.Columns.Add(new DataColumn("Value", typeof (string)));
      dtString.Columns.Add(new DataColumn("Value_Compare", typeof (string)));
    }

  public void BuildStringDataGrid()
  {
      dtString.DefaultView.AllowDelete = false;
      dtString.DefaultView.AllowNew = false;
      dtString.DefaultView.AllowEdit = true;
      DataGridTableStyle table = new DataGridTableStyle();
      dgStringGlobals.TableStyles.Clear();
      table.MappingName = dtString.TableName;
      table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
      DataGridTextBoxColumn column1 = new DataGridTextBoxColumn();
      column1.MappingName = "Variable";
      column1.HeaderText = "Variable";
      column1.ReadOnly = true;
      table.GridColumnStyles.Add(column1);
      DataGridTextBoxColumn column2 = new DataGridTextBoxColumn();
      column2.MappingName = "Value";
      column2.HeaderText = "Value";
      table.GridColumnStyles.Add(column2);
      DataGridTextBoxColumn column3 = new DataGridTextBoxColumn();
      column3.MappingName = "Value_Compare_off";
      column3.HeaderText = "Value (Compare)";
      table.GridColumnStyles.Add(column3);
      dgStringGlobals.TableStyles.Add(table);
      dgStringGlobals.SetDataBinding(dtString.DefaultView, null);
      dgStringGlobals.CaptionVisible = false;
    }

  public void AutoSizeColumns(DataGrid dg, DataTable dt)
  {
      int num1 = checked (dt.Columns.Count - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        dg.TableStyles[0].GridColumnStyles[num2].Width = GetColWidth(dg, num2, dt.Columns[num2].Caption);
        checked { ++num2; }
      }
    }

  protected int GetColWidth(DataGrid dg, int col, string DisplayName)
  {
      int count = ((DataView) dg.DataSource).Count;
      Graphics graphics = Graphics.FromHwnd(Handle);
      StringFormat format = new StringFormat(StringFormat.GenericTypographic);
      float num1 = graphics.MeasureString(DisplayName, Font, 500, format).Width;
      try
      {
        int num2 = checked (count - 1);
        int rowIndex = 0;
        while (rowIndex <= num2)
        {
          SizeF sizeF = graphics.MeasureString(dg[rowIndex, col].ToString(), Font, 500, format);
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
      return checked ((int) Math.Round(num1 + 15f));
    }

  private void frmGlobalVar_Editor_Load(object sender, EventArgs e) => PositionWindow(Name);

  private void frmGlobalVar_Editor_Closing(object sender, CancelEventArgs e) => SaveSettings(Name);

  private void dgNumericGlobals_CurrentCellChanged(object sender, EventArgs e)
  {
      try
      {
        foreach (DataRow row in (InternalDataCollectionBase) dtNumeric.Rows)
        {
          row.EndEdit();
          bool flag1 = false;
          bool flag2 = false;
          if (row[1] == DBNull.Value)
            flag1 = true;
          if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(row[1], 0, false) < 0, ObjectType.ObjTst(row[1], (int) byte.MaxValue, false) > 0)))
            flag2 = true;
          row.ClearErrors();
          if (flag1)
            row.SetColumnError(1, "You must enter a numeric value for this item");
          if (flag2)
            row.SetColumnError(2, "You must enter a numeric value from 0-255 for this item");
        }
      }
      finally
      {
       
      }
    }

  private void miOpenFirst_Click(object sender, EventArgs e)
  {
      string str = StringType.FromObject(FrmMain.GetFilePath("load", "", "GLOBALVARS.res", "", ""));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      g_savePath = str;
      lblFile1.Text = str;
      if (!bTablesAndGridsBuilt)
        BuildTablesAndGrids();
      else
        ClearTables();
      FileStream fs = new FileStream(str, FileMode.Open);
      Globals = new clsGlobalVars(fs, KotorVersionIndex);
      fs.Close();
      FillGrids();
      if (Globals_Compare != null)
        SetFilterState(true);
      if (Globals_Compare == null)
      {
        TabControl1.Location = new Point(8, 32);
        TabControl1.Size = new Size(432, 488);
      }
      miOpenCompare.Enabled = true;
    }

  private void miOpenCompare_Click(object sender, EventArgs e)
  {
      string str = StringType.FromObject(FrmMain.GetFilePath("load", "", "GLOBALVARS.res", "", ""));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      lblFile2.Text = str;
      TabControl1.Location = new Point(8, 56);
      TabControl1.Size = new Size(432, 464);
      dgBoolGlobals.TableStyles[0].GridColumnStyles[2].MappingName = "Active_Compare";
      AutoSizeColumns(dgBoolGlobals, dtBool);
      dgNumericGlobals.TableStyles[0].GridColumnStyles[2].MappingName = "Value_Compare";
      AutoSizeColumns(dgNumericGlobals, dtNumeric);
      dgStringGlobals.TableStyles[0].GridColumnStyles[2].MappingName = "Value_Compare";
      AutoSizeColumns(dgStringGlobals, dtString);
      Globals_Compare = new clsGlobalVars(new FileStream(str, FileMode.Open), KotorVersionIndex);
      byte[] BooleanArray = (byte[]) LateBinding.LateGet(Globals_Compare.GetNodeValue("ValBoolean"), null, "bytes", new object[0], null, null);
      byte[] numArray = (byte[]) LateBinding.LateGet(Globals_Compare.GetNodeValue("ValNumber"), null, "bytes", new object[0], null, null);
      DataView dataSource1 = (DataView) dgBoolGlobals.DataSource;
      string sort1 = dataSource1.Sort;
      dataSource1.Sort = "";
      dataSource1.RowFilter = "";
      int num1 = checked (Globals_Compare.GetListItemCount("CatBoolean") - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        dtBool.DefaultView[num2].Row[2] = GetBit(num2, BooleanArray);
        checked { ++num2; }
      }
      AutoSizeColumns(dgBoolGlobals, dtBool);
      dataSource1.Sort = sort1;
      DataView dataSource2 = (DataView) dgNumericGlobals.DataSource;
      string sort2 = dataSource2.Sort;
      dataSource2.Sort = "";
      dataSource2.RowFilter = "";
      int num3 = checked (Globals_Compare.GetListItemCount("CatNumber") - 1);
      int recordIndex1 = 0;
      while (recordIndex1 <= num3)
      {
        dtNumeric.DefaultView[recordIndex1].Row[2] = numArray[recordIndex1];
        checked { ++recordIndex1; }
      }
      AutoSizeColumns(dgNumericGlobals, dtNumeric);
      dataSource2.Sort = sort2;
      DataView dataSource3 = (DataView) dgStringGlobals.DataSource;
      string sort3 = dataSource3.Sort;
      dataSource3.Sort = "";
      dataSource3.RowFilter = "";
      int num4 = checked (Globals_Compare.GetListItemCount("CatString") - 1);
      int recordIndex2 = 0;
      while (recordIndex2 <= num4)
      {
        dtString.DefaultView[recordIndex2].Row[2] = RuntimeHelpers.GetObjectValue(Globals_Compare.GetNodeValue("ValString(" + StringType.FromInteger(recordIndex2) + ").String"));
        checked { ++recordIndex2; }
      }
      AutoSizeColumns(dgStringGlobals, dtString);
      dataSource3.Sort = sort3;
      miShowOnlyDiffs.Enabled = true;
      miShowOnlyDiffs.Checked = true;
      bShowOnlyDiffs = true;
      SetFilterState(true);
    }

  private void miShowOnlyDiffs_Click(object sender, EventArgs e)
  {
      bShowOnlyDiffs = !bShowOnlyDiffs;
      miShowOnlyDiffs.Checked = bShowOnlyDiffs;
      SetFilterState(bShowOnlyDiffs);
    }

  private void miSave_Click(object sender, EventArgs e) => SaveFormData();

  private void miQuit_Click(object sender, EventArgs e) => Close();
}