// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmParent
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmParent : Form
{
    private IContainer components;
    public Options CurrentSettings;
    protected int KotorVersionIndex;
    protected string MEditingFilePath;
    protected string MDefaultTitleText;

    public frmParent() => InitializeComponent();

    protected override void Dispose(bool disposing)
    {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
            ResourceManager resourceManager = new ResourceManager(typeof(frmParent));
            Size size = new Size(5, 13);
            AutoScaleBaseSize = size;
            size = new Size(292, 273);
            ClientSize = size;
            Icon = (Icon)resourceManager.GetObject("$this.Icon");
            Name = nameof(frmParent);
            Text = nameof(frmParent);
        }

    protected void WriteConsoleMsg(object msg) => Console.WriteLine(RuntimeHelpers.GetObjectValue(msg));

    public string EditingFilePath
    {
        get => MEditingFilePath;
        set
        {
                MEditingFilePath = value;
                Text = MDefaultTitleText;
                if (KotorVersionIndex == 0)
                    Text += "I - ";
                else
                    Text += "II - ";
                Text += Path.GetFileName(value);
            }
    }

    public void PositionWindow(string FormClassName)
    {
            CurrentSettings = UserSettings.GetSettings();
            Point point1 = CurrentSettings.get_WindowLoc(FormClassName);
            if (point1.X < 0 | point1.Y < 0)
            {
                point1.X = 10;
                point1.Y = 10;
                CurrentSettings.set_WindowLoc(FormClassName, point1);
                UserSettings.SaveSettings(CurrentSettings);
            }

            ((Control)this).Location = point1;
            Size size1 = CurrentSettings.get_WindowSize(FormClassName);
            if (size1.IsEmpty)
                return;
            Point point2;
            int height1 = 0;
            Size size2;
            if (size1.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                Point point3 = default;
                ref Point local1 = ref point3;
                point2 = ((Control)this).Location;
                int x = point2.X;
                int top = Screen.PrimaryScreen.WorkingArea.Top;
                local1 = new Point(x, top);
                ((Control)this).Location = point3;
                height1 = Screen.PrimaryScreen.WorkingArea.Height;
                Size size3 = default;
                ref Size local2 = ref size3;
                size2 = Size;
                int width = size2.Width;
                int height2 = height1;
                local2 = new Size(width, height2);
                Size = size3;
            }

            int width1 = 0;
            if (size1.Width > Screen.PrimaryScreen.WorkingArea.Width)
            {
                point2 = new Point(Screen.PrimaryScreen.WorkingArea.Left, ((Control)this).Location.Y);
                ((Control)this).Location = point2;
                width1 = Screen.PrimaryScreen.WorkingArea.Width;
                size2 = new Size(width1, Size.Height);
                Size = size2;
            }

            if (!(width1 == 0 & height1 == 0))
                return;
            Size = CurrentSettings.get_WindowSize(FormClassName);
        }

    // Make this Async
    public void SaveSettings(string FormClassName)
    {
            CurrentSettings = UserSettings.GetSettings();
            if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
            int width = Size.Width;
            Size size = Size;
            int height1 = size.Height;
            int num1 = height1;
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            int height2 = workingArea.Height;
            if (num1 >= height2)
                height1 = checked(Screen.PrimaryScreen.WorkingArea.Height - 20);
            if (width >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                workingArea = Screen.PrimaryScreen.WorkingArea;
                width = checked(workingArea.Width - 20);
            }

            size = new Size(width, height1);
            Size = size;
            Point point = default;
            ref Point local1 = ref point;
            int x = ((Control)this).Location.X;
            Point location = ((Control)this).Location;
            int y = location.Y;
            local1 = new Point(x, y);
            location = ((Control)this).Location;
            if (location.X < 0)
                point.X = 0;
            location = ((Control)this).Location;
            if (checked(location.X + Size.Width) > Screen.PrimaryScreen.WorkingArea.Width)
            {
                ref Point local2 = ref point;
                workingArea = Screen.PrimaryScreen.WorkingArea;
                int num2 = checked(workingArea.Width - Size.Width - 30);
                local2.X = num2;
            }

            location = ((Control)this).Location;
            if (location.Y < 0)
                point.Y = 0;
            location = ((Control)this).Location;
            if (checked(location.Y + Size.Height) > Screen.PrimaryScreen.WorkingArea.Height)
            {
                ref Point local3 = ref point;
                workingArea = Screen.PrimaryScreen.WorkingArea;
                int num3 = checked(workingArea.Height - Size.Height - 30);
                local3.Y = num3;
            }

            ((Control)this).Location = point;
            CurrentSettings.set_WindowLoc(FormClassName, ((Control)this).Location);
            CurrentSettings.set_WindowSize(FormClassName, Size);
            UserSettings.SaveSettings(CurrentSettings);
        }
}