// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmUserRegistration
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using Kotortool_Legacy.Infrastructure;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmUserRegistration : Form
{
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  private IContainer components;

  public frmUserRegistration() => InitializeComponent();

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
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label2 == null)
          ;
        _Label2 = value;
        if (_Label2 == null)
          ;
      }
    get => _Label2;
  }

  internal virtual Label Label3
  {
    get => _Label3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label3 == null)
          ;
        _Label3 = value;
        if (_Label3 == null)
          ;
      }
  }

  internal virtual Label Label4
  {
    get => _Label4;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label4 == null)
          ;
        _Label4 = value;
        if (_Label4 == null)
          ;
      }
  }

  internal virtual Button Button1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Button1 != null)
          _Button1.Click -= new EventHandler(Button1_Click);
        _Button1 = value;
        if (_Button1 == null)
          return;
        _Button1.Click += new EventHandler(Button1_Click);
      }
    get => _Button1;
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

  internal virtual Label Label6
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label6 == null)
          ;
        _Label6 = value;
        if (_Label6 == null)
          ;
      }
    get => _Label6;
  }

  internal virtual Label Label7
  {
    get => _Label7;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label7 == null)
          ;
        _Label7 = value;
        if (_Label7 == null)
          ;
      }
  }

  internal virtual Label Label8
  {
    get => _Label8;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label8 == null)
          ;
        _Label8 = value;
        if (_Label8 == null)
          ;
      }
  }

  internal virtual Button Button2
  {
    get => _Button2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Button2 != null)
          _Button2.Click -= new EventHandler(Button2_Click);
        _Button2 = value;
        if (_Button2 == null)
          return;
        _Button2.Click += new EventHandler(Button2_Click);
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmUserRegistration));
      Label1 = new Label();
      Label2 = new Label();
      Label3 = new Label();
      Label4 = new Label();
      Button1 = new Button();
      Label5 = new Label();
      Label6 = new Label();
      Label7 = new Label();
      Label8 = new Label();
      Button2 = new Button();
      btnOK = new Button();
      SuspendLayout();
      Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      Label label1_1 = Label1;
      Point point1 = new Point(32, 24);
      Point point2 = point1;
      label1_1.Location = point2;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      Size size1 = new Size(368, 23);
      Size size2 = size1;
      label1_2.Size = size2;
      Label1.TabIndex = 0;
      Label1.Text = "Complete the steps below to register your copy of Kotor Tool";
      Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
      Label label2_1 = Label2;
      point1 = new Point(40, 72);
      Point point3 = point1;
      label2_1.Location = point3;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(24, 16);
      Size size3 = size1;
      label2_2.Size = size3;
      Label2.TabIndex = 1;
      Label2.Text = "1.";
      Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
      Label label3_1 = Label3;
      point1 = new Point(40, 120);
      Point point4 = point1;
      label3_1.Location = point4;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(24, 16);
      Size size4 = size1;
      label3_2.Size = size4;
      Label3.TabIndex = 1;
      Label3.Text = "2.";
      Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
      Label label4_1 = Label4;
      point1 = new Point(40, 168);
      Point point5 = point1;
      label4_1.Location = point5;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(24, 16);
      Size size5 = size1;
      label4_2.Size = size5;
      Label4.TabIndex = 1;
      Label4.Text = "3.";
      Button button1_1 = Button1;
      point1 = new Point(80, 72);
      Point point6 = point1;
      button1_1.Location = point6;
      Button1.Name = "Button1";
      Button button1_2 = Button1;
      size1 = new Size(264, 23);
      Size size6 = size1;
      button1_2.Size = size6;
      Button1.TabIndex = 2;
      Button1.Text = "Enter User Registration Info";
      Label label5_1 = Label5;
      point1 = new Point(72, 112);
      Point point7 = point1;
      label5_1.Location = point7;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(48, 16);
      Size size7 = size1;
      label5_2.Size = size7;
      Label5.TabIndex = 3;
      Label5.Text = "Mail the";
      Label5.TextAlign = ContentAlignment.TopRight;
      Label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
      Label label6_1 = Label6;
      point1 = new Point(120, 112);
      Point point8 = point1;
      label6_1.Location = point8;
      Label6.Name = "Label6";
      Label label6_2 = Label6;
      size1 = new Size(72, 16);
      Size size8 = size1;
      label6_2.Size = size8;
      Label6.TabIndex = 3;
      Label6.Text = "user reg.info";
      Label label7_1 = Label7;
      point1 = new Point(192, 112);
      Point point9 = point1;
      label7_1.Location = point9;
      Label7.Name = "Label7";
      Label label7_2 = Label7;
      size1 = new Size(168, 16);
      Size size9 = size1;
      label7_2.Size = size9;
      Label7.TabIndex = 3;
      Label7.Text = "file (in your Kotor Tool directory)";
      Label label8_1 = Label8;
      point1 = new Point(80, 126);
      Point point10 = point1;
      label8_1.Location = point10;
      Label8.Name = "Label8";
      Label label8_2 = Label8;
      size1 = new Size(272, 34);
      Size size10 = size1;
      label8_2.Size = size10;
      Label8.TabIndex = 3;
      Label8.Text = "to fredtetra@hotmail.com for further details on the registration process.";
      Button button2_1 = Button2;
      point1 = new Point(80, 168);
      Point point11 = point1;
      button2_1.Location = point11;
      Button2.Name = "Button2";
      Button button2_2 = Button2;
      size1 = new Size(264, 23);
      Size size11 = size1;
      button2_2.Size = size11;
      Button2.TabIndex = 2;
      Button2.Text = "Import User Registration Key";
      btnOK.DialogResult = DialogResult.OK;
      Button btnOk = btnOK;
      point1 = new Point(176, 224);
      Point point12 = point1;
      btnOk.Location = point12;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 8;
      btnOK.Text = "OK";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(424, 269);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(btnOK);
      Controls.Add(Label5);
      Controls.Add(Button1);
      Controls.Add(Label2);
      Controls.Add(Label1);
      Controls.Add(Label3);
      Controls.Add(Label4);
      Controls.Add(Label6);
      Controls.Add(Label7);
      Controls.Add(Label8);
      Controls.Add(Button2);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Name = nameof (frmUserRegistration);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "User Registration";
      ResumeLayout(false);
    }

  private void Button1_Click(object sender, EventArgs e)
  {
      frmQueryUserInfo frmQueryUserInfo = new frmQueryUserInfo();
      if (frmQueryUserInfo.ShowDialog(this) != DialogResult.OK)
        return;
      string str1 = "paddingpaddingpaddingpaddingpaddingpadding|1|paddingpadding|" + frmQueryUserInfo.tbUserName.Text.Trim() + "|paddingpaddingpaddingpaddingpaddingpadding|paddingpaddingpaddingpaddingpaddingpadding|" + frmQueryUserInfo.tbUserEmail.Text.Trim() + "|paddingpaddingpaddingpaddingpaddingpadding|" + StringType.FromDate(DateTime.Now);
      try
      {
        ManagementObjectCollection instances = new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
        try
        {
          foreach (ManagementObject managementObject in instances)
          {
            if (ObjectType.ObjTst(managementObject["IPEnabled"], true, false) == 0)
            {
              Console.WriteLine(managementObject["MacAddress"].ToString());
              str1 = str1 + "|paddingpaddingpaddingpaddingpaddingpadding|" + managementObject["MacAddress"].ToString();
              Console.WriteLine(managementObject["Description"].ToString());
              Console.WriteLine(managementObject["ServiceName"].ToString());
            }
          }
        }
        finally
        {
         /*ManagementObjectCollection.ManagementObjectEnumerator objectEnumerator;

          bjectEnumerator?.Dispose();*/
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) Interaction.MsgBox(exception.Message + exception.StackTrace);
        ProjectData.ClearProjectError();
      }
      string inName = str1 + "|paddingpaddingpaddingpaddingpaddingpadding";
      EncryptionService encryptionService = new EncryptionService();
      encryptionService.TheKey[0] = 11;
      encryptionService.TheKey[1] = 19;
      encryptionService.TheKey[2] = 19;
      encryptionService.TheKey[3] = 63;
      encryptionService.TheKey[4] = 9;
      encryptionService.TheKey[5] = 19;
      encryptionService.TheKey[6] = 19;
      encryptionService.TheKey[7] = 65;
      //string str2 = encryptionService.Encrypt(inName);
      //BinaryWriter binaryWriter = new BinaryWriter(new FileStream("user reg.info", FileMode.Create), Encoding.ASCII);
      //binaryWriter.Write(str2);
      //binaryWriter.Close();
      int num1 = (int) Interaction.MsgBox("Your User Registration info file has been generated and placed in the same folder as Kotor Tool.\nEmail this file to author to continue the registration process.", MsgBoxStyle.Information);
    }

  private void Button2_Click(object sender, EventArgs e)
  {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      FrmMain frmMain = new FrmMain();
      openFileDialog.Title = "Select key file...";
      openFileDialog.Filter = "User key files (*.key)|*.key";
      openFileDialog.FilterIndex = 1;
      openFileDialog.Multiselect = false;
      openFileDialog.RestoreDirectory = true;
      openFileDialog.FileName = "*.key";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      BinaryReader binaryReader = new BinaryReader(new FileStream(openFileDialog.FileName, FileMode.Open), Encoding.ASCII);
      string str = binaryReader.ReadString();
      binaryReader.Close();
      FrmMain.CurrentSettings.Key = str;
      FrmMain.SaveSettings();
      int num = (int) Interaction.MsgBox("The key file has been imported into your settings.xml file.\n\nThank you for registering your copy of Kotor Tool.");
      Close();
    }
}