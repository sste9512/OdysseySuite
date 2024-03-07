// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmProgressMeter
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class FrmProgressMeter : Form
{
    [AccessedThroughProperty("pbar")] private ProgressBar _pbar;
    [AccessedThroughProperty("lblStatus")] private Label _lblStatus;
    [AccessedThroughProperty("lblMsg")] private Label _lblMsg;
    private IContainer components;

    public FrmProgressMeter() => InitializeComponent();

    protected override void Dispose(bool disposing)
    {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

    internal virtual ProgressBar Pbar
    {
        get => _pbar;
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_pbar == null)
                    ;
                _pbar = value;
                if (_pbar == null)
                    ;
            }
    }

    internal virtual Label LblStatus
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_lblStatus == null)
                    ;
                _lblStatus = value;
                if (_lblStatus == null)
                    ;
            }
        get => _lblStatus;
    }

    internal virtual Label LblMsg
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
                if (_lblMsg == null)
                    ;
                _lblMsg = value;
                if (_lblMsg == null)
                    ;
            }
        get => _lblMsg;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
            Pbar = new ProgressBar();
            LblStatus = new Label();
            LblMsg = new Label();
            SuspendLayout();
            ProgressBar pbar1 = Pbar;
            Point point1 = new Point(42, 48);
            Point point2 = point1;
            pbar1.Location = point2;
            Pbar.Name = "pbar";
            ProgressBar pbar2 = Pbar;
            Size size1 = new Size(203, 16);
            Size size2 = size1;
            pbar2.Size = size2;
            Pbar.TabIndex = 0;
            Label lblStatus1 = LblStatus;
            point1 = new Point(27, 80);
            Point point3 = point1;
            lblStatus1.Location = point3;
            LblStatus.Name = "lblStatus";
            Label lblStatus2 = LblStatus;
            size1 = new Size(232, 23);
            Size size3 = size1;
            lblStatus2.Size = size3;
            LblStatus.TabIndex = 1;
            LblStatus.TextAlign = ContentAlignment.MiddleCenter;
            Label lblMsg1 = LblMsg;
            point1 = new Point(32, 8);
            Point point4 = point1;
            lblMsg1.Location = point4;
            LblMsg.Name = "lblMsg";
            Label lblMsg2 = LblMsg;
            size1 = new Size(224, 23);
            Size size4 = size1;
            lblMsg2.Size = size4;
            LblMsg.TabIndex = 2;
            LblMsg.TextAlign = ContentAlignment.MiddleCenter;
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            size1 = new Size(286, 115);
            ClientSize = size1;
            ControlBox = false;
            Controls.AddRange(new Control[3]
            {
                LblMsg,
                LblStatus,
                Pbar
            });
            Name = nameof(FrmProgressMeter);
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.Manual;
            ResumeLayout(false);
        }

    public int Progress
    {
        set => Pbar.Value = value;
    }

    public int StepAmount
    {
        set => Pbar.Step = value;
    }

    public string Message
    {
        set
        {
                LblMsg.Text = value;
                //Application.DoEvents();
            }
    }

    public string Status
    {
        set
        {
                LblStatus.Text = value;
                //Application.DoEvents();
            }
    }

    public int Maxvalue
    {
        set => Pbar.Maximum = value;
    }

    public void StepUp()
    {
            Pbar.PerformStep();
            //Application.DoEvents();
        }
}