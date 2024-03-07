// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmCreateAnimListEntry
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmCreateAnimListEntry : Form
{
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("cmbxAnimation")]
  private ComboBox _cmbxAnimation;
  [AccessedThroughProperty("ToolTip1")]
  private ToolTip _ToolTip1;
  [AccessedThroughProperty("tbParticipant")]
  private TextBox _tbParticipant;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  private IContainer components;
  private ArrayList al;
  public int AnimationNumber;
  public string Participant;

  public frmCreateAnimListEntry()
  {
      Load += new EventHandler(frmCreateAnimListEntry_Load);
      al = new ArrayList();
      InitializeComponent();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual Button btnOK
  {
    get => _btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnOK != null)
          _btnOK.Click -= new EventHandler(btnOK_Click);
        _btnOK = value;
        if (_btnOK == null)
          return;
        _btnOK.Click += new EventHandler(btnOK_Click);
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

  internal virtual TextBox tbParticipant
  {
    get => _tbParticipant;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbParticipant == null)
          ;
        _tbParticipant = value;
        if (_tbParticipant == null)
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

  internal virtual ComboBox cmbxAnimation
  {
    get => _cmbxAnimation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxAnimation == null)
          ;
        _cmbxAnimation = value;
        if (_cmbxAnimation == null)
          ;
      }
  }

  internal virtual ToolTip ToolTip1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolTip1 == null)
          ;
        _ToolTip1 = value;
        if (_ToolTip1 == null)
          ;
      }
    get => _ToolTip1;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      components = new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (frmCreateAnimListEntry));
      btnOK = new Button();
      this.btnCancel = new Button();
      tbParticipant = new TextBox();
      Label1 = new Label();
      cmbxAnimation = new ComboBox();
      Label3 = new Label();
      ToolTip1 = new ToolTip(components);
      SuspendLayout();
      Button btnOk = btnOK;
      Point point1 = new Point(64, 160);
      Point point2 = point1;
      btnOk.Location = point2;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 2;
      btnOK.Text = "OK";
      ToolTip1.SetToolTip(btnOK, "Click when you have selected a Participant and an Animation.");
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(168, 160);
      Point point3 = point1;
      btnCancel.Location = point3;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Cancel";
      TextBox tbParticipant1 = tbParticipant;
      point1 = new Point(96, 48);
      Point point4 = point1;
      tbParticipant1.Location = point4;
      tbParticipant.Name = "tbParticipant";
      TextBox tbParticipant2 = tbParticipant;
      Size size1 = new Size(128, 20);
      Size size2 = size1;
      tbParticipant2.Size = size2;
      tbParticipant.TabIndex = 0;
      tbParticipant.Text = "";
      ToolTip1.SetToolTip(tbParticipant, "Enter the Participant name for the Animation");
      Label label1_1 = Label1;
      point1 = new Point(104, 32);
      Point point5 = point1;
      label1_1.Location = point5;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(88, 16);
      Size size3 = size1;
      label1_2.Size = size3;
      Label1.TabIndex = 3;
      Label1.Text = "Participant";
      cmbxAnimation.Items.AddRange(new object[3]
      {
        "A",
        "B",
        "C"
      });
      ComboBox cmbxAnimation1 = cmbxAnimation;
      point1 = new Point(96, 96);
      Point point6 = point1;
      cmbxAnimation1.Location = point6;
      cmbxAnimation.Name = "cmbxAnimation";
      ComboBox cmbxAnimation2 = cmbxAnimation;
      size1 = new Size(121, 21);
      Size size4 = size1;
      cmbxAnimation2.Size = size4;
      cmbxAnimation.TabIndex = 4;
      ToolTip1.SetToolTip(cmbxAnimation, "Select an Animation from the list or enter a number.");
      Label label3_1 = Label3;
      point1 = new Point(96, 80);
      Point point7 = point1;
      label3_1.Location = point7;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(120, 16);
      Size size5 = size1;
      label3_2.Size = size5;
      Label3.TabIndex = 3;
      Label3.Text = "Common Animations";
      AcceptButton = btnOK;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = this.btnCancel;
      size1 = new Size(328, 213);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(cmbxAnimation);
      Controls.Add(Label1);
      Controls.Add(tbParticipant);
      Controls.Add(btnOK);
      Controls.Add(this.btnCancel);
      Controls.Add(Label3);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Name = nameof (frmCreateAnimListEntry);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Create Animation List Entry";
      ResumeLayout(false);
    }

  private void btnOK_Click(object sender, EventArgs e)
  {
      string str = null;
      if (cmbxAnimation.SelectedIndex == -1 && StringType.StrCmp(cmbxAnimation.Text, "", false) != 0)
        str = cmbxAnimation.Text;
      else if (cmbxAnimation.SelectedItem != null)
        str = StringType.FromInteger(((Anim) cmbxAnimation.SelectedItem).Number);
      if (StringType.StrCmp(str, "", false) == 0 | !Information.IsNumeric(str))
      {
        int num1 = (int) Interaction.MsgBox("You must either enter an animation number or select an animation from the list.", MsgBoxStyle.Critical, "Error");
      }
      else if (StringType.StrCmp(tbParticipant.Text.Trim(), "", false) == 0)
      {
        int num2 = (int) Interaction.MsgBox("You must enter a Participant name.", MsgBoxStyle.Critical, "Error");
      }
      else
      {
        AnimationNumber = IntegerType.FromString(str);
        Participant = tbParticipant.Text.Trim();
        DialogResult = DialogResult.OK;
      }
    }

  private void frmCreateAnimListEntry_Load(object sender, EventArgs e)
  {
      al.Add(new Anim("ACTIVATE", 10127));
      al.Add(new Anim("BOW", 10035));
      al.Add(new Anim("CHOKE", 10150));
      al.Add(new Anim("COLLAPSE CHOKING", 10221));
      al.Add(new Anim("COLLAPSE KNOCKOUT", 10222));
      al.Add(new Anim("DEAD", 10006));
      al.Add(new Anim("DRUNK", 10058));
      al.Add(new Anim("FALL SLOWLY (CENTER)", 10224));
      al.Add(new Anim("FALL SLOWLY (RIGHT)", 10223));
      al.Add(new Anim("FLIRT", 10120));
      al.Add(new Anim("FORCE JUMP", 10220));
      al.Add(new Anim("GREETING", 10029));
      al.Add(new Anim("HORROR", 10124));
      al.Add(new Anim("INJECT", 10070));
      al.Add(new Anim("KNEEL TALK ANGRY", 10163));
      al.Add(new Anim("KNEEL TALK SAD", 10164));
      al.Add(new Anim("LISTEN", 10030));
      al.Add(new Anim("LISTEN INJURED", 10155));
      al.Add(new Anim("PAUSE", 10149));
      al.Add(new Anim("PERSUADE", 10126));
      al.Add(new Anim("PRONE", 10139));
      al.Add(new Anim("PUSHED BACK", 10219));
      al.Add(new Anim("READY", 10148));
      al.Add(new Anim("SALUTE", 10034));
      al.Add(new Anim("SCRATCH HEAD", 10055));
      al.Add(new Anim("SLEEP", 10137));
      al.Add(new Anim("TALK FORCEFUL", 10040));
      al.Add(new Anim("TALK INJURED", 10154));
      al.Add(new Anim("TALK LAUGHING", 10041));
      al.Add(new Anim("TALK NORMAL", 10038));
      al.Add(new Anim("TALK PLEADING", 10039));
      al.Add(new Anim("TALK SAD", 10042));
      al.Add(new Anim("TAUNT", 10028));
      al.Add(new Anim("USE COMPUTER", 10125));
      al.Add(new Anim("USE COMPUTER (loop)", 10121));
      al.Add(new Anim("VICTORY", 10044));
      al.Add(new Anim("WORSHIP", 10033));
      ((ListControl) cmbxAnimation).DataSource = al;
      cmbxAnimation.DisplayMember = "Name";
      cmbxAnimation.ValueMember = "Number";
    }

  private class Anim
  {
    private string m_Name;
    private int m_number;

    public Anim(string Name, int Number)
    {
        m_Name = Name.Substring(0, 1) + Name.Substring(1, checked (Name.Length - 1)).ToLower();
        m_number = Number;
      }

    public string Name
    {
      get => m_Name;
      set => m_Name = value;
    }

    public int Number
    {
      get => m_number;
      set => m_number = value;
    }
  }
}