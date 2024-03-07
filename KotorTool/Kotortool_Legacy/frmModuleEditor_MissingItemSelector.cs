// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmModuleEditor_MissingItemSelector
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmModuleEditor_MissingItemSelector : Form
{
  [AccessedThroughProperty("rbTemplatesBif")]
  private RadioButton _rbTemplatesBif;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("rbGlobalTemplates")]
  private RadioButton _rbGlobalTemplates;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("rbUserPalette")]
  private RadioButton _rbUserPalette;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  private IContainer components;
  private string _ProjectPath;

  public frmModuleEditor_MissingItemSelector() => InitializeComponent();

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual RadioButton rbUserPalette
  {
    get => _rbUserPalette;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbUserPalette != null)
          _rbUserPalette.CheckedChanged -= new EventHandler(CheckedChanged);
        _rbUserPalette = value;
        if (_rbUserPalette == null)
          return;
        _rbUserPalette.CheckedChanged += new EventHandler(CheckedChanged);
      }
  }

  internal virtual RadioButton rbGlobalTemplates
  {
    get => _rbGlobalTemplates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbGlobalTemplates != null)
          _rbGlobalTemplates.CheckedChanged -= new EventHandler(CheckedChanged);
        _rbGlobalTemplates = value;
        if (_rbGlobalTemplates == null)
          return;
        _rbGlobalTemplates.CheckedChanged += new EventHandler(CheckedChanged);
      }
  }

  internal virtual RadioButton rbTemplatesBif
  {
    get => _rbTemplatesBif;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbTemplatesBif != null)
          _rbTemplatesBif.CheckedChanged -= new EventHandler(CheckedChanged);
        _rbTemplatesBif = value;
        if (_rbTemplatesBif == null)
          return;
        _rbTemplatesBif.CheckedChanged += new EventHandler(CheckedChanged);
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmModuleEditor_MissingItemSelector));
      rbUserPalette = new RadioButton();
      rbGlobalTemplates = new RadioButton();
      rbTemplatesBif = new RadioButton();
      Label1 = new Label();
      btnOK = new Button();
      this.btnCancel = new Button();
      Label2 = new Label();
      SuspendLayout();
      RadioButton rbUserPalette1 = rbUserPalette;
      Point point1 = new Point(112, 104);
      Point point2 = point1;
      rbUserPalette1.Location = point2;
      rbUserPalette.Name = "rbUserPalette";
      RadioButton rbUserPalette2 = rbUserPalette;
      Size size1 = new Size(152, 24);
      Size size2 = size1;
      rbUserPalette2.Size = size2;
      rbUserPalette.TabIndex = 0;
      rbUserPalette.Text = "UserPalette folder";
      RadioButton rbGlobalTemplates1 = rbGlobalTemplates;
      point1 = new Point(112, 136);
      Point point3 = point1;
      rbGlobalTemplates1.Location = point3;
      rbGlobalTemplates.Name = "rbGlobalTemplates";
      RadioButton rbGlobalTemplates2 = rbGlobalTemplates;
      size1 = new Size(152, 24);
      Size size3 = size1;
      rbGlobalTemplates2.Size = size3;
      rbGlobalTemplates.TabIndex = 0;
      rbGlobalTemplates.Text = "Global Templates folder";
      RadioButton rbTemplatesBif1 = rbTemplatesBif;
      point1 = new Point(112, 168);
      Point point4 = point1;
      rbTemplatesBif1.Location = point4;
      rbTemplatesBif.Name = "rbTemplatesBif";
      RadioButton rbTemplatesBif2 = rbTemplatesBif;
      size1 = new Size(152, 24);
      Size size4 = size1;
      rbTemplatesBif2.Size = size4;
      rbTemplatesBif.TabIndex = 0;
      rbTemplatesBif.Text = "Templates.bif file";
      Label label1_1 = Label1;
      point1 = new Point(32, 56);
      Point point5 = point1;
      label1_1.Location = point5;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(328, 32);
      Size size5 = size1;
      label1_2.Size = size5;
      Label1.TabIndex = 1;
      Label1.Text = "If you would like to change it to an editable instance, select the source of the template file below:";
      btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnOK.DialogResult = DialogResult.OK;
      btnOK.Enabled = false;
      Button btnOk = btnOK;
      point1 = new Point(192, 216);
      Point point6 = point1;
      btnOk.Location = point6;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 2;
      btnOK.Text = "OK";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(280, 216);
      Point point7 = point1;
      btnCancel.Location = point7;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      Label label2_1 = Label2;
      point1 = new Point(32, 24);
      Point point8 = point1;
      label2_1.Location = point8;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(332, 24);
      Size size6 = size1;
      label2_2.Size = size6;
      Label2.TabIndex = 1;
      Label2.Text = "This item is currently a non-editable reference to a template file.";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(376, 253);
      ClientSize = size1;
      Controls.Add(btnOK);
      Controls.Add(Label1);
      Controls.Add(rbUserPalette);
      Controls.Add(rbGlobalTemplates);
      Controls.Add(rbTemplatesBif);
      Controls.Add(this.btnCancel);
      Controls.Add(Label2);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Name = nameof (frmModuleEditor_MissingItemSelector);
      StartPosition = FormStartPosition.CenterParent;
      Text = "Missing Item Source Selector";
      ResumeLayout(false);
    }

  public string ProjectPath
  {
    set
    {
        _ProjectPath = value;
        if (_ProjectPath.EndsWith("\\"))
          return;
        _ProjectPath += "\\";
      }
  }

  private void CheckedChanged(object sender, EventArgs e) => btnOK.Enabled = rbGlobalTemplates.Checked || rbTemplatesBif.Checked || rbUserPalette.Checked;

  public bool UserPaletteChecked
  {
    get => rbUserPalette.Checked;
    set => rbUserPalette.Checked = value;
  }

  public bool GlobalTemplatesChecked
  {
    get => rbGlobalTemplates.Checked;
    set => rbGlobalTemplates.Checked = value;
  }

  public bool TemplatesBifChecked
  {
    get => rbTemplatesBif.Checked;
    set => rbTemplatesBif.Checked = value;
  }

  public bool UserPaletteAvailable
  {
    set => rbUserPalette.Enabled = value;
  }

  public bool GlobalTemplatesAvailable
  {
    set => rbGlobalTemplates.Enabled = value;
  }

  public bool TemplatesBifAvailable
  {
    set => rbTemplatesBif.Enabled = value;
  }
}