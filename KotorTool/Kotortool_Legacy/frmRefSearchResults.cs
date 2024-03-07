// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmRefSearchResults
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmRefSearchResults : frmParent
{
    [AccessedThroughProperty("lblDesc")] private Label _lblDesc;

    [AccessedThroughProperty("lblNoMatchesFound")]
    private Label _lblNoMatchesFound;

    [AccessedThroughProperty("Button1")] private Button _Button1;
    [AccessedThroughProperty("lbMatches")] private ListBox _lbMatches;
    private FrmMain mainform;
    private IContainer components;

    public frmRefSearchResults() => InitializeComponent();

    public frmRefSearchResults(Form f)
        : this()
    {
            mainform = (FrmMain)f;
        }

    protected override void Dispose(bool disposing)
    {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

    internal virtual ListBox lbMatches
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_lbMatches != null)
                {
                    _lbMatches.DoubleClick -= new EventHandler(lbMatches_DoubleClick);
                    _lbMatches.SelectedIndexChanged -= new EventHandler(lbMatches_SelectedIndexChanged);
                }

                _lbMatches = value;
                if (_lbMatches == null)
                    return;
                _lbMatches.DoubleClick += new EventHandler(lbMatches_DoubleClick);
                _lbMatches.SelectedIndexChanged += new EventHandler(lbMatches_SelectedIndexChanged);
            }
        get => _lbMatches;
    }

    internal virtual Button Button1
    {
        get => _Button1;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_Button1 != null)
                    _Button1.Click -= new EventHandler(Button1_Click);
                _Button1 = value;
                if (_Button1 == null)
                    return;
                _Button1.Click += new EventHandler(Button1_Click);
            }
    }

    internal virtual Label lblNoMatchesFound
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_lblNoMatchesFound == null)
                    ;
                _lblNoMatchesFound = value;
                if (_lblNoMatchesFound == null)
                    ;
            }
        get => _lblNoMatchesFound;
    }

    internal virtual Label lblDesc
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_lblDesc == null)
                    ;
                _lblDesc = value;
                if (_lblDesc == null)
                    ;
            }
        get => _lblDesc;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
            lbMatches = new ListBox();
            Button1 = new Button();
            lblDesc = new Label();
            lblNoMatchesFound = new Label();
            SuspendLayout();
            lbMatches.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListBox lbMatches1 = lbMatches;
            Point point1 = new Point(24, 56);
            Point point2 = point1;
            lbMatches1.Location = point2;
            lbMatches.Name = "lbMatches";
            lbMatches.ScrollAlwaysVisible = true;
            ListBox lbMatches2 = lbMatches;
            Size size1 = new Size(208, 186);
            Size size2 = size1;
            lbMatches2.Size = size2;
            lbMatches.TabIndex = 0;
            Button1.Anchor = AnchorStyles.Bottom;
            Button button1_1 = Button1;
            point1 = new Point(95, 288);
            Point point3 = point1;
            button1_1.Location = point3;
            Button1.Name = "Button1";
            Button button1_2 = Button1;
            size1 = new Size(67, 23);
            Size size3 = size1;
            button1_2.Size = size3;
            Button1.TabIndex = 1;
            Button1.Text = "OK";
            Label lblDesc1 = lblDesc;
            point1 = new Point(24, 8);
            Point point4 = point1;
            lblDesc1.Location = point4;
            lblDesc.Name = "lblDesc";
            Label lblDesc2 = lblDesc;
            size1 = new Size(240, 32);
            Size size4 = size1;
            lblDesc2.Size = size4;
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Double click an item in the list to launch the viewer or editor for it";
            lblNoMatchesFound.Anchor = AnchorStyles.Bottom;
            lblNoMatchesFound.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label lblNoMatchesFound1 = lblNoMatchesFound;
            point1 = new Point(32, 208);
            Point point5 = point1;
            lblNoMatchesFound1.Location = point5;
            lblNoMatchesFound.Name = "lblNoMatchesFound";
            Label lblNoMatchesFound2 = lblNoMatchesFound;
            size1 = new Size(192, 32);
            Size size5 = size1;
            lblNoMatchesFound2.Size = size5;
            lblNoMatchesFound.TabIndex = 3;
            lblNoMatchesFound.Text = "No Matches Found";
            lblNoMatchesFound.TextAlign = ContentAlignment.MiddleCenter;
            lblNoMatchesFound.Visible = false;
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            size1 = new Size(256, 333);
            ClientSize = size1;
            Controls.Add(lblDesc);
            Controls.Add(Button1);
            Controls.Add(lbMatches);
            Controls.Add(lblNoMatchesFound);
            size1 = new Size(264, 216);
            MinimumSize = size1;
            Name = nameof(frmRefSearchResults);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Search Results";
            ResumeLayout(false);
        }

    private void lbMatches_SelectedIndexChanged(object sender, EventArgs e)
    {
        }

    private void lbMatches_DoubleClick(object sender, EventArgs e)
    {
            if (lbMatches.SelectedIndex == -1)
                return;
           // mainform.HandleDataByNodeType((KotorTreeNode)lbMatches.SelectedItem, null);
        }

    private void Button1_Click(object sender, EventArgs e) => Close();
}