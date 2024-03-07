// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmOverrideFilesUsed
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmOverrideFilesUsed : frmParent
{
  [AccessedThroughProperty("lbOverrideFiles")]
  private ListBox _lbOverrideFiles;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("lblDesc")]
  private Label _lblDesc;
  private FrmMain mainform;
  private IContainer components;

  public frmOverrideFilesUsed() => InitializeComponent();

  public frmOverrideFilesUsed(Form f)
    : this()
  {
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual Button Button1
  {
    get => _Button1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Button1 != null)
          _Button1.Click -= new EventHandler(Button1_Click);
        _Button1 = value;
        if (_Button1 == null)
          return;
        _Button1.Click += new EventHandler(Button1_Click);
      }
  }

  internal virtual Label lblDesc
  {
    get => _lblDesc;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblDesc == null)
          ;
        _lblDesc = value;
        if (_lblDesc == null)
          ;
      }
  }

  internal virtual ListBox lbOverrideFiles
  {
    get => _lbOverrideFiles;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lbOverrideFiles == null)
          ;
        _lbOverrideFiles = value;
        if (_lbOverrideFiles == null)
          ;
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      lbOverrideFiles = new ListBox();
      Button1 = new Button();
      lblDesc = new Label();
      SuspendLayout();
      lbOverrideFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      ListBox lbOverrideFiles1 = lbOverrideFiles;
      Point point1 = new Point(24, 24);
      Point point2 = point1;
      lbOverrideFiles1.Location = point2;
      lbOverrideFiles.Name = "lbOverrideFiles";
      lbOverrideFiles.ScrollAlwaysVisible = true;
      ListBox lbOverrideFiles2 = lbOverrideFiles;
      Size size1 = new Size(208, 121);
      Size size2 = size1;
      lbOverrideFiles2.Size = size2;
      lbOverrideFiles.TabIndex = 0;
      Button1.Anchor = AnchorStyles.Bottom;
      Button button1_1 = Button1;
      point1 = new Point(95, 160);
      Point point3 = point1;
      button1_1.Location = point3;
      Button1.Name = "Button1";
      Button button1_2 = Button1;
      size1 = new Size(67, 23);
      Size size3 = size1;
      button1_2.Size = size3;
      Button1.TabIndex = 1;
      Button1.Text = "OK";
      Label lblDesc1 = lblDesc;
      point1 = new Point(24, 8);
      Point point4 = point1;
      lblDesc1.Location = point4;
      lblDesc.Name = "lblDesc";
      Label lblDesc2 = lblDesc;
      size1 = new Size(240, 32);
      Size size4 = size1;
      lblDesc2.Size = size4;
      lblDesc.TabIndex = 2;
      lblDesc.Text = "Double click an item in the list to launch the viewer or editor for it";
      lblDesc.Visible = false;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(256, 197);
      ClientSize = size1;
      Controls.Add(lbOverrideFiles);
      Controls.Add(lblDesc);
      Controls.Add(Button1);
      MaximizeBox = false;
      MinimizeBox = false;
      size1 = new Size(264, 216);
      MinimumSize = size1;
      Name = nameof (frmOverrideFilesUsed);
      StartPosition = FormStartPosition.CenterParent;
      Text = "Files used from Override folder";
      ResumeLayout(false);
    }

  private void Button1_Click(object sender, EventArgs e) => Close();
}