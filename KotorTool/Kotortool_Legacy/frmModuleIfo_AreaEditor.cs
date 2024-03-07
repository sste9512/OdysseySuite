// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmModuleIfo_AreaEditor
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmModuleIfo_AreaEditor : frmParent
{
    [AccessedThroughProperty("rbAlwaysDay")]
    private RadioButton _rbAlwaysDay;

    [AccessedThroughProperty("rbDayNightCycle")]
    private RadioButton _rbDayNightCycle;

    [AccessedThroughProperty("btnMoonAmbientColor")]
    private Button _btnMoonAmbientColor;

    [AccessedThroughProperty("btnMoonDiffuseColor")]
    private Button _btnMoonDiffuseColor;

    [AccessedThroughProperty("chkbAreaSunShadows")]
    private CheckBox _chkbAreaSunShadows;

    [AccessedThroughProperty("gbMoon")] private GroupBox _gbMoon;
    [AccessedThroughProperty("gbSun")] private GroupBox _gbSun;

    [AccessedThroughProperty("btnSunAmbientColor")]
    private Button _btnSunAmbientColor;

    [AccessedThroughProperty("btnSunDiffuseColor")]
    private Button _btnSunDiffuseColor;

    [AccessedThroughProperty("tabpagAreaEnvironment")]
    private TabPage _tabpagAreaEnvironment;

    [AccessedThroughProperty("tabpagAreaGrass")]
    private TabPage _tabpagAreaGrass;

    [AccessedThroughProperty("tabpagAreaBasic")]
    private TabPage _tabpagAreaBasic;

    [AccessedThroughProperty("btnGrassEmissiveColor")]
    private Button _btnGrassEmissiveColor;

    [AccessedThroughProperty("Label45")] private Label _Label45;
    [AccessedThroughProperty("Label47")] private Label _Label47;
    [AccessedThroughProperty("Label49")] private Label _Label49;
    [AccessedThroughProperty("Label50")] private Label _Label50;
    [AccessedThroughProperty("Label51")] private Label _Label51;

    [AccessedThroughProperty("tabpagAreaAudio")]
    private TabPage _tabpagAreaAudio;

    [AccessedThroughProperty("Label52")] private Label _Label52;

    [AccessedThroughProperty("trkbarAmbientSndDayVol")]
    private TrackBar _trkbarAmbientSndDayVol;

    [AccessedThroughProperty("Label34")] private Label _Label34;

    [AccessedThroughProperty("cmbxAmbientSndDay")]
    private ComboBox _cmbxAmbientSndDay;

    [AccessedThroughProperty("trkbarAmbientSndNightVol")]
    private TrackBar _trkbarAmbientSndNightVol;

    [AccessedThroughProperty("nudMusicDelay")]
    private NumericUpDown _nudMusicDelay;

    [AccessedThroughProperty("cmbxMusicNight")]
    private ComboBox _cmbxMusicNight;

    [AccessedThroughProperty("Label35")] private Label _Label35;
    [AccessedThroughProperty("Label25")] private Label _Label25;

    [AccessedThroughProperty("cmbxMusicDay")]
    private ComboBox _cmbxMusicDay;

    [AccessedThroughProperty("Label36")] private Label _Label36;

    [AccessedThroughProperty("cmbxMusicBattle")]
    private ComboBox _cmbxMusicBattle;

    [AccessedThroughProperty("cmbxEnvAudio")]
    private ComboBox _cmbxEnvAudio;

    [AccessedThroughProperty("cmbxAmbientSndNight")]
    private ComboBox _cmbxAmbientSndNight;

    [AccessedThroughProperty("tbGrass_TexName")]
    private TextBox _tbGrass_TexName;

    [AccessedThroughProperty("trkbarGrassDensityX10")]
    private TrackBar _trkbarGrassDensityX10;

    [AccessedThroughProperty("Label62")] private Label _Label62;

    [AccessedThroughProperty("nudGrassDensity")]
    private NumericUpDown _nudGrassDensity;

    [AccessedThroughProperty("Label63")] private Label _Label63;
    [AccessedThroughProperty("Label31")] private Label _Label31;
    [AccessedThroughProperty("Label64")] private Label _Label64;
    [AccessedThroughProperty("Label53")] private Label _Label53;
    [AccessedThroughProperty("Label54")] private Label _Label54;
    [AccessedThroughProperty("Label55")] private Label _Label55;
    [AccessedThroughProperty("Label2")] private Label _Label2;
    [AccessedThroughProperty("Label37")] private Label _Label37;

    [AccessedThroughProperty("lblSunFogNear")]
    private Label _lblSunFogNear;

    [AccessedThroughProperty("lblMoonFogFar")]
    private Label _lblMoonFogFar;

    [AccessedThroughProperty("Label33")] private Label _Label33;

    [AccessedThroughProperty("lblMoonFogNear")]
    private Label _lblMoonFogNear;

    [AccessedThroughProperty("Label65")] private Label _Label65;
    [AccessedThroughProperty("Label66")] private Label _Label66;
    [AccessedThroughProperty("Label67")] private Label _Label67;

    [AccessedThroughProperty("nudGrassProbUL")]
    private NumericUpDown _nudGrassProbUL;

    [AccessedThroughProperty("nudGrassProbLL")]
    private NumericUpDown _nudGrassProbLL;

    [AccessedThroughProperty("nudGrassProbUR")]
    private NumericUpDown _nudGrassProbUR;

    [AccessedThroughProperty("Label38")] private Label _Label38;

    [AccessedThroughProperty("tbModEntryArea")]
    private TextBox _tbModEntryArea;

    [AccessedThroughProperty("lblBearing")]
    private Label _lblBearing;

    [AccessedThroughProperty("nudXY")] private NumericUpDown _nudXY;
    [AccessedThroughProperty("pboxXY")] private PictureBox _pboxXY;
    [AccessedThroughProperty("Label86")] private Label _Label86;

    [AccessedThroughProperty("chkbDisableTransit")]
    private CheckBox _chkbDisableTransit;

    [AccessedThroughProperty("Label85")] private Label _Label85;

    [AccessedThroughProperty("chkbUnescapable")]
    private CheckBox _chkbUnescapable;

    [AccessedThroughProperty("Label84")] private Label _Label84;

    [AccessedThroughProperty("cmbxWindPower")]
    private ComboBox _cmbxWindPower;

    [AccessedThroughProperty("btnSetAreaNameLang")]
    private Button _btnSetAreaNameLang;

    [AccessedThroughProperty("btnSetModNameLang")]
    private Button _btnSetModNameLang;

    [AccessedThroughProperty("tbModDescription")]
    private TextBox _tbModDescription;

    [AccessedThroughProperty("nudRoomForceRating")]
    private NumericUpDown _nudRoomForceRating;

    [AccessedThroughProperty("tbRoomName")]
    private TextBox _tbRoomName;

    [AccessedThroughProperty("cmbxRoomEnvAudio")]
    private ComboBox _cmbxRoomEnvAudio;

    [AccessedThroughProperty("nudRoomAmbientScale")]
    private NumericUpDown _nudRoomAmbientScale;

    [AccessedThroughProperty("chkbRoomDisableWeather")]
    private CheckBox _chkbRoomDisableWeather;

    [AccessedThroughProperty("Label83")] private Label _Label83;
    [AccessedThroughProperty("lbRooms")] private ListBox _lbRooms;
    [AccessedThroughProperty("Label56")] private Label _Label56;
    [AccessedThroughProperty("Label6")] private Label _Label6;
    [AccessedThroughProperty("Label57")] private Label _Label57;
    [AccessedThroughProperty("Label7")] private Label _Label7;
    [AccessedThroughProperty("Label82")] private Label _Label82;
    [AccessedThroughProperty("Label58")] private Label _Label58;
    [AccessedThroughProperty("Label8")] private Label _Label8;
    [AccessedThroughProperty("Label59")] private Label _Label59;
    [AccessedThroughProperty("Label9")] private Label _Label9;
    [AccessedThroughProperty("Label60")] private Label _Label60;
    [AccessedThroughProperty("Label81")] private Label _Label81;
    [AccessedThroughProperty("Label10")] private Label _Label10;
    [AccessedThroughProperty("Label61")] private Label _Label61;

    [AccessedThroughProperty("tabpagModuleBasic")]
    private TabPage _tabpagModuleBasic;

    [AccessedThroughProperty("tabpagModuleAdvanced")]
    private TabPage _tabpagModuleAdvanced;

    [AccessedThroughProperty("btnGrassAmbientColor")]
    private Button _btnGrassAmbientColor;

    [AccessedThroughProperty("nudGrassProbLR")]
    private NumericUpDown _nudGrassProbLR;

    [AccessedThroughProperty("btnGrassDiffuseColor")]
    private Button _btnGrassDiffuseColor;

    [AccessedThroughProperty("Label80")] private Label _Label80;
    [AccessedThroughProperty("Label79")] private Label _Label79;
    [AccessedThroughProperty("Label78")] private Label _Label78;

    [AccessedThroughProperty("tabpagAreaRooms")]
    private TabPage _tabpagAreaRooms;

    [AccessedThroughProperty("tbArea_OnUserDefined")]
    private TextBox _tbArea_OnUserDefined;

    [AccessedThroughProperty("Label77")] private Label _Label77;
    [AccessedThroughProperty("Label5")] private Label _Label5;
    [AccessedThroughProperty("Label76")] private Label _Label76;
    [AccessedThroughProperty("Label4")] private Label _Label4;

    [AccessedThroughProperty("tbArea_OnHeartbeat")]
    private TextBox _tbArea_OnHeartbeat;

    [AccessedThroughProperty("tbArea_OnExit")]
    private TextBox _tbArea_OnExit;

    [AccessedThroughProperty("Label3")] private Label _Label3;
    [AccessedThroughProperty("Label75")] private Label _Label75;

    [AccessedThroughProperty("tbArea_OnEnter")]
    private TextBox _tbArea_OnEnter;

    [AccessedThroughProperty("Label1")] private Label _Label1;
    [AccessedThroughProperty("Label74")] private Label _Label74;

    [AccessedThroughProperty("ColorDialog1")]
    private ColorDialog _ColorDialog1;

    [AccessedThroughProperty("TabControlArea")]
    private TabControl _TabControlArea;

    [AccessedThroughProperty("TabControlMain")]
    private TabControl _TabControlMain;

    [AccessedThroughProperty("TabControlModule")]
    private TabControl _TabControlModule;

    [AccessedThroughProperty("NumericUpDown12")]
    private NumericUpDown _NumericUpDown12;

    [AccessedThroughProperty("tabpagArea_Events")]
    private TabPage _tabpagArea_Events;

    [AccessedThroughProperty("tabpagModuleEvents")]
    private TabPage _tabpagModuleEvents;

    [AccessedThroughProperty("tabpagModuleDescription")]
    private TabPage _tabpagModuleDescription;

    [AccessedThroughProperty("nudModEntryX")]
    private NumericUpDown _nudModEntryX;

    [AccessedThroughProperty("nudModEntryY")]
    private NumericUpDown _nudModEntryY;

    [AccessedThroughProperty("Label48")] private Label _Label48;
    [AccessedThroughProperty("Label32")] private Label _Label32;

    [AccessedThroughProperty("btnDynAmbientColor")]
    private Button _btnDynAmbientColor;

    [AccessedThroughProperty("lblSunFogFar")]
    private Label _lblSunFogFar;

    [AccessedThroughProperty("nudModEntryZ")]
    private NumericUpDown _nudModEntryZ;

    [AccessedThroughProperty("GroupBox1")] private GroupBox _GroupBox1;

    [AccessedThroughProperty("lblTotalGrassProbability")]
    private Label _lblTotalGrassProbability;

    [AccessedThroughProperty("tbModTag")] private TextBox _tbModTag;

    [AccessedThroughProperty("nudShadowOpacity")]
    private NumericUpDown _nudShadowOpacity;

    [AccessedThroughProperty("tbModName")] private TextBox _tbModName;

    [AccessedThroughProperty("nudMinutesPerHour")]
    private NumericUpDown _nudMinutesPerHour;

    [AccessedThroughProperty("Label11")] private Label _Label11;

    [AccessedThroughProperty("nudDawnStartHour")]
    private NumericUpDown _nudDawnStartHour;

    [AccessedThroughProperty("btnOK")] private Button _btnOK;

    [AccessedThroughProperty("nudDuskStartHour")]
    private NumericUpDown _nudDuskStartHour;

    [AccessedThroughProperty("btnCancel")] private Button _btnCancel;
    [AccessedThroughProperty("Label73")] private Label _Label73;

    [AccessedThroughProperty("cmbxCameraStyle")]
    private ComboBox _cmbxCameraStyle;

    [AccessedThroughProperty("tbAreaName")]
    private TextBox _tbAreaName;

    [AccessedThroughProperty("nudStartHour")]
    private NumericUpDown _nudStartHour;

    [AccessedThroughProperty("tbAreaTag")] private TextBox _tbAreaTag;

    [AccessedThroughProperty("nudStartDay")]
    private NumericUpDown _nudStartDay;

    [AccessedThroughProperty("nudStartMonth")]
    private NumericUpDown _nudStartMonth;

    [AccessedThroughProperty("Label12")] private Label _Label12;
    [AccessedThroughProperty("Label40")] private Label _Label40;
    [AccessedThroughProperty("Label41")] private Label _Label41;
    [AccessedThroughProperty("Label42")] private Label _Label42;
    [AccessedThroughProperty("Label43")] private Label _Label43;
    [AccessedThroughProperty("Label44")] private Label _Label44;
    [AccessedThroughProperty("Label46")] private Label _Label46;

    [AccessedThroughProperty("nudXPScale")]
    private NumericUpDown _nudXPScale;

    [AccessedThroughProperty("trkbarXPScale")]
    private TrackBar _trkbarXPScale;

    [AccessedThroughProperty("nudGrassQuadSize")]
    private NumericUpDown _nudGrassQuadSize;

    [AccessedThroughProperty("Label26")] private Label _Label26;

    [AccessedThroughProperty("nudStartYear")]
    private NumericUpDown _nudStartYear;

    [AccessedThroughProperty("tbMod_OnClientEntr")]
    private TextBox _tbMod_OnClientEntr;

    [AccessedThroughProperty("tbMod_OnActvtItem")]
    private TextBox _tbMod_OnActvtItem;

    [AccessedThroughProperty("Label68")] private Label _Label68;

    [AccessedThroughProperty("btnSetDescriptionLang")]
    private Button _btnSetDescriptionLang;

    [AccessedThroughProperty("Label72")] private Label _Label72;
    [AccessedThroughProperty("Label27")] private Label _Label27;

    [AccessedThroughProperty("tbMod_OnAcquirItem")]
    private TextBox _tbMod_OnAcquirItem;

    [AccessedThroughProperty("tbMod_OnClientLeav")]
    private TextBox _tbMod_OnClientLeav;

    [AccessedThroughProperty("Label13")] private Label _Label13;

    [AccessedThroughProperty("tbMod_OnHeartbeat")]
    private TextBox _tbMod_OnHeartbeat;

    [AccessedThroughProperty("Label14")] private Label _Label14;
    [AccessedThroughProperty("Label28")] private Label _Label28;

    [AccessedThroughProperty("tbMod_OnModLoad")]
    private TextBox _tbMod_OnModLoad;

    [AccessedThroughProperty("nudChanceLightning")]
    private NumericUpDown _nudChanceLightning;

    [AccessedThroughProperty("Label71")] private Label _Label71;
    [AccessedThroughProperty("Label15")] private Label _Label15;

    [AccessedThroughProperty("btnMoonFogColor")]
    private Button _btnMoonFogColor;

    [AccessedThroughProperty("Label16")] private Label _Label16;
    [AccessedThroughProperty("Label29")] private Label _Label29;

    [AccessedThroughProperty("chkbAreaMoonShadows")]
    private CheckBox _chkbAreaMoonShadows;

    [AccessedThroughProperty("Label17")] private Label _Label17;

    [AccessedThroughProperty("btnSunFogColor")]
    private Button _btnSunFogColor;

    [AccessedThroughProperty("Label18")] private Label _Label18;

    [AccessedThroughProperty("rbAlwaysNight")]
    private RadioButton _rbAlwaysNight;

    [AccessedThroughProperty("Label19")] private Label _Label19;

    [AccessedThroughProperty("tbMod_OnPlrDeath")]
    private TextBox _tbMod_OnPlrDeath;

    [AccessedThroughProperty("Label20")] private Label _Label20;
    [AccessedThroughProperty("Label70")] private Label _Label70;

    [AccessedThroughProperty("tbMod_OnPlrDying")]
    private TextBox _tbMod_OnPlrDying;

    [AccessedThroughProperty("Label21")] private Label _Label21;

    [AccessedThroughProperty("tbMod_OnPlrLvlUp")]
    private TextBox _tbMod_OnPlrLvlUp;

    [AccessedThroughProperty("TabPage5")] private TabPage _TabPage5;
    [AccessedThroughProperty("TabPage6")] private TabPage _TabPage6;

    [AccessedThroughProperty("NumericUpDown10")]
    private NumericUpDown _NumericUpDown10;

    [AccessedThroughProperty("NumericUpDown11")]
    private NumericUpDown _NumericUpDown11;

    [AccessedThroughProperty("Label22")] private Label _Label22;

    [AccessedThroughProperty("tbMod_OnSpawnBtnDn")]
    private TextBox _tbMod_OnSpawnBtnDn;

    [AccessedThroughProperty("Label23")] private Label _Label23;

    [AccessedThroughProperty("tbMod_OnPlrRest")]
    private TextBox _tbMod_OnPlrRest;

    [AccessedThroughProperty("Label24")] private Label _Label24;
    [AccessedThroughProperty("Label69")] private Label _Label69;

    [AccessedThroughProperty("tbMod_OnUnAqreItem")]
    private TextBox _tbMod_OnUnAqreItem;

    [AccessedThroughProperty("tbMod_OnUsrDefined")]
    private TextBox _tbMod_OnUsrDefined;

    [AccessedThroughProperty("chkbSunFogOn")]
    private CheckBox _chkbSunFogOn;

    [AccessedThroughProperty("chkbMoonFogOn")]
    private CheckBox _chkbMoonFogOn;

    [AccessedThroughProperty("trkbarSunFogNear")]
    private TrackBar _trkbarSunFogNear;

    [AccessedThroughProperty("trkbarSunFogFar")]
    private TrackBar _trkbarSunFogFar;

    [AccessedThroughProperty("Label30")] private Label _Label30;
    [AccessedThroughProperty("Label39")] private Label _Label39;

    [AccessedThroughProperty("trkbarMoonFogNear")]
    private TrackBar _trkbarMoonFogNear;

    [AccessedThroughProperty("trkbarMoonFogFar")]
    private TrackBar _trkbarMoonFogFar;

    [AccessedThroughProperty("nudChanceSnow")]
    private NumericUpDown _nudChanceSnow;

    [AccessedThroughProperty("nudChanceRain")]
    private NumericUpDown _nudChanceRain;

    private IContainer components;
    private ClsGff _AREFile;
    private ClsGff _IFOFile;
    private ClsGff _GITFile;
    private ChitinKey _ChitinKey;
    private clsDialogTlk _DialogTlk;
    private bool ComboBoxSettingError;
    private Room[] Rooms;
    private Bitmap bmpXY;
    private double _XYAngle;
    private float _XOrientation;
    private float _YOrientation;
    private float _origXOrientation;
    private float _origYOrientation;
    private float _Bearing;
    private float _Xpos;
    private float _origXPos;
    private float _Ypos;
    private float _origYpos;
    private float _Zpos;
    private float _origZpos;
    private int ModDescriptionLang;
    private int ModNameLang;
    private int AreaNameLang;

    public frmModuleIfo_AreaEditor()
    {
            ComboBoxSettingError = false;
            bmpXY = new Bitmap(50, 50);
            _XYAngle = 0.0;
            InitializeComponent();
        }

    protected override void Dispose(bool disposing)
    {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

    internal virtual Label Label34
    {
        get => _Label34;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label34 == null)
                    ;
                _Label34 = value;
                if (_Label34 == null)
                    ;
            }
    }

    internal virtual Label Label33
    {
        get => _Label33;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label33 == null)
                    ;
                _Label33 = value;
                if (_Label33 == null)
                    ;
            }
    }

    internal virtual Label Label32
    {
        get => _Label32;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label32 == null)
                    ;
                _Label32 = value;
                if (_Label32 == null)
                    ;
            }
    }

    internal virtual Label Label35
    {
        get => _Label35;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
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
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label36 == null)
                    ;
                _Label36 = value;
                if (_Label36 == null)
                    ;
            }
    }

    internal virtual Label Label37
    {
        get => _Label37;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label37 == null)
                    ;
                _Label37 = value;
                if (_Label37 == null)
                    ;
            }
    }

    internal virtual Label Label38
    {
        get => _Label38;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label38 == null)
                    ;
                _Label38 = value;
                if (_Label38 == null)
                    ;
            }
    }

    internal virtual Label Label39
    {
        get => _Label39;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label39 == null)
                    ;
                _Label39 = value;
                if (_Label39 == null)
                    ;
            }
    }

    internal virtual Label Label40
    {
        get => _Label40;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label40 == null)
                    ;
                _Label40 = value;
                if (_Label40 == null)
                    ;
            }
    }

    internal virtual Label Label41
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label41 == null)
                    ;
                _Label41 = value;
                if (_Label41 == null)
                    ;
            }
        get => _Label41;
    }

    internal virtual Label Label42
    {
        get => _Label42;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label42 == null)
                    ;
                _Label42 = value;
                if (_Label42 == null)
                    ;
            }
    }

    internal virtual Label Label43
    {
        get => _Label43;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label43 == null)
                    ;
                _Label43 = value;
                if (_Label43 == null)
                    ;
            }
    }

    internal virtual Label Label44
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label44 == null)
                    ;
                _Label44 = value;
                if (_Label44 == null)
                    ;
            }
        get => _Label44;
    }

    internal virtual Label Label46
    {
        get => _Label46;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label46 == null)
                    ;
                _Label46 = value;
                if (_Label46 == null)
                    ;
            }
    }

    internal virtual Label Label1
    {
        get => _Label1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
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
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
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
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
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
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
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
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
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
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label6 == null)
                    ;
                _Label6 = value;
                if (_Label6 == null)
                    ;
            }
        get => _Label6;
    }

    internal virtual NumericUpDown nudXPScale
    {
        get => _nudXPScale;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudXPScale != null)
                    _nudXPScale.ValueChanged -= new EventHandler(nudXPScale_ValueChanged);
                _nudXPScale = value;
                if (_nudXPScale == null)
                    return;
                _nudXPScale.ValueChanged += new EventHandler(nudXPScale_ValueChanged);
            }
    }

    internal virtual TrackBar trkbarXPScale
    {
        get => _trkbarXPScale;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_trkbarXPScale != null)
                    _trkbarXPScale.Scroll -= new EventHandler(trkbarXPScale_Scroll);
                _trkbarXPScale = value;
                if (_trkbarXPScale == null)
                    return;
                _trkbarXPScale.Scroll += new EventHandler(trkbarXPScale_Scroll);
            }
    }

    internal virtual Label Label7
    {
        get => _Label7;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label7 == null)
                    ;
                _Label7 = value;
                if (_Label7 == null)
                    ;
            }
    }

    internal virtual Button btnSetDescriptionLang
    {
        get => _btnSetDescriptionLang;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnSetDescriptionLang != null)
                    _btnSetDescriptionLang.Click -= new EventHandler(btnSetDescriptionLang_Click);
                _btnSetDescriptionLang = value;
                if (_btnSetDescriptionLang == null)
                    return;
                _btnSetDescriptionLang.Click += new EventHandler(btnSetDescriptionLang_Click);
            }
    }

    internal virtual Label Label8
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label8 == null)
                    ;
                _Label8 = value;
                if (_Label8 == null)
                    ;
            }
        get => _Label8;
    }

    internal virtual Label Label9
    {
        get => _Label9;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
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
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label10 == null)
                    ;
                _Label10 = value;
                if (_Label10 == null)
                    ;
            }
    }

    internal virtual Label Label11
    {
        get => _Label11;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label11 == null)
                    ;
                _Label11 = value;
                if (_Label11 == null)
                    ;
            }
    }

    internal virtual Label Label12
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label12 == null)
                    ;
                _Label12 = value;
                if (_Label12 == null)
                    ;
            }
        get => _Label12;
    }

    internal virtual Label Label13
    {
        get => _Label13;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label13 == null)
                    ;
                _Label13 = value;
                if (_Label13 == null)
                    ;
            }
    }

    internal virtual TabPage TabPage5
    {
        get => _TabPage5;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TabPage5 == null)
                    ;
                _TabPage5 = value;
                if (_TabPage5 == null)
                    ;
            }
    }

    internal virtual TabPage TabPage6
    {
        get => _TabPage6;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TabPage6 == null)
                    ;
                _TabPage6 = value;
                if (_TabPage6 == null)
                    ;
            }
    }

    internal virtual Label Label14
    {
        get => _Label14;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label14 == null)
                    ;
                _Label14 = value;
                if (_Label14 == null)
                    ;
            }
    }

    internal virtual NumericUpDown NumericUpDown10
    {
        get => _NumericUpDown10;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_NumericUpDown10 == null)
                    ;
                _NumericUpDown10 = value;
                if (_NumericUpDown10 == null)
                    ;
            }
    }

    internal virtual Label Label15
    {
        get => _Label15;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label15 == null)
                    ;
                _Label15 = value;
                if (_Label15 == null)
                    ;
            }
    }

    internal virtual NumericUpDown NumericUpDown11
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_NumericUpDown11 == null)
                    ;
                _NumericUpDown11 = value;
                if (_NumericUpDown11 == null)
                    ;
            }
        get => _NumericUpDown11;
    }

    internal virtual Label Label16
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label16 == null)
                    ;
                _Label16 = value;
                if (_Label16 == null)
                    ;
            }
        get => _Label16;
    }

    internal virtual NumericUpDown NumericUpDown12
    {
        get => _NumericUpDown12;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_NumericUpDown12 == null)
                    ;
                _NumericUpDown12 = value;
                if (_NumericUpDown12 == null)
                    ;
            }
    }

    internal virtual Label Label17
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label17 == null)
                    ;
                _Label17 = value;
                if (_Label17 == null)
                    ;
            }
        get => _Label17;
    }

    internal virtual Label Label18
    {
        get => _Label18;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label18 == null)
                    ;
                _Label18 = value;
                if (_Label18 == null)
                    ;
            }
    }

    internal virtual TabControl TabControlModule
    {
        get => _TabControlModule;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TabControlModule == null)
                    ;
                _TabControlModule = value;
                if (_TabControlModule == null)
                    ;
            }
    }

    internal virtual TabControl TabControlMain
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TabControlMain == null)
                    ;
                _TabControlMain = value;
                if (_TabControlMain == null)
                    ;
            }
        get => _TabControlMain;
    }

    internal virtual TabControl TabControlArea
    {
        get => _TabControlArea;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TabControlArea == null)
                    ;
                _TabControlArea = value;
                if (_TabControlArea == null)
                    ;
            }
    }

    internal virtual Label Label20
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label20 == null)
                    ;
                _Label20 = value;
                if (_Label20 == null)
                    ;
            }
        get => _Label20;
    }

    internal virtual ColorDialog ColorDialog1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_ColorDialog1 == null)
                    ;
                _ColorDialog1 = value;
                if (_ColorDialog1 == null)
                    ;
            }
        get => _ColorDialog1;
    }

    internal virtual Label Label21
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label21 == null)
                    ;
                _Label21 = value;
                if (_Label21 == null)
                    ;
            }
        get => _Label21;
    }

    internal virtual Button btnGrassDiffuseColor
    {
        get => _btnGrassDiffuseColor;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnGrassDiffuseColor != null)
                    _btnGrassDiffuseColor.Click -= new EventHandler(SetColor_Click);
                _btnGrassDiffuseColor = value;
                if (_btnGrassDiffuseColor == null)
                    return;
                _btnGrassDiffuseColor.Click += new EventHandler(SetColor_Click);
            }
    }

    internal virtual Label Label22
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label22 == null)
                    ;
                _Label22 = value;
                if (_Label22 == null)
                    ;
            }
        get => _Label22;
    }

    internal virtual Button btnGrassAmbientColor
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnGrassAmbientColor != null)
                    _btnGrassAmbientColor.Click -= new EventHandler(SetColor_Click);
                _btnGrassAmbientColor = value;
                if (_btnGrassAmbientColor == null)
                    return;
                _btnGrassAmbientColor.Click += new EventHandler(SetColor_Click);
            }
        get => _btnGrassAmbientColor;
    }

    internal virtual Label Label23
    {
        get => _Label23;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label23 == null)
                    ;
                _Label23 = value;
                if (_Label23 == null)
                    ;
            }
    }

    internal virtual Button btnGrassEmissiveColor
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnGrassEmissiveColor != null)
                    _btnGrassEmissiveColor.Click -= new EventHandler(SetColor_Click);
                _btnGrassEmissiveColor = value;
                if (_btnGrassEmissiveColor == null)
                    return;
                _btnGrassEmissiveColor.Click += new EventHandler(SetColor_Click);
            }
        get => _btnGrassEmissiveColor;
    }

    internal virtual TabPage tabpagAreaBasic
    {
        get => _tabpagAreaBasic;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tabpagAreaBasic == null)
                    ;
                _tabpagAreaBasic = value;
                if (_tabpagAreaBasic == null)
                    ;
            }
    }

    internal virtual TabPage tabpagAreaGrass
    {
        get => _tabpagAreaGrass;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tabpagAreaGrass == null)
                    ;
                _tabpagAreaGrass = value;
                if (_tabpagAreaGrass == null)
                    ;
            }
    }

    internal virtual TabPage tabpagAreaEnvironment
    {
        get => _tabpagAreaEnvironment;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tabpagAreaEnvironment == null)
                    ;
                _tabpagAreaEnvironment = value;
                if (_tabpagAreaEnvironment == null)
                    ;
            }
    }

    internal virtual Button btnSunDiffuseColor
    {
        get => _btnSunDiffuseColor;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnSunDiffuseColor != null)
                    _btnSunDiffuseColor.Click -= new EventHandler(SetColor_Click);
                _btnSunDiffuseColor = value;
                if (_btnSunDiffuseColor == null)
                    return;
                _btnSunDiffuseColor.Click += new EventHandler(SetColor_Click);
            }
    }

    internal virtual Label Label26
    {
        get => _Label26;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
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
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label27 == null)
                    ;
                _Label27 = value;
                if (_Label27 == null)
                    ;
            }
        get => _Label27;
    }

    internal virtual Button btnSunAmbientColor
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnSunAmbientColor != null)
                    _btnSunAmbientColor.Click -= new EventHandler(SetColor_Click);
                _btnSunAmbientColor = value;
                if (_btnSunAmbientColor == null)
                    return;
                _btnSunAmbientColor.Click += new EventHandler(SetColor_Click);
            }
        get => _btnSunAmbientColor;
    }

    internal virtual GroupBox gbSun
    {
        get => _gbSun;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_gbSun == null)
                    ;
                _gbSun = value;
                if (_gbSun == null)
                    ;
            }
    }

    internal virtual GroupBox gbMoon
    {
        get => _gbMoon;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_gbMoon == null)
                    ;
                _gbMoon = value;
                if (_gbMoon == null)
                    ;
            }
    }

    internal virtual Button btnMoonDiffuseColor
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnMoonDiffuseColor != null)
                    _btnMoonDiffuseColor.Click -= new EventHandler(SetColor_Click);
                _btnMoonDiffuseColor = value;
                if (_btnMoonDiffuseColor == null)
                    return;
                _btnMoonDiffuseColor.Click += new EventHandler(SetColor_Click);
            }
        get => _btnMoonDiffuseColor;
    }

    internal virtual Label Label24
    {
        get => _Label24;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
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
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label25 == null)
                    ;
                _Label25 = value;
                if (_Label25 == null)
                    ;
            }
    }

    internal virtual Button btnMoonAmbientColor
    {
        get => _btnMoonAmbientColor;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnMoonAmbientColor != null)
                    _btnMoonAmbientColor.Click -= new EventHandler(SetColor_Click);
                _btnMoonAmbientColor = value;
                if (_btnMoonAmbientColor == null)
                    return;
                _btnMoonAmbientColor.Click += new EventHandler(SetColor_Click);
            }
    }

    internal virtual RadioButton rbDayNightCycle
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_rbDayNightCycle != null)
                    _rbDayNightCycle.CheckedChanged -= new EventHandler(DayNight_CheckedChanged);
                _rbDayNightCycle = value;
                if (_rbDayNightCycle == null)
                    return;
                _rbDayNightCycle.CheckedChanged += new EventHandler(DayNight_CheckedChanged);
            }
        get => _rbDayNightCycle;
    }

    internal virtual RadioButton rbAlwaysDay
    {
        get => _rbAlwaysDay;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_rbAlwaysDay != null)
                    _rbAlwaysDay.CheckedChanged -= new EventHandler(DayNight_CheckedChanged);
                _rbAlwaysDay = value;
                if (_rbAlwaysDay == null)
                    return;
                _rbAlwaysDay.CheckedChanged += new EventHandler(DayNight_CheckedChanged);
            }
    }

    internal virtual Label Label28
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label28 == null)
                    ;
                _Label28 = value;
                if (_Label28 == null)
                    ;
            }
        get => _Label28;
    }

    internal virtual Label Label29
    {
        get => _Label29;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label29 == null)
                    ;
                _Label29 = value;
                if (_Label29 == null)
                    ;
            }
    }

    internal virtual Label Label30
    {
        get => _Label30;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label30 == null)
                    ;
                _Label30 = value;
                if (_Label30 == null)
                    ;
            }
    }

    internal virtual CheckBox chkbAreaSunShadows
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbAreaSunShadows == null)
                    ;
                _chkbAreaSunShadows = value;
                if (_chkbAreaSunShadows == null)
                    ;
            }
        get => _chkbAreaSunShadows;
    }

    internal virtual Label Label31
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label31 == null)
                    ;
                _Label31 = value;
                if (_Label31 == null)
                    ;
            }
        get => _Label31;
    }

    internal virtual Label Label45
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label45 == null)
                    ;
                _Label45 = value;
                if (_Label45 == null)
                    ;
            }
        get => _Label45;
    }

    internal virtual Label Label47
    {
        get => _Label47;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label47 == null)
                    ;
                _Label47 = value;
                if (_Label47 == null)
                    ;
            }
    }

    internal virtual GroupBox GroupBox1
    {
        get => _GroupBox1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_GroupBox1 == null)
                    ;
                _GroupBox1 = value;
                if (_GroupBox1 == null)
                    ;
            }
    }

    internal virtual Label Label49
    {
        get => _Label49;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label49 == null)
                    ;
                _Label49 = value;
                if (_Label49 == null)
                    ;
            }
    }

    internal virtual Label Label50
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label50 == null)
                    ;
                _Label50 = value;
                if (_Label50 == null)
                    ;
            }
        get => _Label50;
    }

    internal virtual Label Label51
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label51 == null)
                    ;
                _Label51 = value;
                if (_Label51 == null)
                    ;
            }
        get => _Label51;
    }

    internal virtual TabPage tabpagAreaAudio
    {
        get => _tabpagAreaAudio;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tabpagAreaAudio == null)
                    ;
                _tabpagAreaAudio = value;
                if (_tabpagAreaAudio == null)
                    ;
            }
    }

    internal virtual Label Label52
    {
        get => _Label52;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label52 == null)
                    ;
                _Label52 = value;
                if (_Label52 == null)
                    ;
            }
    }

    internal virtual Label Label53
    {
        get => _Label53;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label53 == null)
                    ;
                _Label53 = value;
                if (_Label53 == null)
                    ;
            }
    }

    internal virtual Label Label54
    {
        get => _Label54;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label54 == null)
                    ;
                _Label54 = value;
                if (_Label54 == null)
                    ;
            }
    }

    internal virtual Label Label55
    {
        get => _Label55;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label55 == null)
                    ;
                _Label55 = value;
                if (_Label55 == null)
                    ;
            }
    }

    internal virtual Label Label56
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label56 == null)
                    ;
                _Label56 = value;
                if (_Label56 == null)
                    ;
            }
        get => _Label56;
    }

    internal virtual Label Label57
    {
        get => _Label57;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label57 == null)
                    ;
                _Label57 = value;
                if (_Label57 == null)
                    ;
            }
    }

    internal virtual Label Label58
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label58 == null)
                    ;
                _Label58 = value;
                if (_Label58 == null)
                    ;
            }
        get => _Label58;
    }

    internal virtual Label Label59
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label59 == null)
                    ;
                _Label59 = value;
                if (_Label59 == null)
                    ;
            }
        get => _Label59;
    }

    internal virtual Label Label60
    {
        get => _Label60;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label60 == null)
                    ;
                _Label60 = value;
                if (_Label60 == null)
                    ;
            }
    }

    internal virtual Label Label61
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label61 == null)
                    ;
                _Label61 = value;
                if (_Label61 == null)
                    ;
            }
        get => _Label61;
    }

    internal virtual TabPage tabpagModuleBasic
    {
        get => _tabpagModuleBasic;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tabpagModuleBasic == null)
                    ;
                _tabpagModuleBasic = value;
                if (_tabpagModuleBasic == null)
                    ;
            }
    }

    internal virtual TabPage tabpagModuleAdvanced
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tabpagModuleAdvanced == null)
                    ;
                _tabpagModuleAdvanced = value;
                if (_tabpagModuleAdvanced == null)
                    ;
            }
        get => _tabpagModuleAdvanced;
    }

    internal virtual TabPage tabpagModuleEvents
    {
        get => _tabpagModuleEvents;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tabpagModuleEvents == null)
                    ;
                _tabpagModuleEvents = value;
                if (_tabpagModuleEvents == null)
                    ;
            }
    }

    internal virtual TabPage tabpagModuleDescription
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tabpagModuleDescription == null)
                    ;
                _tabpagModuleDescription = value;
                if (_tabpagModuleDescription == null)
                    ;
            }
        get => _tabpagModuleDescription;
    }

    internal virtual NumericUpDown nudModEntryX
    {
        get => _nudModEntryX;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudModEntryX == null)
                    ;
                _nudModEntryX = value;
                if (_nudModEntryX == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudModEntryY
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudModEntryY == null)
                    ;
                _nudModEntryY = value;
                if (_nudModEntryY == null)
                    ;
            }
        get => _nudModEntryY;
    }

    internal virtual NumericUpDown nudModEntryZ
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudModEntryZ == null)
                    ;
                _nudModEntryZ = value;
                if (_nudModEntryZ == null)
                    ;
            }
        get => _nudModEntryZ;
    }

    internal virtual TextBox tbModTag
    {
        get => _tbModTag;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbModTag == null)
                    ;
                _tbModTag = value;
                if (_tbModTag == null)
                    ;
            }
    }

    internal virtual TextBox tbModName
    {
        get => _tbModName;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbModName == null)
                    ;
                _tbModName = value;
                if (_tbModName == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudMinutesPerHour
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudMinutesPerHour == null)
                    ;
                _nudMinutesPerHour = value;
                if (_nudMinutesPerHour == null)
                    ;
            }
        get => _nudMinutesPerHour;
    }

    internal virtual NumericUpDown nudDawnStartHour
    {
        get => _nudDawnStartHour;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudDawnStartHour == null)
                    ;
                _nudDawnStartHour = value;
                if (_nudDawnStartHour == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudDuskStartHour
    {
        get => _nudDuskStartHour;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudDuskStartHour == null)
                    ;
                _nudDuskStartHour = value;
                if (_nudDuskStartHour == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudStartHour
    {
        get => _nudStartHour;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudStartHour == null)
                    ;
                _nudStartHour = value;
                if (_nudStartHour == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudStartDay
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudStartDay == null)
                    ;
                _nudStartDay = value;
                if (_nudStartDay == null)
                    ;
            }
        get => _nudStartDay;
    }

    internal virtual NumericUpDown nudStartMonth
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudStartMonth == null)
                    ;
                _nudStartMonth = value;
                if (_nudStartMonth == null)
                    ;
            }
        get => _nudStartMonth;
    }

    internal virtual NumericUpDown nudStartYear
    {
        get => _nudStartYear;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudStartYear == null)
                    ;
                _nudStartYear = value;
                if (_nudStartYear == null)
                    ;
            }
    }

    internal virtual TextBox tbMod_OnClientEntr
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbMod_OnClientEntr == null)
                    ;
                _tbMod_OnClientEntr = value;
                if (_tbMod_OnClientEntr == null)
                    ;
            }
        get => _tbMod_OnClientEntr;
    }

    internal virtual TextBox tbMod_OnActvtItem
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbMod_OnActvtItem == null)
                    ;
                _tbMod_OnActvtItem = value;
                if (_tbMod_OnActvtItem == null)
                    ;
            }
        get => _tbMod_OnActvtItem;
    }

    internal virtual TextBox tbMod_OnAcquirItem
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbMod_OnAcquirItem == null)
                    ;
                _tbMod_OnAcquirItem = value;
                if (_tbMod_OnAcquirItem == null)
                    ;
            }
        get => _tbMod_OnAcquirItem;
    }

    internal virtual TextBox tbMod_OnClientLeav
    {
        get => _tbMod_OnClientLeav;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbMod_OnClientLeav == null)
                    ;
                _tbMod_OnClientLeav = value;
                if (_tbMod_OnClientLeav == null)
                    ;
            }
    }

    internal virtual TextBox tbMod_OnHeartbeat
    {
        get => _tbMod_OnHeartbeat;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbMod_OnHeartbeat == null)
                    ;
                _tbMod_OnHeartbeat = value;
                if (_tbMod_OnHeartbeat == null)
                    ;
            }
    }

    internal virtual TextBox tbMod_OnModLoad
    {
        get => _tbMod_OnModLoad;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbMod_OnModLoad == null)
                    ;
                _tbMod_OnModLoad = value;
                if (_tbMod_OnModLoad == null)
                    ;
            }
    }

    internal virtual Button btnMoonFogColor
    {
        get => _btnMoonFogColor;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnMoonFogColor != null)
                    _btnMoonFogColor.Click -= new EventHandler(SetColor_Click);
                _btnMoonFogColor = value;
                if (_btnMoonFogColor == null)
                    return;
                _btnMoonFogColor.Click += new EventHandler(SetColor_Click);
            }
    }

    internal virtual CheckBox chkbAreaMoonShadows
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbAreaMoonShadows == null)
                    ;
                _chkbAreaMoonShadows = value;
                if (_chkbAreaMoonShadows == null)
                    ;
            }
        get => _chkbAreaMoonShadows;
    }

    internal virtual Button btnSunFogColor
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnSunFogColor != null)
                    _btnSunFogColor.Click -= new EventHandler(SetColor_Click);
                _btnSunFogColor = value;
                if (_btnSunFogColor == null)
                    return;
                _btnSunFogColor.Click += new EventHandler(SetColor_Click);
            }
        get => _btnSunFogColor;
    }

    internal virtual RadioButton rbAlwaysNight
    {
        get => _rbAlwaysNight;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_rbAlwaysNight != null)
                    _rbAlwaysNight.CheckedChanged -= new EventHandler(DayNight_CheckedChanged);
                _rbAlwaysNight = value;
                if (_rbAlwaysNight == null)
                    return;
                _rbAlwaysNight.CheckedChanged += new EventHandler(DayNight_CheckedChanged);
            }
    }

    internal virtual TextBox tbMod_OnPlrDeath
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbMod_OnPlrDeath == null)
                    ;
                _tbMod_OnPlrDeath = value;
                if (_tbMod_OnPlrDeath == null)
                    ;
            }
        get => _tbMod_OnPlrDeath;
    }

    internal virtual TextBox tbMod_OnPlrDying
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbMod_OnPlrDying == null)
                    ;
                _tbMod_OnPlrDying = value;
                if (_tbMod_OnPlrDying == null)
                    ;
            }
        get => _tbMod_OnPlrDying;
    }

    internal virtual TextBox tbMod_OnPlrLvlUp
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbMod_OnPlrLvlUp == null)
                    ;
                _tbMod_OnPlrLvlUp = value;
                if (_tbMod_OnPlrLvlUp == null)
                    ;
            }
        get => _tbMod_OnPlrLvlUp;
    }

    internal virtual TextBox tbMod_OnSpawnBtnDn
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbMod_OnSpawnBtnDn == null)
                    ;
                _tbMod_OnSpawnBtnDn = value;
                if (_tbMod_OnSpawnBtnDn == null)
                    ;
            }
        get => _tbMod_OnSpawnBtnDn;
    }

    internal virtual TextBox tbMod_OnPlrRest
    {
        get => _tbMod_OnPlrRest;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbMod_OnPlrRest == null)
                    ;
                _tbMod_OnPlrRest = value;
                if (_tbMod_OnPlrRest == null)
                    ;
            }
    }

    internal virtual TextBox tbMod_OnUnAqreItem
    {
        get => _tbMod_OnUnAqreItem;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbMod_OnUnAqreItem == null)
                    ;
                _tbMod_OnUnAqreItem = value;
                if (_tbMod_OnUnAqreItem == null)
                    ;
            }
    }

    internal virtual TextBox tbMod_OnUsrDefined
    {
        get => _tbMod_OnUsrDefined;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbMod_OnUsrDefined == null)
                    ;
                _tbMod_OnUsrDefined = value;
                if (_tbMod_OnUsrDefined == null)
                    ;
            }
    }

    internal virtual CheckBox chkbSunFogOn
    {
        get => _chkbSunFogOn;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbSunFogOn != null)
                    _chkbSunFogOn.CheckedChanged -= new EventHandler(SunFogEnabled);
                _chkbSunFogOn = value;
                if (_chkbSunFogOn == null)
                    return;
                _chkbSunFogOn.CheckedChanged += new EventHandler(SunFogEnabled);
            }
    }

    internal virtual CheckBox chkbMoonFogOn
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbMoonFogOn != null)
                    _chkbMoonFogOn.CheckedChanged -= new EventHandler(MoonFogEnabled);
                _chkbMoonFogOn = value;
                if (_chkbMoonFogOn == null)
                    return;
                _chkbMoonFogOn.CheckedChanged += new EventHandler(MoonFogEnabled);
            }
        get => _chkbMoonFogOn;
    }

    internal virtual TrackBar trkbarSunFogNear
    {
        get => _trkbarSunFogNear;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_trkbarSunFogNear == null)
                    ;
                _trkbarSunFogNear = value;
                if (_trkbarSunFogNear == null)
                    ;
            }
    }

    internal virtual TrackBar trkbarSunFogFar
    {
        get => _trkbarSunFogFar;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_trkbarSunFogFar == null)
                    ;
                _trkbarSunFogFar = value;
                if (_trkbarSunFogFar == null)
                    ;
            }
    }

    internal virtual TrackBar trkbarMoonFogNear
    {
        get => _trkbarMoonFogNear;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_trkbarMoonFogNear == null)
                    ;
                _trkbarMoonFogNear = value;
                if (_trkbarMoonFogNear == null)
                    ;
            }
    }

    internal virtual TrackBar trkbarMoonFogFar
    {
        get => _trkbarMoonFogFar;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_trkbarMoonFogFar == null)
                    ;
                _trkbarMoonFogFar = value;
                if (_trkbarMoonFogFar == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudChanceSnow
    {
        get => _nudChanceSnow;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudChanceSnow == null)
                    ;
                _nudChanceSnow = value;
                if (_nudChanceSnow == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudChanceRain
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudChanceRain == null)
                    ;
                _nudChanceRain = value;
                if (_nudChanceRain == null)
                    ;
            }
        get => _nudChanceRain;
    }

    internal virtual NumericUpDown nudChanceLightning
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudChanceLightning == null)
                    ;
                _nudChanceLightning = value;
                if (_nudChanceLightning == null)
                    ;
            }
        get => _nudChanceLightning;
    }

    internal virtual Button btnDynAmbientColor
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnDynAmbientColor != null)
                    _btnDynAmbientColor.Click -= new EventHandler(SetColor_Click);
                _btnDynAmbientColor = value;
                if (_btnDynAmbientColor == null)
                    return;
                _btnDynAmbientColor.Click += new EventHandler(SetColor_Click);
            }
        get => _btnDynAmbientColor;
    }

    internal virtual Label Label48
    {
        get => _Label48;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label48 == null)
                    ;
                _Label48 = value;
                if (_Label48 == null)
                    ;
            }
    }

    internal virtual Label lblMoonFogNear
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_lblMoonFogNear == null)
                    ;
                _lblMoonFogNear = value;
                if (_lblMoonFogNear == null)
                    ;
            }
        get => _lblMoonFogNear;
    }

    internal virtual Label lblMoonFogFar
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_lblMoonFogFar == null)
                    ;
                _lblMoonFogFar = value;
                if (_lblMoonFogFar == null)
                    ;
            }
        get => _lblMoonFogFar;
    }

    internal virtual Label lblSunFogNear
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_lblSunFogNear == null)
                    ;
                _lblSunFogNear = value;
                if (_lblSunFogNear == null)
                    ;
            }
        get => _lblSunFogNear;
    }

    internal virtual Label lblSunFogFar
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_lblSunFogFar == null)
                    ;
                _lblSunFogFar = value;
                if (_lblSunFogFar == null)
                    ;
            }
        get => _lblSunFogFar;
    }

    internal virtual Button btnOK
    {
        get => _btnOK;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnOK == null)
                    ;
                _btnOK = value;
                if (_btnOK == null)
                    ;
            }
    }

    internal virtual Button btnCancel
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnCancel == null)
                    ;
                _btnCancel = value;
                if (_btnCancel == null)
                    ;
            }
        get => _btnCancel;
    }

    internal virtual TrackBar trkbarAmbientSndDayVol
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_trkbarAmbientSndDayVol == null)
                    ;
                _trkbarAmbientSndDayVol = value;
                if (_trkbarAmbientSndDayVol == null)
                    ;
            }
        get => _trkbarAmbientSndDayVol;
    }

    internal virtual ComboBox cmbxAmbientSndDay
    {
        get => _cmbxAmbientSndDay;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_cmbxAmbientSndDay == null)
                    ;
                _cmbxAmbientSndDay = value;
                if (_cmbxAmbientSndDay == null)
                    ;
            }
    }

    internal virtual TrackBar trkbarAmbientSndNightVol
    {
        get => _trkbarAmbientSndNightVol;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_trkbarAmbientSndNightVol == null)
                    ;
                _trkbarAmbientSndNightVol = value;
                if (_trkbarAmbientSndNightVol == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudMusicDelay
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudMusicDelay == null)
                    ;
                _nudMusicDelay = value;
                if (_nudMusicDelay == null)
                    ;
            }
        get => _nudMusicDelay;
    }

    internal virtual ComboBox cmbxMusicNight
    {
        get => _cmbxMusicNight;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_cmbxMusicNight == null)
                    ;
                _cmbxMusicNight = value;
                if (_cmbxMusicNight == null)
                    ;
            }
    }

    internal virtual ComboBox cmbxMusicDay
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_cmbxMusicDay == null)
                    ;
                _cmbxMusicDay = value;
                if (_cmbxMusicDay == null)
                    ;
            }
        get => _cmbxMusicDay;
    }

    internal virtual ComboBox cmbxMusicBattle
    {
        get => _cmbxMusicBattle;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_cmbxMusicBattle == null)
                    ;
                _cmbxMusicBattle = value;
                if (_cmbxMusicBattle == null)
                    ;
            }
    }

    internal virtual ComboBox cmbxEnvAudio
    {
        get => _cmbxEnvAudio;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_cmbxEnvAudio == null)
                    ;
                _cmbxEnvAudio = value;
                if (_cmbxEnvAudio == null)
                    ;
            }
    }

    internal virtual ComboBox cmbxAmbientSndNight
    {
        get => _cmbxAmbientSndNight;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_cmbxAmbientSndNight == null)
                    ;
                _cmbxAmbientSndNight = value;
                if (_cmbxAmbientSndNight == null)
                    ;
            }
    }

    internal virtual TextBox tbGrass_TexName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbGrass_TexName == null)
                    ;
                _tbGrass_TexName = value;
                if (_tbGrass_TexName == null)
                    ;
            }
        get => _tbGrass_TexName;
    }

    internal virtual TrackBar trkbarGrassDensityX10
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_trkbarGrassDensityX10 != null)
                    _trkbarGrassDensityX10.Scroll -= new EventHandler(trkbarGrassDensityX10_Scroll);
                _trkbarGrassDensityX10 = value;
                if (_trkbarGrassDensityX10 == null)
                    return;
                _trkbarGrassDensityX10.Scroll += new EventHandler(trkbarGrassDensityX10_Scroll);
            }
        get => _trkbarGrassDensityX10;
    }

    internal virtual Label Label62
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label62 == null)
                    ;
                _Label62 = value;
                if (_Label62 == null)
                    ;
            }
        get => _Label62;
    }

    internal virtual NumericUpDown nudGrassDensity
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudGrassDensity != null)
                    _nudGrassDensity.ValueChanged -= new EventHandler(nudGrassDensity_ValueChanged);
                _nudGrassDensity = value;
                if (_nudGrassDensity == null)
                    return;
                _nudGrassDensity.ValueChanged += new EventHandler(nudGrassDensity_ValueChanged);
            }
        get => _nudGrassDensity;
    }

    internal virtual Label Label63
    {
        get => _Label63;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label63 == null)
                    ;
                _Label63 = value;
                if (_Label63 == null)
                    ;
            }
    }

    internal virtual Label Label64
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label64 == null)
                    ;
                _Label64 = value;
                if (_Label64 == null)
                    ;
            }
        get => _Label64;
    }

    internal virtual Label Label65
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label65 == null)
                    ;
                _Label65 = value;
                if (_Label65 == null)
                    ;
            }
        get => _Label65;
    }

    internal virtual Label Label66
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label66 == null)
                    ;
                _Label66 = value;
                if (_Label66 == null)
                    ;
            }
        get => _Label66;
    }

    internal virtual Label Label67
    {
        get => _Label67;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label67 == null)
                    ;
                _Label67 = value;
                if (_Label67 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudGrassProbUL
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudGrassProbUL != null)
                    _nudGrassProbUL.ValueChanged -= new EventHandler(nudGrassProbXX_ValueChanged);
                _nudGrassProbUL = value;
                if (_nudGrassProbUL == null)
                    return;
                _nudGrassProbUL.ValueChanged += new EventHandler(nudGrassProbXX_ValueChanged);
            }
        get => _nudGrassProbUL;
    }

    internal virtual NumericUpDown nudGrassProbLL
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudGrassProbLL != null)
                    _nudGrassProbLL.ValueChanged -= new EventHandler(nudGrassProbXX_ValueChanged);
                _nudGrassProbLL = value;
                if (_nudGrassProbLL == null)
                    return;
                _nudGrassProbLL.ValueChanged += new EventHandler(nudGrassProbXX_ValueChanged);
            }
        get => _nudGrassProbLL;
    }

    internal virtual NumericUpDown nudGrassProbUR
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudGrassProbUR != null)
                    _nudGrassProbUR.ValueChanged -= new EventHandler(nudGrassProbXX_ValueChanged);
                _nudGrassProbUR = value;
                if (_nudGrassProbUR == null)
                    return;
                _nudGrassProbUR.ValueChanged += new EventHandler(nudGrassProbXX_ValueChanged);
            }
        get => _nudGrassProbUR;
    }

    internal virtual NumericUpDown nudGrassProbLR
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudGrassProbLR != null)
                    _nudGrassProbLR.ValueChanged -= new EventHandler(nudGrassProbXX_ValueChanged);
                _nudGrassProbLR = value;
                if (_nudGrassProbLR == null)
                    return;
                _nudGrassProbLR.ValueChanged += new EventHandler(nudGrassProbXX_ValueChanged);
            }
        get => _nudGrassProbLR;
    }

    internal virtual Label lblTotalGrassProbability
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_lblTotalGrassProbability == null)
                    ;
                _lblTotalGrassProbability = value;
                if (_lblTotalGrassProbability == null)
                    ;
            }
        get => _lblTotalGrassProbability;
    }

    internal virtual Label Label69
    {
        get => _Label69;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label69 == null)
                    ;
                _Label69 = value;
                if (_Label69 == null)
                    ;
            }
    }

    internal virtual Label Label70
    {
        get => _Label70;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label70 == null)
                    ;
                _Label70 = value;
                if (_Label70 == null)
                    ;
            }
    }

    internal virtual Label Label71
    {
        get => _Label71;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label71 == null)
                    ;
                _Label71 = value;
                if (_Label71 == null)
                    ;
            }
    }

    internal virtual Label Label72
    {
        get => _Label72;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label72 == null)
                    ;
                _Label72 = value;
                if (_Label72 == null)
                    ;
            }
    }

    internal virtual Label Label68
    {
        get => _Label68;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label68 == null)
                    ;
                _Label68 = value;
                if (_Label68 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudGrassQuadSize
    {
        get => _nudGrassQuadSize;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudGrassQuadSize == null)
                    ;
                _nudGrassQuadSize = value;
                if (_nudGrassQuadSize == null)
                    ;
            }
    }

    internal virtual TextBox tbAreaTag
    {
        get => _tbAreaTag;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbAreaTag == null)
                    ;
                _tbAreaTag = value;
                if (_tbAreaTag == null)
                    ;
            }
    }

    internal virtual TextBox tbAreaName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbAreaName == null)
                    ;
                _tbAreaName = value;
                if (_tbAreaName == null)
                    ;
            }
        get => _tbAreaName;
    }

    internal virtual Label Label19
    {
        get => _Label19;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label19 == null)
                    ;
                _Label19 = value;
                if (_Label19 == null)
                    ;
            }
    }

    internal virtual ComboBox cmbxCameraStyle
    {
        get => _cmbxCameraStyle;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_cmbxCameraStyle == null)
                    ;
                _cmbxCameraStyle = value;
                if (_cmbxCameraStyle == null)
                    ;
            }
    }

    internal virtual Label Label73
    {
        get => _Label73;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label73 == null)
                    ;
                _Label73 = value;
                if (_Label73 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudShadowOpacity
    {
        get => _nudShadowOpacity;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudShadowOpacity == null)
                    ;
                _nudShadowOpacity = value;
                if (_nudShadowOpacity == null)
                    ;
            }
    }

    internal virtual TabPage tabpagArea_Events
    {
        get => _tabpagArea_Events;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tabpagArea_Events == null)
                    ;
                _tabpagArea_Events = value;
                if (_tabpagArea_Events == null)
                    ;
            }
    }

    internal virtual Label Label74
    {
        get => _Label74;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label74 == null)
                    ;
                _Label74 = value;
                if (_Label74 == null)
                    ;
            }
    }

    internal virtual TextBox tbArea_OnEnter
    {
        get => _tbArea_OnEnter;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbArea_OnEnter == null)
                    ;
                _tbArea_OnEnter = value;
                if (_tbArea_OnEnter == null)
                    ;
            }
    }

    internal virtual Label Label75
    {
        get => _Label75;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label75 == null)
                    ;
                _Label75 = value;
                if (_Label75 == null)
                    ;
            }
    }

    internal virtual TextBox tbArea_OnExit
    {
        get => _tbArea_OnExit;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbArea_OnExit == null)
                    ;
                _tbArea_OnExit = value;
                if (_tbArea_OnExit == null)
                    ;
            }
    }

    internal virtual TextBox tbArea_OnHeartbeat
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbArea_OnHeartbeat == null)
                    ;
                _tbArea_OnHeartbeat = value;
                if (_tbArea_OnHeartbeat == null)
                    ;
            }
        get => _tbArea_OnHeartbeat;
    }

    internal virtual Label Label76
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label76 == null)
                    ;
                _Label76 = value;
                if (_Label76 == null)
                    ;
            }
        get => _Label76;
    }

    internal virtual Label Label77
    {
        get => _Label77;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label77 == null)
                    ;
                _Label77 = value;
                if (_Label77 == null)
                    ;
            }
    }

    internal virtual TextBox tbArea_OnUserDefined
    {
        get => _tbArea_OnUserDefined;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbArea_OnUserDefined == null)
                    ;
                _tbArea_OnUserDefined = value;
                if (_tbArea_OnUserDefined == null)
                    ;
            }
    }

    internal virtual TabPage tabpagAreaRooms
    {
        get => _tabpagAreaRooms;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tabpagAreaRooms == null)
                    ;
                _tabpagAreaRooms = value;
                if (_tabpagAreaRooms == null)
                    ;
            }
    }

    internal virtual Label Label78
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label78 == null)
                    ;
                _Label78 = value;
                if (_Label78 == null)
                    ;
            }
        get => _Label78;
    }

    internal virtual Label Label79
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label79 == null)
                    ;
                _Label79 = value;
                if (_Label79 == null)
                    ;
            }
        get => _Label79;
    }

    internal virtual Label Label80
    {
        get => _Label80;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label80 == null)
                    ;
                _Label80 = value;
                if (_Label80 == null)
                    ;
            }
    }

    internal virtual Label Label81
    {
        get => _Label81;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label81 == null)
                    ;
                _Label81 = value;
                if (_Label81 == null)
                    ;
            }
    }

    internal virtual Label Label82
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label82 == null)
                    ;
                _Label82 = value;
                if (_Label82 == null)
                    ;
            }
        get => _Label82;
    }

    internal virtual ListBox lbRooms
    {
        get => _lbRooms;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_lbRooms != null)
                    _lbRooms.SelectedIndexChanged -= new EventHandler(lbRooms_SelectedIndexChanged);
                _lbRooms = value;
                if (_lbRooms == null)
                    return;
                _lbRooms.SelectedIndexChanged += new EventHandler(lbRooms_SelectedIndexChanged);
            }
    }

    internal virtual Label Label83
    {
        get => _Label83;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label83 == null)
                    ;
                _Label83 = value;
                if (_Label83 == null)
                    ;
            }
    }

    internal virtual CheckBox chkbRoomDisableWeather
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbRoomDisableWeather == null)
                    ;
                _chkbRoomDisableWeather = value;
                if (_chkbRoomDisableWeather == null)
                    ;
            }
        get => _chkbRoomDisableWeather;
    }

    internal virtual NumericUpDown nudRoomAmbientScale
    {
        get => _nudRoomAmbientScale;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudRoomAmbientScale == null)
                    ;
                _nudRoomAmbientScale = value;
                if (_nudRoomAmbientScale == null)
                    ;
            }
    }

    internal virtual ComboBox cmbxRoomEnvAudio
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_cmbxRoomEnvAudio == null)
                    ;
                _cmbxRoomEnvAudio = value;
                if (_cmbxRoomEnvAudio == null)
                    ;
            }
        get => _cmbxRoomEnvAudio;
    }

    internal virtual TextBox tbRoomName
    {
        get => _tbRoomName;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbRoomName == null)
                    ;
                _tbRoomName = value;
                if (_tbRoomName == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudRoomForceRating
    {
        get => _nudRoomForceRating;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudRoomForceRating == null)
                    ;
                _nudRoomForceRating = value;
                if (_nudRoomForceRating == null)
                    ;
            }
    }

    internal virtual TextBox tbModDescription
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbModDescription == null)
                    ;
                _tbModDescription = value;
                if (_tbModDescription == null)
                    ;
            }
        get => _tbModDescription;
    }

    internal virtual Button btnSetModNameLang
    {
        get => _btnSetModNameLang;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnSetModNameLang != null)
                    _btnSetModNameLang.Click -= new EventHandler(btnSetModNameLang_Click);
                _btnSetModNameLang = value;
                if (_btnSetModNameLang == null)
                    return;
                _btnSetModNameLang.Click += new EventHandler(btnSetModNameLang_Click);
            }
    }

    internal virtual Button btnSetAreaNameLang
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_btnSetAreaNameLang != null)
                    _btnSetAreaNameLang.Click -= new EventHandler(btnSetAreaNameLang_Click);
                _btnSetAreaNameLang = value;
                if (_btnSetAreaNameLang == null)
                    return;
                _btnSetAreaNameLang.Click += new EventHandler(btnSetAreaNameLang_Click);
            }
        get => _btnSetAreaNameLang;
    }

    internal virtual ComboBox cmbxWindPower
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_cmbxWindPower == null)
                    ;
                _cmbxWindPower = value;
                if (_cmbxWindPower == null)
                    ;
            }
        get => _cmbxWindPower;
    }

    internal virtual Label Label84
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label84 == null)
                    ;
                _Label84 = value;
                if (_Label84 == null)
                    ;
            }
        get => _Label84;
    }

    internal virtual CheckBox chkbUnescapable
    {
        get => _chkbUnescapable;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbUnescapable == null)
                    ;
                _chkbUnescapable = value;
                if (_chkbUnescapable == null)
                    ;
            }
    }

    internal virtual Label Label85
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label85 == null)
                    ;
                _Label85 = value;
                if (_Label85 == null)
                    ;
            }
        get => _Label85;
    }

    internal virtual CheckBox chkbDisableTransit
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_chkbDisableTransit == null)
                    ;
                _chkbDisableTransit = value;
                if (_chkbDisableTransit == null)
                    ;
            }
        get => _chkbDisableTransit;
    }

    internal virtual Label Label86
    {
        get => _Label86;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label86 == null)
                    ;
                _Label86 = value;
                if (_Label86 == null)
                    ;
            }
    }

    internal virtual PictureBox pboxXY
    {
        get => _pboxXY;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_pboxXY == null)
                    ;
                _pboxXY = value;
                if (_pboxXY == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudXY
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
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

    internal virtual Label lblBearing
    {
        get => _lblBearing;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_lblBearing == null)
                    ;
                _lblBearing = value;
                if (_lblBearing == null)
                    ;
            }
    }

    internal virtual TextBox tbModEntryArea
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbModEntryArea == null)
                    ;
                _tbModEntryArea = value;
                if (_tbModEntryArea == null)
                    ;
            }
        get => _tbModEntryArea;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
            TabControlModule = new TabControl();
            tabpagModuleBasic = new TabPage();
            pboxXY = new PictureBox();
            nudXY = new NumericUpDown();
            lblBearing = new Label();
            Label11 = new Label();
            nudModEntryX = new NumericUpDown();
            Label12 = new Label();
            nudModEntryY = new NumericUpDown();
            Label13 = new Label();
            nudModEntryZ = new NumericUpDown();
            btnSetModNameLang = new Button();
            tbModTag = new TextBox();
            tbModName = new TextBox();
            Label8 = new Label();
            Label9 = new Label();
            tbModEntryArea = new TextBox();
            Label10 = new Label();
            tabpagModuleAdvanced = new TabPage();
            nudXPScale = new NumericUpDown();
            trkbarXPScale = new TrackBar();
            Label46 = new Label();
            nudMinutesPerHour = new NumericUpDown();
            Label1 = new Label();
            nudDawnStartHour = new NumericUpDown();
            Label2 = new Label();
            nudDuskStartHour = new NumericUpDown();
            Label3 = new Label();
            nudStartHour = new NumericUpDown();
            Label4 = new Label();
            nudStartDay = new NumericUpDown();
            Label5 = new Label();
            nudStartMonth = new NumericUpDown();
            Label6 = new Label();
            nudStartYear = new NumericUpDown();
            Label7 = new Label();
            tabpagModuleEvents = new TabPage();
            Label34 = new Label();
            tbMod_OnClientEntr = new TextBox();
            Label33 = new Label();
            tbMod_OnActvtItem = new TextBox();
            Label32 = new Label();
            tbMod_OnAcquirItem = new TextBox();
            Label35 = new Label();
            tbMod_OnClientLeav = new TextBox();
            tbMod_OnHeartbeat = new TextBox();
            Label36 = new Label();
            Label37 = new Label();
            tbMod_OnModLoad = new TextBox();
            tbMod_OnPlrDeath = new TextBox();
            Label38 = new Label();
            tbMod_OnPlrDying = new TextBox();
            Label39 = new Label();
            Label40 = new Label();
            tbMod_OnPlrLvlUp = new TextBox();
            Label41 = new Label();
            tbMod_OnSpawnBtnDn = new TextBox();
            tbMod_OnPlrRest = new TextBox();
            Label42 = new Label();
            tbMod_OnUnAqreItem = new TextBox();
            Label43 = new Label();
            Label44 = new Label();
            tbMod_OnUsrDefined = new TextBox();
            tabpagModuleDescription = new TabPage();
            btnSetDescriptionLang = new Button();
            tbModDescription = new TextBox();
            TabControlMain = new TabControl();
            TabPage5 = new TabPage();
            TabPage6 = new TabPage();
            TabControlArea = new TabControl();
            tabpagAreaBasic = new TabPage();
            chkbUnescapable = new CheckBox();
            Label19 = new Label();
            cmbxCameraStyle = new ComboBox();
            Label14 = new Label();
            NumericUpDown10 = new NumericUpDown();
            Label15 = new Label();
            NumericUpDown11 = new NumericUpDown();
            Label16 = new Label();
            NumericUpDown12 = new NumericUpDown();
            btnSetAreaNameLang = new Button();
            tbAreaTag = new TextBox();
            tbAreaName = new TextBox();
            Label17 = new Label();
            Label18 = new Label();
            Label85 = new Label();
            chkbDisableTransit = new CheckBox();
            Label86 = new Label();
            tabpagAreaEnvironment = new TabPage();
            cmbxWindPower = new ComboBox();
            GroupBox1 = new GroupBox();
            Label49 = new Label();
            nudChanceSnow = new NumericUpDown();
            Label50 = new Label();
            nudChanceRain = new NumericUpDown();
            Label51 = new Label();
            nudChanceLightning = new NumericUpDown();
            rbDayNightCycle = new RadioButton();
            gbMoon = new GroupBox();
            btnMoonDiffuseColor = new Button();
            Label24 = new Label();
            Label25 = new Label();
            btnMoonAmbientColor = new Button();
            Label31 = new Label();
            Label45 = new Label();
            btnMoonFogColor = new Button();
            chkbAreaMoonShadows = new CheckBox();
            Label47 = new Label();
            chkbMoonFogOn = new CheckBox();
            trkbarMoonFogNear = new TrackBar();
            lblMoonFogNear = new Label();
            trkbarMoonFogFar = new TrackBar();
            lblMoonFogFar = new Label();
            gbSun = new GroupBox();
            chkbAreaSunShadows = new CheckBox();
            trkbarSunFogNear = new TrackBar();
            Label27 = new Label();
            btnSunAmbientColor = new Button();
            Label26 = new Label();
            btnSunDiffuseColor = new Button();
            Label28 = new Label();
            btnSunFogColor = new Button();
            Label29 = new Label();
            Label30 = new Label();
            trkbarSunFogFar = new TrackBar();
            lblSunFogNear = new Label();
            lblSunFogFar = new Label();
            chkbSunFogOn = new CheckBox();
            rbAlwaysDay = new RadioButton();
            rbAlwaysNight = new RadioButton();
            btnDynAmbientColor = new Button();
            Label48 = new Label();
            Label73 = new Label();
            nudShadowOpacity = new NumericUpDown();
            Label84 = new Label();
            tabpagAreaGrass = new TabPage();
            nudGrassDensity = new NumericUpDown();
            trkbarGrassDensityX10 = new TrackBar();
            Label62 = new Label();
            btnGrassDiffuseColor = new Button();
            tbGrass_TexName = new TextBox();
            Label20 = new Label();
            Label21 = new Label();
            Label22 = new Label();
            btnGrassAmbientColor = new Button();
            Label23 = new Label();
            btnGrassEmissiveColor = new Button();
            nudGrassProbUL = new NumericUpDown();
            nudGrassProbLL = new NumericUpDown();
            nudGrassProbUR = new NumericUpDown();
            nudGrassProbLR = new NumericUpDown();
            Label63 = new Label();
            Label64 = new Label();
            Label65 = new Label();
            Label66 = new Label();
            Label67 = new Label();
            lblTotalGrassProbability = new Label();
            Label69 = new Label();
            Label70 = new Label();
            Label71 = new Label();
            Label72 = new Label();
            Label68 = new Label();
            nudGrassQuadSize = new NumericUpDown();
            tabpagAreaAudio = new TabPage();
            trkbarAmbientSndNightVol = new TrackBar();
            trkbarAmbientSndDayVol = new TrackBar();
            Label52 = new Label();
            nudMusicDelay = new NumericUpDown();
            cmbxMusicNight = new ComboBox();
            cmbxMusicDay = new ComboBox();
            cmbxMusicBattle = new ComboBox();
            cmbxEnvAudio = new ComboBox();
            cmbxAmbientSndNight = new ComboBox();
            cmbxAmbientSndDay = new ComboBox();
            Label53 = new Label();
            Label54 = new Label();
            Label55 = new Label();
            Label56 = new Label();
            Label57 = new Label();
            Label58 = new Label();
            Label59 = new Label();
            Label60 = new Label();
            Label61 = new Label();
            tabpagArea_Events = new TabPage();
            Label77 = new Label();
            tbArea_OnUserDefined = new TextBox();
            tbArea_OnHeartbeat = new TextBox();
            Label76 = new Label();
            Label74 = new Label();
            tbArea_OnEnter = new TextBox();
            Label75 = new Label();
            tbArea_OnExit = new TextBox();
            tabpagAreaRooms = new TabPage();
            lbRooms = new ListBox();
            Label82 = new Label();
            chkbRoomDisableWeather = new CheckBox();
            nudRoomAmbientScale = new NumericUpDown();
            Label80 = new Label();
            cmbxRoomEnvAudio = new ComboBox();
            Label79 = new Label();
            Label78 = new Label();
            tbRoomName = new TextBox();
            nudRoomForceRating = new NumericUpDown();
            Label81 = new Label();
            Label83 = new Label();
            ColorDialog1 = new ColorDialog();
            btnOK = new Button();
            this.btnCancel = new Button();
            TabControlModule.SuspendLayout();
            tabpagModuleBasic.SuspendLayout();
            nudXY.BeginInit();
            nudModEntryX.BeginInit();
            nudModEntryY.BeginInit();
            nudModEntryZ.BeginInit();
            tabpagModuleAdvanced.SuspendLayout();
            nudXPScale.BeginInit();
            trkbarXPScale.BeginInit();
            nudMinutesPerHour.BeginInit();
            nudDawnStartHour.BeginInit();
            nudDuskStartHour.BeginInit();
            nudStartHour.BeginInit();
            nudStartDay.BeginInit();
            nudStartMonth.BeginInit();
            nudStartYear.BeginInit();
            tabpagModuleEvents.SuspendLayout();
            tabpagModuleDescription.SuspendLayout();
            TabControlMain.SuspendLayout();
            TabPage5.SuspendLayout();
            TabPage6.SuspendLayout();
            TabControlArea.SuspendLayout();
            tabpagAreaBasic.SuspendLayout();
            NumericUpDown10.BeginInit();
            NumericUpDown11.BeginInit();
            NumericUpDown12.BeginInit();
            tabpagAreaEnvironment.SuspendLayout();
            GroupBox1.SuspendLayout();
            nudChanceSnow.BeginInit();
            nudChanceRain.BeginInit();
            nudChanceLightning.BeginInit();
            gbMoon.SuspendLayout();
            trkbarMoonFogNear.BeginInit();
            trkbarMoonFogFar.BeginInit();
            gbSun.SuspendLayout();
            trkbarSunFogNear.BeginInit();
            trkbarSunFogFar.BeginInit();
            nudShadowOpacity.BeginInit();
            tabpagAreaGrass.SuspendLayout();
            nudGrassDensity.BeginInit();
            trkbarGrassDensityX10.BeginInit();
            nudGrassProbUL.BeginInit();
            nudGrassProbLL.BeginInit();
            nudGrassProbUR.BeginInit();
            nudGrassProbLR.BeginInit();
            nudGrassQuadSize.BeginInit();
            tabpagAreaAudio.SuspendLayout();
            trkbarAmbientSndNightVol.BeginInit();
            trkbarAmbientSndDayVol.BeginInit();
            nudMusicDelay.BeginInit();
            tabpagArea_Events.SuspendLayout();
            tabpagAreaRooms.SuspendLayout();
            nudRoomAmbientScale.BeginInit();
            nudRoomForceRating.BeginInit();
            SuspendLayout();
            TabControlModule.Controls.Add(tabpagModuleBasic);
            TabControlModule.Controls.Add(tabpagModuleAdvanced);
            TabControlModule.Controls.Add(tabpagModuleEvents);
            TabControlModule.Controls.Add(tabpagModuleDescription);
            TabControlModule.Dock = DockStyle.Fill;
            var tabControlModule1 = TabControlModule;
            var point1 = new Point(0, 0);
            var point2 = point1;
            tabControlModule1.Location = point2;
            TabControlModule.Name = "TabControlModule";
            var tabControlModule2 = TabControlModule;
            point1 = new Point(12, 3);
            var point3 = point1;
            tabControlModule2.Padding = point3;
            TabControlModule.SelectedIndex = 0;
            var tabControlModule3 = TabControlModule;
            var size1 = new Size(488, 470);
            var size2 = size1;
            tabControlModule3.Size = size2;
            TabControlModule.TabIndex = 0;
            tabpagModuleBasic.Controls.Add(pboxXY);
            tabpagModuleBasic.Controls.Add(nudXY);
            tabpagModuleBasic.Controls.Add(lblBearing);
            tabpagModuleBasic.Controls.Add(Label11);
            tabpagModuleBasic.Controls.Add(nudModEntryX);
            tabpagModuleBasic.Controls.Add(Label12);
            tabpagModuleBasic.Controls.Add(nudModEntryY);
            tabpagModuleBasic.Controls.Add(Label13);
            tabpagModuleBasic.Controls.Add(nudModEntryZ);
            tabpagModuleBasic.Controls.Add(btnSetModNameLang);
            tabpagModuleBasic.Controls.Add(tbModTag);
            tabpagModuleBasic.Controls.Add(tbModName);
            tabpagModuleBasic.Controls.Add(Label8);
            tabpagModuleBasic.Controls.Add(Label9);
            tabpagModuleBasic.Controls.Add(tbModEntryArea);
            tabpagModuleBasic.Controls.Add(Label10);
            var tabpagModuleBasic1 = tabpagModuleBasic;
            point1 = new Point(4, 22);
            var point4 = point1;
            ((Control)tabpagModuleBasic1).Location = point4;
            tabpagModuleBasic.Name = "tabpagModuleBasic";
            var tabpagModuleBasic2 = tabpagModuleBasic;
            size1 = new Size(480, 444);
            var size3 = size1;
            tabpagModuleBasic2.Size = size3;
            tabpagModuleBasic.TabIndex = 0;
            tabpagModuleBasic.Text = "Basic";
            var pboxXy1 = pboxXY;
            point1 = new Point(312, 152);
            var point5 = point1;
            pboxXy1.Location = point5;
            pboxXY.Name = "pboxXY";
            var pboxXy2 = pboxXY;
            size1 = new Size(50, 50);
            var size4 = size1;
            pboxXy2.Size = size4;
            pboxXY.TabIndex = 22;
            pboxXY.TabStop = false;
            nudXY.DecimalPlaces = 2;
            var nudXy1 = nudXY;
            point1 = new Point(304, 208);
            var point6 = point1;
            nudXy1.Location = point6;
            var nudXy2 = nudXY;
            var num1 = new Decimal(new int[4]
            {
                736755711,
                8381903,
                0,
                917504
            });
            var num2 = num1;
            nudXy2.Maximum = num2;
            nudXY.Name = "nudXY";
            var nudXy3 = nudXY;
            size1 = new Size(64, 20);
            var size5 = size1;
            nudXy3.Size = size5;
            nudXY.TabIndex = 23;
            nudXY.TextAlign = HorizontalAlignment.Center;
            var lblBearing1 = lblBearing;
            point1 = new Point(312, 128);
            var point7 = point1;
            lblBearing1.Location = point7;
            lblBearing.Name = "lblBearing";
            var lblBearing2 = lblBearing;
            size1 = new Size(48, 16);
            var size6 = size1;
            lblBearing2.Size = size6;
            lblBearing.TabIndex = 21;
            lblBearing.Text = "Bearing";
            lblBearing.TextAlign = ContentAlignment.MiddleCenter;
            var label11_1 = Label11;
            point1 = new Point(24, 144);
            var point8 = point1;
            label11_1.Location = point8;
            Label11.Name = "Label11";
            var label11_2 = Label11;
            size1 = new Size(104, 16);
            var size7 = size1;
            label11_2.Size = size7;
            Label11.TabIndex = 19;
            Label11.Text = "Starting Position X";
            Label11.TextAlign = ContentAlignment.MiddleRight;
            nudModEntryX.DecimalPlaces = 4;
            var nudModEntryX1 = nudModEntryX;
            point1 = new Point(144, 144);
            var point9 = point1;
            nudModEntryX1.Location = point9;
            var nudModEntryX2 = nudModEntryX;
            num1 = new Decimal(new int[4] { 4000, 0, 0, 0 });
            var num3 = num1;
            nudModEntryX2.Maximum = num3;
            var nudModEntryX3 = nudModEntryX;
            num1 = new Decimal(new int[4]
            {
                4000,
                0,
                0,
                int.MinValue
            });
            var num4 = num1;
            nudModEntryX3.Minimum = num4;
            nudModEntryX.Name = "nudModEntryX";
            var nudModEntryX4 = nudModEntryX;
            size1 = new Size(96, 20);
            var size8 = size1;
            nudModEntryX4.Size = size8;
            nudModEntryX.TabIndex = 4;
            nudModEntryX.TextAlign = HorizontalAlignment.Right;
            var label12_1 = Label12;
            point1 = new Point(24, 176);
            var point10 = point1;
            label12_1.Location = point10;
            Label12.Name = "Label12";
            var label12_2 = Label12;
            size1 = new Size(104, 16);
            var size9 = size1;
            label12_2.Size = size9;
            Label12.TabIndex = 20;
            Label12.Text = "Starting Position Y";
            Label12.TextAlign = ContentAlignment.MiddleRight;
            nudModEntryY.DecimalPlaces = 4;
            var nudModEntryY1 = nudModEntryY;
            point1 = new Point(144, 176);
            var point11 = point1;
            nudModEntryY1.Location = point11;
            var nudModEntryY2 = nudModEntryY;
            num1 = new Decimal(new int[4] { 4000, 0, 0, 0 });
            var num5 = num1;
            nudModEntryY2.Maximum = num5;
            var nudModEntryY3 = nudModEntryY;
            num1 = new Decimal(new int[4]
            {
                4000,
                0,
                0,
                int.MinValue
            });
            var num6 = num1;
            nudModEntryY3.Minimum = num6;
            nudModEntryY.Name = "nudModEntryY";
            var nudModEntryY4 = nudModEntryY;
            size1 = new Size(96, 20);
            var size10 = size1;
            nudModEntryY4.Size = size10;
            nudModEntryY.TabIndex = 5;
            nudModEntryY.TextAlign = HorizontalAlignment.Right;
            var label13_1 = Label13;
            point1 = new Point(24, 208);
            var point12 = point1;
            label13_1.Location = point12;
            Label13.Name = "Label13";
            var label13_2 = Label13;
            size1 = new Size(104, 16);
            var size11 = size1;
            label13_2.Size = size11;
            Label13.TabIndex = 18;
            Label13.Text = "Starting Position Z";
            Label13.TextAlign = ContentAlignment.MiddleRight;
            nudModEntryZ.DecimalPlaces = 4;
            var nudModEntryZ1 = nudModEntryZ;
            point1 = new Point(144, 208);
            var point13 = point1;
            nudModEntryZ1.Location = point13;
            var nudModEntryZ2 = nudModEntryZ;
            num1 = new Decimal(new int[4] { 4000, 0, 0, 0 });
            var num7 = num1;
            nudModEntryZ2.Maximum = num7;
            var nudModEntryZ3 = nudModEntryZ;
            num1 = new Decimal(new int[4]
            {
                4000,
                0,
                0,
                int.MinValue
            });
            var num8 = num1;
            nudModEntryZ3.Minimum = num8;
            nudModEntryZ.Name = "nudModEntryZ";
            var nudModEntryZ4 = nudModEntryZ;
            size1 = new Size(96, 20);
            var size12 = size1;
            nudModEntryZ4.Size = size12;
            nudModEntryZ.TabIndex = 6;
            nudModEntryZ.TextAlign = HorizontalAlignment.Right;
            var btnSetModNameLang1 = btnSetModNameLang;
            point1 = new Point(296, 40);
            var point14 = point1;
            btnSetModNameLang1.Location = point14;
            btnSetModNameLang.Name = "btnSetModNameLang";
            var btnSetModNameLang2 = btnSetModNameLang;
            size1 = new Size(88, 23);
            var size13 = size1;
            btnSetModNameLang2.Size = size13;
            btnSetModNameLang.TabIndex = 1;
            btnSetModNameLang.Text = "Set Language";
            var tbModTag1 = tbModTag;
            point1 = new Point(112, 64);
            var point15 = point1;
            tbModTag1.Location = point15;
            tbModTag.Name = "tbModTag";
            var tbModTag2 = tbModTag;
            size1 = new Size(88, 20);
            var size14 = size1;
            tbModTag2.Size = size14;
            tbModTag.TabIndex = 2;
            tbModTag.Text = "";
            var tbModName1 = tbModName;
            point1 = new Point(112, 40);
            var point16 = point1;
            tbModName1.Location = point16;
            tbModName.Name = "tbModName";
            var tbModName2 = tbModName;
            size1 = new Size(176, 20);
            var size15 = size1;
            tbModName2.Size = size15;
            tbModName.TabIndex = 0;
            tbModName.Text = "";
            var label8_1 = Label8;
            point1 = new Point(24, 40);
            var point17 = point1;
            label8_1.Location = point17;
            Label8.Name = "Label8";
            var label8_2 = Label8;
            size1 = new Size(48, 16);
            var size16 = size1;
            label8_2.Size = size16;
            Label8.TabIndex = 10;
            Label8.Text = "Name";
            Label8.TextAlign = ContentAlignment.MiddleLeft;
            var label9_1 = Label9;
            point1 = new Point(24, 64);
            var point18 = point1;
            label9_1.Location = point18;
            Label9.Name = "Label9";
            var label9_2 = Label9;
            size1 = new Size(48, 16);
            var size17 = size1;
            label9_2.Size = size17;
            Label9.TabIndex = 11;
            Label9.Text = "Tag";
            Label9.TextAlign = ContentAlignment.MiddleLeft;
            var tbModEntryArea1 = tbModEntryArea;
            point1 = new Point(112, 104);
            var point19 = point1;
            tbModEntryArea1.Location = point19;
            tbModEntryArea.Name = "tbModEntryArea";
            var tbModEntryArea2 = tbModEntryArea;
            size1 = new Size(176, 20);
            var size18 = size1;
            tbModEntryArea2.Size = size18;
            tbModEntryArea.TabIndex = 3;
            tbModEntryArea.Text = "";
            var label10_1 = Label10;
            point1 = new Point(16, 104);
            var point20 = point1;
            label10_1.Location = point20;
            Label10.Name = "Label10";
            var label10_2 = Label10;
            size1 = new Size(56, 16);
            var size19 = size1;
            label10_2.Size = size19;
            Label10.TabIndex = 10;
            Label10.Text = "Start Area";
            Label10.TextAlign = ContentAlignment.MiddleLeft;
            tabpagModuleAdvanced.Controls.Add(nudXPScale);
            tabpagModuleAdvanced.Controls.Add(trkbarXPScale);
            tabpagModuleAdvanced.Controls.Add(Label46);
            tabpagModuleAdvanced.Controls.Add(nudMinutesPerHour);
            tabpagModuleAdvanced.Controls.Add(Label1);
            tabpagModuleAdvanced.Controls.Add(nudDawnStartHour);
            tabpagModuleAdvanced.Controls.Add(Label2);
            tabpagModuleAdvanced.Controls.Add(nudDuskStartHour);
            tabpagModuleAdvanced.Controls.Add(Label3);
            tabpagModuleAdvanced.Controls.Add(nudStartHour);
            tabpagModuleAdvanced.Controls.Add(Label4);
            tabpagModuleAdvanced.Controls.Add(nudStartDay);
            tabpagModuleAdvanced.Controls.Add(Label5);
            tabpagModuleAdvanced.Controls.Add(nudStartMonth);
            tabpagModuleAdvanced.Controls.Add(Label6);
            tabpagModuleAdvanced.Controls.Add(nudStartYear);
            tabpagModuleAdvanced.Controls.Add(Label7);
            var tabpagModuleAdvanced1 = tabpagModuleAdvanced;
            point1 = new Point(4, 22);
            var point21 = point1;
            ((Control)tabpagModuleAdvanced1).Location = point21;
            tabpagModuleAdvanced.Name = "tabpagModuleAdvanced";
            var tabpagModuleAdvanced2 = tabpagModuleAdvanced;
            size1 = new Size(480, 444);
            var size20 = size1;
            tabpagModuleAdvanced2.Size = size20;
            tabpagModuleAdvanced.TabIndex = 2;
            tabpagModuleAdvanced.Text = "Advanced";
            var nudXpScale1 = nudXPScale;
            point1 = new Point(336, 272);
            var point22 = point1;
            nudXpScale1.Location = point22;
            var nudXpScale2 = nudXPScale;
            num1 = new Decimal(new int[4] { 200, 0, 0, 0 });
            var num9 = num1;
            nudXpScale2.Maximum = num9;
            nudXPScale.Name = "nudXPScale";
            nudXPScale.RightToLeft = RightToLeft.No;
            var nudXpScale3 = nudXPScale;
            size1 = new Size(42, 20);
            var size21 = size1;
            nudXpScale3.Size = size21;
            nudXPScale.TabIndex = 8;
            nudXPScale.TextAlign = HorizontalAlignment.Right;
            var trkbarXpScale1 = trkbarXPScale;
            point1 = new Point(120, 264);
            var point23 = point1;
            trkbarXpScale1.Location = point23;
            trkbarXPScale.Maximum = 200;
            trkbarXPScale.Name = "trkbarXPScale";
            var trkbarXpScale2 = trkbarXPScale;
            size1 = new Size(216, 42);
            var size22 = size1;
            trkbarXpScale2.Size = size22;
            trkbarXPScale.TabIndex = 7;
            trkbarXPScale.TickFrequency = 10;
            var label46_1 = Label46;
            point1 = new Point(24, 40);
            var point24 = point1;
            label46_1.Location = point24;
            Label46.Name = "Label46";
            var label46_2 = Label46;
            size1 = new Size(88, 16);
            var size23 = size1;
            label46_2.Size = size23;
            Label46.TabIndex = 5;
            Label46.Text = "Minutes/Hour";
            Label46.TextAlign = ContentAlignment.MiddleLeft;
            var nudMinutesPerHour1 = nudMinutesPerHour;
            point1 = new Point(128, 40);
            var point25 = point1;
            nudMinutesPerHour1.Location = point25;
            var nudMinutesPerHour2 = nudMinutesPerHour;
            num1 = new Decimal(new int[4] { 60, 0, 0, 0 });
            var num10 = num1;
            nudMinutesPerHour2.Maximum = num10;
            var nudMinutesPerHour3 = nudMinutesPerHour;
            num1 = new Decimal(new int[4] { 1, 0, 0, 0 });
            var num11 = num1;
            nudMinutesPerHour3.Minimum = num11;
            nudMinutesPerHour.Name = "nudMinutesPerHour";
            var nudMinutesPerHour4 = nudMinutesPerHour;
            size1 = new Size(48, 20);
            var size24 = size1;
            nudMinutesPerHour4.Size = size24;
            nudMinutesPerHour.TabIndex = 0;
            nudMinutesPerHour.TextAlign = HorizontalAlignment.Right;
            var nudMinutesPerHour5 = nudMinutesPerHour;
            num1 = new Decimal(new int[4] { 1, 0, 0, 0 });
            var num12 = num1;
            nudMinutesPerHour5.Value = num12;
            var label1_1 = Label1;
            point1 = new Point(24, 72);
            var point26 = point1;
            label1_1.Location = point26;
            Label1.Name = "Label1";
            var label1_2 = Label1;
            size1 = new Size(88, 16);
            var size25 = size1;
            label1_2.Size = size25;
            Label1.TabIndex = 5;
            Label1.Text = "Dawn Start Hour";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            var nudDawnStartHour1 = nudDawnStartHour;
            point1 = new Point(128, 72);
            var point27 = point1;
            nudDawnStartHour1.Location = point27;
            var nudDawnStartHour2 = nudDawnStartHour;
            num1 = new Decimal(new int[4] { 23, 0, 0, 0 });
            var num13 = num1;
            nudDawnStartHour2.Maximum = num13;
            nudDawnStartHour.Name = "nudDawnStartHour";
            var nudDawnStartHour3 = nudDawnStartHour;
            size1 = new Size(48, 20);
            var size26 = size1;
            nudDawnStartHour3.Size = size26;
            nudDawnStartHour.TabIndex = 1;
            nudDawnStartHour.TextAlign = HorizontalAlignment.Right;
            var label2_1 = Label2;
            point1 = new Point(24, 104);
            var point28 = point1;
            label2_1.Location = point28;
            Label2.Name = "Label2";
            var label2_2 = Label2;
            size1 = new Size(88, 16);
            var size27 = size1;
            label2_2.Size = size27;
            Label2.TabIndex = 5;
            Label2.Text = "Dusk Start Hour";
            Label2.TextAlign = ContentAlignment.MiddleLeft;
            var nudDuskStartHour1 = nudDuskStartHour;
            point1 = new Point(128, 104);
            var point29 = point1;
            nudDuskStartHour1.Location = point29;
            var nudDuskStartHour2 = nudDuskStartHour;
            num1 = new Decimal(new int[4] { 23, 0, 0, 0 });
            var num14 = num1;
            nudDuskStartHour2.Maximum = num14;
            nudDuskStartHour.Name = "nudDuskStartHour";
            var nudDuskStartHour3 = nudDuskStartHour;
            size1 = new Size(48, 20);
            var size28 = size1;
            nudDuskStartHour3.Size = size28;
            nudDuskStartHour.TabIndex = 2;
            nudDuskStartHour.TextAlign = HorizontalAlignment.Right;
            var label3_1 = Label3;
            point1 = new Point(24, 200);
            var point30 = point1;
            label3_1.Location = point30;
            Label3.Name = "Label3";
            var label3_2 = Label3;
            size1 = new Size(80, 16);
            var size29 = size1;
            label3_2.Size = size29;
            Label3.TabIndex = 5;
            Label3.Text = "Starting Month";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            var nudStartHour1 = nudStartHour;
            point1 = new Point(128, 136);
            var point31 = point1;
            nudStartHour1.Location = point31;
            var nudStartHour2 = nudStartHour;
            num1 = new Decimal(new int[4] { 23, 0, 0, 0 });
            var num15 = num1;
            nudStartHour2.Maximum = num15;
            nudStartHour.Name = "nudStartHour";
            var nudStartHour3 = nudStartHour;
            size1 = new Size(48, 20);
            var size30 = size1;
            nudStartHour3.Size = size30;
            nudStartHour.TabIndex = 3;
            nudStartHour.TextAlign = HorizontalAlignment.Right;
            var label4_1 = Label4;
            point1 = new Point(24, 168);
            var point32 = point1;
            label4_1.Location = point32;
            Label4.Name = "Label4";
            var label4_2 = Label4;
            size1 = new Size(72, 16);
            var size31 = size1;
            label4_2.Size = size31;
            Label4.TabIndex = 5;
            Label4.Text = "Starting Day";
            Label4.TextAlign = ContentAlignment.MiddleLeft;
            var nudStartDay1 = nudStartDay;
            point1 = new Point(128, 168);
            var point33 = point1;
            nudStartDay1.Location = point33;
            var nudStartDay2 = nudStartDay;
            num1 = new Decimal(new int[4] { 31, 0, 0, 0 });
            var num16 = num1;
            nudStartDay2.Maximum = num16;
            var nudStartDay3 = nudStartDay;
            num1 = new Decimal(new int[4] { 1, 0, 0, 0 });
            var num17 = num1;
            nudStartDay3.Minimum = num17;
            nudStartDay.Name = "nudStartDay";
            var nudStartDay4 = nudStartDay;
            size1 = new Size(48, 20);
            var size32 = size1;
            nudStartDay4.Size = size32;
            nudStartDay.TabIndex = 4;
            nudStartDay.TextAlign = HorizontalAlignment.Right;
            var nudStartDay5 = nudStartDay;
            num1 = new Decimal(new int[4] { 1, 0, 0, 0 });
            var num18 = num1;
            nudStartDay5.Value = num18;
            var label5_1 = Label5;
            point1 = new Point(24, 136);
            var point34 = point1;
            label5_1.Location = point34;
            Label5.Name = "Label5";
            var label5_2 = Label5;
            size1 = new Size(72, 16);
            var size33 = size1;
            label5_2.Size = size33;
            Label5.TabIndex = 5;
            Label5.Text = "Starting Hour";
            Label5.TextAlign = ContentAlignment.MiddleLeft;
            var nudStartMonth1 = nudStartMonth;
            point1 = new Point(128, 200);
            var point35 = point1;
            nudStartMonth1.Location = point35;
            var nudStartMonth2 = nudStartMonth;
            num1 = new Decimal(new int[4] { 12, 0, 0, 0 });
            var num19 = num1;
            nudStartMonth2.Maximum = num19;
            var nudStartMonth3 = nudStartMonth;
            num1 = new Decimal(new int[4] { 1, 0, 0, 0 });
            var num20 = num1;
            nudStartMonth3.Minimum = num20;
            nudStartMonth.Name = "nudStartMonth";
            var nudStartMonth4 = nudStartMonth;
            size1 = new Size(48, 20);
            var size34 = size1;
            nudStartMonth4.Size = size34;
            nudStartMonth.TabIndex = 5;
            nudStartMonth.TextAlign = HorizontalAlignment.Right;
            var nudStartMonth5 = nudStartMonth;
            num1 = new Decimal(new int[4] { 1, 0, 0, 0 });
            var num21 = num1;
            nudStartMonth5.Value = num21;
            var label6_1 = Label6;
            point1 = new Point(24, 232);
            var point36 = point1;
            label6_1.Location = point36;
            Label6.Name = "Label6";
            var label6_2 = Label6;
            size1 = new Size(72, 16);
            var size35 = size1;
            label6_2.Size = size35;
            Label6.TabIndex = 5;
            Label6.Text = "Starting Year";
            Label6.TextAlign = ContentAlignment.MiddleLeft;
            var nudStartYear1 = nudStartYear;
            point1 = new Point(128, 232);
            var point37 = point1;
            nudStartYear1.Location = point37;
            var nudStartYear2 = nudStartYear;
            num1 = new Decimal(new int[4] { 4000, 0, 0, 0 });
            var num22 = num1;
            nudStartYear2.Maximum = num22;
            nudStartYear.Name = "nudStartYear";
            var nudStartYear3 = nudStartYear;
            size1 = new Size(48, 20);
            var size36 = size1;
            nudStartYear3.Size = size36;
            nudStartYear.TabIndex = 6;
            nudStartYear.TextAlign = HorizontalAlignment.Right;
            var label7_1 = Label7;
            point1 = new Point(24, 272);
            var point38 = point1;
            label7_1.Location = point38;
            Label7.Name = "Label7";
            var label7_2 = Label7;
            size1 = new Size(56, 16);
            var size37 = size1;
            label7_2.Size = size37;
            Label7.TabIndex = 5;
            Label7.Text = "XP Scale";
            Label7.TextAlign = ContentAlignment.MiddleLeft;
            tabpagModuleEvents.Controls.Add(Label34);
            tabpagModuleEvents.Controls.Add(tbMod_OnClientEntr);
            tabpagModuleEvents.Controls.Add(Label33);
            tabpagModuleEvents.Controls.Add(tbMod_OnActvtItem);
            tabpagModuleEvents.Controls.Add(Label32);
            tabpagModuleEvents.Controls.Add(tbMod_OnAcquirItem);
            tabpagModuleEvents.Controls.Add(Label35);
            tabpagModuleEvents.Controls.Add(tbMod_OnClientLeav);
            tabpagModuleEvents.Controls.Add(tbMod_OnHeartbeat);
            tabpagModuleEvents.Controls.Add(Label36);
            tabpagModuleEvents.Controls.Add(Label37);
            tabpagModuleEvents.Controls.Add(tbMod_OnModLoad);
            tabpagModuleEvents.Controls.Add(tbMod_OnPlrDeath);
            tabpagModuleEvents.Controls.Add(Label38);
            tabpagModuleEvents.Controls.Add(tbMod_OnPlrDying);
            tabpagModuleEvents.Controls.Add(Label39);
            tabpagModuleEvents.Controls.Add(Label40);
            tabpagModuleEvents.Controls.Add(tbMod_OnPlrLvlUp);
            tabpagModuleEvents.Controls.Add(Label41);
            tabpagModuleEvents.Controls.Add(tbMod_OnSpawnBtnDn);
            tabpagModuleEvents.Controls.Add(tbMod_OnPlrRest);
            tabpagModuleEvents.Controls.Add(Label42);
            tabpagModuleEvents.Controls.Add(tbMod_OnUnAqreItem);
            tabpagModuleEvents.Controls.Add(Label43);
            tabpagModuleEvents.Controls.Add(Label44);
            tabpagModuleEvents.Controls.Add(tbMod_OnUsrDefined);
            var tabpagModuleEvents1 = tabpagModuleEvents;
            point1 = new Point(4, 22);
            var point39 = point1;
            ((Control)tabpagModuleEvents1).Location = point39;
            tabpagModuleEvents.Name = "tabpagModuleEvents";
            var tabpagModuleEvents2 = tabpagModuleEvents;
            size1 = new Size(480, 444);
            var size38 = size1;
            tabpagModuleEvents2.Size = size38;
            tabpagModuleEvents.TabIndex = 1;
            tabpagModuleEvents.Text = "Events";
            var label34_1 = Label34;
            point1 = new Point(24, 88);
            var point40 = point1;
            label34_1.Location = point40;
            Label34.Name = "Label34";
            var label34_2 = Label34;
            size1 = new Size(100, 18);
            var size39 = size1;
            label34_2.Size = size39;
            Label34.TabIndex = 28;
            Label34.Text = "OnClientEnter";
            Label34.TextAlign = ContentAlignment.MiddleLeft;
            tbMod_OnClientEntr.CharacterCasing = CharacterCasing.Lower;
            var tbModOnClientEntr1 = tbMod_OnClientEntr;
            point1 = new Point(136, 88);
            var point41 = point1;
            tbModOnClientEntr1.Location = point41;
            tbMod_OnClientEntr.MaxLength = 16;
            tbMod_OnClientEntr.Name = "tbMod_OnClientEntr";
            var tbModOnClientEntr2 = tbMod_OnClientEntr;
            size1 = new Size(204, 20);
            var size40 = size1;
            tbModOnClientEntr2.Size = size40;
            tbMod_OnClientEntr.TabIndex = 2;
            tbMod_OnClientEntr.Text = "";
            var label33_1 = Label33;
            point1 = new Point(24, 64);
            var point42 = point1;
            label33_1.Location = point42;
            Label33.Name = "Label33";
            var label33_2 = Label33;
            size1 = new Size(100, 18);
            var size41 = size1;
            label33_2.Size = size41;
            Label33.TabIndex = 18;
            Label33.Text = "OnActivateItem";
            Label33.TextAlign = ContentAlignment.MiddleLeft;
            tbMod_OnActvtItem.CharacterCasing = CharacterCasing.Lower;
            var tbModOnActvtItem1 = tbMod_OnActvtItem;
            point1 = new Point(136, 64);
            var point43 = point1;
            tbModOnActvtItem1.Location = point43;
            tbMod_OnActvtItem.MaxLength = 16;
            tbMod_OnActvtItem.Name = "tbMod_OnActvtItem";
            var tbModOnActvtItem2 = tbMod_OnActvtItem;
            size1 = new Size(204, 20);
            var size42 = size1;
            tbModOnActvtItem2.Size = size42;
            tbMod_OnActvtItem.TabIndex = 1;
            tbMod_OnActvtItem.Text = "";
            var label32_1 = Label32;
            point1 = new Point(24, 40);
            var point44 = point1;
            label32_1.Location = point44;
            Label32.Name = "Label32";
            var label32_2 = Label32;
            size1 = new Size(100, 18);
            var size43 = size1;
            label32_2.Size = size43;
            Label32.TabIndex = 15;
            Label32.Text = "OnAcquireItem";
            Label32.TextAlign = ContentAlignment.MiddleLeft;
            tbMod_OnAcquirItem.CharacterCasing = CharacterCasing.Lower;
            var tbModOnAcquirItem1 = tbMod_OnAcquirItem;
            point1 = new Point(136, 40);
            var point45 = point1;
            tbModOnAcquirItem1.Location = point45;
            tbMod_OnAcquirItem.MaxLength = 16;
            tbMod_OnAcquirItem.Name = "tbMod_OnAcquirItem";
            var tbModOnAcquirItem2 = tbMod_OnAcquirItem;
            size1 = new Size(204, 20);
            var size44 = size1;
            tbModOnAcquirItem2.Size = size44;
            tbMod_OnAcquirItem.TabIndex = 0;
            tbMod_OnAcquirItem.Text = "";
            var label35_1 = Label35;
            point1 = new Point(24, 112);
            var point46 = point1;
            label35_1.Location = point46;
            Label35.Name = "Label35";
            var label35_2 = Label35;
            size1 = new Size(100, 18);
            var size45 = size1;
            label35_2.Size = size45;
            Label35.TabIndex = 27;
            Label35.Text = "OnClientLeave";
            Label35.TextAlign = ContentAlignment.MiddleLeft;
            tbMod_OnClientLeav.CharacterCasing = CharacterCasing.Lower;
            var tbModOnClientLeav1 = tbMod_OnClientLeav;
            point1 = new Point(136, 112);
            var point47 = point1;
            tbModOnClientLeav1.Location = point47;
            tbMod_OnClientLeav.MaxLength = 16;
            tbMod_OnClientLeav.Name = "tbMod_OnClientLeav";
            var tbModOnClientLeav2 = tbMod_OnClientLeav;
            size1 = new Size(204, 20);
            var size46 = size1;
            tbModOnClientLeav2.Size = size46;
            tbMod_OnClientLeav.TabIndex = 3;
            tbMod_OnClientLeav.Text = "";
            tbMod_OnHeartbeat.CharacterCasing = CharacterCasing.Lower;
            var tbModOnHeartbeat1 = tbMod_OnHeartbeat;
            point1 = new Point(136, 136);
            var point48 = point1;
            tbModOnHeartbeat1.Location = point48;
            tbMod_OnHeartbeat.MaxLength = 16;
            tbMod_OnHeartbeat.Name = "tbMod_OnHeartbeat";
            var tbModOnHeartbeat2 = tbMod_OnHeartbeat;
            size1 = new Size(204, 20);
            var size47 = size1;
            tbModOnHeartbeat2.Size = size47;
            tbMod_OnHeartbeat.TabIndex = 4;
            tbMod_OnHeartbeat.Text = "";
            var label36_1 = Label36;
            point1 = new Point(24, 136);
            var point49 = point1;
            label36_1.Location = point49;
            Label36.Name = "Label36";
            var label36_2 = Label36;
            size1 = new Size(100, 18);
            var size48 = size1;
            label36_2.Size = size48;
            Label36.TabIndex = 26;
            Label36.Text = "OnHeartbeat";
            Label36.TextAlign = ContentAlignment.MiddleLeft;
            var label37_1 = Label37;
            point1 = new Point(24, 160);
            var point50 = point1;
            label37_1.Location = point50;
            Label37.Name = "Label37";
            var label37_2 = Label37;
            size1 = new Size(100, 18);
            var size49 = size1;
            label37_2.Size = size49;
            Label37.TabIndex = 31;
            Label37.Text = "OnModuleLoad";
            Label37.TextAlign = ContentAlignment.MiddleLeft;
            tbMod_OnModLoad.CharacterCasing = CharacterCasing.Lower;
            var tbModOnModLoad1 = tbMod_OnModLoad;
            point1 = new Point(136, 160);
            var point51 = point1;
            tbModOnModLoad1.Location = point51;
            tbMod_OnModLoad.MaxLength = 16;
            tbMod_OnModLoad.Name = "tbMod_OnModLoad";
            var tbModOnModLoad2 = tbMod_OnModLoad;
            size1 = new Size(204, 20);
            var size50 = size1;
            tbModOnModLoad2.Size = size50;
            tbMod_OnModLoad.TabIndex = 5;
            tbMod_OnModLoad.Text = "";
            tbMod_OnPlrDeath.CharacterCasing = CharacterCasing.Lower;
            var tbModOnPlrDeath1 = tbMod_OnPlrDeath;
            point1 = new Point(136, 184);
            var point52 = point1;
            tbModOnPlrDeath1.Location = point52;
            tbMod_OnPlrDeath.MaxLength = 16;
            tbMod_OnPlrDeath.Name = "tbMod_OnPlrDeath";
            var tbModOnPlrDeath2 = tbMod_OnPlrDeath;
            size1 = new Size(204, 20);
            var size51 = size1;
            tbModOnPlrDeath2.Size = size51;
            tbMod_OnPlrDeath.TabIndex = 6;
            tbMod_OnPlrDeath.Text = "";
            var label38_1 = Label38;
            point1 = new Point(24, 184);
            var point53 = point1;
            label38_1.Location = point53;
            Label38.Name = "Label38";
            var label38_2 = Label38;
            size1 = new Size(100, 18);
            var size52 = size1;
            label38_2.Size = size52;
            Label38.TabIndex = 21;
            Label38.Text = "OnPlayerDeath";
            Label38.TextAlign = ContentAlignment.MiddleLeft;
            tbMod_OnPlrDying.CharacterCasing = CharacterCasing.Lower;
            var tbModOnPlrDying1 = tbMod_OnPlrDying;
            point1 = new Point(136, 208);
            var point54 = point1;
            tbModOnPlrDying1.Location = point54;
            tbMod_OnPlrDying.MaxLength = 16;
            tbMod_OnPlrDying.Name = "tbMod_OnPlrDying";
            var tbModOnPlrDying2 = tbMod_OnPlrDying;
            size1 = new Size(204, 20);
            var size53 = size1;
            tbModOnPlrDying2.Size = size53;
            tbMod_OnPlrDying.TabIndex = 7;
            tbMod_OnPlrDying.Text = "";
            var label39_1 = Label39;
            point1 = new Point(24, 208);
            var point55 = point1;
            label39_1.Location = point55;
            Label39.Name = "Label39";
            var label39_2 = Label39;
            size1 = new Size(100, 18);
            var size54 = size1;
            label39_2.Size = size54;
            Label39.TabIndex = 20;
            Label39.Text = "OnPlayerDying";
            Label39.TextAlign = ContentAlignment.MiddleLeft;
            var label40_1 = Label40;
            point1 = new Point(24, 232);
            var point56 = point1;
            label40_1.Location = point56;
            Label40.Name = "Label40";
            var label40_2 = Label40;
            size1 = new Size(100, 18);
            var size55 = size1;
            label40_2.Size = size55;
            Label40.TabIndex = 25;
            Label40.Text = "OnPlayerLevelUp";
            Label40.TextAlign = ContentAlignment.MiddleLeft;
            tbMod_OnPlrLvlUp.CharacterCasing = CharacterCasing.Lower;
            var tbModOnPlrLvlUp1 = tbMod_OnPlrLvlUp;
            point1 = new Point(136, 232);
            var point57 = point1;
            tbModOnPlrLvlUp1.Location = point57;
            tbMod_OnPlrLvlUp.MaxLength = 16;
            tbMod_OnPlrLvlUp.Name = "tbMod_OnPlrLvlUp";
            var tbModOnPlrLvlUp2 = tbMod_OnPlrLvlUp;
            size1 = new Size(204, 20);
            var size56 = size1;
            tbModOnPlrLvlUp2.Size = size56;
            tbMod_OnPlrLvlUp.TabIndex = 8;
            tbMod_OnPlrLvlUp.Text = "";
            var label41_1 = Label41;
            point1 = new Point(24, 256);
            var point58 = point1;
            label41_1.Location = point58;
            Label41.Name = "Label41";
            var label41_2 = Label41;
            size1 = new Size(100, 18);
            var size57 = size1;
            label41_2.Size = size57;
            Label41.TabIndex = 23;
            Label41.Text = "OnPlayerRespawn";
            Label41.TextAlign = ContentAlignment.MiddleLeft;
            tbMod_OnSpawnBtnDn.CharacterCasing = CharacterCasing.Lower;
            var tbModOnSpawnBtnDn1 = tbMod_OnSpawnBtnDn;
            point1 = new Point(136, 256);
            var point59 = point1;
            tbModOnSpawnBtnDn1.Location = point59;
            tbMod_OnSpawnBtnDn.MaxLength = 16;
            tbMod_OnSpawnBtnDn.Name = "tbMod_OnSpawnBtnDn";
            var tbModOnSpawnBtnDn2 = tbMod_OnSpawnBtnDn;
            size1 = new Size(204, 20);
            var size58 = size1;
            tbModOnSpawnBtnDn2.Size = size58;
            tbMod_OnSpawnBtnDn.TabIndex = 9;
            tbMod_OnSpawnBtnDn.Text = "";
            tbMod_OnPlrRest.CharacterCasing = CharacterCasing.Lower;
            var tbModOnPlrRest1 = tbMod_OnPlrRest;
            point1 = new Point(136, 280);
            var point60 = point1;
            tbModOnPlrRest1.Location = point60;
            tbMod_OnPlrRest.MaxLength = 16;
            tbMod_OnPlrRest.Name = "tbMod_OnPlrRest";
            var tbModOnPlrRest2 = tbMod_OnPlrRest;
            size1 = new Size(204, 20);
            var size59 = size1;
            tbModOnPlrRest2.Size = size59;
            tbMod_OnPlrRest.TabIndex = 10;
            tbMod_OnPlrRest.Text = "";
            var label42_1 = Label42;
            point1 = new Point(24, 280);
            var point61 = point1;
            label42_1.Location = point61;
            Label42.Name = "Label42";
            var label42_2 = Label42;
            size1 = new Size(100, 18);
            var size60 = size1;
            label42_2.Size = size60;
            Label42.TabIndex = 24;
            Label42.Text = "OnPlayerRest";
            Label42.TextAlign = ContentAlignment.MiddleLeft;
            tbMod_OnUnAqreItem.CharacterCasing = CharacterCasing.Lower;
            var tbModOnUnAqreItem1 = tbMod_OnUnAqreItem;
            point1 = new Point(136, 304);
            var point62 = point1;
            tbModOnUnAqreItem1.Location = point62;
            tbMod_OnUnAqreItem.MaxLength = 16;
            tbMod_OnUnAqreItem.Name = "tbMod_OnUnAqreItem";
            var tbModOnUnAqreItem2 = tbMod_OnUnAqreItem;
            size1 = new Size(204, 20);
            var size61 = size1;
            tbModOnUnAqreItem2.Size = size61;
            tbMod_OnUnAqreItem.TabIndex = 11;
            tbMod_OnUnAqreItem.Text = "";
            var label43_1 = Label43;
            point1 = new Point(24, 304);
            var point63 = point1;
            label43_1.Location = point63;
            Label43.Name = "Label43";
            var label43_2 = Label43;
            size1 = new Size(100, 18);
            var size62 = size1;
            label43_2.Size = size62;
            Label43.TabIndex = 22;
            Label43.Text = "OnUnacquireItem";
            Label43.TextAlign = ContentAlignment.MiddleLeft;
            var label44_1 = Label44;
            point1 = new Point(24, 328);
            var point64 = point1;
            label44_1.Location = point64;
            Label44.Name = "Label44";
            var label44_2 = Label44;
            size1 = new Size(100, 18);
            var size63 = size1;
            label44_2.Size = size63;
            Label44.TabIndex = 29;
            Label44.Text = "OnUserDefined";
            Label44.TextAlign = ContentAlignment.MiddleLeft;
            tbMod_OnUsrDefined.CharacterCasing = CharacterCasing.Lower;
            var tbModOnUsrDefined1 = tbMod_OnUsrDefined;
            point1 = new Point(136, 328);
            var point65 = point1;
            tbModOnUsrDefined1.Location = point65;
            tbMod_OnUsrDefined.MaxLength = 16;
            tbMod_OnUsrDefined.Name = "tbMod_OnUsrDefined";
            var tbModOnUsrDefined2 = tbMod_OnUsrDefined;
            size1 = new Size(204, 20);
            var size64 = size1;
            tbModOnUsrDefined2.Size = size64;
            tbMod_OnUsrDefined.TabIndex = 12;
            tbMod_OnUsrDefined.Text = "";
            tabpagModuleDescription.Controls.Add(btnSetDescriptionLang);
            tabpagModuleDescription.Controls.Add(tbModDescription);
            var moduleDescription1 = tabpagModuleDescription;
            point1 = new Point(4, 22);
            var point66 = point1;
            ((Control)moduleDescription1).Location = point66;
            tabpagModuleDescription.Name = "tabpagModuleDescription";
            var moduleDescription2 = tabpagModuleDescription;
            size1 = new Size(480, 444);
            var size65 = size1;
            moduleDescription2.Size = size65;
            tabpagModuleDescription.TabIndex = 3;
            tabpagModuleDescription.Text = "Description";
            btnSetDescriptionLang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            var setDescriptionLang1 = btnSetDescriptionLang;
            point1 = new Point(368, 414);
            var point67 = point1;
            setDescriptionLang1.Location = point67;
            btnSetDescriptionLang.Name = "btnSetDescriptionLang";
            var setDescriptionLang2 = btnSetDescriptionLang;
            size1 = new Size(88, 23);
            var size66 = size1;
            setDescriptionLang2.Size = size66;
            btnSetDescriptionLang.TabIndex = 1;
            btnSetDescriptionLang.Text = "Set Language";
            tbModDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            var tbModDescription1 = tbModDescription;
            point1 = new Point(16, 8);
            var point68 = point1;
            tbModDescription1.Location = point68;
            tbModDescription.Multiline = true;
            tbModDescription.Name = "tbModDescription";
            var tbModDescription2 = tbModDescription;
            size1 = new Size(448, 391);
            var size67 = size1;
            tbModDescription2.Size = size67;
            tbModDescription.TabIndex = 0;
            tbModDescription.Text = "";
            TabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControlMain.Controls.Add(TabPage5);
            TabControlMain.Controls.Add(TabPage6);
            var tabControlMain1 = TabControlMain;
            point1 = new Point(16, 24);
            var point69 = point1;
            tabControlMain1.Location = point69;
            TabControlMain.Name = "TabControlMain";
            var tabControlMain2 = TabControlMain;
            point1 = new Point(12, 3);
            var point70 = point1;
            tabControlMain2.Padding = point70;
            TabControlMain.SelectedIndex = 0;
            var tabControlMain3 = TabControlMain;
            size1 = new Size(496, 496);
            var size68 = size1;
            tabControlMain3.Size = size68;
            TabControlMain.TabIndex = 1;
            TabPage5.Controls.Add(TabControlModule);
            var tabPage5_1 = TabPage5;
            point1 = new Point(4, 22);
            var point71 = point1;
            ((Control)tabPage5_1).Location = point71;
            TabPage5.Name = "TabPage5";
            var tabPage5_2 = TabPage5;
            size1 = new Size(488, 470);
            var size69 = size1;
            tabPage5_2.Size = size69;
            TabPage5.TabIndex = 0;
            TabPage5.Text = "Module";
            TabPage6.Controls.Add(TabControlArea);
            var tabPage6_1 = TabPage6;
            point1 = new Point(4, 22);
            var point72 = point1;
            ((Control)tabPage6_1).Location = point72;
            TabPage6.Name = "TabPage6";
            var tabPage6_2 = TabPage6;
            size1 = new Size(488, 470);
            var size70 = size1;
            tabPage6_2.Size = size70;
            TabPage6.TabIndex = 1;
            TabPage6.Text = "Area";
            TabControlArea.Controls.Add(tabpagAreaBasic);
            TabControlArea.Controls.Add(tabpagAreaEnvironment);
            TabControlArea.Controls.Add(tabpagAreaGrass);
            TabControlArea.Controls.Add(tabpagAreaAudio);
            TabControlArea.Controls.Add(tabpagArea_Events);
            TabControlArea.Controls.Add(tabpagAreaRooms);
            TabControlArea.Dock = DockStyle.Fill;
            var tabControlArea1 = TabControlArea;
            point1 = new Point(0, 0);
            var point73 = point1;
            tabControlArea1.Location = point73;
            TabControlArea.Name = "TabControlArea";
            var tabControlArea2 = TabControlArea;
            point1 = new Point(12, 3);
            var point74 = point1;
            tabControlArea2.Padding = point74;
            TabControlArea.SelectedIndex = 0;
            var tabControlArea3 = TabControlArea;
            size1 = new Size(488, 470);
            var size71 = size1;
            tabControlArea3.Size = size71;
            TabControlArea.TabIndex = 0;
            tabpagAreaBasic.Controls.Add(chkbUnescapable);
            tabpagAreaBasic.Controls.Add(Label19);
            tabpagAreaBasic.Controls.Add(cmbxCameraStyle);
            tabpagAreaBasic.Controls.Add(Label14);
            tabpagAreaBasic.Controls.Add(NumericUpDown10);
            tabpagAreaBasic.Controls.Add(Label15);
            tabpagAreaBasic.Controls.Add(NumericUpDown11);
            tabpagAreaBasic.Controls.Add(Label16);
            tabpagAreaBasic.Controls.Add(NumericUpDown12);
            tabpagAreaBasic.Controls.Add(btnSetAreaNameLang);
            tabpagAreaBasic.Controls.Add(tbAreaTag);
            tabpagAreaBasic.Controls.Add(tbAreaName);
            tabpagAreaBasic.Controls.Add(Label17);
            tabpagAreaBasic.Controls.Add(Label18);
            tabpagAreaBasic.Controls.Add(Label85);
            tabpagAreaBasic.Controls.Add(chkbDisableTransit);
            tabpagAreaBasic.Controls.Add(Label86);
            var tabpagAreaBasic1 = tabpagAreaBasic;
            point1 = new Point(4, 22);
            var point75 = point1;
            ((Control)tabpagAreaBasic1).Location = point75;
            tabpagAreaBasic.Name = "tabpagAreaBasic";
            var tabpagAreaBasic2 = tabpagAreaBasic;
            size1 = new Size(480, 444);
            var size72 = size1;
            tabpagAreaBasic2.Size = size72;
            tabpagAreaBasic.TabIndex = 1;
            tabpagAreaBasic.Text = "Basic";
            var chkbUnescapable1 = chkbUnescapable;
            point1 = new Point(112, 144);
            var point76 = point1;
            chkbUnescapable1.Location = point76;
            chkbUnescapable.Name = "chkbUnescapable";
            var chkbUnescapable2 = chkbUnescapable;
            size1 = new Size(32, 24);
            var size73 = size1;
            chkbUnescapable2.Size = size73;
            chkbUnescapable.TabIndex = 23;
            var label19_1 = Label19;
            point1 = new Point(16, 104);
            var point77 = point1;
            label19_1.Location = point77;
            Label19.Name = "Label19";
            var label19_2 = Label19;
            size1 = new Size(88, 16);
            var size74 = size1;
            label19_2.Size = size74;
            Label19.TabIndex = 22;
            Label19.Text = "Camera Style";
            Label19.TextAlign = ContentAlignment.MiddleLeft;
            cmbxCameraStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            var cmbxCameraStyle1 = cmbxCameraStyle;
            point1 = new Point(112, 104);
            var point78 = point1;
            cmbxCameraStyle1.Location = point78;
            cmbxCameraStyle.Name = "cmbxCameraStyle";
            var cmbxCameraStyle2 = cmbxCameraStyle;
            size1 = new Size(120, 21);
            var size75 = size1;
            cmbxCameraStyle2.Size = size75;
            cmbxCameraStyle.TabIndex = 21;
            Label14.BackColor = Color.Red;
            var label14_1 = Label14;
            point1 = new Point(88, 328);
            var point79 = point1;
            label14_1.Location = point79;
            Label14.Name = "Label14";
            var label14_2 = Label14;
            size1 = new Size(104, 16);
            var size76 = size1;
            label14_2.Size = size76;
            Label14.TabIndex = 19;
            Label14.Text = "Starting Position X";
            Label14.TextAlign = ContentAlignment.MiddleRight;
            Label14.Visible = false;
            NumericUpDown10.BackColor = Color.Red;
            NumericUpDown10.DecimalPlaces = 4;
            var numericUpDown10_1 = NumericUpDown10;
            point1 = new Point(208, 328);
            var point80 = point1;
            numericUpDown10_1.Location = point80;
            var numericUpDown10_2 = NumericUpDown10;
            num1 = new Decimal(new int[4] { 4000, 0, 0, 0 });
            var num23 = num1;
            numericUpDown10_2.Maximum = num23;
            var numericUpDown10_3 = NumericUpDown10;
            num1 = new Decimal(new int[4]
            {
                4000,
                0,
                0,
                int.MinValue
            });
            var num24 = num1;
            numericUpDown10_3.Minimum = num24;
            NumericUpDown10.Name = "NumericUpDown10";
            var numericUpDown10_4 = NumericUpDown10;
            size1 = new Size(96, 20);
            var size77 = size1;
            numericUpDown10_4.Size = size77;
            NumericUpDown10.TabIndex = 16;
            NumericUpDown10.TextAlign = HorizontalAlignment.Right;
            NumericUpDown10.Visible = false;
            Label15.BackColor = Color.Red;
            var label15_1 = Label15;
            point1 = new Point(88, 360);
            var point81 = point1;
            label15_1.Location = point81;
            Label15.Name = "Label15";
            var label15_2 = Label15;
            size1 = new Size(104, 16);
            var size78 = size1;
            label15_2.Size = size78;
            Label15.TabIndex = 20;
            Label15.Text = "Starting Position Y";
            Label15.TextAlign = ContentAlignment.MiddleRight;
            Label15.Visible = false;
            NumericUpDown11.BackColor = Color.Red;
            NumericUpDown11.DecimalPlaces = 4;
            var numericUpDown11_1 = NumericUpDown11;
            point1 = new Point(208, 360);
            var point82 = point1;
            numericUpDown11_1.Location = point82;
            var numericUpDown11_2 = NumericUpDown11;
            num1 = new Decimal(new int[4] { 4000, 0, 0, 0 });
            var num25 = num1;
            numericUpDown11_2.Maximum = num25;
            var numericUpDown11_3 = NumericUpDown11;
            num1 = new Decimal(new int[4]
            {
                4000,
                0,
                0,
                int.MinValue
            });
            var num26 = num1;
            numericUpDown11_3.Minimum = num26;
            NumericUpDown11.Name = "NumericUpDown11";
            var numericUpDown11_4 = NumericUpDown11;
            size1 = new Size(96, 20);
            var size79 = size1;
            numericUpDown11_4.Size = size79;
            NumericUpDown11.TabIndex = 15;
            NumericUpDown11.TextAlign = HorizontalAlignment.Right;
            NumericUpDown11.Visible = false;
            Label16.BackColor = Color.Red;
            var label16_1 = Label16;
            point1 = new Point(88, 392);
            var point83 = point1;
            label16_1.Location = point83;
            Label16.Name = "Label16";
            var label16_2 = Label16;
            size1 = new Size(104, 16);
            var size80 = size1;
            label16_2.Size = size80;
            Label16.TabIndex = 18;
            Label16.Text = "Starting Position Z";
            Label16.TextAlign = ContentAlignment.MiddleRight;
            Label16.Visible = false;
            NumericUpDown12.BackColor = Color.Red;
            NumericUpDown12.DecimalPlaces = 4;
            var numericUpDown12_1 = NumericUpDown12;
            point1 = new Point(208, 392);
            var point84 = point1;
            numericUpDown12_1.Location = point84;
            var numericUpDown12_2 = NumericUpDown12;
            num1 = new Decimal(new int[4] { 4000, 0, 0, 0 });
            var num27 = num1;
            numericUpDown12_2.Maximum = num27;
            var numericUpDown12_3 = NumericUpDown12;
            num1 = new Decimal(new int[4]
            {
                4000,
                0,
                0,
                int.MinValue
            });
            var num28 = num1;
            numericUpDown12_3.Minimum = num28;
            NumericUpDown12.Name = "NumericUpDown12";
            var numericUpDown12_4 = NumericUpDown12;
            size1 = new Size(96, 20);
            var size81 = size1;
            numericUpDown12_4.Size = size81;
            NumericUpDown12.TabIndex = 17;
            NumericUpDown12.TextAlign = HorizontalAlignment.Right;
            NumericUpDown12.Visible = false;
            var btnSetAreaNameLang1 = btnSetAreaNameLang;
            point1 = new Point(376, 40);
            var point85 = point1;
            btnSetAreaNameLang1.Location = point85;
            btnSetAreaNameLang.Name = "btnSetAreaNameLang";
            var btnSetAreaNameLang2 = btnSetAreaNameLang;
            size1 = new Size(88, 23);
            var size82 = size1;
            btnSetAreaNameLang2.Size = size82;
            btnSetAreaNameLang.TabIndex = 1;
            btnSetAreaNameLang.Text = "Set Language";
            var tbAreaTag1 = tbAreaTag;
            point1 = new Point(112, 64);
            var point86 = point1;
            tbAreaTag1.Location = point86;
            tbAreaTag.Name = "tbAreaTag";
            var tbAreaTag2 = tbAreaTag;
            size1 = new Size(104, 20);
            var size83 = size1;
            tbAreaTag2.Size = size83;
            tbAreaTag.TabIndex = 2;
            tbAreaTag.Text = "";
            var tbAreaName1 = tbAreaName;
            point1 = new Point(112, 40);
            var point87 = point1;
            tbAreaName1.Location = point87;
            tbAreaName.Name = "tbAreaName";
            var tbAreaName2 = tbAreaName;
            size1 = new Size(256, 20);
            var size84 = size1;
            tbAreaName2.Size = size84;
            tbAreaName.TabIndex = 0;
            tbAreaName.Text = "";
            var label17_1 = Label17;
            point1 = new Point(24, 40);
            var point88 = point1;
            label17_1.Location = point88;
            Label17.Name = "Label17";
            var label17_2 = Label17;
            size1 = new Size(48, 16);
            var size85 = size1;
            label17_2.Size = size85;
            Label17.TabIndex = 10;
            Label17.Text = "Name";
            Label17.TextAlign = ContentAlignment.MiddleLeft;
            var label18_1 = Label18;
            point1 = new Point(24, 64);
            var point89 = point1;
            label18_1.Location = point89;
            Label18.Name = "Label18";
            var label18_2 = Label18;
            size1 = new Size(48, 16);
            var size86 = size1;
            label18_2.Size = size86;
            Label18.TabIndex = 11;
            Label18.Text = "Tag";
            Label18.TextAlign = ContentAlignment.MiddleLeft;
            var label85_1 = Label85;
            point1 = new Point(16, 148);
            var point90 = point1;
            label85_1.Location = point90;
            Label85.Name = "Label85";
            var label85_2 = Label85;
            size1 = new Size(88, 16);
            var size87 = size1;
            label85_2.Size = size87;
            Label85.TabIndex = 22;
            Label85.Text = "Unescapable";
            Label85.TextAlign = ContentAlignment.MiddleLeft;
            var chkbDisableTransit1 = chkbDisableTransit;
            point1 = new Point(112, 176);
            var point91 = point1;
            chkbDisableTransit1.Location = point91;
            chkbDisableTransit.Name = "chkbDisableTransit";
            var chkbDisableTransit2 = chkbDisableTransit;
            size1 = new Size(32, 24);
            var size88 = size1;
            chkbDisableTransit2.Size = size88;
            chkbDisableTransit.TabIndex = 23;
            var label86_1 = Label86;
            point1 = new Point(16, 180);
            var point92 = point1;
            label86_1.Location = point92;
            Label86.Name = "Label86";
            var label86_2 = Label86;
            size1 = new Size(88, 16);
            var size89 = size1;
            label86_2.Size = size89;
            Label86.TabIndex = 22;
            Label86.Text = "Disable Transit";
            Label86.TextAlign = ContentAlignment.MiddleLeft;
            tabpagAreaEnvironment.Controls.Add(cmbxWindPower);
            tabpagAreaEnvironment.Controls.Add(GroupBox1);
            tabpagAreaEnvironment.Controls.Add(rbDayNightCycle);
            tabpagAreaEnvironment.Controls.Add(gbMoon);
            tabpagAreaEnvironment.Controls.Add(gbSun);
            tabpagAreaEnvironment.Controls.Add(rbAlwaysDay);
            tabpagAreaEnvironment.Controls.Add(rbAlwaysNight);
            tabpagAreaEnvironment.Controls.Add(btnDynAmbientColor);
            tabpagAreaEnvironment.Controls.Add(Label48);
            tabpagAreaEnvironment.Controls.Add(Label73);
            tabpagAreaEnvironment.Controls.Add(nudShadowOpacity);
            tabpagAreaEnvironment.Controls.Add(Label84);
            var tabpagAreaEnvironment1 = tabpagAreaEnvironment;
            point1 = new Point(4, 22);
            var point93 = point1;
            ((Control)tabpagAreaEnvironment1).Location = point93;
            tabpagAreaEnvironment.Name = "tabpagAreaEnvironment";
            var tabpagAreaEnvironment2 = tabpagAreaEnvironment;
            size1 = new Size(480, 444);
            var size90 = size1;
            tabpagAreaEnvironment2.Size = size90;
            tabpagAreaEnvironment.TabIndex = 4;
            tabpagAreaEnvironment.Text = "Environment";
            cmbxWindPower.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxWindPower.Items.AddRange(new object[3]
            {
                "Calm",
                "Light",
                "Heavy"
            });
            var cmbxWindPower1 = cmbxWindPower;
            point1 = new Point(328, 358);
            var point94 = point1;
            cmbxWindPower1.Location = point94;
            cmbxWindPower.Name = "cmbxWindPower";
            var cmbxWindPower2 = cmbxWindPower;
            size1 = new Size(112, 21);
            var size91 = size1;
            cmbxWindPower2.Size = size91;
            cmbxWindPower.TabIndex = 26;
            GroupBox1.Controls.Add(Label49);
            GroupBox1.Controls.Add(nudChanceSnow);
            GroupBox1.Controls.Add(Label50);
            GroupBox1.Controls.Add(nudChanceRain);
            GroupBox1.Controls.Add(Label51);
            GroupBox1.Controls.Add(nudChanceLightning);
            var groupBox1_1 = GroupBox1;
            point1 = new Point(16, 344);
            var point95 = point1;
            groupBox1_1.Location = point95;
            GroupBox1.Name = "GroupBox1";
            var groupBox1_2 = GroupBox1;
            size1 = new Size(200, 88);
            var size92 = size1;
            groupBox1_2.Size = size92;
            GroupBox1.TabIndex = 25;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Weather";
            var label49_1 = Label49;
            point1 = new Point(8, 16);
            var point96 = point1;
            label49_1.Location = point96;
            Label49.Name = "Label49";
            var label49_2 = Label49;
            size1 = new Size(88, 16);
            var size93 = size1;
            label49_2.Size = size93;
            Label49.TabIndex = 24;
            Label49.Text = "% Chance Snow";
            Label49.TextAlign = ContentAlignment.MiddleLeft;
            var nudChanceSnow1 = nudChanceSnow;
            point1 = new Point(128, 16);
            var point97 = point1;
            nudChanceSnow1.Location = point97;
            nudChanceSnow.Name = "nudChanceSnow";
            var nudChanceSnow2 = nudChanceSnow;
            size1 = new Size(56, 20);
            var size94 = size1;
            nudChanceSnow2.Size = size94;
            nudChanceSnow.TabIndex = 0;
            nudChanceSnow.TextAlign = HorizontalAlignment.Right;
            var label50_1 = Label50;
            point1 = new Point(8, 40);
            var point98 = point1;
            label50_1.Location = point98;
            Label50.Name = "Label50";
            var label50_2 = Label50;
            size1 = new Size(88, 16);
            var size95 = size1;
            label50_2.Size = size95;
            Label50.TabIndex = 24;
            Label50.Text = "% Chance Rain";
            Label50.TextAlign = ContentAlignment.MiddleLeft;
            var nudChanceRain1 = nudChanceRain;
            point1 = new Point(128, 40);
            var point99 = point1;
            nudChanceRain1.Location = point99;
            nudChanceRain.Name = "nudChanceRain";
            var nudChanceRain2 = nudChanceRain;
            size1 = new Size(56, 20);
            var size96 = size1;
            nudChanceRain2.Size = size96;
            nudChanceRain.TabIndex = 1;
            nudChanceRain.TextAlign = HorizontalAlignment.Right;
            var label51_1 = Label51;
            point1 = new Point(8, 64);
            var point100 = point1;
            label51_1.Location = point100;
            Label51.Name = "Label51";
            var label51_2 = Label51;
            size1 = new Size(120, 16);
            var size97 = size1;
            label51_2.Size = size97;
            Label51.TabIndex = 24;
            Label51.Text = "% Chance Lightning";
            Label51.TextAlign = ContentAlignment.MiddleLeft;
            var nudChanceLightning1 = nudChanceLightning;
            point1 = new Point(128, 64);
            var point101 = point1;
            nudChanceLightning1.Location = point101;
            nudChanceLightning.Name = "nudChanceLightning";
            var nudChanceLightning2 = nudChanceLightning;
            size1 = new Size(56, 20);
            var size98 = size1;
            nudChanceLightning2.Size = size98;
            nudChanceLightning.TabIndex = 2;
            nudChanceLightning.TextAlign = HorizontalAlignment.Right;
            rbDayNightCycle.Checked = true;
            var rbDayNightCycle1 = rbDayNightCycle;
            point1 = new Point(40, 8);
            var point102 = point1;
            rbDayNightCycle1.Location = point102;
            rbDayNightCycle.Name = "rbDayNightCycle";
            var rbDayNightCycle2 = rbDayNightCycle;
            size1 = new Size(152, 16);
            var size99 = size1;
            rbDayNightCycle2.Size = size99;
            rbDayNightCycle.TabIndex = 0;
            rbDayNightCycle.TabStop = true;
            rbDayNightCycle.Text = "Cycle Day and Night";
            gbMoon.Controls.Add(btnMoonDiffuseColor);
            gbMoon.Controls.Add(Label24);
            gbMoon.Controls.Add(Label25);
            gbMoon.Controls.Add(btnMoonAmbientColor);
            gbMoon.Controls.Add(Label31);
            gbMoon.Controls.Add(Label45);
            gbMoon.Controls.Add(btnMoonFogColor);
            gbMoon.Controls.Add(chkbAreaMoonShadows);
            gbMoon.Controls.Add(Label47);
            gbMoon.Controls.Add(chkbMoonFogOn);
            gbMoon.Controls.Add(trkbarMoonFogNear);
            gbMoon.Controls.Add(lblMoonFogNear);
            gbMoon.Controls.Add(trkbarMoonFogFar);
            gbMoon.Controls.Add(lblMoonFogFar);
            var gbMoon1 = gbMoon;
            point1 = new Point(16, 200);
            var point103 = point1;
            gbMoon1.Location = point103;
            gbMoon.Name = "gbMoon";
            var gbMoon2 = gbMoon;
            size1 = new Size(448, 136);
            var size100 = size1;
            gbMoon2.Size = size100;
            gbMoon.TabIndex = 21;
            gbMoon.TabStop = false;
            gbMoon.Text = "Moon";
            btnMoonDiffuseColor.FlatStyle = FlatStyle.Flat;
            var moonDiffuseColor1 = btnMoonDiffuseColor;
            point1 = new Point(112, 40);
            var point104 = point1;
            moonDiffuseColor1.Location = point104;
            btnMoonDiffuseColor.Name = "btnMoonDiffuseColor";
            var moonDiffuseColor2 = btnMoonDiffuseColor;
            size1 = new Size(16, 16);
            var size101 = size1;
            moonDiffuseColor2.Size = size101;
            btnMoonDiffuseColor.TabIndex = 1;
            var label24_1 = Label24;
            point1 = new Point(16, 16);
            var point105 = point1;
            label24_1.Location = point105;
            Label24.Name = "Label24";
            var label24_2 = Label24;
            size1 = new Size(88, 16);
            var size102 = size1;
            label24_2.Size = size102;
            Label24.TabIndex = 21;
            Label24.Text = "Ambient Color";
            Label24.TextAlign = ContentAlignment.MiddleLeft;
            var label25_1 = Label25;
            point1 = new Point(16, 40);
            var point106 = point1;
            label25_1.Location = point106;
            Label25.Name = "Label25";
            var label25_2 = Label25;
            size1 = new Size(88, 16);
            var size103 = size1;
            label25_2.Size = size103;
            Label25.TabIndex = 20;
            Label25.Text = "Diffuse Color";
            Label25.TextAlign = ContentAlignment.MiddleLeft;
            btnMoonAmbientColor.FlatStyle = FlatStyle.Flat;
            var moonAmbientColor1 = btnMoonAmbientColor;
            point1 = new Point(112, 16);
            var point107 = point1;
            moonAmbientColor1.Location = point107;
            btnMoonAmbientColor.Name = "btnMoonAmbientColor";
            var moonAmbientColor2 = btnMoonAmbientColor;
            size1 = new Size(16, 16);
            var size104 = size1;
            moonAmbientColor2.Size = size104;
            btnMoonAmbientColor.TabIndex = 0;
            var label31_1 = Label31;
            point1 = new Point(16, 112);
            var point108 = point1;
            label31_1.Location = point108;
            Label31.Name = "Label31";
            var label31_2 = Label31;
            size1 = new Size(88, 16);
            var size105 = size1;
            label31_2.Size = size105;
            Label31.TabIndex = 16;
            Label31.Text = "Shadows";
            Label31.TextAlign = ContentAlignment.MiddleLeft;
            var label45_1 = Label45;
            point1 = new Point(16, 88);
            var point109 = point1;
            label45_1.Location = point109;
            Label45.Name = "Label45";
            var label45_2 = Label45;
            size1 = new Size(88, 16);
            var size106 = size1;
            label45_2.Size = size106;
            Label45.TabIndex = 16;
            Label45.Text = "Fog Color";
            Label45.TextAlign = ContentAlignment.MiddleLeft;
            btnMoonFogColor.FlatStyle = FlatStyle.Flat;
            var btnMoonFogColor1 = btnMoonFogColor;
            point1 = new Point(112, 88);
            var point110 = point1;
            btnMoonFogColor1.Location = point110;
            btnMoonFogColor.Name = "btnMoonFogColor";
            var btnMoonFogColor2 = btnMoonFogColor;
            size1 = new Size(16, 16);
            var size107 = size1;
            btnMoonFogColor2.Size = size107;
            btnMoonFogColor.TabIndex = 3;
            var chkbAreaMoonShadows1 = chkbAreaMoonShadows;
            point1 = new Point(112, 112);
            var point111 = point1;
            chkbAreaMoonShadows1.Location = point111;
            chkbAreaMoonShadows.Name = "chkbAreaMoonShadows";
            var chkbAreaMoonShadows2 = chkbAreaMoonShadows;
            size1 = new Size(32, 16);
            var size108 = size1;
            chkbAreaMoonShadows2.Size = size108;
            chkbAreaMoonShadows.TabIndex = 4;
            var label47_1 = Label47;
            point1 = new Point(16, 64);
            var point112 = point1;
            label47_1.Location = point112;
            Label47.Name = "Label47";
            var label47_2 = Label47;
            size1 = new Size(88, 16);
            var size109 = size1;
            label47_2.Size = size109;
            Label47.TabIndex = 16;
            Label47.Text = "Fog Enabled";
            Label47.TextAlign = ContentAlignment.MiddleLeft;
            var chkbMoonFogOn1 = chkbMoonFogOn;
            point1 = new Point(112, 64);
            var point113 = point1;
            chkbMoonFogOn1.Location = point113;
            chkbMoonFogOn.Name = "chkbMoonFogOn";
            var chkbMoonFogOn2 = chkbMoonFogOn;
            size1 = new Size(32, 16);
            var size110 = size1;
            chkbMoonFogOn2.Size = size110;
            chkbMoonFogOn.TabIndex = 2;
            trkbarMoonFogNear.Enabled = false;
            var trkbarMoonFogNear1 = trkbarMoonFogNear;
            point1 = new Point(232, 24);
            var point114 = point1;
            trkbarMoonFogNear1.Location = point114;
            trkbarMoonFogNear.Maximum = 2000;
            trkbarMoonFogNear.Name = "trkbarMoonFogNear";
            var trkbarMoonFogNear2 = trkbarMoonFogNear;
            size1 = new Size(200, 42);
            var size111 = size1;
            trkbarMoonFogNear2.Size = size111;
            trkbarMoonFogNear.TabIndex = 5;
            trkbarMoonFogNear.TickFrequency = 50;
            trkbarMoonFogNear.TickStyle = TickStyle.TopLeft;
            lblMoonFogNear.Enabled = false;
            var lblMoonFogNear1 = lblMoonFogNear;
            point1 = new Point(160, 32);
            var point115 = point1;
            lblMoonFogNear1.Location = point115;
            lblMoonFogNear.Name = "lblMoonFogNear";
            var lblMoonFogNear2 = lblMoonFogNear;
            size1 = new Size(64, 16);
            var size112 = size1;
            lblMoonFogNear2.Size = size112;
            lblMoonFogNear.TabIndex = 16;
            lblMoonFogNear.Text = "Fog Near";
            lblMoonFogNear.TextAlign = ContentAlignment.MiddleLeft;
            trkbarMoonFogFar.Enabled = false;
            var trkbarMoonFogFar1 = trkbarMoonFogFar;
            point1 = new Point(232, 88);
            var point116 = point1;
            trkbarMoonFogFar1.Location = point116;
            trkbarMoonFogFar.Maximum = 2000;
            trkbarMoonFogFar.Name = "trkbarMoonFogFar";
            var trkbarMoonFogFar2 = trkbarMoonFogFar;
            size1 = new Size(200, 42);
            var size113 = size1;
            trkbarMoonFogFar2.Size = size113;
            trkbarMoonFogFar.TabIndex = 6;
            trkbarMoonFogFar.TickFrequency = 50;
            trkbarMoonFogFar.TickStyle = TickStyle.TopLeft;
            lblMoonFogFar.Enabled = false;
            var lblMoonFogFar1 = lblMoonFogFar;
            point1 = new Point(160, 88);
            var point117 = point1;
            lblMoonFogFar1.Location = point117;
            lblMoonFogFar.Name = "lblMoonFogFar";
            var lblMoonFogFar2 = lblMoonFogFar;
            size1 = new Size(64, 16);
            var size114 = size1;
            lblMoonFogFar2.Size = size114;
            lblMoonFogFar.TabIndex = 16;
            lblMoonFogFar.Text = "Fog Far";
            lblMoonFogFar.TextAlign = ContentAlignment.MiddleLeft;
            gbSun.Controls.Add(chkbAreaSunShadows);
            gbSun.Controls.Add(trkbarSunFogNear);
            gbSun.Controls.Add(Label27);
            gbSun.Controls.Add(btnSunAmbientColor);
            gbSun.Controls.Add(Label26);
            gbSun.Controls.Add(btnSunDiffuseColor);
            gbSun.Controls.Add(Label28);
            gbSun.Controls.Add(btnSunFogColor);
            gbSun.Controls.Add(Label29);
            gbSun.Controls.Add(Label30);
            gbSun.Controls.Add(trkbarSunFogFar);
            gbSun.Controls.Add(lblSunFogNear);
            gbSun.Controls.Add(lblSunFogFar);
            gbSun.Controls.Add(chkbSunFogOn);
            var gbSun1 = gbSun;
            point1 = new Point(16, 56);
            var point118 = point1;
            gbSun1.Location = point118;
            gbSun.Name = "gbSun";
            var gbSun2 = gbSun;
            size1 = new Size(448, 136);
            var size115 = size1;
            gbSun2.Size = size115;
            gbSun.TabIndex = 20;
            gbSun.TabStop = false;
            gbSun.Text = "Sun";
            var chkbAreaSunShadows1 = chkbAreaSunShadows;
            point1 = new Point(112, 112);
            var point119 = point1;
            chkbAreaSunShadows1.Location = point119;
            chkbAreaSunShadows.Name = "chkbAreaSunShadows";
            var chkbAreaSunShadows2 = chkbAreaSunShadows;
            size1 = new Size(32, 16);
            var size116 = size1;
            chkbAreaSunShadows2.Size = size116;
            chkbAreaSunShadows.TabIndex = 4;
            trkbarSunFogNear.Enabled = false;
            var trkbarSunFogNear1 = trkbarSunFogNear;
            point1 = new Point(232, 24);
            var point120 = point1;
            trkbarSunFogNear1.Location = point120;
            trkbarSunFogNear.Maximum = 2000;
            trkbarSunFogNear.Name = "trkbarSunFogNear";
            var trkbarSunFogNear2 = trkbarSunFogNear;
            size1 = new Size(200, 42);
            var size117 = size1;
            trkbarSunFogNear2.Size = size117;
            trkbarSunFogNear.TabIndex = 5;
            trkbarSunFogNear.TickFrequency = 50;
            trkbarSunFogNear.TickStyle = TickStyle.TopLeft;
            var label27_1 = Label27;
            point1 = new Point(16, 40);
            var point121 = point1;
            label27_1.Location = point121;
            Label27.Name = "Label27";
            var label27_2 = Label27;
            size1 = new Size(88, 16);
            var size118 = size1;
            label27_2.Size = size118;
            Label27.TabIndex = 16;
            Label27.Text = "Diffuse Color";
            Label27.TextAlign = ContentAlignment.MiddleLeft;
            btnSunAmbientColor.FlatStyle = FlatStyle.Flat;
            var btnSunAmbientColor1 = btnSunAmbientColor;
            point1 = new Point(112, 16);
            var point122 = point1;
            btnSunAmbientColor1.Location = point122;
            btnSunAmbientColor.Name = "btnSunAmbientColor";
            var btnSunAmbientColor2 = btnSunAmbientColor;
            size1 = new Size(16, 16);
            var size119 = size1;
            btnSunAmbientColor2.Size = size119;
            btnSunAmbientColor.TabIndex = 0;
            var label26_1 = Label26;
            point1 = new Point(16, 16);
            var point123 = point1;
            label26_1.Location = point123;
            Label26.Name = "Label26";
            var label26_2 = Label26;
            size1 = new Size(88, 16);
            var size120 = size1;
            label26_2.Size = size120;
            Label26.TabIndex = 17;
            Label26.Text = "Ambient Color";
            Label26.TextAlign = ContentAlignment.MiddleLeft;
            btnSunDiffuseColor.FlatStyle = FlatStyle.Flat;
            var btnSunDiffuseColor1 = btnSunDiffuseColor;
            point1 = new Point(112, 40);
            var point124 = point1;
            btnSunDiffuseColor1.Location = point124;
            btnSunDiffuseColor.Name = "btnSunDiffuseColor";
            var btnSunDiffuseColor2 = btnSunDiffuseColor;
            size1 = new Size(16, 16);
            var size121 = size1;
            btnSunDiffuseColor2.Size = size121;
            btnSunDiffuseColor.TabIndex = 1;
            var label28_1 = Label28;
            point1 = new Point(16, 88);
            var point125 = point1;
            label28_1.Location = point125;
            Label28.Name = "Label28";
            var label28_2 = Label28;
            size1 = new Size(88, 16);
            var size122 = size1;
            label28_2.Size = size122;
            Label28.TabIndex = 16;
            Label28.Text = "Fog Color";
            Label28.TextAlign = ContentAlignment.MiddleLeft;
            btnSunFogColor.FlatStyle = FlatStyle.Flat;
            var btnSunFogColor1 = btnSunFogColor;
            point1 = new Point(112, 88);
            var point126 = point1;
            btnSunFogColor1.Location = point126;
            btnSunFogColor.Name = "btnSunFogColor";
            var btnSunFogColor2 = btnSunFogColor;
            size1 = new Size(16, 16);
            var size123 = size1;
            btnSunFogColor2.Size = size123;
            btnSunFogColor.TabIndex = 3;
            var label29_1 = Label29;
            point1 = new Point(16, 64);
            var point127 = point1;
            label29_1.Location = point127;
            Label29.Name = "Label29";
            var label29_2 = Label29;
            size1 = new Size(88, 16);
            var size124 = size1;
            label29_2.Size = size124;
            Label29.TabIndex = 16;
            Label29.Text = "Fog Enabled";
            Label29.TextAlign = ContentAlignment.MiddleLeft;
            var label30_1 = Label30;
            point1 = new Point(16, 112);
            var point128 = point1;
            label30_1.Location = point128;
            Label30.Name = "Label30";
            var label30_2 = Label30;
            size1 = new Size(88, 16);
            var size125 = size1;
            label30_2.Size = size125;
            Label30.TabIndex = 16;
            Label30.Text = "Shadows";
            Label30.TextAlign = ContentAlignment.MiddleLeft;
            trkbarSunFogFar.Enabled = false;
            var trkbarSunFogFar1 = trkbarSunFogFar;
            point1 = new Point(232, 80);
            var point129 = point1;
            trkbarSunFogFar1.Location = point129;
            trkbarSunFogFar.Maximum = 2000;
            trkbarSunFogFar.Name = "trkbarSunFogFar";
            var trkbarSunFogFar2 = trkbarSunFogFar;
            size1 = new Size(200, 42);
            var size126 = size1;
            trkbarSunFogFar2.Size = size126;
            trkbarSunFogFar.TabIndex = 6;
            trkbarSunFogFar.TickFrequency = 50;
            trkbarSunFogFar.TickStyle = TickStyle.TopLeft;
            lblSunFogNear.Enabled = false;
            var lblSunFogNear1 = lblSunFogNear;
            point1 = new Point(160, 32);
            var point130 = point1;
            lblSunFogNear1.Location = point130;
            lblSunFogNear.Name = "lblSunFogNear";
            var lblSunFogNear2 = lblSunFogNear;
            size1 = new Size(64, 16);
            var size127 = size1;
            lblSunFogNear2.Size = size127;
            lblSunFogNear.TabIndex = 16;
            lblSunFogNear.Text = "Fog Near";
            lblSunFogNear.TextAlign = ContentAlignment.MiddleLeft;
            lblSunFogFar.Enabled = false;
            var lblSunFogFar1 = lblSunFogFar;
            point1 = new Point(160, 88);
            var point131 = point1;
            lblSunFogFar1.Location = point131;
            lblSunFogFar.Name = "lblSunFogFar";
            var lblSunFogFar2 = lblSunFogFar;
            size1 = new Size(64, 16);
            var size128 = size1;
            lblSunFogFar2.Size = size128;
            lblSunFogFar.TabIndex = 16;
            lblSunFogFar.Text = "Fog Far";
            lblSunFogFar.TextAlign = ContentAlignment.MiddleLeft;
            var chkbSunFogOn1 = chkbSunFogOn;
            point1 = new Point(112, 64);
            var point132 = point1;
            chkbSunFogOn1.Location = point132;
            chkbSunFogOn.Name = "chkbSunFogOn";
            var chkbSunFogOn2 = chkbSunFogOn;
            size1 = new Size(32, 16);
            var size129 = size1;
            chkbSunFogOn2.Size = size129;
            chkbSunFogOn.TabIndex = 2;
            var rbAlwaysDay1 = rbAlwaysDay;
            point1 = new Point(40, 24);
            var point133 = point1;
            rbAlwaysDay1.Location = point133;
            rbAlwaysDay.Name = "rbAlwaysDay";
            var rbAlwaysDay2 = rbAlwaysDay;
            size1 = new Size(104, 16);
            var size130 = size1;
            rbAlwaysDay2.Size = size130;
            rbAlwaysDay.TabIndex = 1;
            rbAlwaysDay.Text = "Always Day";
            var rbAlwaysNight1 = rbAlwaysNight;
            point1 = new Point(40, 40);
            var point134 = point1;
            rbAlwaysNight1.Location = point134;
            rbAlwaysNight.Name = "rbAlwaysNight";
            var rbAlwaysNight2 = rbAlwaysNight;
            size1 = new Size(104, 16);
            var size131 = size1;
            rbAlwaysNight2.Size = size131;
            rbAlwaysNight.TabIndex = 2;
            rbAlwaysNight.Text = "Always Night";
            btnDynAmbientColor.FlatStyle = FlatStyle.Flat;
            var btnDynAmbientColor1 = btnDynAmbientColor;
            point1 = new Point(376, 10);
            var point135 = point1;
            btnDynAmbientColor1.Location = point135;
            btnDynAmbientColor.Name = "btnDynAmbientColor";
            var btnDynAmbientColor2 = btnDynAmbientColor;
            size1 = new Size(16, 16);
            var size132 = size1;
            btnDynAmbientColor2.Size = size132;
            btnDynAmbientColor.TabIndex = 3;
            var label48_1 = Label48;
            point1 = new Point(232, 10);
            var point136 = point1;
            label48_1.Location = point136;
            Label48.Name = "Label48";
            var label48_2 = Label48;
            size1 = new Size(136, 16);
            var size133 = size1;
            label48_2.Size = size133;
            Label48.TabIndex = 17;
            Label48.Text = "Dynamic Ambient Color";
            Label48.TextAlign = ContentAlignment.MiddleLeft;
            var label73_1 = Label73;
            point1 = new Point(232, 32);
            var point137 = point1;
            label73_1.Location = point137;
            Label73.Name = "Label73";
            var label73_2 = Label73;
            size1 = new Size(88, 16);
            var size134 = size1;
            label73_2.Size = size134;
            Label73.TabIndex = 24;
            Label73.Text = "Shadow Opacity";
            Label73.TextAlign = ContentAlignment.MiddleLeft;
            var nudShadowOpacity1 = nudShadowOpacity;
            point1 = new Point(352, 32);
            var point138 = point1;
            nudShadowOpacity1.Location = point138;
            var nudShadowOpacity2 = nudShadowOpacity;
            num1 = new Decimal(new int[4]
            {
                byte.MaxValue,
                0,
                0,
                0
            });
            var num29 = num1;
            nudShadowOpacity2.Maximum = num29;
            nudShadowOpacity.Name = "nudShadowOpacity";
            var nudShadowOpacity3 = nudShadowOpacity;
            size1 = new Size(48, 20);
            var size135 = size1;
            nudShadowOpacity3.Size = size135;
            nudShadowOpacity.TabIndex = 0;
            nudShadowOpacity.TextAlign = HorizontalAlignment.Right;
            Label84.Enabled = false;
            var label84_1 = Label84;
            point1 = new Point(248, 360);
            var point139 = point1;
            label84_1.Location = point139;
            Label84.Name = "Label84";
            var label84_2 = Label84;
            size1 = new Size(80, 16);
            var size136 = size1;
            label84_2.Size = size136;
            Label84.TabIndex = 16;
            Label84.Text = "Wind Strength";
            Label84.TextAlign = ContentAlignment.MiddleLeft;
            tabpagAreaGrass.Controls.Add(nudGrassDensity);
            tabpagAreaGrass.Controls.Add(trkbarGrassDensityX10);
            tabpagAreaGrass.Controls.Add(Label62);
            tabpagAreaGrass.Controls.Add(btnGrassDiffuseColor);
            tabpagAreaGrass.Controls.Add(tbGrass_TexName);
            tabpagAreaGrass.Controls.Add(Label20);
            tabpagAreaGrass.Controls.Add(Label21);
            tabpagAreaGrass.Controls.Add(Label22);
            tabpagAreaGrass.Controls.Add(btnGrassAmbientColor);
            tabpagAreaGrass.Controls.Add(Label23);
            tabpagAreaGrass.Controls.Add(btnGrassEmissiveColor);
            tabpagAreaGrass.Controls.Add(nudGrassProbUL);
            tabpagAreaGrass.Controls.Add(nudGrassProbLL);
            tabpagAreaGrass.Controls.Add(nudGrassProbUR);
            tabpagAreaGrass.Controls.Add(nudGrassProbLR);
            tabpagAreaGrass.Controls.Add(Label63);
            tabpagAreaGrass.Controls.Add(Label64);
            tabpagAreaGrass.Controls.Add(Label65);
            tabpagAreaGrass.Controls.Add(Label66);
            tabpagAreaGrass.Controls.Add(Label67);
            tabpagAreaGrass.Controls.Add(lblTotalGrassProbability);
            tabpagAreaGrass.Controls.Add(Label69);
            tabpagAreaGrass.Controls.Add(Label70);
            tabpagAreaGrass.Controls.Add(Label71);
            tabpagAreaGrass.Controls.Add(Label72);
            tabpagAreaGrass.Controls.Add(Label68);
            tabpagAreaGrass.Controls.Add(nudGrassQuadSize);
            var tabpagAreaGrass1 = tabpagAreaGrass;
            point1 = new Point(4, 22);
            var point140 = point1;
            ((Control)tabpagAreaGrass1).Location = point140;
            tabpagAreaGrass.Name = "tabpagAreaGrass";
            var tabpagAreaGrass2 = tabpagAreaGrass;
            size1 = new Size(480, 444);
            var size137 = size1;
            tabpagAreaGrass2.Size = size137;
            tabpagAreaGrass.TabIndex = 2;
            tabpagAreaGrass.Text = "Grass";
            nudGrassDensity.DecimalPlaces = 2;
            var nudGrassDensity1 = nudGrassDensity;
            point1 = new Point(320, 320);
            var point141 = point1;
            nudGrassDensity1.Location = point141;
            var nudGrassDensity2 = nudGrassDensity;
            num1 = new Decimal(new int[4] { 50, 0, 0, 0 });
            var num30 = num1;
            nudGrassDensity2.Maximum = num30;
            nudGrassDensity.Name = "nudGrassDensity";
            var nudGrassDensity3 = nudGrassDensity;
            size1 = new Size(56, 20);
            var size138 = size1;
            nudGrassDensity3.Size = size138;
            nudGrassDensity.TabIndex = 19;
            nudGrassDensity.TextAlign = HorizontalAlignment.Right;
            var trkbarGrassDensityX10_1 = trkbarGrassDensityX10;
            point1 = new Point(112, 312);
            var point142 = point1;
            trkbarGrassDensityX10_1.Location = point142;
            trkbarGrassDensityX10.Maximum = 500;
            trkbarGrassDensityX10.Name = "trkbarGrassDensityX10";
            var trkbarGrassDensityX10_2 = trkbarGrassDensityX10;
            size1 = new Size(200, 42);
            var size139 = size1;
            trkbarGrassDensityX10_2.Size = size139;
            trkbarGrassDensityX10.TabIndex = 17;
            trkbarGrassDensityX10.TickFrequency = 10;
            var label62_1 = Label62;
            point1 = new Point(24, 320);
            var point143 = point1;
            label62_1.Location = point143;
            Label62.Name = "Label62";
            var label62_2 = Label62;
            size1 = new Size(80, 16);
            var size140 = size1;
            label62_2.Size = size140;
            Label62.TabIndex = 18;
            Label62.Text = "Grass Density";
            Label62.TextAlign = ContentAlignment.MiddleLeft;
            btnGrassDiffuseColor.FlatStyle = FlatStyle.Flat;
            var grassDiffuseColor1 = btnGrassDiffuseColor;
            point1 = new Point(120, 104);
            var point144 = point1;
            grassDiffuseColor1.Location = point144;
            btnGrassDiffuseColor.Name = "btnGrassDiffuseColor";
            var grassDiffuseColor2 = btnGrassDiffuseColor;
            size1 = new Size(16, 16);
            var size141 = size1;
            grassDiffuseColor2.Size = size141;
            btnGrassDiffuseColor.TabIndex = 15;
            var tbGrassTexName1 = tbGrass_TexName;
            point1 = new Point(120, 40);
            var point145 = point1;
            tbGrassTexName1.Location = point145;
            tbGrass_TexName.MaxLength = 16;
            tbGrass_TexName.Name = "tbGrass_TexName";
            var tbGrassTexName2 = tbGrass_TexName;
            size1 = new Size(176, 20);
            var size142 = size1;
            tbGrassTexName2.Size = size142;
            tbGrass_TexName.TabIndex = 14;
            tbGrass_TexName.Text = "";
            var label20_1 = Label20;
            point1 = new Point(24, 40);
            var point146 = point1;
            label20_1.Location = point146;
            Label20.Name = "Label20";
            var label20_2 = Label20;
            size1 = new Size(88, 16);
            var size143 = size1;
            label20_2.Size = size143;
            Label20.TabIndex = 13;
            Label20.Text = "Texture Name";
            Label20.TextAlign = ContentAlignment.MiddleLeft;
            var label21_1 = Label21;
            point1 = new Point(24, 80);
            var point147 = point1;
            label21_1.Location = point147;
            Label21.Name = "Label21";
            var label21_2 = Label21;
            size1 = new Size(88, 16);
            var size144 = size1;
            label21_2.Size = size144;
            Label21.TabIndex = 13;
            Label21.Text = "Ambient Color";
            Label21.TextAlign = ContentAlignment.MiddleLeft;
            var label22_1 = Label22;
            point1 = new Point(24, 104);
            var point148 = point1;
            label22_1.Location = point148;
            Label22.Name = "Label22";
            var label22_2 = Label22;
            size1 = new Size(88, 16);
            var size145 = size1;
            label22_2.Size = size145;
            Label22.TabIndex = 13;
            Label22.Text = "Diffuse Color";
            Label22.TextAlign = ContentAlignment.MiddleLeft;
            btnGrassAmbientColor.FlatStyle = FlatStyle.Flat;
            var grassAmbientColor1 = btnGrassAmbientColor;
            point1 = new Point(120, 80);
            var point149 = point1;
            grassAmbientColor1.Location = point149;
            btnGrassAmbientColor.Name = "btnGrassAmbientColor";
            var grassAmbientColor2 = btnGrassAmbientColor;
            size1 = new Size(16, 16);
            var size146 = size1;
            grassAmbientColor2.Size = size146;
            btnGrassAmbientColor.TabIndex = 15;
            var label23_1 = Label23;
            point1 = new Point(24, 128);
            var point150 = point1;
            label23_1.Location = point150;
            Label23.Name = "Label23";
            var label23_2 = Label23;
            size1 = new Size(88, 16);
            var size147 = size1;
            label23_2.Size = size147;
            Label23.TabIndex = 13;
            Label23.Text = "Emissive Color";
            Label23.TextAlign = ContentAlignment.MiddleLeft;
            btnGrassEmissiveColor.FlatStyle = FlatStyle.Flat;
            var grassEmissiveColor1 = btnGrassEmissiveColor;
            point1 = new Point(120, 128);
            var point151 = point1;
            grassEmissiveColor1.Location = point151;
            btnGrassEmissiveColor.Name = "btnGrassEmissiveColor";
            var grassEmissiveColor2 = btnGrassEmissiveColor;
            size1 = new Size(16, 16);
            var size148 = size1;
            grassEmissiveColor2.Size = size148;
            btnGrassEmissiveColor.TabIndex = 15;
            var nudGrassProbUl1 = nudGrassProbUL;
            point1 = new Point(160, 216);
            var point152 = point1;
            nudGrassProbUl1.Location = point152;
            nudGrassProbUL.Name = "nudGrassProbUL";
            var nudGrassProbUl2 = nudGrassProbUL;
            size1 = new Size(40, 20);
            var size149 = size1;
            nudGrassProbUl2.Size = size149;
            nudGrassProbUL.TabIndex = 19;
            nudGrassProbUL.TextAlign = HorizontalAlignment.Right;
            var nudGrassProbUl3 = nudGrassProbUL;
            num1 = new Decimal(new int[4] { 25, 0, 0, 0 });
            var num31 = num1;
            nudGrassProbUl3.Value = num31;
            var nudGrassProbLl1 = nudGrassProbLL;
            point1 = new Point(160, 272);
            var point153 = point1;
            nudGrassProbLl1.Location = point153;
            nudGrassProbLL.Name = "nudGrassProbLL";
            var nudGrassProbLl2 = nudGrassProbLL;
            size1 = new Size(40, 20);
            var size150 = size1;
            nudGrassProbLl2.Size = size150;
            nudGrassProbLL.TabIndex = 19;
            nudGrassProbLL.TextAlign = HorizontalAlignment.Right;
            var nudGrassProbLl3 = nudGrassProbLL;
            num1 = new Decimal(new int[4] { 25, 0, 0, 0 });
            var num32 = num1;
            nudGrassProbLl3.Value = num32;
            var nudGrassProbUr1 = nudGrassProbUR;
            point1 = new Point(264, 216);
            var point154 = point1;
            nudGrassProbUr1.Location = point154;
            nudGrassProbUR.Name = "nudGrassProbUR";
            var nudGrassProbUr2 = nudGrassProbUR;
            size1 = new Size(40, 20);
            var size151 = size1;
            nudGrassProbUr2.Size = size151;
            nudGrassProbUR.TabIndex = 19;
            nudGrassProbUR.TextAlign = HorizontalAlignment.Right;
            var nudGrassProbUr3 = nudGrassProbUR;
            num1 = new Decimal(new int[4] { 25, 0, 0, 0 });
            var num33 = num1;
            nudGrassProbUr3.Value = num33;
            var nudGrassProbLr1 = nudGrassProbLR;
            point1 = new Point(264, 272);
            var point155 = point1;
            nudGrassProbLr1.Location = point155;
            nudGrassProbLR.Name = "nudGrassProbLR";
            var nudGrassProbLr2 = nudGrassProbLR;
            size1 = new Size(40, 20);
            var size152 = size1;
            nudGrassProbLr2.Size = size152;
            nudGrassProbLR.TabIndex = 19;
            nudGrassProbLR.TextAlign = HorizontalAlignment.Right;
            var nudGrassProbLr3 = nudGrassProbLR;
            num1 = new Decimal(new int[4] { 25, 0, 0, 0 });
            var num34 = num1;
            nudGrassProbLr3.Value = num34;
            var label63_1 = Label63;
            point1 = new Point(24, 224);
            var point156 = point1;
            label63_1.Location = point156;
            Label63.Name = "Label63";
            var label63_2 = Label63;
            size1 = new Size(80, 48);
            var size153 = size1;
            label63_2.Size = size153;
            Label63.TabIndex = 18;
            Label63.Text = "Grass Movement Probability";
            Label63.TextAlign = ContentAlignment.MiddleLeft;
            var label64_1 = Label64;
            point1 = new Point(224, 208);
            var point157 = point1;
            label64_1.Location = point157;
            Label64.Name = "Label64";
            var label64_2 = Label64;
            size1 = new Size(40, 32);
            var size154 = size1;
            label64_2.Size = size154;
            Label64.TabIndex = 13;
            Label64.Text = "Upper Right";
            Label64.TextAlign = ContentAlignment.MiddleLeft;
            var label65_1 = Label65;
            point1 = new Point(120, 208);
            var point158 = point1;
            label65_1.Location = point158;
            Label65.Name = "Label65";
            var label65_2 = Label65;
            size1 = new Size(40, 32);
            var size155 = size1;
            label65_2.Size = size155;
            Label65.TabIndex = 13;
            Label65.Text = "Upper Left";
            Label65.TextAlign = ContentAlignment.MiddleLeft;
            var label66_1 = Label66;
            point1 = new Point(120, 264);
            var point159 = point1;
            label66_1.Location = point159;
            Label66.Name = "Label66";
            var label66_2 = Label66;
            size1 = new Size(40, 32);
            var size156 = size1;
            label66_2.Size = size156;
            Label66.TabIndex = 13;
            Label66.Text = "Lower Left";
            Label66.TextAlign = ContentAlignment.MiddleLeft;
            var label67_1 = Label67;
            point1 = new Point(224, 264);
            var point160 = point1;
            label67_1.Location = point160;
            Label67.Name = "Label67";
            var label67_2 = Label67;
            size1 = new Size(40, 32);
            var size157 = size1;
            label67_2.Size = size157;
            Label67.TabIndex = 13;
            Label67.Text = "Lower Right";
            Label67.TextAlign = ContentAlignment.MiddleLeft;
            var grassProbability1 = lblTotalGrassProbability;
            point1 = new Point(344, 248);
            var point161 = point1;
            grassProbability1.Location = point161;
            lblTotalGrassProbability.Name = "lblTotalGrassProbability";
            var grassProbability2 = lblTotalGrassProbability;
            size1 = new Size(80, 16);
            var size158 = size1;
            grassProbability2.Size = size158;
            lblTotalGrassProbability.TabIndex = 18;
            lblTotalGrassProbability.Text = "Total: ";
            lblTotalGrassProbability.TextAlign = ContentAlignment.MiddleLeft;
            var label69_1 = Label69;
            point1 = new Point(200, 218);
            var point162 = point1;
            label69_1.Location = point162;
            Label69.Name = "Label69";
            var label69_2 = Label69;
            size1 = new Size(16, 16);
            var size159 = size1;
            label69_2.Size = size159;
            Label69.TabIndex = 13;
            Label69.Text = "%";
            Label69.TextAlign = ContentAlignment.MiddleLeft;
            var label70_1 = Label70;
            point1 = new Point(304, 218);
            var point163 = point1;
            label70_1.Location = point163;
            Label70.Name = "Label70";
            var label70_2 = Label70;
            size1 = new Size(16, 16);
            var size160 = size1;
            label70_2.Size = size160;
            Label70.TabIndex = 13;
            Label70.Text = "%";
            Label70.TextAlign = ContentAlignment.MiddleLeft;
            var label71_1 = Label71;
            point1 = new Point(304, 274);
            var point164 = point1;
            label71_1.Location = point164;
            Label71.Name = "Label71";
            var label71_2 = Label71;
            size1 = new Size(16, 16);
            var size161 = size1;
            label71_2.Size = size161;
            Label71.TabIndex = 13;
            Label71.Text = "%";
            Label71.TextAlign = ContentAlignment.MiddleLeft;
            var label72_1 = Label72;
            point1 = new Point(200, 274);
            var point165 = point1;
            label72_1.Location = point165;
            Label72.Name = "Label72";
            var label72_2 = Label72;
            size1 = new Size(16, 16);
            var size162 = size1;
            label72_2.Size = size162;
            Label72.TabIndex = 13;
            Label72.Text = "%";
            Label72.TextAlign = ContentAlignment.MiddleLeft;
            var label68_1 = Label68;
            point1 = new Point(24, 160);
            var point166 = point1;
            label68_1.Location = point166;
            Label68.Name = "Label68";
            var label68_2 = Label68;
            size1 = new Size(96, 16);
            var size163 = size1;
            label68_2.Size = size163;
            Label68.TabIndex = 18;
            Label68.Text = "Grass Quad Size";
            Label68.TextAlign = ContentAlignment.MiddleLeft;
            nudGrassQuadSize.DecimalPlaces = 2;
            var nudGrassQuadSize1 = nudGrassQuadSize;
            num1 = new Decimal(new int[4] { 5, 0, 0, 131072 });
            var num35 = num1;
            nudGrassQuadSize1.Increment = num35;
            var nudGrassQuadSize2 = nudGrassQuadSize;
            point1 = new Point(120, 160);
            var point167 = point1;
            nudGrassQuadSize2.Location = point167;
            var nudGrassQuadSize3 = nudGrassQuadSize;
            num1 = new Decimal(new int[4] { 20, 0, 0, 0 });
            var num36 = num1;
            nudGrassQuadSize3.Maximum = num36;
            nudGrassQuadSize.Name = "nudGrassQuadSize";
            var nudGrassQuadSize4 = nudGrassQuadSize;
            size1 = new Size(56, 20);
            var size164 = size1;
            nudGrassQuadSize4.Size = size164;
            nudGrassQuadSize.TabIndex = 19;
            nudGrassQuadSize.TextAlign = HorizontalAlignment.Right;
            var nudGrassQuadSize5 = nudGrassQuadSize;
            num1 = new Decimal(new int[4] { 10, 0, 0, 65536 });
            var num37 = num1;
            nudGrassQuadSize5.Value = num37;
            tabpagAreaAudio.Controls.Add(trkbarAmbientSndNightVol);
            tabpagAreaAudio.Controls.Add(trkbarAmbientSndDayVol);
            tabpagAreaAudio.Controls.Add(Label52);
            tabpagAreaAudio.Controls.Add(nudMusicDelay);
            tabpagAreaAudio.Controls.Add(cmbxMusicNight);
            tabpagAreaAudio.Controls.Add(cmbxMusicDay);
            tabpagAreaAudio.Controls.Add(cmbxMusicBattle);
            tabpagAreaAudio.Controls.Add(cmbxEnvAudio);
            tabpagAreaAudio.Controls.Add(cmbxAmbientSndNight);
            tabpagAreaAudio.Controls.Add(cmbxAmbientSndDay);
            tabpagAreaAudio.Controls.Add(Label53);
            tabpagAreaAudio.Controls.Add(Label54);
            tabpagAreaAudio.Controls.Add(Label55);
            tabpagAreaAudio.Controls.Add(Label56);
            tabpagAreaAudio.Controls.Add(Label57);
            tabpagAreaAudio.Controls.Add(Label58);
            tabpagAreaAudio.Controls.Add(Label59);
            tabpagAreaAudio.Controls.Add(Label60);
            tabpagAreaAudio.Controls.Add(Label61);
            var tabpagAreaAudio1 = tabpagAreaAudio;
            point1 = new Point(4, 22);
            var point168 = point1;
            ((Control)tabpagAreaAudio1).Location = point168;
            tabpagAreaAudio.Name = "tabpagAreaAudio";
            var tabpagAreaAudio2 = tabpagAreaAudio;
            size1 = new Size(480, 444);
            var size165 = size1;
            tabpagAreaAudio2.Size = size165;
            tabpagAreaAudio.TabIndex = 5;
            tabpagAreaAudio.Text = "Audio";
            var ambientSndNightVol1 = trkbarAmbientSndNightVol;
            point1 = new Point(160, 144);
            var point169 = point1;
            ambientSndNightVol1.Location = point169;
            trkbarAmbientSndNightVol.Maximum = sbyte.MaxValue;
            trkbarAmbientSndNightVol.Name = "trkbarAmbientSndNightVol";
            var ambientSndNightVol2 = trkbarAmbientSndNightVol;
            size1 = new Size(216, 42);
            var size166 = size1;
            ambientSndNightVol2.Size = size166;
            trkbarAmbientSndNightVol.TabIndex = 3;
            trkbarAmbientSndNightVol.TickFrequency = 5;
            var ambientSndDayVol1 = trkbarAmbientSndDayVol;
            point1 = new Point(160, 64);
            var point170 = point1;
            ambientSndDayVol1.Location = point170;
            trkbarAmbientSndDayVol.Maximum = sbyte.MaxValue;
            trkbarAmbientSndDayVol.Name = "trkbarAmbientSndDayVol";
            var ambientSndDayVol2 = trkbarAmbientSndDayVol;
            size1 = new Size(216, 42);
            var size167 = size1;
            ambientSndDayVol2.Size = size167;
            trkbarAmbientSndDayVol.TabIndex = 1;
            trkbarAmbientSndDayVol.TickFrequency = 5;
            var label52_1 = Label52;
            point1 = new Point(24, 40);
            var point171 = point1;
            label52_1.Location = point171;
            Label52.Name = "Label52";
            var label52_2 = Label52;
            size1 = new Size(112, 16);
            var size168 = size1;
            label52_2.Size = size168;
            Label52.TabIndex = 19;
            Label52.Text = "Ambient Sound - Day";
            Label52.TextAlign = ContentAlignment.MiddleLeft;
            var nudMusicDelay1 = nudMusicDelay;
            point1 = new Point(168, 336);
            var point172 = point1;
            nudMusicDelay1.Location = point172;
            var nudMusicDelay2 = nudMusicDelay;
            num1 = new Decimal(new int[4] { 600, 0, 0, 0 });
            var num38 = num1;
            nudMusicDelay2.Maximum = num38;
            nudMusicDelay.Name = "nudMusicDelay";
            var nudMusicDelay3 = nudMusicDelay;
            size1 = new Size(56, 20);
            var size169 = size1;
            nudMusicDelay3.Size = size169;
            nudMusicDelay.TabIndex = 8;
            nudMusicDelay.TextAlign = HorizontalAlignment.Right;
            cmbxMusicNight.DropDownStyle = ComboBoxStyle.DropDownList;
            var cmbxMusicNight1 = cmbxMusicNight;
            point1 = new Point(168, 304);
            var point173 = point1;
            cmbxMusicNight1.Location = point173;
            cmbxMusicNight.Name = "cmbxMusicNight";
            var cmbxMusicNight2 = cmbxMusicNight;
            size1 = new Size(200, 21);
            var size170 = size1;
            cmbxMusicNight2.Size = size170;
            cmbxMusicNight.TabIndex = 7;
            cmbxMusicDay.DropDownStyle = ComboBoxStyle.DropDownList;
            var cmbxMusicDay1 = cmbxMusicDay;
            point1 = new Point(168, 272);
            var point174 = point1;
            cmbxMusicDay1.Location = point174;
            cmbxMusicDay.Name = "cmbxMusicDay";
            var cmbxMusicDay2 = cmbxMusicDay;
            size1 = new Size(200, 21);
            var size171 = size1;
            cmbxMusicDay2.Size = size171;
            cmbxMusicDay.TabIndex = 6;
            cmbxMusicBattle.DropDownStyle = ComboBoxStyle.DropDownList;
            var cmbxMusicBattle1 = cmbxMusicBattle;
            point1 = new Point(168, 240);
            var point175 = point1;
            cmbxMusicBattle1.Location = point175;
            cmbxMusicBattle.Name = "cmbxMusicBattle";
            var cmbxMusicBattle2 = cmbxMusicBattle;
            size1 = new Size(200, 21);
            var size172 = size1;
            cmbxMusicBattle2.Size = size172;
            cmbxMusicBattle.TabIndex = 5;
            cmbxEnvAudio.DropDownStyle = ComboBoxStyle.DropDownList;
            var cmbxEnvAudio1 = cmbxEnvAudio;
            point1 = new Point(168, 208);
            var point176 = point1;
            cmbxEnvAudio1.Location = point176;
            cmbxEnvAudio.Name = "cmbxEnvAudio";
            var cmbxEnvAudio2 = cmbxEnvAudio;
            size1 = new Size(200, 21);
            var size173 = size1;
            cmbxEnvAudio2.Size = size173;
            cmbxEnvAudio.TabIndex = 4;
            cmbxAmbientSndNight.DropDownStyle = ComboBoxStyle.DropDownList;
            var cmbxAmbientSndNight1 = cmbxAmbientSndNight;
            point1 = new Point(168, 120);
            var point177 = point1;
            cmbxAmbientSndNight1.Location = point177;
            cmbxAmbientSndNight.Name = "cmbxAmbientSndNight";
            var cmbxAmbientSndNight2 = cmbxAmbientSndNight;
            size1 = new Size(200, 21);
            var size174 = size1;
            cmbxAmbientSndNight2.Size = size174;
            cmbxAmbientSndNight.TabIndex = 2;
            cmbxAmbientSndDay.DropDownStyle = ComboBoxStyle.DropDownList;
            var cmbxAmbientSndDay1 = cmbxAmbientSndDay;
            point1 = new Point(168, 40);
            var point178 = point1;
            cmbxAmbientSndDay1.Location = point178;
            cmbxAmbientSndDay.Name = "cmbxAmbientSndDay";
            var cmbxAmbientSndDay2 = cmbxAmbientSndDay;
            size1 = new Size(200, 21);
            var size175 = size1;
            cmbxAmbientSndDay2.Size = size175;
            cmbxAmbientSndDay.TabIndex = 0;
            var label53_1 = Label53;
            point1 = new Point(24, 68);
            var point179 = point1;
            label53_1.Location = point179;
            Label53.Name = "Label53";
            var label53_2 = Label53;
            size1 = new Size(88, 16);
            var size176 = size1;
            label53_2.Size = size176;
            Label53.TabIndex = 19;
            Label53.Text = "Volume";
            Label53.TextAlign = ContentAlignment.MiddleLeft;
            var label54_1 = Label54;
            point1 = new Point(24, 120);
            var point180 = point1;
            label54_1.Location = point180;
            Label54.Name = "Label54";
            var label54_2 = Label54;
            size1 = new Size(120, 16);
            var size177 = size1;
            label54_2.Size = size177;
            Label54.TabIndex = 19;
            Label54.Text = "Ambient Sound - Night";
            Label54.TextAlign = ContentAlignment.MiddleLeft;
            var label55_1 = Label55;
            point1 = new Point(24, 148);
            var point181 = point1;
            label55_1.Location = point181;
            Label55.Name = "Label55";
            var label55_2 = Label55;
            size1 = new Size(88, 16);
            var size178 = size1;
            label55_2.Size = size178;
            Label55.TabIndex = 19;
            Label55.Text = "Volume";
            Label55.TextAlign = ContentAlignment.MiddleLeft;
            var label56_1 = Label56;
            point1 = new Point(24, 205);
            var point182 = point1;
            label56_1.Location = point182;
            Label56.Name = "Label56";
            var label56_2 = Label56;
            size1 = new Size(88, 24);
            var size179 = size1;
            label56_2.Size = size179;
            Label56.TabIndex = 19;
            Label56.Text = "Environmental Audio Effects";
            Label56.TextAlign = ContentAlignment.MiddleLeft;
            var label57_1 = Label57;
            point1 = new Point(24, 240);
            var point183 = point1;
            label57_1.Location = point183;
            Label57.Name = "Label57";
            var label57_2 = Label57;
            size1 = new Size(88, 16);
            var size180 = size1;
            label57_2.Size = size180;
            Label57.TabIndex = 19;
            Label57.Text = "Battle Music";
            Label57.TextAlign = ContentAlignment.MiddleLeft;
            var label58_1 = Label58;
            point1 = new Point(24, 272);
            var point184 = point1;
            label58_1.Location = point184;
            Label58.Name = "Label58";
            var label58_2 = Label58;
            size1 = new Size(88, 16);
            var size181 = size1;
            label58_2.Size = size181;
            Label58.TabIndex = 19;
            Label58.Text = "Daytime Music";
            Label58.TextAlign = ContentAlignment.MiddleLeft;
            var label59_1 = Label59;
            point1 = new Point(24, 304);
            var point185 = point1;
            label59_1.Location = point185;
            Label59.Name = "Label59";
            var label59_2 = Label59;
            size1 = new Size(88, 16);
            var size182 = size1;
            label59_2.Size = size182;
            Label59.TabIndex = 19;
            Label59.Text = "Nighttime Music";
            Label59.TextAlign = ContentAlignment.MiddleLeft;
            var label60_1 = Label60;
            point1 = new Point(24, 336);
            var point186 = point1;
            label60_1.Location = point186;
            Label60.Name = "Label60";
            var label60_2 = Label60;
            size1 = new Size(88, 16);
            var size183 = size1;
            label60_2.Size = size183;
            Label60.TabIndex = 19;
            Label60.Text = "Music Delay";
            Label60.TextAlign = ContentAlignment.MiddleLeft;
            var label61_1 = Label61;
            point1 = new Point(224, 338);
            var point187 = point1;
            label61_1.Location = point187;
            Label61.Name = "Label61";
            var label61_2 = Label61;
            size1 = new Size(88, 16);
            var size184 = size1;
            label61_2.Size = size184;
            Label61.TabIndex = 19;
            Label61.Text = "Seconds";
            Label61.TextAlign = ContentAlignment.MiddleLeft;
            tabpagArea_Events.Controls.Add(Label77);
            tabpagArea_Events.Controls.Add(tbArea_OnUserDefined);
            tabpagArea_Events.Controls.Add(tbArea_OnHeartbeat);
            tabpagArea_Events.Controls.Add(Label76);
            tabpagArea_Events.Controls.Add(Label74);
            tabpagArea_Events.Controls.Add(tbArea_OnEnter);
            tabpagArea_Events.Controls.Add(Label75);
            tabpagArea_Events.Controls.Add(tbArea_OnExit);
            var tabpagAreaEvents1 = tabpagArea_Events;
            point1 = new Point(4, 22);
            var point188 = point1;
            ((Control)tabpagAreaEvents1).Location = point188;
            tabpagArea_Events.Name = "tabpagArea_Events";
            var tabpagAreaEvents2 = tabpagArea_Events;
            size1 = new Size(480, 444);
            var size185 = size1;
            tabpagAreaEvents2.Size = size185;
            tabpagArea_Events.TabIndex = 6;
            tabpagArea_Events.Text = "Events";
            var label77_1 = Label77;
            point1 = new Point(24, 112);
            var point189 = point1;
            label77_1.Location = point189;
            Label77.Name = "Label77";
            var label77_2 = Label77;
            size1 = new Size(100, 18);
            var size186 = size1;
            label77_2.Size = size186;
            Label77.TabIndex = 36;
            Label77.Text = "OnUserDefined";
            Label77.TextAlign = ContentAlignment.MiddleLeft;
            tbArea_OnUserDefined.CharacterCasing = CharacterCasing.Lower;
            var areaOnUserDefined1 = tbArea_OnUserDefined;
            point1 = new Point(136, 112);
            var point190 = point1;
            areaOnUserDefined1.Location = point190;
            tbArea_OnUserDefined.MaxLength = 16;
            tbArea_OnUserDefined.Name = "tbArea_OnUserDefined";
            var areaOnUserDefined2 = tbArea_OnUserDefined;
            size1 = new Size(204, 20);
            var size187 = size1;
            areaOnUserDefined2.Size = size187;
            tbArea_OnUserDefined.TabIndex = 35;
            tbArea_OnUserDefined.Text = "";
            tbArea_OnHeartbeat.CharacterCasing = CharacterCasing.Lower;
            var tbAreaOnHeartbeat1 = tbArea_OnHeartbeat;
            point1 = new Point(136, 88);
            var point191 = point1;
            tbAreaOnHeartbeat1.Location = point191;
            tbArea_OnHeartbeat.MaxLength = 16;
            tbArea_OnHeartbeat.Name = "tbArea_OnHeartbeat";
            var tbAreaOnHeartbeat2 = tbArea_OnHeartbeat;
            size1 = new Size(204, 20);
            var size188 = size1;
            tbAreaOnHeartbeat2.Size = size188;
            tbArea_OnHeartbeat.TabIndex = 33;
            tbArea_OnHeartbeat.Text = "";
            var label76_1 = Label76;
            point1 = new Point(24, 88);
            var point192 = point1;
            label76_1.Location = point192;
            Label76.Name = "Label76";
            var label76_2 = Label76;
            size1 = new Size(100, 18);
            var size189 = size1;
            label76_2.Size = size189;
            Label76.TabIndex = 34;
            Label76.Text = "OnHeartbeat";
            Label76.TextAlign = ContentAlignment.MiddleLeft;
            var label74_1 = Label74;
            point1 = new Point(24, 40);
            var point193 = point1;
            label74_1.Location = point193;
            Label74.Name = "Label74";
            var label74_2 = Label74;
            size1 = new Size(100, 18);
            var size190 = size1;
            label74_2.Size = size190;
            Label74.TabIndex = 32;
            Label74.Text = "OnEnter";
            Label74.TextAlign = ContentAlignment.MiddleLeft;
            tbArea_OnEnter.CharacterCasing = CharacterCasing.Lower;
            var tbAreaOnEnter1 = tbArea_OnEnter;
            point1 = new Point(136, 40);
            var point194 = point1;
            tbAreaOnEnter1.Location = point194;
            tbArea_OnEnter.MaxLength = 16;
            tbArea_OnEnter.Name = "tbArea_OnEnter";
            var tbAreaOnEnter2 = tbArea_OnEnter;
            size1 = new Size(204, 20);
            var size191 = size1;
            tbAreaOnEnter2.Size = size191;
            tbArea_OnEnter.TabIndex = 29;
            tbArea_OnEnter.Text = "";
            var label75_1 = Label75;
            point1 = new Point(24, 64);
            var point195 = point1;
            label75_1.Location = point195;
            Label75.Name = "Label75";
            var label75_2 = Label75;
            size1 = new Size(100, 18);
            var size192 = size1;
            label75_2.Size = size192;
            Label75.TabIndex = 31;
            Label75.Text = "OnExit";
            Label75.TextAlign = ContentAlignment.MiddleLeft;
            tbArea_OnExit.CharacterCasing = CharacterCasing.Lower;
            var tbAreaOnExit1 = tbArea_OnExit;
            point1 = new Point(136, 64);
            var point196 = point1;
            tbAreaOnExit1.Location = point196;
            tbArea_OnExit.MaxLength = 16;
            tbArea_OnExit.Name = "tbArea_OnExit";
            var tbAreaOnExit2 = tbArea_OnExit;
            size1 = new Size(204, 20);
            var size193 = size1;
            tbAreaOnExit2.Size = size193;
            tbArea_OnExit.TabIndex = 30;
            tbArea_OnExit.Text = "";
            tabpagAreaRooms.Controls.Add(lbRooms);
            tabpagAreaRooms.Controls.Add(Label82);
            tabpagAreaRooms.Controls.Add(chkbRoomDisableWeather);
            tabpagAreaRooms.Controls.Add(nudRoomAmbientScale);
            tabpagAreaRooms.Controls.Add(Label80);
            tabpagAreaRooms.Controls.Add(cmbxRoomEnvAudio);
            tabpagAreaRooms.Controls.Add(Label79);
            tabpagAreaRooms.Controls.Add(Label78);
            tabpagAreaRooms.Controls.Add(tbRoomName);
            tabpagAreaRooms.Controls.Add(nudRoomForceRating);
            tabpagAreaRooms.Controls.Add(Label81);
            tabpagAreaRooms.Controls.Add(Label83);
            var tabpagAreaRooms1 = tabpagAreaRooms;
            point1 = new Point(4, 22);
            var point197 = point1;
            ((Control)tabpagAreaRooms1).Location = point197;
            tabpagAreaRooms.Name = "tabpagAreaRooms";
            var tabpagAreaRooms2 = tabpagAreaRooms;
            size1 = new Size(480, 444);
            var size194 = size1;
            tabpagAreaRooms2.Size = size194;
            tabpagAreaRooms.TabIndex = 7;
            tabpagAreaRooms.Text = "Rooms";
            var lbRooms1 = lbRooms;
            point1 = new Point(176, 40);
            var point198 = point1;
            lbRooms1.Location = point198;
            lbRooms.Name = "lbRooms";
            lbRooms.ScrollAlwaysVisible = true;
            var lbRooms2 = lbRooms;
            size1 = new Size(96, 95);
            var size195 = size1;
            lbRooms2.Size = size195;
            lbRooms.TabIndex = 41;
            var label82_1 = Label82;
            point1 = new Point(24, 288);
            var point199 = point1;
            label82_1.Location = point199;
            Label82.Name = "Label82";
            var label82_2 = Label82;
            size1 = new Size(88, 16);
            var size196 = size1;
            label82_2.Size = size196;
            Label82.TabIndex = 40;
            Label82.Text = "Disable Weather";
            Label82.TextAlign = ContentAlignment.MiddleLeft;
            var roomDisableWeather1 = chkbRoomDisableWeather;
            point1 = new Point(184, 288);
            var point200 = point1;
            roomDisableWeather1.Location = point200;
            chkbRoomDisableWeather.Name = "chkbRoomDisableWeather";
            var roomDisableWeather2 = chkbRoomDisableWeather;
            size1 = new Size(32, 16);
            var size197 = size1;
            roomDisableWeather2.Size = size197;
            chkbRoomDisableWeather.TabIndex = 39;
            nudRoomAmbientScale.DecimalPlaces = 2;
            var roomAmbientScale1 = nudRoomAmbientScale;
            num1 = new Decimal(new int[4] { 5, 0, 0, 131072 });
            var num39 = num1;
            roomAmbientScale1.Increment = num39;
            var roomAmbientScale2 = nudRoomAmbientScale;
            point1 = new Point(184, 224);
            var point201 = point1;
            roomAmbientScale2.Location = point201;
            var roomAmbientScale3 = nudRoomAmbientScale;
            num1 = new Decimal(new int[4] { 1, 0, 0, 0 });
            var num40 = num1;
            roomAmbientScale3.Maximum = num40;
            nudRoomAmbientScale.Name = "nudRoomAmbientScale";
            var roomAmbientScale4 = nudRoomAmbientScale;
            size1 = new Size(56, 20);
            var size198 = size1;
            roomAmbientScale4.Size = size198;
            nudRoomAmbientScale.TabIndex = 38;
            nudRoomAmbientScale.TextAlign = HorizontalAlignment.Right;
            var label80_1 = Label80;
            point1 = new Point(24, 224);
            var point202 = point1;
            label80_1.Location = point202;
            Label80.Name = "Label80";
            var label80_2 = Label80;
            size1 = new Size(128, 16);
            var size199 = size1;
            label80_2.Size = size199;
            Label80.TabIndex = 37;
            Label80.Text = "Ambient Sound Scale";
            Label80.TextAlign = ContentAlignment.MiddleLeft;
            cmbxRoomEnvAudio.DropDownStyle = ComboBoxStyle.DropDownList;
            var cmbxRoomEnvAudio1 = cmbxRoomEnvAudio;
            point1 = new Point(184, 192);
            var point203 = point1;
            cmbxRoomEnvAudio1.Location = point203;
            cmbxRoomEnvAudio.Name = "cmbxRoomEnvAudio";
            var cmbxRoomEnvAudio2 = cmbxRoomEnvAudio;
            size1 = new Size(192, 21);
            var size200 = size1;
            cmbxRoomEnvAudio2.Size = size200;
            cmbxRoomEnvAudio.TabIndex = 35;
            var label79_1 = Label79;
            point1 = new Point(24, 192);
            var point204 = point1;
            label79_1.Location = point204;
            Label79.Name = "Label79";
            var label79_2 = Label79;
            size1 = new Size(160, 24);
            var size201 = size1;
            label79_2.Size = size201;
            Label79.TabIndex = 36;
            Label79.Text = "Environmental Audio Effects";
            Label79.TextAlign = ContentAlignment.MiddleLeft;
            var label78_1 = Label78;
            point1 = new Point(24, 160);
            var point205 = point1;
            label78_1.Location = point205;
            Label78.Name = "Label78";
            var label78_2 = Label78;
            size1 = new Size(100, 18);
            var size202 = size1;
            label78_2.Size = size202;
            Label78.TabIndex = 34;
            Label78.Text = "Room Name";
            Label78.TextAlign = ContentAlignment.MiddleLeft;
            tbRoomName.CharacterCasing = CharacterCasing.Lower;
            var tbRoomName1 = tbRoomName;
            point1 = new Point(184, 160);
            var point206 = point1;
            tbRoomName1.Location = point206;
            tbRoomName.MaxLength = 16;
            tbRoomName.Name = "tbRoomName";
            tbRoomName.ReadOnly = true;
            var tbRoomName2 = tbRoomName;
            size1 = new Size(104, 20);
            var size203 = size1;
            tbRoomName2.Size = size203;
            tbRoomName.TabIndex = 33;
            tbRoomName.Text = "";
            var nudRoomForceRating1 = nudRoomForceRating;
            point1 = new Point(184, 256);
            var point207 = point1;
            nudRoomForceRating1.Location = point207;
            var nudRoomForceRating2 = nudRoomForceRating;
            num1 = new Decimal(new int[4]
            {
                100,
                0,
                0,
                int.MinValue
            });
            var num41 = num1;
            nudRoomForceRating2.Minimum = num41;
            nudRoomForceRating.Name = "nudRoomForceRating";
            var nudRoomForceRating3 = nudRoomForceRating;
            size1 = new Size(56, 20);
            var size204 = size1;
            nudRoomForceRating3.Size = size204;
            nudRoomForceRating.TabIndex = 38;
            nudRoomForceRating.TextAlign = HorizontalAlignment.Right;
            var label81_1 = Label81;
            point1 = new Point(24, 256);
            var point208 = point1;
            label81_1.Location = point208;
            Label81.Name = "Label81";
            var label81_2 = Label81;
            size1 = new Size(128, 16);
            var size205 = size1;
            label81_2.Size = size205;
            Label81.TabIndex = 37;
            Label81.Text = "Force Rating";
            Label81.TextAlign = ContentAlignment.MiddleLeft;
            var label83_1 = Label83;
            point1 = new Point(24, 72);
            var point209 = point1;
            label83_1.Location = point209;
            Label83.Name = "Label83";
            var label83_2 = Label83;
            size1 = new Size(100, 18);
            var size206 = size1;
            label83_2.Size = size206;
            Label83.TabIndex = 34;
            Label83.Text = "Rooms";
            Label83.TextAlign = ContentAlignment.MiddleLeft;
            btnOK.DialogResult = DialogResult.OK;
            var btnOk = btnOK;
            point1 = new Point(320, 532);
            var point210 = point1;
            btnOk.Location = point210;
            btnOK.Name = "btnOK";
            btnOK.TabIndex = 0;
            btnOK.Text = "&OK";
            this.btnCancel.DialogResult = DialogResult.Cancel;
            var btnCancel = this.btnCancel;
            point1 = new Point(416, 532);
            var point211 = point1;
            btnCancel.Location = point211;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            CancelButton = this.btnCancel;
            size1 = new Size(528, 565);
            ClientSize = size1;
            Controls.Add(btnOK);
            Controls.Add(this.btnCancel);
            Controls.Add(TabControlMain);
            Name = nameof(frmModuleIfo_AreaEditor);
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Module Properties Editor";
            TabControlModule.ResumeLayout(false);
            tabpagModuleBasic.ResumeLayout(false);
            nudXY.EndInit();
            nudModEntryX.EndInit();
            nudModEntryY.EndInit();
            nudModEntryZ.EndInit();
            tabpagModuleAdvanced.ResumeLayout(false);
            nudXPScale.EndInit();
            trkbarXPScale.EndInit();
            nudMinutesPerHour.EndInit();
            nudDawnStartHour.EndInit();
            nudDuskStartHour.EndInit();
            nudStartHour.EndInit();
            nudStartDay.EndInit();
            nudStartMonth.EndInit();
            nudStartYear.EndInit();
            tabpagModuleEvents.ResumeLayout(false);
            tabpagModuleDescription.ResumeLayout(false);
            TabControlMain.ResumeLayout(false);
            TabPage5.ResumeLayout(false);
            TabPage6.ResumeLayout(false);
            TabControlArea.ResumeLayout(false);
            tabpagAreaBasic.ResumeLayout(false);
            NumericUpDown10.EndInit();
            NumericUpDown11.EndInit();
            NumericUpDown12.EndInit();
            tabpagAreaEnvironment.ResumeLayout(false);
            GroupBox1.ResumeLayout(false);
            nudChanceSnow.EndInit();
            nudChanceRain.EndInit();
            nudChanceLightning.EndInit();
            gbMoon.ResumeLayout(false);
            trkbarMoonFogNear.EndInit();
            trkbarMoonFogFar.EndInit();
            gbSun.ResumeLayout(false);
            trkbarSunFogNear.EndInit();
            trkbarSunFogFar.EndInit();
            nudShadowOpacity.EndInit();
            tabpagAreaGrass.ResumeLayout(false);
            nudGrassDensity.EndInit();
            trkbarGrassDensityX10.EndInit();
            nudGrassProbUL.EndInit();
            nudGrassProbLL.EndInit();
            nudGrassProbUR.EndInit();
            nudGrassProbLR.EndInit();
            nudGrassQuadSize.EndInit();
            tabpagAreaAudio.ResumeLayout(false);
            trkbarAmbientSndNightVol.EndInit();
            trkbarAmbientSndDayVol.EndInit();
            nudMusicDelay.EndInit();
            tabpagArea_Events.ResumeLayout(false);
            tabpagAreaRooms.ResumeLayout(false);
            nudRoomAmbientScale.EndInit();
            nudRoomForceRating.EndInit();
            ResumeLayout(false);
        }

    public frmModuleIfo_AreaEditor(
        ref ClsGff AREFile,
        ref ClsGff IFOFile,
        ref ClsGff GITFile,
        int KotorVersion)
        : this()
    {
            KotorVersionIndex = KotorVersion;
            CurrentSettings = UserSettings.GetSettings();
            _DialogTlk = new clsDialogTlk(CurrentSettings.KotorLocation(KotorVersionIndex) + "\\dialog.tlk");
            _ChitinKey = new ChitinKey(CurrentSettings.KeyFileLocation(KotorVersionIndex));
            _AREFile = AREFile;
            _IFOFile = IFOFile;
            _GITFile = GITFile;
            FillForm();
        }

    private void SetupRooms()
    {
            FillComboBoxFrom2DA(cmbxRoomEnvAudio, "label", "soundeax", _ChitinKey, null);
            var num1 = checked(_AREFile.GetListItemCount("Rooms") - 1);
            Rooms = new Room[checked(num1 + 1)];
            var num2 = num1;
            var index = 0;
            while (index <= num2)
            {
                Rooms[index] = new Room();
                Rooms[index].RoomName =
                    StringType.FromObject(
                        _AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(index) + ").RoomName"));
                Rooms[index].EnvAudio =
                    IntegerType.FromObject(
                        _AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(index) + ").EnvAudio"));
                Rooms[index].AmbientScale =
                    SingleType.FromObject(
                        _AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(index) + ").AmbientScale"));
                Rooms[index].ForceRating =
                    IntegerType.FromObject(
                        _AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(index) + ").ForceRating"));
                Rooms[index].DisableWeather =
                    BooleanType.FromObject(
                        _AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(index) + ").DisableWeather"));
                checked
                {
                    ++index;
                }
            }

            lbRooms.DataSource = Rooms;
            lbRooms.DisplayMember = "Text";
        }

    private void ReadRooms()
    {
            var upperBound = Rooms.GetUpperBound(0);
            var index = 0;
            while (index <= upperBound)
            {
                _AREFile.SetNodeValue("Rooms(" + StringType.FromInteger(index) + ").EnvAudio", Rooms[index].EnvAudio);
                _AREFile.SetNodeValue("Rooms(" + StringType.FromInteger(index) + ").AmbientScale",
                    Rooms[index].AmbientScale);
                _AREFile.SetNodeValue("Rooms(" + StringType.FromInteger(index) + ").ForceRating",
                    Rooms[index].ForceRating);
                _AREFile.SetNodeValue("Rooms(" + StringType.FromInteger(index) + ").DisableWeather",
                    Rooms[index].DisableWeather);
                checked
                {
                    ++index;
                }
            }
        }

    private void FillForm()
    {
            _IFOFile.SetTextBoxFromCExoLocStringNodeValue(tbModName, "Mod_Name");
            Mod_Tag = StringType.FromObject(_IFOFile.GetNodeValue("Mod_Tag"));
            Mod_Entry_Area = StringType.FromObject(_IFOFile.GetNodeValue("Mod_Entry_Area"));
            Mod_Entry_X = SingleType.FromObject(_IFOFile.GetNodeValue("Mod_Entry_X"));
            Mod_Entry_Y = SingleType.FromObject(_IFOFile.GetNodeValue("Mod_Entry_Y"));
            Mod_Entry_Z = SingleType.FromObject(_IFOFile.GetNodeValue("Mod_Entry_Z"));
            _origXPos = Mod_Entry_X;
            _origYpos = Mod_Entry_Y;
            _origZpos = Mod_Entry_Z;
            _origXOrientation = SingleType.FromObject(_IFOFile.GetNodeValue("Mod_Entry_Dir_X"));
            _origYOrientation = SingleType.FromObject(_IFOFile.GetNodeValue("Mod_Entry_Dir_Y"));
            SetupOrientationIndicators(_origXOrientation, _origYOrientation);
            Mod_MinutesPerHour = IntegerType.FromObject(_IFOFile.GetNodeValue("Mod_MinPerHour"));
            Mod_DawnHour = IntegerType.FromObject(_IFOFile.GetNodeValue("Mod_DawnHour"));
            Mod_DuskHour = IntegerType.FromObject(_IFOFile.GetNodeValue("Mod_DuskHour"));
            Mod_StartHour = IntegerType.FromObject(_IFOFile.GetNodeValue("Mod_StartHour"));
            Mod_StartDay = IntegerType.FromObject(_IFOFile.GetNodeValue("Mod_StartDay"));
            Mod_StartMonth = IntegerType.FromObject(_IFOFile.GetNodeValue("Mod_StartMonth"));
            Mod_StartYear = Convert.ToInt32(RuntimeHelpers.GetObjectValue(_IFOFile.GetNodeValue("Mod_StartYear")));
            Mod_XPScale = IntegerType.FromObject(_IFOFile.GetNodeValue("Mod_XPScale"));
            Mod_OnAcquirItem = StringType.FromObject(_IFOFile.GetNodeValue("Mod_OnAcquirItem"));
            Mod_OnActvtItem = StringType.FromObject(_IFOFile.GetNodeValue("Mod_OnActvtItem"));
            Mod_OnClientEntr = StringType.FromObject(_IFOFile.GetNodeValue("Mod_OnClientEntr"));
            Mod_OnClientLeav = StringType.FromObject(_IFOFile.GetNodeValue("Mod_OnClientLeav"));
            Mod_OnHeartbeat = StringType.FromObject(_IFOFile.GetNodeValue("Mod_OnHeartbeat"));
            Mod_OnModLoad = StringType.FromObject(_IFOFile.GetNodeValue("Mod_OnModLoad"));
            Mod_OnPlrDeath = StringType.FromObject(_IFOFile.GetNodeValue("Mod_OnPlrDeath"));
            Mod_OnPlrDying = StringType.FromObject(_IFOFile.GetNodeValue("Mod_OnPlrDying"));
            Mod_OnPlrLvlUp = StringType.FromObject(_IFOFile.GetNodeValue("Mod_OnPlrLvlUp"));
            Mod_OnSpawnBtnDn = StringType.FromObject(_IFOFile.GetNodeValue("Mod_OnSpawnBtnDn"));
            Mod_OnPlrRest = StringType.FromObject(_IFOFile.GetNodeValue("Mod_OnPlrRest"));
            Mod_OnUnAqreItem = StringType.FromObject(_IFOFile.GetNodeValue("Mod_OnUnAqreItem"));
            Mod_OnUsrDefined = StringType.FromObject(_IFOFile.GetNodeValue("Mod_OnUsrDefined"));
            _AREFile.SetTextBoxFromCExoLocStringNodeValue(tbAreaName, "Name");
            _AREFile.SetTextBoxToNodeValue(tbAreaTag, "Tag");
            FillComboBoxFrom2DA(cmbxCameraStyle, "name", "camerastyle", _ChitinKey, _DialogTlk);
            if (!_AREFile.SyncComboBox(cmbxCameraStyle, "CameraStyle"))
                ComboBoxSettingError = true;
            chkbUnescapable.Checked = BooleanType.FromObject(_AREFile.GetNodeValue("Unescapable"));
            chkbDisableTransit.Checked = BooleanType.FromObject(_AREFile.GetNodeValue("DisableTransit"));
            rbDayNightCycle.Checked = BooleanType.FromObject(_AREFile.GetNodeValue("DayNightCycle"));
            if (!rbDayNightCycle.Checked)
            {
                if (ObjectType.ObjTst(_AREFile.GetNodeValue("IsNight"), 1, false) == 0)
                    rbAlwaysNight.Checked = true;
                else
                    rbAlwaysDay.Checked = true;
            }

            DynAmbientColor =
                (uint)(_AREFile.GetNodeValue("DynAmbientColor") ?? Activator.CreateInstance(typeof(uint)));
            _AREFile.SetNumericUpDownToNodeValue(nudShadowOpacity, "ShadowOpacity");
            SunAmbientColor =
                (uint)(_AREFile.GetNodeValue("SunAmbientColor") ?? Activator.CreateInstance(typeof(uint)));
            SunDiffuseColor =
                (uint)(_AREFile.GetNodeValue("SunDiffuseColor") ?? Activator.CreateInstance(typeof(uint)));
            SunFogColor = (uint)(_AREFile.GetNodeValue("SunFogColor") ?? Activator.CreateInstance(typeof(uint)));
            chkbSunFogOn.Checked = BooleanType.FromObject(_AREFile.GetNodeValue("SunFogOn"));
            trkbarSunFogNear.Value = IntegerType.FromObject(_AREFile.GetNodeValue("SunFogNear"));
            trkbarSunFogFar.Value = IntegerType.FromObject(_AREFile.GetNodeValue("SunFogFar"));
            chkbAreaSunShadows.Checked = BooleanType.FromObject(_AREFile.GetNodeValue("SunShadows"));
            MoonAmbientColor =
                (uint)(_AREFile.GetNodeValue("MoonAmbientColor") ?? Activator.CreateInstance(typeof(uint)));
            MoonDiffuseColor =
                (uint)(_AREFile.GetNodeValue("MoonDiffuseColor") ?? Activator.CreateInstance(typeof(uint)));
            MoonFogColor = (uint)(_AREFile.GetNodeValue("MoonFogColor") ?? Activator.CreateInstance(typeof(uint)));
            chkbMoonFogOn.Checked = BooleanType.FromObject(_AREFile.GetNodeValue("MoonFogOn"));
            trkbarMoonFogNear.Value = IntegerType.FromObject(_AREFile.GetNodeValue("MoonFogNear"));
            trkbarMoonFogFar.Value = IntegerType.FromObject(_AREFile.GetNodeValue("MoonFogFar"));
            chkbAreaMoonShadows.Checked = BooleanType.FromObject(_AREFile.GetNodeValue("MoonShadows"));
            _AREFile.SetNumericUpDownToNodeValue(nudChanceSnow, "ChanceSnow");
            _AREFile.SetNumericUpDownToNodeValue(nudChanceRain, "ChanceRain");
            _AREFile.SetNumericUpDownToNodeValue(nudChanceLightning, "ChanceLightning");
            FillComboBoxFrom2DA(cmbxAmbientSndDay, "description", "ambientsound", _ChitinKey, _DialogTlk);
            if (!_GITFile.SyncComboBox(cmbxAmbientSndDay, "AreaProperties.AmbientSndDay"))
                ComboBoxSettingError = true;
            FillComboBoxFrom2DA(cmbxAmbientSndNight, "description", "ambientsound", _ChitinKey, _DialogTlk);
            if (!_GITFile.SyncComboBox(cmbxAmbientSndNight, "AreaProperties.AmbientSndNight"))
                ComboBoxSettingError = true;
            trkbarAmbientSndDayVol.Value =
                IntegerType.FromObject(_GITFile.GetNodeValue("AreaProperties.AmbientSndDayVol"));
            trkbarAmbientSndNightVol.Value =
                IntegerType.FromObject(_GITFile.GetNodeValue("AreaProperties.AmbientSndNitVol"));
            FillComboBoxFrom2DA(cmbxEnvAudio, "label", "soundeax", _ChitinKey, null);
            if (!_GITFile.SyncComboBox(cmbxEnvAudio, "AreaProperties.EnvAudio"))
                ComboBoxSettingError = true;
            FillComboBoxFrom2DA(cmbxMusicBattle, "description", "ambientmusic", _ChitinKey, _DialogTlk);
            if (!_GITFile.SyncComboBox(cmbxMusicBattle, "AreaProperties.MusicBattle"))
                ComboBoxSettingError = true;
            FillComboBoxFrom2DA(cmbxMusicDay, "description", "ambientmusic", _ChitinKey, _DialogTlk);
            if (!_GITFile.SyncComboBox(cmbxMusicDay, "AreaProperties.MusicDay"))
                ComboBoxSettingError = true;
            FillComboBoxFrom2DA(cmbxMusicNight, "description", "ambientmusic", _ChitinKey, _DialogTlk);
            if (!_GITFile.SyncComboBox(cmbxMusicNight, "AreaProperties.MusicNight"))
                ComboBoxSettingError = true;
            nudMusicDelay.Value =
                DecimalType.FromObject(ObjectType.DivObj(_GITFile.GetNodeValue("AreaProperties.MusicDelay"), 1000));
            if (ComboBoxSettingError)
            {
                var num = (int)Interaction.MsgBox(
                    "One or more drop down menus could not be set.\n\nThis occurs when the file's index value for a menu exceeds the number of items on the menu itself.\n\nMenus with this error have been colored to make them more visible and will need to have a valid menu item selected.",
                    MsgBoxStyle.Critical, "Menu setting error");
            }

            _AREFile.SetTextBoxToNodeValue(tbGrass_TexName, "Grass_TexName");
            Grass_Ambient = (uint)(_AREFile.GetNodeValue("Grass_Ambient") ?? Activator.CreateInstance(typeof(uint)));
            Grass_Diffuse = (uint)(_AREFile.GetNodeValue("Grass_Diffuse") ?? Activator.CreateInstance(typeof(uint)));
            Grass_Emissive = (uint)(_AREFile.GetNodeValue("Grass_Emissive") ?? Activator.CreateInstance(typeof(uint)));
            _AREFile.SetNumericUpDownToNodeValue(nudGrassQuadSize, "Grass_QuadSize");
            _AREFile.SetNumericUpDownToNodeValue(nudGrassDensity, "Grass_Density");
            Grass_Prob_LL = SingleType.FromObject(_AREFile.GetNodeValue("Grass_Prob_LL"));
            Grass_Prob_UL = SingleType.FromObject(_AREFile.GetNodeValue("Grass_Prob_UL"));
            Grass_Prob_LR = SingleType.FromObject(_AREFile.GetNodeValue("Grass_Prob_LR"));
            Grass_Prob_UR = SingleType.FromObject(_AREFile.GetNodeValue("Grass_Prob_UR"));
            _AREFile.SetTextBoxToNodeValue(tbArea_OnEnter, "OnEnter");
            _AREFile.SetTextBoxToNodeValue(tbArea_OnExit, "OnExit");
            _AREFile.SetTextBoxToNodeValue(tbArea_OnHeartbeat, "OnHeartbeat");
            _AREFile.SetTextBoxToNodeValue(tbArea_OnUserDefined, "OnUserDefined");
            SetupRooms();
        }

    public void UpdateFiles()
    {
            _IFOFile.SetCExoLocStringNodeValueFromTextBox(tbModName, "Mod_Name", ModNameLang);
            _IFOFile.SetNodeValue("Mod_Tag", Mod_Tag);
            _IFOFile.SetNodeValue("Mod_Entry_Area", Mod_Entry_Area);
            _IFOFile.SetNodeValue("Mod_Entry_X", Mod_Entry_X);
            _IFOFile.SetNodeValue("Mod_Entry_Y", Mod_Entry_Y);
            _IFOFile.SetNodeValue("Mod_Entry_Z", Mod_Entry_Z);
            _IFOFile.SetNodeValue("Mod_Entry_Dir_X", XOrientation);
            _IFOFile.SetNodeValue("Mod_Entry_Dir_Y", YOrientation);
            _IFOFile.SetNodeValue("Mod_MinPerHour", Mod_MinutesPerHour);
            _IFOFile.SetNodeValue("Mod_DawnHour", Mod_DawnHour);
            _IFOFile.SetNodeValue("Mod_DuskHour", Mod_DuskHour);
            _IFOFile.SetNodeValue("Mod_StartHour", Mod_StartHour);
            _IFOFile.SetNodeValue("Mod_StartDay", Mod_StartDay);
            _IFOFile.SetNodeValue("Mod_StartMonth", Mod_StartMonth);
            _IFOFile.SetNodeValue("Mod_StartYear", Mod_StartYear);
            _IFOFile.SetNodeValue("Mod_XPScale", Mod_XPScale);
            _IFOFile.SetNodeValue("Mod_OnAcquirItem", Mod_OnAcquirItem);
            _IFOFile.SetNodeValue("Mod_OnActvtItem", Mod_OnActvtItem);
            _IFOFile.SetNodeValue("Mod_OnClientEntr", Mod_OnClientEntr);
            _IFOFile.SetNodeValue("Mod_OnClientLeav", Mod_OnClientLeav);
            _IFOFile.SetNodeValue("Mod_OnHeartbeat", Mod_OnHeartbeat);
            _IFOFile.SetNodeValue("Mod_OnModLoad", Mod_OnModLoad);
            _IFOFile.SetNodeValue("Mod_OnPlrDeath", Mod_OnPlrDeath);
            _IFOFile.SetNodeValue("Mod_OnPlrDying", Mod_OnPlrDying);
            _IFOFile.SetNodeValue("Mod_OnPlrLvlUp", Mod_OnPlrLvlUp);
            _IFOFile.SetNodeValue("Mod_OnSpawnBtnDn", Mod_OnSpawnBtnDn);
            _IFOFile.SetNodeValue("Mod_OnPlrRest", Mod_OnPlrRest);
            _IFOFile.SetNodeValue("Mod_OnUnAqreItem", Mod_OnUnAqreItem);
            _IFOFile.SetNodeValue("Mod_OnUsrDefined", Mod_OnUsrDefined);
            _IFOFile.SetCExoLocStringNodeValueFromTextBox(tbModDescription, "Mod_Description", ModDescriptionLang);
            _AREFile.SetNodeValueFromTextBox(tbAreaTag, "Tag");
            _AREFile.SetCExoLocStringNodeValueFromTextBox(tbAreaName, "Name", AreaNameLang);
            _AREFile.SetNodeValueFromComboBox(cmbxCameraStyle, "CameraStyle");
            _AREFile.SetNodeValue("Unescapable", chkbUnescapable.Checked);
            _AREFile.SetNodeValue("DisableTransit", chkbDisableTransit.Checked);
            _AREFile.SetNodeValue("DayNightCycle", rbDayNightCycle.Checked);
            _AREFile.SetNodeValue("IsNight", rbAlwaysNight.Checked);
            _AREFile.SetNodeValueFromNumericUpDown(nudShadowOpacity, "ShadowOpacity");
            _AREFile.SetNodeValue("DynAmbientColor", DynAmbientColor);
            _AREFile.SetNodeValue("SunAmbientColor", SunAmbientColor);
            _AREFile.SetNodeValue("SunDiffuseColor", SunDiffuseColor);
            _AREFile.SetNodeValue("SunFogColor", SunFogColor);
            _AREFile.SetNodeValue("SunFogOn", chkbSunFogOn.Checked);
            _AREFile.SetNodeValue("SunFogNear", trkbarSunFogNear.Value);
            _AREFile.SetNodeValue("SunFogFar", trkbarSunFogFar.Value);
            _AREFile.SetNodeValue("SunShadows", chkbAreaSunShadows.Checked);
            _AREFile.SetNodeValue("MoonAmbientColor", MoonAmbientColor);
            _AREFile.SetNodeValue("MoonDiffuseColor", MoonDiffuseColor);
            _AREFile.SetNodeValue("MoonFogColor", MoonFogColor);
            _AREFile.SetNodeValue("MoonFogOn", chkbMoonFogOn.Checked);
            _AREFile.SetNodeValue("MoonFogNear", trkbarMoonFogNear.Value);
            _AREFile.SetNodeValue("MoonFogFar", trkbarMoonFogFar.Value);
            _AREFile.SetNodeValue("MoonShadows", chkbAreaMoonShadows.Checked);
            _AREFile.SetNodeValueFromNumericUpDown(nudChanceSnow, "ChanceSnow");
            _AREFile.SetNodeValueFromNumericUpDown(nudChanceRain, "ChanceRain");
            _AREFile.SetNodeValueFromNumericUpDown(nudChanceLightning, "ChanceLightning");
            _AREFile.SetNodeValueFromTextBox(tbGrass_TexName, "Grass_TexName");
            _AREFile.SetNodeValue("Grass_Ambient", Grass_Ambient);
            _AREFile.SetNodeValue("Grass_Diffuse", Grass_Diffuse);
            _AREFile.SetNodeValue("Grass_Emissive", Grass_Emissive);
            _AREFile.SetNodeValueFromNumericUpDown(nudGrassDensity, "Grass_Density");
            _AREFile.SetNodeValueFromNumericUpDown(nudGrassQuadSize, "Grass_QuadSize");
            _AREFile.SetNodeValue("Grass_Prob_LL", Grass_Prob_LL);
            _AREFile.SetNodeValue("Grass_Prob_UL", Grass_Prob_UL);
            _AREFile.SetNodeValue("Grass_Prob_LR", Grass_Prob_LR);
            _AREFile.SetNodeValue("Grass_Prob_UR", Grass_Prob_UR);
            _AREFile.SetNodeValueFromTextBox(tbArea_OnEnter, "OnEnter");
            _AREFile.SetNodeValueFromTextBox(tbArea_OnExit, "OnExit");
            _AREFile.SetNodeValueFromTextBox(tbArea_OnHeartbeat, "OnHeartbeat");
            _AREFile.SetNodeValueFromTextBox(tbArea_OnUserDefined, "OnUserDefined");
            _GITFile.SetNodeValueFromComboBox(cmbxAmbientSndDay, "AreaProperties.AmbientSndDay");
            _GITFile.SetNodeValueFromComboBox(cmbxAmbientSndNight, "AreaProperties.AmbientSndNight");
            _GITFile.SetNodeValue("AreaProperties.AmbientSndDayVol", trkbarAmbientSndDayVol.Value);
            _GITFile.SetNodeValue("AreaProperties.AmbientSndNitVol", trkbarAmbientSndNightVol.Value);
            _GITFile.SetNodeValueFromComboBox(cmbxEnvAudio, "AreaProperties.EnvAudio");
            _GITFile.SetNodeValueFromComboBox(cmbxMusicBattle, "AreaProperties.MusicBattle");
            _GITFile.SetNodeValueFromComboBox(cmbxMusicDay, "AreaProperties.MusicDay");
            _GITFile.SetNodeValueFromComboBox(cmbxMusicNight, "AreaProperties.MusicNight");
            _GITFile.SetNodeValue("AreaProperties.MusicDelay", Decimal.Multiply(nudMusicDelay.Value, 1000M));
            ReadRooms();
        }

    private uint color2bgr(Color col) => Convert.ToUInt32(checked(col.B * 65536 + col.G * 256 + col.R));

    private Color bgr2color(uint bgr)
    {
            var int32 = Convert.ToInt32(bgr);
            return Color.FromArgb(byte.MaxValue, int32 & byte.MaxValue, (int32 & 65280) >> 8, (int32 & 16711680) >> 16);
        }

    public Cls2Da ReadCls2DA(string TwoDAName, ChitinKey ChitinKey)
    {
            var flag = true;
            var numArray = new byte[] { };
            if (CurrentSettings.bUseOverrideFiles)
            {
                var path = CurrentSettings.KotorLocation(KotorVersionIndex) + "\\override\\" + TwoDAName + ".2da";
                try
                {
                    if (File.Exists(path))
                    {
                        var fileStream = new FileStream(path, FileMode.Open);
                        numArray = new byte[checked((int)fileStream.Length + 1)];
                        fileStream.Read(numArray, 0, checked((int)fileStream.Length));
                        fileStream.Close();
                        flag = false;
                        Console.WriteLine("Read " + TwoDAName + ".2da from override");
                    }
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Console.WriteLine("Could not load " + path + " in " + GetType().Name);
                    ProjectData.ClearProjectError();
                }
            }

            if (flag)
            {
                var resIdForResRef = ChitinKey.FindResIdForResRef(TwoDAName, 2017);
                numArray = BIFFArchive
                    .GetBIFFResource(
                        CurrentSettings.KotorLocation(KotorVersionIndex) + "\\" +
                        ChitinKey.BiffList[resIdForResRef >> 20].Filename, resIdForResRef).Data;
                Console.WriteLine("Read " + TwoDAName + ".2da from 2da.bif");
            }

            return new Cls2Da(numArray);
        }

    private void FillComboBoxFrom2DA(
        ComboBox cmbx,
        string colName,
        string TwoDAName,
        ChitinKey ChitinKey,
        clsDialogTlk DialogTlk)
    {
            var cls2Da = ReadCls2DA(TwoDAName, ChitinKey);
            if (DialogTlk != null)
            {
                var rowsUpperBound = cls2Da.RowsUpperBound;
                var rowNumber = 0;
                while (rowNumber <= rowsUpperBound)
                {
                    object indiceData = cls2Da.GetIndiceData(rowNumber, colName);
                    if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)))
                        cmbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData)));
                    else
                        cmbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData));
                    checked
                    {
                        ++rowNumber;
                    }
                }
            }
            else
            {
                var rowsUpperBound = cls2Da.RowsUpperBound;
                var rowNumber = 0;
                while (rowNumber <= rowsUpperBound)
                {
                    cmbx.Items.Add(cls2Da.GetIndiceData(rowNumber, colName));
                    checked
                    {
                        ++rowNumber;
                    }
                }
            }
        }

    public void SetupOrientationIndicators()
    {
            var num = (float)Math.Atan2(_YOrientation, _XOrientation);
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
            var graphics = Graphics.FromImage(bmpXY);
            graphics.FillEllipse(Brushes.White, 0, 0, 49, 49);
            graphics.DrawArc(new Pen(Color.Black), 0, 0, 49, 49, 0, 360);
            graphics.DrawPie(new Pen(Color.Black), 0.0f, 0.0f, 49f, 49f, (float)_XYAngle, 1f);
            bmpXY.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pboxXY.Image = bmpXY;
        }

    private void nudXY_KeyUp(object sender, KeyEventArgs e)
    {
            _XYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, null, "value", new object[0], null, null));
            DrawXYOrientation();
            _XOrientation = -(float)Math.Round(Math.Cos((_XYAngle + 90.0) / 180.0 * Math.PI), 5);
            _YOrientation = (float)Math.Round(Math.Sin((_XYAngle + 90.0) / 180.0 * Math.PI), 5);
        }

    private void nudXY_ValueChanged(object sender, EventArgs e)
    {
            _XYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, null, "value", new object[0], null, null));
            DrawXYOrientation();
            _XOrientation = -(float)Math.Round(Math.Cos((_XYAngle + 90.0) / 180.0 * Math.PI), 5);
            _YOrientation = (float)Math.Round(Math.Sin((_XYAngle + 90.0) / 180.0 * Math.PI), 5);
        }

    private void SetColor_Click(object sender, EventArgs e)
    {
            var colorDialog1 = ColorDialog1;
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;
            colorDialog1.Color = ((Control)sender).BackColor;
            colorDialog1.FullOpen = true;
            if (ColorDialog1.ShowDialog(this) != DialogResult.OK)
                return;
            ((Control)sender).BackColor = ColorDialog1.Color;
        }

    private void trkbarXPScale_Scroll(object sender, EventArgs e) =>
        nudXPScale.Value = new Decimal(((TrackBar)sender).Value);

    private void nudXPScale_ValueChanged(object sender, EventArgs e) =>
        trkbarXPScale.Value = Convert.ToInt32(((NumericUpDown)sender).Value);

    private void trkbarGrassDensityX10_Scroll(object sender, EventArgs e) =>
        nudGrassDensity.Value = new Decimal(((TrackBar)sender).Value / 10.0);

    private void nudGrassDensity_ValueChanged(object sender, EventArgs e) => trkbarGrassDensityX10.Value =
        Convert.ToInt32(Decimal.Multiply(((NumericUpDown)sender).Value, 10M));

    private void nudGrassProbXX_ValueChanged(object sender, EventArgs e)
    {
            var single = Convert.ToSingle(Decimal.Add(
                Decimal.Add(Decimal.Add(nudGrassProbLL.Value, nudGrassProbUL.Value), nudGrassProbLR.Value),
                nudGrassProbUR.Value));
            lblTotalGrassProbability.Text = "Total: " + StringType.FromSingle(single) + "%";
            if (single > 100.0 | single < 100.0)
                lblTotalGrassProbability.BackColor = Color.Tomato;
            else
                lblTotalGrassProbability.BackColor = DefaultBackColor;
        }

    private void DayNight_CheckedChanged(object sender, EventArgs e)
    {
            if (rbDayNightCycle.Checked)
            {
                gbMoon.Enabled = true;
                gbSun.Enabled = true;
            }
            else if (rbAlwaysNight.Checked)
            {
                gbMoon.Enabled = true;
                gbSun.Enabled = false;
            }
            else
            {
                gbMoon.Enabled = false;
                gbSun.Enabled = true;
            }
        }

    private void SunFogEnabled(object sender, EventArgs e)
    {
            trkbarSunFogNear.Enabled = chkbSunFogOn.Checked;
            trkbarSunFogFar.Enabled = chkbSunFogOn.Checked;
            lblSunFogFar.Enabled = chkbSunFogOn.Checked;
            lblSunFogNear.Enabled = chkbSunFogOn.Checked;
        }

    private void MoonFogEnabled(object sender, EventArgs e)
    {
            trkbarMoonFogNear.Enabled = chkbMoonFogOn.Checked;
            trkbarMoonFogFar.Enabled = chkbMoonFogOn.Checked;
            lblMoonFogFar.Enabled = chkbMoonFogOn.Checked;
            lblMoonFogNear.Enabled = chkbMoonFogOn.Checked;
        }

    private void lbRooms_SelectedIndexChanged(object sender, EventArgs e)
    {
            if (lbRooms.SelectedIndex == -1)
                return;
            var selectedItem = (Room)lbRooms.SelectedItem;
            cmbxRoomEnvAudio.SelectedIndexChanged -= new EventHandler(cmbxRoomEnvAudio_SelectedIndexChanged);
            nudRoomAmbientScale.ValueChanged -= new EventHandler(nudRoomAmbientScale_ValueChanged);
            nudRoomForceRating.ValueChanged -= new EventHandler(nudRoomForceRating_ValueChanged);
            chkbRoomDisableWeather.CheckedChanged -= new EventHandler(chkbRoomDisableWeather_CheckedChanged);
            tbRoomName.Text = selectedItem.RoomName;
            nudRoomAmbientScale.Value = new Decimal(selectedItem.AmbientScale);
            nudRoomForceRating.Value = new Decimal(selectedItem.ForceRating);
            chkbRoomDisableWeather.Checked = selectedItem.DisableWeather;
            cmbxRoomEnvAudio.SelectedIndex = selectedItem.EnvAudio;
            cmbxRoomEnvAudio.SelectedIndexChanged += new EventHandler(cmbxRoomEnvAudio_SelectedIndexChanged);
            nudRoomAmbientScale.ValueChanged += new EventHandler(nudRoomAmbientScale_ValueChanged);
            nudRoomForceRating.ValueChanged += new EventHandler(nudRoomForceRating_ValueChanged);
            chkbRoomDisableWeather.CheckedChanged += new EventHandler(chkbRoomDisableWeather_CheckedChanged);
        }

    private void cmbxRoomEnvAudio_SelectedIndexChanged(object sender, EventArgs e) =>
        Rooms[lbRooms.SelectedIndex].EnvAudio = cmbxRoomEnvAudio.SelectedIndex;

    private void nudRoomAmbientScale_ValueChanged(object sender, EventArgs e) =>
        Rooms[lbRooms.SelectedIndex].AmbientScale = Convert.ToSingle(nudRoomAmbientScale.Value);

    private void nudRoomForceRating_ValueChanged(object sender, EventArgs e) =>
        Rooms[lbRooms.SelectedIndex].ForceRating = Convert.ToInt32(nudRoomForceRating.Value);

    private void chkbRoomDisableWeather_CheckedChanged(object sender, EventArgs e) =>
        Rooms[lbRooms.SelectedIndex].DisableWeather = chkbRoomDisableWeather.Checked;

    private void btnSetDescriptionLang_Click(object sender, EventArgs e)
    {
            var stringLanguagePicker = new frmCExoLocStringLanguagePicker(ModDescriptionLang);
            if (stringLanguagePicker.ShowDialog(this) != DialogResult.OK)
                return;
            ModDescriptionLang = stringLanguagePicker.LanguageID;
        }

    private void btnSetModNameLang_Click(object sender, EventArgs e)
    {
            var stringLanguagePicker = new frmCExoLocStringLanguagePicker(ModNameLang);
            if (stringLanguagePicker.ShowDialog(this) != DialogResult.OK)
                return;
            ModNameLang = stringLanguagePicker.LanguageID;
        }

    private void btnSetAreaNameLang_Click(object sender, EventArgs e)
    {
            var stringLanguagePicker = new frmCExoLocStringLanguagePicker(AreaNameLang);
            if (stringLanguagePicker.ShowDialog(this) != DialogResult.OK)
                return;
            AreaNameLang = stringLanguagePicker.LanguageID;
        }

    public string Mod_Tag
    {
        get => tbModTag.Text.Trim();
        set => tbModTag.Text = value;
    }

    public string Mod_Entry_Area
    {
        get => tbModEntryArea.Text.Trim();
        set => tbModEntryArea.Text = value;
    }

    public string Mod_Name
    {
        get => tbModName.Text.Trim();
        set => tbModName.Text = value;
    }

    public float Mod_Entry_X
    {
        get => Convert.ToSingle(nudModEntryX.Value);
        set => nudModEntryX.Value = new Decimal(value);
    }

    public float Mod_Entry_Y
    {
        get => Convert.ToSingle(nudModEntryY.Value);
        set => nudModEntryY.Value = new Decimal(value);
    }

    public float Mod_Entry_Z
    {
        get => Convert.ToSingle(nudModEntryZ.Value);
        set => nudModEntryZ.Value = new Decimal(value);
    }

    private float XOrientation
    {
        get => _XOrientation;
        set => _XOrientation = value;
    }

    private float YOrientation
    {
        get => _YOrientation;
        set => _YOrientation = value;
    }

    public int Mod_MinutesPerHour
    {
        get => Convert.ToInt32(nudMinutesPerHour.Value);
        set => nudMinutesPerHour.Value = new Decimal(value);
    }

    public int Mod_DawnHour
    {
        get => Convert.ToInt32(nudDawnStartHour.Value);
        set => nudDawnStartHour.Value = new Decimal(value);
    }

    public int Mod_DuskHour
    {
        get => Convert.ToInt32(nudDuskStartHour.Value);
        set => nudDuskStartHour.Value = new Decimal(value);
    }

    public int Mod_StartHour
    {
        get => Convert.ToInt32(nudStartHour.Value);
        set => nudStartHour.Value = new Decimal(value);
    }

    public int Mod_StartDay
    {
        get => Convert.ToInt32(nudStartDay.Value);
        set => nudStartDay.Value = new Decimal(value);
    }

    public int Mod_StartMonth
    {
        get => Convert.ToInt32(nudStartMonth.Value);
        set => nudStartMonth.Value = new Decimal(value);
    }

    public int Mod_StartYear
    {
        get => Convert.ToInt32(nudStartYear.Value);
        set => nudStartYear.Value = new Decimal(value);
    }

    public int Mod_XPScale
    {
        get => Convert.ToInt32(nudXPScale.Value);
        set => nudXPScale.Value = new Decimal(value);
    }

    public string Mod_OnAcquirItem
    {
        get => tbMod_OnAcquirItem.Text.Trim();
        set => tbMod_OnAcquirItem.Text = value;
    }

    public string Mod_OnActvtItem
    {
        get => tbMod_OnActvtItem.Text.Trim();
        set => tbMod_OnActvtItem.Text = value;
    }

    public string Mod_OnClientEntr
    {
        get => tbMod_OnClientEntr.Text.Trim();
        set => tbMod_OnClientEntr.Text = value;
    }

    public string Mod_OnClientLeav
    {
        get => tbMod_OnClientLeav.Text.Trim();
        set => tbMod_OnClientLeav.Text = value;
    }

    public string Mod_OnHeartbeat
    {
        get => tbMod_OnHeartbeat.Text.Trim();
        set => tbMod_OnHeartbeat.Text = value;
    }

    public string Mod_OnModLoad
    {
        get => tbMod_OnModLoad.Text.Trim();
        set => tbMod_OnModLoad.Text = value;
    }

    public string Mod_OnPlrDeath
    {
        get => tbMod_OnPlrDeath.Text.Trim();
        set => tbMod_OnPlrDeath.Text = value;
    }

    public string Mod_OnPlrDying
    {
        get => tbMod_OnPlrDying.Text.Trim();
        set => tbMod_OnPlrDying.Text = value;
    }

    public string Mod_OnPlrLvlUp
    {
        get => tbMod_OnPlrLvlUp.Text.Trim();
        set => tbMod_OnPlrLvlUp.Text = value;
    }

    public string Mod_OnSpawnBtnDn
    {
        get => tbMod_OnSpawnBtnDn.Text.Trim();
        set => tbMod_OnSpawnBtnDn.Text = value;
    }

    public string Mod_OnPlrRest
    {
        get => tbMod_OnPlrRest.Text.Trim();
        set => tbMod_OnPlrRest.Text = value;
    }

    public string Mod_OnUnAqreItem
    {
        get => tbMod_OnUnAqreItem.Text.Trim();
        set => tbMod_OnUnAqreItem.Text = value;
    }

    public string Mod_OnUsrDefined
    {
        get => tbMod_OnUsrDefined.Text.Trim();
        set => tbMod_OnUsrDefined.Text = value;
    }

    public uint DynAmbientColor
    {
        get => color2bgr(btnDynAmbientColor.BackColor);
        set => btnDynAmbientColor.BackColor = bgr2color(value);
    }

    public uint SunAmbientColor
    {
        get => color2bgr(btnSunAmbientColor.BackColor);
        set => btnSunAmbientColor.BackColor = bgr2color(value);
    }

    public uint SunDiffuseColor
    {
        get => color2bgr(btnSunDiffuseColor.BackColor);
        set => btnSunDiffuseColor.BackColor = bgr2color(value);
    }

    public uint SunFogColor
    {
        get => color2bgr(btnSunFogColor.BackColor);
        set => btnSunFogColor.BackColor = bgr2color(value);
    }

    public uint MoonAmbientColor
    {
        get => color2bgr(btnMoonAmbientColor.BackColor);
        set => btnMoonAmbientColor.BackColor = bgr2color(value);
    }

    public uint MoonDiffuseColor
    {
        get => color2bgr(btnMoonDiffuseColor.BackColor);
        set => btnMoonDiffuseColor.BackColor = bgr2color(value);
    }

    public uint MoonFogColor
    {
        get => color2bgr(btnMoonFogColor.BackColor);
        set => btnMoonFogColor.BackColor = bgr2color(value);
    }

    public uint Grass_Ambient
    {
        get => color2bgr(btnGrassAmbientColor.BackColor);
        set => btnGrassAmbientColor.BackColor = bgr2color(value);
    }

    public uint Grass_Diffuse
    {
        get => color2bgr(btnGrassDiffuseColor.BackColor);
        set => btnGrassDiffuseColor.BackColor = bgr2color(value);
    }

    public uint Grass_Emissive
    {
        get => color2bgr(btnGrassEmissiveColor.BackColor);
        set => btnGrassEmissiveColor.BackColor = bgr2color(value);
    }

    public float Grass_Prob_LL
    {
        get => Convert.ToSingle(Decimal.Divide(nudGrassProbLL.Value, 100M));
        set => nudGrassProbLL.Value = new Decimal(value * 100f);
    }

    public float Grass_Prob_UL
    {
        get => Convert.ToSingle(Decimal.Divide(nudGrassProbUL.Value, 100M));
        set => nudGrassProbUL.Value = new Decimal(value * 100f);
    }

    public float Grass_Prob_LR
    {
        get => Convert.ToSingle(Decimal.Divide(nudGrassProbLR.Value, 100M));
        set => nudGrassProbLR.Value = new Decimal(value * 100f);
    }

    public float Grass_Prob_UR
    {
        get => Convert.ToSingle(Decimal.Divide(nudGrassProbUR.Value, 100M));
        set => nudGrassProbUR.Value = new Decimal(value * 100f);
    }

    public bool ModEntryChanged => _origXOrientation != (double)_XOrientation ||
                                   _origYOrientation != (double)_YOrientation || _origXPos != (double)Mod_Entry_X ||
                                   _origYpos != (double)Mod_Entry_Y || _origZpos != (double)Mod_Entry_Z;

    private class Room
    {
        public string RoomName;
        public int EnvAudio;
        public int ForceRating;
        public float AmbientScale;
        public bool DisableWeather;

        public string Text => RoomName;
    }
}