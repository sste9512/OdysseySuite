// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmDialogEditor
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmDialogEditor : frmParent
{
  [AccessedThroughProperty("nudCameraID")]
  private NumericUpDown _nudCameraID;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("nudPlotIndex")]
  private NumericUpDown _nudPlotIndex;
  [AccessedThroughProperty("btnDebug")]
  private Button _btnDebug;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("TabControl1")]
  private TabControl _TabControl1;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("tbListener")]
  private TextBox _tbListener;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("Label20")]
  private Label _Label20;
  [AccessedThroughProperty("nudPlotXPPercentage")]
  private NumericUpDown _nudPlotXPPercentage;
  [AccessedThroughProperty("Label21")]
  private Label _Label21;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  [AccessedThroughProperty("btnExpandAll")]
  private Button _btnExpandAll;
  [AccessedThroughProperty("Label23")]
  private Label _Label23;
  [AccessedThroughProperty("nudCamHeightOffset")]
  private NumericUpDown _nudCamHeightOffset;
  [AccessedThroughProperty("Label24")]
  private Label _Label24;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("tbVoiceOverResRef")]
  private TextBox _tbVoiceOverResRef;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("nudFadeColorB")]
  private NumericUpDown _nudFadeColorB;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label39")]
  private Label _Label39;
  [AccessedThroughProperty("tbActionsTakenScript2")]
  private TextBox _tbActionsTakenScript2;
  [AccessedThroughProperty("btnCollapseAll")]
  private Button _btnCollapseAll;
  [AccessedThroughProperty("Label38")]
  private Label _Label38;
  [AccessedThroughProperty("tbTextActiveScript2")]
  private TextBox _tbTextActiveScript2;
  [AccessedThroughProperty("nudTarHeightOffset")]
  private NumericUpDown _nudTarHeightOffset;
  [AccessedThroughProperty("tabpagThisFile3")]
  private TabPage _tabpagThisFile3;
  [AccessedThroughProperty("cmiTV_MoveNodeDown")]
  private ToolStripMenuItem _cmiTV_MoveNodeDown;
  [AccessedThroughProperty("cmiTV_MoveNodeUp")]
  private ToolStripMenuItem _cmiTV_MoveNodeUp;
  [AccessedThroughProperty("lblPlotIndex")]
  private Label _lblPlotIndex;
  [AccessedThroughProperty("nudCamFieldOfView")]
  private NumericUpDown _nudCamFieldOfView;
  [AccessedThroughProperty("Label37")]
  private Label _Label37;
  [AccessedThroughProperty("Label31")]
  private Label _Label31;
  [AccessedThroughProperty("nudFadeColorG")]
  private NumericUpDown _nudFadeColorG;
  [AccessedThroughProperty("tbCameraModel")]
  private TextBox _tbCameraModel;
  [AccessedThroughProperty("chkbAnimatedCut")]
  private CheckBox _chkbAnimatedCut;
  [AccessedThroughProperty("tbComments")]
  private TextBox _tbComments;
  [AccessedThroughProperty("cmbxCamVidEffect")]
  private ComboBox _cmbxCamVidEffect;
  [AccessedThroughProperty("nudFadeColorR")]
  private NumericUpDown _nudFadeColorR;
  [AccessedThroughProperty("cmbxFadeType")]
  private ComboBox _cmbxFadeType;
  [AccessedThroughProperty("btnShowLists")]
  private Button _btnShowLists;
  [AccessedThroughProperty("nudQuestEntry")]
  private NumericUpDown _nudQuestEntry;
  [AccessedThroughProperty("nudFadeDelay")]
  private NumericUpDown _nudFadeDelay;
  [AccessedThroughProperty("Label36")]
  private Label _Label36;
  [AccessedThroughProperty("btnTest")]
  private Button _btnTest;
  [AccessedThroughProperty("Label35")]
  private Label _Label35;
  [AccessedThroughProperty("tbQuest")]
  private TextBox _tbQuest;
  [AccessedThroughProperty("cmbxComputerType")]
  private ComboBox _cmbxComputerType;
  [AccessedThroughProperty("cmbxConversationType")]
  private ComboBox _cmbxConversationType;
  [AccessedThroughProperty("nudFadeLength")]
  private NumericUpDown _nudFadeLength;
  [AccessedThroughProperty("cmiTV_Cut")]
  private ToolStripMenuItem _cmiTV_Cut;
  [AccessedThroughProperty("tbLinkID")]
  private TextBox _tbLinkID;
  [AccessedThroughProperty("tbLinkedCnt")]
  private TextBox _tbLinkedCnt;
  [AccessedThroughProperty("tbSharedCnt")]
  private TextBox _tbSharedCnt;
  [AccessedThroughProperty("ToolTip1")]
  private ToolTip _ToolTip1;
  [AccessedThroughProperty("Label34")]
  private Label _Label34;
  [AccessedThroughProperty("tbLinkDesc")]
  private TextBox _tbLinkDesc;
  [AccessedThroughProperty("tbSound")]
  private TextBox _tbSound;
  [AccessedThroughProperty("cmiTV_PasteTree")]
  private ToolStripMenuItem _cmiTV_PasteTree;
  [AccessedThroughProperty("trkbTVItemHeight")]
  private TrackBar _trkbTVItemHeight;
  [AccessedThroughProperty("Label33")]
  private Label _Label33;
  [AccessedThroughProperty("miNew")]
  private ToolStripMenuItem _miNew;
  [AccessedThroughProperty("Label25")]
  private Label _Label25;
  [AccessedThroughProperty("tbVO_ID")]
  private TextBox _tbVO_ID;
  [AccessedThroughProperty("Label32")]
  private Label _Label32;
  [AccessedThroughProperty("trkbTVIndent")]
  private TrackBar _trkbTVIndent;
  [AccessedThroughProperty("btnChooseColor")]
  private Button _btnChooseColor;
  [AccessedThroughProperty("btnAddAnimListEntry")]
  private Button _btnAddAnimListEntry;
  [AccessedThroughProperty("btnDeleteAnimListEntry")]
  private Button _btnDeleteAnimListEntry;
  [AccessedThroughProperty("dgAnimList")]
  private DataGrid _dgAnimList;
  [AccessedThroughProperty("cmiTV_PasteAsLink")]
  private ToolStripMenuItem _cmiTV_PasteAsLink;
  [AccessedThroughProperty("tvConversation")]
  private TreeView _tvConversation;
  [AccessedThroughProperty("tbTextActiveScript")]
  private TextBox _tbTextActiveScript;
  [AccessedThroughProperty("Label30")]
  private Label _Label30;
  [AccessedThroughProperty("dgStuntList")]
  private DataGrid _dgStuntList;
  [AccessedThroughProperty("ToolStripMenuItem4")]
  private ToolStripMenuItem _ToolStripMenuItem4;
  [AccessedThroughProperty("tabpagThisFile2")]
  private TabPage _tabpagThisFile2;
  [AccessedThroughProperty("tabpagThisFile1")]
  private TabPage _tabpagThisFile1;
  [AccessedThroughProperty("tbEndConversation")]
  private TextBox _tbEndConversation;
  [AccessedThroughProperty("ToolStripMenuItem2")]
  private ToolStripMenuItem _ToolStripMenuItem2;
  [AccessedThroughProperty("miSave")]
  private ToolStripMenuItem _miSave;
  [AccessedThroughProperty("miQuit")]
  private ToolStripMenuItem _miQuit;
  [AccessedThroughProperty("miOpen")]
  private ToolStripMenuItem _miOpen;
  [AccessedThroughProperty("btnOpen")]
  private Button _btnOpen;
  [AccessedThroughProperty("cmTVfunctions")]
  private ContextMenu _cmTVfunctions;
  [AccessedThroughProperty("tbEndConverAbort")]
  private TextBox _tbEndConverAbort;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("tbAmbientTrack")]
  private TextBox _tbAmbientTrack;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("chkbSkippable")]
  private CheckBox _chkbSkippable;
  [AccessedThroughProperty("chkbUnequipItems")]
  private CheckBox _chkbUnequipItems;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("tbActionsTakenScript")]
  private TextBox _tbActionsTakenScript;
  [AccessedThroughProperty("Label26")]
  private Label _Label26;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("nudDelayEntry")]
  private NumericUpDown _nudDelayEntry;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("nudDelayReply")]
  private NumericUpDown _nudDelayReply;
  [AccessedThroughProperty("Label27")]
  private Label _Label27;
  [AccessedThroughProperty("cmiTV_Add")]
  private ToolStripMenuItem _cmiTV_Add;
  [AccessedThroughProperty("chkbUnequipHItem")]
  private CheckBox _chkbUnequipHItem;
  [AccessedThroughProperty("tbSpeaker")]
  private TextBox _tbSpeaker;
  [AccessedThroughProperty("Label28")]
  private Label _Label28;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("cmiTV_Paste")]
  private ToolStripMenuItem _cmiTV_Paste;
  [AccessedThroughProperty("tabpagDebug")]
  private TabPage _tabpagDebug;
  [AccessedThroughProperty("tabpagAnimationSound")]
  private TabPage _tabpagAnimationSound;
  [AccessedThroughProperty("ToolStripMenuItem1")]
  private ToolStripMenuItem _ToolStripMenuItem1;
  [AccessedThroughProperty("tabpagPlot")]
  private TabPage _tabpagPlot;
  [AccessedThroughProperty("tbConversationText")]
  private TextBox _tbConversationText;
  [AccessedThroughProperty("MainMenu1")]
  private MainMenu _MainMenu1;
  [AccessedThroughProperty("Label29")]
  private Label _Label29;
  [AccessedThroughProperty("tabpagComment")]
  private TabPage _tabpagComment;
  [AccessedThroughProperty("tabpagCamera")]
  private TabPage _tabpagCamera;
  [AccessedThroughProperty("tabpagActionsTaken")]
  private TabPage _tabpagActionsTaken;
  [AccessedThroughProperty("nudCameraAngle")]
  private NumericUpDown _nudCameraAngle;
  [AccessedThroughProperty("cmiTV_Copy")]
  private ToolStripMenuItem _cmiTV_Copy;
  private IContainer components;
  private clsDLG clsdlg;
  private int EntryIndex;
  private int ReplyIndex;
  private ArrayList EntryList;
  private ArrayList ReplyList;
  private ClsGff gff;
  private GffStruct @struct;
  private DLGConvListNode LastClickedTvConversationNode;
  private DLGConvListNode CurrentContextMenuTvConversationNode;
  private DLGConvListNode ClipBoardNode;
  private string filename;
  private DataTable dtStunt;
  private DataView DViewStunt;
  private DataTable dtAnim;
  private DataView DViewAnim;

  public frmDialogEditor()
  {
      dtStunt = new DataTable();
      dtAnim = new DataTable();
      InitializeComponent();
      MDefaultTitleText = "Conversation Editor - KotOR ";
      Text = MDefaultTitleText;
      BuildStuntDataGrid();
      BuildAnimDataGrid();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual TextBox tbConversationText
  {
    get => _tbConversationText;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbConversationText == null)
          ;
        _tbConversationText = value;
        if (_tbConversationText == null)
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

  internal virtual TextBox tbActionsTakenScript
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbActionsTakenScript == null)
          ;
        _tbActionsTakenScript = value;
        if (_tbActionsTakenScript == null)
          ;
      }
    get => _tbActionsTakenScript;
  }

  internal virtual TreeView tvConversation
  {
    get => _tvConversation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvConversation != null)
        {
          _tvConversation.AfterSelect -= new TreeViewEventHandler(tvConversation_AfterSelect);
          _tvConversation.MouseUp -= new MouseEventHandler(tvConversation_MouseUp);
          _tvConversation.MouseDown -= new MouseEventHandler(tvConversation_MouseDown);
        }
        _tvConversation = value;
        if (_tvConversation == null)
          return;
        _tvConversation.AfterSelect += new TreeViewEventHandler(tvConversation_AfterSelect);
        _tvConversation.MouseUp += new MouseEventHandler(tvConversation_MouseUp);
        _tvConversation.MouseDown += new MouseEventHandler(tvConversation_MouseDown);
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

  internal virtual TextBox tbSound
  {
    get => _tbSound;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbSound == null)
          ;
        _tbSound = value;
        if (_tbSound == null)
          ;
      }
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

  internal virtual TextBox tbComments
  {
    get => _tbComments;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbComments == null)
          ;
        _tbComments = value;
        if (_tbComments == null)
          ;
      }
  }

  internal virtual Button btnCollapseAll
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnCollapseAll != null)
          _btnCollapseAll.Click -= new EventHandler(btnCollapseAll_Click);
        _btnCollapseAll = value;
        if (_btnCollapseAll == null)
          return;
        _btnCollapseAll.Click += new EventHandler(btnCollapseAll_Click);
      }
    get => _btnCollapseAll;
  }

  internal virtual Button btnExpandAll
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnExpandAll != null)
          _btnExpandAll.Click -= new EventHandler(btnExpandAll_Click);
        _btnExpandAll = value;
        if (_btnExpandAll == null)
          return;
        _btnExpandAll.Click += new EventHandler(btnExpandAll_Click);
      }
    get => _btnExpandAll;
  }

  internal virtual Button btnDebug
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnDebug != null)
          _btnDebug.Click -= new EventHandler(btnDebug_Click);
        _btnDebug = value;
        if (_btnDebug == null)
          return;
        _btnDebug.Click += new EventHandler(btnDebug_Click);
      }
    get => _btnDebug;
  }

  internal virtual Label Label7
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label7 == null)
          ;
        _Label7 = value;
        if (_Label7 == null)
          ;
      }
    get => _Label7;
  }

  internal virtual Label Label8
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label8 == null)
          ;
        _Label8 = value;
        if (_Label8 == null)
          ;
      }
    get => _Label8;
  }

  internal virtual TextBox tbListener
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbListener == null)
          ;
        _tbListener = value;
        if (_tbListener == null)
          ;
      }
    get => _tbListener;
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

  internal virtual TextBox tbVoiceOverResRef
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbVoiceOverResRef == null)
          ;
        _tbVoiceOverResRef = value;
        if (_tbVoiceOverResRef == null)
          ;
      }
    get => _tbVoiceOverResRef;
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

  internal virtual Label lblPlotIndex
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblPlotIndex == null)
          ;
        _lblPlotIndex = value;
        if (_lblPlotIndex == null)
          ;
      }
    get => _lblPlotIndex;
  }

  internal virtual Label Label12
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label12 == null)
          ;
        _Label12 = value;
        if (_Label12 == null)
          ;
      }
    get => _Label12;
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
    get => _Label14;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label14 == null)
          ;
        _Label14 = value;
        if (_Label14 == null)
          ;
      }
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

  internal virtual Button btnTest
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnTest != null)
          _btnTest.Click -= new EventHandler(btnTest_Click);
        _btnTest = value;
        if (_btnTest == null)
          return;
        _btnTest.Click += new EventHandler(btnTest_Click);
      }
    get => _btnTest;
  }

  internal virtual Button btnChooseColor
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnChooseColor != null)
          _btnChooseColor.Click -= new EventHandler(btnChooseColor_Click);
        _btnChooseColor = value;
        if (_btnChooseColor == null)
          return;
        _btnChooseColor.Click += new EventHandler(btnChooseColor_Click);
      }
    get => _btnChooseColor;
  }

  internal virtual ContextMenu cmTVfunctions
  {
    get => _cmTVfunctions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmTVfunctions == null)
          ;
        _cmTVfunctions = value;
        if (_cmTVfunctions == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem cmiTV_Add
  {
    get => _cmiTV_Add;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiTV_Add != null)
          _cmiTV_Add.Click -= new EventHandler(cmiTV_Add_Click);
        _cmiTV_Add = value;
        if (_cmiTV_Add == null)
          return;
        _cmiTV_Add.Click += new EventHandler(cmiTV_Add_Click);
      }
  }

  internal virtual ToolStripMenuItem cmiTV_Copy
  {
    get => _cmiTV_Copy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiTV_Copy != null)
          _cmiTV_Copy.Click -= new EventHandler(cmiTV_Copy_Click);
        _cmiTV_Copy = value;
        if (_cmiTV_Copy == null)
          return;
        _cmiTV_Copy.Click += new EventHandler(cmiTV_Copy_Click);
      }
  }

  internal virtual ToolStripMenuItem cmiTV_Paste
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiTV_Paste != null)
          _cmiTV_Paste.Click -= new EventHandler(cmiTV_Paste_Click);
        _cmiTV_Paste = value;
        if (_cmiTV_Paste == null)
          return;
        _cmiTV_Paste.Click += new EventHandler(cmiTV_Paste_Click);
      }
    get => _cmiTV_Paste;
  }

  internal virtual ToolStripMenuItem cmiTV_PasteAsLink
  {
    get => _cmiTV_PasteAsLink;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiTV_PasteAsLink != null)
          _cmiTV_PasteAsLink.Click -= new EventHandler(cmiTV_PasteAsLink_Click);
        _cmiTV_PasteAsLink = value;
        if (_cmiTV_PasteAsLink == null)
          return;
        _cmiTV_PasteAsLink.Click += new EventHandler(cmiTV_PasteAsLink_Click);
      }
  }

  internal virtual ToolStripMenuItem cmiTV_Cut
  {
    get => _cmiTV_Cut;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiTV_Cut != null)
          _cmiTV_Cut.Click -= new EventHandler(cmiTV_Cut_Click);
        _cmiTV_Cut = value;
        if (_cmiTV_Cut == null)
          return;
        _cmiTV_Cut.Click += new EventHandler(cmiTV_Cut_Click);
      }
  }

  internal virtual NumericUpDown nudFadeColorG
  {
    get => _nudFadeColorG;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudFadeColorG == null)
          ;
        _nudFadeColorG = value;
        if (_nudFadeColorG == null)
          ;
      }
  }

  internal virtual NumericUpDown nudFadeColorB
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudFadeColorB == null)
          ;
        _nudFadeColorB = value;
        if (_nudFadeColorB == null)
          ;
      }
    get => _nudFadeColorB;
  }

  internal virtual NumericUpDown nudPlotIndex
  {
    get => _nudPlotIndex;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudPlotIndex == null)
          ;
        _nudPlotIndex = value;
        if (_nudPlotIndex == null)
          ;
      }
  }

  internal virtual NumericUpDown nudPlotXPPercentage
  {
    get => _nudPlotXPPercentage;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudPlotXPPercentage == null)
          ;
        _nudPlotXPPercentage = value;
        if (_nudPlotXPPercentage == null)
          ;
      }
  }

  internal virtual NumericUpDown nudCameraAngle
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudCameraAngle == null)
          ;
        _nudCameraAngle = value;
        if (_nudCameraAngle == null)
          ;
      }
    get => _nudCameraAngle;
  }

  internal virtual NumericUpDown nudCamHeightOffset
  {
    get => _nudCamHeightOffset;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudCamHeightOffset == null)
          ;
        _nudCamHeightOffset = value;
        if (_nudCamHeightOffset == null)
          ;
      }
  }

  internal virtual NumericUpDown nudTarHeightOffset
  {
    get => _nudTarHeightOffset;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudTarHeightOffset == null)
          ;
        _nudTarHeightOffset = value;
        if (_nudTarHeightOffset == null)
          ;
      }
  }

  internal virtual NumericUpDown nudFadeDelay
  {
    get => _nudFadeDelay;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudFadeDelay == null)
          ;
        _nudFadeDelay = value;
        if (_nudFadeDelay == null)
          ;
      }
  }

  internal virtual NumericUpDown nudFadeLength
  {
    get => _nudFadeLength;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudFadeLength == null)
          ;
        _nudFadeLength = value;
        if (_nudFadeLength == null)
          ;
      }
  }

  internal virtual TextBox tbLinkID
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbLinkID == null)
          ;
        _tbLinkID = value;
        if (_tbLinkID == null)
          ;
      }
    get => _tbLinkID;
  }

  internal virtual TextBox tbLinkedCnt
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbLinkedCnt == null)
          ;
        _tbLinkedCnt = value;
        if (_tbLinkedCnt == null)
          ;
      }
    get => _tbLinkedCnt;
  }

  internal virtual TextBox tbSharedCnt
  {
    get => _tbSharedCnt;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbSharedCnt == null)
          ;
        _tbSharedCnt = value;
        if (_tbSharedCnt == null)
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
    get => _Label18;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label18 == null)
          ;
        _Label18 = value;
        if (_Label18 == null)
          ;
      }
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

  internal virtual TextBox tbVO_ID
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbVO_ID == null)
          ;
        _tbVO_ID = value;
        if (_tbVO_ID == null)
          ;
      }
    get => _tbVO_ID;
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
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label21 == null)
          ;
        _Label21 = value;
        if (_Label21 == null)
          ;
      }
    get => _Label21;
  }

  internal virtual TextBox tbEndConversation
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbEndConversation == null)
          ;
        _tbEndConversation = value;
        if (_tbEndConversation == null)
          ;
      }
    get => _tbEndConversation;
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

  internal virtual TextBox tbEndConverAbort
  {
    get => _tbEndConverAbort;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbEndConverAbort == null)
          ;
        _tbEndConverAbort = value;
        if (_tbEndConverAbort == null)
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

  internal virtual TextBox tbAmbientTrack
  {
    get => _tbAmbientTrack;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbAmbientTrack == null)
          ;
        _tbAmbientTrack = value;
        if (_tbAmbientTrack == null)
          ;
      }
  }

  internal virtual Label Label25
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label25 == null)
          ;
        _Label25 = value;
        if (_Label25 == null)
          ;
      }
    get => _Label25;
  }

  internal virtual CheckBox chkbSkippable
  {
    get => _chkbSkippable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbSkippable == null)
          ;
        _chkbSkippable = value;
        if (_chkbSkippable == null)
          ;
      }
  }

  internal virtual CheckBox chkbUnequipItems
  {
    get => _chkbUnequipItems;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbUnequipItems == null)
          ;
        _chkbUnequipItems = value;
        if (_chkbUnequipItems == null)
          ;
      }
  }

  internal virtual Label Label26
  {
    get => _Label26;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label26 == null)
          ;
        _Label26 = value;
        if (_Label26 == null)
          ;
      }
  }

  internal virtual NumericUpDown nudDelayEntry
  {
    get => _nudDelayEntry;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudDelayEntry == null)
          ;
        _nudDelayEntry = value;
        if (_nudDelayEntry == null)
          ;
      }
  }

  internal virtual NumericUpDown nudDelayReply
  {
    get => _nudDelayReply;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudDelayReply == null)
          ;
        _nudDelayReply = value;
        if (_nudDelayReply == null)
          ;
      }
  }

  internal virtual Label Label27
  {
    get => _Label27;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label27 == null)
          ;
        _Label27 = value;
        if (_Label27 == null)
          ;
      }
  }

  internal virtual CheckBox chkbUnequipHItem
  {
    get => _chkbUnequipHItem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbUnequipHItem == null)
          ;
        _chkbUnequipHItem = value;
        if (_chkbUnequipHItem == null)
          ;
      }
  }

  internal virtual TextBox tbSpeaker
  {
    get => _tbSpeaker;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbSpeaker == null)
          ;
        _tbSpeaker = value;
        if (_tbSpeaker == null)
          ;
      }
  }

  internal virtual Label Label28
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label28 == null)
          ;
        _Label28 = value;
        if (_Label28 == null)
          ;
      }
    get => _Label28;
  }

  internal virtual NumericUpDown nudCameraID
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudCameraID == null)
          ;
        _nudCameraID = value;
        if (_nudCameraID == null)
          ;
      }
    get => _nudCameraID;
  }

  internal virtual Label Label29
  {
    get => _Label29;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label29 == null)
          ;
        _Label29 = value;
        if (_Label29 == null)
          ;
      }
  }

  internal virtual TabPage tabpagActionsTaken
  {
    get => _tabpagActionsTaken;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagActionsTaken == null)
          ;
        _tabpagActionsTaken = value;
        if (_tabpagActionsTaken == null)
          ;
      }
  }

  internal virtual TabPage tabpagCamera
  {
    get => _tabpagCamera;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagCamera == null)
          ;
        _tabpagCamera = value;
        if (_tabpagCamera == null)
          ;
      }
  }

  internal virtual TabPage tabpagComment
  {
    get => _tabpagComment;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagComment == null)
          ;
        _tabpagComment = value;
        if (_tabpagComment == null)
          ;
      }
  }

  internal virtual TabPage tabpagPlot
  {
    get => _tabpagPlot;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagPlot == null)
          ;
        _tabpagPlot = value;
        if (_tabpagPlot == null)
          ;
      }
  }

  internal virtual TabControl TabControl1
  {
    get => _TabControl1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabControl1 == null)
          ;
        _TabControl1 = value;
        if (_TabControl1 == null)
          ;
      }
  }

  internal virtual TabPage tabpagAnimationSound
  {
    get => _tabpagAnimationSound;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagAnimationSound == null)
          ;
        _tabpagAnimationSound = value;
        if (_tabpagAnimationSound == null)
          ;
      }
  }

  internal virtual TabPage tabpagDebug
  {
    get => _tabpagDebug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagDebug == null)
          ;
        _tabpagDebug = value;
        if (_tabpagDebug == null)
          ;
      }
  }

  internal virtual Button btnSave
  {
    get => _btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSave != null)
          _btnSave.Click -= new EventHandler(Button1_Click);
        _btnSave = value;
        if (_btnSave == null)
          return;
        _btnSave.Click += new EventHandler(Button1_Click);
      }
  }

  internal virtual Button btnOpen
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnOpen != null)
          _btnOpen.Click -= new EventHandler(btnOpen_Click);
        _btnOpen = value;
        if (_btnOpen == null)
          return;
        _btnOpen.Click += new EventHandler(btnOpen_Click);
      }
    get => _btnOpen;
  }

  internal virtual MainMenu MainMenu1
  {
    get => _MainMenu1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_MainMenu1 == null)
          ;
        _MainMenu1 = value;
        if (_MainMenu1 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem1 == null)
          ;
        _ToolStripMenuItem1 = value;
        if (_ToolStripMenuItem1 == null)
          ;
      }
    get => _ToolStripMenuItem1;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem4
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem4 == null)
          ;
        _ToolStripMenuItem4 = value;
        if (_ToolStripMenuItem4 == null)
          ;
      }
    get => _ToolStripMenuItem4;
  }

  internal virtual ToolStripMenuItem miOpen
  {
    get => _miOpen;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miOpen != null)
          _miOpen.Click -= new EventHandler(miOpen_Click);
        _miOpen = value;
        if (_miOpen == null)
          return;
        _miOpen.Click += new EventHandler(miOpen_Click);
      }
  }

  internal virtual ToolStripMenuItem miSave
  {
    get => _miSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miSave != null)
          _miSave.Click -= new EventHandler(miSave_Click);
        _miSave = value;
        if (_miSave == null)
          return;
        _miSave.Click += new EventHandler(miSave_Click);
      }
  }

  internal virtual ToolStripMenuItem miQuit
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miQuit != null)
          _miQuit.Click -= new EventHandler(miQuit_Click);
        _miQuit = value;
        if (_miQuit == null)
          return;
        _miQuit.Click += new EventHandler(miQuit_Click);
      }
    get => _miQuit;
  }

  internal virtual TabPage tabpagThisFile1
  {
    get => _tabpagThisFile1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagThisFile1 == null)
          ;
        _tabpagThisFile1 = value;
        if (_tabpagThisFile1 == null)
          ;
      }
  }

  internal virtual TabPage tabpagThisFile2
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagThisFile2 == null)
          ;
        _tabpagThisFile2 = value;
        if (_tabpagThisFile2 == null)
          ;
      }
    get => _tabpagThisFile2;
  }

  internal virtual DataGrid dgStuntList
  {
    get => _dgStuntList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_dgStuntList == null)
          ;
        _dgStuntList = value;
        if (_dgStuntList == null)
          ;
      }
  }

  internal virtual Label Label30
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label30 == null)
          ;
        _Label30 = value;
        if (_Label30 == null)
          ;
      }
    get => _Label30;
  }

  internal virtual TextBox tbTextActiveScript
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTextActiveScript == null)
          ;
        _tbTextActiveScript = value;
        if (_tbTextActiveScript == null)
          ;
      }
    get => _tbTextActiveScript;
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

  internal virtual DataGrid dgAnimList
  {
    get => _dgAnimList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_dgAnimList != null)
        {
          _dgAnimList.Validated -= new EventHandler(dgAnimList_Validated);
          _dgAnimList.Click -= new EventHandler(dgAnimList_Click);
        }
        _dgAnimList = value;
        if (_dgAnimList == null)
          return;
        _dgAnimList.Validated += new EventHandler(dgAnimList_Validated);
        _dgAnimList.Click += new EventHandler(dgAnimList_Click);
      }
  }

  internal virtual Button btnDeleteAnimListEntry
  {
    get => _btnDeleteAnimListEntry;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnDeleteAnimListEntry != null)
          _btnDeleteAnimListEntry.Click -= new EventHandler(btnDeleteAnimListEntry_Click);
        _btnDeleteAnimListEntry = value;
        if (_btnDeleteAnimListEntry == null)
          return;
        _btnDeleteAnimListEntry.Click += new EventHandler(btnDeleteAnimListEntry_Click);
      }
  }

  internal virtual Button btnAddAnimListEntry
  {
    get => _btnAddAnimListEntry;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnAddAnimListEntry != null)
          _btnAddAnimListEntry.Click -= new EventHandler(btnAddAnimListEntry_Click);
        _btnAddAnimListEntry = value;
        if (_btnAddAnimListEntry == null)
          return;
        _btnAddAnimListEntry.Click += new EventHandler(btnAddAnimListEntry_Click);
      }
  }

  internal virtual TrackBar trkbTVIndent
  {
    get => _trkbTVIndent;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_trkbTVIndent != null)
          _trkbTVIndent.Scroll -= new EventHandler(trkbTVIndent_Scroll);
        _trkbTVIndent = value;
        if (_trkbTVIndent == null)
          return;
        _trkbTVIndent.Scroll += new EventHandler(trkbTVIndent_Scroll);
      }
  }

  internal virtual Label Label32
  {
    get => _Label32;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label32 == null)
          ;
        _Label32 = value;
        if (_Label32 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem miNew
  {
    get => _miNew;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miNew != null)
          _miNew.Click -= new EventHandler(miNew_Click);
        _miNew = value;
        if (_miNew == null)
          return;
        _miNew.Click += new EventHandler(miNew_Click);
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

  internal virtual Label Label33
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label33 == null)
          ;
        _Label33 = value;
        if (_Label33 == null)
          ;
      }
    get => _Label33;
  }

  internal virtual TrackBar trkbTVItemHeight
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_trkbTVItemHeight != null)
          _trkbTVItemHeight.Scroll -= new EventHandler(trkbTVItemHeight_Scroll);
        _trkbTVItemHeight = value;
        if (_trkbTVItemHeight == null)
          return;
        _trkbTVItemHeight.Scroll += new EventHandler(trkbTVItemHeight_Scroll);
      }
    get => _trkbTVItemHeight;
  }

  internal virtual ToolStripMenuItem cmiTV_PasteTree
  {
    get => _cmiTV_PasteTree;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiTV_PasteTree != null)
          _cmiTV_PasteTree.Click -= new EventHandler(cmiTV_PasteTree_Click);
        _cmiTV_PasteTree = value;
        if (_cmiTV_PasteTree == null)
          return;
        _cmiTV_PasteTree.Click += new EventHandler(cmiTV_PasteTree_Click);
      }
  }

  internal virtual TextBox tbLinkDesc
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbLinkDesc == null)
          ;
        _tbLinkDesc = value;
        if (_tbLinkDesc == null)
          ;
      }
    get => _tbLinkDesc;
  }

  internal virtual Label Label34
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label34 == null)
          ;
        _Label34 = value;
        if (_Label34 == null)
          ;
      }
    get => _Label34;
  }

  internal virtual ComboBox cmbxConversationType
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxConversationType != null)
          _cmbxConversationType.SelectedIndexChanged -= new EventHandler(cmbxConversationType_SelectedIndexChanged);
        _cmbxConversationType = value;
        if (_cmbxConversationType == null)
          return;
        _cmbxConversationType.SelectedIndexChanged += new EventHandler(cmbxConversationType_SelectedIndexChanged);
      }
    get => _cmbxConversationType;
  }

  internal virtual ComboBox cmbxComputerType
  {
    get => _cmbxComputerType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxComputerType == null)
          ;
        _cmbxComputerType = value;
        if (_cmbxComputerType == null)
          ;
      }
  }

  internal virtual TextBox tbQuest
  {
    get => _tbQuest;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbQuest == null)
          ;
        _tbQuest = value;
        if (_tbQuest == null)
          ;
      }
  }

  internal virtual Label Label35
  {
    get => _Label35;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label35 == null)
          ;
        _Label35 = value;
        if (_Label35 == null)
          ;
      }
  }

  internal virtual Label Label36
  {
    get => _Label36;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label36 == null)
          ;
        _Label36 = value;
        if (_Label36 == null)
          ;
      }
  }

  internal virtual NumericUpDown nudQuestEntry
  {
    get => _nudQuestEntry;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudQuestEntry == null)
          ;
        _nudQuestEntry = value;
        if (_nudQuestEntry == null)
          ;
      }
  }

  internal virtual Button btnShowLists
  {
    get => _btnShowLists;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnShowLists != null)
          _btnShowLists.Click -= new EventHandler(btnShowLists_Click);
        _btnShowLists = value;
        if (_btnShowLists == null)
          return;
        _btnShowLists.Click += new EventHandler(btnShowLists_Click);
      }
  }

  internal virtual ComboBox cmbxFadeType
  {
    get => _cmbxFadeType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxFadeType == null)
          ;
        _cmbxFadeType = value;
        if (_cmbxFadeType == null)
          ;
      }
  }

  internal virtual NumericUpDown nudFadeColorR
  {
    get => _nudFadeColorR;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudFadeColorR == null)
          ;
        _nudFadeColorR = value;
        if (_nudFadeColorR == null)
          ;
      }
  }

  internal virtual ComboBox cmbxCamVidEffect
  {
    get => _cmbxCamVidEffect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxCamVidEffect == null)
          ;
        _cmbxCamVidEffect = value;
        if (_cmbxCamVidEffect == null)
          ;
      }
  }

  internal virtual CheckBox chkbAnimatedCut
  {
    get => _chkbAnimatedCut;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbAnimatedCut != null)
          _chkbAnimatedCut.CheckedChanged -= new EventHandler(chkbAnimatedCut_CheckedChanged);
        _chkbAnimatedCut = value;
        if (_chkbAnimatedCut == null)
          return;
        _chkbAnimatedCut.CheckedChanged += new EventHandler(chkbAnimatedCut_CheckedChanged);
      }
  }

  internal virtual TextBox tbCameraModel
  {
    get => _tbCameraModel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCameraModel == null)
          ;
        _tbCameraModel = value;
        if (_tbCameraModel == null)
          ;
      }
  }

  internal virtual Label Label31
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label31 == null)
          ;
        _Label31 = value;
        if (_Label31 == null)
          ;
      }
    get => _Label31;
  }

  internal virtual Label Label37
  {
    get => _Label37;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label37 == null)
          ;
        _Label37 = value;
        if (_Label37 == null)
          ;
      }
  }

  internal virtual NumericUpDown nudCamFieldOfView
  {
    get => _nudCamFieldOfView;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudCamFieldOfView == null)
          ;
        _nudCamFieldOfView = value;
        if (_nudCamFieldOfView == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem2
  {
    get => _ToolStripMenuItem2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem2 == null)
          ;
        _ToolStripMenuItem2 = value;
        if (_ToolStripMenuItem2 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem cmiTV_MoveNodeUp
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiTV_MoveNodeUp != null)
          _cmiTV_MoveNodeUp.Click -= new EventHandler(cmiTV_MoveNodeUp_Click);
        _cmiTV_MoveNodeUp = value;
        if (_cmiTV_MoveNodeUp == null)
          return;
        _cmiTV_MoveNodeUp.Click += new EventHandler(cmiTV_MoveNodeUp_Click);
      }
    get => _cmiTV_MoveNodeUp;
  }

  internal virtual ToolStripMenuItem cmiTV_MoveNodeDown
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiTV_MoveNodeDown != null)
          _cmiTV_MoveNodeDown.Click -= new EventHandler(cmiTV_MoveNodeDown_Click);
        _cmiTV_MoveNodeDown = value;
        if (_cmiTV_MoveNodeDown == null)
          return;
        _cmiTV_MoveNodeDown.Click += new EventHandler(cmiTV_MoveNodeDown_Click);
      }
    get => _cmiTV_MoveNodeDown;
  }

  internal virtual TabPage tabpagThisFile3
  {
    get => _tabpagThisFile3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagThisFile3 == null)
          ;
        _tabpagThisFile3 = value;
        if (_tabpagThisFile3 == null)
          ;
      }
  }

  internal virtual TextBox tbTextActiveScript2
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTextActiveScript2 == null)
          ;
        _tbTextActiveScript2 = value;
        if (_tbTextActiveScript2 == null)
          ;
      }
    get => _tbTextActiveScript2;
  }

  internal virtual Label Label38
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label38 == null)
          ;
        _Label38 = value;
        if (_Label38 == null)
          ;
      }
    get => _Label38;
  }

  internal virtual TextBox tbActionsTakenScript2
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbActionsTakenScript2 == null)
          ;
        _tbActionsTakenScript2 = value;
        if (_tbActionsTakenScript2 == null)
          ;
      }
    get => _tbActionsTakenScript2;
  }

  internal virtual Label Label39
  {
    get => _Label39;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label39 == null)
          ;
        _Label39 = value;
        if (_Label39 == null)
          ;
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      components = new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (frmDialogEditor));
      tvConversation = new TreeView();
      tbConversationText = new TextBox();
      Label1 = new Label();
      Label2 = new Label();
      TabControl1 = new TabControl();
      tabpagActionsTaken = new TabPage();
      tbTextActiveScript = new TextBox();
      Label3 = new Label();
      tbActionsTakenScript = new TextBox();
      Label4 = new Label();
      tbTextActiveScript2 = new TextBox();
      Label38 = new Label();
      tbActionsTakenScript2 = new TextBox();
      Label39 = new Label();
      tabpagCamera = new TabPage();
      nudCamFieldOfView = new NumericUpDown();
      cmbxCamVidEffect = new ComboBox();
      nudFadeColorG = new NumericUpDown();
      nudFadeColorB = new NumericUpDown();
      nudFadeColorR = new NumericUpDown();
      cmbxFadeType = new ComboBox();
      nudCameraID = new NumericUpDown();
      nudCamHeightOffset = new NumericUpDown();
      nudCameraAngle = new NumericUpDown();
      Label7 = new Label();
      Label8 = new Label();
      tbListener = new TextBox();
      Label9 = new Label();
      Label11 = new Label();
      Label13 = new Label();
      Label14 = new Label();
      Label15 = new Label();
      Label16 = new Label();
      btnChooseColor = new Button();
      nudTarHeightOffset = new NumericUpDown();
      nudFadeDelay = new NumericUpDown();
      nudFadeLength = new NumericUpDown();
      Label28 = new Label();
      Label29 = new Label();
      Label37 = new Label();
      tabpagAnimationSound = new TabPage();
      dgAnimList = new DataGrid();
      Label5 = new Label();
      tbSound = new TextBox();
      Label6 = new Label();
      tbVoiceOverResRef = new TextBox();
      Label10 = new Label();
      btnDeleteAnimListEntry = new Button();
      btnAddAnimListEntry = new Button();
      tabpagPlot = new TabPage();
      tbQuest = new TextBox();
      Label35 = new Label();
      nudPlotIndex = new NumericUpDown();
      lblPlotIndex = new Label();
      Label12 = new Label();
      nudPlotXPPercentage = new NumericUpDown();
      Label36 = new Label();
      nudQuestEntry = new NumericUpDown();
      tabpagComment = new TabPage();
      tbComments = new TextBox();
      tabpagThisFile1 = new TabPage();
      chkbAnimatedCut = new CheckBox();
      tbCameraModel = new TextBox();
      Label31 = new Label();
      cmbxConversationType = new ComboBox();
      chkbSkippable = new CheckBox();
      tbVO_ID = new TextBox();
      Label20 = new Label();
      Label21 = new Label();
      tbEndConversation = new TextBox();
      Label22 = new Label();
      Label23 = new Label();
      tbEndConverAbort = new TextBox();
      Label24 = new Label();
      tbAmbientTrack = new TextBox();
      Label25 = new Label();
      chkbUnequipItems = new CheckBox();
      chkbUnequipHItem = new CheckBox();
      Label26 = new Label();
      nudDelayEntry = new NumericUpDown();
      nudDelayReply = new NumericUpDown();
      Label27 = new Label();
      cmbxComputerType = new ComboBox();
      tabpagThisFile2 = new TabPage();
      dgStuntList = new DataGrid();
      Label30 = new Label();
      tabpagThisFile3 = new TabPage();
      tabpagDebug = new TabPage();
      trkbTVIndent = new TrackBar();
      Label17 = new Label();
      tbLinkID = new TextBox();
      tbLinkedCnt = new TextBox();
      tbSharedCnt = new TextBox();
      Label18 = new Label();
      Label19 = new Label();
      btnDebug = new Button();
      Label32 = new Label();
      Label33 = new Label();
      trkbTVItemHeight = new TrackBar();
      tbLinkDesc = new TextBox();
      Label34 = new Label();
      btnShowLists = new Button();
      btnCollapseAll = new Button();
      btnExpandAll = new Button();
      btnSave = new Button();
      btnTest = new Button();
      cmTVfunctions = new ContextMenu();
      cmiTV_Add = new ToolStripMenuItem();
      cmiTV_Cut = new ToolStripMenuItem();
      cmiTV_Copy = new ToolStripMenuItem();
      cmiTV_Paste = new ToolStripMenuItem();
      cmiTV_PasteTree = new ToolStripMenuItem();
      cmiTV_PasteAsLink = new ToolStripMenuItem();
      ToolStripMenuItem2 = new ToolStripMenuItem();
      cmiTV_MoveNodeUp = new ToolStripMenuItem();
      cmiTV_MoveNodeDown = new ToolStripMenuItem();
      tbSpeaker = new TextBox();
      btnOpen = new Button();
      MainMenu1 = new MainMenu();
      ToolStripMenuItem1 = new ToolStripMenuItem();
      miNew = new ToolStripMenuItem();
      miOpen = new ToolStripMenuItem();
      miSave = new ToolStripMenuItem();
      ToolStripMenuItem4 = new ToolStripMenuItem();
      miQuit = new ToolStripMenuItem();
      ToolTip1 = new ToolTip(components);
      TabControl1.SuspendLayout();
      tabpagActionsTaken.SuspendLayout();
      tabpagCamera.SuspendLayout();
      nudCamFieldOfView.BeginInit();
      nudFadeColorG.BeginInit();
      nudFadeColorB.BeginInit();
      nudFadeColorR.BeginInit();
      nudCameraID.BeginInit();
      nudCamHeightOffset.BeginInit();
      nudCameraAngle.BeginInit();
      nudTarHeightOffset.BeginInit();
      nudFadeDelay.BeginInit();
      nudFadeLength.BeginInit();
      tabpagAnimationSound.SuspendLayout();
      dgAnimList.BeginInit();
      tabpagPlot.SuspendLayout();
      nudPlotIndex.BeginInit();
      nudPlotXPPercentage.BeginInit();
      nudQuestEntry.BeginInit();
      tabpagComment.SuspendLayout();
      tabpagThisFile1.SuspendLayout();
      nudDelayEntry.BeginInit();
      nudDelayReply.BeginInit();
      tabpagThisFile2.SuspendLayout();
      dgStuntList.BeginInit();
      tabpagDebug.SuspendLayout();
      trkbTVIndent.BeginInit();
      trkbTVItemHeight.BeginInit();
      SuspendLayout();
      tvConversation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      tvConversation.HideSelection = false;
      tvConversation.ImageIndex = -1;
      tvConversation.Indent = 16;
      tvConversation.ItemHeight = 16;
      TreeView tvConversation1 = tvConversation;
      Point point1 = new Point(32, 8);
      Point point2 = point1;
      tvConversation1.Location = point2;
      tvConversation.Name = "tvConversation";
      tvConversation.SelectedImageIndex = -1;
      TreeView tvConversation2 = tvConversation;
      Size size1 = new Size(736, 272);
      Size size2 = size1;
      tvConversation2.Size = size2;
      tvConversation.TabIndex = 0;
      tbConversationText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      TextBox conversationText1 = tbConversationText;
      point1 = new Point(32, 400);
      Point point3 = point1;
      conversationText1.Location = point3;
      tbConversationText.Multiline = true;
      tbConversationText.Name = "tbConversationText";
      tbConversationText.ScrollBars = ScrollBars.Vertical;
      TextBox conversationText2 = tbConversationText;
      size1 = new Size(240, 104);
      Size size3 = size1;
      conversationText2.Size = size3;
      tbConversationText.TabIndex = 4;
      tbConversationText.Text = "";
      Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Label label1_1 = Label1;
      point1 = new Point(32, 336);
      Point point4 = point1;
      label1_1.Location = point4;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(100, 16);
      Size size4 = size1;
      label1_2.Size = size4;
      Label1.TabIndex = 3;
      Label1.Text = "Speaker Tag";
      Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Label label2_1 = Label2;
      point1 = new Point(32, 384);
      Point point5 = point1;
      label2_1.Location = point5;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(100, 16);
      Size size5 = size1;
      label2_2.Size = size5;
      Label2.TabIndex = 3;
      Label2.Text = "Text";
      TabControl1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TabControl1.Controls.Add(tabpagActionsTaken);
      TabControl1.Controls.Add(tabpagCamera);
      TabControl1.Controls.Add(tabpagAnimationSound);
      TabControl1.Controls.Add(tabpagPlot);
      TabControl1.Controls.Add(tabpagComment);
      TabControl1.Controls.Add(tabpagThisFile1);
      TabControl1.Controls.Add(tabpagThisFile2);
      TabControl1.Controls.Add(tabpagThisFile3);
      TabControl1.Controls.Add(tabpagDebug);
      TabControl tabControl1_1 = TabControl1;
      point1 = new Point(280, 296);
      Point point6 = point1;
      tabControl1_1.Location = point6;
      TabControl1.Multiline = true;
      TabControl1.Name = "TabControl1";
      TabControl tabControl1_2 = TabControl1;
      point1 = new Point(8, 3);
      Point point7 = point1;
      tabControl1_2.Padding = point7;
      TabControl1.SelectedIndex = 0;
      TabControl tabControl1_3 = TabControl1;
      size1 = new Size(488, 216);
      Size size6 = size1;
      tabControl1_3.Size = size6;
      TabControl1.SizeMode = TabSizeMode.FillToRight;
      TabControl1.TabIndex = 5;
      tabpagActionsTaken.Controls.Add(tbTextActiveScript);
      tabpagActionsTaken.Controls.Add(Label3);
      tabpagActionsTaken.Controls.Add(tbActionsTakenScript);
      tabpagActionsTaken.Controls.Add(Label4);
      tabpagActionsTaken.Controls.Add(tbTextActiveScript2);
      tabpagActionsTaken.Controls.Add(Label38);
      tabpagActionsTaken.Controls.Add(tbActionsTakenScript2);
      tabpagActionsTaken.Controls.Add(Label39);
      TabPage tabpagActionsTaken1 = tabpagActionsTaken;
      point1 = new Point(4, 40);
      Point point8 = point1;
      ((Control) tabpagActionsTaken1).Location = point8;
      tabpagActionsTaken.Name = "tabpagActionsTaken";
      TabPage tabpagActionsTaken2 = tabpagActionsTaken;
      size1 = new Size(480, 172);
      Size size7 = size1;
      tabpagActionsTaken2.Size = size7;
      tabpagActionsTaken.TabIndex = 0;
      tabpagActionsTaken.Text = "Node Scripts";
      tbTextActiveScript.CharacterCasing = CharacterCasing.Lower;
      TextBox textActiveScript1 = tbTextActiveScript;
      point1 = new Point(32, 88);
      Point point9 = point1;
      textActiveScript1.Location = point9;
      tbTextActiveScript.MaxLength = 16;
      tbTextActiveScript.Name = "tbTextActiveScript";
      TextBox textActiveScript2 = tbTextActiveScript;
      size1 = new Size(120, 20);
      Size size8 = size1;
      textActiveScript2.Size = size8;
      tbTextActiveScript.TabIndex = 6;
      tbTextActiveScript.Text = "";
      Label label3_1 = Label3;
      point1 = new Point(32, 72);
      Point point10 = point1;
      label3_1.Location = point10;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(216, 24);
      Size size9 = size1;
      label3_2.Size = size9;
      Label3.TabIndex = 7;
      Label3.Text = "Script that determines if node is available";
      tbActionsTakenScript.CharacterCasing = CharacterCasing.Lower;
      TextBox actionsTakenScript1 = tbActionsTakenScript;
      point1 = new Point(32, 32);
      Point point11 = point1;
      actionsTakenScript1.Location = point11;
      tbActionsTakenScript.MaxLength = 16;
      tbActionsTakenScript.Name = "tbActionsTakenScript";
      TextBox actionsTakenScript2 = tbActionsTakenScript;
      size1 = new Size(120, 20);
      Size size10 = size1;
      actionsTakenScript2.Size = size10;
      tbActionsTakenScript.TabIndex = 4;
      tbActionsTakenScript.Text = "";
      Label label4_1 = Label4;
      point1 = new Point(32, 16);
      Point point12 = point1;
      label4_1.Location = point12;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(136, 16);
      Size size11 = size1;
      label4_2.Size = size11;
      Label4.TabIndex = 5;
      Label4.Text = "Script to run for this node";
      tbTextActiveScript2.CharacterCasing = CharacterCasing.Lower;
      TextBox textActiveScript2_1 = tbTextActiveScript2;
      point1 = new Point(252, 88);
      Point point13 = point1;
      textActiveScript2_1.Location = point13;
      tbTextActiveScript2.MaxLength = 16;
      tbTextActiveScript2.Name = "tbTextActiveScript2";
      TextBox textActiveScript2_2 = tbTextActiveScript2;
      size1 = new Size(128, 20);
      Size size12 = size1;
      textActiveScript2_2.Size = size12;
      tbTextActiveScript2.TabIndex = 6;
      tbTextActiveScript2.Text = "";
      tbTextActiveScript2.Visible = false;
      Label label38_1 = Label38;
      point1 = new Point(252, 72);
      Point point14 = point1;
      label38_1.Location = point14;
      Label38.Name = "Label38";
      Label label38_2 = Label38;
      size1 = new Size(232, 24);
      Size size13 = size1;
      label38_2.Size = size13;
      Label38.TabIndex = 7;
      Label38.Text = "Script #2 that determines if node is available";
      Label38.Visible = false;
      tbActionsTakenScript2.CharacterCasing = CharacterCasing.Lower;
      TextBox actionsTakenScript2_1 = tbActionsTakenScript2;
      point1 = new Point(252, 32);
      Point point15 = point1;
      actionsTakenScript2_1.Location = point15;
      tbActionsTakenScript2.MaxLength = 16;
      tbActionsTakenScript2.Name = "tbActionsTakenScript2";
      TextBox actionsTakenScript2_2 = tbActionsTakenScript2;
      size1 = new Size(128, 20);
      Size size14 = size1;
      actionsTakenScript2_2.Size = size14;
      tbActionsTakenScript2.TabIndex = 4;
      tbActionsTakenScript2.Text = "";
      tbActionsTakenScript2.Visible = false;
      Label label39_1 = Label39;
      point1 = new Point(252, 16);
      Point point16 = point1;
      label39_1.Location = point16;
      Label39.Name = "Label39";
      Label label39_2 = Label39;
      size1 = new Size(144, 16);
      Size size15 = size1;
      label39_2.Size = size15;
      Label39.TabIndex = 5;
      Label39.Text = "Script #2 to run for this node";
      Label39.Visible = false;
      tabpagCamera.Controls.Add(nudCamFieldOfView);
      tabpagCamera.Controls.Add(cmbxCamVidEffect);
      tabpagCamera.Controls.Add(nudFadeColorG);
      tabpagCamera.Controls.Add(nudFadeColorB);
      tabpagCamera.Controls.Add(nudFadeColorR);
      tabpagCamera.Controls.Add(cmbxFadeType);
      tabpagCamera.Controls.Add(nudCameraID);
      tabpagCamera.Controls.Add(nudCamHeightOffset);
      tabpagCamera.Controls.Add(nudCameraAngle);
      tabpagCamera.Controls.Add(Label7);
      tabpagCamera.Controls.Add(Label8);
      tabpagCamera.Controls.Add(tbListener);
      tabpagCamera.Controls.Add(Label9);
      tabpagCamera.Controls.Add(Label11);
      tabpagCamera.Controls.Add(Label13);
      tabpagCamera.Controls.Add(Label14);
      tabpagCamera.Controls.Add(Label15);
      tabpagCamera.Controls.Add(Label16);
      tabpagCamera.Controls.Add(btnChooseColor);
      tabpagCamera.Controls.Add(nudTarHeightOffset);
      tabpagCamera.Controls.Add(nudFadeDelay);
      tabpagCamera.Controls.Add(nudFadeLength);
      tabpagCamera.Controls.Add(Label28);
      tabpagCamera.Controls.Add(Label29);
      tabpagCamera.Controls.Add(Label37);
      TabPage tabpagCamera1 = tabpagCamera;
      point1 = new Point(4, 40);
      Point point17 = point1;
      ((Control) tabpagCamera1).Location = point17;
      tabpagCamera.Name = "tabpagCamera";
      TabPage tabpagCamera2 = tabpagCamera;
      size1 = new Size(480, 172);
      Size size16 = size1;
      tabpagCamera2.Size = size16;
      tabpagCamera.TabIndex = 5;
      tabpagCamera.Text = "Camera";
      nudCamFieldOfView.DecimalPlaces = 2;
      nudCamFieldOfView.Enabled = false;
      NumericUpDown nudCamFieldOfView1 = nudCamFieldOfView;
      point1 = new Point(296, 80);
      Point point18 = point1;
      nudCamFieldOfView1.Location = point18;
      NumericUpDown nudCamFieldOfView2 = nudCamFieldOfView;
      Decimal num1 = new Decimal(new int[4]
      {
        35999,
        0,
        0,
        131072
      });
      Decimal num2 = num1;
      nudCamFieldOfView2.Maximum = num2;
      nudCamFieldOfView.Name = "nudCamFieldOfView";
      NumericUpDown nudCamFieldOfView3 = nudCamFieldOfView;
      size1 = new Size(56, 20);
      Size size17 = size1;
      nudCamFieldOfView3.Size = size17;
      nudCamFieldOfView.TabIndex = 8;
      nudCamFieldOfView.TextAlign = HorizontalAlignment.Right;
      ToolTip1.SetToolTip(nudCamFieldOfView, "This is the angle in degrees that the camera sees");
      NumericUpDown nudCamFieldOfView4 = nudCamFieldOfView;
      num1 = new Decimal(new int[4]{ 35999, 0, 0, 131072 });
      Decimal num3 = num1;
      nudCamFieldOfView4.Value = num3;
      cmbxCamVidEffect.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxCamVidEffect.Items.AddRange(new object[3]
      {
        "(none)",
        "Blue Filter",
        "Red Filter"
      });
      ComboBox cmbxCamVidEffect1 = cmbxCamVidEffect;
      point1 = new Point(256, 48);
      Point point19 = point1;
      cmbxCamVidEffect1.Location = point19;
      cmbxCamVidEffect.Name = "cmbxCamVidEffect";
      ComboBox cmbxCamVidEffect2 = cmbxCamVidEffect;
      size1 = new Size(96, 21);
      Size size18 = size1;
      cmbxCamVidEffect2.Size = size18;
      cmbxCamVidEffect.TabIndex = 12;
      ToolTip1.SetToolTip(cmbxCamVidEffect, "Selecting one of the two colors will make the conversation look like it was viewed through a filter of that color");
      nudFadeColorG.Enabled = false;
      NumericUpDown nudFadeColorG1 = nudFadeColorG;
      point1 = new Point(368, 112);
      Point point20 = point1;
      nudFadeColorG1.Location = point20;
      NumericUpDown nudFadeColorG2 = nudFadeColorG;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num4 = num1;
      nudFadeColorG2.Maximum = num4;
      nudFadeColorG.Name = "nudFadeColorG";
      NumericUpDown nudFadeColorG3 = nudFadeColorG;
      size1 = new Size(48, 20);
      Size size19 = size1;
      nudFadeColorG3.Size = size19;
      nudFadeColorG.TabIndex = 8;
      nudFadeColorG.TextAlign = HorizontalAlignment.Right;
      nudFadeColorB.Enabled = false;
      NumericUpDown nudFadeColorB1 = nudFadeColorB;
      point1 = new Point(424, 112);
      Point point21 = point1;
      nudFadeColorB1.Location = point21;
      NumericUpDown nudFadeColorB2 = nudFadeColorB;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num5 = num1;
      nudFadeColorB2.Maximum = num5;
      nudFadeColorB.Name = "nudFadeColorB";
      NumericUpDown nudFadeColorB3 = nudFadeColorB;
      size1 = new Size(48, 20);
      Size size20 = size1;
      nudFadeColorB3.Size = size20;
      nudFadeColorB.TabIndex = 9;
      nudFadeColorB.TextAlign = HorizontalAlignment.Right;
      nudFadeColorR.Enabled = false;
      NumericUpDown nudFadeColorR1 = nudFadeColorR;
      point1 = new Point(312, 112);
      Point point22 = point1;
      nudFadeColorR1.Location = point22;
      NumericUpDown nudFadeColorR2 = nudFadeColorR;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num6 = num1;
      nudFadeColorR2.Maximum = num6;
      nudFadeColorR.Name = "nudFadeColorR";
      NumericUpDown nudFadeColorR3 = nudFadeColorR;
      size1 = new Size(48, 20);
      Size size21 = size1;
      nudFadeColorR3.Size = size21;
      nudFadeColorR.TabIndex = 8;
      nudFadeColorR.TextAlign = HorizontalAlignment.Right;
      cmbxFadeType.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxFadeType.Items.AddRange(new object[5]
      {
        "(none)",
        "Cut to Black",
        "Cut to Scene",
        "Fade to Scene",
        "Fade to Fade Color"
      });
      ComboBox cmbxFadeType1 = cmbxFadeType;
      point1 = new Point(384, 16);
      Point point23 = point1;
      cmbxFadeType1.Location = point23;
      cmbxFadeType.Name = "cmbxFadeType";
      ComboBox cmbxFadeType2 = cmbxFadeType;
      size1 = new Size(96, 21);
      Size size22 = size1;
      cmbxFadeType2.Size = size22;
      cmbxFadeType.TabIndex = 12;
      NumericUpDown nudCameraId1 = nudCameraID;
      point1 = new Point(264, 16);
      Point point24 = point1;
      nudCameraId1.Location = point24;
      NumericUpDown nudCameraId2 = nudCameraID;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num7 = num1;
      nudCameraId2.Maximum = num7;
      nudCameraID.Name = "nudCameraID";
      NumericUpDown nudCameraId3 = nudCameraID;
      size1 = new Size(40, 20);
      Size size23 = size1;
      nudCameraId3.Size = size23;
      nudCameraID.TabIndex = 11;
      nudCameraID.TextAlign = HorizontalAlignment.Right;
      ToolTip1.SetToolTip(nudCameraID, "The Camera ID indicates which Camera in a module shoould the Conversation be viewed from. It should be in the same room and the conversants.");
      nudCamHeightOffset.DecimalPlaces = 2;
      NumericUpDown nudCamHeightOffset1 = nudCamHeightOffset;
      num1 = new Decimal(new int[4]{ 5, 0, 0, 131072 });
      Decimal num8 = num1;
      nudCamHeightOffset1.Increment = num8;
      NumericUpDown nudCamHeightOffset2 = nudCamHeightOffset;
      point1 = new Point(120, 48);
      Point point25 = point1;
      nudCamHeightOffset2.Location = point25;
      NumericUpDown nudCamHeightOffset3 = nudCamHeightOffset;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num9 = num1;
      nudCamHeightOffset3.Maximum = num9;
      nudCamHeightOffset.Name = "nudCamHeightOffset";
      nudCamHeightOffset.ReadOnly = true;
      NumericUpDown nudCamHeightOffset4 = nudCamHeightOffset;
      size1 = new Size(56, 20);
      Size size24 = size1;
      nudCamHeightOffset4.Size = size24;
      nudCamHeightOffset.TabIndex = 11;
      nudCamHeightOffset.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudCameraAngle1 = nudCameraAngle;
      point1 = new Point(120, 16);
      Point point26 = point1;
      nudCameraAngle1.Location = point26;
      NumericUpDown nudCameraAngle2 = nudCameraAngle;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num10 = num1;
      nudCameraAngle2.Maximum = num10;
      nudCameraAngle.Name = "nudCameraAngle";
      NumericUpDown nudCameraAngle3 = nudCameraAngle;
      size1 = new Size(40, 20);
      Size size25 = size1;
      nudCameraAngle3.Size = size25;
      nudCameraAngle.TabIndex = 11;
      nudCameraAngle.TextAlign = HorizontalAlignment.Right;
      Label label7_1 = Label7;
      point1 = new Point(8, 16);
      Point point27 = point1;
      label7_1.Location = point27;
      Label7.Name = "Label7";
      Label label7_2 = Label7;
      size1 = new Size(100, 16);
      Size size26 = size1;
      label7_2.Size = size26;
      Label7.TabIndex = 5;
      Label7.Text = "Camera Angle";
      Label label8_1 = Label8;
      point1 = new Point(320, 16);
      Point point28 = point1;
      label8_1.Location = point28;
      Label8.Name = "Label8";
      Label label8_2 = Label8;
      size1 = new Size(64, 16);
      Size size27 = size1;
      label8_2.Size = size27;
      Label8.TabIndex = 5;
      Label8.Text = "Fade Type";
      TextBox tbListener1 = tbListener;
      point1 = new Point(88, 112);
      Point point29 = point1;
      tbListener1.Location = point29;
      tbListener.Name = "tbListener";
      TextBox tbListener2 = tbListener;
      size1 = new Size(136, 20);
      Size size28 = size1;
      tbListener2.Size = size28;
      tbListener.TabIndex = 3;
      tbListener.Text = "";
      Label label9_1 = Label9;
      point1 = new Point(8, 112);
      Point point30 = point1;
      label9_1.Location = point30;
      Label9.Name = "Label9";
      Label label9_2 = Label9;
      size1 = new Size(48, 16);
      Size size29 = size1;
      label9_2.Size = size29;
      Label9.TabIndex = 5;
      Label9.Text = "Listener";
      Label label11_1 = Label11;
      point1 = new Point(360, 48);
      Point point31 = point1;
      label11_1.Location = point31;
      Label11.Name = "Label11";
      Label label11_2 = Label11;
      size1 = new Size(64, 16);
      Size size30 = size1;
      label11_2.Size = size30;
      Label11.TabIndex = 5;
      Label11.Text = "Fade Delay";
      Label label13_1 = Label13;
      point1 = new Point(8, 48);
      Point point32 = point1;
      label13_1.Location = point32;
      Label13.Name = "Label13";
      Label label13_2 = Label13;
      size1 = new Size(120, 16);
      Size size31 = size1;
      label13_2.Size = size31;
      Label13.TabIndex = 5;
      Label13.Text = "Camera Height Offset";
      Label label14_1 = Label14;
      point1 = new Point(360, 80);
      Point point33 = point1;
      label14_1.Location = point33;
      Label14.Name = "Label14";
      Label label14_2 = Label14;
      size1 = new Size(72, 16);
      Size size32 = size1;
      label14_2.Size = size32;
      Label14.TabIndex = 5;
      Label14.Text = "Fade Length";
      Label label15_1 = Label15;
      point1 = new Point(248, 112);
      Point point34 = point1;
      label15_1.Location = point34;
      Label15.Name = "Label15";
      Label label15_2 = Label15;
      size1 = new Size(72, 16);
      Size size33 = size1;
      label15_2.Size = size33;
      Label15.TabIndex = 5;
      Label15.Text = "Fade Color";
      Label label16_1 = Label16;
      point1 = new Point(8, 80);
      Point point35 = point1;
      label16_1.Location = point35;
      Label16.Name = "Label16";
      Label label16_2 = Label16;
      size1 = new Size(96, 16);
      Size size34 = size1;
      label16_2.Size = size34;
      Label16.TabIndex = 5;
      Label16.Text = "Tar Height Offset";
      Button btnChooseColor1 = btnChooseColor;
      point1 = new Point(448, 144);
      Point point36 = point1;
      btnChooseColor1.Location = point36;
      btnChooseColor.Name = "btnChooseColor";
      Button btnChooseColor2 = btnChooseColor;
      size1 = new Size(24, 23);
      Size size35 = size1;
      btnChooseColor2.Size = size35;
      btnChooseColor.TabIndex = 10;
      btnChooseColor.Text = "...";
      btnChooseColor.Visible = false;
      nudTarHeightOffset.DecimalPlaces = 2;
      NumericUpDown nudTarHeightOffset1 = nudTarHeightOffset;
      num1 = new Decimal(new int[4]{ 5, 0, 0, 131072 });
      Decimal num11 = num1;
      nudTarHeightOffset1.Increment = num11;
      NumericUpDown nudTarHeightOffset2 = nudTarHeightOffset;
      point1 = new Point(120, 80);
      Point point37 = point1;
      nudTarHeightOffset2.Location = point37;
      NumericUpDown nudTarHeightOffset3 = nudTarHeightOffset;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num12 = num1;
      nudTarHeightOffset3.Maximum = num12;
      nudTarHeightOffset.Name = "nudTarHeightOffset";
      nudTarHeightOffset.ReadOnly = true;
      NumericUpDown nudTarHeightOffset4 = nudTarHeightOffset;
      size1 = new Size(56, 20);
      Size size36 = size1;
      nudTarHeightOffset4.Size = size36;
      nudTarHeightOffset.TabIndex = 11;
      nudTarHeightOffset.TextAlign = HorizontalAlignment.Right;
      nudFadeDelay.DecimalPlaces = 2;
      nudFadeDelay.Enabled = false;
      NumericUpDown nudFadeDelay1 = nudFadeDelay;
      num1 = new Decimal(new int[4]{ 5, 0, 0, 131072 });
      Decimal num13 = num1;
      nudFadeDelay1.Increment = num13;
      NumericUpDown nudFadeDelay2 = nudFadeDelay;
      point1 = new Point(432, 48);
      Point point38 = point1;
      nudFadeDelay2.Location = point38;
      NumericUpDown nudFadeDelay3 = nudFadeDelay;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num14 = num1;
      nudFadeDelay3.Maximum = num14;
      nudFadeDelay.Name = "nudFadeDelay";
      NumericUpDown nudFadeDelay4 = nudFadeDelay;
      size1 = new Size(48, 20);
      Size size37 = size1;
      nudFadeDelay4.Size = size37;
      nudFadeDelay.TabIndex = 11;
      nudFadeDelay.TextAlign = HorizontalAlignment.Right;
      nudFadeLength.DecimalPlaces = 2;
      nudFadeLength.Enabled = false;
      NumericUpDown nudFadeLength1 = nudFadeLength;
      num1 = new Decimal(new int[4]{ 5, 0, 0, 131072 });
      Decimal num15 = num1;
      nudFadeLength1.Increment = num15;
      NumericUpDown nudFadeLength2 = nudFadeLength;
      point1 = new Point(432, 80);
      Point point39 = point1;
      nudFadeLength2.Location = point39;
      NumericUpDown nudFadeLength3 = nudFadeLength;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num16 = num1;
      nudFadeLength3.Maximum = num16;
      nudFadeLength.Name = "nudFadeLength";
      NumericUpDown nudFadeLength4 = nudFadeLength;
      size1 = new Size(48, 20);
      Size size38 = size1;
      nudFadeLength4.Size = size38;
      nudFadeLength.TabIndex = 11;
      nudFadeLength.TextAlign = HorizontalAlignment.Right;
      Label label28_1 = Label28;
      point1 = new Point(192, 16);
      Point point40 = point1;
      label28_1.Location = point40;
      Label28.Name = "Label28";
      Label label28_2 = Label28;
      size1 = new Size(80, 16);
      Size size39 = size1;
      label28_2.Size = size39;
      Label28.TabIndex = 5;
      Label28.Text = "Camera ID";
      Label label29_1 = Label29;
      point1 = new Point(192, 46);
      Point point41 = point1;
      label29_1.Location = point41;
      Label29.Name = "Label29";
      Label label29_2 = Label29;
      size1 = new Size(80, 32);
      Size size40 = size1;
      label29_2.Size = size40;
      Label29.TabIndex = 5;
      Label29.Text = "Camera Vid Effect";
      Label label37_1 = Label37;
      point1 = new Point(192, 81);
      Point point42 = point1;
      label37_1.Location = point42;
      Label37.Name = "Label37";
      Label label37_2 = Label37;
      size1 = new Size(112, 16);
      Size size41 = size1;
      label37_2.Size = size41;
      Label37.TabIndex = 5;
      Label37.Text = "Camera Field of View";
      tabpagAnimationSound.Controls.Add(dgAnimList);
      tabpagAnimationSound.Controls.Add(Label5);
      tabpagAnimationSound.Controls.Add(tbSound);
      tabpagAnimationSound.Controls.Add(Label6);
      tabpagAnimationSound.Controls.Add(tbVoiceOverResRef);
      tabpagAnimationSound.Controls.Add(Label10);
      tabpagAnimationSound.Controls.Add(btnDeleteAnimListEntry);
      tabpagAnimationSound.Controls.Add(btnAddAnimListEntry);
      TabPage tabpagAnimationSound1 = tabpagAnimationSound;
      point1 = new Point(4, 40);
      Point point43 = point1;
      ((Control) tabpagAnimationSound1).Location = point43;
      tabpagAnimationSound.Name = "tabpagAnimationSound";
      TabPage tabpagAnimationSound2 = tabpagAnimationSound;
      size1 = new Size(480, 172);
      Size size42 = size1;
      tabpagAnimationSound2.Size = size42;
      tabpagAnimationSound.TabIndex = 1;
      tabpagAnimationSound.Text = "Animation/Sound";
      dgAnimList.CaptionVisible = false;
      dgAnimList.DataMember = "";
      dgAnimList.HeaderForeColor = SystemColors.ControlText;
      DataGrid dgAnimList1 = dgAnimList;
      point1 = new Point(224, 32);
      Point point44 = point1;
      dgAnimList1.Location = point44;
      dgAnimList.Name = "dgAnimList";
      DataGrid dgAnimList2 = dgAnimList;
      size1 = new Size(248, 104);
      Size size43 = size1;
      dgAnimList2.Size = size43;
      dgAnimList.TabIndex = 8;
      Label label5_1 = Label5;
      point1 = new Point(248, 8);
      Point point45 = point1;
      label5_1.Location = point45;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(100, 16);
      Size size44 = size1;
      label5_2.Size = size44;
      Label5.TabIndex = 7;
      Label5.Text = "Play Animation";
      tbSound.CharacterCasing = CharacterCasing.Lower;
      TextBox tbSound1 = tbSound;
      point1 = new Point(32, 89);
      Point point46 = point1;
      tbSound1.Location = point46;
      tbSound.MaxLength = 16;
      tbSound.Name = "tbSound";
      TextBox tbSound2 = tbSound;
      size1 = new Size(120, 20);
      Size size45 = size1;
      tbSound2.Size = size45;
      tbSound.TabIndex = 2;
      tbSound.Text = "";
      Label label6_1 = Label6;
      point1 = new Point(32, 64);
      Point point47 = point1;
      label6_1.Location = point47;
      Label6.Name = "Label6";
      Label label6_2 = Label6;
      size1 = new Size(136, 16);
      Size size46 = size1;
      label6_2.Size = size46;
      Label6.TabIndex = 7;
      Label6.Text = "Play this sound (ResRef)";
      tbVoiceOverResRef.CharacterCasing = CharacterCasing.Lower;
      TextBox tbVoiceOverResRef1 = tbVoiceOverResRef;
      point1 = new Point(32, 32);
      Point point48 = point1;
      tbVoiceOverResRef1.Location = point48;
      tbVoiceOverResRef.MaxLength = 16;
      tbVoiceOverResRef.Name = "tbVoiceOverResRef";
      TextBox tbVoiceOverResRef2 = tbVoiceOverResRef;
      size1 = new Size(120, 20);
      Size size47 = size1;
      tbVoiceOverResRef2.Size = size47;
      tbVoiceOverResRef.TabIndex = 3;
      tbVoiceOverResRef.Text = "";
      Label label10_1 = Label10;
      point1 = new Point(32, 8);
      Point point49 = point1;
      label10_1.Location = point49;
      Label10.Name = "Label10";
      Label label10_2 = Label10;
      size1 = new Size(184, 16);
      Size size48 = size1;
      label10_2.Size = size48;
      Label10.TabIndex = 7;
      Label10.Text = "Play this Voice Over (ResRef)";
      btnDeleteAnimListEntry.Enabled = false;
      Button deleteAnimListEntry1 = btnDeleteAnimListEntry;
      point1 = new Point(360, 144);
      Point point50 = point1;
      deleteAnimListEntry1.Location = point50;
      btnDeleteAnimListEntry.Name = "btnDeleteAnimListEntry";
      Button deleteAnimListEntry2 = btnDeleteAnimListEntry;
      size1 = new Size(56, 23);
      Size size49 = size1;
      deleteAnimListEntry2.Size = size49;
      btnDeleteAnimListEntry.TabIndex = 6;
      btnDeleteAnimListEntry.Text = "Delete";
      Button addAnimListEntry1 = btnAddAnimListEntry;
      point1 = new Point(288, 144);
      Point point51 = point1;
      addAnimListEntry1.Location = point51;
      btnAddAnimListEntry.Name = "btnAddAnimListEntry";
      Button addAnimListEntry2 = btnAddAnimListEntry;
      size1 = new Size(56, 23);
      Size size50 = size1;
      addAnimListEntry2.Size = size50;
      btnAddAnimListEntry.TabIndex = 6;
      btnAddAnimListEntry.Text = "Add";
      tabpagPlot.Controls.Add(tbQuest);
      tabpagPlot.Controls.Add(Label35);
      tabpagPlot.Controls.Add(nudPlotIndex);
      tabpagPlot.Controls.Add(lblPlotIndex);
      tabpagPlot.Controls.Add(Label12);
      tabpagPlot.Controls.Add(nudPlotXPPercentage);
      tabpagPlot.Controls.Add(Label36);
      tabpagPlot.Controls.Add(nudQuestEntry);
      TabPage tabpagPlot1 = tabpagPlot;
      point1 = new Point(4, 40);
      Point point52 = point1;
      ((Control) tabpagPlot1).Location = point52;
      tabpagPlot.Name = "tabpagPlot";
      TabPage tabpagPlot2 = tabpagPlot;
      size1 = new Size(480, 172);
      Size size51 = size1;
      tabpagPlot2.Size = size51;
      tabpagPlot.TabIndex = 6;
      tabpagPlot.Text = "Plot/Quest";
      tbQuest.CharacterCasing = CharacterCasing.Lower;
      TextBox tbQuest1 = tbQuest;
      point1 = new Point(176, 40);
      Point point53 = point1;
      tbQuest1.Location = point53;
      tbQuest.Name = "tbQuest";
      TextBox tbQuest2 = tbQuest;
      size1 = new Size(224, 20);
      Size size52 = size1;
      tbQuest2.Size = size52;
      tbQuest.TabIndex = 14;
      tbQuest.Text = "";
      Label label35_1 = Label35;
      point1 = new Point(176, 80);
      Point point54 = point1;
      label35_1.Location = point54;
      Label35.Name = "Label35";
      Label label35_2 = Label35;
      size1 = new Size(128, 16);
      Size size53 = size1;
      label35_2.Size = size53;
      Label35.TabIndex = 15;
      Label35.Text = "Quest Entry";
      NumericUpDown nudPlotIndex1 = nudPlotIndex;
      point1 = new Point(32, 40);
      Point point55 = point1;
      nudPlotIndex1.Location = point55;
      NumericUpDown nudPlotIndex2 = nudPlotIndex;
      num1 = new Decimal(new int[4]{ 999, 0, 0, 0 });
      Decimal num17 = num1;
      nudPlotIndex2.Maximum = num17;
      NumericUpDown nudPlotIndex3 = nudPlotIndex;
      num1 = new Decimal(new int[4]
      {
        1,
        0,
        0,
        int.MinValue
      });
      Decimal num18 = num1;
      nudPlotIndex3.Minimum = num18;
      nudPlotIndex.Name = "nudPlotIndex";
      NumericUpDown nudPlotIndex4 = nudPlotIndex;
      size1 = new Size(40, 20);
      Size size54 = size1;
      nudPlotIndex4.Size = size54;
      nudPlotIndex.TabIndex = 12;
      nudPlotIndex.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudPlotIndex5 = nudPlotIndex;
      num1 = new Decimal(new int[4]
      {
        1,
        0,
        0,
        int.MinValue
      });
      Decimal num19 = num1;
      nudPlotIndex5.Value = num19;
      Label lblPlotIndex1 = lblPlotIndex;
      point1 = new Point(32, 24);
      Point point56 = point1;
      lblPlotIndex1.Location = point56;
      lblPlotIndex.Name = "lblPlotIndex";
      Label lblPlotIndex2 = lblPlotIndex;
      size1 = new Size(100, 16);
      Size size55 = size1;
      lblPlotIndex2.Size = size55;
      lblPlotIndex.TabIndex = 11;
      lblPlotIndex.Text = "Plot Index";
      Label label12_1 = Label12;
      point1 = new Point(32, 80);
      Point point57 = point1;
      label12_1.Location = point57;
      Label12.Name = "Label12";
      Label label12_2 = Label12;
      size1 = new Size(120, 16);
      Size size56 = size1;
      label12_2.Size = size56;
      Label12.TabIndex = 10;
      Label12.Text = "Plot XP Percentage";
      NumericUpDown plotXpPercentage1 = nudPlotXPPercentage;
      point1 = new Point(32, 96);
      Point point58 = point1;
      plotXpPercentage1.Location = point58;
      nudPlotXPPercentage.Name = "nudPlotXPPercentage";
      NumericUpDown plotXpPercentage2 = nudPlotXPPercentage;
      size1 = new Size(40, 20);
      Size size57 = size1;
      plotXpPercentage2.Size = size57;
      nudPlotXPPercentage.TabIndex = 12;
      nudPlotXPPercentage.TextAlign = HorizontalAlignment.Right;
      NumericUpDown plotXpPercentage3 = nudPlotXPPercentage;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num20 = num1;
      plotXpPercentage3.Value = num20;
      Label label36_1 = Label36;
      point1 = new Point(176, 24);
      Point point59 = point1;
      label36_1.Location = point59;
      Label36.Name = "Label36";
      Label label36_2 = Label36;
      size1 = new Size(128, 16);
      Size size58 = size1;
      label36_2.Size = size58;
      Label36.TabIndex = 15;
      Label36.Text = "Quest";
      NumericUpDown nudQuestEntry1 = nudQuestEntry;
      point1 = new Point(176, 96);
      Point point60 = point1;
      nudQuestEntry1.Location = point60;
      NumericUpDown nudQuestEntry2 = nudQuestEntry;
      num1 = new Decimal(new int[4]{ -1, 0, 0, 0 });
      Decimal num21 = num1;
      nudQuestEntry2.Maximum = num21;
      nudQuestEntry.Name = "nudQuestEntry";
      NumericUpDown nudQuestEntry3 = nudQuestEntry;
      size1 = new Size(88, 20);
      Size size59 = size1;
      nudQuestEntry3.Size = size59;
      nudQuestEntry.TabIndex = 12;
      nudQuestEntry.TextAlign = HorizontalAlignment.Right;
      tabpagComment.Controls.Add(tbComments);
      TabPage tabpagComment1 = tabpagComment;
      point1 = new Point(4, 40);
      Point point61 = point1;
      ((Control) tabpagComment1).Location = point61;
      tabpagComment.Name = "tabpagComment";
      TabPage tabpagComment2 = tabpagComment;
      size1 = new Size(480, 172);
      Size size60 = size1;
      tabpagComment2.Size = size60;
      tabpagComment.TabIndex = 2;
      tabpagComment.Text = "Comments";
      tbComments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TextBox tbComments1 = tbComments;
      point1 = new Point(8, 16);
      Point point62 = point1;
      tbComments1.Location = point62;
      tbComments.Multiline = true;
      tbComments.Name = "tbComments";
      tbComments.ScrollBars = ScrollBars.Vertical;
      TextBox tbComments2 = tbComments;
      size1 = new Size(456, 136);
      Size size61 = size1;
      tbComments2.Size = size61;
      tbComments.TabIndex = 1;
      tbComments.Text = "";
      tabpagThisFile1.Controls.Add(chkbAnimatedCut);
      tabpagThisFile1.Controls.Add(tbCameraModel);
      tabpagThisFile1.Controls.Add(Label31);
      tabpagThisFile1.Controls.Add(cmbxConversationType);
      tabpagThisFile1.Controls.Add(chkbSkippable);
      tabpagThisFile1.Controls.Add(tbVO_ID);
      tabpagThisFile1.Controls.Add(Label20);
      tabpagThisFile1.Controls.Add(Label21);
      tabpagThisFile1.Controls.Add(tbEndConversation);
      tabpagThisFile1.Controls.Add(Label22);
      tabpagThisFile1.Controls.Add(Label23);
      tabpagThisFile1.Controls.Add(tbEndConverAbort);
      tabpagThisFile1.Controls.Add(Label24);
      tabpagThisFile1.Controls.Add(tbAmbientTrack);
      tabpagThisFile1.Controls.Add(Label25);
      tabpagThisFile1.Controls.Add(chkbUnequipItems);
      tabpagThisFile1.Controls.Add(chkbUnequipHItem);
      tabpagThisFile1.Controls.Add(Label26);
      tabpagThisFile1.Controls.Add(nudDelayEntry);
      tabpagThisFile1.Controls.Add(nudDelayReply);
      tabpagThisFile1.Controls.Add(Label27);
      tabpagThisFile1.Controls.Add(cmbxComputerType);
      TabPage tabpagThisFile1_1 = tabpagThisFile1;
      point1 = new Point(4, 40);
      Point point63 = point1;
      ((Control) tabpagThisFile1_1).Location = point63;
      tabpagThisFile1.Name = "tabpagThisFile1";
      TabPage tabpagThisFile1_2 = tabpagThisFile1;
      size1 = new Size(480, 172);
      Size size62 = size1;
      tabpagThisFile1_2.Size = size62;
      tabpagThisFile1.TabIndex = 3;
      tabpagThisFile1.Text = "This File (1)";
      CheckBox chkbAnimatedCut1 = chkbAnimatedCut;
      point1 = new Point(16, 136);
      Point point64 = point1;
      chkbAnimatedCut1.Location = point64;
      chkbAnimatedCut.Name = "chkbAnimatedCut";
      CheckBox chkbAnimatedCut2 = chkbAnimatedCut;
      size1 = new Size(128, 24);
      Size size63 = size1;
      chkbAnimatedCut2.Size = size63;
      chkbAnimatedCut.TabIndex = 16;
      chkbAnimatedCut.Text = "Animated Cutscene";
      tbCameraModel.Enabled = false;
      TextBox tbCameraModel1 = tbCameraModel;
      point1 = new Point(160, 143);
      Point point65 = point1;
      tbCameraModel1.Location = point65;
      tbCameraModel.MaxLength = 16;
      tbCameraModel.Name = "tbCameraModel";
      TextBox tbCameraModel2 = tbCameraModel;
      size1 = new Size(120, 20);
      Size size64 = size1;
      tbCameraModel2.Size = size64;
      tbCameraModel.TabIndex = 14;
      tbCameraModel.Text = "";
      ToolTip1.SetToolTip(tbCameraModel, "This is the model name of the camera to use in Animated Cutscenes");
      Label label31_1 = Label31;
      point1 = new Point(160, 128);
      Point point66 = point1;
      label31_1.Location = point66;
      Label31.Name = "Label31";
      Label label31_2 = Label31;
      size1 = new Size(80, 16);
      Size size65 = size1;
      label31_2.Size = size65;
      Label31.TabIndex = 15;
      Label31.Text = "Camera Model";
      cmbxConversationType.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxConversationType.Items.AddRange(new object[5]
      {
        "Human",
        "Computer",
        "Type 2",
        "Type 3",
        "Type 4"
      });
      ComboBox conversationType1 = cmbxConversationType;
      point1 = new Point(8, 64);
      Point point67 = point1;
      conversationType1.Location = point67;
      cmbxConversationType.Name = "cmbxConversationType";
      ComboBox conversationType2 = cmbxConversationType;
      size1 = new Size(88, 21);
      Size size66 = size1;
      conversationType2.Size = size66;
      cmbxConversationType.TabIndex = 12;
      CheckBox chkbSkippable1 = chkbSkippable;
      point1 = new Point(320, 8);
      Point point68 = point1;
      chkbSkippable1.Location = point68;
      chkbSkippable.Name = "chkbSkippable";
      CheckBox chkbSkippable2 = chkbSkippable;
      size1 = new Size(80, 24);
      Size size67 = size1;
      chkbSkippable2.Size = size67;
      chkbSkippable.TabIndex = 11;
      chkbSkippable.Text = "Skippable";
      tbVO_ID.CharacterCasing = CharacterCasing.Lower;
      TextBox tbVoId1 = tbVO_ID;
      point1 = new Point(8, 24);
      Point point69 = point1;
      tbVoId1.Location = point69;
      tbVO_ID.Name = "tbVO_ID";
      TextBox tbVoId2 = tbVO_ID;
      size1 = new Size(128, 20);
      Size size68 = size1;
      tbVoId2.Size = size68;
      tbVO_ID.TabIndex = 8;
      tbVO_ID.Text = "";
      Label label20_1 = Label20;
      point1 = new Point(8, 8);
      Point point70 = point1;
      label20_1.Location = point70;
      Label20.Name = "Label20";
      Label label20_2 = Label20;
      size1 = new Size(112, 16);
      Size size69 = size1;
      label20_2.Size = size69;
      Label20.TabIndex = 9;
      Label20.Text = "Voice Over Family ID";
      Label label21_1 = Label21;
      point1 = new Point(8, 48);
      Point point71 = point1;
      label21_1.Location = point71;
      Label21.Name = "Label21";
      Label label21_2 = Label21;
      size1 = new Size(104, 16);
      Size size70 = size1;
      label21_2.Size = size70;
      Label21.TabIndex = 9;
      Label21.Text = "Conversation Type";
      tbEndConversation.CharacterCasing = CharacterCasing.Lower;
      TextBox tbEndConversation1 = tbEndConversation;
      point1 = new Point(160, 24);
      Point point72 = point1;
      tbEndConversation1.Location = point72;
      tbEndConversation.MaxLength = 16;
      tbEndConversation.Name = "tbEndConversation";
      TextBox tbEndConversation2 = tbEndConversation;
      size1 = new Size(128, 20);
      Size size71 = size1;
      tbEndConversation2.Size = size71;
      tbEndConversation.TabIndex = 8;
      tbEndConversation.Text = "";
      Label label22_1 = Label22;
      point1 = new Point(160, 8);
      Point point73 = point1;
      label22_1.Location = point73;
      Label22.Name = "Label22";
      Label label22_2 = Label22;
      size1 = new Size(128, 16);
      Size size72 = size1;
      label22_2.Size = size72;
      Label22.TabIndex = 9;
      Label22.Text = "End Conv Normal Script";
      Label label23_1 = Label23;
      point1 = new Point(160, 48);
      Point point74 = point1;
      label23_1.Location = point74;
      Label23.Name = "Label23";
      Label label23_2 = Label23;
      size1 = new Size(128, 16);
      Size size73 = size1;
      label23_2.Size = size73;
      Label23.TabIndex = 9;
      Label23.Text = "End Conv Abort Script";
      tbEndConverAbort.CharacterCasing = CharacterCasing.Lower;
      TextBox tbEndConverAbort1 = tbEndConverAbort;
      point1 = new Point(160, 64);
      Point point75 = point1;
      tbEndConverAbort1.Location = point75;
      tbEndConverAbort.MaxLength = 16;
      tbEndConverAbort.Name = "tbEndConverAbort";
      TextBox tbEndConverAbort2 = tbEndConverAbort;
      size1 = new Size(128, 20);
      Size size74 = size1;
      tbEndConverAbort2.Size = size74;
      tbEndConverAbort.TabIndex = 8;
      tbEndConverAbort.Text = "";
      Label label24_1 = Label24;
      point1 = new Point(8, 88);
      Point point76 = point1;
      label24_1.Location = point76;
      Label24.Name = "Label24";
      Label label24_2 = Label24;
      size1 = new Size(104, 16);
      Size size75 = size1;
      label24_2.Size = size75;
      Label24.TabIndex = 9;
      Label24.Text = "Computer Type";
      tbAmbientTrack.CharacterCasing = CharacterCasing.Lower;
      TextBox tbAmbientTrack1 = tbAmbientTrack;
      point1 = new Point(160, 104);
      Point point77 = point1;
      tbAmbientTrack1.Location = point77;
      tbAmbientTrack.MaxLength = 16;
      tbAmbientTrack.Name = "tbAmbientTrack";
      TextBox tbAmbientTrack2 = tbAmbientTrack;
      size1 = new Size(128, 20);
      Size size76 = size1;
      tbAmbientTrack2.Size = size76;
      tbAmbientTrack.TabIndex = 8;
      tbAmbientTrack.Text = "";
      Label label25_1 = Label25;
      point1 = new Point(160, 88);
      Point point78 = point1;
      label25_1.Location = point78;
      Label25.Name = "Label25";
      Label label25_2 = Label25;
      size1 = new Size(128, 16);
      Size size77 = size1;
      label25_2.Size = size77;
      Label25.TabIndex = 9;
      Label25.Text = "Ambient Track";
      CheckBox chkbUnequipItems1 = chkbUnequipItems;
      point1 = new Point(320, 32);
      Point point79 = point1;
      chkbUnequipItems1.Location = point79;
      chkbUnequipItems.Name = "chkbUnequipItems";
      CheckBox chkbUnequipItems2 = chkbUnequipItems;
      size1 = new Size(96, 24);
      Size size78 = size1;
      chkbUnequipItems2.Size = size78;
      chkbUnequipItems.TabIndex = 11;
      chkbUnequipItems.Text = "Unequip Items";
      CheckBox chkbUnequipHitem = chkbUnequipHItem;
      point1 = new Point(320, 56);
      Point point80 = point1;
      chkbUnequipHitem.Location = point80;
      chkbUnequipHItem.Name = "chkbUnequipHItem";
      chkbUnequipHItem.TabIndex = 11;
      chkbUnequipHItem.Text = "Unequip HItem";
      Label label26_1 = Label26;
      point1 = new Point(307, 88);
      Point point81 = point1;
      label26_1.Location = point81;
      Label26.Name = "Label26";
      Label label26_2 = Label26;
      size1 = new Size(64, 16);
      Size size79 = size1;
      label26_2.Size = size79;
      Label26.TabIndex = 9;
      Label26.Text = "Delay Entry";
      NumericUpDown nudDelayEntry1 = nudDelayEntry;
      point1 = new Point(304, 104);
      Point point82 = point1;
      nudDelayEntry1.Location = point82;
      NumericUpDown nudDelayEntry2 = nudDelayEntry;
      num1 = new Decimal(new int[4]{ 100000, 0, 0, 0 });
      Decimal num22 = num1;
      nudDelayEntry2.Maximum = num22;
      nudDelayEntry.Name = "nudDelayEntry";
      NumericUpDown nudDelayEntry3 = nudDelayEntry;
      size1 = new Size(64, 20);
      Size size80 = size1;
      nudDelayEntry3.Size = size80;
      nudDelayEntry.TabIndex = 10;
      nudDelayEntry.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudDelayReply1 = nudDelayReply;
      point1 = new Point(400, 104);
      Point point83 = point1;
      nudDelayReply1.Location = point83;
      NumericUpDown nudDelayReply2 = nudDelayReply;
      num1 = new Decimal(new int[4]{ 100000, 0, 0, 0 });
      Decimal num23 = num1;
      nudDelayReply2.Maximum = num23;
      nudDelayReply.Name = "nudDelayReply";
      NumericUpDown nudDelayReply3 = nudDelayReply;
      size1 = new Size(64, 20);
      Size size81 = size1;
      nudDelayReply3.Size = size81;
      nudDelayReply.TabIndex = 10;
      nudDelayReply.TextAlign = HorizontalAlignment.Right;
      Label label27_1 = Label27;
      point1 = new Point(400, 88);
      Point point84 = point1;
      label27_1.Location = point84;
      Label27.Name = "Label27";
      Label label27_2 = Label27;
      size1 = new Size(72, 16);
      Size size82 = size1;
      label27_2.Size = size82;
      Label27.TabIndex = 9;
      Label27.Text = "Delay Reply";
      cmbxComputerType.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxComputerType.Enabled = false;
      cmbxComputerType.Items.AddRange(new object[2]
      {
        "Modern",
        "Ancient"
      });
      ComboBox cmbxComputerType1 = cmbxComputerType;
      point1 = new Point(8, 104);
      Point point85 = point1;
      cmbxComputerType1.Location = point85;
      cmbxComputerType.Name = "cmbxComputerType";
      ComboBox cmbxComputerType2 = cmbxComputerType;
      size1 = new Size(88, 21);
      Size size83 = size1;
      cmbxComputerType2.Size = size83;
      cmbxComputerType.TabIndex = 12;
      tabpagThisFile2.Controls.Add(dgStuntList);
      tabpagThisFile2.Controls.Add(Label30);
      TabPage tabpagThisFile2_1 = tabpagThisFile2;
      point1 = new Point(4, 40);
      Point point86 = point1;
      ((Control) tabpagThisFile2_1).Location = point86;
      tabpagThisFile2.Name = "tabpagThisFile2";
      TabPage tabpagThisFile2_2 = tabpagThisFile2;
      size1 = new Size(480, 172);
      Size size84 = size1;
      tabpagThisFile2_2.Size = size84;
      tabpagThisFile2.TabIndex = 8;
      tabpagThisFile2.Text = "This File (2)";
      dgStuntList.DataMember = "";
      dgStuntList.HeaderForeColor = SystemColors.ControlText;
      DataGrid dgStuntList1 = dgStuntList;
      point1 = new Point(56, 24);
      Point point87 = point1;
      dgStuntList1.Location = point87;
      dgStuntList.Name = "dgStuntList";
      DataGrid dgStuntList2 = dgStuntList;
      size1 = new Size(368, 112);
      Size size85 = size1;
      dgStuntList2.Size = size85;
      dgStuntList.TabIndex = 0;
      Label30.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Label label30_1 = Label30;
      point1 = new Point(56, 24);
      Point point88 = point1;
      label30_1.Location = point88;
      Label30.Name = "Label30";
      Label label30_2 = Label30;
      size1 = new Size(136, 16);
      Size size86 = size1;
      label30_2.Size = size86;
      Label30.TabIndex = 3;
      Label30.Text = "(Stunt List is View-only)";
      TabPage tabpagThisFile3_1 = tabpagThisFile3;
      point1 = new Point(4, 40);
      Point point89 = point1;
      ((Control) tabpagThisFile3_1).Location = point89;
      tabpagThisFile3.Name = "tabpagThisFile3";
      TabPage tabpagThisFile3_2 = tabpagThisFile3;
      size1 = new Size(480, 172);
      Size size87 = size1;
      tabpagThisFile3_2.Size = size87;
      tabpagThisFile3.TabIndex = 9;
      tabpagThisFile3.Text = "This File (3)";
      tabpagDebug.Controls.Add(trkbTVIndent);
      tabpagDebug.Controls.Add(Label17);
      tabpagDebug.Controls.Add(tbLinkID);
      tabpagDebug.Controls.Add(tbLinkedCnt);
      tabpagDebug.Controls.Add(tbSharedCnt);
      tabpagDebug.Controls.Add(Label18);
      tabpagDebug.Controls.Add(Label19);
      tabpagDebug.Controls.Add(btnDebug);
      tabpagDebug.Controls.Add(Label32);
      tabpagDebug.Controls.Add(Label33);
      tabpagDebug.Controls.Add(trkbTVItemHeight);
      tabpagDebug.Controls.Add(tbLinkDesc);
      tabpagDebug.Controls.Add(Label34);
      tabpagDebug.Controls.Add(btnShowLists);
      TabPage tabpagDebug1 = tabpagDebug;
      point1 = new Point(4, 40);
      Point point90 = point1;
      ((Control) tabpagDebug1).Location = point90;
      tabpagDebug.Name = "tabpagDebug";
      TabPage tabpagDebug2 = tabpagDebug;
      size1 = new Size(480, 172);
      Size size88 = size1;
      tabpagDebug2.Size = size88;
      tabpagDebug.TabIndex = 7;
      tabpagDebug.Text = "Debug information/Options";
      TrackBar trkbTvIndent1 = trkbTVIndent;
      point1 = new Point(280, 40);
      Point point91 = point1;
      trkbTvIndent1.Location = point91;
      trkbTVIndent.Maximum = 30;
      trkbTVIndent.Minimum = 15;
      trkbTVIndent.Name = "trkbTVIndent";
      TrackBar trkbTvIndent2 = trkbTVIndent;
      size1 = new Size(120, 42);
      Size size89 = size1;
      trkbTvIndent2.Size = size89;
      trkbTVIndent.TabIndex = 9;
      trkbTVIndent.Value = 16;
      Label label17_1 = Label17;
      point1 = new Point(56, 32);
      Point point92 = point1;
      label17_1.Location = point92;
      Label17.Name = "Label17";
      Label label17_2 = Label17;
      size1 = new Size(100, 16);
      Size size90 = size1;
      label17_2.Size = size90;
      Label17.TabIndex = 8;
      Label17.Text = "Link ID";
      TextBox tbLinkId1 = tbLinkID;
      point1 = new Point(168, 30);
      Point point93 = point1;
      tbLinkId1.Location = point93;
      tbLinkID.Name = "tbLinkID";
      TextBox tbLinkId2 = tbLinkID;
      size1 = new Size(56, 20);
      Size size91 = size1;
      tbLinkId2.Size = size91;
      tbLinkID.TabIndex = 7;
      tbLinkID.Text = "";
      TextBox tbLinkedCnt1 = tbLinkedCnt;
      point1 = new Point(168, 64);
      Point point94 = point1;
      tbLinkedCnt1.Location = point94;
      tbLinkedCnt.Name = "tbLinkedCnt";
      TextBox tbLinkedCnt2 = tbLinkedCnt;
      size1 = new Size(56, 20);
      Size size92 = size1;
      tbLinkedCnt2.Size = size92;
      tbLinkedCnt.TabIndex = 7;
      tbLinkedCnt.Text = "";
      TextBox tbSharedCnt1 = tbSharedCnt;
      point1 = new Point(168, 96);
      Point point95 = point1;
      tbSharedCnt1.Location = point95;
      tbSharedCnt.Name = "tbSharedCnt";
      TextBox tbSharedCnt2 = tbSharedCnt;
      size1 = new Size(56, 20);
      Size size93 = size1;
      tbSharedCnt2.Size = size93;
      tbSharedCnt.TabIndex = 7;
      tbSharedCnt.Text = "";
      Label label18_1 = Label18;
      point1 = new Point(56, 66);
      Point point96 = point1;
      label18_1.Location = point96;
      Label18.Name = "Label18";
      Label label18_2 = Label18;
      size1 = new Size(80, 16);
      Size size94 = size1;
      label18_2.Size = size94;
      Label18.TabIndex = 8;
      Label18.Text = "Linked to this";
      Label label19_1 = Label19;
      point1 = new Point(56, 98);
      Point point97 = point1;
      label19_1.Location = point97;
      Label19.Name = "Label19";
      Label label19_2 = Label19;
      size1 = new Size(100, 16);
      Size size95 = size1;
      label19_2.Size = size95;
      Label19.TabIndex = 8;
      Label19.Text = "Nodes sharing link";
      Button btnDebug1 = btnDebug;
      point1 = new Point(280, 144);
      Point point98 = point1;
      btnDebug1.Location = point98;
      btnDebug.Name = "btnDebug";
      Button btnDebug2 = btnDebug;
      size1 = new Size(120, 23);
      Size size96 = size1;
      btnDebug2.Size = size96;
      btnDebug.TabIndex = 6;
      btnDebug.Text = "Show Debug Listing";
      Label label32_1 = Label32;
      point1 = new Point(288, 24);
      Point point99 = point1;
      label32_1.Location = point99;
      Label32.Name = "Label32";
      Label label32_2 = Label32;
      size1 = new Size(112, 16);
      Size size97 = size1;
      label32_2.Size = size97;
      Label32.TabIndex = 8;
      Label32.Text = "Treeview indent level";
      Label label33_1 = Label33;
      point1 = new Point(288, 88);
      Point point100 = point1;
      label33_1.Location = point100;
      Label33.Name = "Label33";
      Label label33_2 = Label33;
      size1 = new Size(112, 16);
      Size size98 = size1;
      label33_2.Size = size98;
      Label33.TabIndex = 8;
      Label33.Text = "Treeview item height";
      TrackBar trkbTvItemHeight1 = trkbTVItemHeight;
      point1 = new Point(280, 104);
      Point point101 = point1;
      trkbTvItemHeight1.Location = point101;
      trkbTVItemHeight.Maximum = 21;
      trkbTVItemHeight.Minimum = 7;
      trkbTVItemHeight.Name = "trkbTVItemHeight";
      TrackBar trkbTvItemHeight2 = trkbTVItemHeight;
      size1 = new Size(120, 42);
      Size size99 = size1;
      trkbTvItemHeight2.Size = size99;
      trkbTVItemHeight.TabIndex = 9;
      trkbTVItemHeight.Value = 9;
      TextBox tbLinkDesc1 = tbLinkDesc;
      point1 = new Point(168, 128);
      Point point102 = point1;
      tbLinkDesc1.Location = point102;
      tbLinkDesc.Name = "tbLinkDesc";
      TextBox tbLinkDesc2 = tbLinkDesc;
      size1 = new Size(56, 20);
      Size size100 = size1;
      tbLinkDesc2.Size = size100;
      tbLinkDesc.TabIndex = 7;
      tbLinkDesc.Text = "";
      Label label34_1 = Label34;
      point1 = new Point(56, 128);
      Point point103 = point1;
      label34_1.Location = point103;
      Label34.Name = "Label34";
      Label label34_2 = Label34;
      size1 = new Size(100, 16);
      Size size101 = size1;
      label34_2.Size = size101;
      Label34.TabIndex = 8;
      Label34.Text = "Link Desc";
      Button btnShowLists1 = btnShowLists;
      point1 = new Point(448, 144);
      Point point104 = point1;
      btnShowLists1.Location = point104;
      btnShowLists.Name = "btnShowLists";
      Button btnShowLists2 = btnShowLists;
      size1 = new Size(24, 23);
      Size size102 = size1;
      btnShowLists2.Size = size102;
      btnShowLists.TabIndex = 6;
      btnShowLists.Text = "D";
      btnShowLists.Visible = false;
      btnCollapseAll.Image = (Image) resourceManager.GetObject("btnCollapseAll.Image");
      Button btnCollapseAll1 = btnCollapseAll;
      point1 = new Point(5, 240);
      Point point105 = point1;
      btnCollapseAll1.Location = point105;
      btnCollapseAll.Name = "btnCollapseAll";
      Button btnCollapseAll2 = btnCollapseAll;
      size1 = new Size(24, 23);
      Size size103 = size1;
      btnCollapseAll2.Size = size103;
      btnCollapseAll.TabIndex = 2;
      btnCollapseAll.Text = "C";
      ToolTip1.SetToolTip(btnCollapseAll, "Collapse all nodes in the treeview");
      btnExpandAll.Image = (Image) resourceManager.GetObject("btnExpandAll.Image");
      Button btnExpandAll1 = btnExpandAll;
      point1 = new Point(5, 184);
      Point point106 = point1;
      btnExpandAll1.Location = point106;
      btnExpandAll.Name = "btnExpandAll";
      Button btnExpandAll2 = btnExpandAll;
      size1 = new Size(24, 23);
      Size size104 = size1;
      btnExpandAll2.Size = size104;
      btnExpandAll.TabIndex = 1;
      btnExpandAll.Text = "E";
      ToolTip1.SetToolTip(btnExpandAll, "Expand all nodes in the treeview");
      Button btnSave1 = btnSave;
      point1 = new Point(152, 312);
      Point point107 = point1;
      btnSave1.Location = point107;
      btnSave.Name = "btnSave";
      Button btnSave2 = btnSave;
      size1 = new Size(42, 23);
      Size size105 = size1;
      btnSave2.Size = size105;
      btnSave.TabIndex = 6;
      btnSave.Text = "Save";
      btnSave.Visible = false;
      Button btnTest1 = btnTest;
      point1 = new Point(8, 312);
      Point point108 = point1;
      btnTest1.Location = point108;
      btnTest.Name = "btnTest";
      Button btnTest2 = btnTest;
      size1 = new Size(40, 23);
      Size size106 = size1;
      btnTest2.Size = size106;
      btnTest.TabIndex = 5;
      btnTest.Text = "Test";
      btnTest.Visible = false;
      cmTVfunctions.ToolStripMenuItems.AddRange(new ToolStripMenuItem[9]
      {
        cmiTV_Add,
        cmiTV_Cut,
        cmiTV_Copy,
        cmiTV_Paste,
        cmiTV_PasteTree,
        cmiTV_PasteAsLink,
        ToolStripMenuItem2,
        cmiTV_MoveNodeUp,
        cmiTV_MoveNodeDown
      });
      cmiTV_Add.Index = 0;
      cmiTV_Add.Text = "Add";
      cmiTV_Cut.Index = 1;
      cmiTV_Cut.Text = "Cut";
      cmiTV_Copy.Index = 2;
      cmiTV_Copy.Text = "Copy";
      cmiTV_Paste.Index = 3;
      cmiTV_Paste.Text = "Paste Top Node on Clipboard";
      cmiTV_PasteTree.Index = 4;
      cmiTV_PasteTree.Text = "Paste Tree on Clipboard";
      cmiTV_PasteAsLink.Index = 5;
      cmiTV_PasteAsLink.Text = "Paste As Link";
      ToolStripMenuItem2.Index = 6;
      ToolStripMenuItem2.Text = "-";
      cmiTV_MoveNodeUp.Index = 7;
      cmiTV_MoveNodeUp.Text = "Move up";
      cmiTV_MoveNodeDown.Index = 8;
      cmiTV_MoveNodeDown.Text = "Move down";
      tbSpeaker.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      tbSpeaker.CharacterCasing = CharacterCasing.Lower;
      TextBox tbSpeaker1 = tbSpeaker;
      point1 = new Point(32, 360);
      Point point109 = point1;
      tbSpeaker1.Location = point109;
      tbSpeaker.Name = "tbSpeaker";
      TextBox tbSpeaker2 = tbSpeaker;
      size1 = new Size(128, 20);
      Size size107 = size1;
      tbSpeaker2.Size = size107;
      tbSpeaker.TabIndex = 9;
      tbSpeaker.Text = "";
      Button btnOpen1 = btnOpen;
      point1 = new Point(88, 312);
      Point point110 = point1;
      btnOpen1.Location = point110;
      btnOpen.Name = "btnOpen";
      Button btnOpen2 = btnOpen;
      size1 = new Size(48, 23);
      Size size108 = size1;
      btnOpen2.Size = size108;
      btnOpen.TabIndex = 6;
      btnOpen.Text = "Open";
      btnOpen.Visible = false;
      MainMenu1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[1]
      {
        ToolStripMenuItem1
      });
      ToolStripMenuItem1.Index = 0;
      ToolStripMenuItem1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[5]
      {
        miNew,
        miOpen,
        miSave,
        ToolStripMenuItem4,
        miQuit
      });
      ToolStripMenuItem1.Text = "File";
      miNew.Index = 0;
      miNew.Text = "New";
      miOpen.Index = 1;
      miOpen.Shortcut = Shortcut.CtrlO;
      miOpen.Text = "&Open";
      miSave.Index = 2;
      miSave.Shortcut = Shortcut.CtrlS;
      miSave.Text = "&Save";
      ToolStripMenuItem4.Index = 3;
      ToolStripMenuItem4.Text = "-";
      miQuit.Index = 4;
      miQuit.Shortcut = Shortcut.CtrlQ;
      miQuit.Text = "&Quit";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(792, 517);
      ClientSize = size1;
      Controls.Add(tbSpeaker);
      Controls.Add(tbConversationText);
      Controls.Add(btnCollapseAll);
      Controls.Add(TabControl1);
      Controls.Add(Label1);
      Controls.Add(tvConversation);
      Controls.Add(Label2);
      Controls.Add(btnExpandAll);
      Controls.Add(btnSave);
      Controls.Add(btnTest);
      Controls.Add(btnOpen);
      Menu = MainMenu1;
      Name = nameof (frmDialogEditor);
      Text = "Conversation Editor";
      TabControl1.ResumeLayout(false);
      tabpagActionsTaken.ResumeLayout(false);
      tabpagCamera.ResumeLayout(false);
      nudCamFieldOfView.EndInit();
      nudFadeColorG.EndInit();
      nudFadeColorB.EndInit();
      nudFadeColorR.EndInit();
      nudCameraID.EndInit();
      nudCamHeightOffset.EndInit();
      nudCameraAngle.EndInit();
      nudTarHeightOffset.EndInit();
      nudFadeDelay.EndInit();
      nudFadeLength.EndInit();
      tabpagAnimationSound.ResumeLayout(false);
      dgAnimList.EndInit();
      tabpagPlot.ResumeLayout(false);
      nudPlotIndex.EndInit();
      nudPlotXPPercentage.EndInit();
      nudQuestEntry.EndInit();
      tabpagComment.ResumeLayout(false);
      tabpagThisFile1.ResumeLayout(false);
      nudDelayEntry.EndInit();
      nudDelayReply.EndInit();
      tabpagThisFile2.ResumeLayout(false);
      dgStuntList.EndInit();
      tabpagDebug.ResumeLayout(false);
      trkbTVIndent.EndInit();
      trkbTVItemHeight.EndInit();
      ResumeLayout(false);
    }

  public frmDialogEditor(string EditingPath, int KotorVerIndex)
    : this()
  {
      string filepath = EditingPath;
      TreeView tvConversation = this.tvConversation;
      ref TreeView local = ref tvConversation;
      int KotorVerIndex1 = KotorVerIndex;
      clsDLG clsDlg = new clsDLG(filepath, ref local, KotorVerIndex1);
      this.tvConversation = tvConversation;
      clsdlg = clsDlg;
      filename = Path.GetFileNameWithoutExtension(EditingPath);
      EditingFilePath = EditingPath;
      gff = clsdlg.dlgGff;
      SetFormToDLGRootItems();
    }

  public frmDialogEditor(FileStream fs, int KotorVerIndex)
    : this()
  {
      FileStream fs1 = fs;
      TreeView tvConversation = this.tvConversation;
      ref TreeView local = ref tvConversation;
      int KotorVerIndex1 = KotorVerIndex;
      clsDLG clsDlg = new clsDLG(fs1, ref local, KotorVerIndex1);
      this.tvConversation = tvConversation;
      clsdlg = clsDlg;
      filename = Path.GetFileNameWithoutExtension(fs.Name);
      gff = clsdlg.dlgGff;
      SetFormToDLGRootItems();
    }

  public frmDialogEditor(byte[] bytes, string file_name, int KotorVerIndex)
    : this()
  {
      byte[] bytes1 = bytes;
      TreeView tvConversation = this.tvConversation;
      ref TreeView local = ref tvConversation;
      int KotorVerIndex1 = KotorVerIndex;
      clsDLG clsDlg = new clsDLG(bytes1, ref local, KotorVerIndex1);
      this.tvConversation = tvConversation;
      clsdlg = clsDlg;
      filename = file_name;
      gff = clsdlg.dlgGff;
      SetFormToDLGRootItems();
    }

  public void SetupForNewDialog()
  {
      this.tvConversation.Nodes.Clear();
      TreeView tvConversation = this.tvConversation;
      clsDLG clsDlg = new clsDLG(ref tvConversation, KotorVersionIndex);
      this.tvConversation = tvConversation;
      clsdlg = clsDlg;
      gff = clsdlg.dlgGff;
      gff.AddFieldToStruct("", "DelayEntry", 4, 0);
      gff.AddFieldToStruct("", "DelayReply", 4, 0);
      gff.AddFieldToStruct("", "EndConversation", 11, "");
      gff.AddFieldToStruct("", "EndConverAbort", 11, "");
      gff.AddFieldToStruct("", "Skippable", 0, 0);
      gff.AddFieldToStruct("", "CameraModel", 11, "");
      gff.AddFieldToStruct("", "VO_ID", 10, "");
      gff.AddFieldToStruct("", "ConversationType", 5, 0);
      gff.AddFieldToStruct("", "ComputerType", 0, 0);
      gff.AddFieldToStruct("", "OldHitCheck", 0, 0);
      gff.AddFieldToStruct("", "AmbientTrack", 11, "");
      gff.AddFieldToStruct("", "UnequipItems", 0, 0);
      gff.AddFieldToStruct("", "AnimatedCut", 0, 0);
      gff.AddFieldToStruct("", "UnequipHItem", 0, 0);
    }

  private void SaveFile()
  {
      Cursor current = Cursor.Current;
      Cursor.Current = Cursors.WaitCursor;
      EntryList = new ArrayList();
      ReplyList = new ArrayList();
      gff.ClearListElements("EntryList");
      gff.ClearListElements("ReplyList");
      gff.ClearListElements("StartingList");
      gff.ClearListElements("StuntList");
      SeparateNodes((DLGConvListNode) tvConversation.Nodes[0], "Entry");
      try
      {
        foreach (DLGConvListNode entry in EntryList)
        {
          this.@struct = CreateGFFStructFromNode(entry);
          int num1 = 0;
          this.@struct.type = num1;
          gff.AddListElement("EntryList", this.@struct);
          gff.CreateList("EntryList(" + StringType.FromInteger(num1) + ")", "AnimList");
          if (entry.Animlist != null)
          {
            int num2 = checked (entry.Animlist.Count - 1);
            int index = 0;
            while (index <= num2)
            {
              GffStruct @struct = new GffStruct(2, 0);
              @struct.fields[0] = new GFF_Field(GFFField.GFF_CExoString, "Participant", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(entry.Animlist[index], null, "Participant", new object[0], null, null)));
              @struct.fields[1] = new GFF_Field(GFFField.GFF_word, "Animation", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(entry.Animlist[index], null, "Animation", new object[0], null, null)));
              gff.AddListElement("EntryList(" + StringType.FromInteger(num1) + ").AnimList", @struct);
              checked { ++index; }
            }
          }
          gff.CreateList("EntryList(" + StringType.FromInteger(num1) + ")", "RepliesList");
          checked { ++num1; }
        }
      }
      finally
      {
      
      }
      int num3 = 0;
      try
      {
        foreach (DLGConvListNode reply in ReplyList)
        {
          this.@struct = CreateGFFStructFromNode(reply);
          this.@struct.type = num3;
          gff.AddListElement("ReplyList", this.@struct);
          gff.CreateList("ReplyList(" + StringType.FromInteger(num3) + ")", "EntriesList");
          gff.CreateList("ReplyList(" + StringType.FromInteger(num3) + ")", "AnimList");
          if (reply.Animlist != null)
          {
            int num4 = checked (reply.Animlist.Count - 1);
            int index = 0;
            while (index <= num4)
            {
              GffStruct @struct = new GffStruct(2, 0);
              @struct.fields[0] = new GFF_Field(GFFField.GFF_CExoString, "Participant", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(reply.Animlist[index], null, "Participant", new object[0], null, null)));
              @struct.fields[1] = new GFF_Field(GFFField.GFF_word, "Animation", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(reply.Animlist[index], null, "Animation", new object[0], null, null)));
              gff.AddListElement("ReplyList(" + StringType.FromInteger(num3) + ").AnimList", @struct);
              checked { ++index; }
            }
          }
          checked { ++num3; }
        }
      }
      finally
      {
        
      }
      try
      {
        foreach (DLGConvListNode node in tvConversation.Nodes[0].Nodes)
        {
          BuildGFFLists(node, "Entry");
          GffStruct @struct = new GffStruct(2);
          @struct.fields[0] = new GFF_Field(GFFField.GFF_dword, "Index", EntryList.IndexOf(node));
          string FieldValue = node.ActiveScript != null ? node.ActiveScript : "";
          @struct.fields[1] = new GFF_Field(GFFField.GFF_CResRef, "Active", FieldValue);
          gff.AddListElement("StartingList", @struct);
        }
      }
      finally
      {
      
      }
      SetDLGRootItemsValues();
      Cursor.Current = current;
      string str = StringType.StrCmp(EditingFilePath, "", false) == 0 ? StringType.FromObject(FrmMain.GetFilePath("save", FrmMain.CurrentSettings.defaultSaveLocation, filename + ".dlg", "", "")) : EditingFilePath;
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      gff.WriteFile(str, "DLG");
      gff = clsdlg.dlgGff;
      SetFormToDLGRootItems();
      Text = "Conversation Editor - " + Path.GetFileNameWithoutExtension(str) + ".dlg";
    }

  private void SetDLGRootItemsValues()
  {
      if (!gff.VerifyNodeExists("DelayEntry"))
        gff.AddFieldToStruct("", "DelayEntry", 4, 0);
      if (!gff.VerifyNodeExists("DelayReply"))
        gff.AddFieldToStruct("", "DelayReply", 4, 0);
      if (!gff.VerifyNodeExists("EndConversation"))
        gff.AddFieldToStruct("", "EndConversation", 11, "");
      if (!gff.VerifyNodeExists("EndConverAbort"))
        gff.AddFieldToStruct("", "EndConverAbort", 11, "");
      if (!gff.VerifyNodeExists("Skippable"))
        gff.AddFieldToStruct("", "Skippable", 0, 0);
      if (!gff.VerifyNodeExists("CameraModel"))
        gff.AddFieldToStruct("", "CameraModel", 11, "");
      if (!gff.VerifyNodeExists("VO_ID"))
        gff.AddFieldToStruct("", "VO_ID", 10, "");
      if (!gff.VerifyNodeExists("ConversationType"))
        gff.AddFieldToStruct("", "ConversationType", 5, 0);
      if (cmbxConversationType.SelectedIndex == 1 && !gff.VerifyNodeExists("ComputerType"))
        gff.AddFieldToStruct("", "ComputerType", 0, 0);
      if (!gff.VerifyNodeExists("OldHitCheck"))
        gff.AddFieldToStruct("", "OldHitCheck", 0, 0);
      if (!gff.VerifyNodeExists("AmbientTrack"))
        gff.AddFieldToStruct("", "AmbientTrack", 11, "");
      if (!gff.VerifyNodeExists("UnequipItems"))
        gff.AddFieldToStruct("", "UnequipItems", 0, 0);
      if (!gff.VerifyNodeExists("UnequipHItem"))
        gff.AddFieldToStruct("", "UnequipHItem", 0, 0);
      if (!gff.VerifyNodeExists("StuntList"))
        gff.CreateList("", "StuntList");
      gff.SetNodeValue("DelayEntry", nudDelayEntry.Value);
      gff.SetNodeValue("DelayReply", nudDelayReply.Value);
      gff.SetNodeValue("EndConversation", tbEndConversation.Text.Trim());
      gff.SetNodeValue("EndConverAbort", tbEndConverAbort.Text.Trim());
      gff.SetNodeValue("Skippable", chkbSkippable.Checked);
      gff.SetNodeValue("VO_ID", tbVO_ID.Text.Trim());
      gff.SetNodeValue("ConversationType", cmbxConversationType.SelectedIndex);
      if (cmbxConversationType.SelectedIndex == 1)
        gff.SetNodeValue("ComputerType", checked ((byte) cmbxComputerType.SelectedIndex));
      gff.SetNodeValue("AmbientTrack", tbAmbientTrack.Text.Trim());
      gff.SetNodeValue("UnequipItems", chkbUnequipItems.Checked);
      gff.SetNodeValue("UnequipHItem", chkbUnequipHItem.Checked);
      if (gff.VerifyNodeExists("AnimatedCut"))
      {
        chkbAnimatedCut.Checked = BooleanType.FromObject(gff.GetNodeValue("AnimatedCut"));
        if (!gff.VerifyNodeExists("CameraModel"))
          gff.AddFieldToStruct("", "CameraModel", 11, "");
        gff.SetNodeValueFromTextBox(tbCameraModel, "CameraModel");
      }
      else if (chkbAnimatedCut.Checked)
      {
        if (!gff.VerifyNodeExists("AnimatedCut"))
          gff.AddFieldToStruct("", "AnimatedCut", 0, 0);
        gff.SetNodeValue("AnimatedCut", 1);
        if (!gff.VerifyNodeExists("CameraModel"))
          gff.AddFieldToStruct("", "CameraModel", 11, "");
        gff.SetNodeValueFromTextBox(tbCameraModel, "CameraModel");
      }
      int num = checked (DViewStunt.Table.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        GffStruct @struct = new GffStruct(2, 0);
        @struct.fields[0] = new GFF_Field(GFFField.GFF_CExoString, "Participant", RuntimeHelpers.GetObjectValue(DViewStunt.Table.Rows[index]["Participant"]));
        @struct.fields[1] = new GFF_Field(GFFField.GFF_CResRef, "StuntModel", RuntimeHelpers.GetObjectValue(DViewStunt.Table.Rows[index]["StuntModel"]));
        gff.AddListElement("StuntList", @struct);
        checked { ++index; }
      }
    }

  private void SetFormToDLGRootItems()
  {
      gff.SetNumericUpDownToUIntNodeValue(nudDelayEntry, "DelayEntry");
      gff.SetNumericUpDownToUIntNodeValue(nudDelayReply, "DelayReply");
      gff.SetTextBoxToNodeValue(tbEndConversation, "EndConversation");
      gff.SetTextBoxToNodeValue(tbEndConverAbort, "EndConverAbort");
      chkbSkippable.Checked = BooleanType.FromObject(gff.GetNodeValue("Skippable"));
      chkbUnequipItems.Checked = BooleanType.FromObject(gff.GetNodeValue("UnequipItems"));
      chkbUnequipHItem.Checked = BooleanType.FromObject(gff.GetNodeValue("UnequipHItem"));
      gff.SetTextBoxToNodeValue(tbVO_ID, "VO_ID");
      cmbxConversationType.SelectedIndex = IntegerType.FromObject(gff.GetNodeValue("ConversationType"));
      if (cmbxConversationType.SelectedIndex == 1)
        cmbxComputerType.SelectedIndex = IntegerType.FromObject(gff.GetNodeValue("ComputerType"));
      gff.SetTextBoxToNodeValue(tbAmbientTrack, "AmbientTrack");
      gff.SetTextBoxToNodeValue(tbCameraModel, "CameraModel");
      chkbAnimatedCut.Checked = BooleanType.FromObject(gff.GetNodeValue("AnimatedCut"));
      if (!gff.VerifyNodeExists("StuntList") || gff.GetListItemCount("StuntList") <= 0)
        return;
      int num1 = checked (gff.GetListItemCount("StuntList") - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        DataRow row = dtStunt.NewRow();
        row[0] = RuntimeHelpers.GetObjectValue(gff.GetNodeValue("StuntList(" + StringType.FromInteger(num2) + ").Participant"));
        row[1] = RuntimeHelpers.GetObjectValue(gff.GetNodeValue("StuntList(" + StringType.FromInteger(num2) + ").StuntModel"));
        dtStunt.Rows.Add(row);
        checked { ++num2; }
      }
    }

  private GffStruct CreateGFFStructFromNode(DLGConvListNode tn)
  {
      GffStruct gffStructFromNode = new GffStruct()
      {
        fieldCount = 4
      };
      gffStructFromNode.fields = new GFF_Field[checked (gffStructFromNode.fieldCount - 1 + 1)];
      GFFExoLocString FieldValue = new GFFExoLocString();
      FieldValue.StringCount = 1;
      FieldValue.StringRef = -1;
      FieldValue.subStringArr = (object[]) Array.CreateInstance(typeof (object), 1);
      FieldValue.subStringArr[0] = new GFFExoLocSubString()
      {
        StringID = 0,
        StringLength = tn.InternalText.Length,
        value = tn.InternalText
      };
      FieldValue.size = checked (16 + tn.InternalText.Length);
      gffStructFromNode.fields[0] = new GFF_Field(GFFField.GFF_CExoLocString, "Text", FieldValue);
      gffStructFromNode.fields[1] = new GFF_Field(GFFField.GFF_dword, "Delay", (long) uint.MaxValue);
      gffStructFromNode.fields[2] = new GFF_Field(GFFField.GFF_dword, "WaitFlags", 0);
      gffStructFromNode.fields[3] = new GFF_Field(GFFField.GFF_byte, "FadeType", tn.FadeType);
      if (StringType.StrCmp(tn.Script, null, false) != 0 && StringType.StrCmp(tn.Script, "", false) != 0)
      {
        gffStructFromNode.fields = (GFF_Field[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStructFromNode.fields, new GFF_Field[checked (gffStructFromNode.fieldCount + 1)]);
        gffStructFromNode.fields[gffStructFromNode.fieldCount] = new GFF_Field(GFFField.GFF_CResRef, "Script", tn.Script);
        checked { ++gffStructFromNode.fieldCount; }
      }
      if (StringType.StrCmp(tn.Sound, null, false) != 0 && StringType.StrCmp(tn.Sound, "", false) != 0)
      {
        gffStructFromNode.fields = (GFF_Field[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStructFromNode.fields, new GFF_Field[checked (gffStructFromNode.fieldCount + 1)]);
        gffStructFromNode.fields[gffStructFromNode.fieldCount] = new GFF_Field(GFFField.GFF_CResRef, "Sound", tn.Sound);
        checked { ++gffStructFromNode.fieldCount; }
      }
      if (StringType.StrCmp(tn.VO_ResRef, null, false) != 0 && StringType.StrCmp(tn.VO_ResRef, "", false) != 0)
      {
        gffStructFromNode.fields = (GFF_Field[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStructFromNode.fields, new GFF_Field[checked (gffStructFromNode.fieldCount + 1)]);
        gffStructFromNode.fields[gffStructFromNode.fieldCount] = new GFF_Field(GFFField.GFF_CResRef, "VO_ResRef", tn.VO_ResRef);
        checked { ++gffStructFromNode.fieldCount; }
      }
      if (StringType.StrCmp(tn.Speaker, null, false) != 0 && StringType.StrCmp(tn.Speaker, "", false) != 0)
      {
        gffStructFromNode.fields = (GFF_Field[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStructFromNode.fields, new GFF_Field[checked (gffStructFromNode.fieldCount + 1)]);
        gffStructFromNode.fields[gffStructFromNode.fieldCount] = new GFF_Field(GFFField.GFF_CExoString, "Speaker", tn.Speaker);
        checked { ++gffStructFromNode.fieldCount; }
      }
      if (StringType.StrCmp(tn.Comment, null, false) != 0 && StringType.StrCmp(tn.Comment, "", false) != 0)
      {
        gffStructFromNode.fields = (GFF_Field[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStructFromNode.fields, new GFF_Field[checked (gffStructFromNode.fieldCount + 1)]);
        gffStructFromNode.fields[gffStructFromNode.fieldCount] = new GFF_Field(GFFField.GFF_CExoString, "Comment", tn.Comment);
        checked { ++gffStructFromNode.fieldCount; }
      }
      if (StringType.StrCmp(tn.Listener, null, false) != 0 && StringType.StrCmp(tn.Listener, "", false) != 0)
      {
        gffStructFromNode.fields = (GFF_Field[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStructFromNode.fields, new GFF_Field[checked (gffStructFromNode.fieldCount + 1)]);
        gffStructFromNode.fields[gffStructFromNode.fieldCount] = new GFF_Field(GFFField.GFF_CExoString, "Listener", tn.Listener);
        checked { ++gffStructFromNode.fieldCount; }
      }
      if (tn.CameraAngle > 0)
      {
        gffStructFromNode.fields = (GFF_Field[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStructFromNode.fields, new GFF_Field[checked (gffStructFromNode.fieldCount + 1)]);
        gffStructFromNode.fields[gffStructFromNode.fieldCount] = new GFF_Field(GFFField.GFF_dword, "CameraAngle", tn.CameraAngle);
        checked { ++gffStructFromNode.fieldCount; }
      }
      if (StringType.StrCmp(tn.Quest, null, false) != 0 && StringType.StrCmp(tn.Quest, "", false) != 0)
      {
        gffStructFromNode.fields = (GFF_Field[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStructFromNode.fields, new GFF_Field[checked (gffStructFromNode.fieldCount + 1 + 1)]);
        gffStructFromNode.fields[gffStructFromNode.fieldCount] = new GFF_Field(GFFField.GFF_CExoString, "Quest", tn.Quest);
        gffStructFromNode.fields[checked (gffStructFromNode.fieldCount + 1)] = new GFF_Field(GFFField.GFF_dword, "QuestEntry", tn.QuestEntry);
        checked { gffStructFromNode.fieldCount += 2; }
      }
      if (tn.FadeType > 0)
      {
        gffStructFromNode.fields = (GFF_Field[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStructFromNode.fields, new GFF_Field[checked (gffStructFromNode.fieldCount + 2 + 1)]);
        gffStructFromNode.fields[gffStructFromNode.fieldCount] = new GFF_Field(GFFField.GFF_float, "FadeDelay", tn.FadeDelay);
        gffStructFromNode.fields[checked (gffStructFromNode.fieldCount + 1)] = new GFF_Field(GFFField.GFF_float, "FadeLength", tn.FadeLength);
        if (tn.FadeColor == null)
        {
          tn.FadeColor = new GFFType17();
          tn.FadeColor.f1 = 0.0f;
          tn.FadeColor.f2 = 0.0f;
          tn.FadeColor.f3 = 0.0f;
        }
        gffStructFromNode.fields[checked (gffStructFromNode.fieldCount + 2)] = new GFF_Field(GFFField.GFF_Type17, "FadeColor", tn.FadeColor);
        checked { gffStructFromNode.fieldCount += 3; }
      }
      gffStructFromNode.fields = (GFF_Field[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStructFromNode.fields, new GFF_Field[checked (gffStructFromNode.fieldCount + 1 + 1)]);
      gffStructFromNode.fields[gffStructFromNode.fieldCount] = new GFF_Field(GFFField.GFF_int, "CameraID", tn.CameraID);
      gffStructFromNode.fields[checked (gffStructFromNode.fieldCount + 1)] = new GFF_Field(GFFField.GFF_int, "CamVidEffect", tn.CamVidEffect);
      checked { gffStructFromNode.fieldCount += 2; }
      return gffStructFromNode;
    }

  private void RemoveChildLinks(DLGConvListNode parentNode)
  {
      try
      {
        foreach (DLGConvListNode node in parentNode.Nodes)
          RemoveChildLinks(node);
      }
      finally
      {
       
      }
      if (parentNode.IsLink <= 0)
        return;
      parentNode.LinkedToNode.LinkedNodesList.Remove(parentNode);
    }

  private void ResetChildNodesDescAfterPasteTree(DLGConvListNode parentNode)
  {
      try
      {
        foreach (DLGConvListNode node in parentNode.Nodes)
        {
          if (parentNode.IsReply)
            node.IsEntry = true;
          else
            node.IsReply = true;
          node.ForeColor = node.DialogColor;
          ResetChildNodesDescAfterPasteTree(node);
        }
      }
      finally
      {
      
      }
      if (parentNode == tvConversation.Nodes[0])
        return;
      parentNode.Text = parentNode.NodeDesc;
    }

  private void SeparateNodes(DLGConvListNode innode, string CurrNodeType)
  {
      try
      {
        foreach (DLGConvListNode node in innode.Nodes)
        {
          if (StringType.StrCmp(CurrNodeType, "Entry", false) == 0)
          {
            EntryList.Add(node);
            SeparateNodes(node, "Reply");
          }
          else
          {
            ReplyList.Add(node);
            SeparateNodes(node, "Entry");
          }
        }
      }
      finally
      {
      
      }
    }

  private void BuildGFFLists(DLGConvListNode parentNode, string CurrNodeType)
  {
      try
      {
        foreach (DLGConvListNode node in parentNode.Nodes)
        {
          if (StringType.StrCmp(CurrNodeType, "Entry", false) == 0)
          {
            GffStruct @struct = new GffStruct(3);
            @struct.fields[0] = node.IsLink <= 0 ? new GFF_Field(GFFField.GFF_dword, "Index", ReplyList.IndexOf(node)) : new GFF_Field(GFFField.GFF_dword, "Index", ReplyList.IndexOf(node.LinkedToNode));
            @struct.fields[1] = new GFF_Field(GFFField.GFF_CResRef, "Active", node.ActiveScript);
            @struct.fields[2] = new GFF_Field(GFFField.GFF_byte, "IsChild", node.IsLink);
            gff.AddListElement("EntryList(" + StringType.FromInteger(EntryList.IndexOf(parentNode)) + ").RepliesList", @struct);
            if (~node.IsLink > 0)
              BuildGFFLists(node, "Reply");
          }
          else
          {
            GffStruct @struct = new GffStruct(3);
            @struct.fields[0] = node.IsLink <= 0 ? new GFF_Field(GFFField.GFF_dword, "Index", EntryList.IndexOf(node)) : new GFF_Field(GFFField.GFF_dword, "Index", EntryList.IndexOf(node.LinkedToNode));
            @struct.fields[1] = new GFF_Field(GFFField.GFF_CResRef, "Active", node.ActiveScript);
            @struct.fields[2] = new GFF_Field(GFFField.GFF_byte, "IsChild", node.IsLink);
            gff.AddListElement("ReplyList(" + StringType.FromInteger(ReplyList.IndexOf(parentNode)) + ").EntriesList", @struct);
            if (~node.IsLink > 0)
              BuildGFFLists(node, "Entry");
          }
        }
      }
      finally
      {
     
      }
    }

  public void BuildAnimDataGrid()
  {
      DataGridTableStyle table = new DataGridTableStyle();
      dgAnimList.TableStyles.Clear();
      table.MappingName = "ArrayList";
      table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
      DataGridTextBoxColumn column1 = new DataGridTextBoxColumn();
      column1.MappingName = "Participant";
      column1.HeaderText = "Participant";
      column1.Alignment = HorizontalAlignment.Center;
      column1.Width = 120;
      column1.NullText = "";
      column1.ReadOnly = false;
      table.GridColumnStyles.Add(column1);
      DataGridTextBoxColumn column2 = new DataGridTextBoxColumn();
      column2.MappingName = "Animation";
      column2.HeaderText = "Animation";
      column2.Alignment = HorizontalAlignment.Center;
      column2.Width = 75;
      column2.NullText = "";
      column2.TextBox.CharacterCasing = CharacterCasing.Lower;
      table.GridColumnStyles.Add(column2);
      dgAnimList.TableStyles.Add(table);
      dgAnimList.CaptionText = "Animation List";
      dgAnimList.CaptionFont = new Font("Microsoft Sans Serif", 9f);
    }

  public void BuildStuntDataTable()
  {
      dtStunt.Columns.Add(new DataColumn("Participant", typeof (string))
      {
        DefaultValue = ""
      });
      dtStunt.Columns.Add(new DataColumn("StuntModel", typeof (string))
      {
        DefaultValue = ""
      });
      dtStunt.TableName = "StuntList";
    }

  public void BuildStuntDataGrid()
  {
      BuildStuntDataTable();
      DViewStunt = dtStunt.DefaultView;
      DViewStunt.AllowDelete = true;
      DViewStunt.AllowNew = true;
      DViewStunt.AllowEdit = true;
      DataGridTableStyle table = new DataGridTableStyle();
      dgStuntList.TableStyles.Clear();
      table.MappingName = dtStunt.TableName;
      table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
      DataGridTextBoxColumn column1 = new DataGridTextBoxColumn();
      column1.MappingName = "Participant";
      column1.HeaderText = "Participant";
      column1.Alignment = HorizontalAlignment.Center;
      column1.Width = 120;
      column1.NullText = "";
      column1.ReadOnly = false;
      table.GridColumnStyles.Add(column1);
      DataGridTextBoxColumn column2 = new DataGridTextBoxColumn();
      column2.MappingName = "StuntModel";
      column2.HeaderText = "Model";
      column2.Alignment = HorizontalAlignment.Center;
      column2.Width = 120;
      column2.NullText = "";
      column2.TextBox.CharacterCasing = CharacterCasing.Lower;
      column2.TextBox.MaxLength = 16;
      table.GridColumnStyles.Add(column2);
      dgStuntList.TableStyles.Add(table);
      dgStuntList.SetDataBinding(DViewStunt, null);
      dgStuntList.CaptionText = "Stunt List";
      dgStuntList.CaptionFont = new Font("Microsoft Sans Serif", 9f);
    }

  private void btnExpandAll_Click(object sender, EventArgs e)
  {
      tvConversation.ExpandAll();
      tvConversation.SelectedNode = tvConversation.Nodes[0];
    }

  private void btnCollapseAll_Click(object sender, EventArgs e) => tvConversation.CollapseAll();

  private void btnDebug_Click(object sender, EventArgs e)
  {
      frmTextEditor frmTextEditor = new frmTextEditor();
      frmTextEditor.Filename = "dialog";
      frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
      frmTextEditor.RTFMode = true;
      frmTextEditor.tbGeneric.Rtf = clsdlg.ToString();
      frmTextEditor.tbGeneric.SelectionLength = 0;
      frmTextEditor.Show();
    }

  private void btnTest_Click(object sender, EventArgs e)
  {
      DLGConvListNode selectedNode = (DLGConvListNode) tvConversation.SelectedNode;
      DLGConvListNode parent = (DLGConvListNode) selectedNode.Parent;
      int num = parent.Nodes.IndexOf(selectedNode);
      parent.Nodes.Remove(selectedNode);
      parent.Nodes.Insert(checked (num - 1), selectedNode);
    }

  private void btnChooseColor_Click(object sender, EventArgs e)
  {
      ColorDialog colorDialog = new ColorDialog();
      DLGConvListNode selectedNode = (DLGConvListNode) tvConversation.SelectedNode;
      if (selectedNode.FadeColor == null)
      {
        selectedNode.FadeColor = new GFFType17();
        selectedNode.FadeColor.f1 = 0.0f;
        selectedNode.FadeColor.f2 = 0.0f;
        selectedNode.FadeColor.f3 = 0.0f;
      }
      colorDialog.AllowFullOpen = true;
      colorDialog.FullOpen = true;
      colorDialog.Color = Color.FromArgb(0, checked ((int) Math.Round(selectedNode.FadeColor.f1)), checked ((int) Math.Round(selectedNode.FadeColor.f2)), checked ((int) Math.Round(selectedNode.FadeColor.f3)));
      if (colorDialog.ShowDialog() != DialogResult.OK)
        return;
      nudFadeColorR.Text = StringType.FromByte(colorDialog.Color.R);
      nudFadeColorG.Text = StringType.FromByte(colorDialog.Color.G);
      nudFadeColorB.Text = StringType.FromByte(colorDialog.Color.B);
      selectedNode.FadeColor.f1 = Convert.ToSingle(colorDialog.Color.R);
      GFFType17 fadeColor1 = selectedNode.FadeColor;
      Color color = colorDialog.Color;
      double single1 = Convert.ToSingle(color.G);
      fadeColor1.f2 = (float) single1;
      GFFType17 fadeColor2 = selectedNode.FadeColor;
      color = colorDialog.Color;
      double single2 = Convert.ToSingle(color.B);
      fadeColor2.f3 = (float) single2;
    }

  private void WireUpEventHandlers()
  {
      tbConversationText.TextChanged += new EventHandler(tbConversationText_TextChanged);
      tbTextActiveScript.TextChanged += new EventHandler(tbTextActiveScript_TextChanged);
      tbActionsTakenScript.TextChanged += new EventHandler(tbActionsTakenScript_TextChanged);
      nudPlotIndex.ValueChanged += new EventHandler(nudPlotIndex_ValueChanged);
      nudPlotXPPercentage.ValueChanged += new EventHandler(nudPlotXPPercentage_ValueChanged);
      tbComments.TextChanged += new EventHandler(tbComments_TextChanged);
      nudCameraAngle.ValueChanged += new EventHandler(nudCameraAngle_ValueChanged);
      nudCamHeightOffset.ValueChanged += new EventHandler(nudCamHeightOffset_ValueChanged);
      nudTarHeightOffset.ValueChanged += new EventHandler(nudTarHeightOffset_ValueChanged);
      tbListener.TextChanged += new EventHandler(tbListener_TextChanged);
      nudFadeDelay.ValueChanged += new EventHandler(nudFadeDelay_ValueChanged);
      nudFadeLength.ValueChanged += new EventHandler(nudFadeLength_ValueChanged);
      nudFadeColorR.ValueChanged += new EventHandler(nudFadeColorR_ValueChanged);
      nudFadeColorG.ValueChanged += new EventHandler(nudFadeColorG_ValueChanged);
      nudFadeColorB.ValueChanged += new EventHandler(nudFadeColorB_ValueChanged);
      tbSound.TextChanged += new EventHandler(tbSound_TextChanged);
      tbSpeaker.TextChanged += new EventHandler(tbSpeaker_TextChanged);
      tbVoiceOverResRef.TextChanged += new EventHandler(tbVoiceOverResRef_TextChanged);
      nudCameraID.ValueChanged += new EventHandler(nudCameraID_ValueChanged);
      cmbxCamVidEffect.SelectedIndexChanged += new EventHandler(cmbxCamVidEffect_SelectedIndexChanged);
      nudPlotIndex.Validated += new EventHandler(nudPlotIndex_ValueChanged);
      nudPlotXPPercentage.Validated += new EventHandler(nudPlotXPPercentage_ValueChanged);
      nudCameraAngle.Validated += new EventHandler(nudCameraAngle_ValueChanged);
      nudCamHeightOffset.Validated += new EventHandler(nudCamHeightOffset_ValueChanged);
      nudTarHeightOffset.Validated += new EventHandler(nudTarHeightOffset_ValueChanged);
      nudFadeDelay.Validated += new EventHandler(nudFadeDelay_ValueChanged);
      nudFadeLength.Validated += new EventHandler(nudFadeLength_ValueChanged);
      nudFadeColorR.Validated += new EventHandler(nudFadeColorR_ValueChanged);
      nudFadeColorG.Validated += new EventHandler(nudFadeColorG_ValueChanged);
      nudFadeColorB.Validated += new EventHandler(nudFadeColorB_ValueChanged);
      nudCameraID.Validated += new EventHandler(nudCameraID_ValueChanged);
      nudFadeColorB.ValueChanged += new EventHandler(nudFadeColorB_ValueChanged);
      tbQuest.TextChanged += new EventHandler(tbQuest_TextChanged);
      nudQuestEntry.Validated += new EventHandler(nudQuestEntry_ValueChanged);
      cmbxFadeType.SelectedIndexChanged += new EventHandler(cmbxFadeType_SelectedIndexChanged);
      nudCamFieldOfView.ValueChanged += new EventHandler(nudCamFieldOfView_ValueChanged);
      nudCamFieldOfView.Validated += new EventHandler(nudCamFieldOfView_ValueChanged);
    }

  private void DisconnectEventHandlers()
  {
      tbConversationText.TextChanged -= new EventHandler(tbConversationText_TextChanged);
      tbTextActiveScript.TextChanged -= new EventHandler(tbTextActiveScript_TextChanged);
      tbActionsTakenScript.TextChanged -= new EventHandler(tbActionsTakenScript_TextChanged);
      nudPlotIndex.ValueChanged -= new EventHandler(nudPlotIndex_ValueChanged);
      nudPlotXPPercentage.ValueChanged -= new EventHandler(nudPlotXPPercentage_ValueChanged);
      tbComments.TextChanged -= new EventHandler(tbComments_TextChanged);
      nudCameraAngle.ValueChanged -= new EventHandler(nudCameraAngle_ValueChanged);
      nudCamHeightOffset.ValueChanged -= new EventHandler(nudCamHeightOffset_ValueChanged);
      nudTarHeightOffset.ValueChanged -= new EventHandler(nudTarHeightOffset_ValueChanged);
      tbListener.TextChanged -= new EventHandler(tbListener_TextChanged);
      nudFadeDelay.ValueChanged -= new EventHandler(nudFadeDelay_ValueChanged);
      nudFadeLength.ValueChanged -= new EventHandler(nudFadeLength_ValueChanged);
      nudFadeColorR.ValueChanged -= new EventHandler(nudFadeColorR_ValueChanged);
      nudFadeColorG.ValueChanged -= new EventHandler(nudFadeColorG_ValueChanged);
      nudFadeColorB.ValueChanged -= new EventHandler(nudFadeColorB_ValueChanged);
      tbSound.TextChanged -= new EventHandler(tbSound_TextChanged);
      tbSpeaker.TextChanged -= new EventHandler(tbSpeaker_TextChanged);
      tbVoiceOverResRef.TextChanged -= new EventHandler(tbVoiceOverResRef_TextChanged);
      nudCameraID.ValueChanged -= new EventHandler(nudCameraID_ValueChanged);
      cmbxCamVidEffect.SelectedIndexChanged -= new EventHandler(cmbxCamVidEffect_SelectedIndexChanged);
      nudPlotIndex.Validated -= new EventHandler(nudPlotIndex_ValueChanged);
      nudPlotXPPercentage.Validated -= new EventHandler(nudPlotXPPercentage_ValueChanged);
      nudCameraAngle.Validated -= new EventHandler(nudCameraAngle_ValueChanged);
      nudCamHeightOffset.Validated -= new EventHandler(nudCamHeightOffset_ValueChanged);
      nudTarHeightOffset.Validated -= new EventHandler(nudTarHeightOffset_ValueChanged);
      nudFadeDelay.Validated -= new EventHandler(nudFadeDelay_ValueChanged);
      nudFadeLength.Validated -= new EventHandler(nudFadeLength_ValueChanged);
      nudFadeColorR.Validated -= new EventHandler(nudFadeColorR_ValueChanged);
      nudFadeColorG.Validated -= new EventHandler(nudFadeColorG_ValueChanged);
      nudFadeColorB.Validated -= new EventHandler(nudFadeColorB_ValueChanged);
      nudCameraID.Validated -= new EventHandler(nudCameraID_ValueChanged);
      tbQuest.TextChanged -= new EventHandler(tbQuest_TextChanged);
      nudQuestEntry.Validated -= new EventHandler(nudQuestEntry_ValueChanged);
      cmbxFadeType.SelectedIndexChanged -= new EventHandler(cmbxFadeType_SelectedIndexChanged);
      nudCamFieldOfView.ValueChanged -= new EventHandler(nudCamFieldOfView_ValueChanged);
      nudCamFieldOfView.Validated -= new EventHandler(nudCamFieldOfView_ValueChanged);
    }

  private void tbConversationText_TextChanged(object sender, EventArgs e)
  {
      DLGConvListNode selectedNode = (DLGConvListNode) tvConversation.SelectedNode;
      selectedNode.InternalText = tbConversationText.Text;
      selectedNode.Text = selectedNode.NodeDesc;
      selectedNode.UpdateLinkedNodesText();
    }

  private void tbTextActiveScript_TextChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).ActiveScript = tbTextActiveScript.Text.Trim();

  private void tbActionsTakenScript_TextChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).Script = tbActionsTakenScript.Text.Trim();

  private void nudPlotIndex_ValueChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).PlotIndex = IntegerType.FromString(nudPlotIndex.Text.Trim());

  private void nudPlotXPPercentage_ValueChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).PlotXPPercentage = nudPlotXPPercentage.Value;

  private void tbComments_TextChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).Comment = tbComments.Text.Trim();

  private void nudCameraAngle_ValueChanged(object sender, EventArgs e)
  {
      DLGConvListNode selectedNode = (DLGConvListNode) tvConversation.SelectedNode;
      selectedNode.CameraAngle = Convert.ToInt32(nudCameraAngle.Value);
      if (selectedNode.CameraAngle == 6)
      {
        cmbxCamVidEffect.Enabled = true;
        switch (selectedNode.CamVidEffect)
        {
          case -1:
            cmbxCamVidEffect.SelectedIndex = 0;
            break;
          case 0:
            cmbxCamVidEffect.SelectedIndex = 1;
            break;
          case 2:
            cmbxCamVidEffect.SelectedIndex = 2;
            break;
          default:
            cmbxCamVidEffect.SelectedIndex = 0;
            break;
        }
      }
      else
      {
        cmbxCamVidEffect.Enabled = false;
        cmbxCamVidEffect.SelectedIndex = 0;
      }
    }

  private void nudCamHeightOffset_ValueChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).CamHeightOffset = nudCamHeightOffset.Value;

  private void nudTarHeightOffset_ValueChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).CamHeightOffset = nudTarHeightOffset.Value;

  private void tbListener_TextChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).Listener = tbListener.Text.Trim();

  private void nudFadeDelay_ValueChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).FadeDelay = nudFadeDelay.Value;

  private void nudFadeLength_ValueChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).FadeLength = nudFadeLength.Value;

  private void nudFadeColorR_ValueChanged(object sender, EventArgs e)
  {
      DLGConvListNode selectedNode = (DLGConvListNode) tvConversation.SelectedNode;
      if (selectedNode.FadeColor == null)
        selectedNode.FadeColor = new GFFType17();
      selectedNode.FadeColor.f1 = Convert.ToSingle(nudFadeColorR.Value);
      selectedNode.FadeColor.f2 = Convert.ToSingle(nudFadeColorG.Value);
      selectedNode.FadeColor.f3 = Convert.ToSingle(nudFadeColorB.Value);
    }

  private void nudFadeColorG_ValueChanged(object sender, EventArgs e)
  {
      DLGConvListNode selectedNode = (DLGConvListNode) tvConversation.SelectedNode;
      if (selectedNode.FadeColor == null)
        selectedNode.FadeColor = new GFFType17();
      selectedNode.FadeColor.f1 = Convert.ToSingle(nudFadeColorR.Value);
      selectedNode.FadeColor.f2 = Convert.ToSingle(nudFadeColorG.Value);
      selectedNode.FadeColor.f3 = Convert.ToSingle(nudFadeColorB.Value);
    }

  private void nudFadeColorB_ValueChanged(object sender, EventArgs e)
  {
      DLGConvListNode selectedNode = (DLGConvListNode) tvConversation.SelectedNode;
      if (selectedNode.FadeColor == null)
        selectedNode.FadeColor = new GFFType17();
      selectedNode.FadeColor.f1 = Convert.ToSingle(nudFadeColorR.Value);
      selectedNode.FadeColor.f2 = Convert.ToSingle(nudFadeColorG.Value);
      selectedNode.FadeColor.f3 = Convert.ToSingle(nudFadeColorB.Value);
    }

  private void tbSound_TextChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).Sound = tbSound.Text.Trim();

  private void tbSpeaker_TextChanged(object sender, EventArgs e)
  {
      DLGConvListNode selectedNode = (DLGConvListNode) tvConversation.SelectedNode;
      selectedNode.Speaker = tbSpeaker.Text.Trim();
      selectedNode.Text = selectedNode.NodeDesc;
    }

  private void tbVoiceOverResRef_TextChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).VO_ResRef = tbVoiceOverResRef.Text.Trim();

  private void nudCameraID_ValueChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).CameraID = Convert.ToInt32(nudCameraID.Value);

  private void nudCamFieldOfView_ValueChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).CamFieldOfView = nudCamFieldOfView.Value;

  private void cmbxCamVidEffect_SelectedIndexChanged(object sender, EventArgs e)
  {
      DLGConvListNode selectedNode = (DLGConvListNode) tvConversation.SelectedNode;
      switch (cmbxCamVidEffect.SelectedIndex)
      {
        case 0:
          selectedNode.CamVidEffect = -1;
          break;
        case 1:
          selectedNode.CamVidEffect = 0;
          break;
        case 2:
          selectedNode.CamVidEffect = 2;
          break;
      }
    }

  private void tbQuest_TextChanged(object sender, EventArgs e)
  {
      ((DLGConvListNode) tvConversation.SelectedNode).Quest = tbQuest.Text.Trim();
      nudQuestEntry.Enabled = StringType.StrCmp(tbQuest.Text.Trim(), "", false) != 0;
    }

  private void nudQuestEntry_ValueChanged(object sender, EventArgs e) => ((DLGConvListNode) tvConversation.SelectedNode).QuestEntry = Convert.ToUInt32(nudQuestEntry.Value);

  private void cmbxFadeType_SelectedIndexChanged(object sender, EventArgs e)
  {
      ((DLGConvListNode) tvConversation.SelectedNode).FadeType = cmbxFadeType.SelectedIndex;
      bool flag = cmbxFadeType.SelectedIndex > 0;
      nudFadeDelay.Enabled = flag;
      nudFadeLength.Enabled = flag;
      nudFadeColorR.Enabled = flag;
      nudFadeColorG.Enabled = flag;
      nudFadeColorB.Enabled = flag;
    }

  private void tvConversation_MouseDown(object sender, MouseEventArgs e) => LastClickedTvConversationNode = (DLGConvListNode) tvConversation.GetNodeAt(new Point(e.X, e.Y));

  private void tvConversation_MouseUp(object sender, MouseEventArgs e)
  {
      Point pos = new Point(e.X, e.Y);
      DLGConvListNode conversationNode = LastClickedTvConversationNode;
      if (conversationNode != null)
        CurrentContextMenuTvConversationNode = conversationNode;
      if (e.Button == MouseButtons.Right)
      {
        if (conversationNode == null)
          return;
        AdjustContextToolStripMenuItems();
        cmTVfunctions.Show(tvConversation, pos);
        tvConversation.SelectedNode = CurrentContextMenuTvConversationNode;
      }
      else if (e.Button != MouseButtons.Left || conversationNode == null || e.X >= conversationNode.Bounds.Left)
        ;
    }

  private void tvConversation_AfterSelect(object sender, TreeViewEventArgs e)
  {
      DLGConvListNode selectedNode = (DLGConvListNode) ((TreeView) sender).SelectedNode;
      AdjustTabPagesEnabledState(selectedNode);
      if (selectedNode == tvConversation.Nodes[0])
        return;
      tbLinkID.Text = StringType.FromInteger(selectedNode.LinkID);
      tbLinkedCnt.Text = selectedNode.LinkedNodesList != null ? StringType.FromInteger(selectedNode.LinkedNodesList.Count) : "(empty)";
      tbSharedCnt.Text = selectedNode.LinkedToNode != null ? StringType.FromInteger(selectedNode.LinkedToNode.LinkedNodesList.Count) : "(none)";
      tbLinkDesc.Text = selectedNode.LinkDesc;
      DisconnectEventHandlers();
      tbConversationText.Text = selectedNode.InternalText;
      tbTextActiveScript.Text = selectedNode.ActiveScript;
      tbSound.Text = selectedNode.Sound;
      tbComments.Text = selectedNode.Comment;
      tbSound.Text = selectedNode.Sound;
      tbActionsTakenScript.Text = selectedNode.Script;
      tbSpeaker.Text = selectedNode.Speaker;
      nudCameraAngle.Value = new Decimal(selectedNode.CameraAngle);
      if (selectedNode.CameraAngle == 6)
      {
        cmbxCamVidEffect.Enabled = true;
        switch (selectedNode.CamVidEffect)
        {
          case -1:
            cmbxCamVidEffect.SelectedIndex = 0;
            break;
          case 0:
            cmbxCamVidEffect.SelectedIndex = 1;
            break;
          case 2:
            cmbxCamVidEffect.SelectedIndex = 2;
            break;
          default:
            cmbxCamVidEffect.SelectedIndex = 0;
            break;
        }
      }
      else
      {
        cmbxCamVidEffect.Enabled = false;
        cmbxCamVidEffect.SelectedIndex = 0;
      }
      nudCameraID.Value = new Decimal(selectedNode.CameraID);
      cmbxFadeType.SelectedIndex = selectedNode.FadeType;
      bool flag = cmbxFadeType.SelectedIndex > 0;
      nudFadeDelay.Enabled = flag;
      nudFadeLength.Enabled = flag;
      nudFadeColorR.Enabled = flag;
      nudFadeColorG.Enabled = flag;
      nudFadeColorB.Enabled = flag;
      tbListener.Text = selectedNode.Listener;
      nudPlotIndex.Value = new Decimal(selectedNode.PlotIndex);
      nudPlotXPPercentage.Value = selectedNode.PlotXPPercentage;
      tbVoiceOverResRef.Text = selectedNode.VO_ResRef;
      nudCamHeightOffset.Value = selectedNode.CamHeightOffset;
      nudTarHeightOffset.Value = selectedNode.TarHeightOffset;
      nudFadeDelay.Value = selectedNode.FadeDelay;
      nudFadeLength.Value = selectedNode.FadeLength;
      if (selectedNode.FadeColor != null)
      {
        nudFadeColorR.Text = StringType.FromByte(Convert.ToByte(selectedNode.FadeColor.f1));
        nudFadeColorG.Text = StringType.FromByte(Convert.ToByte(selectedNode.FadeColor.f2));
        nudFadeColorB.Text = StringType.FromByte(Convert.ToByte(selectedNode.FadeColor.f3));
      }
      else
      {
        nudFadeColorR.Text = "";
        nudFadeColorG.Text = "";
        nudFadeColorB.Text = "";
      }
      dgAnimList.SetDataBinding(selectedNode.Animlist, null);
      dgAnimList.DataSource = selectedNode.Animlist;
      if (StringType.StrCmp(selectedNode.Quest, null, false) == 0)
      {
        tbQuest.Text = "";
        nudQuestEntry.Value = 0M;
        nudQuestEntry.Enabled = false;
      }
      else
      {
        tbQuest.Text = selectedNode.Quest;
        nudQuestEntry.Value = Convert.ToDecimal(selectedNode.QuestEntry);
        nudQuestEntry.Enabled = true;
      }
      if (chkbAnimatedCut.Checked)
        nudCamFieldOfView.Value = selectedNode.CamFieldOfView;
      WireUpEventHandlers();
    }

  private void cmiTV_Add_Click(object sender, EventArgs e)
  {
      if (LastClickedTvConversationNode.IsLink > 0)
        return;
      DLGConvListNode node = new DLGConvListNode();
      frmPromptForString frmPromptForString1 = new frmPromptForString();
      frmPromptForString1.tbValue.Multiline = true;
      frmPromptForString1.tbValue.AcceptsReturn = false;
      frmPromptForString1.tbValue.AcceptsTab = false;
      frmPromptForString frmPromptForString2 = frmPromptForString1;
      Size size1 = new Size(300, 272);
      Size size2 = size1;
      frmPromptForString2.Size = size2;
      TextBox tbValue = frmPromptForString1.tbValue;
      size1 = new Size(232, 96);
      Size size3 = size1;
      tbValue.Size = size3;
      if (LastClickedTvConversationNode.IsReply)
        frmPromptForString1.lblMsg.Text = "Enter what the NPC says:";
      else
        frmPromptForString1.lblMsg.Text = "Enter what the PC says:";
      if (frmPromptForString1.ShowDialog(this) != DialogResult.OK)
        return;
      node.InternalText = frmPromptForString1.tbValue.Text.Trim();
      if (LastClickedTvConversationNode.IsReply)
      {
        node.IsEntry = true;
      }
      else
      {
        node.IsReply = true;
        node.Speaker = "";
      }
      node.Text = node.NodeDesc;
      node.ForeColor = node.DialogColor;
      LastClickedTvConversationNode.Nodes.Add(node);
      if (LastClickedTvConversationNode != tvConversation.Nodes[0])
        LastClickedTvConversationNode.Text = LastClickedTvConversationNode.NodeDesc;
      node.EnsureVisible();
      tvConversation.SelectedNode = node;
    }

  private void cmiTV_Copy_Click(object sender, EventArgs e) => ClipBoardNode = CurrentContextMenuTvConversationNode;

  private void cmiTV_Paste_Click(object sender, EventArgs e)
  {
      DLGConvListNode node = ClipBoardNode.Copy();
      if (LastClickedTvConversationNode.IsReply)
      {
        node.IsEntry = true;
      }
      else
      {
        node.IsReply = true;
        node.Speaker = "";
      }
      node.ForeColor = node.DialogColor;
      node.Text = node.NodeDesc;
      node.LinkedNodesList = null;
      if (node.IsLink > 0)
      {
        if (ClipBoardNode.LinkedToNode.LinkedNodesList == null)
          ClipBoardNode.LinkedToNode.LinkedNodesList = new ArrayList();
        ClipBoardNode.LinkedToNode.LinkedNodesList.Add(node);
      }
      LastClickedTvConversationNode.Nodes.Add(node);
      LastClickedTvConversationNode.Text = LastClickedTvConversationNode.NodeDesc;
      node.EnsureVisible();
    }

  private void cmiTV_PasteTree_Click(object sender, EventArgs e)
  {
      DLGConvListNode clipBoardNode = ClipBoardNode;
      if (LastClickedTvConversationNode.IsReply)
      {
        clipBoardNode.IsEntry = true;
      }
      else
      {
        clipBoardNode.IsReply = true;
        clipBoardNode.Speaker = "";
      }
      clipBoardNode.ForeColor = clipBoardNode.DialogColor;
      clipBoardNode.Text = clipBoardNode.NodeDesc;
      clipBoardNode.LinkedNodesList = null;
      if (clipBoardNode.IsLink > 0)
      {
        if (ClipBoardNode.LinkedToNode.LinkedNodesList == null)
          ClipBoardNode.LinkedToNode.LinkedNodesList = new ArrayList();
        ClipBoardNode.LinkedToNode.LinkedNodesList.Add(clipBoardNode);
      }
      LastClickedTvConversationNode.Nodes.Add(clipBoardNode);
      LastClickedTvConversationNode.Text = LastClickedTvConversationNode.NodeDesc;
      clipBoardNode.EnsureVisible();
      ClipBoardNode = null;
      ResetChildNodesDescAfterPasteTree(LastClickedTvConversationNode);
    }

  private void cmiTV_PasteAsLink_Click(object sender, EventArgs e)
  {
      DLGConvListNode node = ClipBoardNode.Copy();
      node.IsLink = byte.MaxValue;
      node.LinkedNodesList = null;
      node.LinkedToNode = ClipBoardNode;
      if (ClipBoardNode.LinkedNodesList == null)
        ClipBoardNode.LinkedNodesList = new ArrayList();
      ClipBoardNode.LinkedNodesList.Add(node);
      node.ForeColor = node.DialogColor;
      node.Text = node.NodeDesc;
      LastClickedTvConversationNode.Nodes.Add(node);
      LastClickedTvConversationNode.Text = LastClickedTvConversationNode.NodeDesc;
      LastClickedTvConversationNode.ForeColor = LastClickedTvConversationNode.DialogColor;
      node.EnsureVisible();
    }

  private void cmiTV_Cut_Click(object sender, EventArgs e)
  {
      ClipBoardNode = CurrentContextMenuTvConversationNode;
      RemoveChildLinks(ClipBoardNode);
      DLGConvListNode parent = (DLGConvListNode) ClipBoardNode.Parent;
      ClipBoardNode.Parent.Nodes.Remove(ClipBoardNode);
      parent.Text = parent.NodeDesc;
    }

  private void AdjustContextToolStripMenuItems()
  {
      cmiTV_Add.Enabled = ~LastClickedTvConversationNode.IsLink > 0;
      cmiTV_Copy.Enabled = LastClickedTvConversationNode != tvConversation.Nodes[0];
      cmiTV_Cut.Enabled = LastClickedTvConversationNode != tvConversation.Nodes[0];
      cmiTV_Paste.Enabled = ClipBoardNode != null && ~LastClickedTvConversationNode.IsLink > 0;
      cmiTV_PasteTree.Enabled = ClipBoardNode != null && ~LastClickedTvConversationNode.IsLink > 0;
      cmiTV_PasteAsLink.Enabled = ClipBoardNode != null && ~ClipBoardNode.IsLink > 0 && ~LastClickedTvConversationNode.IsLink > 0 && LastClickedTvConversationNode.IsReply;
      if (LastClickedTvConversationNode == tvConversation.Nodes[0])
      {
        cmiTV_MoveNodeUp.Enabled = false;
        cmiTV_MoveNodeDown.Enabled = false;
      }
      else
      {
        DLGConvListNode parent = (DLGConvListNode) LastClickedTvConversationNode.Parent;
        cmiTV_MoveNodeUp.Enabled = parent.Nodes.IndexOf(LastClickedTvConversationNode) > 0;
        cmiTV_MoveNodeDown.Enabled = parent.Nodes.IndexOf(LastClickedTvConversationNode) < checked (parent.Nodes.Count - 1);
      }
    }

  private void AdjustTabPagesEnabledState(DLGConvListNode node)
  {
      if (((uint) (short) -(node == tvConversation.Nodes[0] ? 1 : 0) | node.IsLink) > 0U)
      {
        tabpagActionsTaken.Enabled = false;
        tabpagAnimationSound.Enabled = false;
        tabpagCamera.Enabled = false;
        tabpagComment.Enabled = false;
        tabpagPlot.Enabled = false;
      }
      else
      {
        tabpagActionsTaken.Enabled = true;
        tabpagAnimationSound.Enabled = true;
        tabpagCamera.Enabled = true;
        tabpagComment.Enabled = true;
        tabpagPlot.Enabled = true;
      }
    }

  private void btnOpen_Click(object sender, EventArgs e) => OpenFile();

  private void Button1_Click(object sender, EventArgs e) => SaveFile();

  private void OpenFile()
  {
      string str = StringType.FromObject(FrmMain.GetFilePath("load", FrmMain.CurrentSettings.defaultImportLocation, "", "Open DLG files...", "dlg"));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      int kotorVersionIndex = FrmMain.GetGffFileKotorVersionIndex(str);
      FileStream fileStream = new FileStream(str, FileMode.Open, FileAccess.Read);
      SetupForNewDialog();
      this.tvConversation.Nodes.Clear();
      FileStream fs = fileStream;
      TreeView tvConversation = this.tvConversation;
      ref TreeView local = ref tvConversation;
      int KotorVerIndex = kotorVersionIndex;
      clsDLG clsDlg = new clsDLG(fs, ref local, KotorVerIndex);
      this.tvConversation = tvConversation;
      clsdlg = clsDlg;
      filename = Path.GetFileNameWithoutExtension(fileStream.Name);
      gff = clsdlg.dlgGff;
      SetFormToDLGRootItems();
      Text = "Conversation Editor - " + filename + ".dlg";
    }

  private void miNew_Click(object sender, EventArgs e) => SetupForNewDialog();

  private void miOpen_Click(object sender, EventArgs e) => OpenFile();

  private void miSave_Click(object sender, EventArgs e) => SaveFile();

  private void miQuit_Click(object sender, EventArgs e) => Close();

  private void btnAddAnimListEntry_Click(object sender, EventArgs e)
  {
      if (LastClickedTvConversationNode.Animlist == null)
        LastClickedTvConversationNode.Animlist = new ArrayList(1);
      frmCreateAnimListEntry createAnimListEntry = new frmCreateAnimListEntry();
      if (createAnimListEntry.ShowDialog(this) != DialogResult.OK)
        return;
      LastClickedTvConversationNode.Animlist.Add(new AnimListEntry(createAnimListEntry.Participant, createAnimListEntry.AnimationNumber));
      dgAnimList.SetDataBinding(LastClickedTvConversationNode.Animlist, null);
      ((CurrencyManager) dgAnimList.BindingContext[RuntimeHelpers.GetObjectValue(dgAnimList.DataSource)])?.Refresh();
      dgAnimList.Refresh();
    }

  private void btnDeleteAnimListEntry_Click(object sender, EventArgs e)
  {
      CurrencyManager currencyManager = (CurrencyManager) dgAnimList.BindingContext[RuntimeHelpers.GetObjectValue(dgAnimList.DataSource)];
      LastClickedTvConversationNode.Animlist.RemoveAt(currencyManager.Position);
      currencyManager?.Refresh();
      btnDeleteAnimListEntry.Enabled = false;
    }

  private void dgAnimList_Click(object sender, EventArgs e)
  {
      DataGrid dataGrid = (DataGrid) sender;
      DataGrid.HitTestInfo hitTestInfo = dataGrid.HitTest(dataGrid.PointToClient(MousePosition).X, dataGrid.PointToClient(MousePosition).Y);
      if (!(hitTestInfo.Type == DataGrid.HitTestType.RowHeader | hitTestInfo.Type == DataGrid.HitTestType.Cell))
        return;
      dgAnimList.Select(hitTestInfo.Row);
      btnDeleteAnimListEntry.Enabled = true;
    }

  private void dgAnimList_Validated(object sender, EventArgs e) => btnDeleteAnimListEntry.Enabled = false;

  private void trkbTVIndent_Scroll(object sender, EventArgs e) => tvConversation.Indent = trkbTVIndent.Value;

  private void trkbTVItemHeight_Scroll(object sender, EventArgs e) => tvConversation.ItemHeight = checked (trkbTVItemHeight.Value * 2);

  private void cmbxConversationType_SelectedIndexChanged(object sender, EventArgs e) => cmbxComputerType.Enabled = cmbxConversationType.SelectedIndex == 1;

  private void btnShowLists_Click(object sender, EventArgs e)
  {
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Entries");
      Console.WriteLine("-----------------------------------------");
      int num1 = checked (gff.GetListItemCount("EntryList") - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        Console.Write("Entry " + StringType.FromInteger(num2) + ": ");
        if (gff.GetListItemCount("EntryList(" + StringType.FromInteger(num2) + ").RepliesList") > 0)
        {
          int num3 = checked (gff.GetListItemCount("EntryList(" + StringType.FromInteger(num2) + ").RepliesList") - 1);
          int num4 = 0;
          while (num4 <= num3)
          {
            Console.Write(Convert.ToInt32(RuntimeHelpers.GetObjectValue(gff.GetNodeValue("EntryList(" + StringType.FromInteger(num2) + ").RepliesList(" + StringType.FromInteger(num4) + ").Index"))));
            if (ObjectType.ObjTst(gff.GetNodeValue("EntryList(" + StringType.FromInteger(num2) + ").RepliesList(" + StringType.FromInteger(num4) + ").IsChild"), 0, false) > 0)
              Console.Write(" (L), ");
            else
              Console.Write(", ");
            checked { ++num4; }
          }
        }
        Console.WriteLine();
        checked { ++num2; }
      }
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Replies");
      Console.WriteLine("-----------------------------------------");
      int num5 = checked (gff.GetListItemCount("ReplyList") - 1);
      int num6 = 0;
      while (num6 <= num5)
      {
        Console.Write("Entry " + StringType.FromInteger(num6) + ": ");
        if (gff.GetListItemCount("ReplyList(" + StringType.FromInteger(num6) + ").EntriesList") > 0)
        {
          int num7 = checked (gff.GetListItemCount("ReplyList(" + StringType.FromInteger(num6) + ").EntriesList") - 1);
          int num8 = 0;
          while (num8 <= num7)
          {
            Console.Write(Convert.ToInt32(RuntimeHelpers.GetObjectValue(gff.GetNodeValue("ReplyList(" + StringType.FromInteger(num6) + ").EntriesList(" + StringType.FromInteger(num8) + ").Index"))));
            if (ObjectType.ObjTst(gff.GetNodeValue("ReplyList(" + StringType.FromInteger(num6) + ").EntriesList(" + StringType.FromInteger(num8) + ").IsChild"), 0, false) > 0)
              Console.Write(" (L), ");
            else
              Console.Write(", ");
            checked { ++num8; }
          }
        }
        Console.WriteLine();
        checked { ++num6; }
      }
      Console.WriteLine("-----------------------------------------");
    }

  private void chkbAnimatedCut_CheckedChanged(object sender, EventArgs e)
  {
      tbCameraModel.Enabled = ((CheckBox) sender).Checked;
      nudCamFieldOfView.Enabled = ((CheckBox) sender).Checked;
    }

  private void cmiTV_MoveNodeUp_Click(object sender, EventArgs e)
  {
      DLGConvListNode selectedNode = (DLGConvListNode) tvConversation.SelectedNode;
      DLGConvListNode parent = (DLGConvListNode) selectedNode.Parent;
      int num = parent.Nodes.IndexOf(selectedNode);
      parent.Nodes.Remove(selectedNode);
      parent.Nodes.Insert(checked (num - 1), selectedNode);
      tvConversation.SelectedNode = selectedNode;
    }

  private void cmiTV_MoveNodeDown_Click(object sender, EventArgs e)
  {
      DLGConvListNode selectedNode = (DLGConvListNode) tvConversation.SelectedNode;
      DLGConvListNode parent = (DLGConvListNode) selectedNode.Parent;
      int num = parent.Nodes.IndexOf(selectedNode);
      parent.Nodes.Remove(selectedNode);
      if (num == checked (parent.Nodes.Count - 1))
        parent.Nodes.Add(selectedNode);
      else
        parent.Nodes.Insert(checked (num + 1), selectedNode);
      tvConversation.SelectedNode = selectedNode;
    }
}