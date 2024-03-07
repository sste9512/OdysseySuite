// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmRefSearchCriteria
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmRefSearchCriteria : frmParent
{
  [AccessedThroughProperty("gboxCaseSens")]
  private GroupBox _gboxCaseSens;
  [AccessedThroughProperty("rbSearchKotor2")]
  private RadioButton _rbSearchKotor2;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("rbSearchKotor1")]
  private RadioButton _rbSearchKotor1;
  [AccessedThroughProperty("tbSearchString")]
  private TextBox _tbSearchString;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("chkbAllBifs")]
  private CheckBox _chkbAllBifs;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("CheckBox1")]
  private CheckBox _CheckBox1;
  [AccessedThroughProperty("gboxScript")]
  private GroupBox _gboxScript;
  [AccessedThroughProperty("CheckBox23")]
  private CheckBox _CheckBox23;
  [AccessedThroughProperty("CheckBox22")]
  private CheckBox _CheckBox22;
  [AccessedThroughProperty("gboxGFF")]
  private GroupBox _gboxGFF;
  [AccessedThroughProperty("chkbRIMs")]
  private CheckBox _chkbRIMs;
  [AccessedThroughProperty("chkbTemplates")]
  private CheckBox _chkbTemplates;
  [AccessedThroughProperty("gboxSearchString")]
  private GroupBox _gboxSearchString;
  [AccessedThroughProperty("chkbScripts")]
  private CheckBox _chkbScripts;
  [AccessedThroughProperty("gboxArchiveTypes")]
  private GroupBox _gboxArchiveTypes;
  [AccessedThroughProperty("gboxFileTypes")]
  private GroupBox _gboxFileTypes;
  [AccessedThroughProperty("rbtnInsensitive")]
  private RadioButton _rbtnInsensitive;
  [AccessedThroughProperty("rbtnSensitive")]
  private RadioButton _rbtnSensitive;
  [AccessedThroughProperty("btnClearAll")]
  private Button _btnClearAll;
  [AccessedThroughProperty("btnSetAll")]
  private Button _btnSetAll;
  [AccessedThroughProperty("CheckBox2")]
  private CheckBox _CheckBox2;
  [AccessedThroughProperty("CheckBox3")]
  private CheckBox _CheckBox3;
  [AccessedThroughProperty("CheckBox4")]
  private CheckBox _CheckBox4;
  [AccessedThroughProperty("CheckBox5")]
  private CheckBox _CheckBox5;
  [AccessedThroughProperty("CheckBox18")]
  private CheckBox _CheckBox18;
  [AccessedThroughProperty("CheckBox6")]
  private CheckBox _CheckBox6;
  [AccessedThroughProperty("CheckBox7")]
  private CheckBox _CheckBox7;
  [AccessedThroughProperty("CheckBox8")]
  private CheckBox _CheckBox8;
  [AccessedThroughProperty("CheckBox11")]
  private CheckBox _CheckBox11;
  [AccessedThroughProperty("CheckBox12")]
  private CheckBox _CheckBox12;
  [AccessedThroughProperty("CheckBox13")]
  private CheckBox _CheckBox13;
  [AccessedThroughProperty("CheckBox16")]
  private CheckBox _CheckBox16;
  public Hashtable htFileTypes;
  private IContainer components;

  public frmRefSearchCriteria() => InitializeComponent();

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

  internal virtual TextBox tbSearchString
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbSearchString != null)
          _tbSearchString.TextChanged -= new EventHandler(tbSearchString_TextChanged);
        _tbSearchString = value;
        if (_tbSearchString == null)
          return;
        _tbSearchString.TextChanged += new EventHandler(tbSearchString_TextChanged);
      }
    get => _tbSearchString;
  }

  internal virtual CheckBox CheckBox1
  {
    get => _CheckBox1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox1 == null)
          ;
        _CheckBox1 = value;
        if (_CheckBox1 == null)
          ;
      }
  }

  internal virtual CheckBox CheckBox2
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox2 == null)
          ;
        _CheckBox2 = value;
        if (_CheckBox2 == null)
          ;
      }
    get => _CheckBox2;
  }

  internal virtual CheckBox CheckBox3
  {
    get => _CheckBox3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox3 == null)
          ;
        _CheckBox3 = value;
        if (_CheckBox3 == null)
          ;
      }
  }

  internal virtual CheckBox CheckBox4
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox4 == null)
          ;
        _CheckBox4 = value;
        if (_CheckBox4 == null)
          ;
      }
    get => _CheckBox4;
  }

  internal virtual CheckBox CheckBox5
  {
    get => _CheckBox5;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox5 == null)
          ;
        _CheckBox5 = value;
        if (_CheckBox5 == null)
          ;
      }
  }

  internal virtual CheckBox CheckBox6
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox6 == null)
          ;
        _CheckBox6 = value;
        if (_CheckBox6 == null)
          ;
      }
    get => _CheckBox6;
  }

  internal virtual CheckBox CheckBox7
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox7 == null)
          ;
        _CheckBox7 = value;
        if (_CheckBox7 == null)
          ;
      }
    get => _CheckBox7;
  }

  internal virtual CheckBox CheckBox8
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox8 == null)
          ;
        _CheckBox8 = value;
        if (_CheckBox8 == null)
          ;
      }
    get => _CheckBox8;
  }

  internal virtual CheckBox CheckBox11
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox11 == null)
          ;
        _CheckBox11 = value;
        if (_CheckBox11 == null)
          ;
      }
    get => _CheckBox11;
  }

  internal virtual CheckBox CheckBox12
  {
    get => _CheckBox12;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox12 == null)
          ;
        _CheckBox12 = value;
        if (_CheckBox12 == null)
          ;
      }
  }

  internal virtual CheckBox CheckBox13
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox13 == null)
          ;
        _CheckBox13 = value;
        if (_CheckBox13 == null)
          ;
      }
    get => _CheckBox13;
  }

  internal virtual CheckBox CheckBox16
  {
    get => _CheckBox16;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox16 == null)
          ;
        _CheckBox16 = value;
        if (_CheckBox16 == null)
          ;
      }
  }

  internal virtual CheckBox CheckBox18
  {
    get => _CheckBox18;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox18 == null)
          ;
        _CheckBox18 = value;
        if (_CheckBox18 == null)
          ;
      }
  }

  internal virtual Button btnSetAll
  {
    get => _btnSetAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSetAll != null)
          _btnSetAll.Click -= new EventHandler(btnSetAll_Click);
        _btnSetAll = value;
        if (_btnSetAll == null)
          return;
        _btnSetAll.Click += new EventHandler(btnSetAll_Click);
      }
  }

  internal virtual Button btnClearAll
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnClearAll != null)
          _btnClearAll.Click -= new EventHandler(btnClearAll_Click);
        _btnClearAll = value;
        if (_btnClearAll == null)
          return;
        _btnClearAll.Click += new EventHandler(btnClearAll_Click);
      }
    get => _btnClearAll;
  }

  internal virtual RadioButton rbtnSensitive
  {
    get => _rbtnSensitive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbtnSensitive == null)
          ;
        _rbtnSensitive = value;
        if (_rbtnSensitive == null)
          ;
      }
  }

  internal virtual RadioButton rbtnInsensitive
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbtnInsensitive == null)
          ;
        _rbtnInsensitive = value;
        if (_rbtnInsensitive == null)
          ;
      }
    get => _rbtnInsensitive;
  }

  internal virtual GroupBox gboxFileTypes
  {
    get => _gboxFileTypes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_gboxFileTypes == null)
          ;
        _gboxFileTypes = value;
        if (_gboxFileTypes == null)
          ;
      }
  }

  internal virtual GroupBox gboxArchiveTypes
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_gboxArchiveTypes == null)
          ;
        _gboxArchiveTypes = value;
        if (_gboxArchiveTypes == null)
          ;
      }
    get => _gboxArchiveTypes;
  }

  internal virtual CheckBox chkbScripts
  {
    get => _chkbScripts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbScripts != null)
          _chkbScripts.CheckedChanged -= new EventHandler(chkbScripts_CheckedChanged);
        _chkbScripts = value;
        if (_chkbScripts == null)
          return;
        _chkbScripts.CheckedChanged += new EventHandler(chkbScripts_CheckedChanged);
      }
  }

  internal virtual CheckBox chkbTemplates
  {
    get => _chkbTemplates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbTemplates != null)
          _chkbTemplates.CheckedChanged -= new EventHandler(chkbTemplates_CheckedChanged);
        _chkbTemplates = value;
        if (_chkbTemplates == null)
          return;
        _chkbTemplates.CheckedChanged += new EventHandler(chkbTemplates_CheckedChanged);
      }
  }

  internal virtual CheckBox chkbRIMs
  {
    get => _chkbRIMs;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbRIMs != null)
          _chkbRIMs.CheckedChanged -= new EventHandler(chkbRIMs_CheckedChanged);
        _chkbRIMs = value;
        if (_chkbRIMs == null)
          return;
        _chkbRIMs.CheckedChanged += new EventHandler(chkbRIMs_CheckedChanged);
      }
  }

  internal virtual GroupBox gboxGFF
  {
    get => _gboxGFF;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_gboxGFF == null)
          ;
        _gboxGFF = value;
        if (_gboxGFF == null)
          ;
      }
  }

  internal virtual CheckBox CheckBox22
  {
    get => _CheckBox22;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox22 == null)
          ;
        _CheckBox22 = value;
        if (_CheckBox22 == null)
          ;
      }
  }

  internal virtual CheckBox CheckBox23
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_CheckBox23 == null)
          ;
        _CheckBox23 = value;
        if (_CheckBox23 == null)
          ;
      }
    get => _CheckBox23;
  }

  internal virtual GroupBox gboxScript
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_gboxScript == null)
          ;
        _gboxScript = value;
        if (_gboxScript == null)
          ;
      }
    get => _gboxScript;
  }

  internal virtual CheckBox chkbAllBifs
  {
    get => _chkbAllBifs;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbAllBifs != null)
          _chkbAllBifs.CheckedChanged -= new EventHandler(chkbAllBifs_CheckedChanged);
        _chkbAllBifs = value;
        if (_chkbAllBifs == null)
          return;
        _chkbAllBifs.CheckedChanged += new EventHandler(chkbAllBifs_CheckedChanged);
      }
  }

  internal virtual GroupBox GroupBox2
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox2 == null)
          ;
        _GroupBox2 = value;
        if (_GroupBox2 == null)
          ;
      }
    get => _GroupBox2;
  }

  internal virtual RadioButton rbSearchKotor1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbSearchKotor1 != null)
          _rbSearchKotor1.CheckedChanged -= new EventHandler(rbSearch_CheckedChanged);
        _rbSearchKotor1 = value;
        if (_rbSearchKotor1 == null)
          return;
        _rbSearchKotor1.CheckedChanged += new EventHandler(rbSearch_CheckedChanged);
      }
    get => _rbSearchKotor1;
  }

  internal virtual RadioButton rbSearchKotor2
  {
    get => _rbSearchKotor2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbSearchKotor2 != null)
          _rbSearchKotor2.CheckedChanged -= new EventHandler(rbSearch_CheckedChanged);
        _rbSearchKotor2 = value;
        if (_rbSearchKotor2 == null)
          return;
        _rbSearchKotor2.CheckedChanged += new EventHandler(rbSearch_CheckedChanged);
      }
  }

  internal virtual GroupBox gboxCaseSens
  {
    get => _gboxCaseSens;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_gboxCaseSens == null)
          ;
        _gboxCaseSens = value;
        if (_gboxCaseSens == null)
          ;
      }
  }

  internal virtual GroupBox gboxSearchString
  {
    get => _gboxSearchString;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_gboxSearchString == null)
          ;
        _gboxSearchString = value;
        if (_gboxSearchString == null)
          ;
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      btnOK = new Button();
      this.btnCancel = new Button();
      tbSearchString = new TextBox();
      CheckBox1 = new CheckBox();
      CheckBox2 = new CheckBox();
      CheckBox3 = new CheckBox();
      CheckBox4 = new CheckBox();
      CheckBox5 = new CheckBox();
      CheckBox6 = new CheckBox();
      CheckBox7 = new CheckBox();
      CheckBox8 = new CheckBox();
      CheckBox11 = new CheckBox();
      CheckBox12 = new CheckBox();
      CheckBox13 = new CheckBox();
      CheckBox16 = new CheckBox();
      CheckBox18 = new CheckBox();
      this.btnSetAll = new Button();
      this.btnClearAll = new Button();
      rbtnSensitive = new RadioButton();
      rbtnInsensitive = new RadioButton();
      gboxFileTypes = new GroupBox();
      gboxGFF = new GroupBox();
      gboxScript = new GroupBox();
      CheckBox22 = new CheckBox();
      CheckBox23 = new CheckBox();
      gboxArchiveTypes = new GroupBox();
      chkbScripts = new CheckBox();
      chkbTemplates = new CheckBox();
      chkbRIMs = new CheckBox();
      chkbAllBifs = new CheckBox();
      gboxCaseSens = new GroupBox();
      GroupBox2 = new GroupBox();
      rbSearchKotor1 = new RadioButton();
      rbSearchKotor2 = new RadioButton();
      gboxSearchString = new GroupBox();
      gboxFileTypes.SuspendLayout();
      gboxGFF.SuspendLayout();
      gboxScript.SuspendLayout();
      gboxArchiveTypes.SuspendLayout();
      gboxCaseSens.SuspendLayout();
      GroupBox2.SuspendLayout();
      gboxSearchString.SuspendLayout();
      SuspendLayout();
      btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnOK.Enabled = false;
      Button btnOk = btnOK;
      Point point1 = new Point(172, 488);
      Point point2 = point1;
      btnOk.Location = point2;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 3;
      btnOK.Text = "OK";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(268, 488);
      Point point3 = point1;
      btnCancel.Location = point3;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 4;
      this.btnCancel.Text = "Cancel";
      TextBox tbSearchString1 = tbSearchString;
      point1 = new Point(16, 24);
      Point point4 = point1;
      tbSearchString1.Location = point4;
      tbSearchString.Name = "tbSearchString";
      TextBox tbSearchString2 = tbSearchString;
      Size size1 = new Size(160, 20);
      Size size2 = size1;
      tbSearchString2.Size = size2;
      tbSearchString.TabIndex = 0;
      tbSearchString.Text = "";
      CheckBox1.Checked = true;
      CheckBox1.CheckState = CheckState.Checked;
      CheckBox checkBox1_1 = CheckBox1;
      point1 = new Point(8, 24);
      Point point5 = point1;
      checkBox1_1.Location = point5;
      CheckBox1.Name = "CheckBox1";
      CheckBox checkBox1_2 = CheckBox1;
      size1 = new Size(48, 16);
      Size size3 = size1;
      checkBox1_2.Size = size3;
      CheckBox1.TabIndex = 0;
      CheckBox1.Text = "are";
      CheckBox2.Checked = true;
      CheckBox2.CheckState = CheckState.Checked;
      CheckBox checkBox2_1 = CheckBox2;
      point1 = new Point(8, 96);
      Point point6 = point1;
      checkBox2_1.Location = point6;
      CheckBox2.Name = "CheckBox2";
      CheckBox checkBox2_2 = CheckBox2;
      size1 = new Size(48, 16);
      Size size4 = size1;
      checkBox2_2.Size = size4;
      CheckBox2.TabIndex = 3;
      CheckBox2.Text = "dlg";
      CheckBox3.Checked = true;
      CheckBox3.CheckState = CheckState.Checked;
      CheckBox checkBox3_1 = CheckBox3;
      point1 = new Point(64, 24);
      Point point7 = point1;
      checkBox3_1.Location = point7;
      CheckBox3.Name = "CheckBox3";
      CheckBox checkBox3_2 = CheckBox3;
      size1 = new Size(48, 16);
      Size size5 = size1;
      checkBox3_2.Size = size5;
      CheckBox3.TabIndex = 4;
      CheckBox3.Text = "utc";
      CheckBox4.Checked = true;
      CheckBox4.CheckState = CheckState.Checked;
      CheckBox checkBox4_1 = CheckBox4;
      point1 = new Point(64, 48);
      Point point8 = point1;
      checkBox4_1.Location = point8;
      CheckBox4.Name = "CheckBox4";
      CheckBox checkBox4_2 = CheckBox4;
      size1 = new Size(48, 16);
      Size size6 = size1;
      checkBox4_2.Size = size6;
      CheckBox4.TabIndex = 5;
      CheckBox4.Text = "utd";
      CheckBox5.Checked = true;
      CheckBox5.CheckState = CheckState.Checked;
      CheckBox checkBox5_1 = CheckBox5;
      point1 = new Point(64, 96);
      Point point9 = point1;
      checkBox5_1.Location = point9;
      CheckBox5.Name = "CheckBox5";
      CheckBox checkBox5_2 = CheckBox5;
      size1 = new Size(48, 16);
      Size size7 = size1;
      checkBox5_2.Size = size7;
      CheckBox5.TabIndex = 7;
      CheckBox5.Text = "uti";
      CheckBox6.Checked = true;
      CheckBox6.CheckState = CheckState.Checked;
      CheckBox checkBox6_1 = CheckBox6;
      point1 = new Point(120, 24);
      Point point10 = point1;
      checkBox6_1.Location = point10;
      CheckBox6.Name = "CheckBox6";
      CheckBox checkBox6_2 = CheckBox6;
      size1 = new Size(48, 16);
      Size size8 = size1;
      checkBox6_2.Size = size8;
      CheckBox6.TabIndex = 8;
      CheckBox6.Text = "utm";
      CheckBox7.Checked = true;
      CheckBox7.CheckState = CheckState.Checked;
      CheckBox checkBox7_1 = CheckBox7;
      point1 = new Point(64, 72);
      Point point11 = point1;
      checkBox7_1.Location = point11;
      CheckBox7.Name = "CheckBox7";
      CheckBox checkBox7_2 = CheckBox7;
      size1 = new Size(48, 16);
      Size size9 = size1;
      checkBox7_2.Size = size9;
      CheckBox7.TabIndex = 6;
      CheckBox7.Text = "ute";
      CheckBox8.Checked = true;
      CheckBox8.CheckState = CheckState.Checked;
      CheckBox checkBox8_1 = CheckBox8;
      point1 = new Point(120, 96);
      Point point12 = point1;
      checkBox8_1.Location = point12;
      CheckBox8.Name = "CheckBox8";
      CheckBox checkBox8_2 = CheckBox8;
      size1 = new Size(48, 16);
      Size size10 = size1;
      checkBox8_2.Size = size10;
      CheckBox8.TabIndex = 11;
      CheckBox8.Text = "utt";
      CheckBox11.Checked = true;
      CheckBox11.CheckState = CheckState.Checked;
      CheckBox checkBox11_1 = CheckBox11;
      point1 = new Point(120, 48);
      Point point13 = point1;
      checkBox11_1.Location = point13;
      CheckBox11.Name = "CheckBox11";
      CheckBox checkBox11_2 = CheckBox11;
      size1 = new Size(48, 16);
      Size size11 = size1;
      checkBox11_2.Size = size11;
      CheckBox11.TabIndex = 9;
      CheckBox11.Text = "utp";
      CheckBox12.Checked = true;
      CheckBox12.CheckState = CheckState.Checked;
      CheckBox checkBox12_1 = CheckBox12;
      point1 = new Point(168, 24);
      Point point14 = point1;
      checkBox12_1.Location = point14;
      CheckBox12.Name = "CheckBox12";
      CheckBox checkBox12_2 = CheckBox12;
      size1 = new Size(48, 16);
      Size size12 = size1;
      checkBox12_2.Size = size12;
      CheckBox12.TabIndex = 12;
      CheckBox12.Text = "utw";
      CheckBox13.Checked = true;
      CheckBox13.CheckState = CheckState.Checked;
      CheckBox checkBox13_1 = CheckBox13;
      point1 = new Point(120, 72);
      Point point15 = point1;
      checkBox13_1.Location = point15;
      CheckBox13.Name = "CheckBox13";
      CheckBox checkBox13_2 = CheckBox13;
      size1 = new Size(48, 16);
      Size size13 = size1;
      checkBox13_2.Size = size13;
      CheckBox13.TabIndex = 10;
      CheckBox13.Text = "uts";
      CheckBox16.Checked = true;
      CheckBox16.CheckState = CheckState.Checked;
      CheckBox checkBox16_1 = CheckBox16;
      point1 = new Point(8, 72);
      Point point16 = point1;
      checkBox16_1.Location = point16;
      CheckBox16.Name = "CheckBox16";
      CheckBox checkBox16_2 = CheckBox16;
      size1 = new Size(48, 16);
      Size size14 = size1;
      checkBox16_2.Size = size14;
      CheckBox16.TabIndex = 2;
      CheckBox16.Text = "ifo";
      CheckBox18.Checked = true;
      CheckBox18.CheckState = CheckState.Checked;
      CheckBox checkBox18_1 = CheckBox18;
      point1 = new Point(8, 48);
      Point point17 = point1;
      checkBox18_1.Location = point17;
      CheckBox18.Name = "CheckBox18";
      CheckBox checkBox18_2 = CheckBox18;
      size1 = new Size(48, 16);
      Size size15 = size1;
      checkBox18_2.Size = size15;
      CheckBox18.TabIndex = 1;
      CheckBox18.Text = "git";
      this.btnSetAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnSetAll = this.btnSetAll;
      point1 = new Point(87, 168);
      Point point18 = point1;
      btnSetAll.Location = point18;
      this.btnSetAll.Name = "btnSetAll";
      this.btnSetAll.TabIndex = 0;
      this.btnSetAll.Text = "Set All";
      this.btnClearAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnClearAll = this.btnClearAll;
      point1 = new Point(191, 168);
      Point point19 = point1;
      btnClearAll.Location = point19;
      this.btnClearAll.Name = "btnClearAll";
      this.btnClearAll.TabIndex = 1;
      this.btnClearAll.Text = "Clear All";
      RadioButton rbtnSensitive1 = rbtnSensitive;
      point1 = new Point(24, 14);
      Point point20 = point1;
      rbtnSensitive1.Location = point20;
      rbtnSensitive.Name = "rbtnSensitive";
      RadioButton rbtnSensitive2 = rbtnSensitive;
      size1 = new Size(88, 20);
      Size size16 = size1;
      rbtnSensitive2.Size = size16;
      rbtnSensitive.TabIndex = 1;
      rbtnSensitive.Text = "Sensitive";
      rbtnInsensitive.Checked = true;
      RadioButton rbtnInsensitive1 = rbtnInsensitive;
      point1 = new Point(24, 38);
      Point point21 = point1;
      rbtnInsensitive1.Location = point21;
      rbtnInsensitive.Name = "rbtnInsensitive";
      RadioButton rbtnInsensitive2 = rbtnInsensitive;
      size1 = new Size(88, 20);
      Size size17 = size1;
      rbtnInsensitive2.Size = size17;
      rbtnInsensitive.TabIndex = 2;
      rbtnInsensitive.TabStop = true;
      rbtnInsensitive.Text = "Insensitive";
      gboxFileTypes.Controls.Add(this.btnSetAll);
      gboxFileTypes.Controls.Add(this.btnClearAll);
      gboxFileTypes.Controls.Add(gboxGFF);
      gboxFileTypes.Controls.Add(gboxScript);
      gboxFileTypes.Enabled = false;
      GroupBox gboxFileTypes1 = gboxFileTypes;
      point1 = new Point(12, 272);
      Point point22 = point1;
      gboxFileTypes1.Location = point22;
      gboxFileTypes.Name = "gboxFileTypes";
      GroupBox gboxFileTypes2 = gboxFileTypes;
      size1 = new Size(332, 208);
      Size size18 = size1;
      gboxFileTypes2.Size = size18;
      gboxFileTypes.TabIndex = 22;
      gboxFileTypes.TabStop = false;
      gboxFileTypes.Text = "File types to search in";
      gboxGFF.Controls.Add(CheckBox2);
      gboxGFF.Controls.Add(CheckBox3);
      gboxGFF.Controls.Add(CheckBox4);
      gboxGFF.Controls.Add(CheckBox5);
      gboxGFF.Controls.Add(CheckBox6);
      gboxGFF.Controls.Add(CheckBox7);
      gboxGFF.Controls.Add(CheckBox8);
      gboxGFF.Controls.Add(CheckBox11);
      gboxGFF.Controls.Add(CheckBox13);
      gboxGFF.Controls.Add(CheckBox16);
      gboxGFF.Controls.Add(CheckBox18);
      gboxGFF.Controls.Add(CheckBox1);
      gboxGFF.Controls.Add(CheckBox12);
      GroupBox gboxGff1 = gboxGFF;
      point1 = new Point(16, 32);
      Point point23 = point1;
      gboxGff1.Location = point23;
      gboxGFF.Name = "gboxGFF";
      GroupBox gboxGff2 = gboxGFF;
      size1 = new Size(224, 128);
      Size size19 = size1;
      gboxGff2.Size = size19;
      gboxGFF.TabIndex = 24;
      gboxGFF.TabStop = false;
      gboxGFF.Text = "GFF-based files";
      gboxScript.Controls.Add(CheckBox22);
      gboxScript.Controls.Add(CheckBox23);
      GroupBox gboxScript1 = gboxScript;
      point1 = new Point(248, 32);
      Point point24 = point1;
      gboxScript1.Location = point24;
      gboxScript.Name = "gboxScript";
      GroupBox gboxScript2 = gboxScript;
      size1 = new Size(72, 88);
      Size size20 = size1;
      gboxScript2.Size = size20;
      gboxScript.TabIndex = 24;
      gboxScript.TabStop = false;
      gboxScript.Text = "Scripts";
      CheckBox22.Checked = true;
      CheckBox22.CheckState = CheckState.Checked;
      CheckBox checkBox22_1 = CheckBox22;
      point1 = new Point(16, 32);
      Point point25 = point1;
      checkBox22_1.Location = point25;
      CheckBox22.Name = "CheckBox22";
      CheckBox checkBox22_2 = CheckBox22;
      size1 = new Size(48, 16);
      Size size21 = size1;
      checkBox22_2.Size = size21;
      CheckBox22.TabIndex = 0;
      CheckBox22.Text = "ncs";
      CheckBox23.Checked = true;
      CheckBox23.CheckState = CheckState.Checked;
      CheckBox checkBox23_1 = CheckBox23;
      point1 = new Point(16, 56);
      Point point26 = point1;
      checkBox23_1.Location = point26;
      CheckBox23.Name = "CheckBox23";
      CheckBox checkBox23_2 = CheckBox23;
      size1 = new Size(48, 16);
      Size size22 = size1;
      checkBox23_2.Size = size22;
      CheckBox23.TabIndex = 1;
      CheckBox23.Text = "nss";
      gboxArchiveTypes.Controls.Add(chkbScripts);
      gboxArchiveTypes.Controls.Add(chkbTemplates);
      gboxArchiveTypes.Controls.Add(chkbRIMs);
      gboxArchiveTypes.Controls.Add(chkbAllBifs);
      gboxArchiveTypes.Enabled = false;
      GroupBox gboxArchiveTypes1 = gboxArchiveTypes;
      point1 = new Point(16, 160);
      Point point27 = point1;
      gboxArchiveTypes1.Location = point27;
      gboxArchiveTypes.Name = "gboxArchiveTypes";
      GroupBox gboxArchiveTypes2 = gboxArchiveTypes;
      size1 = new Size(328, 96);
      Size size23 = size1;
      gboxArchiveTypes2.Size = size23;
      gboxArchiveTypes.TabIndex = 23;
      gboxArchiveTypes.TabStop = false;
      gboxArchiveTypes.Text = "Archive  types to search in";
      chkbScripts.Checked = true;
      chkbScripts.CheckState = CheckState.Checked;
      CheckBox chkbScripts1 = chkbScripts;
      point1 = new Point(80, 64);
      Point point28 = point1;
      chkbScripts1.Location = point28;
      chkbScripts.Name = "chkbScripts";
      CheckBox chkbScripts2 = chkbScripts;
      size1 = new Size(80, 24);
      Size size24 = size1;
      chkbScripts2.Size = size24;
      chkbScripts.TabIndex = 2;
      chkbScripts.Text = "Scripts.bif";
      chkbTemplates.Checked = true;
      chkbTemplates.CheckState = CheckState.Checked;
      CheckBox chkbTemplates1 = chkbTemplates;
      point1 = new Point(80, 40);
      Point point29 = point1;
      chkbTemplates1.Location = point29;
      chkbTemplates.Name = "chkbTemplates";
      CheckBox chkbTemplates2 = chkbTemplates;
      size1 = new Size(96, 24);
      Size size25 = size1;
      chkbTemplates2.Size = size25;
      chkbTemplates.TabIndex = 1;
      chkbTemplates.Text = "Templates.bif";
      chkbRIMs.Checked = true;
      chkbRIMs.CheckState = CheckState.Checked;
      CheckBox chkbRiMs1 = chkbRIMs;
      point1 = new Point(224, 16);
      Point point30 = point1;
      chkbRiMs1.Location = point30;
      chkbRIMs.Name = "chkbRIMs";
      CheckBox chkbRiMs2 = chkbRIMs;
      size1 = new Size(64, 24);
      Size size26 = size1;
      chkbRiMs2.Size = size26;
      chkbRIMs.TabIndex = 3;
      chkbRIMs.Text = "RIMs";
      chkbAllBifs.Checked = true;
      chkbAllBifs.CheckState = CheckState.Checked;
      CheckBox chkbAllBifs1 = chkbAllBifs;
      point1 = new Point(64, 16);
      Point point31 = point1;
      chkbAllBifs1.Location = point31;
      chkbAllBifs.Name = "chkbAllBifs";
      CheckBox chkbAllBifs2 = chkbAllBifs;
      size1 = new Size(64, 24);
      Size size27 = size1;
      chkbAllBifs2.Size = size27;
      chkbAllBifs.TabIndex = 0;
      chkbAllBifs.Text = "All BIFs";
      gboxCaseSens.Controls.Add(rbtnSensitive);
      gboxCaseSens.Controls.Add(rbtnInsensitive);
      gboxCaseSens.Enabled = false;
      GroupBox gboxCaseSens1 = gboxCaseSens;
      point1 = new Point(224, 88);
      Point point32 = point1;
      gboxCaseSens1.Location = point32;
      gboxCaseSens.Name = "gboxCaseSens";
      GroupBox gboxCaseSens2 = gboxCaseSens;
      size1 = new Size(120, 64);
      Size size28 = size1;
      gboxCaseSens2.Size = size28;
      gboxCaseSens.TabIndex = 24;
      gboxCaseSens.TabStop = false;
      gboxCaseSens.Text = "Case";
      GroupBox2.Controls.Add(rbSearchKotor1);
      GroupBox2.Controls.Add(rbSearchKotor2);
      GroupBox groupBox2_1 = GroupBox2;
      point1 = new Point(120, 8);
      Point point33 = point1;
      groupBox2_1.Location = point33;
      GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = GroupBox2;
      size1 = new Size(104, 64);
      Size size29 = size1;
      groupBox2_2.Size = size29;
      GroupBox2.TabIndex = 25;
      GroupBox2.TabStop = false;
      GroupBox2.Text = "Search within";
      RadioButton rbSearchKotor1_1 = rbSearchKotor1;
      point1 = new Point(24, 16);
      Point point34 = point1;
      rbSearchKotor1_1.Location = point34;
      rbSearchKotor1.Name = "rbSearchKotor1";
      RadioButton rbSearchKotor1_2 = rbSearchKotor1;
      size1 = new Size(72, 20);
      Size size30 = size1;
      rbSearchKotor1_2.Size = size30;
      rbSearchKotor1.TabIndex = 0;
      rbSearchKotor1.Text = "KotOR I";
      RadioButton rbSearchKotor2_1 = rbSearchKotor2;
      point1 = new Point(24, 40);
      Point point35 = point1;
      rbSearchKotor2_1.Location = point35;
      rbSearchKotor2.Name = "rbSearchKotor2";
      RadioButton rbSearchKotor2_2 = rbSearchKotor2;
      size1 = new Size(72, 20);
      Size size31 = size1;
      rbSearchKotor2_2.Size = size31;
      rbSearchKotor2.TabIndex = 0;
      rbSearchKotor2.Text = "KotOR II";
      gboxSearchString.Controls.Add(tbSearchString);
      gboxSearchString.Enabled = false;
      GroupBox gboxSearchString1 = gboxSearchString;
      point1 = new Point(16, 88);
      Point point36 = point1;
      gboxSearchString1.Location = point36;
      gboxSearchString.Name = "gboxSearchString";
      GroupBox gboxSearchString2 = gboxSearchString;
      size1 = new Size(192, 64);
      Size size32 = size1;
      gboxSearchString2.Size = size32;
      gboxSearchString.TabIndex = 26;
      gboxSearchString.TabStop = false;
      gboxSearchString.Text = "String to search for";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(360, 525);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(gboxSearchString);
      Controls.Add(GroupBox2);
      Controls.Add(gboxCaseSens);
      Controls.Add(gboxArchiveTypes);
      Controls.Add(gboxFileTypes);
      Controls.Add(btnOK);
      Controls.Add(this.btnCancel);
      MaximizeBox = false;
      size1 = new Size(344, 376);
      MinimumSize = size1;
      Name = nameof (frmRefSearchCriteria);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Search Criteria";
      gboxFileTypes.ResumeLayout(false);
      gboxGFF.ResumeLayout(false);
      gboxScript.ResumeLayout(false);
      gboxArchiveTypes.ResumeLayout(false);
      gboxCaseSens.ResumeLayout(false);
      GroupBox2.ResumeLayout(false);
      gboxSearchString.ResumeLayout(false);
      ResumeLayout(false);
    }

  private void btnOK_Click(object sender, EventArgs e)
  {
      htFileTypes = new Hashtable();
      if (StringType.StrCmp(tbSearchString.Text, "", false) == 0)
      {
        int num1 = (int) Interaction.MsgBox("Please enter a search string", MsgBoxStyle.Critical);
      }
      else
      {
        try
        {
          foreach (Control control in gboxGFF.Controls)
          {
            if (StringType.StrCmp(control.GetType().Name, "CheckBox", false) == 0 & control.Parent.Enabled && ((CheckBox) control).Checked)
              htFileTypes.Add(control.Text, "");
          }
        }
        finally
        {
          
        }
        try
        {
          foreach (Control control in gboxScript.Controls)
          {
            if (StringType.StrCmp(control.GetType().Name, "CheckBox", false) == 0 & control.Parent.Enabled && ((CheckBox) control).Checked)
              htFileTypes.Add(control.Text, "");
          }
        }
        finally
        {
          
        }
        if (htFileTypes.Count == 0)
        {
          int num2 = (int) Interaction.MsgBox("Select at least one file type to search for the string in", MsgBoxStyle.Critical);
        }
        else
          DialogResult = DialogResult.OK;
      }
    }

  private void btnSetAll_Click(object sender, EventArgs e)
  {
      try
      {
        foreach (Control control in gboxGFF.Controls)
        {
          if (StringType.StrCmp(control.GetType().Name, "CheckBox", false) == 0)
            ((CheckBox) control).Checked = true;
        }
      }
      finally
      {
       
      }
      try
      {
        foreach (Control control in gboxScript.Controls)
        {
          if (StringType.StrCmp(control.GetType().Name, "CheckBox", false) == 0)
            ((CheckBox) control).Checked = true;
        }
      }
      finally
      {
       
      }
    }

  private void btnClearAll_Click(object sender, EventArgs e)
  {
      try
      {
        foreach (Control control in gboxGFF.Controls)
        {
          if (StringType.StrCmp(control.GetType().Name, "CheckBox", false) == 0)
            ((CheckBox) control).Checked = false;
        }
      }
      finally
      {
       
      }
      try
      {
        foreach (Control control in gboxScript.Controls)
        {
          if (StringType.StrCmp(control.GetType().Name, "CheckBox", false) == 0)
            ((CheckBox) control).Checked = false;
        }
      }
      finally
      {
       
      }
    }

  private void chkbTemplates_CheckedChanged(object sender, EventArgs e)
  {
      gboxGFF.Enabled = chkbTemplates.Checked | chkbRIMs.Checked | chkbAllBifs.Checked;
      gboxScript.Enabled = chkbTemplates.Checked | chkbRIMs.Checked | chkbScripts.Checked | chkbAllBifs.Checked;
    }

  private void chkbRIMs_CheckedChanged(object sender, EventArgs e)
  {
      gboxGFF.Enabled = chkbTemplates.Checked | chkbRIMs.Checked | chkbAllBifs.Checked;
      gboxScript.Enabled = chkbTemplates.Checked | chkbRIMs.Checked | chkbScripts.Checked | chkbAllBifs.Checked;
    }

  private void chkbScripts_CheckedChanged(object sender, EventArgs e) => gboxScript.Enabled = chkbTemplates.Checked | chkbRIMs.Checked | chkbScripts.Checked | chkbAllBifs.Checked;

  private void chkbAllBifs_CheckedChanged(object sender, EventArgs e)
  {
      if (chkbAllBifs.Checked)
      {
        chkbScripts.Checked = chkbAllBifs.Checked;
        chkbTemplates.Checked = chkbScripts.Checked;
      }
      gboxGFF.Enabled = chkbTemplates.Checked | chkbRIMs.Checked | chkbAllBifs.Checked;
      gboxScript.Enabled = chkbTemplates.Checked | chkbRIMs.Checked | chkbScripts.Checked | chkbAllBifs.Checked;
    }

  private void SetFileTypeGBsState()
  {
      chkbScripts.Checked = chkbAllBifs.Checked;
      chkbTemplates.Checked = chkbScripts.Checked;
      gboxGFF.Enabled = chkbTemplates.Checked | chkbRIMs.Checked | chkbAllBifs.Checked;
      gboxScript.Enabled = chkbTemplates.Checked | chkbRIMs.Checked | chkbScripts.Checked | chkbAllBifs.Checked;
    }

  private void rbSearch_CheckedChanged(object sender, EventArgs e)
  {
      if (!(rbSearchKotor1.Checked | rbSearchKotor2.Checked))
        return;
      gboxCaseSens.Enabled = true;
      gboxSearchString.Enabled = true;
    }

  private void tbSearchString_TextChanged(object sender, EventArgs e)
  {
      bool flag = tbSearchString.Text.Length > 0;
      gboxFileTypes.Enabled = flag;
      gboxArchiveTypes.Enabled = flag;
      btnOK.Enabled = flag;
    }
}