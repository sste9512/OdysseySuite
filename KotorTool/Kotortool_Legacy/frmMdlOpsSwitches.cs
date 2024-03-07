// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmMdlOpsSwitches
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmMdlOpsSwitches : Form
{
  [AccessedThroughProperty("chkbExportMdlAlignData")]
  private CheckBox _chkbExportMdlAlignData;
  [AccessedThroughProperty("chkbMdlAlignDataOnly")]
  private CheckBox _chkbMdlAlignDataOnly;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("btnModuleExportPath")]
  private Button _btnModuleExportPath;
  [AccessedThroughProperty("chkbExtractAnimations")]
  private CheckBox _chkbExtractAnimations;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("chkbConvertSkin")]
  private CheckBox _chkbConvertSkin;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("nudNumberToExtract")]
  private NumericUpDown _nudNumberToExtract;
  [AccessedThroughProperty("chkbEachModelInOwnDir")]
  private CheckBox _chkbEachModelInOwnDir;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("chkbCleanWorkingDir")]
  private CheckBox _chkbCleanWorkingDir;
  [AccessedThroughProperty("tbModelExtractionPath")]
  private TextBox _tbModelExtractionPath;
  private IContainer components;

  public frmMdlOpsSwitches()
  {
      Load += new EventHandler(frmMdlOpsSwitches_Load);
      InitializeComponent();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual CheckBox chkbExtractAnimations
  {
    get => _chkbExtractAnimations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbExtractAnimations == null)
          ;
        _chkbExtractAnimations = value;
        if (_chkbExtractAnimations == null)
          ;
      }
  }

  internal virtual CheckBox chkbConvertSkin
  {
    get => _chkbConvertSkin;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbConvertSkin == null)
          ;
        _chkbConvertSkin = value;
        if (_chkbConvertSkin == null)
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

  internal virtual NumericUpDown nudNumberToExtract
  {
    get => _nudNumberToExtract;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudNumberToExtract == null)
          ;
        _nudNumberToExtract = value;
        if (_nudNumberToExtract == null)
          ;
      }
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

  internal virtual CheckBox chkbEachModelInOwnDir
  {
    get => _chkbEachModelInOwnDir;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbEachModelInOwnDir == null)
          ;
        _chkbEachModelInOwnDir = value;
        if (_chkbEachModelInOwnDir == null)
          ;
      }
  }

  internal virtual CheckBox chkbCleanWorkingDir
  {
    get => _chkbCleanWorkingDir;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbCleanWorkingDir == null)
          ;
        _chkbCleanWorkingDir = value;
        if (_chkbCleanWorkingDir == null)
          ;
      }
  }

  internal virtual TextBox tbModelExtractionPath
  {
    get => _tbModelExtractionPath;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbModelExtractionPath == null)
          ;
        _tbModelExtractionPath = value;
        if (_tbModelExtractionPath == null)
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

  internal virtual Label Label15
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label15 == null)
          ;
        _Label15 = value;
        if (_Label15 == null)
          ;
      }
    get => _Label15;
  }

  internal virtual CheckBox chkbMdlAlignDataOnly
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbMdlAlignDataOnly != null)
          _chkbMdlAlignDataOnly.CheckedChanged -= new EventHandler(chkbMdlAlignDataOnly_CheckedChanged);
        _chkbMdlAlignDataOnly = value;
        if (_chkbMdlAlignDataOnly == null)
          return;
        _chkbMdlAlignDataOnly.CheckedChanged += new EventHandler(chkbMdlAlignDataOnly_CheckedChanged);
      }
    get => _chkbMdlAlignDataOnly;
  }

  internal virtual CheckBox chkbExportMdlAlignData
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbExportMdlAlignData != null)
          _chkbExportMdlAlignData.CheckedChanged -= new EventHandler(chkbExportMdlAlignData_CheckedChanged);
        _chkbExportMdlAlignData = value;
        if (_chkbExportMdlAlignData == null)
          return;
        _chkbExportMdlAlignData.CheckedChanged += new EventHandler(chkbExportMdlAlignData_CheckedChanged);
      }
    get => _chkbExportMdlAlignData;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmMdlOpsSwitches));
      chkbExtractAnimations = new CheckBox();
      chkbConvertSkin = new CheckBox();
      Label1 = new Label();
      btnOK = new Button();
      this.btnCancel = new Button();
      nudNumberToExtract = new NumericUpDown();
      Label2 = new Label();
      chkbEachModelInOwnDir = new CheckBox();
      chkbCleanWorkingDir = new CheckBox();
      tbModelExtractionPath = new TextBox();
      btnModuleExportPath = new Button();
      Label15 = new Label();
      chkbMdlAlignDataOnly = new CheckBox();
      chkbExportMdlAlignData = new CheckBox();
      nudNumberToExtract.BeginInit();
      SuspendLayout();
      chkbExtractAnimations.Checked = true;
      chkbExtractAnimations.CheckState = CheckState.Checked;
      CheckBox extractAnimations1 = chkbExtractAnimations;
      Point point1 = new Point(24, 56);
      Point point2 = point1;
      extractAnimations1.Location = point2;
      chkbExtractAnimations.Name = "chkbExtractAnimations";
      CheckBox extractAnimations2 = chkbExtractAnimations;
      Size size1 = new Size(144, 24);
      Size size2 = size1;
      extractAnimations2.Size = size2;
      chkbExtractAnimations.TabIndex = 0;
      chkbExtractAnimations.Text = "Extract animations";
      chkbConvertSkin.Checked = true;
      chkbConvertSkin.CheckState = CheckState.Checked;
      CheckBox chkbConvertSkin1 = chkbConvertSkin;
      point1 = new Point(24, 88);
      Point point3 = point1;
      chkbConvertSkin1.Location = point3;
      chkbConvertSkin.Name = "chkbConvertSkin";
      CheckBox chkbConvertSkin2 = chkbConvertSkin;
      size1 = new Size(144, 24);
      Size size3 = size1;
      chkbConvertSkin2.Size = size3;
      chkbConvertSkin.TabIndex = 2;
      chkbConvertSkin.Text = "Convert skin to trimesh";
      Label label1_1 = Label1;
      point1 = new Point(152, 24);
      Point point4 = point1;
      label1_1.Location = point4;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(168, 23);
      Size size4 = size1;
      label1_2.Size = size4;
      Label1.TabIndex = 1;
      Label1.Text = "Select model extraction options";
      btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnOK.DialogResult = DialogResult.OK;
      Button btnOk = btnOK;
      point1 = new Point(280, 216);
      Point point5 = point1;
      btnOk.Location = point5;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 7;
      btnOK.Text = "OK";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(384, 216);
      Point point6 = point1;
      btnCancel.Location = point6;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Cancel";
      NumericUpDown nudNumberToExtract1 = nudNumberToExtract;
      point1 = new Point(248, 126);
      Point point7 = point1;
      nudNumberToExtract1.Location = point7;
      NumericUpDown nudNumberToExtract2 = nudNumberToExtract;
      Decimal num1 = new Decimal(new int[4]
      {
        10000,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      nudNumberToExtract2.Maximum = num2;
      NumericUpDown nudNumberToExtract3 = nudNumberToExtract;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num3 = num1;
      nudNumberToExtract3.Minimum = num3;
      nudNumberToExtract.Name = "nudNumberToExtract";
      NumericUpDown nudNumberToExtract4 = nudNumberToExtract;
      size1 = new Size(56, 20);
      Size size5 = size1;
      nudNumberToExtract4.Size = size5;
      nudNumberToExtract.TabIndex = 4;
      nudNumberToExtract.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudNumberToExtract5 = nudNumberToExtract;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num4 = num1;
      nudNumberToExtract5.Value = num4;
      Label label2_1 = Label2;
      point1 = new Point(24, 128);
      Point point8 = point1;
      label2_1.Location = point8;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(216, 24);
      Size size6 = size1;
      label2_2.Size = size6;
      Label2.TabIndex = 4;
      Label2.Text = "Number of consecutive models to extract";
      chkbEachModelInOwnDir.Checked = true;
      chkbEachModelInOwnDir.CheckState = CheckState.Checked;
      CheckBox eachModelInOwnDir1 = chkbEachModelInOwnDir;
      point1 = new Point(200, 88);
      Point point9 = point1;
      eachModelInOwnDir1.Location = point9;
      chkbEachModelInOwnDir.Name = "chkbEachModelInOwnDir";
      CheckBox eachModelInOwnDir2 = chkbEachModelInOwnDir;
      size1 = new Size(168, 24);
      Size size7 = size1;
      eachModelInOwnDir2.Size = size7;
      chkbEachModelInOwnDir.TabIndex = 3;
      chkbEachModelInOwnDir.Text = "Each model in own directory";
      CheckBox chkbCleanWorkingDir1 = chkbCleanWorkingDir;
      point1 = new Point(200, 56);
      Point point10 = point1;
      chkbCleanWorkingDir1.Location = point10;
      chkbCleanWorkingDir.Name = "chkbCleanWorkingDir";
      CheckBox chkbCleanWorkingDir2 = chkbCleanWorkingDir;
      size1 = new Size(272, 24);
      Size size8 = size1;
      chkbCleanWorkingDir2.Size = size8;
      chkbCleanWorkingDir.TabIndex = 1;
      chkbCleanWorkingDir.Text = "Clean Model Export directory before export starts";
      tbModelExtractionPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TextBox modelExtractionPath1 = tbModelExtractionPath;
      point1 = new Point(24, 176);
      Point point11 = point1;
      modelExtractionPath1.Location = point11;
      tbModelExtractionPath.Name = "tbModelExtractionPath";
      TextBox modelExtractionPath2 = tbModelExtractionPath;
      size1 = new Size(392, 20);
      Size size9 = size1;
      modelExtractionPath2.Size = size9;
      tbModelExtractionPath.TabIndex = 5;
      tbModelExtractionPath.Text = "";
      btnModuleExportPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      Button moduleExportPath1 = btnModuleExportPath;
      point1 = new Point(424, 176);
      Point point12 = point1;
      moduleExportPath1.Location = point12;
      btnModuleExportPath.Name = "btnModuleExportPath";
      Button moduleExportPath2 = btnModuleExportPath;
      size1 = new Size(24, 20);
      Size size10 = size1;
      moduleExportPath2.Size = size10;
      btnModuleExportPath.TabIndex = 6;
      btnModuleExportPath.Text = "...";
      Label label15_1 = Label15;
      point1 = new Point(24, 160);
      Point point13 = point1;
      label15_1.Location = point13;
      Label15.Name = "Label15";
      Label label15_2 = Label15;
      size1 = new Size(96, 16);
      Size size11 = size1;
      label15_2.Size = size11;
      Label15.TabIndex = 20;
      Label15.Text = "Model Export path";
      CheckBox mdlAlignDataOnly1 = chkbMdlAlignDataOnly;
      point1 = new Point(312, 136);
      Point point14 = point1;
      mdlAlignDataOnly1.Location = point14;
      chkbMdlAlignDataOnly.Name = "chkbMdlAlignDataOnly";
      CheckBox mdlAlignDataOnly2 = chkbMdlAlignDataOnly;
      size1 = new Size(168, 16);
      Size size12 = size1;
      mdlAlignDataOnly2.Size = size12;
      chkbMdlAlignDataOnly.TabIndex = 3;
      chkbMdlAlignDataOnly.Text = "Alignment data only";
      chkbMdlAlignDataOnly.Visible = false;
      CheckBox exportMdlAlignData1 = chkbExportMdlAlignData;
      point1 = new Point(312, 112);
      Point point15 = point1;
      exportMdlAlignData1.Location = point15;
      chkbExportMdlAlignData.Name = "chkbExportMdlAlignData";
      CheckBox exportMdlAlignData2 = chkbExportMdlAlignData;
      size1 = new Size(168, 16);
      Size size13 = size1;
      exportMdlAlignData2.Size = size13;
      chkbExportMdlAlignData.TabIndex = 3;
      chkbExportMdlAlignData.Text = "Create model alignment data";
      chkbExportMdlAlignData.Visible = false;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(480, 253);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(Label15);
      Controls.Add(btnModuleExportPath);
      Controls.Add(tbModelExtractionPath);
      Controls.Add(Label2);
      Controls.Add(nudNumberToExtract);
      Controls.Add(btnOK);
      Controls.Add(Label1);
      Controls.Add(chkbExtractAnimations);
      Controls.Add(chkbConvertSkin);
      Controls.Add(this.btnCancel);
      Controls.Add(chkbEachModelInOwnDir);
      Controls.Add(chkbCleanWorkingDir);
      Controls.Add(chkbMdlAlignDataOnly);
      Controls.Add(chkbExportMdlAlignData);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      size1 = new Size(1600, 280);
      MaximumSize = size1;
      size1 = new Size(488, 280);
      MinimumSize = size1;
      Name = nameof (frmMdlOpsSwitches);
      StartPosition = FormStartPosition.CenterParent;
      Text = "Model Extraction Options";
      nudNumberToExtract.EndInit();
      ResumeLayout(false);
    }

  public bool ExtractAnimations => chkbExtractAnimations.Checked;

  public bool ConvertSkin => chkbConvertSkin.Checked;

  private void btnModuleExportPath_Click(object sender, EventArgs e)
  {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.Description = "Locate folder to store exported models in";
      folderBrowserDialog.SelectedPath = tbModelExtractionPath.Text;
      folderBrowserDialog.ShowNewFolderButton = true;
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      tbModelExtractionPath.Text = folderBrowserDialog.SelectedPath;
    }

  private void chkbExportMdlAlignData_CheckedChanged(object sender, EventArgs e) => chkbMdlAlignDataOnly.Checked = !chkbExportMdlAlignData.Checked;

  private void chkbMdlAlignDataOnly_CheckedChanged(object sender, EventArgs e) => chkbExportMdlAlignData.Checked = !chkbMdlAlignDataOnly.Checked;

  private void frmMdlOpsSwitches_Load(object sender, EventArgs e)
  {
    }
}