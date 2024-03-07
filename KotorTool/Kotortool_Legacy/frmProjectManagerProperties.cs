// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmProjectManagerProperties
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmProjectManagerProperties : frmParent
{
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("btnReleasePath")]
  private Button _btnReleasePath;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("rbKotor2")]
  private RadioButton _rbKotor2;
  [AccessedThroughProperty("tbDebugPath")]
  private TextBox _tbDebugPath;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("btnKotorPath")]
  private Button _btnKotorPath;
  [AccessedThroughProperty("tbReleasePath")]
  private TextBox _tbReleasePath;
  [AccessedThroughProperty("btnSelectProject")]
  private Button _btnSelectProject;
  [AccessedThroughProperty("tbProjectPath")]
  private TextBox _tbProjectPath;
  [AccessedThroughProperty("tbProjectName")]
  private TextBox _tbProjectName;
  [AccessedThroughProperty("rbKotor1")]
  private RadioButton _rbKotor1;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  private string mode;
  private IContainer components;

  public frmProjectManagerProperties()
  {
      mode = "new";
      InitializeComponent();
    }

  public frmProjectManagerProperties(string FormMode)
    : this()
  {
      mode = FormMode;
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
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

  internal virtual Button btnKotorPath
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnKotorPath != null)
          _btnKotorPath.Click -= new EventHandler(btnKotorPath_Click);
        _btnKotorPath = value;
        if (_btnKotorPath == null)
          return;
        _btnKotorPath.Click += new EventHandler(btnKotorPath_Click);
      }
    get => _btnKotorPath;
  }

  internal virtual Button btnReleasePath
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnReleasePath != null)
          _btnReleasePath.Click -= new EventHandler(btnReleasePath_Click);
        _btnReleasePath = value;
        if (_btnReleasePath == null)
          return;
        _btnReleasePath.Click += new EventHandler(btnReleasePath_Click);
      }
    get => _btnReleasePath;
  }

  internal virtual TextBox tbDebugPath
  {
    get => _tbDebugPath;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbDebugPath == null)
          ;
        _tbDebugPath = value;
        if (_tbDebugPath == null)
          ;
      }
  }

  internal virtual TextBox tbReleasePath
  {
    get => _tbReleasePath;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbReleasePath == null)
          ;
        _tbReleasePath = value;
        if (_tbReleasePath == null)
          ;
      }
  }

  internal virtual Button btnOK
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnOK != null)
          _btnOK.Click -= new EventHandler(btnOK_Click);
        _btnOK = value;
        if (_btnOK == null)
          return;
        _btnOK.Click += new EventHandler(btnOK_Click);
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

  internal virtual Button btnSelectProject
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSelectProject != null)
          _btnSelectProject.Click -= new EventHandler(btnSelectProject_Click);
        _btnSelectProject = value;
        if (_btnSelectProject == null)
          return;
        _btnSelectProject.Click += new EventHandler(btnSelectProject_Click);
      }
    get => _btnSelectProject;
  }

  internal virtual TextBox tbProjectPath
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbProjectPath == null)
          ;
        _tbProjectPath = value;
        if (_tbProjectPath == null)
          ;
      }
    get => _tbProjectPath;
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

  internal virtual TextBox tbProjectName
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbProjectName == null)
          ;
        _tbProjectName = value;
        if (_tbProjectName == null)
          ;
      }
    get => _tbProjectName;
  }

  internal virtual RadioButton rbKotor1
  {
    get => _rbKotor1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbKotor1 == null)
          ;
        _rbKotor1 = value;
        if (_rbKotor1 == null)
          ;
      }
  }

  internal virtual RadioButton rbKotor2
  {
    get => _rbKotor2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbKotor2 == null)
          ;
        _rbKotor2 = value;
        if (_rbKotor2 == null)
          ;
      }
  }

  internal virtual Label Label5
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label5 == null)
          ;
        _Label5 = value;
        if (_Label5 == null)
          ;
      }
    get => _Label5;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      tbProjectPath = new TextBox();
      tbDebugPath = new TextBox();
      tbReleasePath = new TextBox();
      Label1 = new Label();
      Label2 = new Label();
      Label3 = new Label();
      btnKotorPath = new Button();
      btnReleasePath = new Button();
      btnOK = new Button();
      this.btnCancel = new Button();
      btnSelectProject = new Button();
      Label4 = new Label();
      tbProjectName = new TextBox();
      rbKotor1 = new RadioButton();
      rbKotor2 = new RadioButton();
      Label5 = new Label();
      SuspendLayout();
      tbProjectPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TextBox tbProjectPath1 = tbProjectPath;
      Point point1 = new Point(168, 56);
      Point point2 = point1;
      tbProjectPath1.Location = point2;
      tbProjectPath.Name = "tbProjectPath";
      TextBox tbProjectPath2 = tbProjectPath;
      Size size1 = new Size(200, 20);
      Size size2 = size1;
      tbProjectPath2.Size = size2;
      tbProjectPath.TabIndex = 1;
      tbProjectPath.Text = "";
      tbDebugPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TextBox tbDebugPath1 = tbDebugPath;
      point1 = new Point(168, 96);
      Point point3 = point1;
      tbDebugPath1.Location = point3;
      tbDebugPath.Name = "tbDebugPath";
      TextBox tbDebugPath2 = tbDebugPath;
      size1 = new Size(200, 20);
      Size size3 = size1;
      tbDebugPath2.Size = size3;
      tbDebugPath.TabIndex = 3;
      tbDebugPath.Text = "";
      tbReleasePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TextBox tbReleasePath1 = tbReleasePath;
      point1 = new Point(168, 136);
      Point point4 = point1;
      tbReleasePath1.Location = point4;
      tbReleasePath.Name = "tbReleasePath";
      TextBox tbReleasePath2 = tbReleasePath;
      size1 = new Size(200, 20);
      Size size4 = size1;
      tbReleasePath2.Size = size4;
      tbReleasePath.TabIndex = 5;
      tbReleasePath.Text = "";
      Label label1_1 = Label1;
      point1 = new Point(24, 56);
      Point point5 = point1;
      label1_1.Location = point5;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(100, 16);
      Size size5 = size1;
      label1_2.Size = size5;
      Label1.TabIndex = 1;
      Label1.Text = "Project File";
      Label label2_1 = Label2;
      point1 = new Point(24, 96);
      Point point6 = point1;
      label2_1.Location = point6;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(160, 16);
      Size size6 = size1;
      label2_2.Size = size6;
      Label2.TabIndex = 1;
      Label2.Text = "Debug mode output path";
      Label label3_1 = Label3;
      point1 = new Point(24, 133);
      Point point7 = point1;
      label3_1.Location = point7;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(128, 26);
      Size size7 = size1;
      label3_2.Size = size7;
      Label3.TabIndex = 1;
      Label3.Text = "Release mode output and temporary data path";
      btnKotorPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      Button btnKotorPath1 = btnKotorPath;
      point1 = new Point(400, 97);
      Point point8 = point1;
      btnKotorPath1.Location = point8;
      btnKotorPath.Name = "btnKotorPath";
      Button btnKotorPath2 = btnKotorPath;
      size1 = new Size(24, 20);
      Size size8 = size1;
      btnKotorPath2.Size = size8;
      btnKotorPath.TabIndex = 4;
      btnKotorPath.Text = "...";
      btnReleasePath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      Button btnReleasePath1 = btnReleasePath;
      point1 = new Point(400, 137);
      Point point9 = point1;
      btnReleasePath1.Location = point9;
      btnReleasePath.Name = "btnReleasePath";
      Button btnReleasePath2 = btnReleasePath;
      size1 = new Size(24, 20);
      Size size9 = size1;
      btnReleasePath2.Size = size9;
      btnReleasePath.TabIndex = 6;
      btnReleasePath.Text = "...";
      btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnOk = btnOK;
      point1 = new Point(264, 232);
      Point point10 = point1;
      btnOk.Location = point10;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 9;
      btnOK.Text = "OK";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(352, 232);
      Point point11 = point1;
      btnCancel.Location = point11;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 10;
      this.btnCancel.Text = "Cancel";
      btnSelectProject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      Button btnSelectProject1 = btnSelectProject;
      point1 = new Point(400, 57);
      Point point12 = point1;
      btnSelectProject1.Location = point12;
      btnSelectProject.Name = "btnSelectProject";
      Button btnSelectProject2 = btnSelectProject;
      size1 = new Size(24, 20);
      Size size10 = size1;
      btnSelectProject2.Size = size10;
      btnSelectProject.TabIndex = 2;
      btnSelectProject.Text = "...";
      Label label4_1 = Label4;
      point1 = new Point(24, 16);
      Point point13 = point1;
      label4_1.Location = point13;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(100, 16);
      Size size11 = size1;
      label4_2.Size = size11;
      Label4.TabIndex = 1;
      Label4.Text = "Project Name";
      TextBox tbProjectName1 = tbProjectName;
      point1 = new Point(168, 16);
      Point point14 = point1;
      tbProjectName1.Location = point14;
      tbProjectName.Name = "tbProjectName";
      TextBox tbProjectName2 = tbProjectName;
      size1 = new Size(128, 20);
      Size size12 = size1;
      tbProjectName2.Size = size12;
      tbProjectName.TabIndex = 0;
      tbProjectName.Text = "";
      RadioButton rbKotor1_1 = rbKotor1;
      point1 = new Point(168, 184);
      Point point15 = point1;
      rbKotor1_1.Location = point15;
      rbKotor1.Name = "rbKotor1";
      RadioButton rbKotor1_2 = rbKotor1;
      size1 = new Size(72, 20);
      Size size13 = size1;
      rbKotor1_2.Size = size13;
      rbKotor1.TabIndex = 7;
      rbKotor1.Text = "&KotOR I";
      RadioButton rbKotor2_1 = rbKotor2;
      point1 = new Point(256, 184);
      Point point16 = point1;
      rbKotor2_1.Location = point16;
      rbKotor2.Name = "rbKotor2";
      RadioButton rbKotor2_2 = rbKotor2;
      size1 = new Size(106, 20);
      Size size14 = size1;
      rbKotor2_2.Size = size14;
      rbKotor2.TabIndex = 8;
      rbKotor2.Text = "KotOR II : &TSL";
      Label label5_1 = Label5;
      point1 = new Point(24, 184);
      Point point17 = point1;
      label5_1.Location = point17;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(128, 16);
      Size size15 = size1;
      label5_2.Size = size15;
      Label5.TabIndex = 1;
      Label5.Text = "Target Game";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(464, 277);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(rbKotor1);
      Controls.Add(rbKotor2);
      Controls.Add(btnOK);
      Controls.Add(this.btnCancel);
      Controls.Add(btnKotorPath);
      Controls.Add(Label1);
      Controls.Add(tbProjectPath);
      Controls.Add(tbDebugPath);
      Controls.Add(tbReleasePath);
      Controls.Add(Label2);
      Controls.Add(Label3);
      Controls.Add(btnReleasePath);
      Controls.Add(btnSelectProject);
      Controls.Add(Label4);
      Controls.Add(tbProjectName);
      Controls.Add(Label5);
      size1 = new Size(1600, 304);
      MaximumSize = size1;
      size1 = new Size(472, 304);
      MinimumSize = size1;
      Name = nameof (frmProjectManagerProperties);
      SizeGripStyle = SizeGripStyle.Show;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Project Properties";
      ResumeLayout(false);
    }

  private void BrowseForFolder(ref TextBox fld)
  {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.Description = "Locate folder";
      folderBrowserDialog.SelectedPath = fld.Text;
      folderBrowserDialog.ShowNewFolderButton = true;
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      fld.Text = folderBrowserDialog.SelectedPath;
    }

  private void BrowseForFile(ref TextBox fld)
  {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Title = "Select save location and project file name...";
      openFileDialog.Filter = "Kotor Tool Project (*.ktp)|*.ktp";
      openFileDialog.InitialDirectory = fld.Text;
      openFileDialog.CheckFileExists = false;
      openFileDialog.FilterIndex = 1;
      openFileDialog.Multiselect = false;
      openFileDialog.RestoreDirectory = true;
      openFileDialog.FileName = "Project.ktp";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      fld.Text = Path.GetDirectoryName(openFileDialog.FileName) + "\\" + Path.GetFileNameWithoutExtension(openFileDialog.FileName) + ".ktp";
    }

  private void btnSelectProject_Click(object sender, EventArgs e)
  {
      TextBox tbProjectPath = this.tbProjectPath;
      BrowseForFile(ref tbProjectPath);
      this.tbProjectPath = tbProjectPath;
    }

  private void btnKotorPath_Click(object sender, EventArgs e)
  {
      TextBox tbDebugPath = this.tbDebugPath;
      BrowseForFolder(ref tbDebugPath);
      this.tbDebugPath = tbDebugPath;
    }

  private void btnReleasePath_Click(object sender, EventArgs e)
  {
      TextBox tbReleasePath = this.tbReleasePath;
      BrowseForFolder(ref tbReleasePath);
      this.tbReleasePath = tbReleasePath;
    }

  private void btnOK_Click(object sender, EventArgs e)
  {
      if (StringType.StrCmp(tbProjectName.Text.Trim(), "", false) == 0)
      {
        int num1 = (int) Interaction.MsgBox("Project name not specified\nPlease check your selection", MsgBoxStyle.Critical);
      }
      else if (StringType.StrCmp(tbProjectPath.Text.Trim(), "", false) == 0 || StringType.StrCmp(mode, "new", false) != 0 && !Directory.Exists(Path.GetDirectoryName(tbProjectPath.Text.Trim())))
      {
        int num2 = (int) Interaction.MsgBox("Project path not found\nPlease check your selection", MsgBoxStyle.Critical);
      }
      else if (StringType.StrCmp(tbDebugPath.Text.Trim(), "", false) == 0 || !Directory.Exists(tbDebugPath.Text.Trim()))
      {
        int num3 = (int) Interaction.MsgBox("Debug path not found\nPlease check your selection", MsgBoxStyle.Critical);
      }
      else if (StringType.StrCmp(tbReleasePath.Text.Trim(), "", false) == 0 || !Directory.Exists(tbReleasePath.Text.Trim()))
      {
        int num4 = (int) Interaction.MsgBox("Release path not found\nPlease check your selection", MsgBoxStyle.Critical);
      }
      else if (!(rbKotor1.Checked | rbKotor2.Checked))
      {
        int num5 = (int) Interaction.MsgBox("Please select the Target Game for the project", MsgBoxStyle.Critical);
      }
      else
        DialogResult = DialogResult.OK;
    }
}