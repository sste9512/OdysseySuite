// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmErrorMessageWithCopyableText
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmErrorMessageWithCopyableText : Form
{
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("lblMsg")]
  private Label _lblMsg;
  [AccessedThroughProperty("tbMsg")]
  private TextBox _tbMsg;
  private IContainer components;

  public frmErrorMessageWithCopyableText() => InitializeComponent();

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
        if (_Button1 == null)
          ;
        _Button1 = value;
        if (_Button1 == null)
          ;
      }
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

  internal virtual TextBox tbMsg
  {
    get => _tbMsg;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbMsg == null)
          ;
        _tbMsg = value;
        if (_tbMsg == null)
          ;
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmErrorMessageWithCopyableText));
      lblMsg = new Label();
      tbMsg = new TextBox();
      Button1 = new Button();
      SuspendLayout();
      lblMsg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      Label lblMsg1 = lblMsg;
      Point point1 = new Point(36, 16);
      Point point2 = point1;
      lblMsg1.Location = point2;
      lblMsg.Name = "lblMsg";
      Label lblMsg2 = lblMsg;
      Size size1 = new Size(296, 96);
      Size size2 = size1;
      lblMsg2.Size = size2;
      lblMsg.TabIndex = 0;
      lblMsg.Text = "Kotor Tool has either detected a problem with your SW:KotOR installation or is having a problem with one of its own files. Please report this status code by copying it and pasting it into an email to FredTetra@hotmail.com. Thank you!";
      TextBox tbMsg1 = tbMsg;
      point1 = new Point(56, 120);
      Point point3 = point1;
      tbMsg1.Location = point3;
      tbMsg.Multiline = true;
      tbMsg.Name = "tbMsg";
      tbMsg.ReadOnly = true;
      tbMsg.ScrollBars = ScrollBars.Vertical;
      TextBox tbMsg2 = tbMsg;
      size1 = new Size(256, 88);
      Size size3 = size1;
      tbMsg2.Size = size3;
      tbMsg.TabIndex = 1;
      tbMsg.Text = "";
      Button1.DialogResult = DialogResult.OK;
      Button button1 = Button1;
      point1 = new Point(147, 224);
      Point point4 = point1;
      button1.Location = point4;
      Button1.Name = "Button1";
      Button1.TabIndex = 2;
      Button1.Text = "Sorry!";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(360, 269);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(Button1);
      Controls.Add(tbMsg);
      Controls.Add(lblMsg);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Name = nameof (frmErrorMessageWithCopyableText);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "An error has occurred";
      ResumeLayout(false);
    }
}