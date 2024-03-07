// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmPackageTypeSelector
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmPackageTypeSelector : Form
{
  [AccessedThroughProperty("cmbxErfType")]
  private ComboBox _cmbxErfType;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  private IContainer components;

  public frmPackageTypeSelector() => InitializeComponent();

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

  internal virtual ComboBox cmbxErfType
  {
    get => _cmbxErfType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxErfType == null)
          ;
        _cmbxErfType = value;
        if (_cmbxErfType == null)
          ;
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmPackageTypeSelector));
      btnOK = new Button();
      this.btnCancel = new Button();
      Label1 = new Label();
      cmbxErfType = new ComboBox();
      SuspendLayout();
      btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnOK.DialogResult = DialogResult.OK;
      Button btnOk = btnOK;
      Point point1 = new Point(31, 116);
      Point point2 = point1;
      btnOk.Location = point2;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 0;
      btnOK.Text = "OK";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(119, 116);
      Point point3 = point1;
      btnCancel.Location = point3;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 0;
      this.btnCancel.Text = "Cancel";
      Label label1_1 = Label1;
      point1 = new Point(24, 16);
      Point point4 = point1;
      label1_1.Location = point4;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      Size size1 = new Size(168, 23);
      Size size2 = size1;
      label1_2.Size = size2;
      Label1.TabIndex = 2;
      Label1.Text = "Select the type for this Package";
      Label1.TextAlign = ContentAlignment.TopCenter;
      cmbxErfType.Items.AddRange(new object[4]
      {
        "MOD",
        "ERF",
        "HAK",
        "SAV"
      });
      ComboBox cmbxErfType1 = cmbxErfType;
      point1 = new Point(88, 56);
      Point point5 = point1;
      cmbxErfType1.Location = point5;
      cmbxErfType.Name = "cmbxErfType";
      ComboBox cmbxErfType2 = cmbxErfType;
      size1 = new Size(48, 21);
      Size size3 = size1;
      cmbxErfType2.Size = size3;
      cmbxErfType.TabIndex = 3;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(224, 149);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(cmbxErfType);
      Controls.Add(Label1);
      Controls.Add(btnOK);
      Controls.Add(this.btnCancel);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      size1 = new Size(232, 176);
      MaximumSize = size1;
      size1 = new Size(232, 176);
      MinimumSize = size1;
      Name = nameof (frmPackageTypeSelector);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Package Type Selector";
      ResumeLayout(false);
    }

  public frmPackageTypeSelector(string PackageType)
    : this()
  {
      cmbxErfType.SelectedIndex = cmbxErfType.FindStringExact(PackageType);
    }

  public string PackageType => StringType.FromObject(cmbxErfType.SelectedItem);
}