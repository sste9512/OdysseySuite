// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmERFManager
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmERFManager : frmParent
{
  [AccessedThroughProperty("btnRemoveItem")]
  private Button _btnRemoveItem;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("btnAddDirectory")]
  private Button _btnAddDirectory;
  [AccessedThroughProperty("btnSelectOutputFile")]
  private Button _btnSelectOutputFile;
  [AccessedThroughProperty("cmbxErfType")]
  private ComboBox _cmbxErfType;
  [AccessedThroughProperty("tbErfName")]
  private TextBox _tbErfName;
  [AccessedThroughProperty("btnBuild")]
  private Button _btnBuild;
  [AccessedThroughProperty("btnMoveDown")]
  private Button _btnMoveDown;
  [AccessedThroughProperty("btnMoveUp")]
  private Button _btnMoveUp;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("btnAddFile")]
  private Button _btnAddFile;
  [AccessedThroughProperty("ERFContentFiles")]
  private ListBox _ERFContentFiles;
  private IContainer components;
  public ArrayList ERFContentFilesList;

  public frmERFManager()
  {
      Load += new EventHandler(frmERFManager_Load);
      Closing += new CancelEventHandler(frmERFManager_Closing);
      InitializeComponent();
      CurrentSettings = UserSettings.GetSettings();
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

  internal virtual ListBox ERFContentFiles
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ERFContentFiles != null)
        {
          _ERFContentFiles.KeyUp -= new KeyEventHandler(ERFContentFiles_KeyUp);
          _ERFContentFiles.SelectedIndexChanged -= new EventHandler(ERFContentFiles_SelectedIndexChanged);
          _ERFContentFiles.DragDrop -= new DragEventHandler(ERFContentFiles_DragDrop);
          _ERFContentFiles.DragEnter -= new DragEventHandler(ERFContentFiles_DragEnter);
        }
        _ERFContentFiles = value;
        if (_ERFContentFiles == null)
          return;
        _ERFContentFiles.KeyUp += new KeyEventHandler(ERFContentFiles_KeyUp);
        _ERFContentFiles.SelectedIndexChanged += new EventHandler(ERFContentFiles_SelectedIndexChanged);
        _ERFContentFiles.DragDrop += new DragEventHandler(ERFContentFiles_DragDrop);
        _ERFContentFiles.DragEnter += new DragEventHandler(ERFContentFiles_DragEnter);
      }
    get => _ERFContentFiles;
  }

  internal virtual Button btnAddFile
  {
    get => _btnAddFile;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnAddFile != null)
          _btnAddFile.Click -= new EventHandler(btnAddFile_Click);
        _btnAddFile = value;
        if (_btnAddFile == null)
          return;
        _btnAddFile.Click += new EventHandler(btnAddFile_Click);
      }
  }

  internal virtual Button btnRemoveItem
  {
    get => _btnRemoveItem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnRemoveItem != null)
          _btnRemoveItem.Click -= new EventHandler(btnRemoveItem_Click);
        _btnRemoveItem = value;
        if (_btnRemoveItem == null)
          return;
        _btnRemoveItem.Click += new EventHandler(btnRemoveItem_Click);
      }
  }

  internal virtual Button btnMoveUp
  {
    get => _btnMoveUp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnMoveUp != null)
          _btnMoveUp.Click -= new EventHandler(btnMoveUp_Click);
        _btnMoveUp = value;
        if (_btnMoveUp == null)
          return;
        _btnMoveUp.Click += new EventHandler(btnMoveUp_Click);
      }
  }

  internal virtual Button btnMoveDown
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnMoveDown != null)
          _btnMoveDown.Click -= new EventHandler(btnMoveDown_Click);
        _btnMoveDown = value;
        if (_btnMoveDown == null)
          return;
        _btnMoveDown.Click += new EventHandler(btnMoveDown_Click);
      }
    get => _btnMoveDown;
  }

  internal virtual Button btnBuild
  {
    get => _btnBuild;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnBuild != null)
          _btnBuild.Click -= new EventHandler(btnBuild_Click);
        _btnBuild = value;
        if (_btnBuild == null)
          return;
        _btnBuild.Click += new EventHandler(btnBuild_Click);
      }
  }

  internal virtual Button btnCancel
  {
    get => _btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnCancel != null)
          _btnCancel.Click -= new EventHandler(btnCancel_Click);
        _btnCancel = value;
        if (_btnCancel == null)
          return;
        _btnCancel.Click += new EventHandler(btnCancel_Click);
      }
  }

  internal virtual TextBox tbErfName
  {
    get => _tbErfName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbErfName != null)
        {
          _tbErfName.TextChanged -= new EventHandler(tbErfName_TextChanged);
          _tbErfName.ModifiedChanged -= new EventHandler(tbErfName_ModifiedChanged);
        }
        _tbErfName = value;
        if (_tbErfName == null)
          return;
        _tbErfName.TextChanged += new EventHandler(tbErfName_TextChanged);
        _tbErfName.ModifiedChanged += new EventHandler(tbErfName_ModifiedChanged);
      }
  }

  internal virtual ComboBox cmbxErfType
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxErfType != null)
          _cmbxErfType.SelectedIndexChanged -= new EventHandler(cmbxErfType_SelectedIndexChanged);
        _cmbxErfType = value;
        if (_cmbxErfType == null)
          return;
        _cmbxErfType.SelectedIndexChanged += new EventHandler(cmbxErfType_SelectedIndexChanged);
      }
    get => _cmbxErfType;
  }

  internal virtual Button btnSelectOutputFile
  {
    get => _btnSelectOutputFile;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSelectOutputFile != null)
          _btnSelectOutputFile.Click -= new EventHandler(btnSelectOutputFile_Click);
        _btnSelectOutputFile = value;
        if (_btnSelectOutputFile == null)
          return;
        _btnSelectOutputFile.Click += new EventHandler(btnSelectOutputFile_Click);
      }
  }

  internal virtual Button btnAddDirectory
  {
    get => _btnAddDirectory;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnAddDirectory != null)
          _btnAddDirectory.Click -= new EventHandler(btnAddDirectory_Click);
        _btnAddDirectory = value;
        if (_btnAddDirectory == null)
          return;
        _btnAddDirectory.Click += new EventHandler(btnAddDirectory_Click);
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmERFManager));
      Label1 = new Label();
      tbErfName = new TextBox();
      cmbxErfType = new ComboBox();
      Label2 = new Label();
      ERFContentFiles = new ListBox();
      this.btnAddFile = new Button();
      this.btnRemoveItem = new Button();
      this.btnMoveUp = new Button();
      this.btnMoveDown = new Button();
      this.btnBuild = new Button();
      this.btnCancel = new Button();
      btnSelectOutputFile = new Button();
      this.btnAddDirectory = new Button();
      SuspendLayout();
      Label label1_1 = Label1;
      Point point1 = new Point(48, 16);
      Point point2 = point1;
      label1_1.Location = point2;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      Size size1 = new Size(104, 16);
      Size size2 = size1;
      label1_2.Size = size2;
      Label1.TabIndex = 0;
      Label1.Text = "Output file name";
      tbErfName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TextBox tbErfName1 = tbErfName;
      point1 = new Point(24, 40);
      Point point3 = point1;
      tbErfName1.Location = point3;
      tbErfName.Name = "tbErfName";
      TextBox tbErfName2 = tbErfName;
      size1 = new Size(248, 20);
      Size size3 = size1;
      tbErfName2.Size = size3;
      tbErfName.TabIndex = 1;
      tbErfName.Text = "";
      cmbxErfType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      cmbxErfType.Items.AddRange(new object[4]
      {
        "MOD",
        "ERF",
        "HAK",
        "SAV"
      });
      ComboBox cmbxErfType1 = cmbxErfType;
      point1 = new Point(352, 40);
      Point point4 = point1;
      cmbxErfType1.Location = point4;
      cmbxErfType.Name = "cmbxErfType";
      ComboBox cmbxErfType2 = cmbxErfType;
      size1 = new Size(48, 21);
      Size size4 = size1;
      cmbxErfType2.Size = size4;
      cmbxErfType.TabIndex = 2;
      Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      Label label2_1 = Label2;
      point1 = new Point(336, 16);
      Point point5 = point1;
      label2_1.Location = point5;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(80, 24);
      Size size5 = size1;
      label2_2.Size = size5;
      Label2.TabIndex = 0;
      Label2.Text = "Output file type";
      ERFContentFiles.AllowDrop = true;
      ERFContentFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      ERFContentFiles.HorizontalScrollbar = true;
      ListBox erfContentFiles1 = ERFContentFiles;
      point1 = new Point(24, 80);
      Point point6 = point1;
      erfContentFiles1.Location = point6;
      ERFContentFiles.Name = "ERFContentFiles";
      ERFContentFiles.SelectionMode = SelectionMode.MultiExtended;
      ListBox erfContentFiles2 = ERFContentFiles;
      size1 = new Size(288, 290);
      Size size6 = size1;
      erfContentFiles2.Size = size6;
      ERFContentFiles.TabIndex = 3;
      this.btnAddFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      Button btnAddFile = this.btnAddFile;
      point1 = new Point(336, 96);
      Point point7 = point1;
      btnAddFile.Location = point7;
      this.btnAddFile.Name = "btnAddFile";
      this.btnAddFile.TabIndex = 4;
      this.btnAddFile.Text = "Add Files...";
      this.btnRemoveItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnRemoveItem.Enabled = false;
      Button btnRemoveItem = this.btnRemoveItem;
      point1 = new Point(336, 160);
      Point point8 = point1;
      btnRemoveItem.Location = point8;
      this.btnRemoveItem.Name = "btnRemoveItem";
      this.btnRemoveItem.TabIndex = 4;
      this.btnRemoveItem.Text = "Remove";
      this.btnMoveUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnMoveUp.Enabled = false;
      Button btnMoveUp = this.btnMoveUp;
      point1 = new Point(336, 224);
      Point point9 = point1;
      btnMoveUp.Location = point9;
      this.btnMoveUp.Name = "btnMoveUp";
      this.btnMoveUp.TabIndex = 4;
      this.btnMoveUp.Text = "Move Up";
      this.btnMoveDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnMoveDown.Enabled = false;
      Button btnMoveDown = this.btnMoveDown;
      point1 = new Point(336, 264);
      Point point10 = point1;
      btnMoveDown.Location = point10;
      this.btnMoveDown.Name = "btnMoveDown";
      this.btnMoveDown.TabIndex = 4;
      this.btnMoveDown.Text = "Move Down";
      this.btnBuild.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnBuild.Enabled = false;
      Button btnBuild = this.btnBuild;
      point1 = new Point(336, 320);
      Point point11 = point1;
      btnBuild.Location = point11;
      this.btnBuild.Name = "btnBuild";
      this.btnBuild.TabIndex = 4;
      this.btnBuild.Text = "Build ...";
      this.btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(336, 360);
      Point point12 = point1;
      btnCancel.Location = point12;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 4;
      this.btnCancel.Text = "Cancel";
      btnSelectOutputFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      Button selectOutputFile1 = btnSelectOutputFile;
      point1 = new Point(280, 39);
      Point point13 = point1;
      selectOutputFile1.Location = point13;
      btnSelectOutputFile.Name = "btnSelectOutputFile";
      Button selectOutputFile2 = btnSelectOutputFile;
      size1 = new Size(32, 23);
      Size size7 = size1;
      selectOutputFile2.Size = size7;
      btnSelectOutputFile.TabIndex = 4;
      btnSelectOutputFile.Text = "...";
      this.btnAddDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      Button btnAddDirectory = this.btnAddDirectory;
      point1 = new Point(336, 128);
      Point point14 = point1;
      btnAddDirectory.Location = point14;
      this.btnAddDirectory.Name = "btnAddDirectory";
      this.btnAddDirectory.TabIndex = 4;
      this.btnAddDirectory.Text = "Add Dir...";
      AllowDrop = true;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = this.btnCancel;
      size1 = new Size(424, 405);
      ClientSize = size1;
      Controls.Add(this.btnAddFile);
      Controls.Add(ERFContentFiles);
      Controls.Add(cmbxErfType);
      Controls.Add(tbErfName);
      Controls.Add(Label1);
      Controls.Add(Label2);
      Controls.Add(this.btnRemoveItem);
      Controls.Add(this.btnMoveUp);
      Controls.Add(this.btnMoveDown);
      Controls.Add(this.btnBuild);
      Controls.Add(this.btnCancel);
      Controls.Add(btnSelectOutputFile);
      Controls.Add(this.btnAddDirectory);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      size1 = new Size(432, 424);
      MinimumSize = size1;
      Name = nameof (frmERFManager);
      SizeGripStyle = SizeGripStyle.Show;
      StartPosition = FormStartPosition.Manual;
      Text = "ERF Builder";
      ResumeLayout(false);
    }

  private void ERFContentFiles_DragEnter(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;
      e.Effect = DragDropEffects.All;
    }

  private void ERFContentFiles_DragDrop(object sender, DragEventArgs e)
  {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
      {
        string[] data = (string[]) e.Data.GetData(DataFormats.FileDrop);
        int num1 = checked (data.Length - 1);
        int index = 0;
        while (index <= num1)
        {
          if (Path.GetFileNameWithoutExtension(data[index]).Length > 16)
          {
            int num2 = (int) Interaction.MsgBox("The file \"" + data[index] + "\"" + " must be renamed to be no more than 16 characters long, not including the extension, to be used." + "\n" + "\n" + "The file will not be added.", MsgBoxStyle.Critical, "Filename too long");
          }
          else
            ERFContentFiles.Items.Add(data[index]);
          checked { ++index; }
        }
      }
      checkFieldsForBuild();
    }

  private void btnMoveUp_Click(object sender, EventArgs e)
  {
      int selectedIndex = ERFContentFiles.SelectedIndex;
      if (selectedIndex <= 0)
        return;
      string str = StringType.FromObject(ERFContentFiles.SelectedItem);
      ERFContentFiles.Items[selectedIndex] = RuntimeHelpers.GetObjectValue(ERFContentFiles.Items[checked (selectedIndex - 1)]);
      ERFContentFiles.Items[checked (selectedIndex - 1)] = str;
      checked { --ERFContentFiles.SelectedIndex; }
    }

  private void btnMoveDown_Click(object sender, EventArgs e)
  {
      int selectedIndex = ERFContentFiles.SelectedIndex;
      if (selectedIndex >= checked (ERFContentFiles.Items.Count - 1))
        return;
      string str = StringType.FromObject(ERFContentFiles.SelectedItem);
      ERFContentFiles.Items[selectedIndex] = RuntimeHelpers.GetObjectValue(ERFContentFiles.Items[checked (selectedIndex + 1)]);
      ERFContentFiles.Items[checked (selectedIndex + 1)] = str;
      checked { ++ERFContentFiles.SelectedIndex; }
    }

  private void ERFContentFiles_SelectedIndexChanged(object sender, EventArgs e)
  {
      if (ERFContentFiles.SelectedIndex == -1)
      {
        btnMoveUp.Enabled = false;
        btnMoveDown.Enabled = false;
        btnRemoveItem.Enabled = false;
      }
      else
      {
        btnRemoveItem.Enabled = true;
        if (ERFContentFiles.Items.Count == 1 | ERFContentFiles.SelectedIndices.Count > 1)
        {
          btnMoveUp.Enabled = false;
          btnMoveDown.Enabled = false;
        }
        else
        {
          if (ERFContentFiles.SelectedIndices.Count != 1)
            return;
          if (ERFContentFiles.SelectedIndex == checked (ERFContentFiles.Items.Count - 1))
          {
            btnMoveUp.Enabled = true;
            btnMoveDown.Enabled = false;
          }
          else if (ERFContentFiles.SelectedIndex == 0)
          {
            btnMoveUp.Enabled = false;
            btnMoveDown.Enabled = true;
          }
          else
          {
            btnMoveUp.Enabled = true;
            btnMoveDown.Enabled = true;
          }
        }
      }
    }

  private void btnRemoveItem_Click(object sender, EventArgs e)
  {
      if (ERFContentFiles.SelectedIndices.Count == 1)
        RemoveItem();
      else if (ERFContentFiles.SelectedIndices.Count > 1 && Interaction.MsgBox("Remove all " + StringType.FromInteger(ERFContentFiles.SelectedIndices.Count) + " files?", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Confirm removal") == MsgBoxResult.Ok)
      {
        int index = checked (ERFContentFiles.SelectedIndices.Count - 1);
        while (index >= 0)
        {
          ERFContentFiles.Items.RemoveAt(ERFContentFiles.SelectedIndices[index]);
          checked { index += -1; }
        }
      }
      checkFieldsForBuild();
    }

  private void btnSelectOutputFile_Click(object sender, EventArgs e)
  {
      string sLeft = StringType.FromObject(FrmMain.GetFilePath("save", FrmMain.CurrentSettings.defaultSaveLocation, "", "Save ERF file...", ""));
      if (StringType.StrCmp(sLeft, "", false) == 0)
        return;
      tbErfName.Text = sLeft;
    }

  private void btnAddFile_Click(object sender, EventArgs e)
  {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = FrmMain.CurrentSettings.defaultImportLocation;
      openFileDialog.FilterIndex = 1;
      openFileDialog.Multiselect = true;
      openFileDialog.RestoreDirectory = true;
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        string[] fileNames = openFileDialog.FileNames;
        int index = 0;
        while (index < fileNames.Length)
        {
          string path = fileNames[index];
          if (Path.GetFileNameWithoutExtension(path).Length > 16)
          {
            int num = (int) Interaction.MsgBox("The file \"" + path + "\"" + " must be renamed to be no more than 16 characters long, not including the extension, to be used." + "\n" + "\n" + "The file will not be added.", MsgBoxStyle.Critical, "Filename too long");
          }
          else
            ERFContentFiles.Items.Add(path);
          checked { ++index; }
        }
      }
      checkFieldsForBuild();
    }

  private void btnAddDirectory_Click(object sender, EventArgs e)
  {
      string str = BrowseForFolder();
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      ArrayList list = new ArrayList();
      if (Interaction.MsgBox("Do you want to filter out unknown file types?", MsgBoxStyle.YesNo, "Filter files") == MsgBoxResult.No)
      {
        AddFileNamesToList(str, ref list, "*.*");
      }
      else
      {
        AddFileNamesToList(str, ref list, "*.git");
        AddFileNamesToList(str, ref list, "*.are");
        AddFileNamesToList(str, ref list, "*.ifo");
        AddFileNamesToList(str, ref list, "*.pth");
        AddFileNamesToList(str, ref list, "*.u??");
        AddFileNamesToList(str, ref list, "*.ncs");
        AddFileNamesToList(str, ref list, "*.dlg");
      }
      try
      {
        foreach (object obj in list)
          ERFContentFiles.Items.Add(StringType.FromObject(obj));
      }
      finally
      {
       
      }
    }

  private void btnCancel_Click(object sender, EventArgs e) => Close();

  private void btnBuild_Click(object sender, EventArgs e)
  {
      string[] inputFileList = new string[checked (ERFContentFiles.Items.Count - 1 + 1)];
      int num1 = checked (ERFContentFiles.Items.Count - 1);
      int index = 0;
      while (index <= num1)
      {
        inputFileList[index] = StringType.FromObject(ERFContentFiles.Items[index]);
        checked { ++index; }
      }
      ClsErf clsErf = new ClsErf(tbErfName.Text, StringType.FromObject(cmbxErfType.SelectedItem), Convert.ToUInt32(0), null, inputFileList);
      int num2 = (int) Interaction.MsgBox("ERF Build Complete");
      btnCancel.Text = "Done";
      btnCancel.Focus();
    }

  private void ERFContentFiles_KeyUp(object sender, KeyEventArgs e)
  {
      if (e.KeyCode != Keys.Delete || ERFContentFiles.SelectedIndices.Count <= 0)
        return;
      if (ERFContentFiles.SelectedIndices.Count > 1)
      {
        if (Interaction.MsgBox("Remove all " + StringType.FromInteger(ERFContentFiles.SelectedIndices.Count) + "files?", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Confirm removal") != MsgBoxResult.Ok)
          return;
        int index = checked (ERFContentFiles.SelectedIndices.Count - 1);
        while (index >= 0)
        {
          ERFContentFiles.Items.RemoveAt(ERFContentFiles.SelectedIndices[index]);
          checked { index += -1; }
        }
      }
      else
        RemoveItem();
    }

  private void tbErfName_ModifiedChanged(object sender, EventArgs e) => checkFieldsForBuild();

  private void cmbxErfType_SelectedIndexChanged(object sender, EventArgs e)
  {
      checkFieldsForBuild();
      btnBuild.Text = StringType.FromObject(ObjectType.StrCatObj("Build ", cmbxErfType.SelectedItem));
    }

  private void tbErfName_TextChanged(object sender, EventArgs e) => checkFieldsForBuild();

  private void frmERFManager_Load(object sender, EventArgs e) => PositionWindow(GetType().Name);

  private void frmERFManager_Closing(object sender, CancelEventArgs e) => SaveSettings(GetType().Name);

  public void checkFieldsForBuild()
  {
      if (ERFContentFiles.Items.Count > 0 && StringType.StrCmp(tbErfName.Text, "", false) != 0 && cmbxErfType.SelectedIndex != -1)
        btnBuild.Enabled = true;
      else
        btnBuild.Enabled = false;
    }

  private void RemoveItem() => ERFContentFiles.Items.RemoveAt(ERFContentFiles.SelectedIndex);

  private string BrowseForFolder()
  {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.Description = "Locate folder";
      folderBrowserDialog.SelectedPath = CurrentSettings.defaultImportLocation;
      folderBrowserDialog.ShowNewFolderButton = false;
      string str = null;
      return folderBrowserDialog.ShowDialog() == DialogResult.OK ? folderBrowserDialog.SelectedPath : str;
    }

  private void AddFileNamesToList(string path, ref ArrayList list, string wildcard)
  {
      string[] files = Directory.GetFiles(path, wildcard);
      if (files.Length <= 0)
        return;
      string[] strArray = files;
      int index = 0;
      while (index < strArray.Length)
      {
        string str = strArray[index];
        list.Add(str);
        checked { ++index; }
      }
    }
}