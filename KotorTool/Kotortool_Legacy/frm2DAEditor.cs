// Decompiled with JetBrains decompiler
// Type: kotor_tool.frm2DAEditor
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frm2DAEditor : Form
{
    [AccessedThroughProperty("ToolStripMenuItem3")] private ToolStripMenuItem _ToolStripMenuItem3;

    [AccessedThroughProperty("miTestFunction")]
    private ToolStripMenuItem _miTestFunction;

    [AccessedThroughProperty("dt")] private DataTable _dt;

    [AccessedThroughProperty("cmiInsertRow")]
    private ToolStripMenuItem _cmiInsertRow;

    [AccessedThroughProperty("miSave2daV2b")]
    private ToolStripMenuItem _miSave2daV2b;

    [AccessedThroughProperty("cmiPasteRow")]
    private ToolStripMenuItem _cmiPasteRow;

    [AccessedThroughProperty("cmiInsertCopiedRow")]
    private ToolStripMenuItem _cmiInsertCopiedRow;

    [AccessedThroughProperty("miResetSort")]
    private ToolStripMenuItem _miResetSort;

    [AccessedThroughProperty("miLoad2da")] private ToolStripMenuItem _miLoad2da;

    [AccessedThroughProperty("cmiRenumberRowLabelColumn")]
    private ToolStripMenuItem _cmiRenumberRowLabelColumn;

    [AccessedThroughProperty("cmiShowStrings")]
    private ToolStripMenuItem _cmiShowStrings;

    [AccessedThroughProperty("cm")] private ContextMenu _cm;
    [AccessedThroughProperty("dg2DA")] private TwoDADataGrid _dg2DA;

    [AccessedThroughProperty("cmiCopyRow")]
    private ToolStripMenuItem _cmiCopyRow;

    [AccessedThroughProperty("miSetKotORversion")]
    private ToolStripMenuItem _miSetKotORversion;

    [AccessedThroughProperty("miSave2daV2bXML")]
    private ToolStripMenuItem _miSave2daV2bXML;

    [AccessedThroughProperty("ToolStripMenuItem2")] private ToolStripMenuItem _ToolStripMenuItem2;
    [AccessedThroughProperty("miQuit")] private ToolStripMenuItem _miQuit;

    [AccessedThroughProperty("miLoad2daXml")]
    private ToolStripMenuItem _miLoad2daXml;

    [AccessedThroughProperty("ToolStripMenuItem1")] private ToolStripMenuItem _ToolStripMenuItem1;
    [AccessedThroughProperty("ToolStripMenuItem6")] private ToolStripMenuItem _ToolStripMenuItem6;
    [AccessedThroughProperty("miUndoAll")] private ToolStripMenuItem _miUndoAll;
    [AccessedThroughProperty("ToolStripMenuItem4")] private ToolStripMenuItem _ToolStripMenuItem4;
    [AccessedThroughProperty("MainMenu1")] private MainMenu _MainMenu1;
    [AccessedThroughProperty("ToolStripMenuItem5")] private ToolStripMenuItem _ToolStripMenuItem5;
    private IContainer components;
    private DataView DView;
    private DataGridCell lastGDcell;
    private byte[] ary2da;
    private string fname;
    private int numRows;
    private int numColumns;
    private string[] colNames;
    private string[] rowLabels;
    private int gClickedRow;
    private int gClickedColumn;
    private string XMLfilepath;
    private string filetype;
    private DataRow clipboardDataRow;
    private int KotorVersionIndex;
    private int LastKotorVersionIndex;
    private clsDialogTlk g_DialogTlk;

    public frm2DAEditor()
    {
            Load += new EventHandler(frm2DAEditor_Load);
            Closing += new CancelEventHandler(frm2DAEditor_Closing);
            Move += new EventHandler(frm2DAEditor_Move);
            dt = new DataTable();
            lastGDcell = new DataGridCell();
            cm = new ContextMenu();
           /*cmiInsertRow = new ToolStripMenuItem("Insert Row");

            miCopyRow = new ToolStripMenuItem("Copy Row");

            miPasteRow = new ToolStripMenuItem("Paste Row");

            miInsertCopiedRow = new ToolStripMenuItem("Insert Copied Row");

            miRenumberRowLabelColumn = new ToolStripMenuItem("Renumber Row Labels");

            miShowStrings = new ToolStripMenuItem("Show Strings for Refs");*/
            InitializeComponent();
        }

    protected override void Dispose(bool disposing)
    {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

    internal virtual TwoDADataGrid dg2DA
    {
        get => _dg2DA;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_dg2DA != null)
                    _dg2DA.MouseUp -= new MouseEventHandler(dg_MouseUp);
                _dg2DA = value;
                if (_dg2DA == null)
                    return;
                _dg2DA.MouseUp += new MouseEventHandler(dg_MouseUp);
            }
    }

    internal virtual MainMenu MainMenu1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_MainMenu1 == null)
                    ;
                _MainMenu1 = value;
                if (_MainMenu1 == null)
                    ;
            }
        get => _MainMenu1;
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

    internal virtual ToolStripMenuItem miLoad2da
    {
        get => _miLoad2da;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miLoad2da != null)
                    _miLoad2da.Click -= new EventHandler(miLoad2da_Click);
                _miLoad2da = value;
                if (_miLoad2da == null)
                    return;
                _miLoad2da.Click += new EventHandler(miLoad2da_Click);
            }
    }

    internal virtual ToolStripMenuItem miSave2daV2b
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miSave2daV2b != null)
                    _miSave2daV2b.Click -= new EventHandler(miSave2daV2b_Click);
                _miSave2daV2b = value;
                if (_miSave2daV2b == null)
                    return;
                _miSave2daV2b.Click += new EventHandler(miSave2daV2b_Click);
            }
        get => _miSave2daV2b;
    }

    internal virtual ToolStripMenuItem miSave2daV2bXML
    {
        get => _miSave2daV2bXML;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miSave2daV2bXML != null)
                    _miSave2daV2bXML.Click -= new EventHandler(miSave2daV2bXML_Click);
                _miSave2daV2bXML = value;
                if (_miSave2daV2bXML == null)
                    return;
                _miSave2daV2bXML.Click += new EventHandler(miSave2daV2bXML_Click);
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

    internal virtual ToolStripMenuItem miQuit
    {
        get => _miQuit;
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
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem2
    {
        get => _ToolStripMenuItem2;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_ToolStripMenuItem2 == null)
                    ;
                _ToolStripMenuItem2 = value;
                if (_ToolStripMenuItem2 == null)
                    ;
            }
    }

    internal virtual ToolStripMenuItem miResetSort
    {
        get => _miResetSort;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miResetSort != null)
                    _miResetSort.Click -= new EventHandler(miResetSort_Click);
                _miResetSort = value;
                if (_miResetSort == null)
                    return;
                _miResetSort.Click += new EventHandler(miResetSort_Click);
            }
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem4
    {
        get => _ToolStripMenuItem4;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_ToolStripMenuItem4 == null)
                    ;
                _ToolStripMenuItem4 = value;
                if (_ToolStripMenuItem4 == null)
                    ;
            }
    }

    internal virtual ToolStripMenuItem miUndoAll
    {
        get => _miUndoAll;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miUndoAll != null)
                    _miUndoAll.Click -= new EventHandler(miUndoAll_Click);
                _miUndoAll = value;
                if (_miUndoAll == null)
                    return;
                _miUndoAll.Click += new EventHandler(miUndoAll_Click);
            }
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem6
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_ToolStripMenuItem6 == null)
                    ;
                _ToolStripMenuItem6 = value;
                if (_ToolStripMenuItem6 == null)
                    ;
            }
        get => _ToolStripMenuItem6;
    }

    internal virtual ToolStripMenuItem miLoad2daXml
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miLoad2daXml != null)
                    _miLoad2daXml.Click -= new EventHandler(miLoad2daXml_Click);
                _miLoad2daXml = value;
                if (_miLoad2daXml == null)
                    return;
                _miLoad2daXml.Click += new EventHandler(miLoad2daXml_Click);
            }
        get => _miLoad2daXml;
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem3
    {
        get => _ToolStripMenuItem3;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_ToolStripMenuItem3 == null)
                    ;
                _ToolStripMenuItem3 = value;
                if (_ToolStripMenuItem3 == null)
                    ;
            }
    }

    internal virtual ToolStripMenuItem miSetKotORversion
    {
        get => _miSetKotORversion;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miSetKotORversion != null)
                    _miSetKotORversion.Click -= new EventHandler(miSetKotORversion_Click);
                _miSetKotORversion = value;
                if (_miSetKotORversion == null)
                    return;
                _miSetKotORversion.Click += new EventHandler(miSetKotORversion_Click);
            }
    }

    internal virtual ToolStripMenuItem miTestFunction
    {
        get => _miTestFunction;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_miTestFunction != null)
                    _miTestFunction.Click -= new EventHandler(miTestFunction_Click);
                _miTestFunction = value;
                if (_miTestFunction == null)
                    return;
                _miTestFunction.Click += new EventHandler(miTestFunction_Click);
            }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
            ResourceManager resourceManager = new ResourceManager(typeof(frm2DAEditor));
            dg2DA = new TwoDADataGrid();
            MainMenu1 = new MainMenu();
            ToolStripMenuItem1 = new ToolStripMenuItem();
            miLoad2da = new ToolStripMenuItem();
            miLoad2daXml = new ToolStripMenuItem();
            ToolStripMenuItem6 = new ToolStripMenuItem();
            miSave2daV2b = new ToolStripMenuItem();
            miSave2daV2bXML = new ToolStripMenuItem();
            ToolStripMenuItem5 = new ToolStripMenuItem();
            miQuit = new ToolStripMenuItem();
            ToolStripMenuItem2 = new ToolStripMenuItem();
            miResetSort = new ToolStripMenuItem();
            ToolStripMenuItem4 = new ToolStripMenuItem();
            miUndoAll = new ToolStripMenuItem();
            ToolStripMenuItem3 = new ToolStripMenuItem();
            miSetKotORversion = new ToolStripMenuItem();
            miTestFunction = new ToolStripMenuItem();
            dg2DA.BeginInit();
            SuspendLayout();
            dg2DA.DataMember = "";
            dg2DA.Dock = DockStyle.Fill;
            dg2DA.HeaderForeColor = SystemColors.ControlText;
            dg2DA.Location = new Point(0, 0);
            dg2DA.Name = "dg2DA";
            TwoDADataGrid dg2Da = dg2DA;
            Size size1 = new Size(560, 409);
            Size size2 = size1;
            dg2Da.Size = size2;
            dg2DA.TabIndex = 0;
            MainMenu1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[2]
            {
                ToolStripMenuItem1,
                ToolStripMenuItem2
            });
            ToolStripMenuItem1.Index = 0;
            ToolStripMenuItem1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[7]
            {
                miLoad2da,
                miLoad2daXml,
                ToolStripMenuItem6,
                miSave2daV2b,
                miSave2daV2bXML,
                ToolStripMenuItem5,
                miQuit
            });
            ToolStripMenuItem1.Text = "File";
            miLoad2da.Index = 0;
            miLoad2da.Shortcut = Shortcut.CtrlO;
            miLoad2da.Text = "Load 2DA v2.b file...";
            miLoad2daXml.Index = 1;
            miLoad2daXml.Shortcut = Shortcut.CtrlShiftO;
            miLoad2daXml.Text = "Load 2DA v2.b (XML) file...";
            ToolStripMenuItem6.Index = 2;
            ToolStripMenuItem6.Text = "-";
            miSave2daV2b.Index = 3;
            miSave2daV2b.Shortcut = Shortcut.CtrlS;
            miSave2daV2b.Text = "Save as 2DA v2.b...";
            miSave2daV2bXML.Index = 4;
            miSave2daV2bXML.Shortcut = Shortcut.CtrlShiftS;
            miSave2daV2bXML.Text = "Save as 2DA v2.b (XML) ...";
            ToolStripMenuItem5.Index = 5;
            ToolStripMenuItem5.Text = "-";
            miQuit.Index = 6;
            miQuit.Shortcut = Shortcut.CtrlQ;
            miQuit.Text = "Quit";
            ToolStripMenuItem2.Index = 1;
            ToolStripMenuItem2.ToolStripMenuItems.AddRange(new ToolStripMenuItem[6]
            {
                miResetSort,
                ToolStripMenuItem4,
                miUndoAll,
                ToolStripMenuItem3,
                miSetKotORversion,
                miTestFunction
            });
            ToolStripMenuItem2.Text = "Tools";
            miResetSort.Index = 0;
            miResetSort.Shortcut = Shortcut.F5;
            miResetSort.Text = "Reset Sort";
            ToolStripMenuItem4.Index = 1;
            ToolStripMenuItem4.Text = "-";
            miUndoAll.Index = 2;
            miUndoAll.Text = "Undo All Changes";
            ToolStripMenuItem3.Index = 3;
            ToolStripMenuItem3.Text = "-";
            miSetKotORversion.Index = 4;
            miSetKotORversion.Text = "Set KotOR version...";
            miTestFunction.Index = 5;
            miTestFunction.Text = "Test function";
            miTestFunction.Visible = false;
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            size1 = new Size(560, 409);
            ClientSize = size1;
            Controls.Add(dg2DA);
            Icon = (Icon)resourceManager.GetObject("$this.Icon");
            Menu = MainMenu1;
            size1 = new Size(248, 184);
            MinimumSize = size1;
            Name = nameof(frm2DAEditor);
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.Manual;
            Text = "2DA Editor";
            dg2DA.EndInit();
            ResumeLayout(false);
        }

    public virtual DataTable dt
    {
        get => _dt;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_dt == null)
                    ;
                _dt = value;
                if (_dt == null)
                    ;
            }
    }

    protected virtual ContextMenu cm
    {
        get => _cm;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_cm == null)
                    ;
                _cm = value;
                if (_cm == null)
                    ;
            }
    }

    /*private virtual ToolStripMenuItem cmiInsertRow
    {
        get => _cmiInsertRow;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cmiInsertRow != null)
                _cmiInsertRow.Click -= new EventHandler(cmiInsertRow_Click);
            _cmiInsertRow = value;
            if (_cmiInsertRow == null)
                return;
            _cmiInsertRow.Click += new EventHandler(cmiInsertRow_Click);
        }
    }

    private virtual ToolStripMenuItem cmiCopyRow
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cmiCopyRow != null)
                _cmiCopyRow.Click -= new EventHandler(cmiCopyRow_Click);
            _cmiCopyRow = value;
            if (_cmiCopyRow == null)
                return;
            _cmiCopyRow.Click += new EventHandler(cmiCopyRow_Click);
        }
        get => _cmiCopyRow;
    }

    private virtual ToolStripMenuItem cmiPasteRow
    {
        get => _cmiPasteRow;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cmiPasteRow != null)
                _cmiPasteRow.Click -= new EventHandler(cmiPasteRow_Click);
            _cmiPasteRow = value;
            if (_cmiPasteRow == null)
                return;
            _cmiPasteRow.Click += new EventHandler(cmiPasteRow_Click);
        }
    }

    private virtual ToolStripMenuItem cmiInsertCopiedRow
    {
        get => _cmiInsertCopiedRow;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cmiInsertCopiedRow != null)
                _cmiInsertCopiedRow.Click -= new EventHandler(cmiInsertCopiedRow_Click);
            _cmiInsertCopiedRow = value;
            if (_cmiInsertCopiedRow == null)
                return;
            _cmiInsertCopiedRow.Click += new EventHandler(cmiInsertCopiedRow_Click);
        }
    }

    private virtual ToolStripMenuItem cmiRenumberRowLabelColumn
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cmiRenumberRowLabelColumn != null)
                _cmiRenumberRowLabelColumn.Click -= new EventHandler(cmiRenumberRowLabelColumn_Click);
            _cmiRenumberRowLabelColumn = value;
            if (_cmiRenumberRowLabelColumn == null)
                return;
            _cmiRenumberRowLabelColumn.Click += new EventHandler(cmiRenumberRowLabelColumn_Click);
        }
        get => _cmiRenumberRowLabelColumn;
    }

    private virtual ToolStripMenuItem cmiShowStrings
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cmiShowStrings != null)
                _cmiShowStrings.Click -= new EventHandler(cmiShowStrings_Click);
            _cmiShowStrings = value;
            if (_cmiShowStrings == null)
                return;
            _cmiShowStrings.Click += new EventHandler(cmiShowStrings_Click);
        }
        get => _cmiShowStrings;
    }*/

    public frm2DAEditor(byte[] a2DA)
        : this()
    {
            ary2da = a2DA;
        }

    public frm2DAEditor(string filename, byte[] a2da, int KotorVersIndex = -1)
        : this()
    {
            fname = filename;
            ary2da = a2da;
            dt.TableName = filename;
            KotorVersionIndex = KotorVersIndex;
            LastKotorVersionIndex = KotorVersIndex;
            if (KotorVersIndex == 0)
            {
                Text += " - Kotor I";
            }
            else
            {
                if (KotorVersIndex != 1)
                    return;
                Text += " - Kotor II";
            }
        }

    public void CreateDataTable()
    {
            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            int num1 = checked(ary2da.Length - 1);
            int index1 = 9;
            while (index1 <= num1 && ary2da[index1] != 0)
                checked
                {
                    ++index1;
                }

            int index2 = checked(index1 + 1);
            numRows = checked((int)Math.Round(ary2da[index2] + ary2da[checked(index2 + 1)] * 256.0 +
                                              ary2da[checked(index2 + 2)] * 65536.0 +
                                              ary2da[checked(index2 + 3)] * 16777216.0));
            colNames = Strings.Split(asciiEncoding.GetString(ary2da, 9, checked(index1 - 10)), "\t");
            numColumns = colNames.Length;
            int num2 = 0;
            int num3 = checked(index2 + 4);
            int num4 = checked(ary2da.Length - 1);
            int index3 = num3;
            while (index3 <= num4)
            {
                if (ary2da[index3] == 9)
                {
                    checked
                    {
                        ++num2;
                    }

                    if (num2 == numRows)
                        break;
                }

                checked
                {
                    ++index3;
                }
            }

            int num5 = checked(index3 + 1);
            int num6 = num5;
            rowLabels = Strings.Split(asciiEncoding.GetString(ary2da, checked(index2 + 4), checked(num5 - index2 - 5)),
                "\t");
            int num7 = checked(num5 + (numRows * numColumns + 1) * 2);
            dt.Columns.Add(new DataColumn("(Row Label)", typeof(string)));
            int num8 = checked(numColumns - 1);
            int index4 = 0;
            while (index4 <= num8)
            {
                dt.Columns.Add(new DataColumn(colNames[index4])
                {
                    DefaultValue = ""
                });
                checked
                {
                    ++index4;
                }
            }

            int num9 = checked(numRows - 1);
            int index5 = 0;
            while (index5 <= num9)
            {
                DataRow row = dt.NewRow();
                row[0] = rowLabels[index5];
                int num10 = checked(colNames.Length - 1);
                int num11 = 0;
                while (num11 <= num10)
                {
                    int index6 = checked((num11 + index5 * numColumns) * 2 + num6);
                    int byteIndex = checked(num7 + ary2da[index6] + 256 * ary2da[index6 + 1]);
                    int num12 = byteIndex;
                    int num13 = checked(ary2da.Length - 1);
                    int index7 = num12;
                    while (index7 <= num13 && ary2da[index7] != 0)
                        checked
                        {
                            ++index7;
                        }

                    string str = index7 <= byteIndex
                        ? "****"
                        : asciiEncoding.GetString(ary2da, byteIndex, checked(index7 - byteIndex));
                    row[checked(num11 + 1)] = str;
                    checked
                    {
                        ++num11;
                    }
                }

                dt.Rows.Add(row);
                checked
                {
                    ++index5;
                }
            }
        }

    private void frm2DAEditor_Load(object sender, EventArgs e)
    {
            if (ary2da != null)
                BuildEditor();
            PositionWindow();
        }

    private void frm2DAEditor_Closing(object sender, CancelEventArgs e) => SaveSettings();

    public void BuildEditor()
    {
            CreateDataTable();
            DView = dt.DefaultView;
            DView.AllowDelete = true;
            DView.AllowNew = true;
            DView.AllowEdit = true;
            dg2DA.TableStyles.Clear();
            dg2DA.SetDataBinding(DView, null);
            dg2DA.CaptionText = fname;
            dg2DA.CaptionFont = new Font("Microsoft Sans Serif", 9f);
            CreateTableStyle();
            AutoSizeColumns();
            dt.ColumnChanged += new DataColumnChangeEventHandler(dt_ColumnChanged);
        }

    private object WriteStringBytes(BinaryWriter wr, string str)
    {
            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            byte[] numArray = new byte[256];
            asciiEncoding.GetBytes(str, 0, Strings.Len(str), numArray, 0);
            wr.Write(numArray, 0, Strings.Len(str));
            object obj = null;
            return obj;
        }

    public void Write2daV2bFile()
    {
            string str1 = StringType.FromObject(FrmMain.GetFilePath("save", FrmMain.CurrentSettings.defaultSaveLocation,
                fname, "Save 2DA v2.b file...", "2da"));
            if (StringType.StrCmp(str1, "", false) == 0)
                return;
            Hashtable hashtable = new Hashtable();
            FileStream output = new FileStream(str1, FileMode.Create);
            BinaryWriter wr = new BinaryWriter(output, Encoding.ASCII);
            if (checked(numColumns + 1) < dt.Columns.Count)
            {
                int num1 = (int)Interaction.MsgBox(
                    "The columns added via the Show Strings function will be removed so that the file can be saved properly.",
                    MsgBoxStyle.Information, "");
                int num2 = checked(dt.Columns.Count - 1);
                int num3 = checked(numColumns + 1);
                int index = num2;
                while (index >= num3)
                {
                    dt.Columns.RemoveAt(index);
                    checked
                    {
                        index += -1;
                    }
                }
            }

            try
            {
                int num4 = 0;
                int num5 = checked(dt.Rows.Count - 1);
                int rowIndex = 0;
                while (rowIndex <= num5)
                {
                    int num6 = checked(dt.Columns.Count - 1);
                    int columnIndex = 1;
                    while (columnIndex <= num6)
                    {
                        object objectValue = RuntimeHelpers.GetObjectValue(dg2DA[rowIndex, columnIndex]);
                        if (!hashtable.Contains(RuntimeHelpers.GetObjectValue(objectValue)))
                        {
                            hashtable.Add(RuntimeHelpers.GetObjectValue(objectValue), num4);
                            checked
                            {
                                ++num4;
                            }
                        }

                        checked
                        {
                            ++columnIndex;
                        }
                    }

                    checked
                    {
                        ++rowIndex;
                    }
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox(
                    "Error reading data from grid. dtc= " + StringType.FromInteger(dt.Rows.Count) + " dvc= " +
                    StringType.FromInteger(DView.Count), MsgBoxStyle.Critical);
                ProjectData.ClearProjectError();
                return;
            }

            object[] objArray = new object[checked(hashtable.Count + 1)];
            short[] numArray = new short[checked(hashtable.Count + 1)];
            hashtable.CopyTo(objArray, 0);
            int num7 = checked(hashtable.Count - 1);
            int index1 = 0;
            while (index1 <= num7)
            {
                hashtable[
                    RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objArray[index1], null, "key", new object[0],
                        null, null))] = index1;
                checked
                {
                    ++index1;
                }
            }

            WriteStringBytes(wr, "2DA V2.b\n");
            int num8 = checked(dt.Columns.Count - 1);
            int index2 = 1;
            while (index2 <= num8)
            {
                WriteStringBytes(wr, dt.Columns[index2].ColumnName + "\t");
                checked
                {
                    ++index2;
                }
            }

            wr.Write(char.MinValue);
            wr.Write(dt.Rows.Count);
            int num9 = checked(dt.Rows.Count - 1);
            int rowIndex1 = 0;
            while (rowIndex1 <= num9)
            {
                WriteStringBytes(wr, StringType.FromObject(ObjectType.StrCatObj(dg2DA[rowIndex1, 0], '\t')));
                checked
                {
                    ++rowIndex1;
                }
            }

            int position = checked((int)output.Position);
            output.Seek(checked((dt.Columns.Count - 1) * dt.Rows.Count + 1 * 2), SeekOrigin.Current);
            int num10 = 0;
            int num11 = checked(hashtable.Count - 1);
            int index3 = 0;
            while (index3 <= num11)
            {
                string str2 =
                    StringType.FromObject(
                        ((DictionaryEntry)(objArray[index3] ?? Activator.CreateInstance(typeof(DictionaryEntry)))).Key);
                if (StringType.StrCmp(str2, "****", false) == 0)
                    str2 = "";
                WriteStringBytes(wr, str2 + "\0");
                numArray[index3] = checked((short)num10);
                checked
                {
                    num10 += Strings.Len(str2) + 1;
                }

                checked
                {
                    ++index3;
                }
            }

            numArray[index3] = checked((short)num10);
            output.Seek(position, SeekOrigin.Begin);
            int num12 = checked(dt.Rows.Count - 1);
            int rowIndex2 = 0;
            while (rowIndex2 <= num12)
            {
                int num13 = checked(dt.Columns.Count - 1);
                int columnIndex = 1;
                while (columnIndex <= num13)
                {
                    object objectValue = RuntimeHelpers.GetObjectValue(dg2DA[rowIndex2, columnIndex]);
                    int index4 = IntegerType.FromObject(hashtable[RuntimeHelpers.GetObjectValue(objectValue)]);
                    wr.Write(numArray[index4]);
                    checked
                    {
                        ++columnIndex;
                    }
                }

                checked
                {
                    ++rowIndex2;
                }
            }

            wr.Close();
            fname = Path.GetFileName(str1);
            dg2DA.CaptionText = fname;
        }

    private void LoadFromXMLFile(string path)
    {
            filetype = "xml";
            XMLfilepath = path;
            DataSet dataSet = new DataSet();
            int num = (int)dataSet.ReadXml(path);
            dt = dataSet.Tables[0];
            DView = dt.DefaultView;
            DView.AllowDelete = true;
            DView.AllowNew = true;
            DView.AllowEdit = true;
            dg2DA.TableStyles.Clear();
            dg2DA.SetDataBinding(DView, null);
            dg2DA.CaptionText = dt.TableName;
            dg2DA.CaptionFont = new Font("Microsoft Sans Serif", 9f);
            CreateTableStyle();
            AutoSizeColumns();
            dataSet.Tables.Remove(dt);
        }

    private void CreateTableStyle()
    {
            DataGridTableStyle table = new DataGridTableStyle();
            dg2DA.TableStyles.Clear();
            table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
            table.MappingName = fname;
            int num = checked(dt.Columns.Count - 1);
            int index = 0;
            while (index <= num)
            {
                DataGridTextBoxColumn column = new DataGridTextBoxColumn();
                column.MappingName = dt.Columns[index].Caption;
                column.HeaderText = dt.Columns[index].Caption;
                column.NullText = "";
                table.GridColumnStyles.Add(column);
                checked
                {
                    ++index;
                }
            }

            dg2DA.TableStyles.Add(table);
        }

    public void AutoSizeColumns()
    {
            int num1 = checked(dt.Columns.Count - 1);
            int num2 = 0;
            while (num2 <= num1)
            {
                dg2DA.TableStyles[0].GridColumnStyles[num2].Width = GetColWidth(num2, dt.Columns[num2].Caption);
                checked
                {
                    ++num2;
                }
            }
        }

    protected int GetColWidth(int col, string DisplayName)
    {
            int count = ((DataView)dg2DA.DataSource).Count;
            Graphics graphics = Graphics.FromHwnd(Handle);
            StringFormat format = new StringFormat(StringFormat.GenericTypographic);
            float num1 = graphics.MeasureString(DisplayName, Font, 500, format).Width;
            try
            {
                int num2 = checked(count - 1);
                int rowIndex = 0;
                while (rowIndex <= num2)
                {
                    SizeF sizeF = graphics.MeasureString(dg2DA[rowIndex, col].ToString(), Font, 500, format);
                    if (sizeF.Width > (double)num1)
                        num1 = sizeF.Width;
                    checked
                    {
                        ++rowIndex;
                    }
                }

                graphics.Dispose();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                num1 = 75f;
                ProjectData.ClearProjectError();
            }

            return checked((int)Math.Round(num1 + 10f));
        }

    private void dg_MouseUp(object sender, MouseEventArgs e)
    {
           /*DataGridCell currentCell = ((DataGrid)sender).CurrentCell;

            ataGrid.HitTestInfo hitTestInfo = dg2DA.HitTest(dg2DA.PointToClient(MousePosition));

            f (hitTestInfo.Type == DataGrid.HitTestType.RowHeader)

            

                f (!IsLastRow(hitTestInfo.Row))

                

                    f (!(e.Button == MouseButtons.Right & e.Clicks == 1))

                        eturn;

                    ClickedRow = hitTestInfo.Row;

                    m.ToolStripMenuItems.Clear();

                    m.ToolStripMenuItems.Add(cmiInsertRow);

                    m.ToolStripMenuItems.Add(cmiCopyRow);

                    f (clipboardDataRow != null ||

                        lipboard.GetDataObject().GetDataPresent(DataFormats.CommaSeparatedValue))

                    

                        m.ToolStripMenuItems.Add(cmiPasteRow);

                        m.ToolStripMenuItems.Add(cmiInsertCopiedRow);

                    


                    f (IsCol0AllNumbers())

                        m.ToolStripMenuItems.Add(cmiRenumberRowLabelColumn);

                    m.Show(this, new Point(e.X, e.Y));

                

                lse

                

                    f (!(e.Button == MouseButtons.Right & e.Clicks == 1 & clipboardDataRow != null))

                        eturn;

                    ClickedRow = hitTestInfo.Row;

                    m.ToolStripMenuItems.Clear();

                    m.ToolStripMenuItems.Add(cmiPasteRow);

                    m.Show(this, new Point(e.X, e.Y));

                

            

            lse

            

                f (hitTestInfo.Type != DataGrid.HitTestType.ColumnHeader ||

                    (e.Button == MouseButtons.Right & e.Clicks == 1))

                    eturn;

                ClickedColumn = hitTestInfo.Column;

                m.ToolStripMenuItems.Clear();

                m.ToolStripMenuItems.Add(cmiShowStrings);

                m.Show(this, new Point(e.X, e.Y));

            */
        }

    protected bool IsLastRow(int row)
    {
            bool flag;
            try
            {
                dg2DA.Select(checked(row + 1));
                dg2DA.UnSelect(checked(row + 1));
            }
            catch (IndexOutOfRangeException ex)
            {
                ProjectData.SetProjectError(ex);
                flag = true;
                ProjectData.ClearProjectError();
                goto label_3;
            }

            return false;
            label_3:
            return flag;
        }

    private void btnWrite2daV2bFile_Click(object sender, EventArgs e) => Write2daV2bFile();

    private void GetClipboardDataRow(ref DataRow DestRow)
    {
            DataObject dataObject = (DataObject)Clipboard.GetDataObject();
            string str = null;
            if (dataObject != null && dataObject.GetDataPresent(DataFormats.CommaSeparatedValue))
            {
                object objectValue = RuntimeHelpers.GetObjectValue(dataObject.GetData(DataFormats.CommaSeparatedValue));
                if (StringType.StrCmp(objectValue.GetType().Name, "MemoryStream", false) == 0)
                {
                    StreamReader streamReader = new StreamReader((Stream)objectValue);
                    str = streamReader.ReadLine();
                    streamReader.Close();
                }
                else if (StringType.StrCmp(objectValue.GetType().Name, "String", false) == 0)
                    str = (string)objectValue;
            }

            string[] strArray = str.Split(',');
            if (strArray.GetLength(0) > dt.Columns.Count)
            {
                if (Interaction.MsgBox(
                        "The clipboard contains more columns of data than are present in the table.\nDo you want to paste just the columns that will fit?",
                        MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, "") == MsgBoxResult.No)
                    return;
                int num = checked(dt.Columns.Count - 1);
                int columnIndex = 0;
                while (columnIndex <= num)
                {
                    DestRow[columnIndex] = strArray[columnIndex];
                    checked
                    {
                        ++columnIndex;
                    }
                }
            }
            else if (strArray.GetLength(0) < dt.Columns.Count)
            {
                if (Interaction.MsgBox(
                        "The clipboard contains fewer columns of data than are present in the table.\nDo you want to continue?",
                        MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, "") == MsgBoxResult.No)
                    return;
                int num = checked(strArray.GetLength(0) - 1);
                int columnIndex = 0;
                while (columnIndex <= num)
                {
                    DestRow[columnIndex] = strArray[columnIndex];
                    checked
                    {
                        ++columnIndex;
                    }
                }
            }
            else
            {
                int num = checked(dt.Columns.Count - 1);
                int columnIndex = 0;
                while (columnIndex <= num)
                {
                    DestRow[columnIndex] = strArray[columnIndex];
                    checked
                    {
                        ++columnIndex;
                    }
                }
            }
        }

    private void cmiInsertRow_Click(object sender, EventArgs e)
    {
            if (StringType.StrCmp(dt.DefaultView.Sort, "", false) != 0)
            {
                switch (ShowPasteInsertWhileSortedMsg())
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        dt.DefaultView.Sort = "";
                        break;
                }
            }

            InsertRow(null);
        }

    private void cmiCopyRow_Click(object sender, EventArgs e)
    {
            int num = checked(dt.Columns.Count - 2);
            int columnIndex = 0;
            string vLeft = null;
            while (columnIndex <= num)
            {
                vLeft = StringType.FromObject(ObjectType.StrCatObj(vLeft,
                    ObjectType.StrCatObj(DView[gClickedRow].Row[columnIndex], ",")));
                checked
                {
                    ++columnIndex;
                }
            }

            string data1 = StringType.FromObject(ObjectType.StrCatObj(vLeft, DView[gClickedRow].Row[columnIndex]));
            DataObject data2 = new DataObject();
            data2.SetData(DataFormats.CommaSeparatedValue, false, data1);
            Clipboard.SetDataObject(data2, true);
        }

    private void cmiPasteRow_Click(object sender, EventArgs e)
    {
            if (StringType.StrCmp(dt.DefaultView.Sort, "", false) != 0)
            {
                switch (ShowPasteInsertWhileSortedMsg())
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        dt.DefaultView.Sort = "";
                        break;
                }
            }

            DataRow DestRow = !IsLastRow(gClickedRow) ? DView[gClickedRow].Row : dt.NewRow();
            GetClipboardDataRow(ref DestRow);
            if (IsLastRow(gClickedRow))
                dt.Rows.Add(DestRow);
            dg2DA.ScrollToRow(gClickedRow);
        }

    private void cmiInsertCopiedRow_Click(object sender, EventArgs e)
    {
            if (StringType.StrCmp(dt.DefaultView.Sort, "", false) != 0)
            {
                switch (ShowPasteInsertWhileSortedMsg())
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        dt.DefaultView.Sort = "";
                        break;
                }
            }

            DataRow DestRow = dt.NewRow();
            GetClipboardDataRow(ref DestRow);
            InsertRow(DestRow);
        }

    private void cmiRenumberRowLabelColumn_Click(object sender, EventArgs e) => RenumberRowLabelColumn();

    private void miLoad2da_Click(object sender, EventArgs e)
    {
            string str = StringType.FromObject(FrmMain.GetFilePath("load",
                FrmMain.CurrentSettings.defaultImportLocation, "", "Load 2DA v2.b file...", "2da"));
            if (StringType.StrCmp(str, "", false) == 0)
                return;
            filetype = "binary";
            FileStream input = new FileStream(str, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(input, Encoding.ASCII);
            ary2da = binaryReader.ReadBytes(checked((int)input.Length));
            binaryReader.Close();
            fname = Strings.Mid(str, checked(str.LastIndexOf("\\") + 2));
            dt = new DataTable(fname);
            dg2DA.SetDataBinding(null, null);
            BuildEditor();
        }

    private void miLoad2daXml_Click(object sender, EventArgs e)
    {
            string str = StringType.FromObject(FrmMain.GetFilePath("load",
                FrmMain.CurrentSettings.defaultImportLocation, "", "Load 2DA v2.b (XML) file...", "xml"));
            if (StringType.StrCmp(str, "", false) == 0)
                return;
            LoadFromXMLFile(str);
        }

    private void miSave2daV2b_Click(object sender, EventArgs e)
    {
            string sort = dt.DefaultView.Sort;
            dt.DefaultView.Sort = "";
            Write2daV2bFile();
            dt.DefaultView.Sort = sort;
        }

    private void miSave2daV2bXML_Click(object sender, EventArgs e)
    {
            string str = StringType.FromObject(FrmMain.GetFilePath("save", FrmMain.CurrentSettings.defaultSaveLocation,
                Strings.Replace(fname, "2da", "xml"), "Save 2DA v2.b (XML) file...", "xml"));
            if (StringType.StrCmp(str, "", false) == 0)
                return;
            string sort = dt.DefaultView.Sort;
            dt.DefaultView.Sort = "";
            if (checked(numColumns + 1) < dt.Columns.Count)
            {
                int num1 = (int)Interaction.MsgBox(
                    "The columns added via the Show Strings function will be removed so that the file can be saved properly.",
                    MsgBoxStyle.Information, "");
                int num2 = checked(dt.Columns.Count - 1);
                int num3 = checked(numColumns + 1);
                int index = num2;
                while (index >= num3)
                {
                    dt.Columns.RemoveAt(index);
                    checked
                    {
                        index += -1;
                    }
                }
            }

            DataSet dataSet = new DataSet("Kotor_2DA_File");
            dataSet.Tables.Add(dt);
            dataSet.WriteXml(str);
            dataSet.Tables.Remove(dt);
            dataSet.Dispose();
            dt.DefaultView.Sort = sort;
        }

    private void miQuit_Click(object sender, EventArgs e) => Hide();

    private void miResetSort_Click(object sender, EventArgs e) => DView.Sort = "";

    private void miUndoAll_Click(object sender, EventArgs e)
    {
            if (Interaction.MsgBox("Are you sure you want to lose all changes and reload?", MsgBoxStyle.OkCancel, "") !=
                MsgBoxResult.Ok)
                return;
            if (StringType.StrCmp(filetype, "xml", false) == 0)
            {
                LoadFromXMLFile(XMLfilepath);
            }
            else
            {
                dg2DA.SetDataBinding(null, null);
                dt = new DataTable(fname);
                BuildEditor();
            }
        }

    private void RenumberRowLabelColumn()
    {
            if (IsCol0AllNumbers())
            {
                int num1 = 0;
                if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(dg2DA[0, 0])))
                    num1 = IntegerType.FromObject(dg2DA[0, 0]);
                frmPromptForString frmPromptForString = new frmPromptForString("Renumber Row Labels",
                    "Enter the starting value:", StringType.FromInteger(num1));
                if (frmPromptForString.ShowDialog(this) != DialogResult.OK)
                    return;
                int int32 = Convert.ToInt32(frmPromptForString.tbValue.Text);
                int num2 = checked(DView.Count - 1);
                int rowIndex = 0;
                while (rowIndex <= num2)
                {
                    dg2DA[rowIndex, 0] = checked(rowIndex + int32);
                    checked
                    {
                        ++rowIndex;
                    }
                }
            }
            else
            {
                int num = (int)Interaction.MsgBox("One or more Row Labels is not a number or empty; aborting");
            }
        }

    private bool IsCol0AllNumbers()
    {
            bool flag = true;
            int num = checked(DView.Count - 1);
            int rowIndex = 0;
            while (rowIndex <= num)
            {
                if (!Information.IsNumeric(RuntimeHelpers.GetObjectValue(dg2DA[rowIndex, 0])) &&
                    StringType.StrCmp(dg2DA[rowIndex, 0].ToString().Trim(), "", false) != 0)
                {
                    flag = false;
                    break;
                }

                checked
                {
                    ++rowIndex;
                }
            }

            return flag;
        }

    private void InsertRow(DataRow dr)
    {
            string sort = dt.DefaultView.Sort;
            DataTable dataTable = new DataTable("temp");
            dt.DefaultView.Sort = "";
            int num1 = checked(dt.Columns.Count - 1);
            int index = 0;
            while (index <= num1)
            {
                dataTable.Columns.Add(new DataColumn(dt.Columns[index].ColumnName, typeof(string))
                {
                    DefaultValue = ""
                });
                checked
                {
                    ++index;
                }
            }

            int num2 = checked(this.gClickedRow - 1);
            int recordIndex1 = 0;
            while (recordIndex1 <= num2)
            {
                DataRow row = DView[recordIndex1].Row;
                dataTable.ImportRow(row);
                checked
                {
                    ++recordIndex1;
                }
            }

            DataRow row1 = dataTable.NewRow();
            if (dr == null)
            {
                row1[0] = "new";
            }
            else
            {
                int num3 = checked(dt.Columns.Count - 1);
                int columnIndex = 0;
                while (columnIndex <= num3)
                {
                    row1[columnIndex] = RuntimeHelpers.GetObjectValue(dr[columnIndex]);
                    checked
                    {
                        ++columnIndex;
                    }
                }
            }

            dataTable.Rows.Add(row1);
            int gClickedRow = this.gClickedRow;
            int num4 = checked(dt.Rows.Count - 1);
            int recordIndex2 = gClickedRow;
            while (recordIndex2 <= num4)
            {
                DataRow row2 = DView[recordIndex2].Row;
                dataTable.ImportRow(row2);
                checked
                {
                    ++recordIndex2;
                }
            }

            dt = dataTable;
            dt.TableName = fname;
            dt.DefaultView.Sort = sort;
            dg2DA.SetDataBinding(null, null);
            DView = null;
            DView = dt.DefaultView;
            dg2DA.SetDataBinding(DView, null);
            CreateTableStyle();
            AutoSizeColumns();
            dg2DA.ScrollToRow(this.gClickedRow);
        }

    private int InsertColumn(string ColumnName)
    {
            DataColumn column = new DataColumn(ColumnName);
            dt.Columns.Add(column);
            CreateTableStyle();
            AutoSizeColumns();
            return dt.Columns.IndexOf(column);
        }

    private DialogResult ShowPasteInsertWhileSortedMsg() => (DialogResult)Interaction.MsgBox(
        "Pasting or Inserting rows while the grid is sorted may produce unexpected results.\nDo you wish to reset the sort before continuing?",
        MsgBoxStyle.YesNoCancel);

    public void PositionWindow()
    {
            Options settings = UserSettings.GetSettings();
            Point point1 = default;
            Point point2;
            if (!settings.TwoDAEditorWindowLoc.IsEmpty)
            {
                point1 = settings.TwoDAEditorWindowLoc;
                if (point1.X < 0)
                {
                    Options options = settings;
                    point2 = new Point(10, 10);
                    Point point3 = point2;
                    options.TwoDAEditorWindowLoc = point3;
                }

                point2 = settings.TwoDAEditorWindowLoc;
                if (point2.Y < 0)
                {
                    Options options = settings;
                    point1 = new Point(10, 10);
                    Point point4 = point1;
                    options.TwoDAEditorWindowLoc = point4;
                }

                ((Control)this).Location = settings.TwoDAEditorWindowLoc;
            }

            if (settings.TwoDAEditorWindowSize.IsEmpty)
                return;
            Size size1 = settings.TwoDAEditorWindowSize;
            Rectangle workingArea;
            int height1 = 0;
            if (size1.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                ref Point local1 = ref point1;
                point2 = ((Control)this).Location;
                int x = point2.X;
                workingArea = Screen.PrimaryScreen.WorkingArea;
                int top = workingArea.Top;
                local1 = new Point(x, top);
                ((Control)this).Location = point1;
                workingArea = Screen.PrimaryScreen.WorkingArea;
                height1 = workingArea.Height;
                Size size2 = default;
                ref Size local2 = ref size2;
                size1 = Size;
                int width = size1.Width;
                int height2 = height1;
                local2 = new Size(width, height2);
                Size = size2;
            }

            int width1 = settings.TwoDAEditorWindowSize.Width;
            workingArea = Screen.PrimaryScreen.WorkingArea;
            int width2 = workingArea.Width;
            int width3 = 0;
            if (width1 > width2)
            {
                ref Point local = ref point1;
                int left = Screen.PrimaryScreen.WorkingArea.Left;
                point2 = ((Control)this).Location;
                int y = point2.Y;
                local = new Point(left, y);
                ((Control)this).Location = point1;
                workingArea = Screen.PrimaryScreen.WorkingArea;
                width3 = workingArea.Width;
                size1 = new Size(width3, Size.Height);
                Size = size1;
            }

            if (!(width3 == 0 & height1 == 0))
                return;
            Size = settings.TwoDAEditorWindowSize;
        }

    public void SaveSettings()
    {
            Options settings = UserSettings.GetSettings();
            settings.TwoDAEditorWindowLoc = ((Control)this).Location;
            settings.TwoDAEditorWindowSize = Size;
            UserSettings.SaveSettings(settings);
        }

    private void cmiShowStrings_Click(object sender, EventArgs e)
    {
            if (KotorVersionIndex == -1)
            {
                frmSpecifyKotorVersion specifyKotorVersion = new frmSpecifyKotorVersion();
                if (specifyKotorVersion.ShowDialog() != DialogResult.OK)
                    return;
                KotorVersionIndex = specifyKotorVersion.KotorVerIndexSelected;
            }

            getDialogTlk();
            string str = dt.Columns[gClickedColumn].ColumnName + " (Strs)";
            int num1 = checked(dt.Columns.Count - 1);
            int index = 0;
            while (index <= num1 && StringType.StrCmp(dt.Columns[index].ColumnName, str, false) != 0)
                checked
                {
                    ++index;
                }

            int columnIndex = index != dt.Columns.Count ? index : InsertColumn(str);
            int num2 = checked(dt.Rows.Count - 1);
            int rowIndex = 0;
            while (rowIndex <= num2)
            {
                object objectValue = RuntimeHelpers.GetObjectValue(dg2DA[rowIndex, gClickedColumn]);
                if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue)))
                {
                    if (ObjectType.ObjTst(objectValue, -1, false) > 0)
                        dg2DA[rowIndex, columnIndex] = g_DialogTlk.GetString(IntegerType.FromObject(objectValue));
                    else
                        dg2DA[rowIndex, columnIndex] = "";
                }

                checked
                {
                    ++rowIndex;
                }
            }
        }

    private void dt_ColumnChanged(object sender, DataColumnChangeEventArgs e)
    {
            if (e.Column.ColumnName.EndsWith("(Strs)"))
                return;
            object objectValue = RuntimeHelpers.GetObjectValue(e.ProposedValue);
            if (!Information.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue)) ||
                ObjectType.ObjTst(IndexOfColumnName(e.Column.ColumnName + " (Strs)"), -1, false) <= 0)
                return;
            dg2DA[dg2DA.CurrentCell.RowNumber,
                    IntegerType.FromObject(IndexOfColumnName(e.Column.ColumnName + " (Strs)"))] =
                g_DialogTlk.GetString(IntegerType.FromObject(objectValue));
        }

    private object IndexOfColumnName(string name)
    {
            int num1 = -1;
            int num2 = checked(dt.Columns.Count - 1);
            int index = 0;
            while (index <= num2)
            {
                if (StringType.StrCmp(dt.Columns[index].ColumnName.ToLower(), name.ToLower(), false) == 0)
                {
                    num1 = index;
                    break;
                }

                checked
                {
                    ++index;
                }
            }

            return num1;
        }

    private void frm2DAEditor_Move(object sender, EventArgs e) => SaveSettings();

    private void miSetKotORversion_Click(object sender, EventArgs e)
    {
            frmSpecifyKotorVersion specifyKotorVersion = new frmSpecifyKotorVersion();
            switch (KotorVersionIndex)
            {
                case 0:
                    specifyKotorVersion.rbKotor1.Checked = true;
                    break;
                case 1:
                    specifyKotorVersion.rbKotor2.Checked = true;
                    break;
            }

            if (specifyKotorVersion.ShowDialog() != DialogResult.OK)
                return;
            KotorVersionIndex = specifyKotorVersion.KotorVerIndexSelected;
            if (KotorVersionIndex == 0)
                Text = "2DA Editor - Kotor I";
            else if (KotorVersionIndex == 1)
                Text = "2DA Editor - Kotor II";
            if (LastKotorVersionIndex != KotorVersionIndex & g_DialogTlk != null)
            {
                g_DialogTlk =
                    new clsDialogTlk(UserSettings.GetSettings().KotorLocation(KotorVersionIndex) + "\\dialog.tlk");
                if (checked(numColumns + 1) < dt.Columns.Count)
                {
                    int num1 = (int)Interaction.MsgBox(
                        "The columns added via the Show Strings function are being removed as the strings may not match between game versions.",
                        MsgBoxStyle.Information, "");
                    int num2 = checked(dt.Columns.Count - 1);
                    int num3 = checked(numColumns + 1);
                    int index = num2;
                    while (index >= num3)
                    {
                        dt.Columns.RemoveAt(index);
                        checked
                        {
                            index += -1;
                        }
                    }
                }
            }

            LastKotorVersionIndex = KotorVersionIndex;
        }

    private clsDialogTlk getDialogTlk()
    {
            if (g_DialogTlk == null)
                g_DialogTlk =
                    new clsDialogTlk(UserSettings.GetSettings().KotorLocation(KotorVersionIndex) + "\\dialog.tlk");
            return g_DialogTlk;
        }

    private void miTestFunction_Click(object sender, EventArgs e)
    {
            object objectValue = RuntimeHelpers.GetObjectValue(new object());
            objectValue = RuntimeHelpers.GetObjectValue(GetPrivateField(dg2DA, "DataGridRows"));
        }

    public static object GetPrivateField(object PassedObject, string FieldName)
    {
            RuntimeHelpers.GetObjectValue(new object());
            if (PassedObject == null)
                throw new ArgumentNullException(nameof(PassedObject), "PassedObject must be an instantiated object.");
            if (FieldName == null || StringType.StrCmp(FieldName.Trim(), "", false) == 0)
                throw new ArgumentOutOfRangeException(nameof(FieldName), "Fieldname must be a non empty string.");
            Type type = PassedObject.GetType();
            return RuntimeHelpers.GetObjectValue(
                (type.GetField(FieldName,
                     BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic) ??
                 throw new ArgumentOutOfRangeException(nameof(FieldName),
                     type.FullName + " does not have a field : " + FieldName + "."))
                .GetValue(RuntimeHelpers.GetObjectValue(PassedObject)));
        }

    private void SetPrivateProperty(object PassedObject, string PropertyName, object value)
    {
            PropertyInfo property = PassedObject.GetType().BaseType.GetProperty(PropertyName,
                BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic);
            property?.SetValue(RuntimeHelpers.GetObjectValue(PassedObject),
                RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(value),
                    property.PropertyType)), null);
        }

    public class TwoDADataGrid : DataGrid
    {
        public void ScrollToRow(int row)
        {
                if (DataSource == null)
                    return;
                GridVScrolled(this, new ScrollEventArgs(ScrollEventType.LargeIncrement, row));
            }
    }
}