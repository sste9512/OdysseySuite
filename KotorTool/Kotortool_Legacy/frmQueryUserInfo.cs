// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmQueryUserInfo
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmQueryUserInfo : Form
{
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("tbUserEmail")]
  private TextBox _tbUserEmail;
  [AccessedThroughProperty("tbUserName")]
  private TextBox _tbUserName;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  private IContainer components;

  public frmQueryUserInfo() => InitializeComponent();

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
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

  internal virtual TextBox tbUserName
  {
    get => _tbUserName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbUserName == null)
          ;
        _tbUserName = value;
        if (_tbUserName == null)
          ;
      }
  }

  internal virtual TextBox tbUserEmail
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbUserEmail == null)
          ;
        _tbUserEmail = value;
        if (_tbUserEmail == null)
          ;
      }
    get => _tbUserEmail;
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmQueryUserInfo));
      Label2 = new Label();
      Label3 = new Label();
      btnOK = new Button();
      this.btnCancel = new Button();
      tbUserName = new TextBox();
      tbUserEmail = new TextBox();
      Label1 = new Label();
      SuspendLayout();
      Label label2_1 = Label2;
      Point point1 = new Point(40, 64);
      Point point2 = point1;
      label2_1.Location = point2;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      Size size1 = new Size(64, 16);
      Size size2 = size1;
      label2_2.Size = size2;
      Label2.TabIndex = 8;
      Label2.Text = "Name";
      Label label3_1 = Label3;
      point1 = new Point(40, 96);
      Point point3 = point1;
      label3_1.Location = point3;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(88, 16);
      Size size3 = size1;
      label3_2.Size = size3;
      Label3.TabIndex = 6;
      Label3.Text = "Email Address";
      btnOK.DialogResult = DialogResult.OK;
      Button btnOk = btnOK;
      point1 = new Point(88, 136);
      Point point4 = point1;
      btnOk.Location = point4;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 9;
      btnOK.Text = "OK";
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(176, 136);
      Point point5 = point1;
      btnCancel.Location = point5;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 9;
      this.btnCancel.Text = "Cancel";
      TextBox tbUserName1 = tbUserName;
      point1 = new Point(152, 64);
      Point point6 = point1;
      tbUserName1.Location = point6;
      tbUserName.Name = "tbUserName";
      TextBox tbUserName2 = tbUserName;
      size1 = new Size(160, 20);
      Size size4 = size1;
      tbUserName2.Size = size4;
      tbUserName.TabIndex = 11;
      tbUserName.Text = "";
      TextBox tbUserEmail1 = tbUserEmail;
      point1 = new Point(152, 96);
      Point point7 = point1;
      tbUserEmail1.Location = point7;
      tbUserEmail.Name = "tbUserEmail";
      TextBox tbUserEmail2 = tbUserEmail;
      size1 = new Size(160, 20);
      Size size5 = size1;
      tbUserEmail2.Size = size5;
      tbUserEmail.TabIndex = 11;
      tbUserEmail.Text = "";
      Label label1_1 = Label1;
      point1 = new Point(48, 16);
      Point point8 = point1;
      label1_1.Location = point8;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(248, 32);
      Size size6 = size1;
      label1_2.Size = size6;
      Label1.TabIndex = 8;
      Label1.Text = "Please enter your name and the email address you would like to be contacted at.";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(352, 189);
      ClientSize = size1;
      Controls.Add(tbUserName);
      Controls.Add(btnOK);
      Controls.Add(Label2);
      Controls.Add(Label3);
      Controls.Add(this.btnCancel);
      Controls.Add(tbUserEmail);
      Controls.Add(Label1);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Name = nameof (frmQueryUserInfo);
      StartPosition = FormStartPosition.CenterParent;
      Text = "Create User Info File";
      ResumeLayout(false);
    }
}