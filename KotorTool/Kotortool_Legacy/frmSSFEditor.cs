// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmSSFEditor
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

public class frmSSFEditor : frmParent
{
    [AccessedThroughProperty("TextBox30")] private TextBox _TextBox30;
    [AccessedThroughProperty("TextBox41")] private TextBox _TextBox41;
    [AccessedThroughProperty("TextBox40")] private TextBox _TextBox40;
    [AccessedThroughProperty("TextBox39")] private TextBox _TextBox39;
    [AccessedThroughProperty("nudDMin")] private NumericUpDown _nudDMin;
    [AccessedThroughProperty("nudLMin")] private NumericUpDown _nudLMin;
    [AccessedThroughProperty("nudTIA")] private NumericUpDown _nudTIA;
    [AccessedThroughProperty("nudCrit")] private NumericUpDown _nudCrit;
    [AccessedThroughProperty("miSave")] private ToolStripMenuItem _miSave;

    [AccessedThroughProperty("nudLowHlth")]
    private NumericUpDown _nudLowHlth;

    [AccessedThroughProperty("miOpen")] private ToolStripMenuItem _miOpen;
    [AccessedThroughProperty("nudDead")] private NumericUpDown _nudDead;
    [AccessedThroughProperty("nudHit1")] private NumericUpDown _nudHit1;
    [AccessedThroughProperty("Label2")] private Label _Label2;
    [AccessedThroughProperty("nudHit2")] private NumericUpDown _nudHit2;
    [AccessedThroughProperty("nudAtk3")] private NumericUpDown _nudAtk3;
    [AccessedThroughProperty("nudAtk1")] private NumericUpDown _nudAtk1;
    [AccessedThroughProperty("nudAtk2")] private NumericUpDown _nudAtk2;
    [AccessedThroughProperty("nudSel2")] private NumericUpDown _nudSel2;
    [AccessedThroughProperty("nudSel3")] private NumericUpDown _nudSel3;
    [AccessedThroughProperty("nudSel1")] private NumericUpDown _nudSel1;
    [AccessedThroughProperty("TextBox43")] private TextBox _TextBox43;
    [AccessedThroughProperty("nudBat6")] private NumericUpDown _nudBat6;
    [AccessedThroughProperty("Label25")] private Label _Label25;
    [AccessedThroughProperty("nudBat5")] private NumericUpDown _nudBat5;
    [AccessedThroughProperty("Label28")] private Label _Label28;
    [AccessedThroughProperty("Label6")] private Label _Label6;
    [AccessedThroughProperty("nudBat4")] private NumericUpDown _nudBat4;
    [AccessedThroughProperty("nudBat3")] private NumericUpDown _nudBat3;
    [AccessedThroughProperty("nudBat2")] private NumericUpDown _nudBat2;
    [AccessedThroughProperty("TextBox38")] private TextBox _TextBox38;
    [AccessedThroughProperty("TextBox37")] private TextBox _TextBox37;
    [AccessedThroughProperty("TextBox36")] private TextBox _TextBox36;
    [AccessedThroughProperty("Label26")] private Label _Label26;
    [AccessedThroughProperty("TextBox35")] private TextBox _TextBox35;
    [AccessedThroughProperty("TextBox44")] private TextBox _TextBox44;
    [AccessedThroughProperty("TextBox34")] private TextBox _TextBox34;
    [AccessedThroughProperty("TextBox33")] private TextBox _TextBox33;
    [AccessedThroughProperty("TextBox32")] private TextBox _TextBox32;
    [AccessedThroughProperty("TextBox31")] private TextBox _TextBox31;
    [AccessedThroughProperty("TextBox29")] private TextBox _TextBox29;
    [AccessedThroughProperty("TextBox28")] private TextBox _TextBox28;
    [AccessedThroughProperty("Label7")] private Label _Label7;
    [AccessedThroughProperty("TextBox27")] private TextBox _TextBox27;
    [AccessedThroughProperty("TextBox26")] private TextBox _TextBox26;
    [AccessedThroughProperty("TextBox25")] private TextBox _TextBox25;
    [AccessedThroughProperty("TextBox45")] private TextBox _TextBox45;
    [AccessedThroughProperty("miNew")] private ToolStripMenuItem _miNew;
    [AccessedThroughProperty("TextBox24")] private TextBox _TextBox24;
    [AccessedThroughProperty("TextBox23")] private TextBox _TextBox23;
    [AccessedThroughProperty("TextBox22")] private TextBox _TextBox22;
    [AccessedThroughProperty("TextBox46")] private TextBox _TextBox46;
    [AccessedThroughProperty("TextBox21")] private TextBox _TextBox21;
    [AccessedThroughProperty("TextBox47")] private TextBox _TextBox47;
    [AccessedThroughProperty("Label24")] private Label _Label24;
    [AccessedThroughProperty("Label8")] private Label _Label8;
    [AccessedThroughProperty("TextBox20")] private TextBox _TextBox20;
    [AccessedThroughProperty("Label23")] private Label _Label23;
    [AccessedThroughProperty("TextBox48")] private TextBox _TextBox48;
    [AccessedThroughProperty("TextBox49")] private TextBox _TextBox49;
    [AccessedThroughProperty("TextBox50")] private TextBox _TextBox50;
    [AccessedThroughProperty("TextBox19")] private TextBox _TextBox19;
    [AccessedThroughProperty("Label22")] private Label _Label22;
    [AccessedThroughProperty("TextBox18")] private TextBox _TextBox18;
    [AccessedThroughProperty("TextBox51")] private TextBox _TextBox51;
    [AccessedThroughProperty("Label21")] private Label _Label21;
    [AccessedThroughProperty("TextBox52")] private TextBox _TextBox52;
    [AccessedThroughProperty("TextBox53")] private TextBox _TextBox53;
    [AccessedThroughProperty("Label9")] private Label _Label9;
    [AccessedThroughProperty("TextBox54")] private TextBox _TextBox54;
    [AccessedThroughProperty("Label1")] private Label _Label1;
    [AccessedThroughProperty("nudStlh")] private NumericUpDown _nudStlh;
    [AccessedThroughProperty("nudSrch")] private NumericUpDown _nudSrch;
    [AccessedThroughProperty("Label3")] private Label _Label3;

    [AccessedThroughProperty("nudTryUnlock")]
    private NumericUpDown _nudTryUnlock;

    [AccessedThroughProperty("nudFailUnlock")]
    private NumericUpDown _nudFailUnlock;

    [AccessedThroughProperty("Label4")] private Label _Label4;

    [AccessedThroughProperty("nudSucceedUnlock")]
    private NumericUpDown _nudSucceedUnlock;

    [AccessedThroughProperty("Label5")] private Label _Label5;

    [AccessedThroughProperty("nudLeaveParty")]
    private NumericUpDown _nudLeaveParty;

    [AccessedThroughProperty("nudRejoinParty")]
    private NumericUpDown _nudRejoinParty;

    [AccessedThroughProperty("Label10")] private Label _Label10;

    [AccessedThroughProperty("nudPoisoned")]
    private NumericUpDown _nudPoisoned;

    [AccessedThroughProperty("label111")] private Label _label111;
    [AccessedThroughProperty("miSaveAs")] private ToolStripMenuItem _miSaveAs;
    [AccessedThroughProperty("TextBox1")] private TextBox _TextBox1;

    [AccessedThroughProperty("miUseK1DialogTlk")]
    private ToolStripMenuItem _miUseK1DialogTlk;

    [AccessedThroughProperty("miUseK2DialogTlk")]
    private ToolStripMenuItem _miUseK2DialogTlk;

    [AccessedThroughProperty("miUseExtDialogTlk")]
    private ToolStripMenuItem _miUseExtDialogTlk;

    [AccessedThroughProperty("TextBox17")] private TextBox _TextBox17;

    [AccessedThroughProperty("miAskDialogTlk")]
    private ToolStripMenuItem _miAskDialogTlk;

    [AccessedThroughProperty("nudBat1")] private NumericUpDown _nudBat1;
    [AccessedThroughProperty("Label11")] private Label _Label11;

    [AccessedThroughProperty("tbBat1ResRef")]
    private TextBox _tbBat1ResRef;

    [AccessedThroughProperty("tbBat1Desc")]
    private TextBox _tbBat1Desc;

    [AccessedThroughProperty("TextBox2")] private TextBox _TextBox2;
    [AccessedThroughProperty("TextBox3")] private TextBox _TextBox3;
    [AccessedThroughProperty("TextBox4")] private TextBox _TextBox4;
    [AccessedThroughProperty("Label12")] private Label _Label12;
    [AccessedThroughProperty("MainMenu1")] private MainMenu _MainMenu1;

    [AccessedThroughProperty("StatusBar1")]
    private StatusBar _StatusBar1;

    [AccessedThroughProperty("TextBox5")] private TextBox _TextBox5;
    [AccessedThroughProperty("TextBox6")] private TextBox _TextBox6;
    [AccessedThroughProperty("TextBox7")] private TextBox _TextBox7;
    [AccessedThroughProperty("TextBox8")] private TextBox _TextBox8;
    [AccessedThroughProperty("TextBox9")] private TextBox _TextBox9;
    [AccessedThroughProperty("Label13")] private Label _Label13;
    [AccessedThroughProperty("ToolStripMenuItem1")] private ToolStripMenuItem _ToolStripMenuItem1;
    [AccessedThroughProperty("ToolTip1")] private ToolTip _ToolTip1;
    [AccessedThroughProperty("Label20")] private Label _Label20;
    [AccessedThroughProperty("TextBox10")] private TextBox _TextBox10;
    [AccessedThroughProperty("Label14")] private Label _Label14;
    [AccessedThroughProperty("TextBox11")] private TextBox _TextBox11;
    [AccessedThroughProperty("Label15")] private Label _Label15;
    [AccessedThroughProperty("TextBox16")] private TextBox _TextBox16;
    [AccessedThroughProperty("TextBox12")] private TextBox _TextBox12;
    [AccessedThroughProperty("ToolStripMenuItem2")] private ToolStripMenuItem _ToolStripMenuItem2;
    [AccessedThroughProperty("Label16")] private Label _Label16;
    [AccessedThroughProperty("TextBox13")] private TextBox _TextBox13;
    [AccessedThroughProperty("Label17")] private Label _Label17;
    [AccessedThroughProperty("miQuit")] private ToolStripMenuItem _miQuit;
    [AccessedThroughProperty("Panel1")] private Panel _Panel1;
    [AccessedThroughProperty("TextBox14")] private TextBox _TextBox14;
    [AccessedThroughProperty("Label18")] private Label _Label18;
    [AccessedThroughProperty("ToolStripMenuItem5")] private ToolStripMenuItem _ToolStripMenuItem5;
    [AccessedThroughProperty("TextBox15")] private TextBox _TextBox15;
    [AccessedThroughProperty("Label19")] private Label _Label19;
    [AccessedThroughProperty("TextBox42")] private TextBox _TextBox42;
    private ClsSsf _SSF;
    private clsDialogTlk g_dialogtlk;
    private string g_filepath;
    private IContainer components;

    public frmSSFEditor()
    {
            Load += new EventHandler(frmSSFEditor_Load);
            InitializeComponent();
            CurrentSettings = UserSettings.GetSettings();
            KotorVersionIndex = -1;
        }

