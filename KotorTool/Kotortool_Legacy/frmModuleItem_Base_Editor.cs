// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmModuleItem_Base_Editor
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmModuleItem_Base_Editor : frmParent
{
  [AccessedThroughProperty("nudXYSpawnPointBearing")]
  private NumericUpDown _nudXYSpawnPointBearing;
  [AccessedThroughProperty("lblTransitionMsg")]
  private Label _lblTransitionMsg;
  [AccessedThroughProperty("lblDoorLinkedToTransitionDestin")]
  private Label _lblDoorLinkedToTransitionDestin;
  [AccessedThroughProperty("lblDoorLinkedToModule")]
  private Label _lblDoorLinkedToModule;
  [AccessedThroughProperty("lblBearing")]
  private Label _lblBearing;
  [AccessedThroughProperty("lblDoorLinkedToFlags")]
  private Label _lblDoorLinkedToFlags;
  [AccessedThroughProperty("nudXY")]
  private NumericUpDown _nudXY;
  [AccessedThroughProperty("lblDoorLinkedTo")]
  private Label _lblDoorLinkedTo;
  [AccessedThroughProperty("pboxXY")]
  private PictureBox _pboxXY;
  [AccessedThroughProperty("nudCamOrientationZ")]
  private NumericUpDown _nudCamOrientationZ;
  [AccessedThroughProperty("nudCamOrientationY")]
  private NumericUpDown _nudCamOrientationY;
  [AccessedThroughProperty("Label24")]
  private Label _Label24;
  [AccessedThroughProperty("nudCamOrientationX")]
  private NumericUpDown _nudCamOrientationX;
  [AccessedThroughProperty("Label23")]
  private Label _Label23;
  [AccessedThroughProperty("lblQuaternionW")]
  private Label _lblQuaternionW;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  [AccessedThroughProperty("btnShowQuaternion")]
  private Button _btnShowQuaternion;
  [AccessedThroughProperty("Label21")]
  private Label _Label21;
  [AccessedThroughProperty("ErrorProvider1")]
  private ErrorProvider _ErrorProvider1;
  [AccessedThroughProperty("Label20")]
  private Label _Label20;
  [AccessedThroughProperty("tbCamOrientationY")]
  private TextBox _tbCamOrientationY;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("tbCamOrientationX")]
  private TextBox _tbCamOrientationX;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("tbCamOrientationZ")]
  private TextBox _tbCamOrientationZ;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("tabpagEncounter")]
  private TabPage _tabpagEncounter;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("gbTriggerNode")]
  private GroupBox _gbTriggerNode;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("tbTriggerNodeZPosition")]
  private TextBox _tbTriggerNodeZPosition;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("tbTriggerNodeYPosition")]
  private TextBox _tbTriggerNodeYPosition;
  [AccessedThroughProperty("tbTriggerNodeXPosition")]
  private TextBox _tbTriggerNodeXPosition;
  [AccessedThroughProperty("tbCamOrientationF3")]
  private TextBox _tbCamOrientationF3;
  [AccessedThroughProperty("tbCamOrientationF4")]
  private TextBox _tbCamOrientationF4;
  [AccessedThroughProperty("tbCamOrientationF2")]
  private TextBox _tbCamOrientationF2;
  [AccessedThroughProperty("tbCamOrientationF1")]
  private TextBox _tbCamOrientationF1;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("lbSpawnPoints")]
  private ListBox _lbSpawnPoints;
  [AccessedThroughProperty("tbCamFieldOfView")]
  private TextBox _tbCamFieldOfView;
  [AccessedThroughProperty("tbCamMicRange")]
  private TextBox _tbCamMicRange;
  [AccessedThroughProperty("tbCamHeight")]
  private TextBox _tbCamHeight;
  [AccessedThroughProperty("nudSpawnPointX")]
  private NumericUpDown _nudSpawnPointX;
  [AccessedThroughProperty("nudSpawnPointY")]
  private NumericUpDown _nudSpawnPointY;
  [AccessedThroughProperty("nudSpawnPointZ")]
  private NumericUpDown _nudSpawnPointZ;
  [AccessedThroughProperty("tbxo")]
  private TextBox _tbxo;
  [AccessedThroughProperty("tbCamPitch")]
  private TextBox _tbCamPitch;
  [AccessedThroughProperty("tbyo")]
  private TextBox _tbyo;
  [AccessedThroughProperty("tbBearing")]
  private TextBox _tbBearing;
  [AccessedThroughProperty("btnSetNameLang")]
  private Button _btnSetNameLang;
  [AccessedThroughProperty("Label25")]
  private Label _Label25;
  [AccessedThroughProperty("tbWpMapNote")]
  private TextBox _tbWpMapNote;
  [AccessedThroughProperty("Button3")]
  private Button _Button3;
  [AccessedThroughProperty("pboxXYSpawnPointBearing")]
  private PictureBox _pboxXYSpawnPointBearing;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("lblResRef")]
  private Label _lblResRef;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label26")]
  private Label _Label26;
  [AccessedThroughProperty("Label27")]
  private Label _Label27;
  [AccessedThroughProperty("cmbxDoorLinkedToFlags")]
  private ComboBox _cmbxDoorLinkedToFlags;
  [AccessedThroughProperty("tbXPosition")]
  private TextBox _tbXPosition;
  [AccessedThroughProperty("tbYPosition")]
  private TextBox _tbYPosition;
  [AccessedThroughProperty("Label28")]
  private Label _Label28;
  [AccessedThroughProperty("tbZPosition")]
  private TextBox _tbZPosition;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Label29")]
  private Label _Label29;
  [AccessedThroughProperty("tbResRef")]
  private TextBox _tbResRef;
  [AccessedThroughProperty("tbTag")]
  private TextBox _tbTag;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("tabpagCamera")]
  private TabPage _tabpagCamera;
  [AccessedThroughProperty("lblTag")]
  private Label _lblTag;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("tabpagDoor")]
  private TabPage _tabpagDoor;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("tabpagGeneral")]
  private TabPage _tabpagGeneral;
  [AccessedThroughProperty("tabctrl")]
  private TabControl _tabctrl;
  [AccessedThroughProperty("chkbMapNoteEnabled")]
  private CheckBox _chkbMapNoteEnabled;
  [AccessedThroughProperty("chkbHasMapNote")]
  private CheckBox _chkbHasMapNote;
  [AccessedThroughProperty("lblLocalizedName")]
  private Label _lblLocalizedName;
  [AccessedThroughProperty("tabpagWaypoint")]
  private TabPage _tabpagWaypoint;
  [AccessedThroughProperty("tbWpLocalizedName")]
  private TextBox _tbWpLocalizedName;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("tbDoorLinkedTo")]
  private TextBox _tbDoorLinkedTo;
  [AccessedThroughProperty("tbDoorLinkedToModule")]
  private TextBox _tbDoorLinkedToModule;
  [AccessedThroughProperty("tbWpDescription")]
  private TextBox _tbWpDescription;
  [AccessedThroughProperty("tbDoorLinkedToTransitionDestin")]
  private TextBox _tbDoorLinkedToTransitionDestin;
  [AccessedThroughProperty("tbWPLinkedTo")]
  private TextBox _tbWPLinkedTo;
  private IContainer components;
  private Bitmap bmpXY;
  private Bitmap bmpXYSpawnPointBearing;
  private double _XYAngle;
  private double _SpawnPointXYAngle;
  private float _XOrientation;
  private float _YOrientation;
  private float _ZOrientation;
  private float _Bearing;
  private GFFType16[] _SpawnPoints;
  private int _nameLang;

  public frmModuleItem_Base_Editor()
  {
      bmpXY = new Bitmap(50, 50);
      bmpXYSpawnPointBearing = new Bitmap(50, 50);
      _XYAngle = 0.0;
      _SpawnPointXYAngle = 0.0;
      InitializeComponent();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
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

  internal virtual PictureBox pboxXY
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pboxXY == null)
          ;
        _pboxXY = value;
        if (_pboxXY == null)
          ;
      }
    get => _pboxXY;
  }

  internal virtual TextBox tbXPosition
  {
    get => _tbXPosition;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbXPosition == null)
          ;
        _tbXPosition = value;
        if (_tbXPosition == null)
          ;
      }
  }

  internal virtual TextBox tbYPosition
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbYPosition == null)
          ;
        _tbYPosition = value;
        if (_tbYPosition == null)
          ;
      }
    get => _tbYPosition;
  }

  internal virtual TextBox tbZPosition
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbZPosition == null)
          ;
        _tbZPosition = value;
        if (_tbZPosition == null)
          ;
      }
    get => _tbZPosition;
  }

  internal virtual NumericUpDown nudXY
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudXY != null)
        {
          _nudXY.ValueChanged -= new EventHandler(nudXY_ValueChanged);
          _nudXY.KeyUp -= new KeyEventHandler(nudXY_KeyUp);
        }
        _nudXY = value;
        if (_nudXY == null)
          return;
        _nudXY.ValueChanged += new EventHandler(nudXY_ValueChanged);
        _nudXY.KeyUp += new KeyEventHandler(nudXY_KeyUp);
      }
    get => _nudXY;
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

  internal virtual Button Button2
  {
    get => _Button2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Button2 == null)
          ;
        _Button2 = value;
        if (_Button2 == null)
          ;
      }
  }

  internal virtual Button Button3
  {
    get => _Button3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Button3 == null)
          ;
        _Button3 = value;
        if (_Button3 == null)
          ;
      }
  }

  internal virtual TextBox tbResRef
  {
    get => _tbResRef;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbResRef == null)
          ;
        _tbResRef = value;
        if (_tbResRef == null)
          ;
      }
  }

  internal virtual TextBox tbTag
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTag == null)
          ;
        _tbTag = value;
        if (_tbTag == null)
          ;
      }
    get => _tbTag;
  }

  internal virtual Label lblTag
  {
    get => _lblTag;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblTag == null)
          ;
        _lblTag = value;
        if (_lblTag == null)
          ;
      }
  }

  internal virtual TabPage tabpagDoor
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagDoor == null)
          ;
        _tabpagDoor = value;
        if (_tabpagDoor == null)
          ;
      }
    get => _tabpagDoor;
  }

  internal virtual TabPage tabpagGeneral
  {
    get => _tabpagGeneral;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagGeneral == null)
          ;
        _tabpagGeneral = value;
        if (_tabpagGeneral == null)
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

  internal virtual TabPage tabpagWaypoint
  {
    get => _tabpagWaypoint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagWaypoint == null)
          ;
        _tabpagWaypoint = value;
        if (_tabpagWaypoint == null)
          ;
      }
  }

  internal virtual TextBox tbDoorLinkedTo
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbDoorLinkedTo == null)
          ;
        _tbDoorLinkedTo = value;
        if (_tbDoorLinkedTo == null)
          ;
      }
    get => _tbDoorLinkedTo;
  }

  internal virtual TextBox tbDoorLinkedToModule
  {
    get => _tbDoorLinkedToModule;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbDoorLinkedToModule == null)
          ;
        _tbDoorLinkedToModule = value;
        if (_tbDoorLinkedToModule == null)
          ;
      }
  }

  internal virtual TextBox tbDoorLinkedToTransitionDestin
  {
    get => _tbDoorLinkedToTransitionDestin;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbDoorLinkedToTransitionDestin == null)
          ;
        _tbDoorLinkedToTransitionDestin = value;
        if (_tbDoorLinkedToTransitionDestin == null)
          ;
      }
  }

  internal virtual Label Label9
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label9 == null)
          ;
        _Label9 = value;
        if (_Label9 == null)
          ;
      }
    get => _Label9;
  }

  internal virtual TextBox tbWPLinkedTo
  {
    get => _tbWPLinkedTo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbWPLinkedTo == null)
          ;
        _tbWPLinkedTo = value;
        if (_tbWPLinkedTo == null)
          ;
      }
  }

  internal virtual TextBox tbWpDescription
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbWpDescription == null)
          ;
        _tbWpDescription = value;
        if (_tbWpDescription == null)
          ;
      }
    get => _tbWpDescription;
  }

  internal virtual Label Label11
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label11 == null)
          ;
        _Label11 = value;
        if (_Label11 == null)
          ;
      }
    get => _Label11;
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

  internal virtual TextBox tbWpLocalizedName
  {
    get => _tbWpLocalizedName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbWpLocalizedName == null)
          ;
        _tbWpLocalizedName = value;
        if (_tbWpLocalizedName == null)
          ;
      }
  }

  internal virtual Label lblLocalizedName
  {
    get => _lblLocalizedName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblLocalizedName == null)
          ;
        _lblLocalizedName = value;
        if (_lblLocalizedName == null)
          ;
      }
  }

  internal virtual CheckBox chkbHasMapNote
  {
    get => _chkbHasMapNote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbHasMapNote == null)
          ;
        _chkbHasMapNote = value;
        if (_chkbHasMapNote == null)
          ;
      }
  }

  internal virtual CheckBox chkbMapNoteEnabled
  {
    get => _chkbMapNoteEnabled;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbMapNoteEnabled == null)
          ;
        _chkbMapNoteEnabled = value;
        if (_chkbMapNoteEnabled == null)
          ;
      }
  }

  internal virtual TabControl tabctrl
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabctrl == null)
          ;
        _tabctrl = value;
        if (_tabctrl == null)
          ;
      }
    get => _tabctrl;
  }

  internal virtual ComboBox cmbxDoorLinkedToFlags
  {
    get => _cmbxDoorLinkedToFlags;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxDoorLinkedToFlags == null)
          ;
        _cmbxDoorLinkedToFlags = value;
        if (_cmbxDoorLinkedToFlags == null)
          ;
      }
  }

  internal virtual Label lblResRef
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblResRef == null)
          ;
        _lblResRef = value;
        if (_lblResRef == null)
          ;
      }
    get => _lblResRef;
  }

  internal virtual TextBox tbWpMapNote
  {
    get => _tbWpMapNote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbWpMapNote == null)
          ;
        _tbWpMapNote = value;
        if (_tbWpMapNote == null)
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

  internal virtual TextBox tbCamPitch
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCamPitch == null)
          ;
        _tbCamPitch = value;
        if (_tbCamPitch == null)
          ;
      }
    get => _tbCamPitch;
  }

  internal virtual TextBox tbCamHeight
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCamHeight == null)
          ;
        _tbCamHeight = value;
        if (_tbCamHeight == null)
          ;
      }
    get => _tbCamHeight;
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

  internal virtual TextBox tbCamMicRange
  {
    get => _tbCamMicRange;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCamMicRange == null)
          ;
        _tbCamMicRange = value;
        if (_tbCamMicRange == null)
          ;
      }
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
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label17 == null)
          ;
        _Label17 = value;
        if (_Label17 == null)
          ;
      }
    get => _Label17;
  }

  internal virtual TextBox tbCamFieldOfView
  {
    get => _tbCamFieldOfView;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCamFieldOfView == null)
          ;
        _tbCamFieldOfView = value;
        if (_tbCamFieldOfView == null)
          ;
      }
  }

  internal virtual Label lblBearing
  {
    get => _lblBearing;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblBearing == null)
          ;
        _lblBearing = value;
        if (_lblBearing == null)
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
    get => _Label20;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label20 == null)
          ;
        _Label20 = value;
        if (_Label20 == null)
          ;
      }
  }

  internal virtual TextBox tbCamOrientationF1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCamOrientationF1 == null)
          ;
        _tbCamOrientationF1 = value;
        if (_tbCamOrientationF1 == null)
          ;
      }
    get => _tbCamOrientationF1;
  }

  internal virtual TextBox tbCamOrientationF2
  {
    get => _tbCamOrientationF2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCamOrientationF2 == null)
          ;
        _tbCamOrientationF2 = value;
        if (_tbCamOrientationF2 == null)
          ;
      }
  }

  internal virtual TextBox tbCamOrientationF4
  {
    get => _tbCamOrientationF4;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCamOrientationF4 == null)
          ;
        _tbCamOrientationF4 = value;
        if (_tbCamOrientationF4 == null)
          ;
      }
  }

  internal virtual TextBox tbCamOrientationF3
  {
    get => _tbCamOrientationF3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCamOrientationF3 == null)
          ;
        _tbCamOrientationF3 = value;
        if (_tbCamOrientationF3 == null)
          ;
      }
  }

  internal virtual TextBox tbTriggerNodeXPosition
  {
    get => _tbTriggerNodeXPosition;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTriggerNodeXPosition == null)
          ;
        _tbTriggerNodeXPosition = value;
        if (_tbTriggerNodeXPosition == null)
          ;
      }
  }

  internal virtual TextBox tbTriggerNodeYPosition
  {
    get => _tbTriggerNodeYPosition;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTriggerNodeYPosition == null)
          ;
        _tbTriggerNodeYPosition = value;
        if (_tbTriggerNodeYPosition == null)
          ;
      }
  }

  internal virtual TextBox tbTriggerNodeZPosition
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTriggerNodeZPosition == null)
          ;
        _tbTriggerNodeZPosition = value;
        if (_tbTriggerNodeZPosition == null)
          ;
      }
    get => _tbTriggerNodeZPosition;
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
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label22 == null)
          ;
        _Label22 = value;
        if (_Label22 == null)
          ;
      }
    get => _Label22;
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

  internal virtual GroupBox gbTriggerNode
  {
    get => _gbTriggerNode;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_gbTriggerNode == null)
          ;
        _gbTriggerNode = value;
        if (_gbTriggerNode == null)
          ;
      }
  }

  internal virtual TabPage tabpagEncounter
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagEncounter == null)
          ;
        _tabpagEncounter = value;
        if (_tabpagEncounter == null)
          ;
      }
    get => _tabpagEncounter;
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

  internal virtual TextBox tbCamOrientationZ
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCamOrientationZ == null)
          ;
        _tbCamOrientationZ = value;
        if (_tbCamOrientationZ == null)
          ;
      }
    get => _tbCamOrientationZ;
  }

  internal virtual TextBox tbCamOrientationX
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCamOrientationX == null)
          ;
        _tbCamOrientationX = value;
        if (_tbCamOrientationX == null)
          ;
      }
    get => _tbCamOrientationX;
  }

  internal virtual TextBox tbCamOrientationY
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCamOrientationY == null)
          ;
        _tbCamOrientationY = value;
        if (_tbCamOrientationY == null)
          ;
      }
    get => _tbCamOrientationY;
  }

  internal virtual ErrorProvider ErrorProvider1
  {
    get => _ErrorProvider1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ErrorProvider1 == null)
          ;
        _ErrorProvider1 = value;
        if (_ErrorProvider1 == null)
          ;
      }
  }

  internal virtual Button btnShowQuaternion
  {
    get => _btnShowQuaternion;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnShowQuaternion != null)
        {
          _btnShowQuaternion.MouseUp -= new MouseEventHandler(btnShowQuaternion_MouseUp);
          _btnShowQuaternion.MouseDown -= new MouseEventHandler(btnShowQuaternion_MouseDown);
        }
        _btnShowQuaternion = value;
        if (_btnShowQuaternion == null)
          return;
        _btnShowQuaternion.MouseUp += new MouseEventHandler(btnShowQuaternion_MouseUp);
        _btnShowQuaternion.MouseDown += new MouseEventHandler(btnShowQuaternion_MouseDown);
      }
  }

  internal virtual Label lblQuaternionW
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblQuaternionW == null)
          ;
        _lblQuaternionW = value;
        if (_lblQuaternionW == null)
          ;
      }
    get => _lblQuaternionW;
  }

  internal virtual NumericUpDown nudCamOrientationX
  {
    get => _nudCamOrientationX;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudCamOrientationX != null)
          _nudCamOrientationX.ValueChanged -= new EventHandler(nudCamOrientation_ValueChanged);
        _nudCamOrientationX = value;
        if (_nudCamOrientationX == null)
          return;
        _nudCamOrientationX.ValueChanged += new EventHandler(nudCamOrientation_ValueChanged);
      }
  }

  internal virtual NumericUpDown nudCamOrientationY
  {
    get => _nudCamOrientationY;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudCamOrientationY != null)
          _nudCamOrientationY.ValueChanged -= new EventHandler(nudCamOrientation_ValueChanged);
        _nudCamOrientationY = value;
        if (_nudCamOrientationY == null)
          return;
        _nudCamOrientationY.ValueChanged += new EventHandler(nudCamOrientation_ValueChanged);
      }
  }

  internal virtual NumericUpDown nudCamOrientationZ
  {
    get => _nudCamOrientationZ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudCamOrientationZ != null)
          _nudCamOrientationZ.ValueChanged -= new EventHandler(nudCamOrientation_ValueChanged);
        _nudCamOrientationZ = value;
        if (_nudCamOrientationZ == null)
          return;
        _nudCamOrientationZ.ValueChanged += new EventHandler(nudCamOrientation_ValueChanged);
      }
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

  internal virtual Label lblDoorLinkedTo
  {
    get => _lblDoorLinkedTo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblDoorLinkedTo == null)
          ;
        _lblDoorLinkedTo = value;
        if (_lblDoorLinkedTo == null)
          ;
      }
  }

  internal virtual Label lblDoorLinkedToFlags
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblDoorLinkedToFlags == null)
          ;
        _lblDoorLinkedToFlags = value;
        if (_lblDoorLinkedToFlags == null)
          ;
      }
    get => _lblDoorLinkedToFlags;
  }

  internal virtual Label lblDoorLinkedToModule
  {
    get => _lblDoorLinkedToModule;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblDoorLinkedToModule == null)
          ;
        _lblDoorLinkedToModule = value;
        if (_lblDoorLinkedToModule == null)
          ;
      }
  }

  internal virtual Label lblDoorLinkedToTransitionDestin
  {
    get => _lblDoorLinkedToTransitionDestin;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblDoorLinkedToTransitionDestin == null)
          ;
        _lblDoorLinkedToTransitionDestin = value;
        if (_lblDoorLinkedToTransitionDestin == null)
          ;
      }
  }

  internal virtual Label lblTransitionMsg
  {
    get => _lblTransitionMsg;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblTransitionMsg == null)
          ;
        _lblTransitionMsg = value;
        if (_lblTransitionMsg == null)
          ;
      }
  }

  internal virtual NumericUpDown nudXYSpawnPointBearing
  {
    get => _nudXYSpawnPointBearing;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudXYSpawnPointBearing != null)
        {
          _nudXYSpawnPointBearing.KeyUp -= new KeyEventHandler(nudXYSpawnPointBearing_KeyUp);
          _nudXYSpawnPointBearing.ValueChanged -= new EventHandler(nudXYSpawnPointBearing_ValueChanged);
        }
        _nudXYSpawnPointBearing = value;
        if (_nudXYSpawnPointBearing == null)
          return;
        _nudXYSpawnPointBearing.KeyUp += new KeyEventHandler(nudXYSpawnPointBearing_KeyUp);
        _nudXYSpawnPointBearing.ValueChanged += new EventHandler(nudXYSpawnPointBearing_ValueChanged);
      }
  }

  internal virtual PictureBox pboxXYSpawnPointBearing
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pboxXYSpawnPointBearing == null)
          ;
        _pboxXYSpawnPointBearing = value;
        if (_pboxXYSpawnPointBearing == null)
          ;
      }
    get => _pboxXYSpawnPointBearing;
  }

  internal virtual ListBox lbSpawnPoints
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lbSpawnPoints != null)
          _lbSpawnPoints.SelectedIndexChanged -= new EventHandler(lbSpawnPoints_SelectedIndexChanged);
        _lbSpawnPoints = value;
        if (_lbSpawnPoints == null)
          return;
        _lbSpawnPoints.SelectedIndexChanged += new EventHandler(lbSpawnPoints_SelectedIndexChanged);
      }
    get => _lbSpawnPoints;
  }

  internal virtual NumericUpDown nudSpawnPointX
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudSpawnPointX == null)
          ;
        _nudSpawnPointX = value;
        if (_nudSpawnPointX == null)
          ;
      }
    get => _nudSpawnPointX;
  }

  internal virtual NumericUpDown nudSpawnPointY
  {
    get => _nudSpawnPointY;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudSpawnPointY == null)
          ;
        _nudSpawnPointY = value;
        if (_nudSpawnPointY == null)
          ;
      }
  }

  internal virtual NumericUpDown nudSpawnPointZ
  {
    get => _nudSpawnPointZ;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudSpawnPointZ == null)
          ;
        _nudSpawnPointZ = value;
        if (_nudSpawnPointZ == null)
          ;
      }
  }

  internal virtual TextBox tbxo
  {
    get => _tbxo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbxo == null)
          ;
        _tbxo = value;
        if (_tbxo == null)
          ;
      }
  }

  internal virtual TextBox tbyo
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbyo == null)
          ;
        _tbyo = value;
        if (_tbyo == null)
          ;
      }
    get => _tbyo;
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

  internal virtual TextBox tbBearing
  {
    get => _tbBearing;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbBearing == null)
          ;
        _tbBearing = value;
        if (_tbBearing == null)
          ;
      }
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

  internal virtual Button btnSetNameLang
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSetNameLang != null)
          _btnSetNameLang.Click -= new EventHandler(btnSetNameLang_Click);
        _btnSetNameLang = value;
        if (_btnSetNameLang == null)
          return;
        _btnSetNameLang.Click += new EventHandler(btnSetNameLang_Click);
      }
    get => _btnSetNameLang;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmModuleItem_Base_Editor));
      tbXPosition = new TextBox();
      tbYPosition = new TextBox();
      tbZPosition = new TextBox();
      tbResRef = new TextBox();
      lblResRef = new Label();
      Label2 = new Label();
      Label3 = new Label();
      Label4 = new Label();
      pboxXY = new PictureBox();
      nudXY = new NumericUpDown();
      Button1 = new Button();
      Button2 = new Button();
      Button3 = new Button();
      tbTag = new TextBox();
      lblTag = new Label();
      tabctrl = new TabControl();
      tabpagGeneral = new TabPage();
      lblBearing = new Label();
      tabpagWaypoint = new TabPage();
      btnSetNameLang = new Button();
      chkbHasMapNote = new CheckBox();
      Label9 = new Label();
      tbWPLinkedTo = new TextBox();
      tbWpDescription = new TextBox();
      tbWpMapNote = new TextBox();
      Label11 = new Label();
      Label12 = new Label();
      tbWpLocalizedName = new TextBox();
      lblLocalizedName = new Label();
      chkbMapNoteEnabled = new CheckBox();
      tabpagEncounter = new TabPage();
      tbBearing = new TextBox();
      tbxo = new TextBox();
      tbyo = new TextBox();
      pboxXYSpawnPointBearing = new PictureBox();
      nudXYSpawnPointBearing = new NumericUpDown();
      Label25 = new Label();
      Label26 = new Label();
      nudSpawnPointX = new NumericUpDown();
      Label27 = new Label();
      nudSpawnPointY = new NumericUpDown();
      Label28 = new Label();
      nudSpawnPointZ = new NumericUpDown();
      Label24 = new Label();
      lbSpawnPoints = new ListBox();
      Label5 = new Label();
      Label6 = new Label();
      Label7 = new Label();
      tabpagDoor = new TabPage();
      gbTriggerNode = new GroupBox();
      Label23 = new Label();
      tbTriggerNodeYPosition = new TextBox();
      tbTriggerNodeXPosition = new TextBox();
      Label22 = new Label();
      tbTriggerNodeZPosition = new TextBox();
      Label21 = new Label();
      cmbxDoorLinkedToFlags = new ComboBox();
      lblDoorLinkedTo = new Label();
      tbDoorLinkedTo = new TextBox();
      tbDoorLinkedToModule = new TextBox();
      tbDoorLinkedToTransitionDestin = new TextBox();
      lblDoorLinkedToFlags = new Label();
      lblDoorLinkedToModule = new Label();
      lblDoorLinkedToTransitionDestin = new Label();
      lblTransitionMsg = new Label();
      tabpagCamera = new TabPage();
      Label29 = new Label();
      nudCamOrientationX = new NumericUpDown();
      btnShowQuaternion = new Button();
      Label1 = new Label();
      tbCamPitch = new TextBox();
      tbCamHeight = new TextBox();
      Label15 = new Label();
      tbCamMicRange = new TextBox();
      Label16 = new Label();
      Label17 = new Label();
      tbCamFieldOfView = new TextBox();
      tbCamOrientationF1 = new TextBox();
      tbCamOrientationF2 = new TextBox();
      tbCamOrientationF4 = new TextBox();
      tbCamOrientationF3 = new TextBox();
      lblQuaternionW = new Label();
      Label18 = new Label();
      Label19 = new Label();
      Label20 = new Label();
      tbCamOrientationZ = new TextBox();
      tbCamOrientationX = new TextBox();
      tbCamOrientationY = new TextBox();
      nudCamOrientationY = new NumericUpDown();
      nudCamOrientationZ = new NumericUpDown();
      Label14 = new Label();
      ErrorProvider1 = new ErrorProvider();
      nudXY.BeginInit();
      tabctrl.SuspendLayout();
      tabpagGeneral.SuspendLayout();
      tabpagWaypoint.SuspendLayout();
      tabpagEncounter.SuspendLayout();
      nudXYSpawnPointBearing.BeginInit();
      nudSpawnPointX.BeginInit();
      nudSpawnPointY.BeginInit();
      nudSpawnPointZ.BeginInit();
      tabpagDoor.SuspendLayout();
      gbTriggerNode.SuspendLayout();
      tabpagCamera.SuspendLayout();
      nudCamOrientationX.BeginInit();
      nudCamOrientationY.BeginInit();
      nudCamOrientationZ.BeginInit();
      SuspendLayout();
      TextBox tbXposition = tbXPosition;
      Point point1 = new Point(152, 80);
      Point point2 = point1;
      tbXposition.Location = point2;
      tbXPosition.Name = "tbXPosition";
      tbXPosition.TabIndex = 0;
      tbXPosition.Text = "";
      tbXPosition.TextAlign = HorizontalAlignment.Right;
      TextBox tbYposition = tbYPosition;
      point1 = new Point(152, 112);
      Point point3 = point1;
      tbYposition.Location = point3;
      tbYPosition.Name = "tbYPosition";
      tbYPosition.TabIndex = 0;
      tbYPosition.Text = "";
      tbYPosition.TextAlign = HorizontalAlignment.Right;
      TextBox tbZposition = tbZPosition;
      point1 = new Point(152, 144);
      Point point4 = point1;
      tbZposition.Location = point4;
      tbZPosition.Name = "tbZPosition";
      tbZPosition.TabIndex = 0;
      tbZPosition.Text = "";
      tbZPosition.TextAlign = HorizontalAlignment.Right;
      TextBox tbResRef1 = tbResRef;
      point1 = new Point(152, 16);
      Point point5 = point1;
      tbResRef1.Location = point5;
      tbResRef.MaxLength = 16;
      tbResRef.Name = "tbResRef";
      TextBox tbResRef2 = tbResRef;
      Size size1 = new Size(184, 20);
      Size size2 = size1;
      tbResRef2.Size = size2;
      tbResRef.TabIndex = 0;
      tbResRef.Text = "";
      Label lblResRef1 = lblResRef;
      point1 = new Point(40, 16);
      Point point6 = point1;
      lblResRef1.Location = point6;
      lblResRef.Name = "lblResRef";
      Label lblResRef2 = lblResRef;
      size1 = new Size(96, 16);
      Size size3 = size1;
      lblResRef2.Size = size3;
      lblResRef.TabIndex = 1;
      lblResRef.Text = "TemplateResRef";
      lblResRef.TextAlign = ContentAlignment.MiddleLeft;
      Label label2_1 = Label2;
      point1 = new Point(40, 80);
      Point point7 = point1;
      label2_1.Location = point7;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(88, 16);
      Size size4 = size1;
      label2_2.Size = size4;
      Label2.TabIndex = 1;
      Label2.Text = "X Position";
      Label2.TextAlign = ContentAlignment.MiddleLeft;
      Label label3_1 = Label3;
      point1 = new Point(40, 112);
      Point point8 = point1;
      label3_1.Location = point8;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(88, 16);
      Size size5 = size1;
      label3_2.Size = size5;
      Label3.TabIndex = 1;
      Label3.Text = "Y Position";
      Label3.TextAlign = ContentAlignment.MiddleLeft;
      Label label4_1 = Label4;
      point1 = new Point(40, 144);
      Point point9 = point1;
      label4_1.Location = point9;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(88, 16);
      Size size6 = size1;
      label4_2.Size = size6;
      Label4.TabIndex = 1;
      Label4.Text = "Z Position";
      Label4.TextAlign = ContentAlignment.MiddleLeft;
      PictureBox pboxXy1 = pboxXY;
      point1 = new Point(280, 104);
      Point point10 = point1;
      pboxXy1.Location = point10;
      pboxXY.Name = "pboxXY";
      PictureBox pboxXy2 = pboxXY;
      size1 = new Size(50, 50);
      Size size7 = size1;
      pboxXy2.Size = size7;
      pboxXY.TabIndex = 2;
      pboxXY.TabStop = false;
      nudXY.DecimalPlaces = 2;
      NumericUpDown nudXy1 = nudXY;
      point1 = new Point(277, 160);
      Point point11 = point1;
      nudXy1.Location = point11;
      NumericUpDown nudXy2 = nudXY;
      Decimal num1 = new Decimal(new int[4]
      {
        736755711,
        8381903,
        0,
        917504
      });
      Decimal num2 = num1;
      nudXy2.Maximum = num2;
      nudXY.Name = "nudXY";
      NumericUpDown nudXy3 = nudXY;
      size1 = new Size(64, 20);
      Size size8 = size1;
      nudXy3.Size = size8;
      nudXY.TabIndex = 4;
      nudXY.TextAlign = HorizontalAlignment.Center;
      Button button1 = Button1;
      point1 = new Point(40, 352);
      Point point12 = point1;
      button1.Location = point12;
      Button1.Name = "Button1";
      Button1.TabIndex = 5;
      Button1.Text = "Button1";
      Button1.Visible = false;
      Button2.DialogResult = DialogResult.OK;
      Button button2 = Button2;
      point1 = new Point(296, 352);
      Point point13 = point1;
      button2.Location = point13;
      Button2.Name = "Button2";
      Button2.TabIndex = 5;
      Button2.Text = "OK";
      Button3.DialogResult = DialogResult.Cancel;
      Button button3 = Button3;
      point1 = new Point(392, 352);
      Point point14 = point1;
      button3.Location = point14;
      Button3.Name = "Button3";
      Button3.TabIndex = 5;
      Button3.Text = "Cancel";
      TextBox tbTag1 = tbTag;
      point1 = new Point(152, 48);
      Point point15 = point1;
      tbTag1.Location = point15;
      tbTag.MaxLength = 16;
      tbTag.Name = "tbTag";
      TextBox tbTag2 = tbTag;
      size1 = new Size(184, 20);
      Size size9 = size1;
      tbTag2.Size = size9;
      tbTag.TabIndex = 0;
      tbTag.Text = "";
      Label lblTag1 = lblTag;
      point1 = new Point(40, 48);
      Point point16 = point1;
      lblTag1.Location = point16;
      lblTag.Name = "lblTag";
      Label lblTag2 = lblTag;
      size1 = new Size(96, 16);
      Size size10 = size1;
      lblTag2.Size = size10;
      lblTag.TabIndex = 1;
      lblTag.Text = "Tag";
      lblTag.TextAlign = ContentAlignment.MiddleLeft;
      tabctrl.Controls.Add(tabpagGeneral);
      tabctrl.Controls.Add(tabpagWaypoint);
      tabctrl.Controls.Add(tabpagDoor);
      tabctrl.Controls.Add(tabpagEncounter);
      tabctrl.Controls.Add(tabpagCamera);
      TabControl tabctrl1 = tabctrl;
      point1 = new Point(8, 8);
      Point point17 = point1;
      tabctrl1.Location = point17;
      tabctrl.Name = "tabctrl";
      tabctrl.SelectedIndex = 0;
      TabControl tabctrl2 = tabctrl;
      size1 = new Size(480, 328);
      Size size11 = size1;
      tabctrl2.Size = size11;
      tabctrl.TabIndex = 6;
      tabpagGeneral.Controls.Add(tbXPosition);
      tabpagGeneral.Controls.Add(tbYPosition);
      tabpagGeneral.Controls.Add(tbZPosition);
      tabpagGeneral.Controls.Add(tbTag);
      tabpagGeneral.Controls.Add(tbResRef);
      tabpagGeneral.Controls.Add(lblTag);
      tabpagGeneral.Controls.Add(lblResRef);
      tabpagGeneral.Controls.Add(Label2);
      tabpagGeneral.Controls.Add(Label3);
      tabpagGeneral.Controls.Add(Label4);
      tabpagGeneral.Controls.Add(pboxXY);
      tabpagGeneral.Controls.Add(nudXY);
      tabpagGeneral.Controls.Add(lblBearing);
      TabPage tabpagGeneral1 = tabpagGeneral;
      point1 = new Point(4, 22);
      Point point18 = point1;
      ((Control) tabpagGeneral1).Location = point18;
      tabpagGeneral.Name = "tabpagGeneral";
      TabPage tabpagGeneral2 = tabpagGeneral;
      size1 = new Size(472, 302);
      Size size12 = size1;
      tabpagGeneral2.Size = size12;
      tabpagGeneral.TabIndex = 1;
      tabpagGeneral.Text = "General";
      Label lblBearing1 = lblBearing;
      point1 = new Point(281, 80);
      Point point19 = point1;
      lblBearing1.Location = point19;
      lblBearing.Name = "lblBearing";
      Label lblBearing2 = lblBearing;
      size1 = new Size(48, 16);
      Size size13 = size1;
      lblBearing2.Size = size13;
      lblBearing.TabIndex = 1;
      lblBearing.Text = "Bearing";
      lblBearing.TextAlign = ContentAlignment.MiddleCenter;
      tabpagWaypoint.Controls.Add(btnSetNameLang);
      tabpagWaypoint.Controls.Add(chkbHasMapNote);
      tabpagWaypoint.Controls.Add(Label9);
      tabpagWaypoint.Controls.Add(tbWPLinkedTo);
      tabpagWaypoint.Controls.Add(tbWpDescription);
      tabpagWaypoint.Controls.Add(tbWpMapNote);
      tabpagWaypoint.Controls.Add(Label11);
      tabpagWaypoint.Controls.Add(Label12);
      tabpagWaypoint.Controls.Add(tbWpLocalizedName);
      tabpagWaypoint.Controls.Add(lblLocalizedName);
      tabpagWaypoint.Controls.Add(chkbMapNoteEnabled);
      TabPage tabpagWaypoint1 = tabpagWaypoint;
      point1 = new Point(4, 22);
      Point point20 = point1;
      ((Control) tabpagWaypoint1).Location = point20;
      tabpagWaypoint.Name = "tabpagWaypoint";
      TabPage tabpagWaypoint2 = tabpagWaypoint;
      size1 = new Size(472, 302);
      Size size14 = size1;
      tabpagWaypoint2.Size = size14;
      tabpagWaypoint.TabIndex = 3;
      tabpagWaypoint.Text = "Waypoint Specific";
      btnSetNameLang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Button btnSetNameLang1 = btnSetNameLang;
      point1 = new Point(296, 264);
      Point point21 = point1;
      btnSetNameLang1.Location = point21;
      btnSetNameLang.Name = "btnSetNameLang";
      Button btnSetNameLang2 = btnSetNameLang;
      size1 = new Size(88, 23);
      Size size15 = size1;
      btnSetNameLang2.Size = size15;
      btnSetNameLang.TabIndex = 10;
      btnSetNameLang.Text = "Set Language";
      CheckBox chkbHasMapNote1 = chkbHasMapNote;
      point1 = new Point(48, 168);
      Point point22 = point1;
      chkbHasMapNote1.Location = point22;
      chkbHasMapNote.Name = "chkbHasMapNote";
      CheckBox chkbHasMapNote2 = chkbHasMapNote;
      size1 = new Size(192, 24);
      Size size16 = size1;
      chkbHasMapNote2.Size = size16;
      chkbHasMapNote.TabIndex = 9;
      chkbHasMapNote.Text = "Waypoint Contains a Map Note";
      Label label9_1 = Label9;
      point1 = new Point(48, 16);
      Point point23 = point1;
      label9_1.Location = point23;
      Label9.Name = "Label9";
      Label label9_2 = Label9;
      size1 = new Size(100, 16);
      Size size17 = size1;
      label9_2.Size = size17;
      Label9.TabIndex = 8;
      Label9.Text = "Linked To";
      Label9.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbWpLinkedTo1 = tbWPLinkedTo;
      point1 = new Point(176, 16);
      Point point24 = point1;
      tbWpLinkedTo1.Location = point24;
      tbWPLinkedTo.Name = "tbWPLinkedTo";
      TextBox tbWpLinkedTo2 = tbWPLinkedTo;
      size1 = new Size(208, 20);
      Size size18 = size1;
      tbWpLinkedTo2.Size = size18;
      tbWPLinkedTo.TabIndex = 5;
      tbWPLinkedTo.Text = "";
      TextBox tbWpDescription1 = tbWpDescription;
      point1 = new Point(176, 96);
      Point point25 = point1;
      tbWpDescription1.Location = point25;
      tbWpDescription.Multiline = true;
      tbWpDescription.Name = "tbWpDescription";
      TextBox tbWpDescription2 = tbWpDescription;
      size1 = new Size(208, 60);
      Size size19 = size1;
      tbWpDescription2.Size = size19;
      tbWpDescription.TabIndex = 2;
      tbWpDescription.Text = "";
      TextBox tbWpMapNote1 = tbWpMapNote;
      point1 = new Point(176, 192);
      Point point26 = point1;
      tbWpMapNote1.Location = point26;
      tbWpMapNote.Multiline = true;
      tbWpMapNote.Name = "tbWpMapNote";
      TextBox tbWpMapNote2 = tbWpMapNote;
      size1 = new Size(208, 60);
      Size size20 = size1;
      tbWpMapNote2.Size = size20;
      tbWpMapNote.TabIndex = 3;
      tbWpMapNote.Text = "";
      Label label11_1 = Label11;
      point1 = new Point(48, 96);
      Point point27 = point1;
      label11_1.Location = point27;
      Label11.Name = "Label11";
      Label label11_2 = Label11;
      size1 = new Size(100, 16);
      Size size21 = size1;
      label11_2.Size = size21;
      Label11.TabIndex = 6;
      Label11.Text = "Description";
      Label11.TextAlign = ContentAlignment.MiddleLeft;
      Label label12_1 = Label12;
      point1 = new Point(48, 208);
      Point point28 = point1;
      label12_1.Location = point28;
      Label12.Name = "Label12";
      Label label12_2 = Label12;
      size1 = new Size(120, 16);
      Size size22 = size1;
      label12_2.Size = size22;
      Label12.TabIndex = 7;
      Label12.Text = "Map Note";
      Label12.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbWpLocalizedName1 = tbWpLocalizedName;
      point1 = new Point(176, 56);
      Point point29 = point1;
      tbWpLocalizedName1.Location = point29;
      tbWpLocalizedName.Name = "tbWpLocalizedName";
      TextBox tbWpLocalizedName2 = tbWpLocalizedName;
      size1 = new Size(208, 20);
      Size size23 = size1;
      tbWpLocalizedName2.Size = size23;
      tbWpLocalizedName.TabIndex = 2;
      tbWpLocalizedName.Text = "";
      Label lblLocalizedName1 = lblLocalizedName;
      point1 = new Point(48, 56);
      Point point30 = point1;
      lblLocalizedName1.Location = point30;
      lblLocalizedName.Name = "lblLocalizedName";
      Label lblLocalizedName2 = lblLocalizedName;
      size1 = new Size(100, 16);
      Size size24 = size1;
      lblLocalizedName2.Size = size24;
      lblLocalizedName.TabIndex = 6;
      lblLocalizedName.Text = "Localized Name";
      lblLocalizedName.TextAlign = ContentAlignment.MiddleLeft;
      CheckBox chkbMapNoteEnabled1 = chkbMapNoteEnabled;
      point1 = new Point(256, 168);
      Point point31 = point1;
      chkbMapNoteEnabled1.Location = point31;
      chkbMapNoteEnabled.Name = "chkbMapNoteEnabled";
      CheckBox chkbMapNoteEnabled2 = chkbMapNoteEnabled;
      size1 = new Size(128, 24);
      Size size25 = size1;
      chkbMapNoteEnabled2.Size = size25;
      chkbMapNoteEnabled.TabIndex = 9;
      chkbMapNoteEnabled.Text = "Map Note Enabled";
      tabpagEncounter.Controls.Add(tbBearing);
      tabpagEncounter.Controls.Add(tbxo);
      tabpagEncounter.Controls.Add(tbyo);
      tabpagEncounter.Controls.Add(pboxXYSpawnPointBearing);
      tabpagEncounter.Controls.Add(nudXYSpawnPointBearing);
      tabpagEncounter.Controls.Add(Label25);
      tabpagEncounter.Controls.Add(Label26);
      tabpagEncounter.Controls.Add(nudSpawnPointX);
      tabpagEncounter.Controls.Add(Label27);
      tabpagEncounter.Controls.Add(nudSpawnPointY);
      tabpagEncounter.Controls.Add(Label28);
      tabpagEncounter.Controls.Add(nudSpawnPointZ);
      tabpagEncounter.Controls.Add(Label24);
      tabpagEncounter.Controls.Add(lbSpawnPoints);
      tabpagEncounter.Controls.Add(Label5);
      tabpagEncounter.Controls.Add(Label6);
      tabpagEncounter.Controls.Add(Label7);
      TabPage tabpagEncounter1 = tabpagEncounter;
      point1 = new Point(4, 22);
      Point point32 = point1;
      ((Control) tabpagEncounter1).Location = point32;
      tabpagEncounter.Name = "tabpagEncounter";
      TabPage tabpagEncounter2 = tabpagEncounter;
      size1 = new Size(472, 302);
      Size size26 = size1;
      tabpagEncounter2.Size = size26;
      tabpagEncounter.TabIndex = 5;
      tabpagEncounter.Text = "Encounter Specific";
      TextBox tbBearing1 = tbBearing;
      point1 = new Point(96, 248);
      Point point33 = point1;
      tbBearing1.Location = point33;
      tbBearing.Name = "tbBearing";
      tbBearing.ReadOnly = true;
      TextBox tbBearing2 = tbBearing;
      size1 = new Size(104, 20);
      Size size27 = size1;
      tbBearing2.Size = size27;
      tbBearing.TabIndex = 55;
      tbBearing.Text = "";
      tbBearing.TextAlign = HorizontalAlignment.Right;
      tbBearing.Visible = false;
      TextBox tbxo1 = tbxo;
      point1 = new Point(96, 192);
      Point point34 = point1;
      tbxo1.Location = point34;
      tbxo.Name = "tbxo";
      tbxo.ReadOnly = true;
      TextBox tbxo2 = tbxo;
      size1 = new Size(64, 20);
      Size size28 = size1;
      tbxo2.Size = size28;
      tbxo.TabIndex = 54;
      tbxo.Text = "";
      tbxo.TextAlign = HorizontalAlignment.Right;
      tbxo.Visible = false;
      TextBox tbyo1 = tbyo;
      point1 = new Point(96, 216);
      Point point35 = point1;
      tbyo1.Location = point35;
      tbyo.Name = "tbyo";
      tbyo.ReadOnly = true;
      TextBox tbyo2 = tbyo;
      size1 = new Size(64, 20);
      Size size29 = size1;
      tbyo2.Size = size29;
      tbyo.TabIndex = 53;
      tbyo.Text = "";
      tbyo.TextAlign = HorizontalAlignment.Right;
      tbyo.Visible = false;
      PictureBox spawnPointBearing1 = pboxXYSpawnPointBearing;
      point1 = new Point(336, 80);
      Point point36 = point1;
      spawnPointBearing1.Location = point36;
      pboxXYSpawnPointBearing.Name = "pboxXYSpawnPointBearing";
      PictureBox spawnPointBearing2 = pboxXYSpawnPointBearing;
      size1 = new Size(50, 50);
      Size size30 = size1;
      spawnPointBearing2.Size = size30;
      pboxXYSpawnPointBearing.TabIndex = 51;
      pboxXYSpawnPointBearing.TabStop = false;
      nudXYSpawnPointBearing.DecimalPlaces = 2;
      nudXYSpawnPointBearing.Enabled = false;
      NumericUpDown spawnPointBearing3 = nudXYSpawnPointBearing;
      point1 = new Point(328, 136);
      Point point37 = point1;
      spawnPointBearing3.Location = point37;
      NumericUpDown spawnPointBearing4 = nudXYSpawnPointBearing;
      num1 = new Decimal(new int[4]
      {
        736755711,
        8381903,
        0,
        917504
      });
      Decimal num3 = num1;
      spawnPointBearing4.Maximum = num3;
      nudXYSpawnPointBearing.Name = "nudXYSpawnPointBearing";
      NumericUpDown spawnPointBearing5 = nudXYSpawnPointBearing;
      size1 = new Size(64, 20);
      Size size31 = size1;
      spawnPointBearing5.Size = size31;
      nudXYSpawnPointBearing.TabIndex = 52;
      nudXYSpawnPointBearing.TextAlign = HorizontalAlignment.Center;
      Label label25_1 = Label25;
      point1 = new Point(336, 56);
      Point point38 = point1;
      label25_1.Location = point38;
      Label25.Name = "Label25";
      Label label25_2 = Label25;
      size1 = new Size(48, 16);
      Size size32 = size1;
      label25_2.Size = size32;
      Label25.TabIndex = 50;
      Label25.Text = "Bearing";
      Label25.TextAlign = ContentAlignment.MiddleCenter;
      Label label26_1 = Label26;
      point1 = new Point(168, 64);
      Point point39 = point1;
      label26_1.Location = point39;
      Label26.Name = "Label26";
      Label label26_2 = Label26;
      size1 = new Size(16, 16);
      Size size33 = size1;
      label26_2.Size = size33;
      Label26.TabIndex = 48;
      Label26.Text = "X";
      Label26.TextAlign = ContentAlignment.MiddleRight;
      nudSpawnPointX.DecimalPlaces = 4;
      nudSpawnPointX.Enabled = false;
      NumericUpDown nudSpawnPointX1 = nudSpawnPointX;
      point1 = new Point(200, 64);
      Point point40 = point1;
      nudSpawnPointX1.Location = point40;
      NumericUpDown nudSpawnPointX2 = nudSpawnPointX;
      num1 = new Decimal(new int[4]{ 4000, 0, 0, 0 });
      Decimal num4 = num1;
      nudSpawnPointX2.Maximum = num4;
      NumericUpDown nudSpawnPointX3 = nudSpawnPointX;
      num1 = new Decimal(new int[4]
      {
        4000,
        0,
        0,
        int.MinValue
      });
      Decimal num5 = num1;
      nudSpawnPointX3.Minimum = num5;
      nudSpawnPointX.Name = "nudSpawnPointX";
      NumericUpDown nudSpawnPointX4 = nudSpawnPointX;
      size1 = new Size(96, 20);
      Size size34 = size1;
      nudSpawnPointX4.Size = size34;
      nudSpawnPointX.TabIndex = 44;
      nudSpawnPointX.TextAlign = HorizontalAlignment.Right;
      Label label27_1 = Label27;
      point1 = new Point(168, 96);
      Point point41 = point1;
      label27_1.Location = point41;
      Label27.Name = "Label27";
      Label label27_2 = Label27;
      size1 = new Size(16, 16);
      Size size35 = size1;
      label27_2.Size = size35;
      Label27.TabIndex = 49;
      Label27.Text = "Y";
      Label27.TextAlign = ContentAlignment.MiddleRight;
      nudSpawnPointY.DecimalPlaces = 4;
      nudSpawnPointY.Enabled = false;
      NumericUpDown nudSpawnPointY1 = nudSpawnPointY;
      point1 = new Point(200, 96);
      Point point42 = point1;
      nudSpawnPointY1.Location = point42;
      NumericUpDown nudSpawnPointY2 = nudSpawnPointY;
      num1 = new Decimal(new int[4]{ 4000, 0, 0, 0 });
      Decimal num6 = num1;
      nudSpawnPointY2.Maximum = num6;
      NumericUpDown nudSpawnPointY3 = nudSpawnPointY;
      num1 = new Decimal(new int[4]
      {
        4000,
        0,
        0,
        int.MinValue
      });
      Decimal num7 = num1;
      nudSpawnPointY3.Minimum = num7;
      nudSpawnPointY.Name = "nudSpawnPointY";
      NumericUpDown nudSpawnPointY4 = nudSpawnPointY;
      size1 = new Size(96, 20);
      Size size36 = size1;
      nudSpawnPointY4.Size = size36;
      nudSpawnPointY.TabIndex = 45;
      nudSpawnPointY.TextAlign = HorizontalAlignment.Right;
      Label label28_1 = Label28;
      point1 = new Point(168, 128);
      Point point43 = point1;
      label28_1.Location = point43;
      Label28.Name = "Label28";
      Label label28_2 = Label28;
      size1 = new Size(16, 16);
      Size size37 = size1;
      label28_2.Size = size37;
      Label28.TabIndex = 47;
      Label28.Text = "Z";
      Label28.TextAlign = ContentAlignment.MiddleRight;
      nudSpawnPointZ.DecimalPlaces = 4;
      nudSpawnPointZ.Enabled = false;
      NumericUpDown nudSpawnPointZ1 = nudSpawnPointZ;
      point1 = new Point(200, 128);
      Point point44 = point1;
      nudSpawnPointZ1.Location = point44;
      NumericUpDown nudSpawnPointZ2 = nudSpawnPointZ;
      num1 = new Decimal(new int[4]{ 4000, 0, 0, 0 });
      Decimal num8 = num1;
      nudSpawnPointZ2.Maximum = num8;
      NumericUpDown nudSpawnPointZ3 = nudSpawnPointZ;
      num1 = new Decimal(new int[4]
      {
        4000,
        0,
        0,
        int.MinValue
      });
      Decimal num9 = num1;
      nudSpawnPointZ3.Minimum = num9;
      nudSpawnPointZ.Name = "nudSpawnPointZ";
      NumericUpDown nudSpawnPointZ4 = nudSpawnPointZ;
      size1 = new Size(96, 20);
      Size size38 = size1;
      nudSpawnPointZ4.Size = size38;
      nudSpawnPointZ.TabIndex = 46;
      nudSpawnPointZ.TextAlign = HorizontalAlignment.Right;
      Label label24_1 = Label24;
      point1 = new Point(72, 32);
      Point point45 = point1;
      label24_1.Location = point45;
      Label24.Name = "Label24";
      Label label24_2 = Label24;
      size1 = new Size(80, 16);
      Size size39 = size1;
      label24_2.Size = size39;
      Label24.TabIndex = 43;
      Label24.Text = "Spawn Points";
      ListBox lbSpawnPoints1 = lbSpawnPoints;
      point1 = new Point(80, 56);
      Point point46 = point1;
      lbSpawnPoints1.Location = point46;
      lbSpawnPoints.Name = "lbSpawnPoints";
      lbSpawnPoints.ScrollAlwaysVisible = true;
      ListBox lbSpawnPoints2 = lbSpawnPoints;
      size1 = new Size(56, 95);
      Size size40 = size1;
      lbSpawnPoints2.Size = size40;
      lbSpawnPoints.TabIndex = 42;
      Label label5_1 = Label5;
      point1 = new Point(64, 192);
      Point point47 = point1;
      label5_1.Location = point47;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(16, 16);
      Size size41 = size1;
      label5_2.Size = size41;
      Label5.TabIndex = 48;
      Label5.Text = "X";
      Label5.TextAlign = ContentAlignment.MiddleRight;
      Label5.Visible = false;
      Label label6_1 = Label6;
      point1 = new Point(64, 216);
      Point point48 = point1;
      label6_1.Location = point48;
      Label6.Name = "Label6";
      Label label6_2 = Label6;
      size1 = new Size(16, 16);
      Size size42 = size1;
      label6_2.Size = size42;
      Label6.TabIndex = 49;
      Label6.Text = "Y";
      Label6.TextAlign = ContentAlignment.MiddleRight;
      Label6.Visible = false;
      Label label7_1 = Label7;
      point1 = new Point(224, 40);
      Point point49 = point1;
      label7_1.Location = point49;
      Label7.Name = "Label7";
      Label label7_2 = Label7;
      size1 = new Size(48, 16);
      Size size43 = size1;
      label7_2.Size = size43;
      Label7.TabIndex = 50;
      Label7.Text = "Position";
      Label7.TextAlign = ContentAlignment.MiddleCenter;
      tabpagDoor.Controls.Add(gbTriggerNode);
      tabpagDoor.Controls.Add(cmbxDoorLinkedToFlags);
      tabpagDoor.Controls.Add(lblDoorLinkedTo);
      tabpagDoor.Controls.Add(tbDoorLinkedTo);
      tabpagDoor.Controls.Add(tbDoorLinkedToModule);
      tabpagDoor.Controls.Add(tbDoorLinkedToTransitionDestin);
      tabpagDoor.Controls.Add(lblDoorLinkedToFlags);
      tabpagDoor.Controls.Add(lblDoorLinkedToModule);
      tabpagDoor.Controls.Add(lblDoorLinkedToTransitionDestin);
      tabpagDoor.Controls.Add(lblTransitionMsg);
      TabPage tabpagDoor1 = tabpagDoor;
      point1 = new Point(4, 22);
      Point point50 = point1;
      ((Control) tabpagDoor1).Location = point50;
      tabpagDoor.Name = "tabpagDoor";
      TabPage tabpagDoor2 = tabpagDoor;
      size1 = new Size(472, 302);
      Size size44 = size1;
      tabpagDoor2.Size = size44;
      tabpagDoor.TabIndex = 0;
      tabpagDoor.Text = "Door/Trigger Specific";
      gbTriggerNode.Controls.Add(Label23);
      gbTriggerNode.Controls.Add(tbTriggerNodeYPosition);
      gbTriggerNode.Controls.Add(tbTriggerNodeXPosition);
      gbTriggerNode.Controls.Add(Label22);
      gbTriggerNode.Controls.Add(tbTriggerNodeZPosition);
      gbTriggerNode.Controls.Add(Label21);
      GroupBox gbTriggerNode1 = gbTriggerNode;
      point1 = new Point(16, 176);
      Point point51 = point1;
      gbTriggerNode1.Location = point51;
      gbTriggerNode.Name = "gbTriggerNode";
      GroupBox gbTriggerNode2 = gbTriggerNode;
      size1 = new Size(304, 120);
      Size size45 = size1;
      gbTriggerNode2.Size = size45;
      gbTriggerNode.TabIndex = 9;
      gbTriggerNode.TabStop = false;
      gbTriggerNode.Text = "Trigger Node";
      gbTriggerNode.Visible = false;
      Label label23_1 = Label23;
      point1 = new Point(24, 88);
      Point point52 = point1;
      label23_1.Location = point52;
      Label23.Name = "Label23";
      Label label23_2 = Label23;
      size1 = new Size(88, 16);
      Size size46 = size1;
      label23_2.Size = size46;
      Label23.TabIndex = 6;
      Label23.Text = "Z Position";
      Label23.TextAlign = ContentAlignment.MiddleLeft;
      TextBox triggerNodeYposition = tbTriggerNodeYPosition;
      point1 = new Point(136, 56);
      Point point53 = point1;
      triggerNodeYposition.Location = point53;
      tbTriggerNodeYPosition.Name = "tbTriggerNodeYPosition";
      tbTriggerNodeYPosition.TabIndex = 4;
      tbTriggerNodeYPosition.Text = "";
      tbTriggerNodeYPosition.TextAlign = HorizontalAlignment.Right;
      TextBox triggerNodeXposition = tbTriggerNodeXPosition;
      point1 = new Point(136, 24);
      Point point54 = point1;
      triggerNodeXposition.Location = point54;
      tbTriggerNodeXPosition.Name = "tbTriggerNodeXPosition";
      tbTriggerNodeXPosition.TabIndex = 5;
      tbTriggerNodeXPosition.Text = "";
      tbTriggerNodeXPosition.TextAlign = HorizontalAlignment.Right;
      Label label22_1 = Label22;
      point1 = new Point(24, 56);
      Point point55 = point1;
      label22_1.Location = point55;
      Label22.Name = "Label22";
      Label label22_2 = Label22;
      size1 = new Size(88, 16);
      Size size47 = size1;
      label22_2.Size = size47;
      Label22.TabIndex = 7;
      Label22.Text = "Y Position";
      Label22.TextAlign = ContentAlignment.MiddleLeft;
      TextBox triggerNodeZposition = tbTriggerNodeZPosition;
      point1 = new Point(136, 88);
      Point point56 = point1;
      triggerNodeZposition.Location = point56;
      tbTriggerNodeZPosition.Name = "tbTriggerNodeZPosition";
      tbTriggerNodeZPosition.TabIndex = 3;
      tbTriggerNodeZPosition.Text = "";
      tbTriggerNodeZPosition.TextAlign = HorizontalAlignment.Right;
      Label label21_1 = Label21;
      point1 = new Point(24, 24);
      Point point57 = point1;
      label21_1.Location = point57;
      Label21.Name = "Label21";
      Label label21_2 = Label21;
      size1 = new Size(88, 16);
      Size size48 = size1;
      label21_2.Size = size48;
      Label21.TabIndex = 8;
      Label21.Text = "X Position";
      Label21.TextAlign = ContentAlignment.MiddleLeft;
      cmbxDoorLinkedToFlags.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxDoorLinkedToFlags.Items.AddRange(new object[3]
      {
        "Does not link to anything",
        "Is an Area Transition and links to a Door",
        "Is an Area Transition and links to a Waypoint"
      });
      ComboBox doorLinkedToFlags1 = cmbxDoorLinkedToFlags;
      point1 = new Point(152, 16);
      Point point58 = point1;
      doorLinkedToFlags1.Location = point58;
      cmbxDoorLinkedToFlags.Name = "cmbxDoorLinkedToFlags";
      ComboBox doorLinkedToFlags2 = cmbxDoorLinkedToFlags;
      size1 = new Size(272, 21);
      Size size49 = size1;
      doorLinkedToFlags2.Size = size49;
      cmbxDoorLinkedToFlags.TabIndex = 2;
      Label lblDoorLinkedTo1 = lblDoorLinkedTo;
      point1 = new Point(40, 80);
      Point point59 = point1;
      lblDoorLinkedTo1.Location = point59;
      lblDoorLinkedTo.Name = "lblDoorLinkedTo";
      Label lblDoorLinkedTo2 = lblDoorLinkedTo;
      size1 = new Size(100, 16);
      Size size50 = size1;
      lblDoorLinkedTo2.Size = size50;
      lblDoorLinkedTo.TabIndex = 1;
      lblDoorLinkedTo.Text = "Linked To";
      lblDoorLinkedTo.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbDoorLinkedTo1 = tbDoorLinkedTo;
      point1 = new Point(152, 80);
      Point point60 = point1;
      tbDoorLinkedTo1.Location = point60;
      tbDoorLinkedTo.Name = "tbDoorLinkedTo";
      TextBox tbDoorLinkedTo2 = tbDoorLinkedTo;
      size1 = new Size(208, 20);
      Size size51 = size1;
      tbDoorLinkedTo2.Size = size51;
      tbDoorLinkedTo.TabIndex = 0;
      tbDoorLinkedTo.Text = "";
      TextBox doorLinkedToModule1 = tbDoorLinkedToModule;
      point1 = new Point(152, 48);
      Point point61 = point1;
      doorLinkedToModule1.Location = point61;
      tbDoorLinkedToModule.Name = "tbDoorLinkedToModule";
      TextBox doorLinkedToModule2 = tbDoorLinkedToModule;
      size1 = new Size(208, 20);
      Size size52 = size1;
      doorLinkedToModule2.Size = size52;
      tbDoorLinkedToModule.TabIndex = 0;
      tbDoorLinkedToModule.Text = "";
      TextBox transitionDestin1 = tbDoorLinkedToTransitionDestin;
      point1 = new Point(152, 112);
      Point point62 = point1;
      transitionDestin1.Location = point62;
      tbDoorLinkedToTransitionDestin.Name = "tbDoorLinkedToTransitionDestin";
      TextBox transitionDestin2 = tbDoorLinkedToTransitionDestin;
      size1 = new Size(208, 20);
      Size size53 = size1;
      transitionDestin2.Size = size53;
      tbDoorLinkedToTransitionDestin.TabIndex = 0;
      tbDoorLinkedToTransitionDestin.Text = "";
      Label doorLinkedToFlags3 = lblDoorLinkedToFlags;
      point1 = new Point(40, 16);
      Point point63 = point1;
      doorLinkedToFlags3.Location = point63;
      lblDoorLinkedToFlags.Name = "lblDoorLinkedToFlags";
      Label doorLinkedToFlags4 = lblDoorLinkedToFlags;
      size1 = new Size(100, 16);
      Size size54 = size1;
      doorLinkedToFlags4.Size = size54;
      lblDoorLinkedToFlags.TabIndex = 1;
      lblDoorLinkedToFlags.Text = "Linked To Flag";
      lblDoorLinkedToFlags.TextAlign = ContentAlignment.MiddleLeft;
      Label doorLinkedToModule3 = lblDoorLinkedToModule;
      point1 = new Point(40, 48);
      Point point64 = point1;
      doorLinkedToModule3.Location = point64;
      lblDoorLinkedToModule.Name = "lblDoorLinkedToModule";
      Label doorLinkedToModule4 = lblDoorLinkedToModule;
      size1 = new Size(100, 16);
      Size size55 = size1;
      doorLinkedToModule4.Size = size55;
      lblDoorLinkedToModule.TabIndex = 1;
      lblDoorLinkedToModule.Text = "Linked To Module";
      lblDoorLinkedToModule.TextAlign = ContentAlignment.MiddleLeft;
      Label transitionDestin3 = lblDoorLinkedToTransitionDestin;
      point1 = new Point(40, 114);
      Point point65 = point1;
      transitionDestin3.Location = point65;
      lblDoorLinkedToTransitionDestin.Name = "lblDoorLinkedToTransitionDestin";
      Label transitionDestin4 = lblDoorLinkedToTransitionDestin;
      size1 = new Size(120, 16);
      Size size56 = size1;
      transitionDestin4.Size = size56;
      lblDoorLinkedToTransitionDestin.TabIndex = 1;
      lblDoorLinkedToTransitionDestin.Text = "Transition Destination";
      lblDoorLinkedToTransitionDestin.TextAlign = ContentAlignment.MiddleLeft;
      Label lblTransitionMsg1 = lblTransitionMsg;
      point1 = new Point(32, 144);
      Point point66 = point1;
      lblTransitionMsg1.Location = point66;
      lblTransitionMsg.Name = "lblTransitionMsg";
      Label lblTransitionMsg2 = lblTransitionMsg;
      size1 = new Size(432, 16);
      Size size57 = size1;
      lblTransitionMsg2.Size = size57;
      lblTransitionMsg.TabIndex = 1;
      lblTransitionMsg.Text = "Note: To enable the above fields, set the type to Transition in the Trigger editor.";
      lblTransitionMsg.TextAlign = ContentAlignment.MiddleLeft;
      lblTransitionMsg.Visible = false;
      tabpagCamera.Controls.Add(Label29);
      tabpagCamera.Controls.Add(nudCamOrientationX);
      tabpagCamera.Controls.Add(btnShowQuaternion);
      tabpagCamera.Controls.Add(Label1);
      tabpagCamera.Controls.Add(tbCamPitch);
      tabpagCamera.Controls.Add(tbCamHeight);
      tabpagCamera.Controls.Add(Label15);
      tabpagCamera.Controls.Add(tbCamMicRange);
      tabpagCamera.Controls.Add(Label16);
      tabpagCamera.Controls.Add(Label17);
      tabpagCamera.Controls.Add(tbCamFieldOfView);
      tabpagCamera.Controls.Add(tbCamOrientationF1);
      tabpagCamera.Controls.Add(tbCamOrientationF2);
      tabpagCamera.Controls.Add(tbCamOrientationF4);
      tabpagCamera.Controls.Add(tbCamOrientationF3);
      tabpagCamera.Controls.Add(lblQuaternionW);
      tabpagCamera.Controls.Add(Label18);
      tabpagCamera.Controls.Add(Label19);
      tabpagCamera.Controls.Add(Label20);
      tabpagCamera.Controls.Add(tbCamOrientationZ);
      tabpagCamera.Controls.Add(tbCamOrientationX);
      tabpagCamera.Controls.Add(tbCamOrientationY);
      tabpagCamera.Controls.Add(nudCamOrientationY);
      tabpagCamera.Controls.Add(nudCamOrientationZ);
      tabpagCamera.Controls.Add(Label14);
      TabPage tabpagCamera1 = tabpagCamera;
      point1 = new Point(4, 22);
      Point point67 = point1;
      ((Control) tabpagCamera1).Location = point67;
      tabpagCamera.Name = "tabpagCamera";
      TabPage tabpagCamera2 = tabpagCamera;
      size1 = new Size(472, 302);
      Size size58 = size1;
      tabpagCamera2.Size = size58;
      tabpagCamera.TabIndex = 2;
      tabpagCamera.Text = "Camera Specific";
      Label label29_1 = Label29;
      point1 = new Point(256, 8);
      Point point68 = point1;
      label29_1.Location = point68;
      Label29.Name = "Label29";
      Label label29_2 = Label29;
      size1 = new Size(176, 40);
      Size size59 = size1;
      label29_2.Size = size59;
      Label29.TabIndex = 10;
      Label29.Text = "(Use this value or the one below to set the camera's pitch but not both. Set unused one to 0)";
      NumericUpDown nudCamOrientationX1 = nudCamOrientationX;
      point1 = new Point(152, 168);
      Point point69 = point1;
      nudCamOrientationX1.Location = point69;
      NumericUpDown nudCamOrientationX2 = nudCamOrientationX;
      num1 = new Decimal(new int[4]{ 179, 0, 0, 0 });
      Decimal num10 = num1;
      nudCamOrientationX2.Maximum = num10;
      NumericUpDown nudCamOrientationX3 = nudCamOrientationX;
      num1 = new Decimal(new int[4]
      {
        179,
        0,
        0,
        int.MinValue
      });
      Decimal num11 = num1;
      nudCamOrientationX3.Minimum = num11;
      nudCamOrientationX.Name = "nudCamOrientationX";
      NumericUpDown nudCamOrientationX4 = nudCamOrientationX;
      size1 = new Size(48, 20);
      Size size60 = size1;
      nudCamOrientationX4.Size = size60;
      nudCamOrientationX.TabIndex = 9;
      nudCamOrientationX.TextAlign = HorizontalAlignment.Right;
      btnShowQuaternion.FlatStyle = FlatStyle.Flat;
      btnShowQuaternion.ForeColor = SystemColors.Control;
      Button btnShowQuaternion1 = btnShowQuaternion;
      point1 = new Point(376, 168);
      Point point70 = point1;
      btnShowQuaternion1.Location = point70;
      btnShowQuaternion.Name = "btnShowQuaternion";
      Button btnShowQuaternion2 = btnShowQuaternion;
      size1 = new Size(24, 23);
      Size size61 = size1;
      btnShowQuaternion2.Size = size61;
      btnShowQuaternion.TabIndex = 8;
      Label label1_1 = Label1;
      point1 = new Point(40, 16);
      Point point71 = point1;
      label1_1.Location = point71;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(100, 16);
      Size size62 = size1;
      label1_2.Size = size62;
      Label1.TabIndex = 3;
      Label1.Text = "Pitch";
      Label1.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbCamPitch1 = tbCamPitch;
      point1 = new Point(152, 16);
      Point point72 = point1;
      tbCamPitch1.Location = point72;
      tbCamPitch.Name = "tbCamPitch";
      TextBox tbCamPitch2 = tbCamPitch;
      size1 = new Size(64, 20);
      Size size63 = size1;
      tbCamPitch2.Size = size63;
      tbCamPitch.TabIndex = 0;
      tbCamPitch.Text = "";
      TextBox tbCamHeight1 = tbCamHeight;
      point1 = new Point(152, 48);
      Point point73 = point1;
      tbCamHeight1.Location = point73;
      tbCamHeight.Name = "tbCamHeight";
      TextBox tbCamHeight2 = tbCamHeight;
      size1 = new Size(64, 20);
      Size size64 = size1;
      tbCamHeight2.Size = size64;
      tbCamHeight.TabIndex = 1;
      tbCamHeight.Text = "";
      Label label15_1 = Label15;
      point1 = new Point(40, 48);
      Point point74 = point1;
      label15_1.Location = point74;
      Label15.Name = "Label15";
      Label label15_2 = Label15;
      size1 = new Size(100, 16);
      Size size65 = size1;
      label15_2.Size = size65;
      Label15.TabIndex = 3;
      Label15.Text = "Height";
      Label15.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbCamMicRange1 = tbCamMicRange;
      point1 = new Point(152, 80);
      Point point75 = point1;
      tbCamMicRange1.Location = point75;
      tbCamMicRange.Name = "tbCamMicRange";
      TextBox tbCamMicRange2 = tbCamMicRange;
      size1 = new Size(64, 20);
      Size size66 = size1;
      tbCamMicRange2.Size = size66;
      tbCamMicRange.TabIndex = 2;
      tbCamMicRange.Text = "";
      Label label16_1 = Label16;
      point1 = new Point(40, 80);
      Point point76 = point1;
      label16_1.Location = point76;
      Label16.Name = "Label16";
      Label label16_2 = Label16;
      size1 = new Size(100, 16);
      Size size67 = size1;
      label16_2.Size = size67;
      Label16.TabIndex = 3;
      Label16.Text = "Mic Range";
      Label16.TextAlign = ContentAlignment.MiddleLeft;
      Label label17_1 = Label17;
      point1 = new Point(40, 112);
      Point point77 = point1;
      label17_1.Location = point77;
      Label17.Name = "Label17";
      Label label17_2 = Label17;
      size1 = new Size(100, 16);
      Size size68 = size1;
      label17_2.Size = size68;
      Label17.TabIndex = 3;
      Label17.Text = "Field of View";
      Label17.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbCamFieldOfView1 = tbCamFieldOfView;
      point1 = new Point(152, 112);
      Point point78 = point1;
      tbCamFieldOfView1.Location = point78;
      tbCamFieldOfView.Name = "tbCamFieldOfView";
      TextBox tbCamFieldOfView2 = tbCamFieldOfView;
      size1 = new Size(64, 20);
      Size size69 = size1;
      tbCamFieldOfView2.Size = size69;
      tbCamFieldOfView.TabIndex = 3;
      tbCamFieldOfView.Text = "";
      TextBox camOrientationF1_1 = tbCamOrientationF1;
      point1 = new Point(24, 224);
      Point point79 = point1;
      camOrientationF1_1.Location = point79;
      tbCamOrientationF1.Name = "tbCamOrientationF1";
      tbCamOrientationF1.ReadOnly = true;
      TextBox camOrientationF1_2 = tbCamOrientationF1;
      size1 = new Size(88, 20);
      Size size70 = size1;
      camOrientationF1_2.Size = size70;
      tbCamOrientationF1.TabIndex = 4;
      tbCamOrientationF1.Text = "";
      tbCamOrientationF1.Visible = false;
      TextBox camOrientationF2_1 = tbCamOrientationF2;
      point1 = new Point(136, 224);
      Point point80 = point1;
      camOrientationF2_1.Location = point80;
      tbCamOrientationF2.Name = "tbCamOrientationF2";
      tbCamOrientationF2.ReadOnly = true;
      TextBox camOrientationF2_2 = tbCamOrientationF2;
      size1 = new Size(88, 20);
      Size size71 = size1;
      camOrientationF2_2.Size = size71;
      tbCamOrientationF2.TabIndex = 5;
      tbCamOrientationF2.Text = "";
      tbCamOrientationF2.Visible = false;
      TextBox camOrientationF4_1 = tbCamOrientationF4;
      point1 = new Point(360, 224);
      Point point81 = point1;
      camOrientationF4_1.Location = point81;
      tbCamOrientationF4.Name = "tbCamOrientationF4";
      tbCamOrientationF4.ReadOnly = true;
      TextBox camOrientationF4_2 = tbCamOrientationF4;
      size1 = new Size(88, 20);
      Size size72 = size1;
      camOrientationF4_2.Size = size72;
      tbCamOrientationF4.TabIndex = 7;
      tbCamOrientationF4.Text = "";
      tbCamOrientationF4.Visible = false;
      TextBox camOrientationF3_1 = tbCamOrientationF3;
      point1 = new Point(248, 224);
      Point point82 = point1;
      camOrientationF3_1.Location = point82;
      tbCamOrientationF3.Name = "tbCamOrientationF3";
      tbCamOrientationF3.ReadOnly = true;
      TextBox camOrientationF3_2 = tbCamOrientationF3;
      size1 = new Size(88, 20);
      Size size73 = size1;
      camOrientationF3_2.Size = size73;
      tbCamOrientationF3.TabIndex = 6;
      tbCamOrientationF3.Text = "";
      tbCamOrientationF3.Visible = false;
      Label lblQuaternionW1 = lblQuaternionW;
      point1 = new Point(24, 200);
      Point point83 = point1;
      lblQuaternionW1.Location = point83;
      lblQuaternionW.Name = "lblQuaternionW";
      Label lblQuaternionW2 = lblQuaternionW;
      size1 = new Size(40, 16);
      Size size74 = size1;
      lblQuaternionW2.Size = size74;
      lblQuaternionW.TabIndex = 3;
      lblQuaternionW.Text = "W";
      lblQuaternionW.TextAlign = ContentAlignment.MiddleLeft;
      lblQuaternionW.Visible = false;
      Label label18_1 = Label18;
      point1 = new Point(160, 144);
      Point point84 = point1;
      label18_1.Location = point84;
      Label18.Name = "Label18";
      Label label18_2 = Label18;
      size1 = new Size(40, 16);
      Size size75 = size1;
      label18_2.Size = size75;
      Label18.TabIndex = 3;
      Label18.Text = "Pitch";
      Label18.TextAlign = ContentAlignment.MiddleLeft;
      Label label19_1 = Label19;
      point1 = new Point(240, 144);
      Point point85 = point1;
      label19_1.Location = point85;
      Label19.Name = "Label19";
      Label label19_2 = Label19;
      size1 = new Size(40, 16);
      Size size76 = size1;
      label19_2.Size = size76;
      Label19.TabIndex = 3;
      Label19.Text = "Roll";
      Label19.TextAlign = ContentAlignment.MiddleLeft;
      Label label20_1 = Label20;
      point1 = new Point(320, 144);
      Point point86 = point1;
      label20_1.Location = point86;
      Label20.Name = "Label20";
      Label label20_2 = Label20;
      size1 = new Size(40, 16);
      Size size77 = size1;
      label20_2.Size = size77;
      Label20.TabIndex = 3;
      Label20.Text = "Yaw";
      Label20.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbCamOrientationZ1 = tbCamOrientationZ;
      point1 = new Point(360, 264);
      Point point87 = point1;
      tbCamOrientationZ1.Location = point87;
      tbCamOrientationZ.Name = "tbCamOrientationZ";
      TextBox tbCamOrientationZ2 = tbCamOrientationZ;
      size1 = new Size(88, 20);
      Size size78 = size1;
      tbCamOrientationZ2.Size = size78;
      tbCamOrientationZ.TabIndex = 7;
      tbCamOrientationZ.Text = "";
      tbCamOrientationZ.TextAlign = HorizontalAlignment.Right;
      tbCamOrientationZ.Visible = false;
      tbCamOrientationZ.WordWrap = false;
      ErrorProvider1.SetIconAlignment(tbCamOrientationX, ErrorIconAlignment.MiddleLeft);
      TextBox tbCamOrientationX1 = tbCamOrientationX;
      point1 = new Point(136, 264);
      Point point88 = point1;
      tbCamOrientationX1.Location = point88;
      tbCamOrientationX.Name = "tbCamOrientationX";
      TextBox tbCamOrientationX2 = tbCamOrientationX;
      size1 = new Size(88, 20);
      Size size79 = size1;
      tbCamOrientationX2.Size = size79;
      tbCamOrientationX.TabIndex = 5;
      tbCamOrientationX.Text = "";
      tbCamOrientationX.TextAlign = HorizontalAlignment.Right;
      tbCamOrientationX.Visible = false;
      tbCamOrientationX.WordWrap = false;
      TextBox tbCamOrientationY1 = tbCamOrientationY;
      point1 = new Point(248, 264);
      Point point89 = point1;
      tbCamOrientationY1.Location = point89;
      tbCamOrientationY.Name = "tbCamOrientationY";
      TextBox tbCamOrientationY2 = tbCamOrientationY;
      size1 = new Size(88, 20);
      Size size80 = size1;
      tbCamOrientationY2.Size = size80;
      tbCamOrientationY.TabIndex = 6;
      tbCamOrientationY.Text = "";
      tbCamOrientationY.TextAlign = HorizontalAlignment.Right;
      tbCamOrientationY.Visible = false;
      tbCamOrientationY.WordWrap = false;
      NumericUpDown nudCamOrientationY1 = nudCamOrientationY;
      point1 = new Point(232, 168);
      Point point90 = point1;
      nudCamOrientationY1.Location = point90;
      NumericUpDown nudCamOrientationY2 = nudCamOrientationY;
      num1 = new Decimal(new int[4]{ 179, 0, 0, 0 });
      Decimal num12 = num1;
      nudCamOrientationY2.Maximum = num12;
      NumericUpDown nudCamOrientationY3 = nudCamOrientationY;
      num1 = new Decimal(new int[4]
      {
        179,
        0,
        0,
        int.MinValue
      });
      Decimal num13 = num1;
      nudCamOrientationY3.Minimum = num13;
      nudCamOrientationY.Name = "nudCamOrientationY";
      NumericUpDown nudCamOrientationY4 = nudCamOrientationY;
      size1 = new Size(48, 20);
      Size size81 = size1;
      nudCamOrientationY4.Size = size81;
      nudCamOrientationY.TabIndex = 9;
      nudCamOrientationY.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudCamOrientationZ1 = nudCamOrientationZ;
      point1 = new Point(312, 168);
      Point point91 = point1;
      nudCamOrientationZ1.Location = point91;
      NumericUpDown nudCamOrientationZ2 = nudCamOrientationZ;
      num1 = new Decimal(new int[4]{ 179, 0, 0, 0 });
      Decimal num14 = num1;
      nudCamOrientationZ2.Maximum = num14;
      NumericUpDown nudCamOrientationZ3 = nudCamOrientationZ;
      num1 = new Decimal(new int[4]
      {
        179,
        0,
        0,
        int.MinValue
      });
      Decimal num15 = num1;
      nudCamOrientationZ3.Minimum = num15;
      nudCamOrientationZ.Name = "nudCamOrientationZ";
      NumericUpDown nudCamOrientationZ4 = nudCamOrientationZ;
      size1 = new Size(48, 20);
      Size size82 = size1;
      nudCamOrientationZ4.Size = size82;
      nudCamOrientationZ.TabIndex = 9;
      nudCamOrientationZ.TextAlign = HorizontalAlignment.Right;
      Label label14_1 = Label14;
      point1 = new Point(40, 168);
      Point point92 = point1;
      label14_1.Location = point92;
      Label14.Name = "Label14";
      Label label14_2 = Label14;
      size1 = new Size(80, 16);
      Size size83 = size1;
      label14_2.Size = size83;
      Label14.TabIndex = 3;
      Label14.Text = "Camera Angle";
      Label14.TextAlign = ContentAlignment.MiddleLeft;
      ErrorProvider1.ContainerControl = this;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(504, 389);
      ClientSize = size1;
      Controls.Add(tabctrl);
      Controls.Add(Button1);
      Controls.Add(Button2);
      Controls.Add(Button3);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      MaximizeBox = false;
      MinimizeBox = false;
      Name = nameof (frmModuleItem_Base_Editor);
      StartPosition = FormStartPosition.CenterParent;
      Text = "";
      nudXY.EndInit();
      tabctrl.ResumeLayout(false);
      tabpagGeneral.ResumeLayout(false);
      tabpagWaypoint.ResumeLayout(false);
      tabpagEncounter.ResumeLayout(false);
      nudXYSpawnPointBearing.EndInit();
      nudSpawnPointX.EndInit();
      nudSpawnPointY.EndInit();
      nudSpawnPointZ.EndInit();
      tabpagDoor.ResumeLayout(false);
      gbTriggerNode.ResumeLayout(false);
      tabpagCamera.ResumeLayout(false);
      nudCamOrientationX.EndInit();
      nudCamOrientationY.EndInit();
      nudCamOrientationZ.EndInit();
      ResumeLayout(false);
    }

  public void SetupOrientationIndicators()
  {
      float num = (float) Math.Atan2(_YOrientation, _XOrientation);
      _XYAngle = Math.Atan2(_YOrientation, _XOrientation * -1.0) * 180.0 / Math.PI - 90.0;
      if (_XYAngle < 0.0)
        _XYAngle += 360.0;
      nudXY.Value = new Decimal(_XYAngle);
      DrawXYOrientation();
    }

  public void SetupOrientationIndicators(float XOrientation, float YOrientation)
  {
      _XOrientation = XOrientation;
      _YOrientation = YOrientation;
      SetupOrientationIndicators();
    }

  private void DrawXYOrientation()
  {
      Graphics graphics = Graphics.FromImage(bmpXY);
      graphics.FillEllipse(Brushes.White, 0, 0, 49, 49);
      graphics.DrawArc(new Pen(Color.Black), 0, 0, 49, 49, 0, 360);
      graphics.DrawPie(new Pen(Color.Black), 0.0f, 0.0f, 49f, 49f, (float) _XYAngle, 1f);
      bmpXY.RotateFlip(RotateFlipType.Rotate270FlipNone);
      pboxXY.Image = bmpXY;
    }

  public void SetupOrientationIndicatorsSpawnPointBearing()
  {
      float num = (float) Math.Atan2(_YOrientation, _XOrientation);
      _XYAngle = Math.Atan2(_YOrientation, _XOrientation * -1.0) * 180.0 / Math.PI - 90.0;
      if (_XYAngle < 0.0)
        _XYAngle += 360.0;
      nudXYSpawnPointBearing.Value = new Decimal(_XYAngle);
      DrawXYOrientationSpawnPointBearing();
    }

  public void SetupOrientationIndicatorsSpawnPointBearing(float XOrientation, float YOrientation)
  {
      _XOrientation = XOrientation;
      _YOrientation = YOrientation;
      SetupOrientationIndicatorsSpawnPointBearing();
    }

  private void DrawXYOrientationSpawnPointBearing()
  {
      Graphics graphics = Graphics.FromImage(bmpXYSpawnPointBearing);
      graphics.FillEllipse(Brushes.White, 0, 0, 49, 49);
      graphics.DrawArc(new Pen(Color.Black), 0, 0, 49, 49, 0, 360);
      graphics.DrawPie(new Pen(Color.Black), 0.0f, 0.0f, 49f, 49f, (float) _SpawnPointXYAngle, 1f);
      bmpXYSpawnPointBearing.RotateFlip(RotateFlipType.Rotate270FlipNone);
      pboxXYSpawnPointBearing.Image = bmpXYSpawnPointBearing;
    }

  public void SetupForItemType(int type)
  {
      if (type != 2042 && type != 2058)
      {
        tbTag.Visible = false;
        lblTag.Visible = false;
      }
      switch (type)
      {
        case 6:
          Text = "Camera Properties";
          tabctrl.TabPages.Remove(tabpagDoor);
          tabctrl.TabPages.Remove(tabpagWaypoint);
          tabctrl.TabPages.Remove(tabpagEncounter);
          tabctrl.TabPages[0].Controls.Remove(lblBearing);
          tabctrl.TabPages[0].Controls.Remove(nudXY);
          break;
        case 2027:
          Text = "Creature Properties";
          tabctrl.TabPages.Remove(tabpagCamera);
          tabctrl.TabPages.Remove(tabpagDoor);
          tabctrl.TabPages.Remove(tabpagWaypoint);
          tabctrl.TabPages.Remove(tabpagEncounter);
          break;
        case 2032:
          Text = "Trigger Properties";
          tabctrl.TabPages.Remove(tabpagCamera);
          tabctrl.TabPages.Remove(tabpagWaypoint);
          tabctrl.TabPages[0].Controls.Remove(lblBearing);
          tabctrl.TabPages[0].Controls.Remove(nudXY);
          tabctrl.TabPages.Remove(tabpagEncounter);
          break;
        case 2035:
          Text = "Sound Properties";
          tabctrl.TabPages.Remove(tabpagCamera);
          tabctrl.TabPages.Remove(tabpagDoor);
          tabctrl.TabPages.Remove(tabpagWaypoint);
          tabctrl.TabPages[0].Controls.Remove(lblBearing);
          tabctrl.TabPages[0].Controls.Remove(nudXY);
          tabctrl.TabPages.Remove(tabpagEncounter);
          tbTag.Visible = false;
          lblTag.Visible = false;
          break;
        case 2040:
          Text = "Encounter Properties";
          tabctrl.TabPages.Remove(tabpagCamera);
          tabctrl.TabPages.Remove(tabpagDoor);
          tabctrl.TabPages.Remove(tabpagWaypoint);
          tbTag.Visible = false;
          lblTag.Visible = false;
          tabctrl.TabPages[0].Controls.Remove(lblBearing);
          tabctrl.TabPages[0].Controls.Remove(pboxXY);
          tabctrl.TabPages[0].Controls.Remove(nudXY);
          break;
        case 2042:
          Text = "Door Properties";
          tabctrl.TabPages.Remove(tabpagCamera);
          tabctrl.TabPages.Remove(tabpagWaypoint);
          gbTriggerNode.Visible = false;
          tabctrl.TabPages.Remove(tabpagEncounter);
          break;
        case 2044:
          Text = "Placeable Properties";
          tabctrl.TabPages.Remove(tabpagCamera);
          tabctrl.TabPages.Remove(tabpagDoor);
          tabctrl.TabPages.Remove(tabpagWaypoint);
          tabctrl.TabPages.Remove(tabpagEncounter);
          tbTag.Visible = false;
          lblTag.Visible = false;
          break;
        case 2051:
          Text = "Merchant Properties";
          tabctrl.TabPages.Remove(tabpagCamera);
          tabctrl.TabPages.Remove(tabpagDoor);
          tabctrl.TabPages.Remove(tabpagWaypoint);
          tabctrl.TabPages.Remove(tabpagEncounter);
          lblResRef.Text = "ResRef";
          tbTag.Visible = false;
          lblTag.Visible = false;
          break;
        case 2058:
          Text = "Waypoint Properties";
          tabctrl.TabPages.Remove(tabpagCamera);
          tabctrl.TabPages.Remove(tabpagDoor);
          tabctrl.TabPages.Remove(tabpagEncounter);
          break;
      }
      tabctrl.SelectedTab = tabpagGeneral;
    }

  public void DisableLinkedToFields()
  {
      lblDoorLinkedTo.Enabled = false;
      lblDoorLinkedToFlags.Enabled = false;
      lblDoorLinkedToModule.Enabled = false;
      lblDoorLinkedToTransitionDestin.Enabled = false;
      tbDoorLinkedTo.Enabled = false;
      cmbxDoorLinkedToFlags.Enabled = false;
      tbDoorLinkedToModule.Enabled = false;
      tbDoorLinkedToTransitionDestin.Enabled = false;
      lblTransitionMsg.Visible = true;
    }

  public float XOrientation
  {
    get => _XOrientation;
    set => _XOrientation = value;
  }

  public float YOrientation
  {
    get => _YOrientation;
    set => _YOrientation = value;
  }

  public float get_Bearing(int ModItemType)
  {
      switch (ModItemType)
      {
        case 2042:
          return _XYAngle > 180.0 ? (float) (-(_XYAngle - 180.0) / 180.0 * Math.PI) : (float) ((180.0 - _XYAngle) / 180.0 * Math.PI);
        case 2044:
          return _XYAngle > 90.0 ? (float) ((270.0 - _XYAngle) / 180.0 * Math.PI) : (float) (-(_XYAngle + 90.0) / 180.0 * Math.PI);
        default:
          float bearing = 0;
          return bearing;
      }
    }

  public void set_Bearing(int ModItemType, float Value)
  {
      switch (ModItemType)
      {
        case 2042:
          SetupOrientationIndicators((float) Math.Sin(Value), (float) -Math.Cos(Value));
          break;
        case 2044:
          SetupOrientationIndicators((float) -Math.Cos(Value), (float) -Math.Sin(Value));
          break;
      }
      _Bearing = Value;
      tbBearing.Text = StringType.FromSingle(Value);
    }

  public float XYAngle
  {
    get => (float) _XYAngle;
    set => _XYAngle = value;
  }

  public float SpawnPointBearing
  {
    get => _Bearing;
    set
    {
        _Bearing = value;
        _SpawnPointXYAngle = _Bearing >= 0.0 ? _Bearing / Math.PI * 180.0 : _Bearing / Math.PI * 180.0 + 360.0;
        DrawXYOrientationSpawnPointBearing();
        tbBearing.Text = StringType.FromSingle(value);
        nudXYSpawnPointBearing.ValueChanged -= new EventHandler(nudXYSpawnPointBearing_ValueChanged);
        nudXYSpawnPointBearing.Value = new Decimal(_SpawnPointXYAngle);
        nudXYSpawnPointBearing.ValueChanged += new EventHandler(nudXYSpawnPointBearing_ValueChanged);
      }
  }

  public float SpawnPointXYAngle
  {
    get => (float) _SpawnPointXYAngle;
    set => _SpawnPointXYAngle = value;
  }

  public GFFType16[] SpawnPoints
  {
    get => _SpawnPoints;
    set
    {
        _SpawnPoints = value;
        int length = _SpawnPoints.Length;
        int num = 1;
        while (num <= length)
        {
          lbSpawnPoints.Items.Add(num);
          checked { ++num; }
        }
      }
  }

  public int NameLang
  {
    get => _nameLang;
    set => _nameLang = value;
  }

  public GFFType16 CameraOrientationQuat
  {
    get
    {
        GFFType16 cameraOrientationQuat = new GFFType16();
        double num1 = Convert.ToDouble(nudCamOrientationX.Value) * Math.PI / 180.0;
        double num2 = Convert.ToDouble(nudCamOrientationY.Value) * Math.PI / 180.0;
        double num3 = Convert.ToDouble(nudCamOrientationZ.Value) * Math.PI / 180.0;
        double num4 = Math.Cos(num3 / 2.0);
        double num5 = Math.Cos(num2 / 2.0);
        double num6 = Math.Cos(num1 / 2.0);
        double num7 = Math.Sin(num3 / 2.0);
        double num8 = Math.Sin(num2 / 2.0);
        double num9 = Math.Sin(num1 / 2.0);
        double x1 = num4 * num5 * num6 - num7 * num8 * num9;
        double x2 = num4 * num5 * num9 - num7 * num8 * num6;
        double x3 = num4 * num8 * num6 + num7 * num5 * num9;
        double x4 = num7 * num5 * num6 - num4 * num8 * num9;
        double num10 = Math.Sqrt(Math.Pow(x1, 2.0) + Math.Pow(x2, 2.0) + Math.Pow(x3, 2.0) + Math.Pow(x4, 2.0));
        cameraOrientationQuat.W = Convert.ToSingle(x1 / num10);
        cameraOrientationQuat.X = Convert.ToSingle(x2 / num10);
        cameraOrientationQuat.Y = Convert.ToSingle(x3 / num10);
        cameraOrientationQuat.Z = Convert.ToSingle(x4 / num10);
        return cameraOrientationQuat;
      }
    set
    {
        tbCamOrientationF1.Text = StringType.FromSingle(value.W);
        tbCamOrientationF2.Text = StringType.FromSingle(value.X);
        tbCamOrientationF3.Text = StringType.FromSingle(value.Y);
        tbCamOrientationF4.Text = StringType.FromSingle(value.Z);
      }
  }

  public GFFType17 CameraOrientationEulerAngles
  {
    set
    {
        nudCamOrientationX.Value = new Decimal(value.X);
        nudCamOrientationY.Value = new Decimal(value.Y);
        nudCamOrientationZ.Value = new Decimal(value.Z);
      }
    get => new GFFType17()
    {
      X = Convert.ToSingle(nudCamOrientationX.Value),
      Y = Convert.ToSingle(nudCamOrientationY.Value),
      Z = Convert.ToSingle(nudCamOrientationZ.Value)
    };
  }

  private void btnSetNameLang_Click(object sender, EventArgs e)
  {
      frmCExoLocStringLanguagePicker stringLanguagePicker = new frmCExoLocStringLanguagePicker(NameLang);
      if (stringLanguagePicker.ShowDialog(this) != DialogResult.OK)
        return;
      NameLang = stringLanguagePicker.LanguageID;
    }

  private void nudXY_KeyUp(object sender, KeyEventArgs e)
  {
      _XYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, null, "value", new object[0], null, null));
      DrawXYOrientation();
      _XOrientation = -(float) Math.Round(Math.Cos((_XYAngle + 90.0) / 180.0 * Math.PI), 5);
      _YOrientation = (float) Math.Round(Math.Sin((_XYAngle + 90.0) / 180.0 * Math.PI), 5);
      tbxo.Text = StringType.FromSingle(_XOrientation);
      tbyo.Text = StringType.FromSingle(_YOrientation);
    }

  private void nudXY_ValueChanged(object sender, EventArgs e)
  {
      _XYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, null, "value", new object[0], null, null));
      DrawXYOrientation();
      _XOrientation = -(float) Math.Round(Math.Cos((_XYAngle + 90.0) / 180.0 * Math.PI), 5);
      _YOrientation = (float) Math.Round(Math.Sin((_XYAngle + 90.0) / 180.0 * Math.PI), 5);
      tbxo.Text = StringType.FromSingle(_XOrientation);
      tbyo.Text = StringType.FromSingle(_YOrientation);
    }

  private void nudXYSpawnPointBearing_ValueChanged(object sender, EventArgs e)
  {
      _SpawnPointXYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, null, "value", new object[0], null, null));
      DrawXYOrientationSpawnPointBearing();
      _Bearing = _SpawnPointXYAngle > 180.0 ? (float) ((_SpawnPointXYAngle - 360.0) / 180.0 * Math.PI) : (float) (_SpawnPointXYAngle / 180.0 * Math.PI);
      if (lbSpawnPoints.SelectedIndex != -1)
        _SpawnPoints[lbSpawnPoints.SelectedIndex].W = _Bearing;
      tbBearing.Text = StringType.FromSingle(_Bearing);
    }

  private void btnShowQuaternion_MouseDown(object sender, MouseEventArgs e)
  {
      tbCamOrientationF1.Visible = true;
      tbCamOrientationF2.Visible = true;
      tbCamOrientationF3.Visible = true;
      tbCamOrientationF4.Visible = true;
      lblQuaternionW.Visible = true;
    }

  private void btnShowQuaternion_MouseUp(object sender, MouseEventArgs e)
  {
      tbCamOrientationF1.Visible = false;
      tbCamOrientationF2.Visible = false;
      tbCamOrientationF3.Visible = false;
      tbCamOrientationF4.Visible = false;
      lblQuaternionW.Visible = false;
    }

  private void nudCamOrientation_ValueChanged(object sender, EventArgs e) => ErrorProvider1.SetError(nudCamOrientationX, "");

  private void lbSpawnPoints_SelectedIndexChanged(object sender, EventArgs e)
  {
      nudSpawnPointX.Enabled = true;
      nudSpawnPointY.Enabled = true;
      nudSpawnPointZ.Enabled = true;
      nudXYSpawnPointBearing.Enabled = true;
      nudSpawnPointX.Value = new Decimal(_SpawnPoints[lbSpawnPoints.SelectedIndex].X);
      nudSpawnPointY.Value = new Decimal(_SpawnPoints[lbSpawnPoints.SelectedIndex].Y);
      nudSpawnPointZ.Value = new Decimal(_SpawnPoints[lbSpawnPoints.SelectedIndex].Z);
      SpawnPointBearing = _SpawnPoints[lbSpawnPoints.SelectedIndex].W;
    }

  private void nudXYSpawnPointBearing_KeyUp(object sender, KeyEventArgs e) => nudXYSpawnPointBearing.Value = nudXYSpawnPointBearing.Value;
}