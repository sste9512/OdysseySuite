// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmAppearanceWizard
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmAppearanceWizard : frmParent
{
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("tbHeadNum")]
  private TextBox _tbHeadNum;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("tbName")]
  private TextBox _tbName;
  [AccessedThroughProperty("cmbxGender")]
  private ComboBox _cmbxGender;
  [AccessedThroughProperty("cmbxSizes")]
  private ComboBox _cmbxSizes;
  [AccessedThroughProperty("cmbxEnvMap")]
  private ComboBox _cmbxEnvMap;
  [AccessedThroughProperty("cmbxMovementRate")]
  private ComboBox _cmbxMovementRate;
  [AccessedThroughProperty("cmbxModelType")]
  private ComboBox _cmbxModelType;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("tbHitRadius")]
  private TextBox _tbHitRadius;
  [AccessedThroughProperty("tbPerspace")]
  private TextBox _tbPerspace;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("TabControl1")]
  private TabControl _TabControl1;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("TabPage1")]
  private TabPage _TabPage1;
  [AccessedThroughProperty("tbprefatkdist")]
  private TextBox _tbprefatkdist;
  [AccessedThroughProperty("TabPage2")]
  private TabPage _TabPage2;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("tbBaseModelName")]
  private TextBox _tbBaseModelName;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("cmbxModelNaming")]
  private ComboBox _cmbxModelNaming;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("Label20")]
  private Label _Label20;
  [AccessedThroughProperty("tbCreperspace")]
  private TextBox _tbCreperspace;
  [AccessedThroughProperty("Label21")]
  private Label _Label21;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  [AccessedThroughProperty("Label23")]
  private Label _Label23;
  [AccessedThroughProperty("Label24")]
  private Label _Label24;
  [AccessedThroughProperty("tbMa")]
  private TextBox _tbMa;
  [AccessedThroughProperty("tbTa")]
  private TextBox _tbTa;
  [AccessedThroughProperty("tbMb")]
  private TextBox _tbMb;
  [AccessedThroughProperty("tbTb")]
  private TextBox _tbTb;
  [AccessedThroughProperty("tbTd")]
  private TextBox _tbTd;
  [AccessedThroughProperty("tbMd")]
  private TextBox _tbMd;
  [AccessedThroughProperty("tbMc")]
  private TextBox _tbMc;
  [AccessedThroughProperty("tbTc")]
  private TextBox _tbTc;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("tbTf")]
  private TextBox _tbTf;
  [AccessedThroughProperty("tbMf")]
  private TextBox _tbMf;
  [AccessedThroughProperty("tbMe")]
  private TextBox _tbMe;
  [AccessedThroughProperty("tbTe")]
  private TextBox _tbTe;
  [AccessedThroughProperty("tbTg")]
  private TextBox _tbTg;
  [AccessedThroughProperty("tbMg")]
  private TextBox _tbMg;
  [AccessedThroughProperty("tbMh")]
  private TextBox _tbMh;
  [AccessedThroughProperty("tbTh")]
  private TextBox _tbTh;
  [AccessedThroughProperty("tbTi")]
  private TextBox _tbTi;
  [AccessedThroughProperty("tbMi")]
  private TextBox _tbMi;
  [AccessedThroughProperty("tbMj")]
  private TextBox _tbMj;
  [AccessedThroughProperty("tbTj")]
  private TextBox _tbTj;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("tbEvilTexture")]
  private TextBox _tbEvilTexture;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("chkbAutoCreateSeqEntries")]
  private CheckBox _chkbAutoCreateSeqEntries;
  [AccessedThroughProperty("Label25")]
  private Label _Label25;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  private IContainer components;
  public string appearanceName;

  public frmAppearanceWizard()
  {
      Load += new EventHandler(frmAppearanceWizard_Load);
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

  internal virtual Label Label6
  {
    get => _Label6;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label6 == null)
          ;
        _Label6 = value;
        if (_Label6 == null)
          ;
      }
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

  internal virtual Label Label9
  {
    get => _Label9;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label9 == null)
          ;
        _Label9 = value;
        if (_Label9 == null)
          ;
      }
  }

  internal virtual Label Label10
  {
    get => _Label10;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label10 == null)
          ;
        _Label10 = value;
        if (_Label10 == null)
          ;
      }
  }

  internal virtual TextBox tbName
  {
    get => _tbName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbName == null)
          ;
        _tbName = value;
        if (_tbName == null)
          ;
      }
  }

  internal virtual ComboBox cmbxGender
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxGender == null)
          ;
        _cmbxGender = value;
        if (_cmbxGender == null)
          ;
      }
    get => _cmbxGender;
  }

  internal virtual ComboBox cmbxSizes
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxSizes == null)
          ;
        _cmbxSizes = value;
        if (_cmbxSizes == null)
          ;
      }
    get => _cmbxSizes;
  }

  internal virtual ComboBox cmbxEnvMap
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxEnvMap == null)
          ;
        _cmbxEnvMap = value;
        if (_cmbxEnvMap == null)
          ;
      }
    get => _cmbxEnvMap;
  }

  internal virtual ComboBox cmbxMovementRate
  {
    get => _cmbxMovementRate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxMovementRate == null)
          ;
        _cmbxMovementRate = value;
        if (_cmbxMovementRate == null)
          ;
      }
  }

  internal virtual ComboBox cmbxModelType
  {
    get => _cmbxModelType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxModelType == null)
          ;
        _cmbxModelType = value;
        if (_cmbxModelType == null)
          ;
      }
  }

  internal virtual TextBox tbHitRadius
  {
    get => _tbHitRadius;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbHitRadius == null)
          ;
        _tbHitRadius = value;
        if (_tbHitRadius == null)
          ;
      }
  }

  internal virtual TextBox tbPerspace
  {
    get => _tbPerspace;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbPerspace == null)
          ;
        _tbPerspace = value;
        if (_tbPerspace == null)
          ;
      }
  }

  internal virtual TextBox tbprefatkdist
  {
    get => _tbprefatkdist;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbprefatkdist == null)
          ;
        _tbprefatkdist = value;
        if (_tbprefatkdist == null)
          ;
      }
  }

  internal virtual TextBox tbCreperspace
  {
    get => _tbCreperspace;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCreperspace == null)
          ;
        _tbCreperspace = value;
        if (_tbCreperspace == null)
          ;
      }
  }

  internal virtual Label Label11
  {
    get => _Label11;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label11 == null)
          ;
        _Label11 = value;
        if (_Label11 == null)
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

  internal virtual ComboBox cmbxModelNaming
  {
    get => _cmbxModelNaming;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxModelNaming != null)
          _cmbxModelNaming.SelectedIndexChanged -= new EventHandler(cmbxModelNaming_SelectedIndexChanged);
        _cmbxModelNaming = value;
        if (_cmbxModelNaming == null)
          return;
        _cmbxModelNaming.SelectedIndexChanged += new EventHandler(cmbxModelNaming_SelectedIndexChanged);
      }
  }

  internal virtual TextBox tbBaseModelName
  {
    get => _tbBaseModelName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbBaseModelName == null)
          ;
        _tbBaseModelName = value;
        if (_tbBaseModelName == null)
          ;
      }
  }

  internal virtual Label Label12
  {
    get => _Label12;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label12 == null)
          ;
        _Label12 = value;
        if (_Label12 == null)
          ;
      }
  }

  internal virtual TextBox tbHeadNum
  {
    get => _tbHeadNum;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbHeadNum == null)
          ;
        _tbHeadNum = value;
        if (_tbHeadNum == null)
          ;
      }
  }

  internal virtual TabControl TabControl1
  {
    get => _TabControl1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabControl1 != null)
          _TabControl1.SelectedIndexChanged -= new EventHandler(TabControl1_SelectedIndexChanged);
        _TabControl1 = value;
        if (_TabControl1 == null)
          return;
        _TabControl1.SelectedIndexChanged += new EventHandler(TabControl1_SelectedIndexChanged);
      }
  }

  internal virtual TabPage TabPage1
  {
    get => _TabPage1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPage1 == null)
          ;
        _TabPage1 = value;
        if (_TabPage1 == null)
          ;
      }
  }

  internal virtual TabPage TabPage2
  {
    get => _TabPage2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPage2 == null)
          ;
        _TabPage2 = value;
        if (_TabPage2 == null)
          ;
      }
  }

  internal virtual Label Label13
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label13 == null)
          ;
        _Label13 = value;
        if (_Label13 == null)
          ;
      }
    get => _Label13;
  }

  internal virtual Label Label14
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label14 == null)
          ;
        _Label14 = value;
        if (_Label14 == null)
          ;
      }
    get => _Label14;
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

  internal virtual Label Label16
  {
    get => _Label16;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label16 == null)
          ;
        _Label16 = value;
        if (_Label16 == null)
          ;
      }
  }

  internal virtual Label Label17
  {
    get => _Label17;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label17 == null)
          ;
        _Label17 = value;
        if (_Label17 == null)
          ;
      }
  }

  internal virtual Label Label18
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label18 == null)
          ;
        _Label18 = value;
        if (_Label18 == null)
          ;
      }
    get => _Label18;
  }

  internal virtual Label Label19
  {
    get => _Label19;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label19 == null)
          ;
        _Label19 = value;
        if (_Label19 == null)
          ;
      }
  }

  internal virtual Label Label20
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label20 == null)
          ;
        _Label20 = value;
        if (_Label20 == null)
          ;
      }
    get => _Label20;
  }

  internal virtual Label Label21
  {
    get => _Label21;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label21 == null)
          ;
        _Label21 = value;
        if (_Label21 == null)
          ;
      }
  }

  internal virtual Label Label22
  {
    get => _Label22;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label22 == null)
          ;
        _Label22 = value;
        if (_Label22 == null)
          ;
      }
  }

  internal virtual Label Label23
  {
    get => _Label23;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label23 == null)
          ;
        _Label23 = value;
        if (_Label23 == null)
          ;
      }
  }

  internal virtual Label Label24
  {
    get => _Label24;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label24 == null)
          ;
        _Label24 = value;
        if (_Label24 == null)
          ;
      }
  }

  internal virtual TextBox tbMa
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbMa == null)
          ;
        _tbMa = value;
        if (_tbMa == null)
          ;
      }
    get => _tbMa;
  }

  internal virtual TextBox tbTa
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTa == null)
          ;
        _tbTa = value;
        if (_tbTa == null)
          ;
      }
    get => _tbTa;
  }

  internal virtual TextBox tbMb
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbMb == null)
          ;
        _tbMb = value;
        if (_tbMb == null)
          ;
      }
    get => _tbMb;
  }

  internal virtual TextBox tbTb
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTb == null)
          ;
        _tbTb = value;
        if (_tbTb == null)
          ;
      }
    get => _tbTb;
  }

  internal virtual TextBox tbTd
  {
    get => _tbTd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTd == null)
          ;
        _tbTd = value;
        if (_tbTd == null)
          ;
      }
  }

  internal virtual TextBox tbMd
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbMd == null)
          ;
        _tbMd = value;
        if (_tbMd == null)
          ;
      }
    get => _tbMd;
  }

  internal virtual TextBox tbMc
  {
    get => _tbMc;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbMc == null)
          ;
        _tbMc = value;
        if (_tbMc == null)
          ;
      }
  }

  internal virtual TextBox tbTc
  {
    get => _tbTc;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTc == null)
          ;
        _tbTc = value;
        if (_tbTc == null)
          ;
      }
  }

  internal virtual TextBox tbTf
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTf == null)
          ;
        _tbTf = value;
        if (_tbTf == null)
          ;
      }
    get => _tbTf;
  }

  internal virtual TextBox tbMf
  {
    get => _tbMf;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbMf == null)
          ;
        _tbMf = value;
        if (_tbMf == null)
          ;
      }
  }

  internal virtual TextBox tbMe
  {
    get => _tbMe;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbMe == null)
          ;
        _tbMe = value;
        if (_tbMe == null)
          ;
      }
  }

  internal virtual TextBox tbTe
  {
    get => _tbTe;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTe == null)
          ;
        _tbTe = value;
        if (_tbTe == null)
          ;
      }
  }

  internal virtual TextBox tbTg
  {
    get => _tbTg;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTg == null)
          ;
        _tbTg = value;
        if (_tbTg == null)
          ;
      }
  }

  internal virtual TextBox tbMg
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbMg == null)
          ;
        _tbMg = value;
        if (_tbMg == null)
          ;
      }
    get => _tbMg;
  }

  internal virtual TextBox tbMh
  {
    get => _tbMh;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbMh == null)
          ;
        _tbMh = value;
        if (_tbMh == null)
          ;
      }
  }

  internal virtual TextBox tbTh
  {
    get => _tbTh;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTh == null)
          ;
        _tbTh = value;
        if (_tbTh == null)
          ;
      }
  }

  internal virtual TextBox tbTi
  {
    get => _tbTi;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTi == null)
          ;
        _tbTi = value;
        if (_tbTi == null)
          ;
      }
  }

  internal virtual TextBox tbMi
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbMi == null)
          ;
        _tbMi = value;
        if (_tbMi == null)
          ;
      }
    get => _tbMi;
  }

  internal virtual TextBox tbMj
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbMj == null)
          ;
        _tbMj = value;
        if (_tbMj == null)
          ;
      }
    get => _tbMj;
  }

  internal virtual TextBox tbTj
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTj == null)
          ;
        _tbTj = value;
        if (_tbTj == null)
          ;
      }
    get => _tbTj;
  }

  internal virtual TextBox tbEvilTexture
  {
    get => _tbEvilTexture;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbEvilTexture == null)
          ;
        _tbEvilTexture = value;
        if (_tbEvilTexture == null)
          ;
      }
  }

  internal virtual Label Label25
  {
    get => _Label25;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label25 == null)
          ;
        _Label25 = value;
        if (_Label25 == null)
          ;
      }
  }

  internal virtual Button Button1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Button1 == null)
          ;
        _Button1 = value;
        if (_Button1 == null)
          ;
      }
    get => _Button1;
  }

  internal virtual CheckBox chkbAutoCreateSeqEntries
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbAutoCreateSeqEntries != null)
          _chkbAutoCreateSeqEntries.CheckedChanged -= new EventHandler(chkbAutoCreateSeqEntires_CheckedChanged);
        _chkbAutoCreateSeqEntries = value;
        if (_chkbAutoCreateSeqEntries == null)
          return;
        _chkbAutoCreateSeqEntries.CheckedChanged += new EventHandler(chkbAutoCreateSeqEntires_CheckedChanged);
      }
    get => _chkbAutoCreateSeqEntries;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmAppearanceWizard));
      this.tbName = new TextBox();
      cmbxGender = new ComboBox();
      cmbxSizes = new ComboBox();
      cmbxEnvMap = new ComboBox();
      Label1 = new Label();
      Label2 = new Label();
      Label3 = new Label();
      Label4 = new Label();
      Label5 = new Label();
      cmbxMovementRate = new ComboBox();
      cmbxModelType = new ComboBox();
      Label6 = new Label();
      Label7 = new Label();
      Label8 = new Label();
      Label9 = new Label();
      Label10 = new Label();
      tbHitRadius = new TextBox();
      tbPerspace = new TextBox();
      tbprefatkdist = new TextBox();
      tbCreperspace = new TextBox();
      Label11 = new Label();
      tbBaseModelName = new TextBox();
      cmbxModelNaming = new ComboBox();
      btnOK = new Button();
      this.btnCancel = new Button();
      Label12 = new Label();
      tbHeadNum = new TextBox();
      TabControl1 = new TabControl();
      TabPage1 = new TabPage();
      TabPage2 = new TabPage();
      Button1 = new Button();
      Label15 = new Label();
      Label13 = new Label();
      this.tbMa = new TextBox();
      this.tbTa = new TextBox();
      this.tbMb = new TextBox();
      this.tbTb = new TextBox();
      this.tbTd = new TextBox();
      this.tbMd = new TextBox();
      this.tbMc = new TextBox();
      this.tbTc = new TextBox();
      this.tbTf = new TextBox();
      this.tbMf = new TextBox();
      this.tbMe = new TextBox();
      this.tbTe = new TextBox();
      this.tbTg = new TextBox();
      this.tbMg = new TextBox();
      this.tbMh = new TextBox();
      this.tbTh = new TextBox();
      this.tbTi = new TextBox();
      this.tbMi = new TextBox();
      this.tbMj = new TextBox();
      this.tbTj = new TextBox();
      Label14 = new Label();
      Label16 = new Label();
      Label17 = new Label();
      Label18 = new Label();
      Label19 = new Label();
      Label20 = new Label();
      Label21 = new Label();
      Label22 = new Label();
      Label23 = new Label();
      Label24 = new Label();
      this.tbEvilTexture = new TextBox();
      Label25 = new Label();
      chkbAutoCreateSeqEntries = new CheckBox();
      TabControl1.SuspendLayout();
      TabPage1.SuspendLayout();
      TabPage2.SuspendLayout();
      SuspendLayout();
      TextBox tbName = this.tbName;
      Point point1 = new Point(160, 24);
      Point point2 = point1;
      tbName.Location = point2;
      this.tbName.Name = "tbName";
      this.tbName.TabIndex = 0;
      this.tbName.Text = "";
      cmbxGender.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxGender.Items.AddRange(new object[2]
      {
        "Male",
        "Female"
      });
      ComboBox cmbxGender1 = cmbxGender;
      point1 = new Point(160, 56);
      Point point3 = point1;
      cmbxGender1.Location = point3;
      cmbxGender.Name = "cmbxGender";
      ComboBox cmbxGender2 = cmbxGender;
      Size size1 = new Size(56, 21);
      Size size2 = size1;
      cmbxGender2.Size = size2;
      cmbxGender.TabIndex = 1;
      cmbxSizes.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxSizes.Items.AddRange(new object[2]
      {
        "1",
        "3"
      });
      ComboBox cmbxSizes1 = cmbxSizes;
      point1 = new Point(160, 168);
      Point point4 = point1;
      cmbxSizes1.Location = point4;
      cmbxSizes.Name = "cmbxSizes";
      cmbxSizes.RightToLeft = RightToLeft.No;
      ComboBox cmbxSizes2 = cmbxSizes;
      size1 = new Size(56, 21);
      Size size3 = size1;
      cmbxSizes2.Size = size3;
      cmbxSizes.TabIndex = 5;
      cmbxEnvMap.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxEnvMap.Items.AddRange(new object[3]
      {
        "DEFAULT",
        "CM_BareMetal",
        "CM_MANUN"
      });
      ComboBox cmbxEnvMap1 = cmbxEnvMap;
      point1 = new Point(160, 200);
      Point point5 = point1;
      cmbxEnvMap1.Location = point5;
      cmbxEnvMap.Name = "cmbxEnvMap";
      cmbxEnvMap.RightToLeft = RightToLeft.No;
      ComboBox cmbxEnvMap2 = cmbxEnvMap;
      size1 = new Size(128, 21);
      Size size4 = size1;
      cmbxEnvMap2.Size = size4;
      cmbxEnvMap.TabIndex = 6;
      Label label1_1 = Label1;
      point1 = new Point(16, 24);
      Point point6 = point1;
      label1_1.Location = point6;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(100, 16);
      Size size5 = size1;
      label1_2.Size = size5;
      Label1.TabIndex = 3;
      Label1.Text = "Name";
      Label label2_1 = Label2;
      point1 = new Point(16, 56);
      Point point7 = point1;
      label2_1.Location = point7;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(100, 16);
      Size size6 = size1;
      label2_2.Size = size6;
      Label2.TabIndex = 3;
      Label2.Text = "Gender";
      Label label3_1 = Label3;
      point1 = new Point(16, 168);
      Point point8 = point1;
      label3_1.Location = point8;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(136, 16);
      Size size7 = size1;
      label3_2.Size = size7;
      Label3.TabIndex = 3;
      Label3.Text = "Number of Sizes to create";
      Label label4_1 = Label4;
      point1 = new Point(16, 200);
      Point point9 = point1;
      label4_1.Location = point9;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(100, 16);
      Size size8 = size1;
      label4_2.Size = size8;
      Label4.TabIndex = 3;
      Label4.Text = "Environment Map";
      Label label5_1 = Label5;
      point1 = new Point(16, 232);
      Point point10 = point1;
      label5_1.Location = point10;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(100, 16);
      Size size9 = size1;
      label5_2.Size = size9;
      Label5.TabIndex = 3;
      Label5.Text = "Movement Rate";
      cmbxMovementRate.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxMovementRate.Items.AddRange(new object[11]
      {
        "No Movement",
        "Wee Folk",
        "Very Slow",
        "Slow",
        "Norm/Default",
        "Fast",
        "Very Fast",
        "Player",
        "Huge",
        "Giant",
        "Fastest"
      });
      ComboBox cmbxMovementRate1 = cmbxMovementRate;
      point1 = new Point(160, 232);
      Point point11 = point1;
      cmbxMovementRate1.Location = point11;
      cmbxMovementRate.Name = "cmbxMovementRate";
      cmbxMovementRate.RightToLeft = RightToLeft.No;
      ComboBox cmbxMovementRate2 = cmbxMovementRate;
      size1 = new Size(128, 21);
      Size size10 = size1;
      cmbxMovementRate2.Size = size10;
      cmbxMovementRate.TabIndex = 7;
      cmbxModelType.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxModelType.Items.AddRange(new object[4]
      {
        "B",
        "F",
        "L",
        "S"
      });
      ComboBox cmbxModelType1 = cmbxModelType;
      point1 = new Point(160, 264);
      Point point12 = point1;
      cmbxModelType1.Location = point12;
      cmbxModelType.Name = "cmbxModelType";
      cmbxModelType.RightToLeft = RightToLeft.No;
      ComboBox cmbxModelType2 = cmbxModelType;
      size1 = new Size(128, 21);
      Size size11 = size1;
      cmbxModelType2.Size = size11;
      cmbxModelType.TabIndex = 8;
      Label label6_1 = Label6;
      point1 = new Point(16, 296);
      Point point13 = point1;
      label6_1.Location = point13;
      Label6.Name = "Label6";
      Label label6_2 = Label6;
      size1 = new Size(100, 16);
      Size size12 = size1;
      label6_2.Size = size12;
      Label6.TabIndex = 3;
      Label6.Text = "Hit Radius";
      Label label7_1 = Label7;
      point1 = new Point(16, 328);
      Point point14 = point1;
      label7_1.Location = point14;
      Label7.Name = "Label7";
      Label label7_2 = Label7;
      size1 = new Size(100, 16);
      Size size13 = size1;
      label7_2.Size = size13;
      Label7.TabIndex = 3;
      Label7.Text = "Personal Space";
      Label label8_1 = Label8;
      point1 = new Point(16, 360);
      Point point15 = point1;
      label8_1.Location = point15;
      Label8.Name = "Label8";
      Label label8_2 = Label8;
      size1 = new Size(128, 16);
      Size size14 = size1;
      label8_2.Size = size14;
      Label8.TabIndex = 3;
      Label8.Text = "CRep Personal Space";
      Label label9_1 = Label9;
      point1 = new Point(16, 392);
      Point point16 = point1;
      label9_1.Location = point16;
      Label9.Name = "Label9";
      Label label9_2 = Label9;
      size1 = new Size(136, 16);
      Size size15 = size1;
      label9_2.Size = size15;
      Label9.TabIndex = 3;
      Label9.Text = "Preferred Attack Distance";
      Label label10_1 = Label10;
      point1 = new Point(16, 264);
      Point point17 = point1;
      label10_1.Location = point17;
      Label10.Name = "Label10";
      Label label10_2 = Label10;
      size1 = new Size(100, 16);
      Size size16 = size1;
      label10_2.Size = size16;
      Label10.TabIndex = 3;
      Label10.Text = "Model Type";
      TextBox tbHitRadius1 = tbHitRadius;
      point1 = new Point(160, 296);
      Point point18 = point1;
      tbHitRadius1.Location = point18;
      tbHitRadius.Name = "tbHitRadius";
      TextBox tbHitRadius2 = tbHitRadius;
      size1 = new Size(32, 20);
      Size size17 = size1;
      tbHitRadius2.Size = size17;
      tbHitRadius.TabIndex = 9;
      tbHitRadius.Text = "****";
      tbHitRadius.TextAlign = HorizontalAlignment.Right;
      TextBox tbPerspace1 = tbPerspace;
      point1 = new Point(160, 328);
      Point point19 = point1;
      tbPerspace1.Location = point19;
      tbPerspace.Name = "tbPerspace";
      TextBox tbPerspace2 = tbPerspace;
      size1 = new Size(32, 20);
      Size size18 = size1;
      tbPerspace2.Size = size18;
      tbPerspace.TabIndex = 10;
      tbPerspace.Text = "****";
      tbPerspace.TextAlign = HorizontalAlignment.Right;
      TextBox tbprefatkdist1 = tbprefatkdist;
      point1 = new Point(160, 392);
      Point point20 = point1;
      tbprefatkdist1.Location = point20;
      tbprefatkdist.Name = "tbprefatkdist";
      TextBox tbprefatkdist2 = tbprefatkdist;
      size1 = new Size(32, 20);
      Size size19 = size1;
      tbprefatkdist2.Size = size19;
      tbprefatkdist.TabIndex = 12;
      tbprefatkdist.Text = "****";
      tbprefatkdist.TextAlign = HorizontalAlignment.Right;
      TextBox tbCreperspace1 = tbCreperspace;
      point1 = new Point(160, 360);
      Point point21 = point1;
      tbCreperspace1.Location = point21;
      tbCreperspace.Name = "tbCreperspace";
      TextBox tbCreperspace2 = tbCreperspace;
      size1 = new Size(32, 20);
      Size size20 = size1;
      tbCreperspace2.Size = size20;
      tbCreperspace.TabIndex = 11;
      tbCreperspace.Text = "****";
      tbCreperspace.TextAlign = HorizontalAlignment.Right;
      Label label11_1 = Label11;
      point1 = new Point(16, 120);
      Point point22 = point1;
      label11_1.Location = point22;
      Label11.Name = "Label11";
      Label label11_2 = Label11;
      size1 = new Size(100, 16);
      Size size21 = size1;
      label11_2.Size = size21;
      Label11.TabIndex = 3;
      Label11.Text = "Base Model Name";
      TextBox tbBaseModelName1 = tbBaseModelName;
      point1 = new Point(160, 120);
      Point point23 = point1;
      tbBaseModelName1.Location = point23;
      tbBaseModelName.Name = "tbBaseModelName";
      TextBox tbBaseModelName2 = tbBaseModelName;
      size1 = new Size(56, 20);
      Size size22 = size1;
      tbBaseModelName2.Size = size22;
      tbBaseModelName.TabIndex = 3;
      tbBaseModelName.Text = "";
      cmbxModelNaming.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxModelNaming.Items.AddRange(new object[2]
      {
        "Use name for all model entries",
        "Create sequential model entries"
      });
      ComboBox cmbxModelNaming1 = cmbxModelNaming;
      point1 = new Point(232, 120);
      Point point24 = point1;
      cmbxModelNaming1.Location = point24;
      cmbxModelNaming.Name = "cmbxModelNaming";
      ComboBox cmbxModelNaming2 = cmbxModelNaming;
      size1 = new Size(184, 21);
      Size size23 = size1;
      cmbxModelNaming2.Size = size23;
      cmbxModelNaming.TabIndex = 4;
      btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnOk = btnOK;
      point1 = new Point(280, 488);
      Point point25 = point1;
      btnOk.Location = point25;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 0;
      btnOK.Text = "OK";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(368, 488);
      Point point26 = point1;
      btnCancel.Location = point26;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      Label label12_1 = Label12;
      point1 = new Point(16, 88);
      Point point27 = point1;
      label12_1.Location = point27;
      Label12.Name = "Label12";
      Label label12_2 = Label12;
      size1 = new Size(136, 16);
      Size size24 = size1;
      label12_2.Size = size24;
      Label12.TabIndex = 3;
      Label12.Text = "Head Number";
      TextBox tbHeadNum1 = tbHeadNum;
      point1 = new Point(160, 88);
      Point point28 = point1;
      tbHeadNum1.Location = point28;
      tbHeadNum.Name = "tbHeadNum";
      TextBox tbHeadNum2 = tbHeadNum;
      size1 = new Size(40, 20);
      Size size25 = size1;
      tbHeadNum2.Size = size25;
      tbHeadNum.TabIndex = 2;
      tbHeadNum.Text = "";
      tbHeadNum.TextAlign = HorizontalAlignment.Right;
      TabControl1.Controls.Add(TabPage1);
      TabControl1.Controls.Add(TabPage2);
      TabControl tabControl1_1 = TabControl1;
      point1 = new Point(16, 16);
      Point point29 = point1;
      tabControl1_1.Location = point29;
      TabControl1.Name = "TabControl1";
      TabControl tabControl1_2 = TabControl1;
      point1 = new Point(10, 3);
      Point point30 = point1;
      tabControl1_2.Padding = point30;
      TabControl1.SelectedIndex = 0;
      TabControl tabControl1_3 = TabControl1;
      size1 = new Size(432, 448);
      Size size26 = size1;
      tabControl1_3.Size = size26;
      TabControl1.TabIndex = 0;
      TabPage1.Controls.Add(chkbAutoCreateSeqEntries);
      TabPage1.Controls.Add(this.tbName);
      TabPage1.Controls.Add(tbHeadNum);
      TabPage1.Controls.Add(Label12);
      TabPage1.Controls.Add(cmbxModelNaming);
      TabPage1.Controls.Add(tbBaseModelName);
      TabPage1.Controls.Add(Label11);
      TabPage1.Controls.Add(tbCreperspace);
      TabPage1.Controls.Add(tbprefatkdist);
      TabPage1.Controls.Add(tbPerspace);
      TabPage1.Controls.Add(tbHitRadius);
      TabPage1.Controls.Add(Label10);
      TabPage1.Controls.Add(Label9);
      TabPage1.Controls.Add(Label8);
      TabPage1.Controls.Add(Label7);
      TabPage1.Controls.Add(Label6);
      TabPage1.Controls.Add(cmbxModelType);
      TabPage1.Controls.Add(cmbxMovementRate);
      TabPage1.Controls.Add(Label5);
      TabPage1.Controls.Add(Label4);
      TabPage1.Controls.Add(Label3);
      TabPage1.Controls.Add(Label2);
      TabPage1.Controls.Add(Label1);
      TabPage1.Controls.Add(cmbxEnvMap);
      TabPage1.Controls.Add(cmbxSizes);
      TabPage1.Controls.Add(cmbxGender);
      TabPage tabPage1_1 = TabPage1;
      point1 = new Point(4, 22);
      Point point31 = point1;
      ((Control) tabPage1_1).Location = point31;
      TabPage1.Name = "TabPage1";
      TabPage tabPage1_2 = TabPage1;
      size1 = new Size(424, 422);
      Size size27 = size1;
      tabPage1_2.Size = size27;
      TabPage1.TabIndex = 0;
      TabPage1.Text = "General";
      TabPage2.Controls.Add(Button1);
      TabPage2.Controls.Add(Label15);
      TabPage2.Controls.Add(Label13);
      TabPage2.Controls.Add(this.tbMa);
      TabPage2.Controls.Add(this.tbTa);
      TabPage2.Controls.Add(this.tbMb);
      TabPage2.Controls.Add(this.tbTb);
      TabPage2.Controls.Add(this.tbTd);
      TabPage2.Controls.Add(this.tbMd);
      TabPage2.Controls.Add(this.tbMc);
      TabPage2.Controls.Add(this.tbTc);
      TabPage2.Controls.Add(this.tbTf);
      TabPage2.Controls.Add(this.tbMf);
      TabPage2.Controls.Add(this.tbMe);
      TabPage2.Controls.Add(this.tbTe);
      TabPage2.Controls.Add(this.tbTg);
      TabPage2.Controls.Add(this.tbMg);
      TabPage2.Controls.Add(this.tbMh);
      TabPage2.Controls.Add(this.tbTh);
      TabPage2.Controls.Add(this.tbTi);
      TabPage2.Controls.Add(this.tbMi);
      TabPage2.Controls.Add(this.tbMj);
      TabPage2.Controls.Add(this.tbTj);
      TabPage2.Controls.Add(Label14);
      TabPage2.Controls.Add(Label16);
      TabPage2.Controls.Add(Label17);
      TabPage2.Controls.Add(Label18);
      TabPage2.Controls.Add(Label19);
      TabPage2.Controls.Add(Label20);
      TabPage2.Controls.Add(Label21);
      TabPage2.Controls.Add(Label22);
      TabPage2.Controls.Add(Label23);
      TabPage2.Controls.Add(Label24);
      TabPage2.Controls.Add(this.tbEvilTexture);
      TabPage2.Controls.Add(Label25);
      TabPage tabPage2_1 = TabPage2;
      point1 = new Point(4, 22);
      Point point32 = point1;
      ((Control) tabPage2_1).Location = point32;
      TabPage2.Name = "TabPage2";
      TabPage tabPage2_2 = TabPage2;
      size1 = new Size(424, 422);
      Size size28 = size1;
      tabPage2_2.Size = size28;
      TabPage2.TabIndex = 1;
      TabPage2.Text = "Model/Texture Names";
      Button button1_1 = Button1;
      point1 = new Point(112, 384);
      Point point33 = point1;
      button1_1.Location = point33;
      Button1.Name = "Button1";
      Button button1_2 = Button1;
      size1 = new Size(224, 23);
      Size size29 = size1;
      button1_2.Size = size29;
      Button1.TabIndex = 21;
      Button1.Text = "Show samples from Base Model Name";
      Label label15_1 = Label15;
      point1 = new Point(80, 32);
      Point point34 = point1;
      label15_1.Location = point34;
      Label15.Name = "Label15";
      Label label15_2 = Label15;
      size1 = new Size(24, 16);
      Size size30 = size1;
      label15_2.Size = size30;
      Label15.TabIndex = 2;
      Label15.Text = "A";
      Label label13_1 = Label13;
      point1 = new Point(144, 8);
      Point point35 = point1;
      label13_1.Location = point35;
      Label13.Name = "Label13";
      Label label13_2 = Label13;
      size1 = new Size(40, 16);
      Size size31 = size1;
      label13_2.Size = size31;
      Label13.TabIndex = 1;
      Label13.Text = "Model";
      TextBox tbMa = this.tbMa;
      point1 = new Point(112, 32);
      Point point36 = point1;
      tbMa.Location = point36;
      this.tbMa.Name = "tbMa";
      this.tbMa.RightToLeft = RightToLeft.Yes;
      this.tbMa.TabIndex = 0;
      this.tbMa.Text = "";
      TextBox tbTa = this.tbTa;
      point1 = new Point(232, 32);
      Point point37 = point1;
      tbTa.Location = point37;
      this.tbTa.Name = "tbTa";
      this.tbTa.RightToLeft = RightToLeft.Yes;
      this.tbTa.TabIndex = 1;
      this.tbTa.Text = "";
      TextBox tbMb = this.tbMb;
      point1 = new Point(112, 64);
      Point point38 = point1;
      tbMb.Location = point38;
      this.tbMb.Name = "tbMb";
      this.tbMb.RightToLeft = RightToLeft.Yes;
      this.tbMb.TabIndex = 2;
      this.tbMb.Text = "";
      TextBox tbTb = this.tbTb;
      point1 = new Point(232, 64);
      Point point39 = point1;
      tbTb.Location = point39;
      this.tbTb.Name = "tbTb";
      this.tbTb.RightToLeft = RightToLeft.Yes;
      this.tbTb.TabIndex = 3;
      this.tbTb.Text = "";
      TextBox tbTd = this.tbTd;
      point1 = new Point(232, 128);
      Point point40 = point1;
      tbTd.Location = point40;
      this.tbTd.Name = "tbTd";
      this.tbTd.RightToLeft = RightToLeft.Yes;
      this.tbTd.TabIndex = 7;
      this.tbTd.Text = "";
      TextBox tbMd = this.tbMd;
      point1 = new Point(112, 128);
      Point point41 = point1;
      tbMd.Location = point41;
      this.tbMd.Name = "tbMd";
      this.tbMd.RightToLeft = RightToLeft.Yes;
      this.tbMd.TabIndex = 6;
      this.tbMd.Text = "";
      TextBox tbMc = this.tbMc;
      point1 = new Point(112, 96);
      Point point42 = point1;
      tbMc.Location = point42;
      this.tbMc.Name = "tbMc";
      this.tbMc.RightToLeft = RightToLeft.Yes;
      this.tbMc.TabIndex = 4;
      this.tbMc.Text = "";
      TextBox tbTc = this.tbTc;
      point1 = new Point(232, 96);
      Point point43 = point1;
      tbTc.Location = point43;
      this.tbTc.Name = "tbTc";
      this.tbTc.RightToLeft = RightToLeft.Yes;
      this.tbTc.TabIndex = 5;
      this.tbTc.Text = "";
      TextBox tbTf = this.tbTf;
      point1 = new Point(232, 192);
      Point point44 = point1;
      tbTf.Location = point44;
      this.tbTf.Name = "tbTf";
      this.tbTf.RightToLeft = RightToLeft.Yes;
      this.tbTf.TabIndex = 11;
      this.tbTf.Text = "";
      TextBox tbMf = this.tbMf;
      point1 = new Point(112, 192);
      Point point45 = point1;
      tbMf.Location = point45;
      this.tbMf.Name = "tbMf";
      this.tbMf.RightToLeft = RightToLeft.Yes;
      this.tbMf.TabIndex = 10;
      this.tbMf.Text = "";
      TextBox tbMe = this.tbMe;
      point1 = new Point(112, 160);
      Point point46 = point1;
      tbMe.Location = point46;
      this.tbMe.Name = "tbMe";
      this.tbMe.RightToLeft = RightToLeft.Yes;
      this.tbMe.TabIndex = 8;
      this.tbMe.Text = "";
      TextBox tbTe = this.tbTe;
      point1 = new Point(232, 160);
      Point point47 = point1;
      tbTe.Location = point47;
      this.tbTe.Name = "tbTe";
      this.tbTe.RightToLeft = RightToLeft.Yes;
      this.tbTe.TabIndex = 9;
      this.tbTe.Text = "";
      TextBox tbTg = this.tbTg;
      point1 = new Point(232, 224);
      Point point48 = point1;
      tbTg.Location = point48;
      this.tbTg.Name = "tbTg";
      this.tbTg.RightToLeft = RightToLeft.Yes;
      this.tbTg.TabIndex = 13;
      this.tbTg.Text = "";
      TextBox tbMg = this.tbMg;
      point1 = new Point(112, 224);
      Point point49 = point1;
      tbMg.Location = point49;
      this.tbMg.Name = "tbMg";
      this.tbMg.RightToLeft = RightToLeft.Yes;
      this.tbMg.TabIndex = 12;
      this.tbMg.Text = "";
      TextBox tbMh = this.tbMh;
      point1 = new Point(112, 256);
      Point point50 = point1;
      tbMh.Location = point50;
      this.tbMh.Name = "tbMh";
      this.tbMh.RightToLeft = RightToLeft.Yes;
      this.tbMh.TabIndex = 14;
      this.tbMh.Text = "";
      TextBox tbTh = this.tbTh;
      point1 = new Point(232, 256);
      Point point51 = point1;
      tbTh.Location = point51;
      this.tbTh.Name = "tbTh";
      this.tbTh.RightToLeft = RightToLeft.Yes;
      this.tbTh.TabIndex = 15;
      this.tbTh.Text = "";
      TextBox tbTi = this.tbTi;
      point1 = new Point(232, 288);
      Point point52 = point1;
      tbTi.Location = point52;
      this.tbTi.Name = "tbTi";
      this.tbTi.RightToLeft = RightToLeft.Yes;
      this.tbTi.TabIndex = 17;
      this.tbTi.Text = "";
      TextBox tbMi = this.tbMi;
      point1 = new Point(112, 288);
      Point point53 = point1;
      tbMi.Location = point53;
      this.tbMi.Name = "tbMi";
      this.tbMi.RightToLeft = RightToLeft.Yes;
      this.tbMi.TabIndex = 16;
      this.tbMi.Text = "";
      TextBox tbMj = this.tbMj;
      point1 = new Point(112, 320);
      Point point54 = point1;
      tbMj.Location = point54;
      this.tbMj.Name = "tbMj";
      this.tbMj.RightToLeft = RightToLeft.Yes;
      this.tbMj.TabIndex = 18;
      this.tbMj.Text = "";
      TextBox tbTj = this.tbTj;
      point1 = new Point(232, 320);
      Point point55 = point1;
      tbTj.Location = point55;
      this.tbTj.Name = "tbTj";
      this.tbTj.RightToLeft = RightToLeft.Yes;
      this.tbTj.TabIndex = 19;
      this.tbTj.Text = "";
      Label label14_1 = Label14;
      point1 = new Point(256, 8);
      Point point56 = point1;
      label14_1.Location = point56;
      Label14.Name = "Label14";
      Label label14_2 = Label14;
      size1 = new Size(48, 16);
      Size size32 = size1;
      label14_2.Size = size32;
      Label14.TabIndex = 1;
      Label14.Text = "Texture";
      Label label16_1 = Label16;
      point1 = new Point(80, 64);
      Point point57 = point1;
      label16_1.Location = point57;
      Label16.Name = "Label16";
      Label label16_2 = Label16;
      size1 = new Size(24, 16);
      Size size33 = size1;
      label16_2.Size = size33;
      Label16.TabIndex = 2;
      Label16.Text = "B";
      Label label17_1 = Label17;
      point1 = new Point(80, 96);
      Point point58 = point1;
      label17_1.Location = point58;
      Label17.Name = "Label17";
      Label label17_2 = Label17;
      size1 = new Size(24, 16);
      Size size34 = size1;
      label17_2.Size = size34;
      Label17.TabIndex = 2;
      Label17.Text = "C";
      Label label18_1 = Label18;
      point1 = new Point(80, 128);
      Point point59 = point1;
      label18_1.Location = point59;
      Label18.Name = "Label18";
      Label label18_2 = Label18;
      size1 = new Size(24, 16);
      Size size35 = size1;
      label18_2.Size = size35;
      Label18.TabIndex = 2;
      Label18.Text = "D";
      Label label19_1 = Label19;
      point1 = new Point(80, 256);
      Point point60 = point1;
      label19_1.Location = point60;
      Label19.Name = "Label19";
      Label label19_2 = Label19;
      size1 = new Size(24, 16);
      Size size36 = size1;
      label19_2.Size = size36;
      Label19.TabIndex = 2;
      Label19.Text = "H";
      Label label20_1 = Label20;
      point1 = new Point(80, 192);
      Point point61 = point1;
      label20_1.Location = point61;
      Label20.Name = "Label20";
      Label label20_2 = Label20;
      size1 = new Size(24, 16);
      Size size37 = size1;
      label20_2.Size = size37;
      Label20.TabIndex = 2;
      Label20.Text = "F";
      Label label21_1 = Label21;
      point1 = new Point(80, 224);
      Point point62 = point1;
      label21_1.Location = point62;
      Label21.Name = "Label21";
      Label label21_2 = Label21;
      size1 = new Size(24, 16);
      Size size38 = size1;
      label21_2.Size = size38;
      Label21.TabIndex = 2;
      Label21.Text = "G";
      Label label22_1 = Label22;
      point1 = new Point(80, 160);
      Point point63 = point1;
      label22_1.Location = point63;
      Label22.Name = "Label22";
      Label label22_2 = Label22;
      size1 = new Size(24, 16);
      Size size39 = size1;
      label22_2.Size = size39;
      Label22.TabIndex = 2;
      Label22.Text = "E";
      Label label23_1 = Label23;
      point1 = new Point(80, 320);
      Point point64 = point1;
      label23_1.Location = point64;
      Label23.Name = "Label23";
      Label label23_2 = Label23;
      size1 = new Size(24, 16);
      Size size40 = size1;
      label23_2.Size = size40;
      Label23.TabIndex = 2;
      Label23.Text = "J";
      Label label24_1 = Label24;
      point1 = new Point(80, 288);
      Point point65 = point1;
      label24_1.Location = point65;
      Label24.Name = "Label24";
      Label label24_2 = Label24;
      size1 = new Size(24, 16);
      Size size41 = size1;
      label24_2.Size = size41;
      Label24.TabIndex = 2;
      Label24.Text = "I";
      TextBox tbEvilTexture = this.tbEvilTexture;
      point1 = new Point(112, 352);
      Point point66 = point1;
      tbEvilTexture.Location = point66;
      this.tbEvilTexture.Name = "tbEvilTexture";
      this.tbEvilTexture.RightToLeft = RightToLeft.Yes;
      this.tbEvilTexture.TabIndex = 20;
      this.tbEvilTexture.Text = "";
      Label label25_1 = Label25;
      point1 = new Point(32, 352);
      Point point67 = point1;
      label25_1.Location = point67;
      Label25.Name = "Label25";
      Label label25_2 = Label25;
      size1 = new Size(64, 16);
      Size size42 = size1;
      label25_2.Size = size42;
      Label25.TabIndex = 1;
      Label25.Text = "Evil Texture";
      CheckBox createSeqEntries1 = chkbAutoCreateSeqEntries;
      point1 = new Point(232, 144);
      Point point68 = point1;
      createSeqEntries1.Location = point68;
      chkbAutoCreateSeqEntries.Name = "chkbAutoCreateSeqEntries";
      CheckBox createSeqEntries2 = chkbAutoCreateSeqEntries;
      size1 = new Size(184, 16);
      Size size43 = size1;
      createSeqEntries2.Size = size43;
      chkbAutoCreateSeqEntries.TabIndex = 13;
      chkbAutoCreateSeqEntries.Text = "Auto-create sequential entries";
      chkbAutoCreateSeqEntries.Visible = false;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(464, 517);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(TabControl1);
      Controls.Add(btnOK);
      Controls.Add(this.btnCancel);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Name = nameof (frmAppearanceWizard);
      SizeGripStyle = SizeGripStyle.Hide;
      Text = "Appearance Wizard";
      TabControl1.ResumeLayout(false);
      TabPage1.ResumeLayout(false);
      TabPage2.ResumeLayout(false);
      ResumeLayout(false);
    }

  private void frmAppearanceWizard_Load(object sender, EventArgs e)
  {
      cmbxEnvMap.SelectedIndex = 0;
      cmbxGender.SelectedIndex = 0;
      cmbxModelNaming.SelectedIndex = 0;
      cmbxModelType.SelectedIndex = 0;
      cmbxMovementRate.SelectedIndex = 4;
      cmbxSizes.SelectedIndex = 1;
      tbHitRadius.Text = "0.25";
      tbPerspace.Text = "0.35";
      tbCreperspace.Text = "0.4";
      tbprefatkdist.Text = "0.5";
    }

  public string GetSizeString(int index)
  {
      switch (index)
      {
        case 1:
          return "SML";
        case 2:
          return "MED";
        case 3:
          return "LRG";
        default:
          string sizeString = null;
          return sizeString;
      }
    }

  public string GetSizeLetter(int index) => Strings.Mid(GetSizeString(index), 1, 1);

  public string GetSpeedString()
  {
      switch (cmbxMovementRate.SelectedIndex)
      {
        case 0:
          return "NOMOVE";
        case 1:
          return "WEE_FOLK";
        case 2:
          return "VSLOW";
        case 3:
          return "SLOW";
        case 4:
          return "NORM";
        case 5:
          return "FAST";
        case 6:
          return "VFAST";
        case 7:
          return "PLAYER";
        case 8:
          return "HUGE";
        case 9:
          return "GIANT";
        case 10:
          return "DFAST";
        default:
          string speedString = null;
          return speedString;
      }
    }

  public void FillRowCommonInfo(ref DataRow dr)
  {
      dr[0] = "512";
      dr[1] = "placeholder for name";
      dr[2] = "****";
      dr[3] = "****";
      dr[4] = "1.813";
      dr[5] = "3.96";
      dr[6] = "1.813";
      dr[7] = "3.96";
      dr[8] = "****";
      dr[9] = "B";
      dr[10] = "77";
      dr[11] = "PMBAL";
      dr[12] = "";
      dr[13] = "";
      dr[14] = "";
      dr[15] = "";
      dr[16] = "";
      dr[17] = "";
      dr[18] = "";
      dr[19] = "";
      dr[20] = "";
      dr[21] = "";
      dr[22] = "";
      dr[23] = "";
      dr[24] = "";
      dr[25] = "";
      dr[26] = "";
      dr[27] = "";
      dr[28] = "";
      dr[29] = "";
      dr[30] = "";
      dr[31] = "";
      dr[32] = "****";
      dr[33] = "****";
      dr[34] = "****";
      dr[35] = "****";
      dr[36] = "****";
      dr[37] = "****";
      dr[38] = "DEFAULT";
      dr[39] = "R";
      dr[40] = "****";
      dr[41] = "1";
      dr[42] = "NORM";
      dr[43] = "50";
      dr[44] = "5.4";
      dr[45] = "0.25";
      dr[46] = "0.35";
      dr[47] = "0.4";
      dr[48] = "****";
      dr[49] = "1.6";
      dr[50] = "l";
      dr[51] = "0";
      dr[52] = "20";
      dr[53] = "1";
      dr[54] = "1";
      dr[55] = "****";
      dr[56] = "****";
      dr[57] = "1";
      dr[58] = "3";
      dr[59] = "****";
      dr[60] = "****";
      dr[61] = "****";
      dr[62] = "****";
      dr[63] = "9";
      dr[64] = "0";
      dr[65] = "0";
      dr[66] = "1";
      dr[67] = "30";
      dr[68] = "15";
      dr[69] = "****";
      dr[70] = "1";
      dr[71] = "0.5";
      dr[72] = "0";
      dr[73] = "2";
      dr[74] = "****";
      dr[75] = "****";
      dr[76] = "****";
      dr[77] = "****";
      dr[78] = "****";
      dr[79] = "****";
      dr[80] = "****";
    }

  public void GenerateModelStrings(int size)
  {
      tbMa.Text = tbBaseModelName.Text + "A" + GetSizeLetter(size);
      tbMb.Text = tbBaseModelName.Text + "B" + GetSizeLetter(size);
      tbMc.Text = tbBaseModelName.Text + "C" + GetSizeLetter(size);
      tbMd.Text = tbBaseModelName.Text + "D" + GetSizeLetter(size);
      tbMe.Text = tbBaseModelName.Text + "E" + GetSizeLetter(size);
      tbMf.Text = tbBaseModelName.Text + "F" + GetSizeLetter(size);
      tbMg.Text = tbBaseModelName.Text + "G" + GetSizeLetter(size);
      tbMh.Text = tbBaseModelName.Text + "H" + GetSizeLetter(size);
      tbMi.Text = tbBaseModelName.Text + "I" + GetSizeLetter(size);
      tbMj.Text = tbBaseModelName.Text + "J" + GetSizeLetter(size);
      tbTa.Text = tbBaseModelName.Text + "A";
      tbTb.Text = tbBaseModelName.Text + "B";
      tbTc.Text = tbBaseModelName.Text + "C";
      tbTd.Text = tbBaseModelName.Text + "D";
      tbTe.Text = tbBaseModelName.Text + "E";
      tbTf.Text = tbBaseModelName.Text + "F";
      tbTg.Text = tbBaseModelName.Text + "G";
      tbTh.Text = tbBaseModelName.Text + "H";
      tbTi.Text = tbBaseModelName.Text + "I";
      tbTj.Text = tbBaseModelName.Text + "J";
    }

  public void PropagateBaseModelString() => SetAllModelStrings(tbBaseModelName.Text);

  public void ClearAllModelStrings() => SetAllModelStrings("");

  public void SetAllModelStrings(string s)
  {
      tbMa.Text = s;
      tbMb.Text = s;
      tbMc.Text = s;
      tbMd.Text = s;
      tbMe.Text = s;
      tbMf.Text = s;
      tbMg.Text = s;
      tbMh.Text = s;
      tbMi.Text = s;
      tbMj.Text = s;
      tbTa.Text = s;
      tbTb.Text = s;
      tbTc.Text = s;
      tbTd.Text = s;
      tbTe.Text = s;
      tbTf.Text = s;
      tbTg.Text = s;
      tbTh.Text = s;
      tbTi.Text = s;
      tbTj.Text = s;
    }

  private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
  {
      if (StringType.StrCmp(Strings.Trim(tbBaseModelName.Text), "", false) == 0)
        return;
      if (cmbxModelNaming.SelectedIndex == 1)
        GenerateModelStrings(1);
      else
        PropagateBaseModelString();
    }

  private void cmbxModelNaming_SelectedIndexChanged(object sender, EventArgs e) => chkbAutoCreateSeqEntries.Visible = cmbxModelNaming.SelectedIndex == 1;

  private void chkbAutoCreateSeqEntires_CheckedChanged(object sender, EventArgs e)
  {
      bool flag = chkbAutoCreateSeqEntries.Checked;
      tbMa.ReadOnly = flag;
      tbTa.ReadOnly = flag;
      tbEvilTexture.ReadOnly = flag;
      tbMb.ReadOnly = flag;
      tbTb.ReadOnly = flag;
      tbMc.ReadOnly = flag;
      tbTc.ReadOnly = flag;
      tbMd.ReadOnly = flag;
      tbTd.ReadOnly = flag;
      tbMe.ReadOnly = flag;
      tbTe.ReadOnly = flag;
      tbMf.ReadOnly = flag;
      tbTf.ReadOnly = flag;
      tbMg.ReadOnly = flag;
      tbTg.ReadOnly = flag;
      tbMh.ReadOnly = flag;
      tbTh.ReadOnly = flag;
      tbMi.ReadOnly = flag;
      tbTi.ReadOnly = flag;
      tbMj.ReadOnly = flag;
      tbTj.ReadOnly = flag;
    }
}