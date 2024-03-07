// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmInstanceOrRefPrompt
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class frmInstanceOrRefPrompt : Form
{
  [AccessedThroughProperty("btnInstance")]
  private Button _btnInstance;
  [AccessedThroughProperty("btnReference")]
  private Button _btnReference;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Button3")]
  private Button _Button3;
  private IContainer components;
  private string _itemclass;

  public frmInstanceOrRefPrompt()
  {
      _itemclass = "";
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

  internal virtual Button btnReference
  {
    get => _btnReference;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnReference != null)
          _btnReference.Click -= new EventHandler(btnReference_Click);
        _btnReference = value;
        if (_btnReference == null)
          return;
        _btnReference.Click += new EventHandler(btnReference_Click);
      }
  }

  internal virtual Button btnInstance
  {
    get => _btnInstance;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnInstance != null)
          _btnInstance.Click -= new EventHandler(btnInstance_Click);
        _btnInstance = value;
        if (_btnInstance == null)
          return;
        _btnInstance.Click += new EventHandler(btnInstance_Click);
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmInstanceOrRefPrompt));
      Label1 = new Label();
      btnReference = new Button();
      btnInstance = new Button();
      Button3 = new Button();
      SuspendLayout();
      Label label1_1 = Label1;
      Point point1 = new Point(90, 16);
      Point point2 = point1;
      label1_1.Location = point2;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      Size size1 = new Size(120, 16);
      Size size2 = size1;
      label1_2.Size = size2;
      Label1.TabIndex = 0;
      Label1.Text = "Do you want to create:";
      Label1.TextAlign = ContentAlignment.TopCenter;
      Button btnReference1 = btnReference;
      point1 = new Point(42, 48);
      Point point3 = point1;
      btnReference1.Location = point3;
      btnReference.Name = "btnReference";
      Button btnReference2 = btnReference;
      size1 = new Size(208, 23);
      Size size3 = size1;
      btnReference2.Size = size3;
      btnReference.TabIndex = 1;
      btnReference.Text = "A non-editable reference to this item";
      Button btnInstance1 = btnInstance;
      point1 = new Point(42, 88);
      Point point4 = point1;
      btnInstance1.Location = point4;
      btnInstance.Name = "btnInstance";
      Button btnInstance2 = btnInstance;
      size1 = new Size(208, 23);
      Size size4 = size1;
      btnInstance2.Size = size4;
      btnInstance.TabIndex = 1;
      btnInstance.Text = "An editable instance of this item";
      Button3.DialogResult = DialogResult.Cancel;
      Button button3 = Button3;
      point1 = new Point(106, 144);
      Point point5 = point1;
      button3.Location = point5;
      Button3.Name = "Button3";
      Button3.TabIndex = 2;
      Button3.Text = "Cancel";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(292, 181);
      ClientSize = size1;
      Controls.Add(Button3);
      Controls.Add(btnReference);
      Controls.Add(Label1);
      Controls.Add(btnInstance);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Name = nameof (frmInstanceOrRefPrompt);
      StartPosition = FormStartPosition.CenterParent;
      Text = "Instance or Reference";
      ResumeLayout(false);
    }

  public string ItemClass => _itemclass;

  private void btnReference_Click(object sender, EventArgs e)
  {
      _itemclass = "reference";
      DialogResult = DialogResult.OK;
    }

  private void btnInstance_Click(object sender, EventArgs e)
  {
      _itemclass = "instance";
      DialogResult = DialogResult.OK;
    }
}