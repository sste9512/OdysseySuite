// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmBasicHelp
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmBasicHelp : Form
{
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("TextBox1")]
  private TextBox _TextBox1;
  private IContainer components;

  public frmBasicHelp() => InitializeComponent();

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

  internal virtual TextBox TextBox1
  {
    get => _TextBox1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TextBox1 == null)
          ;
        _TextBox1 = value;
        if (_TextBox1 == null)
          ;
      }
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmBasicHelp));
      Button1 = new Button();
      TextBox1 = new TextBox();
      Label1 = new Label();
      SuspendLayout();
      Button1.DialogResult = DialogResult.OK;
      Button button1 = Button1;
      Point point1 = new Point(171, 344);
      Point point2 = point1;
      button1.Location = point2;
      Button1.Name = "Button1";
      Button1.TabIndex = 2;
      Button1.Text = "OK";
      TextBox textBox1_1 = TextBox1;
      point1 = new Point(8, 40);
      Point point3 = point1;
      textBox1_1.Location = point3;
      TextBox1.Multiline = true;
      TextBox1.Name = "TextBox1";
      TextBox1.ScrollBars = ScrollBars.Vertical;
      TextBox textBox1_2 = TextBox1;
      Size size1 = new Size(400, 296);
      Size size2 = size1;
      textBox1_2.Size = size2;
      TextBox1.TabIndex = 3;
      TextBox1.Text = "The first time you run the program, it will attempt to detect where you have installed KotOR and configure some of the directory paths it needs to work. It will then bring up the path management screen so you can verify them.\r\n\r\nYou can specify whether or not you want the BIF tree built at program startup or not from the Tools | Options... menu. If you leave the checkbox unchecked, the BIF portion of the tree view will only be built when you attempt to expand it.\r\n\r\nOnce the program is running, you can:\r\n\r\n- Select any *.bif or *.rim  file from the tree view, then click Extact to extract every file in it to a directory\r\n\r\n- Select any file in a bif, rim, or erf, then click Extact to extract it to a directory\r\n\r\n- Double-click on any 2da file to bring up the editor for it.  You can then edit the values and write the file to a directory. (Most likely the override folder in yout KotOR folder)  Clicking on the column header in the editor grid will sort it based on the values in that column.  Repeated clicking will change the sort direction.\r\n\r\n- Double-clicking on most other file types will bring up and editor/viewer for them, if one it available\r\n\r\n- You can also directly open a 2da v2.b file from the File menu for editing. NOTE: You do not have to open the chitin.key file first.\r\n\r\nNotes:\r\n* If you want to edit files contained in RIM files, install Bioware's Gff Editor in the same directory as kotor_tool.\r\n\r\n* If you want to extract texture pack .tpc files, you will need the tpc2tga program installed in the same directory at kotor tool.\r\n\r\n* You can specify whether or not you want to automatically convert extracted .tpc files to TGA format from the Tools | Options... menu\r\n\r\n* If you also want to be able to view the .tpc files, you must install a TGA file viewer and specify the path to it in the Path Manager.\r\nYou can download a free TGA viewer at http://www.creabit.com/viewer/";
      Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
      Label label1 = Label1;
      point1 = new Point(158, 8);
      Point point4 = point1;
      label1.Location = point4;
      Label1.Name = "Label1";
      Label1.TabIndex = 4;
      Label1.Text = "Basic Help";
      Label1.TextAlign = ContentAlignment.MiddleCenter;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(416, 381);
      ClientSize = size1;
      Controls.Add(Label1);
      Controls.Add(TextBox1);
      Controls.Add(Button1);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Name = nameof (frmBasicHelp);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Basic Help";
      ResumeLayout(false);
    }
}