    protected override void Dispose(bool disposing)
    {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

    internal virtual NumericUpDown nudBat1
    {
        get => _nudBat1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudBat1 == null)
                    ;
                _nudBat1 = value;
                if (_nudBat1 == null)
                    ;
            }
    }

    internal virtual TextBox tbBat1ResRef
    {
        get => _tbBat1ResRef;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbBat1ResRef == null)
                    ;
                _tbBat1ResRef = value;
                if (_tbBat1ResRef == null)
                    ;
            }
    }

    internal virtual TextBox tbBat1Desc
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_tbBat1Desc == null)
                    ;
                _tbBat1Desc = value;
                if (_tbBat1Desc == null)
                    ;
            }
        get => _tbBat1Desc;
    }

    internal virtual Label Label1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label1 == null)
                    ;
                _Label1 = value;
                if (_Label1 == null)
                    ;
            }
        get => _Label1;
    }

    internal virtual TextBox TextBox1
    {
        get => _TextBox1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox1 == null)
                    ;
                _TextBox1 = value;
                if (_TextBox1 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox2
    {
        get => _TextBox2;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox2 == null)
                    ;
                _TextBox2 = value;
                if (_TextBox2 == null)
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

    internal virtual TextBox TextBox3
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox3 == null)
                    ;
                _TextBox3 = value;
                if (_TextBox3 == null)
                    ;
            }
        get => _TextBox3;
    }

    internal virtual TextBox TextBox4
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox4 == null)
                    ;
                _TextBox4 = value;
                if (_TextBox4 == null)
                    ;
            }
        get => _TextBox4;
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

    internal virtual TextBox TextBox5
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox5 == null)
                    ;
                _TextBox5 = value;
                if (_TextBox5 == null)
                    ;
            }
        get => _TextBox5;
    }

    internal virtual TextBox TextBox6
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox6 == null)
                    ;
                _TextBox6 = value;
                if (_TextBox6 == null)
                    ;
            }
        get => _TextBox6;
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

    internal virtual Panel Panel1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Panel1 == null)
                    ;
                _Panel1 = value;
                if (_Panel1 == null)
                    ;
            }
        get => _Panel1;
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

    internal virtual TextBox TextBox7
    {
        get => _TextBox7;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox7 == null)
                    ;
                _TextBox7 = value;
                if (_TextBox7 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox8
    {
        get => _TextBox8;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox8 == null)
                    ;
                _TextBox8 = value;
                if (_TextBox8 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox9
    {
        get => _TextBox9;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox9 == null)
                    ;
                _TextBox9 = value;
                if (_TextBox9 == null)
                    ;
            }
    }

    internal virtual Label Label6
    {
        get => _Label6;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label6 == null)
                    ;
                _Label6 = value;
                if (_Label6 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox10
    {
        get => _TextBox10;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox10 == null)
                    ;
                _TextBox10 = value;
                if (_TextBox10 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox11
    {
        get => _TextBox11;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox11 == null)
                    ;
                _TextBox11 = value;
                if (_TextBox11 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox12
    {
        get => _TextBox12;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox12 == null)
                    ;
                _TextBox12 = value;
                if (_TextBox12 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox13
    {
        get => _TextBox13;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox13 == null)
                    ;
                _TextBox13 = value;
                if (_TextBox13 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox14
    {
        get => _TextBox14;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox14 == null)
                    ;
                _TextBox14 = value;
                if (_TextBox14 == null)
                    ;
            }
    }

    internal virtual Label Label7
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label7 == null)
                    ;
                _Label7 = value;
                if (_Label7 == null)
                    ;
            }
        get => _Label7;
    }

    internal virtual TextBox TextBox15
    {
        get => _TextBox15;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox15 == null)
                    ;
                _TextBox15 = value;
                if (_TextBox15 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox16
    {
        get => _TextBox16;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox16 == null)
                    ;
                _TextBox16 = value;
                if (_TextBox16 == null)
                    ;
            }
    }

    internal virtual Label Label8
    {
        get => _Label8;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
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
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label9 == null)
                    ;
                _Label9 = value;
                if (_Label9 == null)
                    ;
            }
        get => _Label9;
    }

    internal virtual TextBox TextBox17
    {
        get => _TextBox17;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox17 == null)
                    ;
                _TextBox17 = value;
                if (_TextBox17 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox18
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox18 == null)
                    ;
                _TextBox18 = value;
                if (_TextBox18 == null)
                    ;
            }
        get => _TextBox18;
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
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label11 == null)
                    ;
                _Label11 = value;
                if (_Label11 == null)
                    ;
            }
        get => _Label11;
    }

    internal virtual TextBox TextBox19
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox19 == null)
                    ;
                _TextBox19 = value;
                if (_TextBox19 == null)
                    ;
            }
        get => _TextBox19;
    }

    internal virtual TextBox TextBox20
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox20 == null)
                    ;
                _TextBox20 = value;
                if (_TextBox20 == null)
                    ;
            }
        get => _TextBox20;
    }

    internal virtual TextBox TextBox21
    {
        get => _TextBox21;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox21 == null)
                    ;
                _TextBox21 = value;
                if (_TextBox21 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox22
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox22 == null)
                    ;
                _TextBox22 = value;
                if (_TextBox22 == null)
                    ;
            }
        get => _TextBox22;
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
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
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
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label14 == null)
                    ;
                _Label14 = value;
                if (_Label14 == null)
                    ;
            }
        get => _Label14;
    }

    internal virtual TextBox TextBox23
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox23 == null)
                    ;
                _TextBox23 = value;
                if (_TextBox23 == null)
                    ;
            }
        get => _TextBox23;
    }

    internal virtual TextBox TextBox24
    {
        get => _TextBox24;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox24 == null)
                    ;
                _TextBox24 = value;
                if (_TextBox24 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox25
    {
        get => _TextBox25;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox25 == null)
                    ;
                _TextBox25 = value;
                if (_TextBox25 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox26
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox26 == null)
                    ;
                _TextBox26 = value;
                if (_TextBox26 == null)
                    ;
            }
        get => _TextBox26;
    }

    internal virtual TextBox TextBox27
    {
        get => _TextBox27;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox27 == null)
                    ;
                _TextBox27 = value;
                if (_TextBox27 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox28
    {
        get => _TextBox28;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox28 == null)
                    ;
                _TextBox28 = value;
                if (_TextBox28 == null)
                    ;
            }
    }

    internal virtual Label Label15
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label15 == null)
                    ;
                _Label15 = value;
                if (_Label15 == null)
                    ;
            }
        get => _Label15;
    }

    internal virtual TextBox TextBox29
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox29 == null)
                    ;
                _TextBox29 = value;
                if (_TextBox29 == null)
                    ;
            }
        get => _TextBox29;
    }

    internal virtual TextBox TextBox30
    {
        get => _TextBox30;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox30 == null)
                    ;
                _TextBox30 = value;
                if (_TextBox30 == null)
                    ;
            }
    }

    internal virtual Label Label16
    {
        get => _Label16;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label16 == null)
                    ;
                _Label16 = value;
                if (_Label16 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox31
    {
        get => _TextBox31;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox31 == null)
                    ;
                _TextBox31 = value;
                if (_TextBox31 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox32
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox32 == null)
                    ;
                _TextBox32 = value;
                if (_TextBox32 == null)
                    ;
            }
        get => _TextBox32;
    }

    internal virtual Label Label17
    {
        get => _Label17;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label17 == null)
                    ;
                _Label17 = value;
                if (_Label17 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox33
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox33 == null)
                    ;
                _TextBox33 = value;
                if (_TextBox33 == null)
                    ;
            }
        get => _TextBox33;
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

    internal virtual TextBox TextBox34
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox34 == null)
                    ;
                _TextBox34 = value;
                if (_TextBox34 == null)
                    ;
            }
        get => _TextBox34;
    }

    internal virtual TextBox TextBox35
    {
        get => _TextBox35;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox35 == null)
                    ;
                _TextBox35 = value;
                if (_TextBox35 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox36
    {
        get => _TextBox36;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox36 == null)
                    ;
                _TextBox36 = value;
                if (_TextBox36 == null)
                    ;
            }
    }

    internal virtual Label Label19
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label19 == null)
                    ;
                _Label19 = value;
                if (_Label19 == null)
                    ;
            }
        get => _Label19;
    }

    internal virtual TextBox TextBox37
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox37 == null)
                    ;
                _TextBox37 = value;
                if (_TextBox37 == null)
                    ;
            }
        get => _TextBox37;
    }

    internal virtual Label Label20
    {
        get => _Label20;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label20 == null)
                    ;
                _Label20 = value;
                if (_Label20 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox38
    {
        get => _TextBox38;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox38 == null)
                    ;
                _TextBox38 = value;
                if (_TextBox38 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudBat2
    {
        get => _nudBat2;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudBat2 == null)
                    ;
                _nudBat2 = value;
                if (_nudBat2 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudBat3
    {
        get => _nudBat3;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudBat3 == null)
                    ;
                _nudBat3 = value;
                if (_nudBat3 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudBat4
    {
        get => _nudBat4;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudBat4 == null)
                    ;
                _nudBat4 = value;
                if (_nudBat4 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudBat5
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudBat5 == null)
                    ;
                _nudBat5 = value;
                if (_nudBat5 == null)
                    ;
            }
        get => _nudBat5;
    }

    internal virtual NumericUpDown nudBat6
    {
        get => _nudBat6;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudBat6 == null)
                    ;
                _nudBat6 = value;
                if (_nudBat6 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudSel1
    {
        get => _nudSel1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudSel1 == null)
                    ;
                _nudSel1 = value;
                if (_nudSel1 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudSel3
    {
        get => _nudSel3;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudSel3 == null)
                    ;
                _nudSel3 = value;
                if (_nudSel3 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudSel2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudSel2 == null)
                    ;
                _nudSel2 = value;
                if (_nudSel2 == null)
                    ;
            }
        get => _nudSel2;
    }

    internal virtual NumericUpDown nudAtk2
    {
        get => _nudAtk2;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudAtk2 == null)
                    ;
                _nudAtk2 = value;
                if (_nudAtk2 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudAtk1
    {
        get => _nudAtk1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudAtk1 == null)
                    ;
                _nudAtk1 = value;
                if (_nudAtk1 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudAtk3
    {
        get => _nudAtk3;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudAtk3 == null)
                    ;
                _nudAtk3 = value;
                if (_nudAtk3 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudHit2
    {
        get => _nudHit2;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudHit2 == null)
                    ;
                _nudHit2 = value;
                if (_nudHit2 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudHit1
    {
        get => _nudHit1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudHit1 == null)
                    ;
                _nudHit1 = value;
                if (_nudHit1 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudDead
    {
        get => _nudDead;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudDead == null)
                    ;
                _nudDead = value;
                if (_nudDead == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudLowHlth
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudLowHlth == null)
                    ;
                _nudLowHlth = value;
                if (_nudLowHlth == null)
                    ;
            }
        get => _nudLowHlth;
    }

    internal virtual NumericUpDown nudCrit
    {
        get => _nudCrit;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudCrit == null)
                    ;
                _nudCrit = value;
                if (_nudCrit == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudTIA
    {
        get => _nudTIA;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudTIA == null)
                    ;
                _nudTIA = value;
                if (_nudTIA == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudLMin
    {
        get => _nudLMin;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudLMin == null)
                    ;
                _nudLMin = value;
                if (_nudLMin == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudDMin
    {
        get => _nudDMin;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudDMin == null)
                    ;
                _nudDMin = value;
                if (_nudDMin == null)
                    ;
            }
    }

    internal virtual TextBox TextBox39
    {
        get => _TextBox39;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox39 == null)
                    ;
                _TextBox39 = value;
                if (_TextBox39 == null)
                    ;
            }
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

    internal virtual TextBox TextBox40
    {
        get => _TextBox40;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox40 == null)
                    ;
                _TextBox40 = value;
                if (_TextBox40 == null)
                    ;
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

    internal virtual TextBox TextBox41
    {
        get => _TextBox41;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox41 == null)
                    ;
                _TextBox41 = value;
                if (_TextBox41 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox42
    {
        get => _TextBox42;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox42 == null)
                    ;
                _TextBox42 = value;
                if (_TextBox42 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox43
    {
        get => _TextBox43;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox43 == null)
                    ;
                _TextBox43 = value;
                if (_TextBox43 == null)
                    ;
            }
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

    internal virtual TextBox TextBox44
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox44 == null)
                    ;
                _TextBox44 = value;
                if (_TextBox44 == null)
                    ;
            }
        get => _TextBox44;
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

    internal virtual TextBox TextBox45
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox45 == null)
                    ;
                _TextBox45 = value;
                if (_TextBox45 == null)
                    ;
            }
        get => _TextBox45;
    }

    internal virtual TextBox TextBox46
    {
        get => _TextBox46;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox46 == null)
                    ;
                _TextBox46 = value;
                if (_TextBox46 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox47
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox47 == null)
                    ;
                _TextBox47 = value;
                if (_TextBox47 == null)
                    ;
            }
        get => _TextBox47;
    }

    internal virtual TextBox TextBox48
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox48 == null)
                    ;
                _TextBox48 = value;
                if (_TextBox48 == null)
                    ;
            }
        get => _TextBox48;
    }

    internal virtual TextBox TextBox49
    {
        get => _TextBox49;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox49 == null)
                    ;
                _TextBox49 = value;
                if (_TextBox49 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox50
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox50 == null)
                    ;
                _TextBox50 = value;
                if (_TextBox50 == null)
                    ;
            }
        get => _TextBox50;
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

    internal virtual Label Label26
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label26 == null)
                    ;
                _Label26 = value;
                if (_Label26 == null)
                    ;
            }
        get => _Label26;
    }

    internal virtual TextBox TextBox51
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox51 == null)
                    ;
                _TextBox51 = value;
                if (_TextBox51 == null)
                    ;
            }
        get => _TextBox51;
    }

    internal virtual TextBox TextBox52
    {
        get => _TextBox52;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox52 == null)
                    ;
                _TextBox52 = value;
                if (_TextBox52 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox53
    {
        get => _TextBox53;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox53 == null)
                    ;
                _TextBox53 = value;
                if (_TextBox53 == null)
                    ;
            }
    }

    internal virtual TextBox TextBox54
    {
        get => _TextBox54;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_TextBox54 == null)
                    ;
                _TextBox54 = value;
                if (_TextBox54 == null)
                    ;
            }
    }

    internal virtual Label Label28
    {
        get => _Label28;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Label28 == null)
                    ;
                _Label28 = value;
                if (_Label28 == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudStlh
    {
        get => _nudStlh;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudStlh == null)
                    ;
                _nudStlh = value;
                if (_nudStlh == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudSrch
    {
        get => _nudSrch;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudSrch == null)
                    ;
                _nudSrch = value;
                if (_nudSrch == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudTryUnlock
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudTryUnlock == null)
                    ;
                _nudTryUnlock = value;
                if (_nudTryUnlock == null)
                    ;
            }
        get => _nudTryUnlock;
    }

    internal virtual NumericUpDown nudFailUnlock
    {
        get => _nudFailUnlock;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudFailUnlock == null)
                    ;
                _nudFailUnlock = value;
                if (_nudFailUnlock == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudSucceedUnlock
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudSucceedUnlock == null)
                    ;
                _nudSucceedUnlock = value;
                if (_nudSucceedUnlock == null)
                    ;
            }
        get => _nudSucceedUnlock;
    }

    internal virtual NumericUpDown nudLeaveParty
    {
        get => _nudLeaveParty;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudLeaveParty == null)
                    ;
                _nudLeaveParty = value;
                if (_nudLeaveParty == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudRejoinParty
    {
        get => _nudRejoinParty;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudRejoinParty == null)
                    ;
                _nudRejoinParty = value;
                if (_nudRejoinParty == null)
                    ;
            }
    }

    internal virtual NumericUpDown nudPoisoned
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_nudPoisoned == null)
                    ;
                _nudPoisoned = value;
                if (_nudPoisoned == null)
                    ;
            }
        get => _nudPoisoned;
    }

    internal virtual Label label111
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_label111 == null)
                    ;
                _label111 = value;
                if (_label111 == null)
                    ;
            }
        get => _label111;
    }

    internal virtual MainMenu MainMenu1
    {
        get => _MainMenu1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
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
        get => _ToolStripMenuItem1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_ToolStripMenuItem1 == null)
                    ;
                _ToolStripMenuItem1 = value;
                if (_ToolStripMenuItem1 == null)
                    ;
            }
    }

    internal virtual ToolStripMenuItem miSave
    {
        get => _miSave;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miSave != null)
                    _miSave.Click -= new EventHandler(miSave_Click);
                _miSave = value;
                if (_miSave == null)
                    return;
                _miSave.Click += new EventHandler(miSave_Click);
            }
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem5
    {
        get => _ToolStripMenuItem5;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_ToolStripMenuItem5 == null)
                    ;
                _ToolStripMenuItem5 = value;
                if (_ToolStripMenuItem5 == null)
                    ;
            }
    }

    internal virtual ToolStripMenuItem miNew
    {
        get => _miNew;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miNew != null)
                    _miNew.Click -= new EventHandler(miNew_Click);
                _miNew = value;
                if (_miNew == null)
                    return;
                _miNew.Click += new EventHandler(miNew_Click);
            }
    }

    internal virtual ToolStripMenuItem miOpen
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miOpen != null)
                    _miOpen.Click -= new EventHandler(miOpen_Click);
                _miOpen = value;
                if (_miOpen == null)
                    return;
                _miOpen.Click += new EventHandler(miOpen_Click);
            }
        get => _miOpen;
    }

    internal virtual ToolStripMenuItem miQuit
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
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

    internal virtual ToolStripMenuItem miSaveAs
    {
        get => _miSaveAs;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miSaveAs != null)
                    _miSaveAs.Click -= new EventHandler(miSaveAs_Click);
                _miSaveAs = value;
                if (_miSaveAs == null)
                    return;
                _miSaveAs.Click += new EventHandler(miSaveAs_Click);
            }
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_ToolStripMenuItem2 == null)
                    ;
                _ToolStripMenuItem2 = value;
                if (_ToolStripMenuItem2 == null)
                    ;
            }
        get => _ToolStripMenuItem2;
    }

    internal virtual ToolStripMenuItem miUseK1DialogTlk
    {
        get => _miUseK1DialogTlk;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miUseK1DialogTlk != null)
                    _miUseK1DialogTlk.Click -= new EventHandler(UseDialogTlk_Click);
                _miUseK1DialogTlk = value;
                if (_miUseK1DialogTlk == null)
                    return;
                _miUseK1DialogTlk.Click += new EventHandler(UseDialogTlk_Click);
            }
    }

    internal virtual ToolStripMenuItem miUseK2DialogTlk
    {
        get => _miUseK2DialogTlk;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miUseK2DialogTlk != null)
                    _miUseK2DialogTlk.Click -= new EventHandler(UseDialogTlk_Click);
                _miUseK2DialogTlk = value;
                if (_miUseK2DialogTlk == null)
                    return;
                _miUseK2DialogTlk.Click += new EventHandler(UseDialogTlk_Click);
            }
    }

    internal virtual ToolStripMenuItem miUseExtDialogTlk
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miUseExtDialogTlk != null)
                    _miUseExtDialogTlk.Click -= new EventHandler(UseDialogTlk_Click);
                _miUseExtDialogTlk = value;
                if (_miUseExtDialogTlk == null)
                    return;
                _miUseExtDialogTlk.Click += new EventHandler(UseDialogTlk_Click);
            }
        get => _miUseExtDialogTlk;
    }

    internal virtual ToolStripMenuItem miAskDialogTlk
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miAskDialogTlk != null)
                    _miAskDialogTlk.Click -= new EventHandler(UseDialogTlk_Click);
                _miAskDialogTlk = value;
                if (_miAskDialogTlk == null)
                    return;
                _miAskDialogTlk.Click += new EventHandler(UseDialogTlk_Click);
            }
        get => _miAskDialogTlk;
    }

    internal virtual StatusBar StatusBar1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_StatusBar1 == null)
                    ;
                _StatusBar1 = value;
                if (_StatusBar1 == null)
                    ;
            }
        get => _StatusBar1;
    }

    internal virtual ToolTip ToolTip1
    {
        get => _ToolTip1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_ToolTip1 == null)
                    ;
                _ToolTip1 = value;
                if (_ToolTip1 == null)
                    ;
            }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
            components = new Container();
            nudBat1 = new NumericUpDown();
            tbBat1ResRef = new TextBox();
            tbBat1Desc = new TextBox();
            Label1 = new Label();
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            nudBat2 = new NumericUpDown();
            Label2 = new Label();
            TextBox3 = new TextBox();
            TextBox4 = new TextBox();
            Label3 = new Label();
            nudBat3 = new NumericUpDown();
            TextBox5 = new TextBox();
            TextBox6 = new TextBox();
            nudBat4 = new NumericUpDown();
            Label4 = new Label();
            Panel1 = new Panel();
            TextBox43 = new TextBox();
            Label23 = new Label();
            TextBox44 = new TextBox();
            Label24 = new Label();
            TextBox45 = new TextBox();
            nudTryUnlock = new NumericUpDown();
            nudFailUnlock = new NumericUpDown();
            TextBox46 = new TextBox();
            TextBox9 = new TextBox();
            Label6 = new Label();
            TextBox8 = new TextBox();
            TextBox7 = new TextBox();
            nudBat5 = new NumericUpDown();
            TextBox10 = new TextBox();
            Label5 = new Label();
            nudBat6 = new NumericUpDown();
            nudSel1 = new NumericUpDown();
            TextBox11 = new TextBox();
            TextBox12 = new TextBox();
            TextBox13 = new TextBox();
            TextBox14 = new TextBox();
            Label7 = new Label();
            nudSel3 = new NumericUpDown();
            TextBox15 = new TextBox();
            TextBox16 = new TextBox();
            nudSel2 = new NumericUpDown();
            Label8 = new Label();
            Label9 = new Label();
            TextBox17 = new TextBox();
            TextBox18 = new TextBox();
            nudAtk2 = new NumericUpDown();
            Label10 = new Label();
            Label11 = new Label();
            nudAtk1 = new NumericUpDown();
            TextBox19 = new TextBox();
            TextBox20 = new TextBox();
            TextBox21 = new TextBox();
            TextBox22 = new TextBox();
            nudAtk3 = new NumericUpDown();
            Label12 = new Label();
            nudHit2 = new NumericUpDown();
            Label13 = new Label();
            Label14 = new Label();
            nudHit1 = new NumericUpDown();
            TextBox23 = new TextBox();
            TextBox24 = new TextBox();
            TextBox25 = new TextBox();
            TextBox26 = new TextBox();
            TextBox27 = new TextBox();
            TextBox28 = new TextBox();
            nudDead = new NumericUpDown();
            Label15 = new Label();
            TextBox29 = new TextBox();
            nudLowHlth = new NumericUpDown();
            TextBox30 = new TextBox();
            Label16 = new Label();
            nudCrit = new NumericUpDown();
            TextBox31 = new TextBox();
            TextBox32 = new TextBox();
            nudTIA = new NumericUpDown();
            Label17 = new Label();
            TextBox33 = new TextBox();
            Label18 = new Label();
            TextBox34 = new TextBox();
            TextBox35 = new TextBox();
            TextBox36 = new TextBox();
            nudLMin = new NumericUpDown();
            Label19 = new Label();
            nudDMin = new NumericUpDown();
            TextBox37 = new TextBox();
            Label20 = new Label();
            TextBox38 = new TextBox();
            TextBox39 = new TextBox();
            Label21 = new Label();
            TextBox40 = new TextBox();
            Label22 = new Label();
            TextBox41 = new TextBox();
            nudStlh = new NumericUpDown();
            nudSrch = new NumericUpDown();
            TextBox42 = new TextBox();
            TextBox47 = new TextBox();
            nudSucceedUnlock = new NumericUpDown();
            nudLeaveParty = new NumericUpDown();
            TextBox48 = new TextBox();
            TextBox49 = new TextBox();
            TextBox50 = new TextBox();
            Label25 = new Label();
            Label26 = new Label();
            TextBox51 = new TextBox();
            nudRejoinParty = new NumericUpDown();
            nudPoisoned = new NumericUpDown();
            TextBox52 = new TextBox();
            TextBox53 = new TextBox();
            TextBox54 = new TextBox();
            label111 = new Label();
            Label28 = new Label();
            MainMenu1 = new MainMenu();
            ToolStripMenuItem1 = new ToolStripMenuItem();
            miNew = new ToolStripMenuItem();
            miOpen = new ToolStripMenuItem();
            miSave = new ToolStripMenuItem();
            miSaveAs = new ToolStripMenuItem();
            ToolStripMenuItem5 = new ToolStripMenuItem();
            miQuit = new ToolStripMenuItem();
            ToolStripMenuItem2 = new ToolStripMenuItem();
            miUseK1DialogTlk = new ToolStripMenuItem();
            miUseK2DialogTlk = new ToolStripMenuItem();
            miUseExtDialogTlk = new ToolStripMenuItem();
            miAskDialogTlk = new ToolStripMenuItem();
            StatusBar1 = new StatusBar();
            ToolTip1 = new ToolTip(components);
            nudBat1.BeginInit();
            nudBat2.BeginInit();
            nudBat3.BeginInit();
            nudBat4.BeginInit();
            Panel1.SuspendLayout();
            nudTryUnlock.BeginInit();
            nudFailUnlock.BeginInit();
            nudBat5.BeginInit();
            nudBat6.BeginInit();
            nudSel1.BeginInit();
            nudSel3.BeginInit();
            nudSel2.BeginInit();
            nudAtk2.BeginInit();
            nudAtk1.BeginInit();
            nudAtk3.BeginInit();
            nudHit2.BeginInit();
            nudHit1.BeginInit();
            nudDead.BeginInit();
            nudLowHlth.BeginInit();
            nudCrit.BeginInit();
            nudTIA.BeginInit();
            nudLMin.BeginInit();
            nudDMin.BeginInit();
            nudStlh.BeginInit();
            nudSrch.BeginInit();
            nudSucceedUnlock.BeginInit();
            nudLeaveParty.BeginInit();
            nudRejoinParty.BeginInit();
            nudPoisoned.BeginInit();
            SuspendLayout();
            nudBat1.Enabled = false;
            NumericUpDown nudBat1_1 = nudBat1;
            Point point1 = new Point(152, 16);
            Point point2 = point1;
            nudBat1_1.Location = point2;
            NumericUpDown nudBat1_2 = nudBat1;
            Decimal num1 = new Decimal(new int[4]
            {
                300000,
                0,
                0,
                0
            });
            Decimal num2 = num1;
            nudBat1_2.Maximum = num2;
            NumericUpDown nudBat1_3 = nudBat1;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num3 = num1;
            nudBat1_3.Minimum = num3;
            nudBat1.Name = "nudBat1";
            NumericUpDown nudBat1_4 = nudBat1;
            Size size1 = new Size(64, 20);
            Size size2 = size1;
            nudBat1_4.Size = size2;
            nudBat1.TabIndex = 0;
            nudBat1.Tag = "0";
            nudBat1.TextAlign = HorizontalAlignment.Right;
            TextBox tbBat1ResRef1 = tbBat1ResRef;
            point1 = new Point(224, 16);
            Point point3 = point1;
            tbBat1ResRef1.Location = point3;
            tbBat1ResRef.Name = "tbBat1ResRef";
            tbBat1ResRef.ReadOnly = true;
            TextBox tbBat1ResRef2 = tbBat1ResRef;
            size1 = new Size(136, 20);
            Size size3 = size1;
            tbBat1ResRef2.Size = size3;
            tbBat1ResRef.TabIndex = 4;
            tbBat1ResRef.TabStop = false;
            tbBat1ResRef.Tag = "rr0";
            tbBat1ResRef.Text = "";
            tbBat1ResRef.TextAlign = HorizontalAlignment.Right;
            tbBat1Desc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox tbBat1Desc1 = tbBat1Desc;
            point1 = new Point(368, 16);
            Point point4 = point1;
            tbBat1Desc1.Location = point4;
            tbBat1Desc.Name = "tbBat1Desc";
            tbBat1Desc.ReadOnly = true;
            TextBox tbBat1Desc2 = tbBat1Desc;
            size1 = new Size(272, 20);
            Size size4 = size1;
            tbBat1Desc2.Size = size4;
            tbBat1Desc.TabIndex = 4;
            tbBat1Desc.TabStop = false;
            tbBat1Desc.Tag = "d0";
            tbBat1Desc.Text = "";
            Label label1_1 = Label1;
            point1 = new Point(16, 16);
            Point point5 = point1;
            label1_1.Location = point5;
            Label1.Name = "Label1";
            Label label1_2 = Label1;
            size1 = new Size(64, 16);
            Size size5 = size1;
            label1_2.Size = size5;
            Label1.TabIndex = 5;
            Label1.Text = "Battlecry 1";
            TextBox textBox1_1 = TextBox1;
            point1 = new Point(224, 40);
            Point point6 = point1;
            textBox1_1.Location = point6;
            TextBox1.Name = "TextBox1";
            TextBox1.ReadOnly = true;
            TextBox textBox1_2 = TextBox1;
            size1 = new Size(136, 20);
            Size size6 = size1;
            textBox1_2.Size = size6;
            TextBox1.TabIndex = 4;
            TextBox1.TabStop = false;
            TextBox1.Tag = "rr1";
            TextBox1.Text = "";
            TextBox1.TextAlign = HorizontalAlignment.Right;
            TextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox2_1 = TextBox2;
            point1 = new Point(368, 40);
            Point point7 = point1;
            textBox2_1.Location = point7;
            TextBox2.Name = "TextBox2";
            TextBox2.ReadOnly = true;
            TextBox textBox2_2 = TextBox2;
            size1 = new Size(272, 20);
            Size size7 = size1;
            textBox2_2.Size = size7;
            TextBox2.TabIndex = 4;
            TextBox2.TabStop = false;
            TextBox2.Tag = "d1";
            TextBox2.Text = "";
            nudBat2.Enabled = false;
            NumericUpDown nudBat2_1 = nudBat2;
            point1 = new Point(152, 40);
            Point point8 = point1;
            nudBat2_1.Location = point8;
            NumericUpDown nudBat2_2 = nudBat2;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num4 = num1;
            nudBat2_2.Maximum = num4;
            NumericUpDown nudBat2_3 = nudBat2;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num5 = num1;
            nudBat2_3.Minimum = num5;
            nudBat2.Name = "nudBat2";
            NumericUpDown nudBat2_4 = nudBat2;
            size1 = new Size(64, 20);
            Size size8 = size1;
            nudBat2_4.Size = size8;
            nudBat2.TabIndex = 1;
            nudBat2.Tag = "1";
            nudBat2.TextAlign = HorizontalAlignment.Right;
            Label label2_1 = Label2;
            point1 = new Point(16, 40);
            Point point9 = point1;
            label2_1.Location = point9;
            Label2.Name = "Label2";
            Label label2_2 = Label2;
            size1 = new Size(64, 16);
            Size size9 = size1;
            label2_2.Size = size9;
            Label2.TabIndex = 5;
            Label2.Text = "Battlecry 2";
            TextBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox3_1 = TextBox3;
            point1 = new Point(368, 64);
            Point point10 = point1;
            textBox3_1.Location = point10;
            TextBox3.Name = "TextBox3";
            TextBox3.ReadOnly = true;
            TextBox textBox3_2 = TextBox3;
            size1 = new Size(272, 20);
            Size size10 = size1;
            textBox3_2.Size = size10;
            TextBox3.TabIndex = 4;
            TextBox3.TabStop = false;
            TextBox3.Tag = "d2";
            TextBox3.Text = "";
            TextBox textBox4_1 = TextBox4;
            point1 = new Point(224, 64);
            Point point11 = point1;
            textBox4_1.Location = point11;
            TextBox4.Name = "TextBox4";
            TextBox4.ReadOnly = true;
            TextBox textBox4_2 = TextBox4;
            size1 = new Size(136, 20);
            Size size11 = size1;
            textBox4_2.Size = size11;
            TextBox4.TabIndex = 4;
            TextBox4.TabStop = false;
            TextBox4.Tag = "rr2";
            TextBox4.Text = "";
            TextBox4.TextAlign = HorizontalAlignment.Right;
            Label label3_1 = Label3;
            point1 = new Point(16, 64);
            Point point12 = point1;
            label3_1.Location = point12;
            Label3.Name = "Label3";
            Label label3_2 = Label3;
            size1 = new Size(64, 16);
            Size size12 = size1;
            label3_2.Size = size12;
            Label3.TabIndex = 5;
            Label3.Text = "Battlecry 3";
            nudBat3.Enabled = false;
            NumericUpDown nudBat3_1 = nudBat3;
            point1 = new Point(152, 64);
            Point point13 = point1;
            nudBat3_1.Location = point13;
            NumericUpDown nudBat3_2 = nudBat3;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num6 = num1;
            nudBat3_2.Maximum = num6;
            NumericUpDown nudBat3_3 = nudBat3;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num7 = num1;
            nudBat3_3.Minimum = num7;
            nudBat3.Name = "nudBat3";
            NumericUpDown nudBat3_4 = nudBat3;
            size1 = new Size(64, 20);
            Size size13 = size1;
            nudBat3_4.Size = size13;
            nudBat3.TabIndex = 2;
            nudBat3.Tag = "2";
            nudBat3.TextAlign = HorizontalAlignment.Right;
            TextBox textBox5_1 = TextBox5;
            point1 = new Point(224, 88);
            Point point14 = point1;
            textBox5_1.Location = point14;
            TextBox5.Name = "TextBox5";
            TextBox5.ReadOnly = true;
            TextBox textBox5_2 = TextBox5;
            size1 = new Size(136, 20);
            Size size14 = size1;
            textBox5_2.Size = size14;
            TextBox5.TabIndex = 4;
            TextBox5.TabStop = false;
            TextBox5.Tag = "rr3";
            TextBox5.Text = "";
            TextBox5.TextAlign = HorizontalAlignment.Right;
            TextBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox6_1 = TextBox6;
            point1 = new Point(368, 88);
            Point point15 = point1;
            textBox6_1.Location = point15;
            TextBox6.Name = "TextBox6";
            TextBox6.ReadOnly = true;
            TextBox textBox6_2 = TextBox6;
            size1 = new Size(272, 20);
            Size size15 = size1;
            textBox6_2.Size = size15;
            TextBox6.TabIndex = 4;
            TextBox6.TabStop = false;
            TextBox6.Tag = "d3";
            TextBox6.Text = "";
            nudBat4.Enabled = false;
            NumericUpDown nudBat4_1 = nudBat4;
            point1 = new Point(152, 88);
            Point point16 = point1;
            nudBat4_1.Location = point16;
            NumericUpDown nudBat4_2 = nudBat4;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num8 = num1;
            nudBat4_2.Maximum = num8;
            NumericUpDown nudBat4_3 = nudBat4;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num9 = num1;
            nudBat4_3.Minimum = num9;
            nudBat4.Name = "nudBat4";
            NumericUpDown nudBat4_4 = nudBat4;
            size1 = new Size(64, 20);
            Size size16 = size1;
            nudBat4_4.Size = size16;
            nudBat4.TabIndex = 3;
            nudBat4.Tag = "3";
            nudBat4.TextAlign = HorizontalAlignment.Right;
            Label label4_1 = Label4;
            point1 = new Point(16, 88);
            Point point17 = point1;
            label4_1.Location = point17;
            Label4.Name = "Label4";
            Label label4_2 = Label4;
            size1 = new Size(64, 16);
            Size size17 = size1;
            label4_2.Size = size17;
            Label4.TabIndex = 5;
            Label4.Text = "Battlecry 4";
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.AutoScroll = true;
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(TextBox43);
            Panel1.Controls.Add(Label23);
            Panel1.Controls.Add(TextBox44);
            Panel1.Controls.Add(Label24);
            Panel1.Controls.Add(TextBox45);
            Panel1.Controls.Add(nudTryUnlock);
            Panel1.Controls.Add(nudFailUnlock);
            Panel1.Controls.Add(TextBox46);
            Panel1.Controls.Add(nudBat1);
            Panel1.Controls.Add(tbBat1ResRef);
            Panel1.Controls.Add(TextBox5);
            Panel1.Controls.Add(Label4);
            Panel1.Controls.Add(TextBox9);
            Panel1.Controls.Add(Label6);
            Panel1.Controls.Add(tbBat1Desc);
            Panel1.Controls.Add(TextBox3);
            Panel1.Controls.Add(TextBox4);
            Panel1.Controls.Add(TextBox1);
            Panel1.Controls.Add(nudBat3);
            Panel1.Controls.Add(nudBat2);
            Panel1.Controls.Add(TextBox2);
            Panel1.Controls.Add(nudBat4);
            Panel1.Controls.Add(Label2);
            Panel1.Controls.Add(TextBox8);
            Panel1.Controls.Add(TextBox7);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(nudBat5);
            Panel1.Controls.Add(TextBox6);
            Panel1.Controls.Add(TextBox10);
            Panel1.Controls.Add(Label5);
            Panel1.Controls.Add(nudBat6);
            Panel1.Controls.Add(Label1);
            Panel1.Controls.Add(nudSel1);
            Panel1.Controls.Add(TextBox11);
            Panel1.Controls.Add(TextBox12);
            Panel1.Controls.Add(TextBox13);
            Panel1.Controls.Add(TextBox14);
            Panel1.Controls.Add(Label7);
            Panel1.Controls.Add(nudSel3);
            Panel1.Controls.Add(TextBox15);
            Panel1.Controls.Add(TextBox16);
            Panel1.Controls.Add(nudSel2);
            Panel1.Controls.Add(Label8);
            Panel1.Controls.Add(Label9);
            Panel1.Controls.Add(TextBox17);
            Panel1.Controls.Add(TextBox18);
            Panel1.Controls.Add(nudAtk2);
            Panel1.Controls.Add(Label10);
            Panel1.Controls.Add(Label11);
            Panel1.Controls.Add(nudAtk1);
            Panel1.Controls.Add(TextBox19);
            Panel1.Controls.Add(TextBox20);
            Panel1.Controls.Add(TextBox21);
            Panel1.Controls.Add(TextBox22);
            Panel1.Controls.Add(nudAtk3);
            Panel1.Controls.Add(Label12);
            Panel1.Controls.Add(nudHit2);
            Panel1.Controls.Add(Label13);
            Panel1.Controls.Add(Label14);
            Panel1.Controls.Add(nudHit1);
            Panel1.Controls.Add(TextBox23);
            Panel1.Controls.Add(TextBox24);
            Panel1.Controls.Add(TextBox25);
            Panel1.Controls.Add(TextBox26);
            Panel1.Controls.Add(TextBox27);
            Panel1.Controls.Add(TextBox28);
            Panel1.Controls.Add(nudDead);
            Panel1.Controls.Add(Label15);
            Panel1.Controls.Add(TextBox29);
            Panel1.Controls.Add(nudLowHlth);
            Panel1.Controls.Add(TextBox30);
            Panel1.Controls.Add(Label16);
            Panel1.Controls.Add(nudCrit);
            Panel1.Controls.Add(TextBox31);
            Panel1.Controls.Add(TextBox32);
            Panel1.Controls.Add(nudTIA);
            Panel1.Controls.Add(Label17);
            Panel1.Controls.Add(TextBox33);
            Panel1.Controls.Add(Label18);
            Panel1.Controls.Add(TextBox34);
            Panel1.Controls.Add(TextBox35);
            Panel1.Controls.Add(TextBox36);
            Panel1.Controls.Add(nudLMin);
            Panel1.Controls.Add(Label19);
            Panel1.Controls.Add(nudDMin);
            Panel1.Controls.Add(TextBox37);
            Panel1.Controls.Add(Label20);
            Panel1.Controls.Add(TextBox38);
            Panel1.Controls.Add(TextBox39);
            Panel1.Controls.Add(Label21);
            Panel1.Controls.Add(TextBox40);
            Panel1.Controls.Add(Label22);
            Panel1.Controls.Add(TextBox41);
            Panel1.Controls.Add(nudStlh);
            Panel1.Controls.Add(nudSrch);
            Panel1.Controls.Add(TextBox42);
            Panel1.Controls.Add(TextBox47);
            Panel1.Controls.Add(nudSucceedUnlock);
            Panel1.Controls.Add(nudLeaveParty);
            Panel1.Controls.Add(TextBox48);
            Panel1.Controls.Add(TextBox49);
            Panel1.Controls.Add(TextBox50);
            Panel1.Controls.Add(Label25);
            Panel1.Controls.Add(Label26);
            Panel1.Controls.Add(TextBox51);
            Panel1.Controls.Add(nudRejoinParty);
            Panel1.Controls.Add(nudPoisoned);
            Panel1.Controls.Add(TextBox52);
            Panel1.Controls.Add(TextBox53);
            Panel1.Controls.Add(TextBox54);
            Panel1.Controls.Add(label111);
            Panel1.Controls.Add(Label28);
            Panel panel1_1 = Panel1;
            point1 = new Point(8, 16);
            Point point18 = point1;
            panel1_1.Location = point18;
            Panel1.Name = "Panel1";
            Panel panel1_2 = Panel1;
            size1 = new Size(672, 336);
            Size size18 = size1;
            panel1_2.Size = size18;
            Panel1.TabIndex = 6;
            TextBox textBox43_1 = TextBox43;
            point1 = new Point(224, 592);
            Point point19 = point1;
            textBox43_1.Location = point19;
            TextBox43.Name = "TextBox43";
            TextBox43.ReadOnly = true;
            TextBox textBox43_2 = TextBox43;
            size1 = new Size(136, 20);
            Size size19 = size1;
            textBox43_2.Size = size19;
            TextBox43.TabIndex = 17;
            TextBox43.TabStop = false;
            TextBox43.Tag = "rr22";
            TextBox43.Text = "";
            TextBox43.TextAlign = HorizontalAlignment.Right;
            Label label23_1 = Label23;
            point1 = new Point(16, 616);
            Point point20 = point1;
            label23_1.Location = point20;
            Label23.Name = "Label23";
            Label label23_2 = Label23;
            size1 = new Size(80, 16);
            Size size20 = size1;
            label23_2.Size = size20;
            Label23.TabIndex = 20;
            Label23.Text = "Unlock Failed";
            TextBox textBox44_1 = TextBox44;
            point1 = new Point(224, 616);
            Point point21 = point1;
            textBox44_1.Location = point21;
            TextBox44.Name = "TextBox44";
            TextBox44.ReadOnly = true;
            TextBox textBox44_2 = TextBox44;
            size1 = new Size(136, 20);
            Size size21 = size1;
            textBox44_2.Size = size21;
            TextBox44.TabIndex = 16;
            TextBox44.TabStop = false;
            TextBox44.Tag = "rr23";
            TextBox44.Text = "";
            TextBox44.TextAlign = HorizontalAlignment.Right;
            Label label24_1 = Label24;
            point1 = new Point(16, 592);
            Point point22 = point1;
            label24_1.Location = point22;
            Label24.Name = "Label24";
            Label label24_2 = Label24;
            size1 = new Size(80, 16);
            Size size22 = size1;
            label24_2.Size = size22;
            Label24.TabIndex = 21;
            Label24.Text = "Begin Unlock";
            TextBox45.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox45_1 = TextBox45;
            point1 = new Point(368, 592);
            Point point23 = point1;
            textBox45_1.Location = point23;
            TextBox45.Name = "TextBox45";
            TextBox45.ReadOnly = true;
            TextBox textBox45_2 = TextBox45;
            size1 = new Size(272, 20);
            Size size23 = size1;
            textBox45_2.Size = size23;
            TextBox45.TabIndex = 18;
            TextBox45.TabStop = false;
            TextBox45.Tag = "d22";
            TextBox45.Text = "";
            nudTryUnlock.Enabled = false;
            NumericUpDown nudTryUnlock1 = nudTryUnlock;
            point1 = new Point(152, 592);
            Point point24 = point1;
            nudTryUnlock1.Location = point24;
            NumericUpDown nudTryUnlock2 = nudTryUnlock;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num10 = num1;
            nudTryUnlock2.Maximum = num10;
            NumericUpDown nudTryUnlock3 = nudTryUnlock;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num11 = num1;
            nudTryUnlock3.Minimum = num11;
            nudTryUnlock.Name = "nudTryUnlock";
            NumericUpDown nudTryUnlock4 = nudTryUnlock;
            size1 = new Size(64, 20);
            Size size24 = size1;
            nudTryUnlock4.Size = size24;
            nudTryUnlock.TabIndex = 22;
            nudTryUnlock.Tag = "22";
            nudTryUnlock.TextAlign = HorizontalAlignment.Right;
            nudFailUnlock.Enabled = false;
            NumericUpDown nudFailUnlock1 = nudFailUnlock;
            point1 = new Point(152, 616);
            Point point25 = point1;
            nudFailUnlock1.Location = point25;
            NumericUpDown nudFailUnlock2 = nudFailUnlock;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num12 = num1;
            nudFailUnlock2.Maximum = num12;
            NumericUpDown nudFailUnlock3 = nudFailUnlock;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num13 = num1;
            nudFailUnlock3.Minimum = num13;
            nudFailUnlock.Name = "nudFailUnlock";
            NumericUpDown nudFailUnlock4 = nudFailUnlock;
            size1 = new Size(64, 20);
            Size size25 = size1;
            nudFailUnlock4.Size = size25;
            nudFailUnlock.TabIndex = 23;
            nudFailUnlock.Tag = "23";
            nudFailUnlock.TextAlign = HorizontalAlignment.Right;
            TextBox46.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox46_1 = TextBox46;
            point1 = new Point(368, 616);
            Point point26 = point1;
            textBox46_1.Location = point26;
            TextBox46.Name = "TextBox46";
            TextBox46.ReadOnly = true;
            TextBox textBox46_2 = TextBox46;
            size1 = new Size(272, 20);
            Size size26 = size1;
            textBox46_2.Size = size26;
            TextBox46.TabIndex = 19;
            TextBox46.TabStop = false;
            TextBox46.Tag = "d23";
            TextBox46.Text = "";
            TextBox textBox9_1 = TextBox9;
            point1 = new Point(224, 112);
            Point point27 = point1;
            textBox9_1.Location = point27;
            TextBox9.Name = "TextBox9";
            TextBox9.ReadOnly = true;
            TextBox textBox9_2 = TextBox9;
            size1 = new Size(136, 20);
            Size size27 = size1;
            textBox9_2.Size = size27;
            TextBox9.TabIndex = 9;
            TextBox9.TabStop = false;
            TextBox9.Tag = "rr4";
            TextBox9.Text = "";
            TextBox9.TextAlign = HorizontalAlignment.Right;
            Label label6_1 = Label6;
            point1 = new Point(16, 112);
            Point point28 = point1;
            label6_1.Location = point28;
            Label6.Name = "Label6";
            Label label6_2 = Label6;
            size1 = new Size(64, 16);
            Size size28 = size1;
            label6_2.Size = size28;
            Label6.TabIndex = 13;
            Label6.Text = "Battlecry 5";
            TextBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox8_1 = TextBox8;
            point1 = new Point(368, 112);
            Point point29 = point1;
            textBox8_1.Location = point29;
            TextBox8.Name = "TextBox8";
            TextBox8.ReadOnly = true;
            TextBox textBox8_2 = TextBox8;
            size1 = new Size(272, 20);
            Size size29 = size1;
            textBox8_2.Size = size29;
            TextBox8.TabIndex = 11;
            TextBox8.TabStop = false;
            TextBox8.Tag = "d4";
            TextBox8.Text = "";
            TextBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox7_1 = TextBox7;
            point1 = new Point(368, 136);
            Point point30 = point1;
            textBox7_1.Location = point30;
            TextBox7.Name = "TextBox7";
            TextBox7.ReadOnly = true;
            TextBox textBox7_2 = TextBox7;
            size1 = new Size(272, 20);
            Size size30 = size1;
            textBox7_2.Size = size30;
            TextBox7.TabIndex = 10;
            TextBox7.TabStop = false;
            TextBox7.Tag = "d5";
            TextBox7.Text = "";
            nudBat5.Enabled = false;
            NumericUpDown nudBat5_1 = nudBat5;
            point1 = new Point(152, 112);
            Point point31 = point1;
            nudBat5_1.Location = point31;
            NumericUpDown nudBat5_2 = nudBat5;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num14 = num1;
            nudBat5_2.Maximum = num14;
            NumericUpDown nudBat5_3 = nudBat5;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num15 = num1;
            nudBat5_3.Minimum = num15;
            nudBat5.Name = "nudBat5";
            NumericUpDown nudBat5_4 = nudBat5;
            size1 = new Size(64, 20);
            Size size31 = size1;
            nudBat5_4.Size = size31;
            nudBat5.TabIndex = 4;
            nudBat5.Tag = "4";
            nudBat5.TextAlign = HorizontalAlignment.Right;
            TextBox textBox10_1 = TextBox10;
            point1 = new Point(224, 136);
            Point point32 = point1;
            textBox10_1.Location = point32;
            TextBox10.Name = "TextBox10";
            TextBox10.ReadOnly = true;
            TextBox textBox10_2 = TextBox10;
            size1 = new Size(136, 20);
            Size size32 = size1;
            textBox10_2.Size = size32;
            TextBox10.TabIndex = 8;
            TextBox10.TabStop = false;
            TextBox10.Tag = "rr5";
            TextBox10.Text = "";
            TextBox10.TextAlign = HorizontalAlignment.Right;
            Label label5_1 = Label5;
            point1 = new Point(16, 136);
            Point point33 = point1;
            label5_1.Location = point33;
            Label5.Name = "Label5";
            Label label5_2 = Label5;
            size1 = new Size(64, 16);
            Size size33 = size1;
            label5_2.Size = size33;
            Label5.TabIndex = 12;
            Label5.Text = "Battlecry 6";
            nudBat6.Enabled = false;
            NumericUpDown nudBat6_1 = nudBat6;
            point1 = new Point(152, 136);
            Point point34 = point1;
            nudBat6_1.Location = point34;
            NumericUpDown nudBat6_2 = nudBat6;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num16 = num1;
            nudBat6_2.Maximum = num16;
            NumericUpDown nudBat6_3 = nudBat6;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num17 = num1;
            nudBat6_3.Minimum = num17;
            nudBat6.Name = "nudBat6";
            NumericUpDown nudBat6_4 = nudBat6;
            size1 = new Size(64, 20);
            Size size34 = size1;
            nudBat6_4.Size = size34;
            nudBat6.TabIndex = 5;
            nudBat6.Tag = "5";
            nudBat6.TextAlign = HorizontalAlignment.Right;
            nudSel1.Enabled = false;
            NumericUpDown nudSel1_1 = nudSel1;
            point1 = new Point(152, 168);
            Point point35 = point1;
            nudSel1_1.Location = point35;
            NumericUpDown nudSel1_2 = nudSel1;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num18 = num1;
            nudSel1_2.Maximum = num18;
            NumericUpDown nudSel1_3 = nudSel1;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num19 = num1;
            nudSel1_3.Minimum = num19;
            nudSel1.Name = "nudSel1";
            NumericUpDown nudSel1_4 = nudSel1;
            size1 = new Size(64, 20);
            Size size35 = size1;
            nudSel1_4.Size = size35;
            nudSel1.TabIndex = 6;
            nudSel1.Tag = "6";
            nudSel1.TextAlign = HorizontalAlignment.Right;
            TextBox textBox11_1 = TextBox11;
            point1 = new Point(224, 168);
            Point point36 = point1;
            textBox11_1.Location = point36;
            TextBox11.Name = "TextBox11";
            TextBox11.ReadOnly = true;
            TextBox textBox11_2 = TextBox11;
            size1 = new Size(136, 20);
            Size size36 = size1;
            textBox11_2.Size = size36;
            TextBox11.TabIndex = 4;
            TextBox11.TabStop = false;
            TextBox11.Tag = "rr6";
            TextBox11.Text = "";
            TextBox11.TextAlign = HorizontalAlignment.Right;
            TextBox12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox12_1 = TextBox12;
            point1 = new Point(368, 168);
            Point point37 = point1;
            textBox12_1.Location = point37;
            TextBox12.Name = "TextBox12";
            TextBox12.ReadOnly = true;
            TextBox textBox12_2 = TextBox12;
            size1 = new Size(272, 20);
            Size size37 = size1;
            textBox12_2.Size = size37;
            TextBox12.TabIndex = 4;
            TextBox12.TabStop = false;
            TextBox12.Tag = "d6";
            TextBox12.Text = "";
            TextBox13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox13_1 = TextBox13;
            point1 = new Point(368, 216);
            Point point38 = point1;
            textBox13_1.Location = point38;
            TextBox13.Name = "TextBox13";
            TextBox13.ReadOnly = true;
            TextBox textBox13_2 = TextBox13;
            size1 = new Size(272, 20);
            Size size38 = size1;
            textBox13_2.Size = size38;
            TextBox13.TabIndex = 4;
            TextBox13.TabStop = false;
            TextBox13.Tag = "d8";
            TextBox13.Text = "";
            TextBox textBox14_1 = TextBox14;
            point1 = new Point(224, 216);
            Point point39 = point1;
            textBox14_1.Location = point39;
            TextBox14.Name = "TextBox14";
            TextBox14.ReadOnly = true;
            TextBox textBox14_2 = TextBox14;
            size1 = new Size(136, 20);
            Size size39 = size1;
            textBox14_2.Size = size39;
            TextBox14.TabIndex = 4;
            TextBox14.TabStop = false;
            TextBox14.Tag = "rr8";
            TextBox14.Text = "";
            TextBox14.TextAlign = HorizontalAlignment.Right;
            Label label7_1 = Label7;
            point1 = new Point(16, 216);
            Point point40 = point1;
            label7_1.Location = point40;
            Label7.Name = "Label7";
            Label label7_2 = Label7;
            size1 = new Size(64, 16);
            Size size40 = size1;
            label7_2.Size = size40;
            Label7.TabIndex = 5;
            Label7.Text = "Select 3";
            nudSel3.Enabled = false;
            NumericUpDown nudSel3_1 = nudSel3;
            point1 = new Point(152, 216);
            Point point41 = point1;
            nudSel3_1.Location = point41;
            NumericUpDown nudSel3_2 = nudSel3;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num20 = num1;
            nudSel3_2.Maximum = num20;
            NumericUpDown nudSel3_3 = nudSel3;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num21 = num1;
            nudSel3_3.Minimum = num21;
            nudSel3.Name = "nudSel3";
            NumericUpDown nudSel3_4 = nudSel3;
            size1 = new Size(64, 20);
            Size size41 = size1;
            nudSel3_4.Size = size41;
            nudSel3.TabIndex = 8;
            nudSel3.Tag = "8";
            nudSel3.TextAlign = HorizontalAlignment.Right;
            TextBox textBox15_1 = TextBox15;
            point1 = new Point(224, 192);
            Point point42 = point1;
            textBox15_1.Location = point42;
            TextBox15.Name = "TextBox15";
            TextBox15.ReadOnly = true;
            TextBox textBox15_2 = TextBox15;
            size1 = new Size(136, 20);
            Size size42 = size1;
            textBox15_2.Size = size42;
            TextBox15.TabIndex = 4;
            TextBox15.TabStop = false;
            TextBox15.Tag = "rr7";
            TextBox15.Text = "";
            TextBox15.TextAlign = HorizontalAlignment.Right;
            TextBox16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox16_1 = TextBox16;
            point1 = new Point(368, 192);
            Point point43 = point1;
            textBox16_1.Location = point43;
            TextBox16.Name = "TextBox16";
            TextBox16.ReadOnly = true;
            TextBox textBox16_2 = TextBox16;
            size1 = new Size(272, 20);
            Size size43 = size1;
            textBox16_2.Size = size43;
            TextBox16.TabIndex = 4;
            TextBox16.TabStop = false;
            TextBox16.Tag = "d7";
            TextBox16.Text = "";
            nudSel2.Enabled = false;
            NumericUpDown nudSel2_1 = nudSel2;
            point1 = new Point(152, 192);
            Point point44 = point1;
            nudSel2_1.Location = point44;
            NumericUpDown nudSel2_2 = nudSel2;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num22 = num1;
            nudSel2_2.Maximum = num22;
            NumericUpDown nudSel2_3 = nudSel2;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num23 = num1;
            nudSel2_3.Minimum = num23;
            nudSel2.Name = "nudSel2";
            NumericUpDown nudSel2_4 = nudSel2;
            size1 = new Size(64, 20);
            Size size44 = size1;
            nudSel2_4.Size = size44;
            nudSel2.TabIndex = 7;
            nudSel2.Tag = "7";
            nudSel2.TextAlign = HorizontalAlignment.Right;
            Label label8_1 = Label8;
            point1 = new Point(16, 192);
            Point point45 = point1;
            label8_1.Location = point45;
            Label8.Name = "Label8";
            Label label8_2 = Label8;
            size1 = new Size(64, 16);
            Size size45 = size1;
            label8_2.Size = size45;
            Label8.TabIndex = 5;
            Label8.Text = "Select 2";
            Label label9_1 = Label9;
            point1 = new Point(16, 168);
            Point point46 = point1;
            label9_1.Location = point46;
            Label9.Name = "Label9";
            Label label9_2 = Label9;
            size1 = new Size(64, 16);
            Size size46 = size1;
            label9_2.Size = size46;
            Label9.TabIndex = 5;
            Label9.Text = "Select 1";
            TextBox textBox17_1 = TextBox17;
            point1 = new Point(224, 272);
            Point point47 = point1;
            textBox17_1.Location = point47;
            TextBox17.Name = "TextBox17";
            TextBox17.ReadOnly = true;
            TextBox textBox17_2 = TextBox17;
            size1 = new Size(136, 20);
            Size size47 = size1;
            textBox17_2.Size = size47;
            TextBox17.TabIndex = 4;
            TextBox17.TabStop = false;
            TextBox17.Tag = "rr10";
            TextBox17.Text = "";
            TextBox17.TextAlign = HorizontalAlignment.Right;
            TextBox18.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox18_1 = TextBox18;
            point1 = new Point(368, 272);
            Point point48 = point1;
            textBox18_1.Location = point48;
            TextBox18.Name = "TextBox18";
            TextBox18.ReadOnly = true;
            TextBox textBox18_2 = TextBox18;
            size1 = new Size(272, 20);
            Size size48 = size1;
            textBox18_2.Size = size48;
            TextBox18.TabIndex = 4;
            TextBox18.TabStop = false;
            TextBox18.Tag = "d10";
            TextBox18.Text = "";
            nudAtk2.Enabled = false;
            NumericUpDown nudAtk2_1 = nudAtk2;
            point1 = new Point(152, 272);
            Point point49 = point1;
            nudAtk2_1.Location = point49;
            NumericUpDown nudAtk2_2 = nudAtk2;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num24 = num1;
            nudAtk2_2.Maximum = num24;
            NumericUpDown nudAtk2_3 = nudAtk2;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num25 = num1;
            nudAtk2_3.Minimum = num25;
            nudAtk2.Name = "nudAtk2";
            NumericUpDown nudAtk2_4 = nudAtk2;
            size1 = new Size(64, 20);
            Size size49 = size1;
            nudAtk2_4.Size = size49;
            nudAtk2.TabIndex = 10;
            nudAtk2.Tag = "10";
            nudAtk2.TextAlign = HorizontalAlignment.Right;
            Label label10_1 = Label10;
            point1 = new Point(16, 272);
            Point point50 = point1;
            label10_1.Location = point50;
            Label10.Name = "Label10";
            Label label10_2 = Label10;
            size1 = new Size(88, 16);
            Size size50 = size1;
            label10_2.Size = size50;
            Label10.TabIndex = 5;
            Label10.Text = "Attack Grunt 2";
            Label label11_1 = Label11;
            point1 = new Point(16, 248);
            Point point51 = point1;
            label11_1.Location = point51;
            Label11.Name = "Label11";
            Label label11_2 = Label11;
            size1 = new Size(88, 16);
            Size size51 = size1;
            label11_2.Size = size51;
            Label11.TabIndex = 5;
            Label11.Text = "Attack Grunt 1";
            nudAtk1.Enabled = false;
            NumericUpDown nudAtk1_1 = nudAtk1;
            point1 = new Point(152, 248);
            Point point52 = point1;
            nudAtk1_1.Location = point52;
            NumericUpDown nudAtk1_2 = nudAtk1;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num26 = num1;
            nudAtk1_2.Maximum = num26;
            NumericUpDown nudAtk1_3 = nudAtk1;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num27 = num1;
            nudAtk1_3.Minimum = num27;
            nudAtk1.Name = "nudAtk1";
            NumericUpDown nudAtk1_4 = nudAtk1;
            size1 = new Size(64, 20);
            Size size52 = size1;
            nudAtk1_4.Size = size52;
            nudAtk1.TabIndex = 9;
            nudAtk1.Tag = "9";
            nudAtk1.TextAlign = HorizontalAlignment.Right;
            TextBox textBox19_1 = TextBox19;
            point1 = new Point(224, 248);
            Point point53 = point1;
            textBox19_1.Location = point53;
            TextBox19.Name = "TextBox19";
            TextBox19.ReadOnly = true;
            TextBox textBox19_2 = TextBox19;
            size1 = new Size(136, 20);
            Size size53 = size1;
            textBox19_2.Size = size53;
            TextBox19.TabIndex = 4;
            TextBox19.TabStop = false;
            TextBox19.Tag = "rr9";
            TextBox19.Text = "";
            TextBox19.TextAlign = HorizontalAlignment.Right;
            TextBox20.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox20_1 = TextBox20;
            point1 = new Point(368, 248);
            Point point54 = point1;
            textBox20_1.Location = point54;
            TextBox20.Name = "TextBox20";
            TextBox20.ReadOnly = true;
            TextBox textBox20_2 = TextBox20;
            size1 = new Size(272, 20);
            Size size54 = size1;
            textBox20_2.Size = size54;
            TextBox20.TabIndex = 4;
            TextBox20.TabStop = false;
            TextBox20.Tag = "d9";
            TextBox20.Text = "";
            TextBox textBox21_1 = TextBox21;
            point1 = new Point(224, 296);
            Point point55 = point1;
            textBox21_1.Location = point55;
            TextBox21.Name = "TextBox21";
            TextBox21.ReadOnly = true;
            TextBox textBox21_2 = TextBox21;
            size1 = new Size(136, 20);
            Size size55 = size1;
            textBox21_2.Size = size55;
            TextBox21.TabIndex = 4;
            TextBox21.TabStop = false;
            TextBox21.Tag = "rr11";
            TextBox21.Text = "";
            TextBox21.TextAlign = HorizontalAlignment.Right;
            TextBox22.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox22_1 = TextBox22;
            point1 = new Point(368, 296);
            Point point56 = point1;
            textBox22_1.Location = point56;
            TextBox22.Name = "TextBox22";
            TextBox22.ReadOnly = true;
            TextBox textBox22_2 = TextBox22;
            size1 = new Size(272, 20);
            Size size56 = size1;
            textBox22_2.Size = size56;
            TextBox22.TabIndex = 4;
            TextBox22.TabStop = false;
            TextBox22.Tag = "d11";
            TextBox22.Text = "";
            nudAtk3.Enabled = false;
            NumericUpDown nudAtk3_1 = nudAtk3;
            point1 = new Point(152, 296);
            Point point57 = point1;
            nudAtk3_1.Location = point57;
            NumericUpDown nudAtk3_2 = nudAtk3;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num28 = num1;
            nudAtk3_2.Maximum = num28;
            NumericUpDown nudAtk3_3 = nudAtk3;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num29 = num1;
            nudAtk3_3.Minimum = num29;
            nudAtk3.Name = "nudAtk3";
            NumericUpDown nudAtk3_4 = nudAtk3;
            size1 = new Size(64, 20);
            Size size57 = size1;
            nudAtk3_4.Size = size57;
            nudAtk3.TabIndex = 11;
            nudAtk3.Tag = "11";
            nudAtk3.TextAlign = HorizontalAlignment.Right;
            Label label12_1 = Label12;
            point1 = new Point(16, 296);
            Point point58 = point1;
            label12_1.Location = point58;
            Label12.Name = "Label12";
            Label label12_2 = Label12;
            size1 = new Size(88, 16);
            Size size58 = size1;
            label12_2.Size = size58;
            Label12.TabIndex = 5;
            Label12.Text = "Attack Grunt 3";
            nudHit2.Enabled = false;
            NumericUpDown nudHit2_1 = nudHit2;
            point1 = new Point(152, 352);
            Point point59 = point1;
            nudHit2_1.Location = point59;
            NumericUpDown nudHit2_2 = nudHit2;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num30 = num1;
            nudHit2_2.Maximum = num30;
            NumericUpDown nudHit2_3 = nudHit2;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num31 = num1;
            nudHit2_3.Minimum = num31;
            nudHit2.Name = "nudHit2";
            NumericUpDown nudHit2_4 = nudHit2;
            size1 = new Size(64, 20);
            Size size59 = size1;
            nudHit2_4.Size = size59;
            nudHit2.TabIndex = 13;
            nudHit2.Tag = "13";
            nudHit2.TextAlign = HorizontalAlignment.Right;
            Label label13_1 = Label13;
            point1 = new Point(16, 352);
            Point point60 = point1;
            label13_1.Location = point60;
            Label13.Name = "Label13";
            Label label13_2 = Label13;
            size1 = new Size(88, 16);
            Size size60 = size1;
            label13_2.Size = size60;
            Label13.TabIndex = 5;
            Label13.Text = "Pain Grunt 2";
            Label label14_1 = Label14;
            point1 = new Point(16, 328);
            Point point61 = point1;
            label14_1.Location = point61;
            Label14.Name = "Label14";
            Label label14_2 = Label14;
            size1 = new Size(88, 16);
            Size size61 = size1;
            label14_2.Size = size61;
            Label14.TabIndex = 5;
            Label14.Text = "Pain Grunt 1";
            nudHit1.Enabled = false;
            NumericUpDown nudHit1_1 = nudHit1;
            point1 = new Point(152, 328);
            Point point62 = point1;
            nudHit1_1.Location = point62;
            NumericUpDown nudHit1_2 = nudHit1;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num32 = num1;
            nudHit1_2.Maximum = num32;
            NumericUpDown nudHit1_3 = nudHit1;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num33 = num1;
            nudHit1_3.Minimum = num33;
            nudHit1.Name = "nudHit1";
            NumericUpDown nudHit1_4 = nudHit1;
            size1 = new Size(64, 20);
            Size size62 = size1;
            nudHit1_4.Size = size62;
            nudHit1.TabIndex = 12;
            nudHit1.Tag = "12";
            nudHit1.TextAlign = HorizontalAlignment.Right;
            TextBox textBox23_1 = TextBox23;
            point1 = new Point(224, 328);
            Point point63 = point1;
            textBox23_1.Location = point63;
            TextBox23.Name = "TextBox23";
            TextBox23.ReadOnly = true;
            TextBox textBox23_2 = TextBox23;
            size1 = new Size(136, 20);
            Size size63 = size1;
            textBox23_2.Size = size63;
            TextBox23.TabIndex = 4;
            TextBox23.TabStop = false;
            TextBox23.Tag = "rr12";
            TextBox23.Text = "";
            TextBox23.TextAlign = HorizontalAlignment.Right;
            TextBox24.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox24_1 = TextBox24;
            point1 = new Point(368, 328);
            Point point64 = point1;
            textBox24_1.Location = point64;
            TextBox24.Name = "TextBox24";
            TextBox24.ReadOnly = true;
            TextBox textBox24_2 = TextBox24;
            size1 = new Size(272, 20);
            Size size64 = size1;
            textBox24_2.Size = size64;
            TextBox24.TabIndex = 4;
            TextBox24.TabStop = false;
            TextBox24.Tag = "d12";
            TextBox24.Text = "";
            TextBox textBox25_1 = TextBox25;
            point1 = new Point(224, 352);
            Point point65 = point1;
            textBox25_1.Location = point65;
            TextBox25.Name = "TextBox25";
            TextBox25.ReadOnly = true;
            TextBox textBox25_2 = TextBox25;
            size1 = new Size(136, 20);
            Size size65 = size1;
            textBox25_2.Size = size65;
            TextBox25.TabIndex = 4;
            TextBox25.TabStop = false;
            TextBox25.Tag = "rr13";
            TextBox25.Text = "";
            TextBox25.TextAlign = HorizontalAlignment.Right;
            TextBox26.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox26_1 = TextBox26;
            point1 = new Point(368, 352);
            Point point66 = point1;
            textBox26_1.Location = point66;
            TextBox26.Name = "TextBox26";
            TextBox26.ReadOnly = true;
            TextBox textBox26_2 = TextBox26;
            size1 = new Size(272, 20);
            Size size66 = size1;
            textBox26_2.Size = size66;
            TextBox26.TabIndex = 4;
            TextBox26.TabStop = false;
            TextBox26.Tag = "d13";
            TextBox26.Text = "";
            TextBox textBox27_1 = TextBox27;
            point1 = new Point(224, 408);
            Point point67 = point1;
            textBox27_1.Location = point67;
            TextBox27.Name = "TextBox27";
            TextBox27.ReadOnly = true;
            TextBox textBox27_2 = TextBox27;
            size1 = new Size(136, 20);
            Size size67 = size1;
            textBox27_2.Size = size67;
            TextBox27.TabIndex = 4;
            TextBox27.TabStop = false;
            TextBox27.Tag = "rr15";
            TextBox27.Text = "";
            TextBox27.TextAlign = HorizontalAlignment.Right;
            TextBox28.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox28_1 = TextBox28;
            point1 = new Point(368, 408);
            Point point68 = point1;
            textBox28_1.Location = point68;
            TextBox28.Name = "TextBox28";
            TextBox28.ReadOnly = true;
            TextBox textBox28_2 = TextBox28;
            size1 = new Size(272, 20);
            Size size68 = size1;
            textBox28_2.Size = size68;
            TextBox28.TabIndex = 4;
            TextBox28.TabStop = false;
            TextBox28.Tag = "d15";
            TextBox28.Text = "";
            nudDead.Enabled = false;
            NumericUpDown nudDead1 = nudDead;
            point1 = new Point(152, 408);
            Point point69 = point1;
            nudDead1.Location = point69;
            NumericUpDown nudDead2 = nudDead;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num34 = num1;
            nudDead2.Maximum = num34;
            NumericUpDown nudDead3 = nudDead;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num35 = num1;
            nudDead3.Minimum = num35;
            nudDead.Name = "nudDead";
            NumericUpDown nudDead4 = nudDead;
            size1 = new Size(64, 20);
            Size size69 = size1;
            nudDead4.Size = size69;
            nudDead.TabIndex = 15;
            nudDead.Tag = "15";
            nudDead.TextAlign = HorizontalAlignment.Right;
            Label label15_1 = Label15;
            point1 = new Point(16, 408);
            Point point70 = point1;
            label15_1.Location = point70;
            Label15.Name = "Label15";
            Label label15_2 = Label15;
            size1 = new Size(64, 16);
            Size size70 = size1;
            label15_2.Size = size70;
            Label15.TabIndex = 5;
            Label15.Text = "Dead";
            TextBox29.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox29_1 = TextBox29;
            point1 = new Point(368, 432);
            Point point71 = point1;
            textBox29_1.Location = point71;
            TextBox29.Name = "TextBox29";
            TextBox29.ReadOnly = true;
            TextBox textBox29_2 = TextBox29;
            size1 = new Size(272, 20);
            Size size71 = size1;
            textBox29_2.Size = size71;
            TextBox29.TabIndex = 4;
            TextBox29.TabStop = false;
            TextBox29.Tag = "d16";
            TextBox29.Text = "";
            nudLowHlth.Enabled = false;
            NumericUpDown nudLowHlth1 = nudLowHlth;
            point1 = new Point(152, 384);
            Point point72 = point1;
            nudLowHlth1.Location = point72;
            NumericUpDown nudLowHlth2 = nudLowHlth;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num36 = num1;
            nudLowHlth2.Maximum = num36;
            NumericUpDown nudLowHlth3 = nudLowHlth;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num37 = num1;
            nudLowHlth3.Minimum = num37;
            nudLowHlth.Name = "nudLowHlth";
            NumericUpDown nudLowHlth4 = nudLowHlth;
            size1 = new Size(64, 20);
            Size size72 = size1;
            nudLowHlth4.Size = size72;
            nudLowHlth.TabIndex = 14;
            nudLowHlth.Tag = "14";
            nudLowHlth.TextAlign = HorizontalAlignment.Right;
            TextBox textBox30_1 = TextBox30;
            point1 = new Point(224, 432);
            Point point73 = point1;
            textBox30_1.Location = point73;
            TextBox30.Name = "TextBox30";
            TextBox30.ReadOnly = true;
            TextBox textBox30_2 = TextBox30;
            size1 = new Size(136, 20);
            Size size73 = size1;
            textBox30_2.Size = size73;
            TextBox30.TabIndex = 4;
            TextBox30.TabStop = false;
            TextBox30.Tag = "rr16";
            TextBox30.Text = "";
            TextBox30.TextAlign = HorizontalAlignment.Right;
            Label label16_1 = Label16;
            point1 = new Point(16, 432);
            Point point74 = point1;
            label16_1.Location = point74;
            Label16.Name = "Label16";
            Label label16_2 = Label16;
            size1 = new Size(64, 16);
            Size size74 = size1;
            label16_2.Size = size74;
            Label16.TabIndex = 5;
            Label16.Text = "Critical Hit";
            nudCrit.Enabled = false;
            NumericUpDown nudCrit1 = nudCrit;
            point1 = new Point(152, 432);
            Point point75 = point1;
            nudCrit1.Location = point75;
            NumericUpDown nudCrit2 = nudCrit;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num38 = num1;
            nudCrit2.Maximum = num38;
            NumericUpDown nudCrit3 = nudCrit;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num39 = num1;
            nudCrit3.Minimum = num39;
            nudCrit.Name = "nudCrit";
            NumericUpDown nudCrit4 = nudCrit;
            size1 = new Size(64, 20);
            Size size75 = size1;
            nudCrit4.Size = size75;
            nudCrit.TabIndex = 16;
            nudCrit.Tag = "16";
            nudCrit.TextAlign = HorizontalAlignment.Right;
            TextBox textBox31_1 = TextBox31;
            point1 = new Point(224, 456);
            Point point76 = point1;
            textBox31_1.Location = point76;
            TextBox31.Name = "TextBox31";
            TextBox31.ReadOnly = true;
            TextBox textBox31_2 = TextBox31;
            size1 = new Size(136, 20);
            Size size76 = size1;
            textBox31_2.Size = size76;
            TextBox31.TabIndex = 4;
            TextBox31.TabStop = false;
            TextBox31.Tag = "rr17";
            TextBox31.Text = "";
            TextBox31.TextAlign = HorizontalAlignment.Right;
            TextBox32.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox32_1 = TextBox32;
            point1 = new Point(368, 456);
            Point point77 = point1;
            textBox32_1.Location = point77;
            TextBox32.Name = "TextBox32";
            TextBox32.ReadOnly = true;
            TextBox textBox32_2 = TextBox32;
            size1 = new Size(272, 20);
            Size size77 = size1;
            textBox32_2.Size = size77;
            TextBox32.TabIndex = 4;
            TextBox32.TabStop = false;
            TextBox32.Tag = "d17";
            TextBox32.Text = "";
            nudTIA.Enabled = false;
            NumericUpDown nudTia1 = nudTIA;
            point1 = new Point(152, 456);
            Point point78 = point1;
            nudTia1.Location = point78;
            NumericUpDown nudTia2 = nudTIA;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num40 = num1;
            nudTia2.Maximum = num40;
            NumericUpDown nudTia3 = nudTIA;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num41 = num1;
            nudTia3.Minimum = num41;
            nudTIA.Name = "nudTIA";
            NumericUpDown nudTia4 = nudTIA;
            size1 = new Size(64, 20);
            Size size78 = size1;
            nudTia4.Size = size78;
            nudTIA.TabIndex = 17;
            nudTIA.Tag = "17";
            nudTIA.TextAlign = HorizontalAlignment.Right;
            Label label17_1 = Label17;
            point1 = new Point(16, 456);
            Point point79 = point1;
            label17_1.Location = point79;
            Label17.Name = "Label17";
            Label label17_2 = Label17;
            size1 = new Size(152, 16);
            Size size79 = size1;
            label17_2.Size = size79;
            Label17.TabIndex = 5;
            Label17.Text = "Target Immune to Assault";
            TextBox textBox33_1 = TextBox33;
            point1 = new Point(224, 480);
            Point point80 = point1;
            textBox33_1.Location = point80;
            TextBox33.Name = "TextBox33";
            TextBox33.ReadOnly = true;
            TextBox textBox33_2 = TextBox33;
            size1 = new Size(136, 20);
            Size size80 = size1;
            textBox33_2.Size = size80;
            TextBox33.TabIndex = 9;
            TextBox33.TabStop = false;
            TextBox33.Tag = "rr18";
            TextBox33.Text = "";
            TextBox33.TextAlign = HorizontalAlignment.Right;
            Label label18_1 = Label18;
            point1 = new Point(16, 480);
            Point point81 = point1;
            label18_1.Location = point81;
            Label18.Name = "Label18";
            Label label18_2 = Label18;
            size1 = new Size(64, 16);
            Size size81 = size1;
            label18_2.Size = size81;
            Label18.TabIndex = 13;
            Label18.Text = "Lay Mine";
            TextBox34.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox34_1 = TextBox34;
            point1 = new Point(368, 480);
            Point point82 = point1;
            textBox34_1.Location = point82;
            TextBox34.Name = "TextBox34";
            TextBox34.ReadOnly = true;
            TextBox textBox34_2 = TextBox34;
            size1 = new Size(272, 20);
            Size size82 = size1;
            textBox34_2.Size = size82;
            TextBox34.TabIndex = 11;
            TextBox34.TabStop = false;
            TextBox34.Tag = "d18";
            TextBox34.Text = "";
            TextBox textBox35_1 = TextBox35;
            point1 = new Point(224, 384);
            Point point83 = point1;
            textBox35_1.Location = point83;
            TextBox35.Name = "TextBox35";
            TextBox35.ReadOnly = true;
            TextBox textBox35_2 = TextBox35;
            size1 = new Size(136, 20);
            Size size83 = size1;
            textBox35_2.Size = size83;
            TextBox35.TabIndex = 4;
            TextBox35.TabStop = false;
            TextBox35.Tag = "rr14";
            TextBox35.Text = "";
            TextBox35.TextAlign = HorizontalAlignment.Right;
            TextBox36.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox36_1 = TextBox36;
            point1 = new Point(368, 384);
            Point point84 = point1;
            textBox36_1.Location = point84;
            TextBox36.Name = "TextBox36";
            TextBox36.ReadOnly = true;
            TextBox textBox36_2 = TextBox36;
            size1 = new Size(272, 20);
            Size size84 = size1;
            textBox36_2.Size = size84;
            TextBox36.TabIndex = 4;
            TextBox36.TabStop = false;
            TextBox36.Tag = "d14";
            TextBox36.Text = "";
            nudLMin.Enabled = false;
            NumericUpDown nudLmin1 = nudLMin;
            point1 = new Point(152, 480);
            Point point85 = point1;
            nudLmin1.Location = point85;
            NumericUpDown nudLmin2 = nudLMin;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num42 = num1;
            nudLmin2.Maximum = num42;
            NumericUpDown nudLmin3 = nudLMin;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num43 = num1;
            nudLmin3.Minimum = num43;
            nudLMin.Name = "nudLMin";
            NumericUpDown nudLmin4 = nudLMin;
            size1 = new Size(64, 20);
            Size size85 = size1;
            nudLmin4.Size = size85;
            nudLMin.TabIndex = 18;
            nudLMin.Tag = "18";
            nudLMin.TextAlign = HorizontalAlignment.Right;
            Label label19_1 = Label19;
            point1 = new Point(16, 384);
            Point point86 = point1;
            label19_1.Location = point86;
            Label19.Name = "Label19";
            Label label19_2 = Label19;
            size1 = new Size(64, 16);
            Size size86 = size1;
            label19_2.Size = size86;
            Label19.TabIndex = 5;
            Label19.Text = "Low Health";
            nudDMin.Enabled = false;
            NumericUpDown nudDmin1 = nudDMin;
            point1 = new Point(152, 504);
            Point point87 = point1;
            nudDmin1.Location = point87;
            NumericUpDown nudDmin2 = nudDMin;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num44 = num1;
            nudDmin2.Maximum = num44;
            NumericUpDown nudDmin3 = nudDMin;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num45 = num1;
            nudDmin3.Minimum = num45;
            nudDMin.Name = "nudDMin";
            NumericUpDown nudDmin4 = nudDMin;
            size1 = new Size(64, 20);
            Size size87 = size1;
            nudDmin4.Size = size87;
            nudDMin.TabIndex = 19;
            nudDMin.Tag = "19";
            nudDMin.TextAlign = HorizontalAlignment.Right;
            TextBox37.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox37_1 = TextBox37;
            point1 = new Point(368, 504);
            Point point88 = point1;
            textBox37_1.Location = point88;
            TextBox37.Name = "TextBox37";
            TextBox37.ReadOnly = true;
            TextBox textBox37_2 = TextBox37;
            size1 = new Size(272, 20);
            Size size88 = size1;
            textBox37_2.Size = size88;
            TextBox37.TabIndex = 11;
            TextBox37.TabStop = false;
            TextBox37.Tag = "d19";
            TextBox37.Text = "";
            Label label20_1 = Label20;
            point1 = new Point(16, 504);
            Point point89 = point1;
            label20_1.Location = point89;
            Label20.Name = "Label20";
            Label label20_2 = Label20;
            size1 = new Size(96, 16);
            Size size89 = size1;
            label20_2.Size = size89;
            Label20.TabIndex = 13;
            Label20.Text = "Disarm Mine";
            TextBox textBox38_1 = TextBox38;
            point1 = new Point(224, 504);
            Point point90 = point1;
            textBox38_1.Location = point90;
            TextBox38.Name = "TextBox38";
            TextBox38.ReadOnly = true;
            TextBox textBox38_2 = TextBox38;
            size1 = new Size(136, 20);
            Size size90 = size1;
            textBox38_2.Size = size90;
            TextBox38.TabIndex = 9;
            TextBox38.TabStop = false;
            TextBox38.Tag = "rr19";
            TextBox38.Text = "";
            TextBox38.TextAlign = HorizontalAlignment.Right;
            TextBox textBox39_1 = TextBox39;
            point1 = new Point(224, 536);
            Point point91 = point1;
            textBox39_1.Location = point91;
            TextBox39.Name = "TextBox39";
            TextBox39.ReadOnly = true;
            TextBox textBox39_2 = TextBox39;
            size1 = new Size(136, 20);
            Size size91 = size1;
            textBox39_2.Size = size91;
            TextBox39.TabIndex = 9;
            TextBox39.TabStop = false;
            TextBox39.Tag = "rr20";
            TextBox39.Text = "";
            TextBox39.TextAlign = HorizontalAlignment.Right;
            Label label21_1 = Label21;
            point1 = new Point(16, 560);
            Point point92 = point1;
            label21_1.Location = point92;
            Label21.Name = "Label21";
            Label label21_2 = Label21;
            size1 = new Size(80, 16);
            Size size92 = size1;
            label21_2.Size = size92;
            Label21.TabIndex = 13;
            Label21.Text = "Begin Search";
            TextBox textBox40_1 = TextBox40;
            point1 = new Point(224, 560);
            Point point93 = point1;
            textBox40_1.Location = point93;
            TextBox40.Name = "TextBox40";
            TextBox40.ReadOnly = true;
            TextBox textBox40_2 = TextBox40;
            size1 = new Size(136, 20);
            Size size93 = size1;
            textBox40_2.Size = size93;
            TextBox40.TabIndex = 9;
            TextBox40.TabStop = false;
            TextBox40.Tag = "rr21";
            TextBox40.Text = "";
            TextBox40.TextAlign = HorizontalAlignment.Right;
            Label label22_1 = Label22;
            point1 = new Point(16, 536);
            Point point94 = point1;
            label22_1.Location = point94;
            Label22.Name = "Label22";
            Label label22_2 = Label22;
            size1 = new Size(80, 16);
            Size size94 = size1;
            label22_2.Size = size94;
            Label22.TabIndex = 13;
            Label22.Text = "Begin Stealth";
            TextBox41.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox41_1 = TextBox41;
            point1 = new Point(368, 536);
            Point point95 = point1;
            textBox41_1.Location = point95;
            TextBox41.Name = "TextBox41";
            TextBox41.ReadOnly = true;
            TextBox textBox41_2 = TextBox41;
            size1 = new Size(272, 20);
            Size size95 = size1;
            textBox41_2.Size = size95;
            TextBox41.TabIndex = 11;
            TextBox41.TabStop = false;
            TextBox41.Tag = "d20";
            TextBox41.Text = "";
            nudStlh.Enabled = false;
            NumericUpDown nudStlh1 = nudStlh;
            point1 = new Point(152, 536);
            Point point96 = point1;
            nudStlh1.Location = point96;
            NumericUpDown nudStlh2 = nudStlh;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num46 = num1;
            nudStlh2.Maximum = num46;
            NumericUpDown nudStlh3 = nudStlh;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num47 = num1;
            nudStlh3.Minimum = num47;
            nudStlh.Name = "nudStlh";
            NumericUpDown nudStlh4 = nudStlh;
            size1 = new Size(64, 20);
            Size size96 = size1;
            nudStlh4.Size = size96;
            nudStlh.TabIndex = 20;
            nudStlh.Tag = "20";
            nudStlh.TextAlign = HorizontalAlignment.Right;
            nudSrch.Enabled = false;
            NumericUpDown nudSrch1 = nudSrch;
            point1 = new Point(152, 560);
            Point point97 = point1;
            nudSrch1.Location = point97;
            NumericUpDown nudSrch2 = nudSrch;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num48 = num1;
            nudSrch2.Maximum = num48;
            NumericUpDown nudSrch3 = nudSrch;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num49 = num1;
            nudSrch3.Minimum = num49;
            nudSrch.Name = "nudSrch";
            NumericUpDown nudSrch4 = nudSrch;
            size1 = new Size(64, 20);
            Size size97 = size1;
            nudSrch4.Size = size97;
            nudSrch.TabIndex = 21;
            nudSrch.Tag = "21";
            nudSrch.TextAlign = HorizontalAlignment.Right;
            TextBox42.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox42_1 = TextBox42;
            point1 = new Point(368, 560);
            Point point98 = point1;
            textBox42_1.Location = point98;
            TextBox42.Name = "TextBox42";
            TextBox42.ReadOnly = true;
            TextBox textBox42_2 = TextBox42;
            size1 = new Size(272, 20);
            Size size98 = size1;
            textBox42_2.Size = size98;
            TextBox42.TabIndex = 11;
            TextBox42.TabStop = false;
            TextBox42.Tag = "d21";
            TextBox42.Text = "";
            TextBox47.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox47_1 = TextBox47;
            point1 = new Point(368, 640);
            Point point99 = point1;
            textBox47_1.Location = point99;
            TextBox47.Name = "TextBox47";
            TextBox47.ReadOnly = true;
            TextBox textBox47_2 = TextBox47;
            size1 = new Size(272, 20);
            Size size99 = size1;
            textBox47_2.Size = size99;
            TextBox47.TabIndex = 18;
            TextBox47.TabStop = false;
            TextBox47.Tag = "d24";
            TextBox47.Text = "";
            nudSucceedUnlock.Enabled = false;
            NumericUpDown nudSucceedUnlock1 = nudSucceedUnlock;
            point1 = new Point(152, 640);
            Point point100 = point1;
            nudSucceedUnlock1.Location = point100;
            NumericUpDown nudSucceedUnlock2 = nudSucceedUnlock;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num50 = num1;
            nudSucceedUnlock2.Maximum = num50;
            NumericUpDown nudSucceedUnlock3 = nudSucceedUnlock;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num51 = num1;
            nudSucceedUnlock3.Minimum = num51;
            nudSucceedUnlock.Name = "nudSucceedUnlock";
            NumericUpDown nudSucceedUnlock4 = nudSucceedUnlock;
            size1 = new Size(64, 20);
            Size size100 = size1;
            nudSucceedUnlock4.Size = size100;
            nudSucceedUnlock.TabIndex = 24;
            nudSucceedUnlock.Tag = "24";
            nudSucceedUnlock.TextAlign = HorizontalAlignment.Right;
            nudLeaveParty.Enabled = false;
            NumericUpDown nudLeaveParty1 = nudLeaveParty;
            point1 = new Point(152, 664);
            Point point101 = point1;
            nudLeaveParty1.Location = point101;
            NumericUpDown nudLeaveParty2 = nudLeaveParty;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num52 = num1;
            nudLeaveParty2.Maximum = num52;
            NumericUpDown nudLeaveParty3 = nudLeaveParty;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num53 = num1;
            nudLeaveParty3.Minimum = num53;
            nudLeaveParty.Name = "nudLeaveParty";
            NumericUpDown nudLeaveParty4 = nudLeaveParty;
            size1 = new Size(64, 20);
            Size size101 = size1;
            nudLeaveParty4.Size = size101;
            nudLeaveParty.TabIndex = 25;
            nudLeaveParty.Tag = "25";
            nudLeaveParty.TextAlign = HorizontalAlignment.Right;
            TextBox48.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox48_1 = TextBox48;
            point1 = new Point(368, 664);
            Point point102 = point1;
            textBox48_1.Location = point102;
            TextBox48.Name = "TextBox48";
            TextBox48.ReadOnly = true;
            TextBox textBox48_2 = TextBox48;
            size1 = new Size(272, 20);
            Size size102 = size1;
            textBox48_2.Size = size102;
            TextBox48.TabIndex = 19;
            TextBox48.TabStop = false;
            TextBox48.Tag = "d25";
            TextBox48.Text = "";
            TextBox textBox49_1 = TextBox49;
            point1 = new Point(224, 664);
            Point point103 = point1;
            textBox49_1.Location = point103;
            TextBox49.Name = "TextBox49";
            TextBox49.ReadOnly = true;
            TextBox textBox49_2 = TextBox49;
            size1 = new Size(136, 20);
            Size size103 = size1;
            textBox49_2.Size = size103;
            TextBox49.TabIndex = 16;
            TextBox49.TabStop = false;
            TextBox49.Tag = "rr25";
            TextBox49.Text = "";
            TextBox49.TextAlign = HorizontalAlignment.Right;
            TextBox textBox50_1 = TextBox50;
            point1 = new Point(224, 640);
            Point point104 = point1;
            textBox50_1.Location = point104;
            TextBox50.Name = "TextBox50";
            TextBox50.ReadOnly = true;
            TextBox textBox50_2 = TextBox50;
            size1 = new Size(136, 20);
            Size size104 = size1;
            textBox50_2.Size = size104;
            TextBox50.TabIndex = 17;
            TextBox50.TabStop = false;
            TextBox50.Tag = "rr24";
            TextBox50.Text = "";
            TextBox50.TextAlign = HorizontalAlignment.Right;
            Label label25_1 = Label25;
            point1 = new Point(16, 712);
            Point point105 = point1;
            label25_1.Location = point105;
            Label25.Name = "Label25";
            Label label25_2 = Label25;
            size1 = new Size(80, 16);
            Size size105 = size1;
            label25_2.Size = size105;
            Label25.TabIndex = 20;
            Label25.Text = "Poisoned";
            Label label26_1 = Label26;
            point1 = new Point(16, 640);
            Point point106 = point1;
            label26_1.Location = point106;
            Label26.Name = "Label26";
            Label label26_2 = Label26;
            size1 = new Size(88, 16);
            Size size106 = size1;
            label26_2.Size = size106;
            Label26.TabIndex = 21;
            Label26.Text = "Unlock Success";
            TextBox51.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox51_1 = TextBox51;
            point1 = new Point(368, 688);
            Point point107 = point1;
            textBox51_1.Location = point107;
            TextBox51.Name = "TextBox51";
            TextBox51.ReadOnly = true;
            TextBox textBox51_2 = TextBox51;
            size1 = new Size(272, 20);
            Size size107 = size1;
            textBox51_2.Size = size107;
            TextBox51.TabIndex = 18;
            TextBox51.TabStop = false;
            TextBox51.Tag = "d26";
            TextBox51.Text = "";
            nudRejoinParty.Enabled = false;
            NumericUpDown nudRejoinParty1 = nudRejoinParty;
            point1 = new Point(152, 688);
            Point point108 = point1;
            nudRejoinParty1.Location = point108;
            NumericUpDown nudRejoinParty2 = nudRejoinParty;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num54 = num1;
            nudRejoinParty2.Maximum = num54;
            NumericUpDown nudRejoinParty3 = nudRejoinParty;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num55 = num1;
            nudRejoinParty3.Minimum = num55;
            nudRejoinParty.Name = "nudRejoinParty";
            NumericUpDown nudRejoinParty4 = nudRejoinParty;
            size1 = new Size(64, 20);
            Size size108 = size1;
            nudRejoinParty4.Size = size108;
            nudRejoinParty.TabIndex = 26;
            nudRejoinParty.Tag = "26";
            nudRejoinParty.TextAlign = HorizontalAlignment.Right;
            nudPoisoned.Enabled = false;
            NumericUpDown nudPoisoned1 = nudPoisoned;
            point1 = new Point(152, 712);
            Point point109 = point1;
            nudPoisoned1.Location = point109;
            NumericUpDown nudPoisoned2 = nudPoisoned;
            num1 = new Decimal(new int[4] { 300000, 0, 0, 0 });
            Decimal num56 = num1;
            nudPoisoned2.Maximum = num56;
            NumericUpDown nudPoisoned3 = nudPoisoned;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num57 = num1;
            nudPoisoned3.Minimum = num57;
            nudPoisoned.Name = "nudPoisoned";
            NumericUpDown nudPoisoned4 = nudPoisoned;
            size1 = new Size(64, 20);
            Size size109 = size1;
            nudPoisoned4.Size = size109;
            nudPoisoned.TabIndex = 27;
            nudPoisoned.Tag = "27";
            nudPoisoned.TextAlign = HorizontalAlignment.Right;
            TextBox52.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox52_1 = TextBox52;
            point1 = new Point(368, 712);
            Point point110 = point1;
            textBox52_1.Location = point110;
            TextBox52.Name = "TextBox52";
            TextBox52.ReadOnly = true;
            TextBox textBox52_2 = TextBox52;
            size1 = new Size(272, 20);
            Size size110 = size1;
            textBox52_2.Size = size110;
            TextBox52.TabIndex = 19;
            TextBox52.TabStop = false;
            TextBox52.Tag = "d27";
            TextBox52.Text = "";
            TextBox textBox53_1 = TextBox53;
            point1 = new Point(224, 712);
            Point point111 = point1;
            textBox53_1.Location = point111;
            TextBox53.Name = "TextBox53";
            TextBox53.ReadOnly = true;
            TextBox textBox53_2 = TextBox53;
            size1 = new Size(136, 20);
            Size size111 = size1;
            textBox53_2.Size = size111;
            TextBox53.TabIndex = 16;
            TextBox53.TabStop = false;
            TextBox53.Tag = "rr27";
            TextBox53.Text = "";
            TextBox53.TextAlign = HorizontalAlignment.Right;
            TextBox textBox54_1 = TextBox54;
            point1 = new Point(224, 688);
            Point point112 = point1;
            textBox54_1.Location = point112;
            TextBox54.Name = "TextBox54";
            TextBox54.ReadOnly = true;
            TextBox textBox54_2 = TextBox54;
            size1 = new Size(136, 20);
            Size size112 = size1;
            textBox54_2.Size = size112;
            TextBox54.TabIndex = 17;
            TextBox54.TabStop = false;
            TextBox54.Tag = "rr26";
            TextBox54.Text = "";
            TextBox54.TextAlign = HorizontalAlignment.Right;
            Label label111_1 = label111;
            point1 = new Point(16, 688);
            Point point113 = point1;
            label111_1.Location = point113;
            label111.Name = "label111";
            Label label111_2 = label111;
            size1 = new Size(80, 16);
            Size size113 = size1;
            label111_2.Size = size113;
            label111.TabIndex = 20;
            label111.Text = "Rejoin Party";
            Label label28_1 = Label28;
            point1 = new Point(16, 664);
            Point point114 = point1;
            label28_1.Location = point114;
            Label28.Name = "Label28";
            Label label28_2 = Label28;
            size1 = new Size(112, 16);
            Size size114 = size1;
            label28_2.Size = size114;
            Label28.TabIndex = 21;
            Label28.Text = "Separate from Party";
            MainMenu1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[2]
            {
                ToolStripMenuItem1,
                ToolStripMenuItem2
            });
            ToolStripMenuItem1.Index = 0;
            ToolStripMenuItem1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[6]
            {
                miNew,
                miOpen,
                miSave,
                miSaveAs,
                ToolStripMenuItem5,
                miQuit
            });
            ToolStripMenuItem1.Text = "&File";
            miNew.Index = 0;
            miNew.Shortcut = Shortcut.CtrlN;
            miNew.Text = "&New";
            miOpen.Index = 1;
            miOpen.Shortcut = Shortcut.CtrlO;
            miOpen.Text = "&Open...";
            miSave.Enabled = false;
            miSave.Index = 2;
            miSave.Shortcut = Shortcut.CtrlS;
            miSave.Text = "&Save";
            miSaveAs.Enabled = false;
            miSaveAs.Index = 3;
            miSaveAs.Text = "Save &As...";
            ToolStripMenuItem5.Index = 4;
            ToolStripMenuItem5.Text = "-";
            miQuit.Index = 5;
            miQuit.Text = "E&xit";
            ToolStripMenuItem2.Index = 1;
            ToolStripMenuItem2.ToolStripMenuItems.AddRange(new ToolStripMenuItem[4]
            {
                miUseK1DialogTlk,
                miUseK2DialogTlk,
                miUseExtDialogTlk,
                miAskDialogTlk
            });
            ToolStripMenuItem2.Text = "Options";
            miUseK1DialogTlk.Index = 0;
            miUseK1DialogTlk.Text = "Use KotOR I Dialog.Tlk";
            miUseK2DialogTlk.Index = 1;
            miUseK2DialogTlk.Text = "Use KotOR II Dialog.Tlk";
            miUseExtDialogTlk.Index = 2;
            miUseExtDialogTlk.Text = "Use External Dialog.Tlk";
            miAskDialogTlk.Checked = true;
            miAskDialogTlk.Index = 3;
            miAskDialogTlk.Text = "Ask which Dialog.Tlk for each file";
            StatusBar statusBar1_1 = StatusBar1;
            point1 = new Point(0, 363);
            Point point115 = point1;
            statusBar1_1.Location = point115;
            StatusBar1.Name = "StatusBar1";
            StatusBar statusBar1_2 = StatusBar1;
            size1 = new Size(688, 22);
            Size size115 = size1;
            statusBar1_2.Size = size115;
            StatusBar1.TabIndex = 7;
            StatusBar1.Text = "StatusBar1";
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            size1 = new Size(688, 385);
            ClientSize = size1;
            Controls.Add(StatusBar1);
            Controls.Add(Panel1);
            Menu = MainMenu1;
            Name = nameof(frmSSFEditor);
            SizeGripStyle = SizeGripStyle.Show;
            Text = "SSF Editor";
            nudBat1.EndInit();
            nudBat2.EndInit();
            nudBat3.EndInit();
            nudBat4.EndInit();
            Panel1.ResumeLayout(false);
            nudTryUnlock.EndInit();
            nudFailUnlock.EndInit();
            nudBat5.EndInit();
            nudBat6.EndInit();
            nudSel1.EndInit();
            nudSel3.EndInit();
            nudSel2.EndInit();
            nudAtk2.EndInit();
            nudAtk1.EndInit();
            nudAtk3.EndInit();
            nudHit2.EndInit();
            nudHit1.EndInit();
            nudDead.EndInit();
            nudLowHlth.EndInit();
            nudCrit.EndInit();
            nudTIA.EndInit();
            nudLMin.EndInit();
            nudDMin.EndInit();
            nudStlh.EndInit();
            nudSrch.EndInit();
            nudSucceedUnlock.EndInit();
            nudLeaveParty.EndInit();
            nudRejoinParty.EndInit();
            nudPoisoned.EndInit();
            ResumeLayout(false);
        }

    public frmSSFEditor(FileStream fs, int KotorVersionIndex)
        : this(new ClsSsf(fs, KotorVersionIndex))
    {
            fs.Close();
        }

    public frmSSFEditor(string filepath, int KotorVersionIndex)
        : this(new FileStream(filepath, FileMode.Open), KotorVersionIndex)
    {
        }

    public frmSSFEditor(ClsSsf SSF)
        : this()
    {
            _SSF = SSF;
            ParseSSF();
        }

    private int KotorVersion()
    {
            frmSpecifyKotorVersion specifyKotorVersion = new frmSpecifyKotorVersion();
            specifyKotorVersion.btnCancel.Visible = false;
            return specifyKotorVersion.ShowDialog(this) == DialogResult.OK
                ? specifyKotorVersion.KotorVerIndexSelected
                : -1;
        }

    private void ParseSSF()
    {
            int index = 0;
            do
            {
                Control controlAndSetValue1 = FindControlAndSetValue(Convert.ToString(index),
                    StringType.FromInteger(_SSF.get_RefArray(index)));
                FindControlAndSetValue("rr" + StringType.FromInteger(index), _SSF.get_RefArraySoundResRef(index));
                Control controlAndSetValue2 =
                    FindControlAndSetValue("d" + StringType.FromInteger(index), _SSF.get_RefArrayString(index));
                ((NumericUpDown)controlAndSetValue1).ValueChanged += new EventHandler(nud_ValueChanged);
                controlAndSetValue2.MouseEnter += new EventHandler(tbDesc_MouseEnter);
                controlAndSetValue1.Enabled = true;
                checked
                {
                    ++index;
                }
            } while (index <= 27);
        }

    private void LoadDialogTlk(bool promptForVersion = true)
    {
            bool flag = false;
            string path = null;
            if (miUseK1DialogTlk.Checked && (KotorVersionIndex == 1 || KotorVersionIndex == -1))
            {
                path = Path.Combine(UserSettings.GetSettings().KotorLocation(0), "dialog.tlk");
                KotorVersionIndex = 0;
                flag = true;
            }

            if (miUseK2DialogTlk.Checked && (KotorVersionIndex == 0 || KotorVersionIndex == -1))
            {
                path = Path.Combine(UserSettings.GetSettings().KotorLocation(1), "dialog.tlk");
                KotorVersionIndex = 1;
                flag = true;
            }

            if (miAskDialogTlk.Checked && promptForVersion)
            {
                int num = KotorVersion();
                if (num == -1)
                    return;
                if (KotorVersionIndex != num)
                {
                    KotorVersionIndex = num;
                    path = Path.Combine(UserSettings.GetSettings().KotorLocation(KotorVersionIndex), "dialog.tlk");
                    flag = true;
                }
            }

            if (miUseExtDialogTlk.Checked && (KotorVersionIndex > -1 || g_dialogtlk == null))
            {
                g_dialogtlk = null;
                GetExternalDialogTlk();
                KotorVersionIndex = -1;
            }
            else
            {
                if (!flag)
                    return;
                g_dialogtlk = new clsDialogTlk(path, true);
                StatusBar1.Text = "Dialog.Tlk: " + path + " (KotOR I";
                if (KotorVersionIndex == 0)
                    StatusBar1.Text += ")";
                else
                    StatusBar1.Text += "I)";
            }
        }

    private void GetExternalDialogTlk()
    {
            string startPath = null;
            if (FrmMain.IsOnly1KotORInstalled())
            {
                if (FrmMain.HasKotor1())
                    startPath = UserSettings.GetSettings().KotorLocation(0);
                if (FrmMain.HasKotor2())
                    startPath = UserSettings.GetSettings().KotorLocation(1);
            }
            else
                startPath = UserSettings.GetSettings().defaultImportLocation;

            object objectValue =
                RuntimeHelpers.GetObjectValue(FrmMain.GetFilePath("load", startPath, "*.tlk", "Open Dialog.Tlk file...",
                    "tlk"));
            if (objectValue.GetType() != typeof(string) || ObjectType.ObjTst(objectValue, "", false) == 0)
                return;
            string path = StringType.FromObject(objectValue);
            if (!path.ToLower().EndsWith(".tlk") && Interaction.MsgBox(
                    "The file you selected does not have a .TLK extension; do you want to open it?",
                    MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2,
                    "Questionable file extension") == MsgBoxResult.No)
                return;
            g_dialogtlk = new clsDialogTlk(path, true);
            StatusBar1.Text = "Dialog.Tlk: " + path + " (External)";
        }

    public void SetFormName(string Name) => Text = "SSF Editor - " + Name;

    private Control FindControlAndSetValue(string tagStr, string value)
    {
            Control controlAndSetValue = null;
            try
            {
                foreach (Control control in Panel1.Controls)
                {
                    if (control.Tag != null && StringType.StrCmp(control.Tag.ToString(), tagStr, false) == 0)
                    {
                        if (StringType.StrCmp(control.GetType().Name, "NumericUpDown", false) == 0)
                            ((NumericUpDown)control).Value = new Decimal(Convert.ToDouble(value));
                        else
                            control.Text = value;
                        controlAndSetValue = control;
                        break;
                    }
                }
            }
            finally
            {
               
            }

            return controlAndSetValue;
        }

    public void EnableControls()
    {
            miSave.Enabled = true;
            miSaveAs.Enabled = true;
        }

    private void miNew_Click(object sender, EventArgs e)
    {
            int KotorVerIndex = KotorVersion();
            if (KotorVerIndex <= -1)
                return;
            _SSF = new ClsSsf(KotorVerIndex);
            int index = 0;
            do
            {
                _SSF.set_RefArray(index, -1);
                checked
                {
                    ++index;
                }
            } while (index <= 39);

            ParseSSF();
            EnableControls();
        }

    private void miOpen_Click(object sender, EventArgs e)
    {
            string str = StringType.FromObject(FrmMain.GetFilePath("load", CurrentSettings.defaultSaveLocation, "",
                "Load SSF file...", "ssf"));
            if (StringType.StrCmp(str, "", false) == 0)
                return;
            LoadDialogTlk();
            if (g_dialogtlk != null)
            {
                _SSF = new ClsSsf(new FileStream(str, FileMode.Open), g_dialogtlk);
                ParseSSF();
                SetFormName(str);
                EnableControls();
            }
            else
            {
                int num = (int)Interaction.MsgBox("Dialog.Tlk not loaded; opening of file aborted!",
                    MsgBoxStyle.Exclamation);
            }
        }

    private void miSave_Click(object sender, EventArgs e)
    {
            if (StringType.StrCmp(g_filepath, "", false) != 0)
                _SSF.WriteFile(g_filepath);
            else
                miSaveAs_Click(RuntimeHelpers.GetObjectValue(sender), e);
        }

    private void miSaveAs_Click(object sender, EventArgs e)
    {
            string str = StringType.FromObject(FrmMain.GetFilePath("save", CurrentSettings.defaultSaveLocation, "",
                "Save SSF file as...", "ssf"));
            if (StringType.StrCmp(str, "", false) == 0)
                return;
            _SSF.WriteFile(str);
            g_filepath = str;
        }

    private void miQuit_Click(object sender, EventArgs e) => Close();

    private void UseDialogTlk_Click(object sender, EventArgs e)
    {
            miUseK1DialogTlk.Checked = false;
            miUseK2DialogTlk.Checked = false;
            miUseExtDialogTlk.Checked = false;
            miAskDialogTlk.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
            LoadDialogTlk(false);
        }

    private void nud_ValueChanged(object sender, EventArgs e)
    {
            int int32 = Convert.ToInt32(
                RuntimeHelpers.GetObjectValue(LateBinding.LateGet(sender, null, "tag", new object[0], null, null)));
            _SSF.set_RefArray(int32,
                IntegerType.FromObject(LateBinding.LateGet(sender, null, "Value", new object[0], null, null)));
            FindControlAndSetValue("rr" + StringType.FromInteger(int32), _SSF.get_RefArraySoundResRef(int32));
            FindControlAndSetValue("d" + StringType.FromInteger(int32), _SSF.get_RefArrayString(int32));
        }

    private void frmSSFEditor_Load(object sender, EventArgs e)
    {
            miUseK1DialogTlk.Visible = FrmMain.HasKotor1();
            miUseK2DialogTlk.Visible = FrmMain.HasKotor2();
        }

    private void tbDesc_MouseEnter(object sender, EventArgs e) =>
        ToolTip1.SetToolTip((Control)sender, ((TextBox)sender).Text);
}