// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmCExoLocStringLanguagePicker
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmCExoLocStringLanguagePicker : Form
{
  [AccessedThroughProperty("cmbxGender")]
  private ComboBox _cmbxGender;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbxLanguage")]
  private ComboBox _cmbxLanguage;
  private IContainer components;
  private int m_LanguageID;

  public frmCExoLocStringLanguagePicker()
  {
      Load += new EventHandler(frmCExoLocStringLanguagePicker_Load);
      InitializeComponent();
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

  internal virtual ComboBox cmbxLanguage
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxLanguage == null)
          ;
        _cmbxLanguage = value;
        if (_cmbxLanguage == null)
          ;
      }
    get => _cmbxLanguage;
  }

  internal virtual ComboBox cmbxGender
  {
    get => _cmbxGender;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxGender == null)
          ;
        _cmbxGender = value;
        if (_cmbxGender == null)
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmCExoLocStringLanguagePicker));
      cmbxLanguage = new ComboBox();
      cmbxGender = new ComboBox();
      btnOK = new Button();
      this.btnCancel = new Button();
      Label1 = new Label();
      Label2 = new Label();
      SuspendLayout();
      cmbxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxLanguage.Items.AddRange(new object[6]
      {
        "English",
        "French",
        "German",
        "Italian",
        "Spanish",
        "Polish"
      });
      ComboBox cmbxLanguage1 = cmbxLanguage;
      Point point1 = new Point(64, 40);
      Point point2 = point1;
      cmbxLanguage1.Location = point2;
      cmbxLanguage.Name = "cmbxLanguage";
      ComboBox cmbxLanguage2 = cmbxLanguage;
      Size size1 = new Size(160, 21);
      Size size2 = size1;
      cmbxLanguage2.Size = size2;
      cmbxLanguage.TabIndex = 0;
      cmbxGender.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxGender.Items.AddRange(new object[2]
      {
        "Neuter/Masculine",
        "Feminine"
      });
      ComboBox cmbxGender1 = cmbxGender;
      point1 = new Point(64, 96);
      Point point3 = point1;
      cmbxGender1.Location = point3;
      cmbxGender.Name = "cmbxGender";
      ComboBox cmbxGender2 = cmbxGender;
      size1 = new Size(136, 21);
      Size size3 = size1;
      cmbxGender2.Size = size3;
      cmbxGender.TabIndex = 0;
      Button btnOk = btnOK;
      point1 = new Point(57, 144);
      Point point4 = point1;
      btnOk.Location = point4;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 1;
      btnOK.Text = "OK";
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(161, 144);
      Point point5 = point1;
      btnCancel.Location = point5;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      Label label1_1 = Label1;
      point1 = new Point(64, 24);
      Point point6 = point1;
      label1_1.Location = point6;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(100, 16);
      Size size4 = size1;
      label1_2.Size = size4;
      Label1.TabIndex = 2;
      Label1.Text = "Language";
      Label label2_1 = Label2;
      point1 = new Point(64, 80);
      Point point7 = point1;
      label2_1.Location = point7;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(100, 16);
      Size size5 = size1;
      label2_2.Size = size5;
      Label2.TabIndex = 2;
      Label2.Text = "Gender";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(292, 197);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(Label1);
      Controls.Add(btnOK);
      Controls.Add(cmbxLanguage);
      Controls.Add(cmbxGender);
      Controls.Add(this.btnCancel);
      Controls.Add(Label2);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      size1 = new Size(300, 224);
      MaximumSize = size1;
      size1 = new Size(300, 224);
      MinimumSize = size1;
      Name = nameof (frmCExoLocStringLanguagePicker);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Language Selector";
      ResumeLayout(false);
    }

  public int LanguageID
  {
    get => m_LanguageID;
    set => m_LanguageID = value;
  }

  public frmCExoLocStringLanguagePicker(int LanguageID)
    : this()
  {
      m_LanguageID = LanguageID;
    }

  private void frmCExoLocStringLanguagePicker_Load(object sender, EventArgs e)
  {
      cmbxLanguage.SelectedIndex = m_LanguageID / 2;
      cmbxGender.SelectedIndex = m_LanguageID % 2;
    }

  private void btnOK_Click(object sender, EventArgs e)
  {
      m_LanguageID = checked (cmbxLanguage.SelectedIndex * 2 + cmbxGender.SelectedIndex);
      DialogResult = DialogResult.OK;
    }
}