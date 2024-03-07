// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmPromptForString
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmPromptForString : Form
{
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("lblMsg")]
  private Label _lblMsg;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("tbValue")]
  private TextBox _tbValue;
  private IContainer components;

  public frmPromptForString() => InitializeComponent();

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual Label lblMsg
  {
    get => _lblMsg;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblMsg == null)
          ;
        _lblMsg = value;
        if (_lblMsg == null)
          ;
      }
  }

  internal virtual TextBox tbValue
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbValue == null)
          ;
        _tbValue = value;
        if (_tbValue == null)
          ;
      }
    get => _tbValue;
  }

  internal virtual Button btnOK
  {
    get => _btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnOK == null)
          ;
        _btnOK = value;
        if (_btnOK == null)
          ;
      }
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmPromptForString));
      lblMsg = new Label();
      tbValue = new TextBox();
      btnOK = new Button();
      this.btnCancel = new Button();
      SuspendLayout();
      Label lblMsg1 = lblMsg;
      Point point1 = new Point(61, 24);
      Point point2 = point1;
      lblMsg1.Location = point2;
      lblMsg.Name = "lblMsg";
      Label lblMsg2 = lblMsg;
      Size size1 = new Size(176, 32);
      Size size2 = size1;
      lblMsg2.Size = size2;
      lblMsg.TabIndex = 0;
      lblMsg.Text = "Label1";
      tbValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TextBox tbValue1 = tbValue;
      point1 = new Point(33, 72);
      Point point3 = point1;
      tbValue1.Location = point3;
      tbValue.Name = "tbValue";
      TextBox tbValue2 = tbValue;
      size1 = new Size(224, 20);
      Size size3 = size1;
      tbValue2.Size = size3;
      tbValue.TabIndex = 0;
      tbValue.Text = "";
      btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnOK.DialogResult = DialogResult.OK;
      Button btnOk = btnOK;
      point1 = new Point(52, 112);
      Point point4 = point1;
      btnOk.Location = point4;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 1;
      btnOK.Text = "OK";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(156, 112);
      Point point5 = point1;
      btnCancel.Location = point5;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      AcceptButton = btnOK;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = this.btnCancel;
      size1 = new Size(288, 165);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(btnOK);
      Controls.Add(tbValue);
      Controls.Add(lblMsg);
      Controls.Add(this.btnCancel);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Name = nameof (frmPromptForString);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = nameof (frmPromptForString);
      ResumeLayout(false);
    }

  public frmPromptForString(string Title, string Message, string ValueText)
    : this()
  {
      Text = Title;
      lblMsg.Text = Message;
      tbValue.Text = ValueText;
    }
}