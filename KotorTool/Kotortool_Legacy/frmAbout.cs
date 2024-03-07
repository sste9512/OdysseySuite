// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmAbout
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmAbout : Form
{
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("PictureBox1")]
  private PictureBox _PictureBox1;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("lblVersion")]
  private Label _lblVersion;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  private IContainer components;

  public frmAbout() => InitializeComponent();

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

  internal virtual PictureBox PictureBox1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_PictureBox1 == null)
          ;
        _PictureBox1 = value;
        if (_PictureBox1 == null)
          ;
      }
    get => _PictureBox1;
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

  internal virtual Label Label5
  {
    get => _Label5;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label5 == null)
          ;
        _Label5 = value;
        if (_Label5 == null)
          ;
      }
  }

  internal virtual Label lblVersion
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblVersion == null)
          ;
        _lblVersion = value;
        if (_lblVersion == null)
          ;
      }
    get => _lblVersion;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmAbout));
      Label1 = new Label();
      Button1 = new Button();
      Label3 = new Label();
      PictureBox1 = new PictureBox();
      Label4 = new Label();
      Label5 = new Label();
      lblVersion = new Label();
      SuspendLayout();
      Label1.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      Label label1_1 = Label1;
      Point point1 = new Point(138, 24);
      Point point2 = point1;
      label1_1.Location = point2;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      Size size1 = new Size(124, 32);
      Size size2 = size1;
      label1_2.Size = size2;
      Label1.TabIndex = 0;
      Label1.Text = "KotOR Tool";
      Label1.TextAlign = ContentAlignment.MiddleCenter;
      Button1.Anchor = AnchorStyles.Bottom;
      Button1.BackColor = SystemColors.Control;
      Button1.DialogResult = DialogResult.OK;
      Button button1 = Button1;
      point1 = new Point(304, 224);
      Point point3 = point1;
      button1.Location = point3;
      Button1.Name = "Button1";
      Button1.TabIndex = 1;
      Button1.Text = "OK";
      Label3.Anchor = AnchorStyles.Bottom;
      Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
      Label label3_1 = Label3;
      point1 = new Point(72, 112);
      Point point4 = point1;
      label3_1.Location = point4;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(256, 23);
      Size size3 = size1;
      label3_2.Size = size3;
      Label3.TabIndex = 3;
      Label3.Text = "Email: FredTetra@hotmail.com";
      Label3.TextAlign = ContentAlignment.MiddleCenter;
      PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
      PictureBox pictureBox1_1 = PictureBox1;
      point1 = new Point(72, 16);
      Point point5 = point1;
      pictureBox1_1.Location = point5;
      PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = PictureBox1;
      size1 = new Size(48, 48);
      Size size4 = size1;
      pictureBox1_2.Size = size4;
      PictureBox1.TabIndex = 4;
      PictureBox1.TabStop = false;
      Label4.Anchor = AnchorStyles.Bottom;
      Label label4_1 = Label4;
      point1 = new Point(48, 192);
      Point point6 = point1;
      label4_1.Location = point6;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(307, 23);
      Size size5 = size1;
      label4_2.Size = size5;
      Label4.TabIndex = 3;
      Label4.Text = "Thanks to Eiz for his dxt1/5 converter code!";
      Label4.TextAlign = ContentAlignment.MiddleCenter;
      Label5.Anchor = AnchorStyles.Bottom;
      Label label5_1 = Label5;
      point1 = new Point(38, 144);
      Point point7 = point1;
      label5_1.Location = point7;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(325, 40);
      Size size6 = size1;
      label5_2.Size = size6;
      Label5.TabIndex = 3;
      Label5.Text = "Thanks to Achilles, illuzion69, CDRSeadog, Darth333, death_disco, ChAiNz.2da, Guardian Archon, Gsccc, Uchiha Itachi, and everyone else for their support!";
      Label5.TextAlign = ContentAlignment.MiddleCenter;
      lblVersion.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      Label lblVersion1 = lblVersion;
      point1 = new Point(92, 72);
      Point point8 = point1;
      lblVersion1.Location = point8;
      lblVersion.Name = "lblVersion";
      Label lblVersion2 = lblVersion;
      size1 = new Size(216, 16);
      Size size7 = size1;
      lblVersion2.Size = size7;
      lblVersion.TabIndex = 5;
      lblVersion.TextAlign = ContentAlignment.MiddleCenter;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      BackColor = SystemColors.ActiveCaptionText;
      size1 = new Size(400, 261);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(lblVersion);
      Controls.Add(PictureBox1);
      Controls.Add(Button1);
      Controls.Add(Label1);
      Controls.Add(Label3);
      Controls.Add(Label4);
      Controls.Add(Label5);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Name = nameof (frmAbout);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "About Kotor Tool";
      ResumeLayout(false);
    }

  private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(((LinkLabel) sender).Text);
}