// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmMapInfoStatus
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Kotortool_Legacy;

public class frmMapInfoStatus : Form
{
  [AccessedThroughProperty("dgMapInfoStatus")]
  private DataGrid _dgMapInfoStatus;
  private IContainer components;
  private DataTable dt;
  private DataView DView;
  private MapInfo Map_Info;
  private string g_mapsPath;
  private int g_totalColWidth;

  public frmMapInfoStatus()
  {
      dt = new DataTable();
      g_mapsPath = Path.Combine(StringType.FromObject(Registry.LocalMachine.OpenSubKey("software\\SCM\\Kotor Tool").GetValue("path")), "maps\\");
      InitializeComponent();
      BuildDataGrid();
      Map_Info = ReadMapInfoFile();
      ShowStatus();
      AutoSizeColumns();
      Width = checked (g_totalColWidth + 80);
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual DataGrid dgMapInfoStatus
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_dgMapInfoStatus == null)
          ;
        _dgMapInfoStatus = value;
        if (_dgMapInfoStatus == null)
          ;
      }
    get => _dgMapInfoStatus;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmMapInfoStatus));
      this.dgMapInfoStatus = new DataGrid();
      this.dgMapInfoStatus.BeginInit();
      SuspendLayout();
      this.dgMapInfoStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.dgMapInfoStatus.CaptionVisible = false;
      this.dgMapInfoStatus.DataMember = "";
      this.dgMapInfoStatus.HeaderForeColor = SystemColors.ControlText;
      this.dgMapInfoStatus.Location = new Point(8, 8);
      this.dgMapInfoStatus.Name = "dgMapInfoStatus";
      DataGrid dgMapInfoStatus = this.dgMapInfoStatus;
      Size size1 = new Size(536, 280);
      Size size2 = size1;
      dgMapInfoStatus.Size = size2;
      this.dgMapInfoStatus.TabIndex = 0;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(552, 309);
      ClientSize = size1;
      Controls.Add(this.dgMapInfoStatus);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Name = nameof (frmMapInfoStatus);
      SizeGripStyle = SizeGripStyle.Show;
      StartPosition = FormStartPosition.CenterParent;
      Text = "MapInfo Status";
      this.dgMapInfoStatus.EndInit();
      ResumeLayout(false);
    }

  public static MapInfo ReadMapInfoFile()
  {
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      Stream serializationStream1 = File.OpenRead(FrmMain.GRootPath + "MapInfo.bfd");
      MapInfo graph;
      try
      {
        graph = (MapInfo) binaryFormatter.Deserialize(serializationStream1);
        serializationStream1.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        serializationStream1.Seek(0L, SeekOrigin.Begin);
        graph = (MapInfo) CreateMapInfoFormatter(Type.GetType("kotor_tool.MapInfo")).Deserialize(serializationStream1);
        serializationStream1.Close();
        if (graph.GetType() == Type.GetType("kotor_tool.MapInfo"))
        {
          Stream serializationStream2 = File.OpenWrite(FrmMain.GRootPath + "MapInfo.bfd");
          new BinaryFormatter().Serialize(serializationStream2, graph);
          serializationStream2.Close();
        }
        else
        {
          int num = (int) Interaction.MsgBox("Unable to load MapInfo.bfd file.\n\nPlease download a fresh copy.", MsgBoxStyle.Critical, "MapInfo error");
        }
        ProjectData.ClearProjectError();
      }
      return graph;
    }

  public static BinaryFormatter CreateMapInfoFormatter(Type type) => new BinaryFormatter(new MyMapInfoSurrogate(type.Assembly), new StreamingContext(StreamingContextStates.All));

  public void ShowStatus()
  {
      try
      {
        foreach (MapInfo.Map map in Map_Info.MapList)
        {
          DataRow row = dt.NewRow();
          row[0] = map.MapName;
          row[1] = !map.S ? "Unsupported" : (!File.Exists(g_mapsPath + "map" + map.MapName + ".map") ? "File Missing" : (object) "Available");
          row[2] = !map.L ? "Unsupported" : (!File.Exists(g_mapsPath + "map" + map.MapName + "_lg.map") ? "File Missing" : (object) "Available");
          row[3] = map.ModuleName;
          row[4] = map.MapAssembler;
          row[5] = map.MapCalibrator;
          dt.Rows.Add(row);
        }
      }
      finally
      {
       
      }
    }

  public void BuildDataTable()
  {
      dt.Columns.Add(new DataColumn("Map Name", typeof (string))
      {
        DefaultValue = ""
      });
      dt.Columns.Add(new DataColumn("Small map", typeof (string))
      {
        DefaultValue = ""
      });
      dt.Columns.Add(new DataColumn("Large map", typeof (string))
      {
        DefaultValue = ""
      });
      dt.Columns.Add(new DataColumn("Module Description", typeof (string))
      {
        DefaultValue = ""
      });
      dt.Columns.Add(new DataColumn("Map Assembler", typeof (string))
      {
        DefaultValue = ""
      });
      dt.Columns.Add(new DataColumn("Map Calibrator", typeof (string))
      {
        DefaultValue = ""
      });
    }

  public void BuildDataGrid()
  {
      BuildDataTable();
      DView = dt.DefaultView;
      DView.AllowDelete = false;
      DView.AllowNew = false;
      DView.AllowEdit = false;
      DView.Sort = "Map Name ASC";
      DataGridTableStyle table = new DataGridTableStyle();
      dgMapInfoStatus.TableStyles.Clear();
      table.MappingName = dt.TableName;
      table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
      DataGridEnableTextBoxColumn column1 = new DataGridEnableTextBoxColumn();
      column1.MappingName = "Map Name";
      column1.HeaderText = "Map Name";
      column1.NullText = "";
      column1.ReadOnly = true;
      table.GridColumnStyles.Add(column1);
      DataGridEnableTextBoxColumn column2 = new DataGridEnableTextBoxColumn();
      column2.MappingName = "Small map";
      column2.HeaderText = "Small map";
      column2.NullText = "";
      column2.ReadOnly = true;
      table.GridColumnStyles.Add(column2);
      DataGridEnableTextBoxColumn column3 = new DataGridEnableTextBoxColumn();
      column3.MappingName = "Large map";
      column3.HeaderText = "Large map";
      column3.NullText = "";
      column3.ReadOnly = true;
      table.GridColumnStyles.Add(column3);
      DataGridEnableTextBoxColumn column4 = new DataGridEnableTextBoxColumn();
      column4.MappingName = "Module Description";
      column4.HeaderText = "Module Description";
      column4.NullText = "";
      table.GridColumnStyles.Add(column4);
      DataGridEnableTextBoxColumn column5 = new DataGridEnableTextBoxColumn();
      column5.MappingName = "Map Assembler";
      column5.HeaderText = "Map Assembler";
      column5.NullText = "";
      table.GridColumnStyles.Add(column5);
      DataGridEnableTextBoxColumn column6 = new DataGridEnableTextBoxColumn();
      column6.MappingName = "Map Calibrator";
      column6.HeaderText = "Map Calibrator";
      column6.NullText = "";
      table.GridColumnStyles.Add(column6);
      dgMapInfoStatus.TableStyles.Add(table);
      dgMapInfoStatus.SetDataBinding(DView, null);
      dgMapInfoStatus.CaptionText = "Map Status";
      dgMapInfoStatus.CaptionFont = new Font("Microsoft Sans Serif", 9f);
    }

  public void AutoSizeColumns()
  {
      g_totalColWidth = 0;
      int num1 = checked (dt.Columns.Count - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        int colWidth = GetColWidth(num2, dt.Columns[num2].Caption);
        dgMapInfoStatus.TableStyles[0].GridColumnStyles[num2].Width = colWidth;
        checked { g_totalColWidth += colWidth; }
        checked { ++num2; }
      }
    }

  protected int GetColWidth(int col, string DisplayName)
  {
      int count = ((DataView) dgMapInfoStatus.DataSource).Count;
      Graphics graphics = Graphics.FromHwnd(Handle);
      StringFormat format = new StringFormat(StringFormat.GenericTypographic);
      float num1 = graphics.MeasureString(DisplayName, Font, 500, format).Width;
      try
      {
        int num2 = checked (count - 1);
        int rowIndex = 0;
        while (rowIndex <= num2)
        {
          SizeF sizeF = graphics.MeasureString(dgMapInfoStatus[rowIndex, col].ToString(), Font, 500, format);
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
}