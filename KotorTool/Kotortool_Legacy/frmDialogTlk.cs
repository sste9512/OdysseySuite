// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmDialogTlk
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

public class frmDialogTlk : frmParent
{
  [AccessedThroughProperty("ToolStripMenuItem3")]
  private ToolStripMenuItem _ToolStripMenuItem3;
  [AccessedThroughProperty("miOpenExternal")]
  private ToolStripMenuItem _miOpenExternal;
  [AccessedThroughProperty("ToolStripMenuItem5")]
  private ToolStripMenuItem _ToolStripMenuItem5;
  [AccessedThroughProperty("miOpenK1")]
  private ToolStripMenuItem _miOpenK1;
  [AccessedThroughProperty("miQuit")]
  private ToolStripMenuItem _miQuit;
  [AccessedThroughProperty("btnApplyChanges")]
  private Button _btnApplyChanges;
  [AccessedThroughProperty("tbSoundResRef")]
  private TextBox _tbSoundResRef;
  [AccessedThroughProperty("miSaveAsXML")]
  private ToolStripMenuItem _miSaveAsXML;
  [AccessedThroughProperty("Panel1")]
  private Panel _Panel1;
  [AccessedThroughProperty("dgDialogTlk")]
  private DataGrid _dgDialogTlk;
  [AccessedThroughProperty("MainMenu1")]
  private MainMenu _MainMenu1;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("tbString")]
  private TextBox _tbString;
  [AccessedThroughProperty("ToolStripMenuItem1")]
  private ToolStripMenuItem _ToolStripMenuItem1;
  [AccessedThroughProperty("miSave")]
  private ToolStripMenuItem _miSave;
  [AccessedThroughProperty("miOpenK2")]
  private ToolStripMenuItem _miOpenK2;
  [AccessedThroughProperty("btnFilter")]
  private Button _btnFilter;
  [AccessedThroughProperty("nudEntryNumber")]
  private NumericUpDown _nudEntryNumber;
  [AccessedThroughProperty("btnGoToEntry")]
  private Button _btnGoToEntry;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  private IContainer components;
  private DataTable dt;
  private DataView DView;
  private RowFilter RF;
  private clsDialogTlk g_dialogtlk;
  private string g_currentFilePath;
  private int g_currentRow;
  private bool g_useApplyBtn;

  public frmDialogTlk()
  {
      Load += new EventHandler(frmDialogTlk_Load);
      dt = new DataTable();
      g_currentRow = -1;
      g_useApplyBtn = true;
      InitializeComponent();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual Panel Panel1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Panel1 == null)
          ;
        _Panel1 = value;
        if (_Panel1 == null)
          ;
      }
    get => _Panel1;
  }

  internal virtual DataGrid dgDialogTlk
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_dgDialogTlk != null)
        {
          _dgDialogTlk.CurrentCellChanged -= new EventHandler(dgDialogTlk_CurrentCellChanged);
          _dgDialogTlk.Click -= new EventHandler(dgDialogTlk_Click);
        }
        _dgDialogTlk = value;
        if (_dgDialogTlk == null)
          return;
        _dgDialogTlk.CurrentCellChanged += new EventHandler(dgDialogTlk_CurrentCellChanged);
        _dgDialogTlk.Click += new EventHandler(dgDialogTlk_Click);
      }
    get => _dgDialogTlk;
  }

  internal virtual TextBox tbString
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbString == null)
          ;
        _tbString = value;
        if (_tbString == null)
          ;
      }
    get => _tbString;
  }

  internal virtual NumericUpDown nudEntryNumber
  {
    get => _nudEntryNumber;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudEntryNumber != null)
          _nudEntryNumber.KeyUp -= new KeyEventHandler(nudEntryNumber_KeyUp);
        _nudEntryNumber = value;
        if (_nudEntryNumber == null)
          return;
        _nudEntryNumber.KeyUp += new KeyEventHandler(nudEntryNumber_KeyUp);
      }
  }

  internal virtual Button btnGoToEntry
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnGoToEntry != null)
          _btnGoToEntry.Click -= new EventHandler(btnGoToEntry_Click);
        _btnGoToEntry = value;
        if (_btnGoToEntry == null)
          return;
        _btnGoToEntry.Click += new EventHandler(btnGoToEntry_Click);
      }
    get => _btnGoToEntry;
  }

  internal virtual Button btnFilter
  {
    get => _btnFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnFilter != null)
          _btnFilter.Click -= new EventHandler(btnFilter_Click);
        _btnFilter = value;
        if (_btnFilter == null)
          return;
        _btnFilter.Click += new EventHandler(btnFilter_Click);
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

  internal virtual ToolStripMenuItem miOpenExternal
  {
    get => _miOpenExternal;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miOpenExternal != null)
          _miOpenExternal.Click -= new EventHandler(miOpenExternal_Click);
        _miOpenExternal = value;
        if (_miOpenExternal == null)
          return;
        _miOpenExternal.Click += new EventHandler(miOpenExternal_Click);
      }
  }

  internal virtual ToolStripMenuItem miOpenK1
  {
    get => _miOpenK1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miOpenK1 != null)
          _miOpenK1.Click -= new EventHandler(miOpenK1_Click);
        _miOpenK1 = value;
        if (_miOpenK1 == null)
          return;
        _miOpenK1.Click += new EventHandler(miOpenK1_Click);
      }
  }

  internal virtual ToolStripMenuItem miOpenK2
  {
    get => _miOpenK2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miOpenK2 != null)
          _miOpenK2.Click -= new EventHandler(miOpenK2_Click);
        _miOpenK2 = value;
        if (_miOpenK2 == null)
          return;
        _miOpenK2.Click += new EventHandler(miOpenK2_Click);
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem5
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem5 == null)
          ;
        _ToolStripMenuItem5 = value;
        if (_ToolStripMenuItem5 == null)
          ;
      }
    get => _ToolStripMenuItem5;
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

  internal virtual ToolStripMenuItem miSaveAsXML
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miSaveAsXML != null)
          _miSaveAsXML.Click -= new EventHandler(miSaveAsXML_Click);
        _miSaveAsXML = value;
        if (_miSaveAsXML == null)
          return;
        _miSaveAsXML.Click += new EventHandler(miSaveAsXML_Click);
      }
    get => _miSaveAsXML;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem3
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem3 == null)
          ;
        _ToolStripMenuItem3 = value;
        if (_ToolStripMenuItem3 == null)
          ;
      }
    get => _ToolStripMenuItem3;
  }

  internal virtual TextBox tbSoundResRef
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbSoundResRef == null)
          ;
        _tbSoundResRef = value;
        if (_tbSoundResRef == null)
          ;
      }
    get => _tbSoundResRef;
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

  internal virtual ToolStripMenuItem miSave
  {
    get => _miSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miSave != null)
          _miSave.Click -= new EventHandler(miSave_Click);
        _miSave = value;
        if (_miSave == null)
          return;
        _miSave.Click += new EventHandler(miSave_Click);
      }
  }

  internal virtual Button btnApplyChanges
  {
    get => _btnApplyChanges;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnApplyChanges != null)
          _btnApplyChanges.Click -= new EventHandler(btnApplyChanges_Click);
        _btnApplyChanges = value;
        if (_btnApplyChanges == null)
          return;
        _btnApplyChanges.Click += new EventHandler(btnApplyChanges_Click);
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      Panel1 = new Panel();
      dgDialogTlk = new DataGrid();
      tbString = new TextBox();
      nudEntryNumber = new NumericUpDown();
      btnGoToEntry = new Button();
      btnFilter = new Button();
      MainMenu1 = new MainMenu();
      ToolStripMenuItem1 = new ToolStripMenuItem();
      miOpenExternal = new ToolStripMenuItem();
      miOpenK1 = new ToolStripMenuItem();
      miOpenK2 = new ToolStripMenuItem();
      ToolStripMenuItem3 = new ToolStripMenuItem();
      miSave = new ToolStripMenuItem();
      miSaveAsXML = new ToolStripMenuItem();
      ToolStripMenuItem5 = new ToolStripMenuItem();
      miQuit = new ToolStripMenuItem();
      this.tbSoundResRef = new TextBox();
      Label1 = new Label();
      Label3 = new Label();
      btnApplyChanges = new Button();
      Panel1.SuspendLayout();
      dgDialogTlk.BeginInit();
      nudEntryNumber.BeginInit();
      SuspendLayout();
      Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      Panel1.Controls.Add(dgDialogTlk);
      Panel panel1_1 = Panel1;
      Point point1 = new Point(16, 24);
      Point point2 = point1;
      panel1_1.Location = point2;
      Panel1.Name = "Panel1";
      Panel panel1_2 = Panel1;
      Size size1 = new Size(608, 200);
      Size size2 = size1;
      panel1_2.Size = size2;
      Panel1.TabIndex = 0;
      dgDialogTlk.CaptionFont = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
      dgDialogTlk.DataMember = "";
      dgDialogTlk.Dock = DockStyle.Fill;
      dgDialogTlk.HeaderForeColor = SystemColors.ControlText;
      DataGrid dgDialogTlk1 = dgDialogTlk;
      point1 = new Point(0, 0);
      Point point3 = point1;
      dgDialogTlk1.Location = point3;
      dgDialogTlk.Name = "dgDialogTlk";
      DataGrid dgDialogTlk2 = dgDialogTlk;
      size1 = new Size(608, 200);
      Size size3 = size1;
      dgDialogTlk2.Size = size3;
      dgDialogTlk.TabIndex = 0;
      tbString.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      tbString.Enabled = false;
      TextBox tbString1 = tbString;
      point1 = new Point(144, 248);
      Point point4 = point1;
      tbString1.Location = point4;
      tbString.Multiline = true;
      tbString.Name = "tbString";
      tbString.ScrollBars = ScrollBars.Vertical;
      TextBox tbString2 = tbString;
      size1 = new Size(480, 112);
      Size size4 = size1;
      tbString2.Size = size4;
      tbString.TabIndex = 3;
      tbString.Text = "";
      nudEntryNumber.Enabled = false;
      NumericUpDown nudEntryNumber1 = nudEntryNumber;
      point1 = new Point(160, 0);
      Point point5 = point1;
      nudEntryNumber1.Location = point5;
      nudEntryNumber.Name = "nudEntryNumber";
      NumericUpDown nudEntryNumber2 = nudEntryNumber;
      size1 = new Size(80, 20);
      Size size5 = size1;
      nudEntryNumber2.Size = size5;
      nudEntryNumber.TabIndex = 0;
      nudEntryNumber.TextAlign = HorizontalAlignment.Right;
      btnGoToEntry.Enabled = false;
      Button btnGoToEntry1 = btnGoToEntry;
      point1 = new Point(248, 0);
      Point point6 = point1;
      btnGoToEntry1.Location = point6;
      btnGoToEntry.Name = "btnGoToEntry";
      Button btnGoToEntry2 = btnGoToEntry;
      size1 = new Size(56, 23);
      Size size6 = size1;
      btnGoToEntry2.Size = size6;
      btnGoToEntry.TabIndex = 1;
      btnGoToEntry.Text = "Go";
      btnFilter.Enabled = false;
      Button btnFilter1 = btnFilter;
      point1 = new Point(360, 0);
      Point point7 = point1;
      btnFilter1.Location = point7;
      btnFilter.Name = "btnFilter";
      Button btnFilter2 = btnFilter;
      size1 = new Size(80, 23);
      Size size7 = size1;
      btnFilter2.Size = size7;
      btnFilter.TabIndex = 2;
      btnFilter.Text = "Filter Entries";
      MainMenu1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[1]
      {
        ToolStripMenuItem1
      });
      ToolStripMenuItem1.Index = 0;
      ToolStripMenuItem1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[8]
      {
        miOpenExternal,
        miOpenK1,
        miOpenK2,
        ToolStripMenuItem3,
        miSave,
        miSaveAsXML,
        ToolStripMenuItem5,
        miQuit
      });
      ToolStripMenuItem1.Text = "&File";
      miOpenExternal.Index = 0;
      miOpenExternal.Shortcut = Shortcut.CtrlO;
      miOpenExternal.Text = "&Open External Dialog.tlk";
      miOpenK1.Index = 1;
      miOpenK1.Shortcut = Shortcut.Ctrl1;
      miOpenK1.Text = "Open KotOR Dialog.tlk";
      miOpenK2.Index = 2;
      miOpenK2.Shortcut = Shortcut.Ctrl2;
      miOpenK2.Text = "Open KotOR II Dialog.tlk";
      ToolStripMenuItem3.Index = 3;
      ToolStripMenuItem3.Text = "-";
      miSave.Enabled = false;
      miSave.Index = 4;
      miSave.Shortcut = Shortcut.CtrlS;
      miSave.Text = "Save...";
      miSaveAsXML.Enabled = false;
      miSaveAsXML.Index = 5;
      miSaveAsXML.Text = "Save as XML...";
      ToolStripMenuItem5.Index = 6;
      ToolStripMenuItem5.Text = "-";
      miQuit.Index = 7;
      miQuit.Shortcut = Shortcut.CtrlQ;
      miQuit.Text = "&Quit";
      this.tbSoundResRef.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.tbSoundResRef.CharacterCasing = CharacterCasing.Lower;
      this.tbSoundResRef.Enabled = false;
      TextBox tbSoundResRef = this.tbSoundResRef;
      point1 = new Point(144, 368);
      Point point8 = point1;
      tbSoundResRef.Location = point8;
      this.tbSoundResRef.MaxLength = 16;
      this.tbSoundResRef.Name = "tbSoundResRef";
      this.tbSoundResRef.TabIndex = 4;
      this.tbSoundResRef.Text = "";
      Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Label label1_1 = Label1;
      point1 = new Point(32, 256);
      Point point9 = point1;
      label1_1.Location = point9;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(88, 16);
      Size size8 = size1;
      label1_2.Size = size8;
      Label1.TabIndex = 6;
      Label1.Text = "Dialog Text";
      Label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Label label3_1 = Label3;
      point1 = new Point(32, 370);
      Point point10 = point1;
      label3_1.Location = point10;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(96, 16);
      Size size9 = size1;
      label3_2.Size = size9;
      Label3.TabIndex = 6;
      Label3.Text = "SoundResRef";
      btnApplyChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnApplyChanges.Enabled = false;
      Button btnApplyChanges1 = btnApplyChanges;
      point1 = new Point(488, 368);
      Point point11 = point1;
      btnApplyChanges1.Location = point11;
      btnApplyChanges.Name = "btnApplyChanges";
      Button btnApplyChanges2 = btnApplyChanges;
      size1 = new Size(96, 23);
      Size size10 = size1;
      btnApplyChanges2.Size = size10;
      btnApplyChanges.TabIndex = 5;
      btnApplyChanges.Text = "Apply Changes";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(640, 401);
      ClientSize = size1;
      Controls.Add(Label1);
      Controls.Add(this.tbSoundResRef);
      Controls.Add(btnFilter);
      Controls.Add(btnGoToEntry);
      Controls.Add(nudEntryNumber);
      Controls.Add(tbString);
      Controls.Add(Panel1);
      Controls.Add(Label3);
      Controls.Add(btnApplyChanges);
      Menu = MainMenu1;
      Name = nameof (frmDialogTlk);
      Text = "Dialog.Tlk Editor";
      Panel1.ResumeLayout(false);
      dgDialogTlk.EndInit();
      nudEntryNumber.EndInit();
      ResumeLayout(false);
    }

  public frmDialogTlk(string inputpath)
    : this()
  {
      g_currentFilePath = inputpath;
      g_dialogtlk = new clsDialogTlk(g_currentFilePath, true);
    }

  private void BuildDataTable()
  {
      dt.Columns.Add(new DataColumn("index", typeof (int)));
      dt.Columns.Add(new DataColumn("Text", typeof (string))
      {
        DefaultValue = ""
      });
      dt.Columns.Add(new DataColumn("SoundRef", typeof (string))
      {
        DefaultValue = ""
      });
    }

  private void BuildDataGrid()
  {
      Panel1.SuspendLayout();
      if (Panel1.Controls.Contains(dgDialogTlk))
        Panel1.Controls.Remove(dgDialogTlk);
      dgDialogTlk = new DataGrid();
      dgDialogTlk.CaptionFont = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
      dgDialogTlk.DataMember = "";
      dgDialogTlk.Dock = DockStyle.Fill;
      dgDialogTlk.HeaderForeColor = SystemColors.ControlText;
      dgDialogTlk.Location = new Point(0, 0);
      dgDialogTlk.Name = "dgDialogTlk";
      dgDialogTlk.Size = Panel1.Size;
      dgDialogTlk.TabIndex = 0;
      Panel1.Controls.Add(dgDialogTlk);
      Panel1.ResumeLayout(false);
      DView = dt.DefaultView;
      DView.AllowDelete = true;
      DView.AllowNew = true;
      DView.AllowEdit = true;
      DataGridTableStyle table = new DataGridTableStyle();
      dgDialogTlk.TableStyles.Clear();
      table.MappingName = dt.TableName;
      table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
      DataGridEnableTextBoxColumn column1 = new DataGridEnableTextBoxColumn();
      column1.MappingName = "index";
      column1.HeaderText = "(index)";
      column1.NullText = "";
      column1.ReadOnly = true;
      table.GridColumnStyles.Add(column1);
      DataGridEnableTextBoxColumn column2 = new DataGridEnableTextBoxColumn();
      column2.MappingName = "Text";
      column2.HeaderText = "Text";
      column2.NullText = "";
      column2.Width = 350;
      column2.ReadOnly = true;
      column2.TextBox.Multiline = true;
      column2.TextBox.WordWrap = true;
      table.GridColumnStyles.Add(column2);
      DataGridEnableTextBoxColumn column3 = new DataGridEnableTextBoxColumn();
      column3.MappingName = "SoundRef";
      column3.HeaderText = "SoundRef";
      column3.TextBox.CharacterCasing = CharacterCasing.Lower;
      column3.TextBox.MaxLength = 16;
      column3.ReadOnly = true;
      column3.Width = 120;
      column3.NullText = "";
      table.GridColumnStyles.Add(column3);
      dgDialogTlk.TableStyles.Add(table);
      dgDialogTlk.SetDataBinding(DView, null);
    }

  private void LoadTableAndBuildGrid(clsDialogTlk dialogtlk)
  {
      FrmProgressMeter childForm = new FrmProgressMeter();
      g_dialogtlk = dialogtlk;
      int num1 = checked ((int) Math.Round(dialogtlk.StringCount / 10.0));
      if (num1 == 0)
        num1 = 1;
      dgDialogTlk.SetDataBinding(null, null);
      dt.Rows.Clear();
      childForm.StepAmount = 10;
      childForm.Message = "Loading";
      ((Control) childForm).Location = new utilWindowRelativePositioner(this, childForm).GetConcentric();
      childForm.Show();
      int num2 = checked (dialogtlk.StringCount - 1);
      int StringRef = 0;
      while (StringRef <= num2)
      {
        DataRow row = dt.NewRow();
        DialogTlkStrDataElement tlkStrDataElement = new DialogTlkStrDataElement();
        DialogTlkStrDataElement stringDataElement = dialogtlk.GetStringDataElement(StringRef);
        row[0] = StringRef;
        row[1] = stringDataElement.Text;
        row[2] = stringDataElement.SoundResRef;
        dt.Rows.Add(row);
        if (StringRef / (double) num1 == StringRef / num1)
        {
          childForm.StepUp();
          childForm.Status = "Entry " + StringType.FromInteger(StringRef);
        }
        checked { ++StringRef; }
      }
      childForm.Close();
      BuildDataGrid();
      nudEntryNumber.Maximum = new Decimal(checked (dialogtlk.StringCount - 1));
      nudEntryNumber.Enabled = true;
      btnFilter.Enabled = true;
      btnGoToEntry.Enabled = true;
      miSave.Enabled = true;
      miSaveAsXML.Enabled = true;
      tbSoundResRef.Enabled = false;
      tbSoundResRef.Text = "";
      tbString.Enabled = false;
      tbString.Text = "";
    }

  protected void ApplyFilter()
  {
      if (RF != null)
      {
        if (RF.active)
        {
          try
          {
            DView.RowFilter = StringType.FromObject(RF.FilterString());
            return;
          }
          catch (SyntaxErrorException ex)
          {
            ProjectData.SetProjectError(ex);
            int num = (int) Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Filter Error");
            ProjectData.ClearProjectError();
            return;
          }
          catch (EvaluateException ex)
          {
            ProjectData.SetProjectError(ex);
            int num = (int) Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Filter Error");
            ProjectData.ClearProjectError();
            return;
          }
        }
      }
      DView.RowFilter = "";
    }

  private void frmDialogTlk_Load(object sender, EventArgs e)
  {
      BuildDataTable();
      miOpenK1.Visible = FrmMain.HasKotor1();
      miOpenK2.Visible = FrmMain.HasKotor2();
      if (g_dialogtlk == null)
        return;
      LoadTableAndBuildGrid(g_dialogtlk);
      dgDialogTlk.CaptionText = g_currentFilePath;
    }

  private void dgDialogTlk_Click(object sender, EventArgs e)
  {
      DataGridCell currentCell = ((DataGrid) sender).CurrentCell;
      DataGrid.HitTestInfo hitTestInfo = dgDialogTlk.HitTest(dgDialogTlk.PointToClient(MousePosition));
      if (hitTestInfo.Type != DataGrid.HitTestType.RowHeader && hitTestInfo.Type != DataGrid.HitTestType.Cell)
        return;
      tbSoundResRef.Enabled = true;
      tbString.Enabled = true;
      if (hitTestInfo.Row == dt.Rows.Count)
        return;
      g_currentRow = hitTestInfo.Row;
      RemoveTextChangeHandlers();
      tbString.Text = Strings.Replace(StringType.FromObject(dgDialogTlk[hitTestInfo.Row, 1]), "\n", "\r\n");
      tbSoundResRef.Text = StringType.FromObject(dgDialogTlk[hitTestInfo.Row, 2]);
      tbString.Focus();
      AddTextChangeHandlers();
    }

  private void dgDialogTlk_CurrentCellChanged(object sender, EventArgs e)
  {
      RemoveTextChangeHandlers();
      if (dgDialogTlk[dgDialogTlk.CurrentCell.RowNumber, 1] != DBNull.Value)
        tbString.Text = Strings.Replace(StringType.FromObject(dgDialogTlk[dgDialogTlk.CurrentCell.RowNumber, 1]), "\n", "\r\n");
      if (dgDialogTlk[dgDialogTlk.CurrentCell.RowNumber, 2] != DBNull.Value)
        tbSoundResRef.Text = StringType.FromObject(dgDialogTlk[dgDialogTlk.CurrentCell.RowNumber, 2]);
      tbString.Focus();
      g_currentRow = dgDialogTlk.CurrentCell.RowNumber;
      tbSoundResRef.Enabled = true;
      tbString.Enabled = true;
      AddTextChangeHandlers();
    }

  private void tbString_TextChanged(object sender, EventArgs e)
  {
      btnApplyChanges.Enabled = true;
      if (g_useApplyBtn || g_currentRow != dgDialogTlk.CurrentCell.RowNumber)
        return;
      dgDialogTlk[g_currentRow, 1] = Strings.Replace(tbString.Text, "\r\n", "\n").Trim();
    }

  private void tbSoundResRef_TextChanged(object sender, EventArgs e)
  {
      btnApplyChanges.Enabled = true;
      if (g_useApplyBtn || g_currentRow != dgDialogTlk.CurrentCell.RowNumber)
        return;
      dgDialogTlk[g_currentRow, 2] = tbSoundResRef.Text.Trim();
    }

  private void btnApplyChanges_Click(object sender, EventArgs e)
  {
      if (!g_useApplyBtn || g_currentRow != dgDialogTlk.CurrentCell.RowNumber)
        return;
      dgDialogTlk.TableStyles[0].GridColumnStyles[1].ReadOnly = false;
      dgDialogTlk.TableStyles[0].GridColumnStyles[2].ReadOnly = false;
      dgDialogTlk[g_currentRow, 1] = Strings.Replace(tbString.Text, "\r\n", "\n").Trim();
      dgDialogTlk[g_currentRow, 2] = tbSoundResRef.Text.Trim();
      dgDialogTlk.TableStyles[0].GridColumnStyles[1].ReadOnly = true;
      dgDialogTlk.TableStyles[0].GridColumnStyles[2].ReadOnly = true;
      dgDialogTlk.Select(checked (g_currentRow + 1));
      dgDialogTlk.UnSelect(checked (g_currentRow + 1));
      btnApplyChanges.Enabled = false;
    }

  private void AddTextChangeHandlers()
  {
      tbString.TextChanged += new EventHandler(tbSoundResRef_TextChanged);
      tbSoundResRef.TextChanged += new EventHandler(tbSoundResRef_TextChanged);
    }

  private void RemoveTextChangeHandlers()
  {
      tbString.TextChanged -= new EventHandler(tbSoundResRef_TextChanged);
      tbSoundResRef.TextChanged -= new EventHandler(tbSoundResRef_TextChanged);
    }

  private void btnGoToEntry_Click(object sender, EventArgs e)
  {
      int int32 = Convert.ToInt32(nudEntryNumber.Value);
      if (int32 > checked (dt.Rows.Count - 1))
        return;
      dgDialogTlk.CurrentCell = new DataGridCell(int32, 0);
    }

  private void btnFilter_Click(object sender, EventArgs e)
  {
      ColumnEntryList columnEntryList = new ColumnEntryList();
      ColumnEntryList ColumnList = new ColumnEntryList();
      ColumnList.Add(new ColumnEntry("index", "(index)", typeof (int)));
      ColumnList.Add(new ColumnEntry("Text", "Text", typeof (string)));
      ColumnList.Add(new ColumnEntry("SoundRef", "SoundRef", typeof (string)));
      frmFilterDesigner frmFilterDesigner = RF != null ? new frmFilterDesigner(ColumnList, RF) : new frmFilterDesigner(ColumnList);
      int num = (int) frmFilterDesigner.ShowDialog(this);
      if (frmFilterDesigner.DialogResult == DialogResult.OK)
      {
        if (frmFilterDesigner.DialogResult == DialogResult.OK && frmFilterDesigner.RF.FilterParts.Count > 0)
        {
          RF = frmFilterDesigner.RF;
          RF.active = true;
        }
        else if (RF != null)
          RF.active = false;
      }
      ApplyFilter();
    }

  private void nudEntryNumber_KeyUp(object sender, KeyEventArgs e)
  {
      int int32 = Convert.ToInt32(nudEntryNumber.Value);
      if (int32 > checked (dt.Rows.Count - 1) | int32 < 0)
        return;
      dgDialogTlk.CurrentCell = new DataGridCell(int32, 0);
      nudEntryNumber.Focus();
    }

  private void miOpenExternal_Click(object sender, EventArgs e)
  {
      string startPath = null;
      if (FrmMain.IsOnly1KotORInstalled())
      {
        if (FrmMain.HasKotor1())
          startPath = UserSettings.GetSettings().KotorLocation(0);
        if (FrmMain.HasKotor2())
          startPath = UserSettings.GetSettings().KotorLocation(1);
      }
      else
        startPath = UserSettings.GetSettings().defaultImportLocation;
      object objectValue = RuntimeHelpers.GetObjectValue(FrmMain.GetFilePath("load", startPath, "*.tlk", "Open Dialog.Tlk file...", "tlk"));
      if (objectValue.GetType() != typeof (string))
        return;
      string path = StringType.FromObject(objectValue);
      if (!path.ToLower().EndsWith(".tlk") && Interaction.MsgBox("The file you selected does not have a .TLK extension; do you want to open it?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, "Questionable file extension") == MsgBoxResult.No)
        return;
      LoadTableAndBuildGrid(new clsDialogTlk(path, true));
      dgDialogTlk.CaptionText = path;
    }

  private void miOpenK1_Click(object sender, EventArgs e)
  {
      LoadTableAndBuildGrid(new clsDialogTlk(UserSettings.GetSettings().KotorLocation(0) + "\\dialog.tlk", true));
      dgDialogTlk.CaptionText = UserSettings.GetSettings().KotorLocation(0) + "\\dialog.tlk";
    }

  private void miOpenK2_Click(object sender, EventArgs e)
  {
      LoadTableAndBuildGrid(new clsDialogTlk(UserSettings.GetSettings().KotorLocation(1) + "\\dialog.tlk", true));
      dgDialogTlk.CaptionText = UserSettings.GetSettings().KotorLocation(1) + "\\dialog.tlk";
    }

  private void miSave_Click(object sender, EventArgs e)
  {
      string str = StringType.FromObject(FrmMain.GetFilePath("save", FrmMain.CurrentSettings.defaultSaveLocation, "Dialog.tlk", "Save Dialog.tlk file...", "xml"));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      g_dialogtlk.ClearTalkEntryList();
      try
      {
        foreach (DataRow row in (InternalDataCollectionBase) dt.Rows)
        {
          DialogTlkStrDataElement TalkEntry = new DialogTlkStrDataElement();
          if (StringType.StrCmp(row["Text"].ToString().Trim(), "", false) != 0)
          {
            TalkEntry.Text = StringType.FromObject(row["Text"]);
            TalkEntry.Flags = 1;
          }
          if (StringType.StrCmp(row["SoundRef"].ToString().Trim(), "", false) != 0)
          {
            TalkEntry.SoundResRef = StringType.FromObject(row["SoundRef"]);
            checked { TalkEntry.Flags += 2; }
          }
          if (TalkEntry.Flags == 0)
            TalkEntry.Flags = 32768;
          g_dialogtlk.AddTalkEntry(TalkEntry);
        }
      }
      finally
      {
       
      }
      g_dialogtlk.WriteListToFile(str);
      dgDialogTlk.CaptionText = str;
    }

  private void miSaveAsXML_Click(object sender, EventArgs e)
  {
      string str = StringType.FromObject(FrmMain.GetFilePath("save", FrmMain.CurrentSettings.defaultSaveLocation, "Dialog.tlk.xml", "Save Dialog.tlk XML file...", "xml"));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      DataSet dataSet = new DataSet("DialogTlkFile");
      dataSet.Tables.Add(dt);
      dataSet.WriteXml(str);
      dataSet.Tables.Remove(dt);
      dataSet.Dispose();
    }

  private void miQuit_Click(object sender, EventArgs e) => Close();
}