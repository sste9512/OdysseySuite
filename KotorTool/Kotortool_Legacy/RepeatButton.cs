// Decompiled with JetBrains decompiler
// Type: kotor_tool.RepeatButton
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using Timer = System.Timers.Timer;

namespace Kotortool_Legacy;

public class RepeatButton : Button
{
  public Timer Timer;

  public RepeatButton()
  {
      MouseUp += new MouseEventHandler(RepeatButton_MouseUp);
      MouseDown += new MouseEventHandler(RepeatButton_MouseDown);
      Timer = new Timer();
     // Timer.Elapsed += new EventHandler(OnTimer);
      Timer.Interval = 200;
      Timer.Enabled = false;
    }

  public int Interval
  {
    //get => Timer.Interval;
    set => Timer.Interval = value;
  }

  private void OnTimer(object sender, EventArgs e) => OnClick(EventArgs.Empty);

  private void RepeatButton_MouseDown(object sender, MouseEventArgs e) => Timer.Enabled = true;

  private void RepeatButton_MouseUp(object sender, MouseEventArgs e) => Timer.Enabled = false;
}