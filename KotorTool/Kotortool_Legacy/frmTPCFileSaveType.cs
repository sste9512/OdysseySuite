// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmTPCFileSaveType
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmTPCFileSaveType : Form
{
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("btnTGA")]
  private Button _btnTGA;
  [AccessedThroughProperty("btnTPC")]
  private Button _btnTPC;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  private IContainer components;
  public string saveType;

  public frmTPCFileSaveType() => InitializeComponent();

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual Button btnTPC
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnTPC != null)
          _btnTPC.Click -= new EventHandler(btnTPC_Click);
        _btnTPC = value;
        if (_btnTPC == null)
          return;
        _btnTPC.Click += new EventHandler(btnTPC_Click);
      }
    get => _btnTPC;
  }

  internal virtual Button btnTGA
  {
    get => _btnTGA;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnTGA != null)
          _btnTGA.Click -= new EventHandler(btnTGA_Click);
        _btnTGA = value;
        if (_btnTGA == null)
          return;
        _btnTGA.Click += new EventHandler(btnTGA_Click);
      }
  }

  internal virtual Button btnCancel
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnCancel == null)
          ;
        _btnCancel = value;
        if (_btnCancel == null)
          ;
      }
    get => _btnCancel;
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      btnTPC = new Button();
      btnTGA = new Button();
      this.btnCancel = new Button();
      Label1 = new Label();
      SuspendLayout();
      btnTPC.DialogResult = DialogResult.OK;
      Button btnTpc1 = btnTPC;
      Point point1 = new Point(143, 96);
      Point point2 = point1;
      btnTpc1.Location = point2;
      btnTPC.Name = "btnTPC";
      Button btnTpc2 = btnTPC;
      Size size1 = new Size(80, 23);
      Size size2 = size1;
      btnTpc2.Size = size2;
      btnTPC.TabIndex = 1;
      btnTPC.Text = "Save as TPC";
      btnTGA.DialogResult = DialogResult.OK;
      Button btnTga1 = btnTGA;
      point1 = new Point(39, 96);
      Point point3 = point1;
      btnTga1.Location = point3;
      btnTGA.Name = "btnTGA";
      Button btnTga2 = btnTGA;
      size1 = new Size(80, 23);
      Size size3 = size1;
      btnTga2.Size = size3;
      btnTGA.TabIndex = 0;
      btnTGA.Text = "Save as TGA";
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(247, 96);
      Point point4 = point1;
      btnCancel.Location = point4;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      Label label1_1 = Label1;
      point1 = new Point(52, 24);
      Point point5 = point1;
      label1_1.Location = point5;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(256, 40);
      Size size4 = size1;
      label1_2.Size = size4;
      Label1.TabIndex = 1;
      Label1.Text = "Do you want save this file as TPC (native) format or convert it to TGA?";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = this.btnCancel;
      size1 = new Size(360, 133);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(Label1);
      Controls.Add(btnTPC);
      Controls.Add(btnTGA);
      Controls.Add(this.btnCancel);
      Name = nameof (frmTPCFileSaveType);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "TPC File Output Format";
      ResumeLayout(false);
    }

  private void btnTPC_Click(object sender, EventArgs e) => saveType = "tpc";

  private void btnTGA_Click(object sender, EventArgs e) => saveType = "tga";
}