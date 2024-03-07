// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmTextEditorFind
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmTextEditorFind : Form
{
  [AccessedThroughProperty("chkbMatchWholeWord")]
  private CheckBox _chkbMatchWholeWord;
  [AccessedThroughProperty("chkbMatchCase")]
  private CheckBox _chkbMatchCase;
  [AccessedThroughProperty("btnFind")]
  private Button _btnFind;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("chkbSearchUp")]
  private CheckBox _chkbSearchUp;
  [AccessedThroughProperty("tbFindText")]
  private TextBox _tbFindText;
  private IContainer components;

  public frmTextEditorFind() => InitializeComponent();

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual TextBox tbFindText
  {
    get => _tbFindText;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbFindText == null)
          ;
        _tbFindText = value;
        if (_tbFindText == null)
          ;
      }
  }

  internal virtual Button btnFind
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnFind == null)
          ;
        _btnFind = value;
        if (_btnFind == null)
          ;
      }
    get => _btnFind;
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

  internal virtual CheckBox chkbMatchCase
  {
    get => _chkbMatchCase;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbMatchCase == null)
          ;
        _chkbMatchCase = value;
        if (_chkbMatchCase == null)
          ;
      }
  }

  internal virtual CheckBox chkbMatchWholeWord
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbMatchWholeWord == null)
          ;
        _chkbMatchWholeWord = value;
        if (_chkbMatchWholeWord == null)
          ;
      }
    get => _chkbMatchWholeWord;
  }

  internal virtual CheckBox chkbSearchUp
  {
    get => _chkbSearchUp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbSearchUp == null)
          ;
        _chkbSearchUp = value;
        if (_chkbSearchUp == null)
          ;
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      tbFindText = new TextBox();
      this.btnFind = new Button();
      Label1 = new Label();
      this.btnCancel = new Button();
      chkbMatchCase = new CheckBox();
      chkbMatchWholeWord = new CheckBox();
      chkbSearchUp = new CheckBox();
      SuspendLayout();
      TextBox tbFindText1 = tbFindText;
      Point point1 = new Point(96, 16);
      Point point2 = point1;
      tbFindText1.Location = point2;
      tbFindText.Name = "tbFindText";
      TextBox tbFindText2 = tbFindText;
      Size size1 = new Size(280, 20);
      Size size2 = size1;
      tbFindText2.Size = size2;
      tbFindText.TabIndex = 0;
      tbFindText.Text = "";
      this.btnFind.DialogResult = DialogResult.OK;
      Button btnFind = this.btnFind;
      point1 = new Point(408, 16);
      Point point3 = point1;
      btnFind.Location = point3;
      this.btnFind.Name = "btnFind";
      this.btnFind.TabIndex = 1;
      this.btnFind.Text = "Find";
      Label label1_1 = Label1;
      point1 = new Point(16, 16);
      Point point4 = point1;
      label1_1.Location = point4;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(56, 16);
      Size size3 = size1;
      label1_2.Size = size3;
      Label1.TabIndex = 2;
      Label1.Text = "Find what:";
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(408, 56);
      Point point5 = point1;
      btnCancel.Location = point5;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Close";
      CheckBox chkbMatchCase1 = chkbMatchCase;
      point1 = new Point(24, 41);
      Point point6 = point1;
      chkbMatchCase1.Location = point6;
      chkbMatchCase.Name = "chkbMatchCase";
      CheckBox chkbMatchCase2 = chkbMatchCase;
      size1 = new Size(104, 16);
      Size size4 = size1;
      chkbMatchCase2.Size = size4;
      chkbMatchCase.TabIndex = 3;
      chkbMatchCase.Text = "Match case";
      CheckBox chkbMatchWholeWord1 = chkbMatchWholeWord;
      point1 = new Point(24, 61);
      Point point7 = point1;
      chkbMatchWholeWord1.Location = point7;
      chkbMatchWholeWord.Name = "chkbMatchWholeWord";
      CheckBox chkbMatchWholeWord2 = chkbMatchWholeWord;
      size1 = new Size(136, 16);
      Size size5 = size1;
      chkbMatchWholeWord2.Size = size5;
      chkbMatchWholeWord.TabIndex = 3;
      chkbMatchWholeWord.Text = "Match whole word";
      CheckBox chkbSearchUp1 = chkbSearchUp;
      point1 = new Point(24, 81);
      Point point8 = point1;
      chkbSearchUp1.Location = point8;
      chkbSearchUp.Name = "chkbSearchUp";
      CheckBox chkbSearchUp2 = chkbSearchUp;
      size1 = new Size(104, 16);
      Size size6 = size1;
      chkbSearchUp2.Size = size6;
      chkbSearchUp.TabIndex = 3;
      chkbSearchUp.Text = "Search up";
      AcceptButton = this.btnFind;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = this.btnCancel;
      size1 = new Size(496, 109);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(chkbMatchCase);
      Controls.Add(Label1);
      Controls.Add(this.btnFind);
      Controls.Add(tbFindText);
      Controls.Add(this.btnCancel);
      Controls.Add(chkbMatchWholeWord);
      Controls.Add(chkbSearchUp);
      size1 = new Size(504, 136);
      MaximumSize = size1;
      size1 = new Size(504, 136);
      MinimumSize = size1;
      Name = nameof (frmTextEditorFind);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Find";
      ResumeLayout(false);
    }
}