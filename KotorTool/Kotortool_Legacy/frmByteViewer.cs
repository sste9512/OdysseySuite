// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmByteViewer
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmByteViewer : Form
{
  [AccessedThroughProperty("bv")]
  private ByteViewer _bv;
  [AccessedThroughProperty("rbHex")]
  private RadioButton _rbHex;
  [AccessedThroughProperty("rbUnicode")]
  private RadioButton _rbUnicode;
  [AccessedThroughProperty("rbANSI")]
  private RadioButton _rbANSI;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  public string filepath;
  public byte[] data;
  private IContainer components;

  public virtual ByteViewer bv
  {
    get => _bv;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_bv == null)
          ;
        _bv = value;
        if (_bv == null)
          ;
      }
  }

  public frmByteViewer()
  {
      Resize += new EventHandler(frmByteViewer_Resize);
      Closing += new CancelEventHandler(frmByteViewer_Closing);
      Load += new EventHandler(Form1_Load);
      bv = new ByteViewer();
      InitializeComponent();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual RadioButton rbHex
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbHex != null)
          _rbHex.Click -= new EventHandler(rbHex_Click);
        _rbHex = value;
        if (_rbHex == null)
          return;
        _rbHex.Click += new EventHandler(rbHex_Click);
      }
    get => _rbHex;
  }

  internal virtual RadioButton rbANSI
  {
    get => _rbANSI;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbANSI != null)
          _rbANSI.Click -= new EventHandler(rbANSI_Click);
        _rbANSI = value;
        if (_rbANSI == null)
          return;
        _rbANSI.Click += new EventHandler(rbANSI_Click);
      }
  }

  internal virtual RadioButton rbUnicode
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbUnicode != null)
          _rbUnicode.Click -= new EventHandler(rbUnicode_Click);
        _rbUnicode = value;
        if (_rbUnicode == null)
          return;
        _rbUnicode.Click += new EventHandler(rbUnicode_Click);
      }
    get => _rbUnicode;
  }

  internal virtual Button Button1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Button1 != null)
          _Button1.Click -= new EventHandler(Button1_Click);
        _Button1 = value;
        if (_Button1 == null)
          return;
        _Button1.Click += new EventHandler(Button1_Click);
      }
    get => _Button1;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmByteViewer));
      rbHex = new RadioButton();
      rbANSI = new RadioButton();
      rbUnicode = new RadioButton();
      Button1 = new Button();
      SuspendLayout();
      rbHex.Anchor = AnchorStyles.Bottom;
      rbHex.Checked = true;
      RadioButton rbHex1 = rbHex;
      Point point1 = new Point(64, 256);
      Point point2 = point1;
      rbHex1.Location = point2;
      rbHex.Name = "rbHex";
      RadioButton rbHex2 = rbHex;
      Size size1 = new Size(64, 16);
      Size size2 = size1;
      rbHex2.Size = size2;
      rbHex.TabIndex = 0;
      rbHex.TabStop = true;
      rbHex.Text = "Hex";
      rbANSI.Anchor = AnchorStyles.Bottom;
      RadioButton rbAnsi1 = rbANSI;
      point1 = new Point(156, 256);
      Point point3 = point1;
      rbAnsi1.Location = point3;
      rbANSI.Name = "rbANSI";
      RadioButton rbAnsi2 = rbANSI;
      size1 = new Size(64, 16);
      Size size3 = size1;
      rbAnsi2.Size = size3;
      rbANSI.TabIndex = 1;
      rbANSI.Text = "ANSI";
      rbUnicode.Anchor = AnchorStyles.Bottom;
      RadioButton rbUnicode1 = rbUnicode;
      point1 = new Point(248, 256);
      Point point4 = point1;
      rbUnicode1.Location = point4;
      rbUnicode.Name = "rbUnicode";
      RadioButton rbUnicode2 = rbUnicode;
      size1 = new Size(64, 16);
      Size size4 = size1;
      rbUnicode2.Size = size4;
      rbUnicode.TabIndex = 2;
      rbUnicode.Text = "Unicode";
      Button1.Anchor = AnchorStyles.Bottom;
      Button1.DialogResult = DialogResult.OK;
      Button button1 = Button1;
      point1 = new Point(504, 248);
      Point point5 = point1;
      button1.Location = point5;
      Button1.Name = "Button1";
      Button1.TabIndex = 3;
      Button1.Text = "OK";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(632, 277);
      ClientSize = size1;
      Controls.Add(Button1);
      Controls.Add(rbHex);
      Controls.Add(rbANSI);
      Controls.Add(rbUnicode);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      size1 = new Size(640, 1600);
      MaximumSize = size1;
      size1 = new Size(640, 200);
      MinimumSize = size1;
      Name = nameof (frmByteViewer);
      StartPosition = FormStartPosition.CenterParent;
      Text = "Byte Viewer";
      ResumeLayout(false);
    }

  public frmByteViewer(string path)
    : this()
  {
      filepath = path;
    }

  public frmByteViewer(byte[] bytes)
    : this()
  {
      data = bytes;
    }

  private void Form1_Load(object sender, EventArgs e)
  {
      bv.Size = new Size(638, 250);
      bv.Anchor = AnchorStyles.Top;
      bv.ForeColor = Color.Black;
      bv.BackColor = DefaultBackColor;
      bv.Visible = true;
      Controls.Add(bv);
      if (StringType.StrCmp(filepath, "", false) != 0)
        bv.SetFile(filepath);
      else if (data.Length > 0)
        bv.SetBytes(data);
      bv.SetDisplayMode(DisplayMode.Hexdump);
      PositionWindow();
      bv.Height = checked ((int) Math.Round(Conversion.Int(checked (Height - 80) / 21.0) * 21.0 + 21.0));
    }

  private void rbANSI_Click(object sender, EventArgs e)
  {
      bv.SetDisplayMode(DisplayMode.Ansi);
      bv.Font = new Font("Lucida Console", 8f);
    }

  private void rbHex_Click(object sender, EventArgs e) => bv.SetDisplayMode(DisplayMode.Hexdump);

  private void rbUnicode_Click(object sender, EventArgs e) => bv.SetDisplayMode(DisplayMode.Unicode);

  private void frmByteViewer_Resize(object sender, EventArgs e) => bv.Height = checked ((int) Math.Round(Conversion.Int(checked (Height - 80) / 21.0) * 21.0 + 21.0));

  public void PositionWindow()
  {
      Point point1 = FrmMain.CurrentSettings.ByteViewerWindowLoc;
      if (!point1.IsEmpty)
        ((Control) this).Location = FrmMain.CurrentSettings.ByteViewerWindowLoc;
      if (FrmMain.CurrentSettings.ByteViewerWindowSize.IsEmpty)
        return;
      Size size1 = FrmMain.CurrentSettings.ByteViewerWindowSize;
      Rectangle workingArea;
      int height1 = 0;
      if (size1.Height > Screen.PrimaryScreen.WorkingArea.Height)
      {
        Point point2 = default;
        ref Point local1 = ref point2;
        point1 = ((Control) this).Location;
        int x = point1.X;
        int top = Screen.PrimaryScreen.WorkingArea.Top;
        local1 = new Point(x, top);
        ((Control) this).Location = point2;
        workingArea = Screen.PrimaryScreen.WorkingArea;
        height1 = workingArea.Height;
        Size size2 = default;
        ref Size local2 = ref size2;
        size1 = Size;
        int width = size1.Width;
        int height2 = height1;
        local2 = new Size(width, height2);
        Size = size2;
      }
      int width1 = FrmMain.CurrentSettings.ByteViewerWindowSize.Width;
      workingArea = Screen.PrimaryScreen.WorkingArea;
      int width2 = workingArea.Width;
      int width3 = 0;
      if (width1 > width2)
      {
        point1 = new Point(Screen.PrimaryScreen.WorkingArea.Left, ((Control) this).Location.Y);
        ((Control) this).Location = point1;
        workingArea = Screen.PrimaryScreen.WorkingArea;
        width3 = workingArea.Width;
        size1 = new Size(width3, Size.Height);
        Size = size1;
      }
      if (!(width3 == 0 & height1 == 0))
        return;
      Size = FrmMain.CurrentSettings.ByteViewerWindowSize;
    }

  public void SaveSettings()
  {
      FrmMain.CurrentSettings.ByteViewerWindowLoc = ((Control) this).Location;
      FrmMain.CurrentSettings.ByteViewerWindowSize = Size;
    }

  private void frmByteViewer_Closing(object sender, CancelEventArgs e) => SaveSettings();

  private void Button1_Click(object sender, EventArgs e) => Close();
}