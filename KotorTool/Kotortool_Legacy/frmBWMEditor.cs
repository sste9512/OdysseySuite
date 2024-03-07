// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmBWMEditor
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmBWMEditor : frmParent
{
  [AccessedThroughProperty("miOpenAscii")]
  private ToolStripMenuItem _miOpenAscii;
  [AccessedThroughProperty("miOpenBinary")]
  private ToolStripMenuItem _miOpenBinary;
  [AccessedThroughProperty("ToolStripMenuItem4")]
  private ToolStripMenuItem _ToolStripMenuItem4;
  [AccessedThroughProperty("nudUnk4z")]
  private NumericUpDown _nudUnk4z;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("nudUnk5y")]
  private NumericUpDown _nudUnk5y;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("nudUnk4y")]
  private NumericUpDown _nudUnk4y;
  [AccessedThroughProperty("miQuit")]
  private ToolStripMenuItem _miQuit;
  [AccessedThroughProperty("nudUnk5z")]
  private NumericUpDown _nudUnk5z;
  [AccessedThroughProperty("nudUnk4x")]
  private NumericUpDown _nudUnk4x;
  [AccessedThroughProperty("nudUnk5x")]
  private NumericUpDown _nudUnk5x;
  [AccessedThroughProperty("nudUnk3z")]
  private NumericUpDown _nudUnk3z;
  [AccessedThroughProperty("nudUnk3y")]
  private NumericUpDown _nudUnk3y;
  [AccessedThroughProperty("tbFilepath")]
  private TextBox _tbFilepath;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("ToolStripMenuItem1")]
  private ToolStripMenuItem _ToolStripMenuItem1;
  [AccessedThroughProperty("nudUnk3x")]
  private NumericUpDown _nudUnk3x;
  [AccessedThroughProperty("ToolTip1")]
  private ToolTip _ToolTip1;
  [AccessedThroughProperty("MainMenu1")]
  private MainMenu _MainMenu1;
  [AccessedThroughProperty("miSaveAsBinary")]
  private ToolStripMenuItem _miSaveAsBinary;
  [AccessedThroughProperty("miSaveAsASCII")]
  private ToolStripMenuItem _miSaveAsASCII;
  [AccessedThroughProperty("lblNotSupported")]
  private Label _lblNotSupported;
  [AccessedThroughProperty("nudUnk1")]
  private NumericUpDown _nudUnk1;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("nudUnk2z")]
  private NumericUpDown _nudUnk2z;
  [AccessedThroughProperty("tbInfo")]
  private TextBox _tbInfo;
  [AccessedThroughProperty("nudUnk2x")]
  private NumericUpDown _nudUnk2x;
  [AccessedThroughProperty("nudUnk2y")]
  private NumericUpDown _nudUnk2y;
  private IContainer components;
  private ClsBwm walk;
  private string filepath;

  public frmBWMEditor() => InitializeComponent();

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual NumericUpDown nudUnk2x
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudUnk2x == null)
          ;
        _nudUnk2x = value;
        if (_nudUnk2x == null)
          ;
      }
    get => _nudUnk2x;
  }

  internal virtual NumericUpDown nudUnk2y
  {
    get => _nudUnk2y;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudUnk2y == null)
          ;
        _nudUnk2y = value;
        if (_nudUnk2y == null)
          ;
      }
  }

  internal virtual NumericUpDown nudUnk2z
  {
    get => _nudUnk2z;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudUnk2z == null)
          ;
        _nudUnk2z = value;
        if (_nudUnk2z == null)
          ;
      }
  }

  internal virtual NumericUpDown nudUnk1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudUnk1 == null)
          ;
        _nudUnk1 = value;
        if (_nudUnk1 == null)
          ;
      }
    get => _nudUnk1;
  }

  internal virtual NumericUpDown nudUnk3x
  {
    get => _nudUnk3x;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudUnk3x == null)
          ;
        _nudUnk3x = value;
        if (_nudUnk3x == null)
          ;
      }
  }

  internal virtual NumericUpDown nudUnk3y
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudUnk3y == null)
          ;
        _nudUnk3y = value;
        if (_nudUnk3y == null)
          ;
      }
    get => _nudUnk3y;
  }

  internal virtual NumericUpDown nudUnk3z
  {
    get => _nudUnk3z;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudUnk3z == null)
          ;
        _nudUnk3z = value;
        if (_nudUnk3z == null)
          ;
      }
  }

  internal virtual NumericUpDown nudUnk5x
  {
    get => _nudUnk5x;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudUnk5x == null)
          ;
        _nudUnk5x = value;
        if (_nudUnk5x == null)
          ;
      }
  }

  internal virtual NumericUpDown nudUnk4x
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudUnk4x == null)
          ;
        _nudUnk4x = value;
        if (_nudUnk4x == null)
          ;
      }
    get => _nudUnk4x;
  }

  internal virtual NumericUpDown nudUnk5z
  {
    get => _nudUnk5z;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudUnk5z == null)
          ;
        _nudUnk5z = value;
        if (_nudUnk5z == null)
          ;
      }
  }

  internal virtual NumericUpDown nudUnk4y
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudUnk4y == null)
          ;
        _nudUnk4y = value;
        if (_nudUnk4y == null)
          ;
      }
    get => _nudUnk4y;
  }

  internal virtual NumericUpDown nudUnk5y
  {
    get => _nudUnk5y;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudUnk5y == null)
          ;
        _nudUnk5y = value;
        if (_nudUnk5y == null)
          ;
      }
  }

  internal virtual NumericUpDown nudUnk4z
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudUnk4z == null)
          ;
        _nudUnk4z = value;
        if (_nudUnk4z == null)
          ;
      }
    get => _nudUnk4z;
  }

  internal virtual MainMenu MainMenu1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_MainMenu1 == null)
          ;
        _MainMenu1 = value;
        if (_MainMenu1 == null)
          ;
      }
    get => _MainMenu1;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem1 == null)
          ;
        _ToolStripMenuItem1 = value;
        if (_ToolStripMenuItem1 == null)
          ;
      }
    get => _ToolStripMenuItem1;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem4
  {
    get => _ToolStripMenuItem4;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem4 == null)
          ;
        _ToolStripMenuItem4 = value;
        if (_ToolStripMenuItem4 == null)
          ;
      }
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

  internal virtual ToolStripMenuItem miOpenBinary
  {
    get => _miOpenBinary;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miOpenBinary != null)
          _miOpenBinary.Click -= new EventHandler(miOpenBinary_Click);
        _miOpenBinary = value;
        if (_miOpenBinary == null)
          return;
        _miOpenBinary.Click += new EventHandler(miOpenBinary_Click);
      }
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

  internal virtual ToolStripMenuItem miOpenAscii
  {
    get => _miOpenAscii;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miOpenAscii != null)
          _miOpenAscii.Click -= new EventHandler(miOpenAscii_Click);
        _miOpenAscii = value;
        if (_miOpenAscii == null)
          return;
        _miOpenAscii.Click += new EventHandler(miOpenAscii_Click);
      }
  }

  internal virtual TextBox tbInfo
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbInfo == null)
          ;
        _tbInfo = value;
        if (_tbInfo == null)
          ;
      }
    get => _tbInfo;
  }

  internal virtual TextBox tbFilepath
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbFilepath == null)
          ;
        _tbFilepath = value;
        if (_tbFilepath == null)
          ;
      }
    get => _tbFilepath;
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

  internal virtual GroupBox GroupBox1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox1 == null)
          ;
        _GroupBox1 = value;
        if (_GroupBox1 == null)
          ;
      }
    get => _GroupBox1;
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

  internal virtual ToolStripMenuItem miSaveAsBinary
  {
    get => _miSaveAsBinary;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miSaveAsBinary != null)
          _miSaveAsBinary.Click -= new EventHandler(miSaveAsBinary_Click);
        _miSaveAsBinary = value;
        if (_miSaveAsBinary == null)
          return;
        _miSaveAsBinary.Click += new EventHandler(miSaveAsBinary_Click);
      }
  }

  internal virtual ToolStripMenuItem miSaveAsASCII
  {
    get => _miSaveAsASCII;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miSaveAsASCII != null)
          _miSaveAsASCII.Click -= new EventHandler(miSaveAsASCII_Click);
        _miSaveAsASCII = value;
        if (_miSaveAsASCII == null)
          return;
        _miSaveAsASCII.Click += new EventHandler(miSaveAsASCII_Click);
      }
  }

  internal virtual Label lblNotSupported
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblNotSupported == null)
          ;
        _lblNotSupported = value;
        if (_lblNotSupported == null)
          ;
      }
    get => _lblNotSupported;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      components = new Container();
      nudUnk2x = new NumericUpDown();
      nudUnk2y = new NumericUpDown();
      nudUnk2z = new NumericUpDown();
      nudUnk1 = new NumericUpDown();
      nudUnk3x = new NumericUpDown();
      nudUnk3y = new NumericUpDown();
      nudUnk3z = new NumericUpDown();
      nudUnk5x = new NumericUpDown();
      nudUnk4x = new NumericUpDown();
      nudUnk5z = new NumericUpDown();
      nudUnk4y = new NumericUpDown();
      nudUnk5y = new NumericUpDown();
      nudUnk4z = new NumericUpDown();
      MainMenu1 = new MainMenu();
      ToolStripMenuItem1 = new ToolStripMenuItem();
      miOpenBinary = new ToolStripMenuItem();
      miOpenAscii = new ToolStripMenuItem();
      miSaveAsBinary = new ToolStripMenuItem();
      miSaveAsASCII = new ToolStripMenuItem();
      ToolStripMenuItem4 = new ToolStripMenuItem();
      miQuit = new ToolStripMenuItem();
      Label1 = new Label();
      Label2 = new Label();
      Label3 = new Label();
      Label4 = new Label();
      Label5 = new Label();
      tbInfo = new TextBox();
      tbFilepath = new TextBox();
      Label6 = new Label();
      GroupBox1 = new GroupBox();
      ToolTip1 = new ToolTip(components);
      lblNotSupported = new Label();
      nudUnk2x.BeginInit();
      nudUnk2y.BeginInit();
      nudUnk2z.BeginInit();
      nudUnk1.BeginInit();
      nudUnk3x.BeginInit();
      nudUnk3y.BeginInit();
      nudUnk3z.BeginInit();
      nudUnk5x.BeginInit();
      nudUnk4x.BeginInit();
      nudUnk5z.BeginInit();
      nudUnk4y.BeginInit();
      nudUnk5y.BeginInit();
      nudUnk4z.BeginInit();
      GroupBox1.SuspendLayout();
      SuspendLayout();
      nudUnk2x.DecimalPlaces = 6;
      NumericUpDown nudUnk2x1 = nudUnk2x;
      Point point1 = new Point(96, 48);
      Point point2 = point1;
      nudUnk2x1.Location = point2;
      NumericUpDown nudUnk2x2 = nudUnk2x;
      Decimal num1 = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      nudUnk2x2.Maximum = num2;
      NumericUpDown nudUnk2x3 = nudUnk2x;
      num1 = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      Decimal num3 = num1;
      nudUnk2x3.Minimum = num3;
      nudUnk2x.Name = "nudUnk2x";
      NumericUpDown nudUnk2x4 = nudUnk2x;
      Size size1 = new Size(88, 20);
      Size size2 = size1;
      nudUnk2x4.Size = size2;
      nudUnk2x.TabIndex = 0;
      nudUnk2x.TextAlign = HorizontalAlignment.Right;
      nudUnk2y.DecimalPlaces = 6;
      NumericUpDown nudUnk2y1 = nudUnk2y;
      point1 = new Point(192, 48);
      Point point3 = point1;
      nudUnk2y1.Location = point3;
      NumericUpDown nudUnk2y2 = nudUnk2y;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num4 = num1;
      nudUnk2y2.Maximum = num4;
      NumericUpDown nudUnk2y3 = nudUnk2y;
      num1 = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      Decimal num5 = num1;
      nudUnk2y3.Minimum = num5;
      nudUnk2y.Name = "nudUnk2y";
      NumericUpDown nudUnk2y4 = nudUnk2y;
      size1 = new Size(88, 20);
      Size size3 = size1;
      nudUnk2y4.Size = size3;
      nudUnk2y.TabIndex = 0;
      nudUnk2y.TextAlign = HorizontalAlignment.Right;
      nudUnk2z.DecimalPlaces = 6;
      NumericUpDown nudUnk2z1 = nudUnk2z;
      point1 = new Point(288, 48);
      Point point4 = point1;
      nudUnk2z1.Location = point4;
      NumericUpDown nudUnk2z2 = nudUnk2z;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num6 = num1;
      nudUnk2z2.Maximum = num6;
      NumericUpDown nudUnk2z3 = nudUnk2z;
      num1 = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      Decimal num7 = num1;
      nudUnk2z3.Minimum = num7;
      nudUnk2z.Name = "nudUnk2z";
      NumericUpDown nudUnk2z4 = nudUnk2z;
      size1 = new Size(88, 20);
      Size size4 = size1;
      nudUnk2z4.Size = size4;
      nudUnk2z.TabIndex = 0;
      nudUnk2z.TextAlign = HorizontalAlignment.Right;
      nudUnk1.DecimalPlaces = 6;
      NumericUpDown nudUnk1_1 = nudUnk1;
      point1 = new Point(96, 24);
      Point point5 = point1;
      nudUnk1_1.Location = point5;
      NumericUpDown nudUnk1_2 = nudUnk1;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num8 = num1;
      nudUnk1_2.Maximum = num8;
      NumericUpDown nudUnk1_3 = nudUnk1;
      num1 = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      Decimal num9 = num1;
      nudUnk1_3.Minimum = num9;
      nudUnk1.Name = "nudUnk1";
      NumericUpDown nudUnk1_4 = nudUnk1;
      size1 = new Size(88, 20);
      Size size5 = size1;
      nudUnk1_4.Size = size5;
      nudUnk1.TabIndex = 0;
      nudUnk1.TextAlign = HorizontalAlignment.Right;
      nudUnk3x.DecimalPlaces = 6;
      NumericUpDown nudUnk3x1 = nudUnk3x;
      point1 = new Point(96, 72);
      Point point6 = point1;
      nudUnk3x1.Location = point6;
      NumericUpDown nudUnk3x2 = nudUnk3x;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num10 = num1;
      nudUnk3x2.Maximum = num10;
      NumericUpDown nudUnk3x3 = nudUnk3x;
      num1 = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      Decimal num11 = num1;
      nudUnk3x3.Minimum = num11;
      nudUnk3x.Name = "nudUnk3x";
      NumericUpDown nudUnk3x4 = nudUnk3x;
      size1 = new Size(88, 20);
      Size size6 = size1;
      nudUnk3x4.Size = size6;
      nudUnk3x.TabIndex = 3;
      nudUnk3x.TextAlign = HorizontalAlignment.Right;
      nudUnk3y.DecimalPlaces = 6;
      NumericUpDown nudUnk3y1 = nudUnk3y;
      point1 = new Point(192, 72);
      Point point7 = point1;
      nudUnk3y1.Location = point7;
      NumericUpDown nudUnk3y2 = nudUnk3y;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num12 = num1;
      nudUnk3y2.Maximum = num12;
      NumericUpDown nudUnk3y3 = nudUnk3y;
      num1 = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      Decimal num13 = num1;
      nudUnk3y3.Minimum = num13;
      nudUnk3y.Name = "nudUnk3y";
      NumericUpDown nudUnk3y4 = nudUnk3y;
      size1 = new Size(88, 20);
      Size size7 = size1;
      nudUnk3y4.Size = size7;
      nudUnk3y.TabIndex = 2;
      nudUnk3y.TextAlign = HorizontalAlignment.Right;
      nudUnk3z.DecimalPlaces = 6;
      NumericUpDown nudUnk3z1 = nudUnk3z;
      point1 = new Point(288, 72);
      Point point8 = point1;
      nudUnk3z1.Location = point8;
      NumericUpDown nudUnk3z2 = nudUnk3z;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num14 = num1;
      nudUnk3z2.Maximum = num14;
      NumericUpDown nudUnk3z3 = nudUnk3z;
      num1 = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      Decimal num15 = num1;
      nudUnk3z3.Minimum = num15;
      nudUnk3z.Name = "nudUnk3z";
      NumericUpDown nudUnk3z4 = nudUnk3z;
      size1 = new Size(88, 20);
      Size size8 = size1;
      nudUnk3z4.Size = size8;
      nudUnk3z.TabIndex = 1;
      nudUnk3z.TextAlign = HorizontalAlignment.Right;
      nudUnk5x.DecimalPlaces = 6;
      NumericUpDown nudUnk5x1 = nudUnk5x;
      point1 = new Point(96, 120);
      Point point9 = point1;
      nudUnk5x1.Location = point9;
      NumericUpDown nudUnk5x2 = nudUnk5x;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num16 = num1;
      nudUnk5x2.Maximum = num16;
      NumericUpDown nudUnk5x3 = nudUnk5x;
      num1 = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      Decimal num17 = num1;
      nudUnk5x3.Minimum = num17;
      nudUnk5x.Name = "nudUnk5x";
      NumericUpDown nudUnk5x4 = nudUnk5x;
      size1 = new Size(88, 20);
      Size size9 = size1;
      nudUnk5x4.Size = size9;
      nudUnk5x.TabIndex = 3;
      nudUnk5x.TextAlign = HorizontalAlignment.Right;
      nudUnk4x.DecimalPlaces = 6;
      NumericUpDown nudUnk4x1 = nudUnk4x;
      point1 = new Point(96, 96);
      Point point10 = point1;
      nudUnk4x1.Location = point10;
      NumericUpDown nudUnk4x2 = nudUnk4x;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num18 = num1;
      nudUnk4x2.Maximum = num18;
      NumericUpDown nudUnk4x3 = nudUnk4x;
      num1 = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      Decimal num19 = num1;
      nudUnk4x3.Minimum = num19;
      nudUnk4x.Name = "nudUnk4x";
      NumericUpDown nudUnk4x4 = nudUnk4x;
      size1 = new Size(88, 20);
      Size size10 = size1;
      nudUnk4x4.Size = size10;
      nudUnk4x.TabIndex = 0;
      nudUnk4x.TextAlign = HorizontalAlignment.Right;
      nudUnk5z.DecimalPlaces = 6;
      NumericUpDown nudUnk5z1 = nudUnk5z;
      point1 = new Point(288, 120);
      Point point11 = point1;
      nudUnk5z1.Location = point11;
      NumericUpDown nudUnk5z2 = nudUnk5z;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num20 = num1;
      nudUnk5z2.Maximum = num20;
      NumericUpDown nudUnk5z3 = nudUnk5z;
      num1 = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      Decimal num21 = num1;
      nudUnk5z3.Minimum = num21;
      nudUnk5z.Name = "nudUnk5z";
      NumericUpDown nudUnk5z4 = nudUnk5z;
      size1 = new Size(88, 20);
      Size size11 = size1;
      nudUnk5z4.Size = size11;
      nudUnk5z.TabIndex = 1;
      nudUnk5z.TextAlign = HorizontalAlignment.Right;
      nudUnk4y.DecimalPlaces = 6;
      NumericUpDown nudUnk4y1 = nudUnk4y;
      point1 = new Point(192, 96);
      Point point12 = point1;
      nudUnk4y1.Location = point12;
      NumericUpDown nudUnk4y2 = nudUnk4y;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num22 = num1;
      nudUnk4y2.Maximum = num22;
      NumericUpDown nudUnk4y3 = nudUnk4y;
      num1 = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      Decimal num23 = num1;
      nudUnk4y3.Minimum = num23;
      nudUnk4y.Name = "nudUnk4y";
      NumericUpDown nudUnk4y4 = nudUnk4y;
      size1 = new Size(88, 20);
      Size size12 = size1;
      nudUnk4y4.Size = size12;
      nudUnk4y.TabIndex = 0;
      nudUnk4y.TextAlign = HorizontalAlignment.Right;
      nudUnk5y.DecimalPlaces = 6;
      NumericUpDown nudUnk5y1 = nudUnk5y;
      point1 = new Point(192, 120);
      Point point13 = point1;
      nudUnk5y1.Location = point13;
      NumericUpDown nudUnk5y2 = nudUnk5y;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num24 = num1;
      nudUnk5y2.Maximum = num24;
      NumericUpDown nudUnk5y3 = nudUnk5y;
      num1 = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      Decimal num25 = num1;
      nudUnk5y3.Minimum = num25;
      nudUnk5y.Name = "nudUnk5y";
      NumericUpDown nudUnk5y4 = nudUnk5y;
      size1 = new Size(88, 20);
      Size size13 = size1;
      nudUnk5y4.Size = size13;
      nudUnk5y.TabIndex = 2;
      nudUnk5y.TextAlign = HorizontalAlignment.Right;
      nudUnk4z.DecimalPlaces = 6;
      NumericUpDown nudUnk4z1 = nudUnk4z;
      point1 = new Point(288, 96);
      Point point14 = point1;
      nudUnk4z1.Location = point14;
      NumericUpDown nudUnk4z2 = nudUnk4z;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num26 = num1;
      nudUnk4z2.Maximum = num26;
      NumericUpDown nudUnk4z3 = nudUnk4z;
      num1 = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      Decimal num27 = num1;
      nudUnk4z3.Minimum = num27;
      nudUnk4z.Name = "nudUnk4z";
      NumericUpDown nudUnk4z4 = nudUnk4z;
      size1 = new Size(88, 20);
      Size size14 = size1;
      nudUnk4z4.Size = size14;
      nudUnk4z.TabIndex = 0;
      nudUnk4z.TextAlign = HorizontalAlignment.Right;
      MainMenu1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[1]
      {
        ToolStripMenuItem1
      });
      ToolStripMenuItem1.Index = 0;
      ToolStripMenuItem1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[6]
      {
        miOpenBinary,
        miOpenAscii,
        miSaveAsBinary,
        miSaveAsASCII,
        ToolStripMenuItem4,
        miQuit
      });
      ToolStripMenuItem1.Text = "&File";
      miOpenBinary.Index = 0;
      miOpenBinary.Shortcut = Shortcut.CtrlO;
      miOpenBinary.Text = "&Open Binary PWK...";
      miOpenAscii.Index = 1;
      miOpenAscii.Text = "Open &ASCII PWK...";
      miSaveAsBinary.Enabled = false;
      miSaveAsBinary.Index = 2;
      miSaveAsBinary.Shortcut = Shortcut.CtrlS;
      miSaveAsBinary.Text = "&Save as Binary...";
      miSaveAsASCII.Enabled = false;
      miSaveAsASCII.Index = 3;
      miSaveAsASCII.Text = "Save as AS&CII...";
      ToolStripMenuItem4.Index = 4;
      ToolStripMenuItem4.Text = "-";
      miQuit.Index = 5;
      miQuit.Shortcut = Shortcut.CtrlQ;
      miQuit.Text = "&Quit";
      Label label1_1 = Label1;
      point1 = new Point(24, 24);
      Point point15 = point1;
      label1_1.Location = point15;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(56, 16);
      Size size15 = size1;
      label1_2.Size = size15;
      Label1.TabIndex = 4;
      Label1.Text = "1";
      Label1.TextAlign = ContentAlignment.MiddleCenter;
      Label label2_1 = Label2;
      point1 = new Point(24, 48);
      Point point16 = point1;
      label2_1.Location = point16;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(56, 16);
      Size size16 = size1;
      label2_2.Size = size16;
      Label2.TabIndex = 4;
      Label2.Text = "2";
      Label2.TextAlign = ContentAlignment.MiddleCenter;
      Label label3_1 = Label3;
      point1 = new Point(24, 72);
      Point point17 = point1;
      label3_1.Location = point17;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(56, 16);
      Size size17 = size1;
      label3_2.Size = size17;
      Label3.TabIndex = 4;
      Label3.Text = "3";
      Label3.TextAlign = ContentAlignment.MiddleCenter;
      Label label4_1 = Label4;
      point1 = new Point(24, 96);
      Point point18 = point1;
      label4_1.Location = point18;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(56, 16);
      Size size18 = size1;
      label4_2.Size = size18;
      Label4.TabIndex = 4;
      Label4.Text = "4";
      Label4.TextAlign = ContentAlignment.MiddleCenter;
      Label label5_1 = Label5;
      point1 = new Point(24, 120);
      Point point19 = point1;
      label5_1.Location = point19;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(56, 16);
      Size size19 = size1;
      label5_2.Size = size19;
      Label5.TabIndex = 4;
      Label5.Text = "5";
      Label5.TextAlign = ContentAlignment.MiddleCenter;
      tbInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      tbInfo.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
      TextBox tbInfo1 = tbInfo;
      point1 = new Point(56, 240);
      Point point20 = point1;
      tbInfo1.Location = point20;
      tbInfo.Multiline = true;
      tbInfo.Name = "tbInfo";
      tbInfo.ReadOnly = true;
      tbInfo.ScrollBars = ScrollBars.Vertical;
      TextBox tbInfo2 = tbInfo;
      size1 = new Size(344, 200);
      Size size20 = size1;
      tbInfo2.Size = size20;
      tbInfo.TabIndex = 5;
      tbInfo.Text = "";
      TextBox tbFilepath1 = tbFilepath;
      point1 = new Point(108, 8);
      Point point21 = point1;
      tbFilepath1.Location = point21;
      tbFilepath.Name = "tbFilepath";
      TextBox tbFilepath2 = tbFilepath;
      size1 = new Size(240, 20);
      Size size21 = size1;
      tbFilepath2.Size = size21;
      tbFilepath.TabIndex = 6;
      tbFilepath.Text = "";
      Label label6_1 = Label6;
      point1 = new Point(32, 8);
      Point point22 = point1;
      label6_1.Location = point22;
      Label6.Name = "Label6";
      Label label6_2 = Label6;
      size1 = new Size(56, 16);
      Size size22 = size1;
      label6_2.Size = size22;
      Label6.TabIndex = 4;
      Label6.Text = "File name";
      Label6.TextAlign = ContentAlignment.MiddleCenter;
      GroupBox1.Controls.Add(nudUnk3y);
      GroupBox1.Controls.Add(nudUnk3x);
      GroupBox1.Controls.Add(nudUnk1);
      GroupBox1.Controls.Add(nudUnk2z);
      GroupBox1.Controls.Add(nudUnk2y);
      GroupBox1.Controls.Add(nudUnk2x);
      GroupBox1.Controls.Add(Label1);
      GroupBox1.Controls.Add(Label2);
      GroupBox1.Controls.Add(Label3);
      GroupBox1.Controls.Add(Label4);
      GroupBox1.Controls.Add(Label5);
      GroupBox1.Controls.Add(nudUnk4z);
      GroupBox1.Controls.Add(nudUnk5y);
      GroupBox1.Controls.Add(nudUnk4y);
      GroupBox1.Controls.Add(nudUnk5z);
      GroupBox1.Controls.Add(nudUnk4x);
      GroupBox1.Controls.Add(nudUnk5x);
      GroupBox1.Controls.Add(nudUnk3z);
      GroupBox groupBox1_1 = GroupBox1;
      point1 = new Point(28, 64);
      Point point23 = point1;
      groupBox1_1.Location = point23;
      GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = GroupBox1;
      size1 = new Size(400, 160);
      Size size23 = size1;
      groupBox1_2.Size = size23;
      GroupBox1.TabIndex = 7;
      GroupBox1.TabStop = false;
      GroupBox1.Text = "Unknown data";
      ToolTip1.SetToolTip(GroupBox1, "This box contains data the purpose of which is unknown. You can edit these values and see what effect they have in the game.");
      Label lblNotSupported1 = lblNotSupported;
      point1 = new Point(120, 40);
      Point point24 = point1;
      lblNotSupported1.Location = point24;
      lblNotSupported.Name = "lblNotSupported";
      Label lblNotSupported2 = lblNotSupported;
      size1 = new Size(216, 16);
      Size size24 = size1;
      lblNotSupported2.Size = size24;
      lblNotSupported.TabIndex = 8;
      lblNotSupported.TextAlign = ContentAlignment.MiddleCenter;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(456, 457);
      ClientSize = size1;
      Controls.Add(lblNotSupported);
      Controls.Add(GroupBox1);
      Controls.Add(tbFilepath);
      Controls.Add(tbInfo);
      Controls.Add(Label6);
      Menu = MainMenu1;
      Name = nameof (frmBWMEditor);
      SizeGripStyle = SizeGripStyle.Show;
      Text = "PWK/DWK Editor";
      nudUnk2x.EndInit();
      nudUnk2y.EndInit();
      nudUnk2z.EndInit();
      nudUnk1.EndInit();
      nudUnk3x.EndInit();
      nudUnk3y.EndInit();
      nudUnk3z.EndInit();
      nudUnk5x.EndInit();
      nudUnk4x.EndInit();
      nudUnk5z.EndInit();
      nudUnk4y.EndInit();
      nudUnk5y.EndInit();
      nudUnk4z.EndInit();
      GroupBox1.ResumeLayout(false);
      ResumeLayout(false);
    }

  public frmBWMEditor(byte[] Data, string filename)
    : this()
  {
      walk = new ClsBwm(Data);
      DisplayInfo();
      tbFilepath.Text = filename;
      filepath = filename;
      ShowMsgIfNotSupported(filename);
      EnableSaveMenus();
    }

  private void miOpenBinary_Click(object sender, EventArgs e)
  {
      filepath = StringType.FromObject(FrmMain.GetFilePath("load", StringType.StrCmp(filepath, "", false) != 0 ? filepath : UserSettings.GetSettings().defaultImportLocation, "*.pwk", "Select a binary PWK/DWK file", "pwk"));
      if (StringType.StrCmp(filepath, "", false) == 0)
        return;
      try
      {
        walk = new ClsBwm(filepath);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "PWK Editor Error");
        ProjectData.ClearProjectError();
        return;
      }
      DisplayInfo();
      tbFilepath.Text = filepath;
      ShowMsgIfNotSupported(filepath);
      EnableSaveMenus();
    }

  private void miOpenAscii_Click(object sender, EventArgs e)
  {
      filepath = StringType.FromObject(FrmMain.GetFilePath("load", StringType.StrCmp(filepath, "", false) != 0 ? filepath : UserSettings.GetSettings().defaultImportLocation, "", "Select an ASCII PWK/DWK/WOK file", "pwk"));
      if (StringType.StrCmp(filepath, "", false) == 0)
        return;
      walk = new ClsBwm();
      try
      {
        walk.ParseAsciiWalkMesh(filepath);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "PWK Editor Error");
        ProjectData.ClearProjectError();
        return;
      }
      DisplayInfo();
      tbFilepath.Text = filepath;
      ShowMsgIfNotSupported(filepath);
      EnableSaveMenus();
    }

  private void miSaveAsBinary_Click(object sender, EventArgs e)
  {
      string startPath;
      string sugg_filename;
      if (StringType.StrCmp(filepath, "", false) == 0)
      {
        startPath = UserSettings.GetSettings().defaultSaveLocation;
        sugg_filename = "*.pwk";
      }
      else
      {
        startPath = Path.GetDirectoryName(filepath);
        sugg_filename = Path.GetFileName(filepath);
      }
      filepath = StringType.FromObject(FrmMain.GetFilePath("save", startPath, sugg_filename, "Save binary PWK/DWK file", "pwk"));
      if (StringType.StrCmp(filepath, "", false) == 0)
        return;
      walk.WriteBinary(filepath);
      tbFilepath.Text = filepath;
    }

  private void miSaveAsASCII_Click(object sender, EventArgs e)
  {
      string startPath;
      string sugg_filename;
      if (StringType.StrCmp(filepath, "", false) == 0)
      {
        startPath = UserSettings.GetSettings().defaultSaveLocation;
        sugg_filename = "*.pwk";
      }
      else
      {
        startPath = Path.GetDirectoryName(filepath);
        sugg_filename = Path.GetFileName(filepath);
      }
      filepath = StringType.FromObject(FrmMain.GetFilePath("save", startPath, sugg_filename, "Save ASCII PWK/DWK file", "pwk"));
      if (StringType.StrCmp(filepath, "", false) == 0)
        return;
      frmPromptForString frmPromptForString = new frmPromptForString();
      frmPromptForString.lblMsg.Text = "Enter name to use for Walkmesh Parent or click OK to use default";
      if (frmPromptForString.ShowDialog() != DialogResult.OK)
        return;
      if (StringType.StrCmp(frmPromptForString.tbValue.Text.Trim(), "", false) != 0)
        walk.WriteAscii(filepath, frmPromptForString.tbValue.Text.Trim());
      else
        walk.WriteAscii(filepath);
    }

  private void miQuit_Click(object sender, EventArgs e) => Close();

  private void ShowMsgIfNotSupported(object filepath)
  {
      if (BooleanType.FromObject(LateBinding.LateGet(LateBinding.LateGet(filepath, null, "ToLower", new object[0], null, null), null, "EndsWith", new object[1]
      {
        "dwk"
      }, null, null)))
        lblNotSupported.Text = "DWK files are not fully supported";
      else
        lblNotSupported.Text = "";
    }

  private void EnableSaveMenus()
  {
      miSaveAsASCII.Enabled = true;
      miSaveAsBinary.Enabled = true;
    }

  private void DisplayInfo()
  {
      StringBuilder stringBuilder = new StringBuilder(300);
      nudUnk1.Value = new Decimal(this.walk.UnkSingles[0]);
      nudUnk2x.Value = new Decimal(this.walk.UnkSingles[1]);
      nudUnk2y.Value = new Decimal(this.walk.UnkSingles[2]);
      nudUnk2z.Value = new Decimal(this.walk.UnkSingles[3]);
      nudUnk3x.Value = new Decimal(this.walk.UnkSingles[4]);
      nudUnk3y.Value = new Decimal(this.walk.UnkSingles[5]);
      nudUnk3z.Value = new Decimal(this.walk.UnkSingles[6]);
      nudUnk4x.Value = new Decimal(this.walk.UnkSingles[7]);
      nudUnk4y.Value = new Decimal(this.walk.UnkSingles[8]);
      nudUnk4z.Value = new Decimal(this.walk.UnkSingles[9]);
      nudUnk5x.Value = new Decimal(this.walk.UnkSingles[10]);
      nudUnk5y.Value = new Decimal(this.walk.UnkSingles[11]);
      nudUnk5z.Value = new Decimal(this.walk.UnkSingles[12]);
      tbInfo.Text = "";
      stringBuilder.Append("Verts: " + StringType.FromInteger(this.walk.Verts.Length) + "\r\n");
      int num1 = checked (this.walk.Verts.Length - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        stringBuilder.AppendFormat("{0,10:f4}", walk.Verts[index1].X);
        stringBuilder.AppendFormat("{0,10:f4}", walk.Verts[index1].Y);
        stringBuilder.AppendFormat("{0,10:f4}", walk.Verts[index1].Z);
        stringBuilder.Append("\r\n");
        checked { ++index1; }
      }
      stringBuilder.Append("\r\n");
      stringBuilder.Append("Faces: " + StringType.FromInteger(this.walk.Faces.Length) + "\r\n");
      int num2 = checked (this.walk.Faces.Length - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        stringBuilder.AppendFormat("{0,4:d}", walk.Faces[index2].V1);
        stringBuilder.AppendFormat("{0,4:d}", walk.Faces[index2].V2);
        stringBuilder.AppendFormat("{0,4:d}", walk.Faces[index2].V3);
        stringBuilder.Append("\r\n");
        checked { ++index2; }
      }
      stringBuilder.Append("\r\n");
      stringBuilder.Append("Walk Types: " + StringType.FromInteger(this.walk.Faces.Length) + "\r\n");
      int num3 = checked (this.walk.Faces.Length - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        stringBuilder.Append(StringType.FromInteger(walk.WalkTypes[index3]) + " (" + WalkTypeString(walk.WalkTypes[index3]) + ")\r\n");
        checked { ++index3; }
      }
      stringBuilder.Append("\r\n");
      if (this.walk.AabbNodes != null && this.walk.AabbNodes.Length > 0)
      {
        stringBuilder.Append("AABB Nodes: " + StringType.FromInteger(this.walk.AabbNodes.Length) + "\r\n");
        int num4 = checked (this.walk.AabbNodes.Length - 1);
        int num5 = 0;
        while (num5 <= num4)
        {
          ClsBwm walk = this.walk;
          int index4 = num5;
          stringBuilder.AppendFormat("{0,10:f4}", walk.AabbNodes[index4].BBoxMin.X);
          stringBuilder.AppendFormat("{0,10:f4}", walk.AabbNodes[index4].BBoxMin.Y);
          stringBuilder.AppendFormat("{0,10:f4}", walk.AabbNodes[index4].BBoxMin.Z);
          stringBuilder.AppendFormat("{0,10:f4}", walk.AabbNodes[index4].BBoxMax.X);
          stringBuilder.AppendFormat("{0,10:f4}", walk.AabbNodes[index4].BBoxMax.Y);
          stringBuilder.AppendFormat("{0,10:f4}", walk.AabbNodes[index4].BBoxMax.Z);
          stringBuilder.AppendFormat("{0,3:d}", walk.AabbNodes[index4].LeafFacePartNumber);
          stringBuilder.Append("\r\n");
          checked { ++num5; }
        }
      }
      tbInfo.Text = stringBuilder.ToString();
      tbInfo.SelectionLength = 0;
    }

  private string WalkTypeString(int walktype)
  {
      switch (walktype)
      {
        case 0:
          return "Not Defined";
        case 1:
          return "Dirt";
        case 2:
          return "Obscuring";
        case 3:
          return "Grass";
        case 4:
          return "Stone";
        case 5:
          return "Wood";
        case 6:
          return "Water";
        case 7:
          return "Non-walk";
        case 8:
          return "Transparent";
        case 9:
          return "Carpet";
        case 10:
          return "Metal";
        case 11:
          return "Puddles";
        case 12:
          return "Swamp";
        case 13:
          return "Mud";
        case 14:
          return "Leaves";
        case 15:
          return "Lava";
        case 16:
          return "BottomlessPit";
        case 17:
          return "DeepWater";
        case 18:
          return "Door";
        case 19:
          return "NonWalkGrass";
        default:
          string str = null;
          return str;
      }
    }
}