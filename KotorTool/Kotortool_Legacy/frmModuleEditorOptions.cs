// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmModuleEditorOptions
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmModuleEditorOptions : Form
{
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("btnModuleExportPath")]
  private Button _btnModuleExportPath;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("tbModuleExportPath")]
  private TextBox _tbModuleExportPath;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("nudDotSize")]
  private NumericUpDown _nudDotSize;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("chkbShowLocatorRay")]
  private CheckBox _chkbShowLocatorRay;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("chkbConfirmDeletes")]
  private CheckBox _chkbConfirmDeletes;
  private IContainer components;

  public frmModuleEditorOptions() => InitializeComponent();

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
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

  internal virtual CheckBox chkbShowLocatorRay
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbShowLocatorRay == null)
          ;
        _chkbShowLocatorRay = value;
        if (_chkbShowLocatorRay == null)
          ;
      }
    get => _chkbShowLocatorRay;
  }

  internal virtual CheckBox chkbConfirmDeletes
  {
    get => _chkbConfirmDeletes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbConfirmDeletes == null)
          ;
        _chkbConfirmDeletes = value;
        if (_chkbConfirmDeletes == null)
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

  internal virtual NumericUpDown nudDotSize
  {
    get => _nudDotSize;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudDotSize == null)
          ;
        _nudDotSize = value;
        if (_nudDotSize == null)
          ;
      }
  }

  internal virtual Button btnModuleExportPath
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnModuleExportPath != null)
          _btnModuleExportPath.Click -= new EventHandler(btnModuleExportPath_Click);
        _btnModuleExportPath = value;
        if (_btnModuleExportPath == null)
          return;
        _btnModuleExportPath.Click += new EventHandler(btnModuleExportPath_Click);
      }
    get => _btnModuleExportPath;
  }

  internal virtual Label Label4
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label4 == null)
          ;
        _Label4 = value;
        if (_Label4 == null)
          ;
      }
    get => _Label4;
  }

  internal virtual TextBox tbModuleExportPath
  {
    get => _tbModuleExportPath;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbModuleExportPath == null)
          ;
        _tbModuleExportPath = value;
        if (_tbModuleExportPath == null)
          ;
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmModuleEditorOptions));
      Label1 = new Label();
      nudDotSize = new NumericUpDown();
      Label2 = new Label();
      Label3 = new Label();
      chkbShowLocatorRay = new CheckBox();
      chkbConfirmDeletes = new CheckBox();
      btnOK = new Button();
      this.btnCancel = new Button();
      btnModuleExportPath = new Button();
      tbModuleExportPath = new TextBox();
      Label4 = new Label();
      nudDotSize.BeginInit();
      SuspendLayout();
      Label label1_1 = Label1;
      Point point1 = new Point(40, 40);
      Point point2 = point1;
      label1_1.Location = point2;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      Size size1 = new Size(136, 16);
      Size size2 = size1;
      label1_2.Size = size2;
      Label1.TabIndex = 0;
      Label1.Text = "Module Element Dot Size";
      nudDotSize.DecimalPlaces = 2;
      NumericUpDown nudDotSize1 = nudDotSize;
      Decimal num1 = new Decimal(new int[4]
      {
        25,
        0,
        0,
        131072
      });
      Decimal num2 = num1;
      nudDotSize1.Increment = num2;
      NumericUpDown nudDotSize2 = nudDotSize;
      point1 = new Point(184, 38);
      Point point3 = point1;
      nudDotSize2.Location = point3;
      NumericUpDown nudDotSize3 = nudDotSize;
      num1 = new Decimal(new int[4]{ 4, 0, 0, 0 });
      Decimal num3 = num1;
      nudDotSize3.Maximum = num3;
      NumericUpDown nudDotSize4 = nudDotSize;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num4 = num1;
      nudDotSize4.Minimum = num4;
      nudDotSize.Name = "nudDotSize";
      NumericUpDown nudDotSize5 = nudDotSize;
      size1 = new Size(48, 20);
      Size size3 = size1;
      nudDotSize5.Size = size3;
      nudDotSize.TabIndex = 1;
      NumericUpDown nudDotSize6 = nudDotSize;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num5 = num1;
      nudDotSize6.Value = num5;
      Label label2_1 = Label2;
      point1 = new Point(40, 80);
      Point point4 = point1;
      label2_1.Location = point4;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(136, 16);
      Size size4 = size1;
      label2_2.Size = size4;
      Label2.TabIndex = 0;
      Label2.Text = "Show Locator Ray";
      Label label3_1 = Label3;
      point1 = new Point(40, 120);
      Point point5 = point1;
      label3_1.Location = point5;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(136, 16);
      Size size5 = size1;
      label3_2.Size = size5;
      Label3.TabIndex = 0;
      Label3.Text = "Confirm Deletes";
      CheckBox chkbShowLocatorRay1 = chkbShowLocatorRay;
      point1 = new Point(184, 76);
      Point point6 = point1;
      chkbShowLocatorRay1.Location = point6;
      chkbShowLocatorRay.Name = "chkbShowLocatorRay";
      CheckBox chkbShowLocatorRay2 = chkbShowLocatorRay;
      size1 = new Size(24, 24);
      Size size6 = size1;
      chkbShowLocatorRay2.Size = size6;
      chkbShowLocatorRay.TabIndex = 2;
      CheckBox chkbConfirmDeletes1 = chkbConfirmDeletes;
      point1 = new Point(184, 112);
      Point point7 = point1;
      chkbConfirmDeletes1.Location = point7;
      chkbConfirmDeletes.Name = "chkbConfirmDeletes";
      CheckBox chkbConfirmDeletes2 = chkbConfirmDeletes;
      size1 = new Size(24, 24);
      Size size7 = size1;
      chkbConfirmDeletes2.Size = size7;
      chkbConfirmDeletes.TabIndex = 2;
      btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnOK.DialogResult = DialogResult.OK;
      Button btnOk = btnOK;
      point1 = new Point(260, 208);
      Point point8 = point1;
      btnOk.Location = point8;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 3;
      btnOK.Text = "OK";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(348, 208);
      Point point9 = point1;
      btnCancel.Location = point9;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Cancel";
      btnModuleExportPath.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button moduleExportPath1 = btnModuleExportPath;
      point1 = new Point(392, 160);
      Point point10 = point1;
      moduleExportPath1.Location = point10;
      btnModuleExportPath.Name = "btnModuleExportPath";
      Button moduleExportPath2 = btnModuleExportPath;
      size1 = new Size(24, 20);
      Size size8 = size1;
      moduleExportPath2.Size = size8;
      btnModuleExportPath.TabIndex = 14;
      btnModuleExportPath.Text = "...";
      tbModuleExportPath.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TextBox moduleExportPath3 = tbModuleExportPath;
      point1 = new Point(176, 160);
      Point point11 = point1;
      moduleExportPath3.Location = point11;
      tbModuleExportPath.Name = "tbModuleExportPath";
      TextBox moduleExportPath4 = tbModuleExportPath;
      size1 = new Size(200, 20);
      Size size9 = size1;
      moduleExportPath4.Size = size9;
      tbModuleExportPath.TabIndex = 13;
      tbModuleExportPath.Text = "";
      Label label4_1 = Label4;
      point1 = new Point(40, 160);
      Point point12 = point1;
      label4_1.Location = point12;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(112, 16);
      Size size10 = size1;
      label4_2.Size = size10;
      Label4.TabIndex = 15;
      Label4.Text = "Module Export path";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = this.btnCancel;
      size1 = new Size(448, 253);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(btnModuleExportPath);
      Controls.Add(tbModuleExportPath);
      Controls.Add(Label4);
      Controls.Add(btnOK);
      Controls.Add(chkbShowLocatorRay);
      Controls.Add(nudDotSize);
      Controls.Add(Label1);
      Controls.Add(Label2);
      Controls.Add(Label3);
      Controls.Add(chkbConfirmDeletes);
      Controls.Add(this.btnCancel);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      size1 = new Size(300, 240);
      MinimumSize = size1;
      Name = nameof (frmModuleEditorOptions);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Module Editor Options";
      nudDotSize.EndInit();
      ResumeLayout(false);
    }

  public Decimal ModuleElementIndicatorSize
  {
    get => nudDotSize.Value;
    set
    {
        if (Convert.ToDouble(value) < 1.0)
          value = 1M;
        if (Convert.ToDouble(value) > 4.0)
          value = 4M;
        nudDotSize.Value = value;
      }
  }

  public bool ConfirmDeletes
  {
    get => chkbConfirmDeletes.Checked;
    set => chkbConfirmDeletes.Checked = value;
  }

  public bool ShowLocatorRay
  {
    get => chkbShowLocatorRay.Checked;
    set => chkbShowLocatorRay.Checked = value;
  }

  public string ModuleExportPath
  {
    get => tbModuleExportPath.Text.Trim();
    set => tbModuleExportPath.Text = value;
  }

  private void btnModuleExportPath_Click(object sender, EventArgs e)
  {
      TextBox moduleExportPath = tbModuleExportPath;
      BrowseForModFile(ref moduleExportPath);
      tbModuleExportPath = moduleExportPath;
    }

  private void BrowseForModFile(ref TextBox fld)
  {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      saveFileDialog2.Title = "Select Module file to export to...";
      saveFileDialog2.Filter = "Module Files (*.mod)|*.mod";
      saveFileDialog2.ValidateNames = true;
      saveFileDialog2.DefaultExt = ".mod";
      saveFileDialog2.CheckPathExists = true;
      saveFileDialog2.AddExtension = true;
      saveFileDialog2.CheckFileExists = false;
      saveFileDialog2.CreatePrompt = false;
      saveFileDialog2.FilterIndex = 1;
      saveFileDialog2.RestoreDirectory = true;
      if (StringType.StrCmp(fld.Text, "", false) != 0)
      {
        saveFileDialog1.InitialDirectory = Strings.Mid(fld.Text, 1, fld.Text.LastIndexOf("\\"));
        saveFileDialog1.FileName = Strings.Mid(fld.Text, checked (fld.Text.LastIndexOf("\\") + 2));
      }
      if (saveFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      fld.Text = saveFileDialog1.FileName;
    }
}