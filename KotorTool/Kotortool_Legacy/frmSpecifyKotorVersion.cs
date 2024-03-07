// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmSpecifyKotorVersion
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmSpecifyKotorVersion : Form
{
  [AccessedThroughProperty("rbKotor1")]
  private RadioButton _rbKotor1;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("rbKotor2")]
  private RadioButton _rbKotor2;
  [AccessedThroughProperty("lblMsg")]
  private Label _lblMsg;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("chkbRecordSelection")]
  private CheckBox _chkbRecordSelection;
  private IContainer components;

  public frmSpecifyKotorVersion() => InitializeComponent();

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
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

  internal virtual RadioButton rbKotor1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbKotor1 != null)
          _rbKotor1.CheckedChanged -= new EventHandler(rb_CheckedChanged);
        _rbKotor1 = value;
        if (_rbKotor1 == null)
          return;
        _rbKotor1.CheckedChanged += new EventHandler(rb_CheckedChanged);
      }
    get => _rbKotor1;
  }

  internal virtual RadioButton rbKotor2
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbKotor2 != null)
          _rbKotor2.CheckedChanged -= new EventHandler(rb_CheckedChanged);
        _rbKotor2 = value;
        if (_rbKotor2 == null)
          return;
        _rbKotor2.CheckedChanged += new EventHandler(rb_CheckedChanged);
      }
    get => _rbKotor2;
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

  internal virtual CheckBox chkbRecordSelection
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbRecordSelection == null)
          ;
        _chkbRecordSelection = value;
        if (_chkbRecordSelection == null)
          ;
      }
    get => _chkbRecordSelection;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmSpecifyKotorVersion));
      rbKotor1 = new RadioButton();
      rbKotor2 = new RadioButton();
      lblMsg = new Label();
      btnOK = new Button();
      this.btnCancel = new Button();
      chkbRecordSelection = new CheckBox();
      SuspendLayout();
      RadioButton rbKotor1_1 = rbKotor1;
      Point point1 = new Point(134, 72);
      Point point2 = point1;
      rbKotor1_1.Location = point2;
      rbKotor1.Name = "rbKotor1";
      RadioButton rbKotor1_2 = rbKotor1;
      Size size1 = new Size(72, 20);
      Size size2 = size1;
      rbKotor1_2.Size = size2;
      rbKotor1.TabIndex = 0;
      rbKotor1.Text = "&KotOR I";
      RadioButton rbKotor2_1 = rbKotor2;
      point1 = new Point(134, 96);
      Point point3 = point1;
      rbKotor2_1.Location = point3;
      rbKotor2.Name = "rbKotor2";
      RadioButton rbKotor2_2 = rbKotor2;
      size1 = new Size(106, 20);
      Size size3 = size1;
      rbKotor2_2.Size = size3;
      rbKotor2.TabIndex = 1;
      rbKotor2.Text = "KotOR II : &TSL";
      Label lblMsg1 = lblMsg;
      point1 = new Point(48, 24);
      Point point4 = point1;
      lblMsg1.Location = point4;
      lblMsg.Name = "lblMsg";
      Label lblMsg2 = lblMsg;
      size1 = new Size(256, 32);
      Size size4 = size1;
      lblMsg2.Size = size4;
      lblMsg.TabIndex = 3;
      lblMsg.Text = "Please indicate which game's data should be used for this file";
      lblMsg.TextAlign = ContentAlignment.TopCenter;
      btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnOK.DialogResult = DialogResult.OK;
      btnOK.Enabled = false;
      Button btnOk = btnOK;
      point1 = new Point(168, 136);
      Point point5 = point1;
      btnOk.Location = point5;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 3;
      btnOK.Text = "&OK";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(264, 136);
      Point point6 = point1;
      btnCancel.Location = point6;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 4;
      this.btnCancel.Text = "&Cancel";
      chkbRecordSelection.Checked = true;
      chkbRecordSelection.CheckState = CheckState.Checked;
      CheckBox chkbRecordSelection1 = chkbRecordSelection;
      point1 = new Point(8, 160);
      Point point7 = point1;
      chkbRecordSelection1.Location = point7;
      chkbRecordSelection.Name = "chkbRecordSelection";
      CheckBox chkbRecordSelection2 = chkbRecordSelection;
      size1 = new Size(160, 16);
      Size size5 = size1;
      chkbRecordSelection2.Size = size5;
      chkbRecordSelection.TabIndex = 2;
      chkbRecordSelection.Text = "&Record selection in file";
      chkbRecordSelection.Visible = false;
      AcceptButton = btnOK;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = this.btnCancel;
      size1 = new Size(352, 173);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(btnOK);
      Controls.Add(lblMsg);
      Controls.Add(rbKotor1);
      Controls.Add(rbKotor2);
      Controls.Add(this.btnCancel);
      Controls.Add(chkbRecordSelection);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      size1 = new Size(360, 240);
      MaximumSize = size1;
      Name = nameof (frmSpecifyKotorVersion);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Specify KotOR Version";
      ResumeLayout(false);
    }

  private void rb_CheckedChanged(object sender, EventArgs e) => btnOK.Enabled = true;

  public int KotorVerIndexSelected => rbKotor1.Checked ? 0 : 1;

  public string FileName
  {
    set
    {
        Label lblMsg = this.lblMsg;
        lblMsg.Text = lblMsg.Text + ": " + value;
      }
  }
}