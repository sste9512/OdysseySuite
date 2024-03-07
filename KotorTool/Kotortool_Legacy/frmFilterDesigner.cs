// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmFilterDesigner
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmFilterDesigner : Form
{
  [AccessedThroughProperty("btnReset")]
  private Button _btnReset;
  [AccessedThroughProperty("HelpProvider1")]
  private HelpProvider _HelpProvider1;
  [AccessedThroughProperty("cmbxConcatOperator1")]
  private ComboBox _cmbxConcatOperator1;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("btnRemove1")]
  private Button _btnRemove1;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("tbCriteria1")]
  private TextBox _tbCriteria1;
  [AccessedThroughProperty("cmbxColumnName1")]
  private ComboBox _cmbxColumnName1;
  [AccessedThroughProperty("cmbxMatchOperator1")]
  private ComboBox _cmbxMatchOperator1;
  [AccessedThroughProperty("btnAddFilter")]
  private Button _btnAddFilter;
  private ColumnEntryList m_ColumnList;
  private bool m_HandlersActive;
  public RowFilter RF;
  private const int FILTERCONTROLSPACING = 25;
  private IContainer components;

  public string filterString => StringType.FromObject(RF.FilterString());

  public frmFilterDesigner()
  {
      Load += new EventHandler(frmFilterDesigner_Load);
      m_HandlersActive = true;
      RF = new RowFilter();
      InitializeComponent();
    }

  public frmFilterDesigner(ColumnEntryList ColumnList)
    : this()
  {
      m_ColumnList = ColumnList;
      ((ListControl) cmbxColumnName1).DataSource = m_ColumnList;
      cmbxColumnName1.DisplayMember = "displayColName";
      cmbxColumnName1.ValueMember = "nativeColName";
    }

  public frmFilterDesigner(ColumnEntryList ColumnList, RowFilter RowFilter)
    : this(ColumnList)
  {
      RF = RowFilter;
      BuildGuiFromRowFilterList();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual TextBox tbCriteria1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCriteria1 == null)
          ;
        _tbCriteria1 = value;
        if (_tbCriteria1 == null)
          ;
      }
    get => _tbCriteria1;
  }

  internal virtual Button btnOK
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnOK != null)
          _btnOK.Click -= new EventHandler(btnOK_Click);
        _btnOK = value;
        if (_btnOK == null)
          return;
        _btnOK.Click += new EventHandler(btnOK_Click);
      }
    get => _btnOK;
  }

  internal virtual Button btnCancel
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnCancel == null)
          ;
        _btnCancel = value;
        if (_btnCancel == null)
          ;
      }
    get => _btnCancel;
  }

  internal virtual Button btnReset
  {
    get => _btnReset;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnReset != null)
          _btnReset.Click -= new EventHandler(btnReset_Click);
        _btnReset = value;
        if (_btnReset == null)
          return;
        _btnReset.Click += new EventHandler(btnReset_Click);
      }
  }

  internal virtual ComboBox cmbxMatchOperator1
  {
    get => _cmbxMatchOperator1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxMatchOperator1 == null)
          ;
        _cmbxMatchOperator1 = value;
        if (_cmbxMatchOperator1 == null)
          ;
      }
  }

  internal virtual ComboBox cmbxConcatOperator1
  {
    get => _cmbxConcatOperator1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxConcatOperator1 == null)
          ;
        _cmbxConcatOperator1 = value;
        if (_cmbxConcatOperator1 == null)
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

  internal virtual Button btnAddFilter
  {
    get => _btnAddFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnAddFilter != null)
          _btnAddFilter.Click -= new EventHandler(btnAddFilter_Click);
        _btnAddFilter = value;
        if (_btnAddFilter == null)
          return;
        _btnAddFilter.Click += new EventHandler(btnAddFilter_Click);
      }
  }

  internal virtual ComboBox cmbxColumnName1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxColumnName1 == null)
          ;
        _cmbxColumnName1 = value;
        if (_cmbxColumnName1 == null)
          ;
      }
    get => _cmbxColumnName1;
  }

  internal virtual Button btnRemove1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnRemove1 == null)
          ;
        _btnRemove1 = value;
        if (_btnRemove1 == null)
          ;
      }
    get => _btnRemove1;
  }

  internal virtual HelpProvider HelpProvider1
  {
    get => _HelpProvider1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_HelpProvider1 == null)
          ;
        _HelpProvider1 = value;
        if (_HelpProvider1 == null)
          ;
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmFilterDesigner));
      cmbxMatchOperator1 = new ComboBox();
      tbCriteria1 = new TextBox();
      cmbxConcatOperator1 = new ComboBox();
      btnOK = new Button();
      this.btnCancel = new Button();
      this.btnReset = new Button();
      Label1 = new Label();
      btnAddFilter = new Button();
      cmbxColumnName1 = new ComboBox();
      btnRemove1 = new Button();
      HelpProvider1 = new HelpProvider();
      SuspendLayout();
      cmbxMatchOperator1.DropDownStyle = ComboBoxStyle.DropDownList;
      HelpProvider1.SetHelpString(cmbxMatchOperator1, "Choose the Match Operator for this filter element");
      cmbxMatchOperator1.Items.AddRange(new object[10]
      {
        "LIKE",
        "NOT LIKE",
        "=",
        "<>",
        "<",
        ">",
        "<=",
        ">=",
        "IN",
        "NOT IN"
      });
      ComboBox cmbxMatchOperator1_1 = cmbxMatchOperator1;
      Point point1 = new Point(168, 56);
      Point point2 = point1;
      cmbxMatchOperator1_1.Location = point2;
      cmbxMatchOperator1.MaxDropDownItems = 10;
      cmbxMatchOperator1.Name = "cmbxMatchOperator1";
      HelpProvider1.SetShowHelp(cmbxMatchOperator1, true);
      ComboBox cmbxMatchOperator1_2 = cmbxMatchOperator1;
      Size size1 = new Size(80, 21);
      Size size2 = size1;
      cmbxMatchOperator1_2.Size = size2;
      cmbxMatchOperator1.TabIndex = 1;
      cmbxMatchOperator1.Tag = "mo1";
      HelpProvider1.SetHelpString(tbCriteria1, "Enter the Criteria String for this filter element");
      TextBox tbCriteria1_1 = tbCriteria1;
      point1 = new Point(256, 56);
      Point point3 = point1;
      tbCriteria1_1.Location = point3;
      tbCriteria1.Name = "tbCriteria1";
      HelpProvider1.SetShowHelp(tbCriteria1, true);
      TextBox tbCriteria1_2 = tbCriteria1;
      size1 = new Size(136, 20);
      Size size3 = size1;
      tbCriteria1_2.Size = size3;
      tbCriteria1.TabIndex = 2;
      tbCriteria1.Tag = "cr1";
      tbCriteria1.Text = "";
      cmbxConcatOperator1.DropDownStyle = ComboBoxStyle.DropDownList;
      HelpProvider1.SetHelpString(cmbxConcatOperator1, "Choose the Boolean Concatenation Operator for this filter element. This is only required if another filter element will follow this one.");
      cmbxConcatOperator1.Items.AddRange(new object[3]
      {
        "",
        "AND",
        "OR"
      });
      ComboBox cmbxConcatOperator1_1 = cmbxConcatOperator1;
      point1 = new Point(400, 56);
      Point point4 = point1;
      cmbxConcatOperator1_1.Location = point4;
      cmbxConcatOperator1.Name = "cmbxConcatOperator1";
      HelpProvider1.SetShowHelp(cmbxConcatOperator1, true);
      ComboBox cmbxConcatOperator1_2 = cmbxConcatOperator1;
      size1 = new Size(48, 21);
      Size size4 = size1;
      cmbxConcatOperator1_2.Size = size4;
      cmbxConcatOperator1.TabIndex = 3;
      cmbxConcatOperator1.Tag = "co1";
      btnOK.Anchor = AnchorStyles.Bottom;
      Button btnOk = btnOK;
      point1 = new Point(107, 144);
      Point point5 = point1;
      btnOk.Location = point5;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 101;
      btnOK.Text = "OK";
      this.btnCancel.Anchor = AnchorStyles.Bottom;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(305, 144);
      Point point6 = point1;
      btnCancel.Location = point6;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 103;
      this.btnCancel.Text = "Cancel";
      this.btnReset.Anchor = AnchorStyles.Bottom;
      Button btnReset = this.btnReset;
      point1 = new Point(206, 144);
      Point point7 = point1;
      btnReset.Location = point7;
      this.btnReset.Name = "btnReset";
      this.btnReset.TabIndex = 102;
      this.btnReset.Text = "Reset";
      Label label1_1 = Label1;
      point1 = new Point(32, 32);
      Point point8 = point1;
      label1_1.Location = point8;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(96, 16);
      Size size5 = size1;
      label1_2.Size = size5;
      Label1.TabIndex = 43;
      Label1.Text = "Column";
      Label1.TextAlign = ContentAlignment.MiddleCenter;
      btnAddFilter.Anchor = AnchorStyles.Bottom;
      HelpProvider1.SetHelpString(btnAddFilter, "Add a new filter element");
      Button btnAddFilter1 = btnAddFilter;
      point1 = new Point(332, 88);
      Point point9 = point1;
      btnAddFilter1.Location = point9;
      btnAddFilter.Name = "btnAddFilter";
      HelpProvider1.SetShowHelp(btnAddFilter, true);
      Button btnAddFilter2 = btnAddFilter;
      size1 = new Size(40, 23);
      Size size6 = size1;
      btnAddFilter2.Size = size6;
      btnAddFilter.TabIndex = 100;
      btnAddFilter.Text = "Add";
      cmbxColumnName1.DropDownStyle = ComboBoxStyle.DropDownList;
      HelpProvider1.SetHelpString(cmbxColumnName1, "Choose the Column for this filter element");
      ComboBox cmbxColumnName1_1 = cmbxColumnName1;
      point1 = new Point(16, 56);
      Point point10 = point1;
      cmbxColumnName1_1.Location = point10;
      cmbxColumnName1.Name = "cmbxColumnName1";
      HelpProvider1.SetShowHelp(cmbxColumnName1, true);
      ComboBox cmbxColumnName1_2 = cmbxColumnName1;
      size1 = new Size(141, 21);
      Size size7 = size1;
      cmbxColumnName1_2.Size = size7;
      cmbxColumnName1.TabIndex = 0;
      cmbxColumnName1.Tag = "cn1";
      btnRemove1.AccessibleDescription = "This is a template don't move it";
      HelpProvider1.SetHelpString(btnRemove1, "Click to remove this filter element");
      Button btnRemove1_1 = btnRemove1;
      point1 = new Point(456, 56);
      Point point11 = point1;
      btnRemove1_1.Location = point11;
      btnRemove1.Name = "btnRemove1";
      HelpProvider1.SetShowHelp(btnRemove1, true);
      Button btnRemove1_2 = btnRemove1;
      size1 = new Size(21, 21);
      Size size8 = size1;
      btnRemove1_2.Size = size8;
      btnRemove1.TabIndex = 105;
      btnRemove1.Text = "This is a template don't move it";
      btnRemove1.Visible = false;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = this.btnCancel;
      size1 = new Size(486, 187);
      ClientSize = size1;
      Controls.Add(btnRemove1);
      Controls.Add(cmbxColumnName1);
      Controls.Add(btnAddFilter);
      Controls.Add(Label1);
      Controls.Add(this.btnReset);
      Controls.Add(btnOK);
      Controls.Add(this.btnCancel);
      Controls.Add(tbCriteria1);
      Controls.Add(cmbxMatchOperator1);
      Controls.Add(cmbxConcatOperator1);
      HelpButton = true;
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      MaximizeBox = false;
      MinimizeBox = false;
      Name = nameof (frmFilterDesigner);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Filter Editor";
      ResumeLayout(false);
    }

  private void btnOK_Click(object sender, EventArgs e)
  {
      RF.FilterParts.Clear();
      int num1 = FilterControlCount();
      int num2 = 1;
      while (num2 <= num1)
      {
        ComboBox control1 = (ComboBox) FindControl("cn" + StringType.FromInteger(num2));
        TextBox control2 = (TextBox) FindControl("cr" + StringType.FromInteger(num2));
        ComboBox control3 = (ComboBox) FindControl("mo" + StringType.FromInteger(num2));
        if (control1.SelectedIndex != -1 & StringType.StrCmp(control2.Text, "", false) != 0 & control3.SelectedIndex != -1)
        {
          ComboBox control4 = (ComboBox) FindControl("co" + StringType.FromInteger(num2));
          RF.FilterParts.Add(new RowFilterPart(((ColumnEntry) control1.SelectedItem).nativeColName, ((ColumnEntry) control1.SelectedItem).displayColName, StringType.FromObject(control3.SelectedItem), control2.Text, StringType.FromObject(control4.SelectedItem), ((ColumnEntry) control1.SelectedItem).data_type.Name));
        }
        checked { ++num2; }
      }
      DialogResult = DialogResult.OK;
      Hide();
    }

  private void btnReset_Click(object sender, EventArgs e)
  {
      m_HandlersActive = false;
      int num1 = FilterControlCount();
      int num2 = 1;
      while (num2 <= num1)
      {
        ((ComboBox) FindControl("cn" + StringType.FromInteger(num2))).SelectedIndex = -1;
        ((ComboBox) FindControl("mo" + StringType.FromInteger(num2))).SelectedIndex = -1;
        ((ComboBox) FindControl("co" + StringType.FromInteger(num2))).SelectedIndex = 0;
        ((TextBox) FindControl("cr" + StringType.FromInteger(num2))).Text = "";
        checked { ++num2; }
      }
      m_HandlersActive = true;
    }

  private void btnAddFilter_Click(object sender, EventArgs e) => AddFilterRow();

  private Control FindControl(string tagName)
  {
      Control control1 = null;
      try
      {
        foreach (Control control2 in Controls)
        {
          if (ObjectType.ObjTst(control2.Tag, tagName, false) == 0)
          {
            control1 = control2;
            break;
          }
        }
      }
      finally
      {
       
      }
      return control1;
    }

  private int FilterControlCount()
  {
      int num = 0;
      try
      {
        foreach (Control control in Controls)
        {
          if (StringType.StrCmp(Strings.Mid(StringType.FromObject(control.Tag), 1, 2), "cn", false) == 0)
            checked { ++num; }
        }
      }
      finally
      {
       
      }
      return num;
    }

  private void BuildGuiFromRowFilterList()
  {
      if (RF.FilterParts.Count > 1)
      {
        int num1 = checked (RF.FilterParts.Count - 1);
        int num2 = 1;
        while (num2 <= num1)
        {
          AddFilterRow();
          checked { ++num2; }
        }
      }
      int count = RF.FilterParts.Count;
      int num = 1;
      while (num <= count)
      {
        ComboBox control1 = (ComboBox) FindControl("cn" + StringType.FromInteger(num));
        ComboBox control2 = (ComboBox) FindControl("mo" + StringType.FromInteger(num));
        TextBox control3 = (TextBox) FindControl("cr" + StringType.FromInteger(num));
        ComboBox control4 = (ComboBox) FindControl("co" + StringType.FromInteger(num));
        RowFilterPart filterPart = (RowFilterPart) RF.FilterParts[checked (num - 1)];
        control1.SelectedIndex = control1.FindStringExact(filterPart.DisplayColumnName);
        control2.SelectedIndex = control2.FindStringExact(filterPart.MatchOperator);
        control3.Text = filterPart.FilterText;
        control4.SelectedIndex = control4.FindStringExact(filterPart.ConcatOperator);
        checked { ++num; }
      }
    }

  private void AddFilterRow()
  {
      SuspendLayout();
      int num = checked (FilterControlCount() + 1);
      ComboBox comboBox1 = new ComboBox();
      comboBox1.Tag = "cn" + StringType.FromInteger(num);
      comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox comboBox2 = comboBox1;
      Point point1 = default;
      ref Point local1 = ref point1;
      int x1 = cmbxColumnName1.Location.X;
      Point point2 = cmbxColumnName1.Location;
      int y1 = checked (point2.Y + 25 * (num - 1));
      local1 = new Point(x1, y1);
      Point point3 = point1;
      comboBox2.Location = point3;
      comboBox1.Size = cmbxColumnName1.Size;
      comboBox1.TabIndex = checked ((num - 1) * 5 + 1);
      try
      {
        foreach (object obj in cmbxColumnName1.Items)
        {
          object objectValue = RuntimeHelpers.GetObjectValue(obj);
          comboBox1.Items.Add(RuntimeHelpers.GetObjectValue(objectValue));
        }
      }
      finally
      {
       
      }
      comboBox1.DisplayMember = "displayColName";
      comboBox1.ValueMember = "nativeColName";
      comboBox1.SelectedIndexChanged += new EventHandler(cmbxColumnName_SelectedIndexChanged);
      ComboBox comboBox3 = new ComboBox();
      comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
      comboBox3.Items.AddRange(new object[10]
      {
        "LIKE",
        "NOT LIKE",
        "=",
        "<>",
        "<",
        ">",
        "<=",
        ">=",
        "IN",
        "NOT IN"
      });
      comboBox3.Tag = "mo" + StringType.FromInteger(num);
      ComboBox comboBox4 = comboBox3;
      point2 = new Point(cmbxMatchOperator1.Location.X, checked (cmbxMatchOperator1.Location.Y + 25 * (num - 1)));
      Point point4 = point2;
      comboBox4.Location = point4;
      comboBox3.Size = cmbxMatchOperator1.Size;
      comboBox3.MaxDropDownItems = 10;
      comboBox3.TabIndex = checked ((num - 1) * 5 + 2);
      TextBox textBox1 = new TextBox();
      textBox1.Tag = "cr" + StringType.FromInteger(num);
      TextBox textBox2 = textBox1;
      point2 = new Point(tbCriteria1.Location.X, checked (tbCriteria1.Location.Y + 25 * (num - 1)));
      Point point5 = point2;
      textBox2.Location = point5;
      textBox1.Size = tbCriteria1.Size;
      textBox1.TabIndex = checked ((num - 1) * 5 + 3);
      ComboBox comboBox5 = new ComboBox();
      comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
      comboBox5.Items.AddRange(new object[3]
      {
        "",
        "AND",
        "OR"
      });
      comboBox5.Tag = "co" + StringType.FromInteger(num);
      ComboBox comboBox6 = comboBox5;
      ref Point local2 = ref point2;
      Point location = cmbxConcatOperator1.Location;
      int x2 = location.X;
      int y2 = checked (cmbxConcatOperator1.Location.Y + 25 * (num - 1));
      local2 = new Point(x2, y2);
      Point point6 = point2;
      comboBox6.Location = point6;
      comboBox5.Size = cmbxConcatOperator1.Size;
      comboBox5.TabIndex = checked ((num - 1) * 5 + 4);
      comboBox5.SelectedIndexChanged += new EventHandler(cmbxConcatOperator_SelectedIndexChanged);
      Button button1 = new Button();
      button1.Text = "X";
      button1.Size = new Size(21, 21);
      button1.Tag = "rb" + StringType.FromInteger(num);
      button1.TabIndex = checked ((num - 1) * 5 + 5);
      Button button2 = button1;
      ref Point local3 = ref point2;
      location = btnRemove1.Location;
      int x3 = location.X;
      int y3 = checked (btnRemove1.Location.Y + 25 * (num - 1));
      local3 = new Point(x3, y3);
      Point point7 = point2;
      button2.Location = point7;
      button1.Click += new EventHandler(btnRemove_Click);
      Controls.AddRange(new Control[5]
      {
        comboBox1,
        comboBox3,
        textBox1,
        comboBox5,
        button1
      });
      ResizeAndMoveButtons(25);
      ResumeLayout(false);
    }

  private void RemoveFilterRow(int InstanceNum)
  {
      SuspendLayout();
      MoveControlsUp(InstanceNum);
      RenumberControls(checked (InstanceNum + 1));
      Controls.Remove(FindControl("cn" + StringType.FromInteger(InstanceNum)));
      Controls.Remove(FindControl("mo" + StringType.FromInteger(InstanceNum)));
      Controls.Remove(FindControl("cr" + StringType.FromInteger(InstanceNum)));
      Controls.Remove(FindControl("co" + StringType.FromInteger(InstanceNum)));
      Controls.Remove(FindControl("rb" + StringType.FromInteger(InstanceNum)));
      ResizeAndMoveButtons(-25);
      ResumeLayout();
    }

  private void RenumberControls(int startControlInstanceNum)
  {
      int num1 = startControlInstanceNum;
      int num2 = FilterControlCount();
      int num3 = num1;
      while (num3 <= num2)
      {
        FindControl("cn" + StringType.FromInteger(num3)).Tag = "cn" + StringType.FromInteger(checked (num3 - 1));
        FindControl("mo" + StringType.FromInteger(num3)).Tag = "mo" + StringType.FromInteger(checked (num3 - 1));
        FindControl("cr" + StringType.FromInteger(num3)).Tag = "cr" + StringType.FromInteger(checked (num3 - 1));
        FindControl("co" + StringType.FromInteger(num3)).Tag = "co" + StringType.FromInteger(checked (num3 - 1));
        FindControl("rb" + StringType.FromInteger(num3)).Tag = "rb" + StringType.FromInteger(checked (num3 - 1));
        checked { ++num3; }
      }
    }

  private void MoveControlsUp(int startControlInstanceNum)
  {
      int num1 = startControlInstanceNum;
      int num2 = FilterControlCount();
      int num3 = num1;
      while (num3 <= num2)
      {
        Control control1 = FindControl("cn" + StringType.FromInteger(num3));
        Control control2 = control1;
        Point location1 = default;
        ref Point local1 = ref location1;
        Point location2 = control1.Location;
        int x1 = location2.X;
        Point location3 = control1.Location;
        int y1 = checked (location3.Y - 25);
        local1 = new Point(x1, y1);
        Point point1 = location1;
        control2.Location = point1;
        Control control3 = FindControl("mo" + StringType.FromInteger(num3));
        Control control4 = control3;
        ref Point local2 = ref location3;
        location2 = control3.Location;
        int x2 = location2.X;
        int y2 = checked (control3.Location.Y - 25);
        local2 = new Point(x2, y2);
        Point point2 = location3;
        control4.Location = point2;
        Control control5 = FindControl("cr" + StringType.FromInteger(num3));
        Control control6 = control5;
        ref Point local3 = ref location3;
        location2 = control5.Location;
        int x3 = location2.X;
        int y3 = checked (control5.Location.Y - 25);
        local3 = new Point(x3, y3);
        Point point3 = location3;
        control6.Location = point3;
        Control control7 = FindControl("co" + StringType.FromInteger(num3));
        Control control8 = control7;
        ref Point local4 = ref location3;
        location2 = control7.Location;
        int x4 = location2.X;
        int y4 = checked (control7.Location.Y - 25);
        local4 = new Point(x4, y4);
        Point point4 = location3;
        control8.Location = point4;
        Control control9 = FindControl("rb" + StringType.FromInteger(num3));
        Control control10 = control9;
        ref Point local5 = ref location3;
        location2 = control9.Location;
        int x5 = location2.X;
        location1 = control9.Location;
        int y5 = checked (location1.Y - 25);
        local5 = new Point(x5, y5);
        Point point5 = location3;
        control10.Location = point5;
        checked { ++num3; }
      }
    }

  private void ResizeAndMoveButtons(int SizeY)
  {
      Size = new Size(Size.Width, checked (Size.Height + SizeY));
      Button btnOk = btnOK;
      Point point1 = default;
      ref Point local = ref point1;
      Point point2 = btnOK.Location;
      int x = point2.X;
      int y = checked (Size.Height - 70);
      local = new Point(x, y);
      Point point3 = point1;
      btnOk.Location = point3;
      Button btnCancel = this.btnCancel;
      point2 = new Point(this.btnCancel.Location.X, checked (Size.Height - 70));
      Point point4 = point2;
      btnCancel.Location = point4;
      Button btnReset = this.btnReset;
      point2 = new Point(this.btnReset.Location.X, checked (Size.Height - 70));
      Point point5 = point2;
      btnReset.Location = point5;
      Button btnAddFilter = this.btnAddFilter;
      point2 = new Point(this.btnAddFilter.Location.X, checked (Size.Height - 126));
      Point point6 = point2;
      btnAddFilter.Location = point6;
    }

  private void btnRemove_Click(object sender, EventArgs e) => RemoveFilterRow(IntegerType.FromString(Strings.Mid(StringType.FromObject(((Control) sender).Tag), 3)));

  private void cmbxColumnName_SelectedIndexChanged(object sender, EventArgs e)
  {
      if (!m_HandlersActive)
        return;
      SetupMatchOperatorCB((ComboBox) sender);
    }

  private void SetupMatchOperatorCB(ComboBox BrotherColNameCB)
  {
      Type dataType = ((ColumnEntry) BrotherColNameCB.SelectedItem).data_type;
      ComboBox control = (ComboBox) FindControl("mo" + Strings.Mid(StringType.FromObject(BrotherColNameCB.Tag), 3));
      string text = control.Text;
      control.Items.Clear();
      if (dataType == typeof (string))
        control.Items.AddRange(new object[10]
        {
          "LIKE",
          "NOT LIKE",
          "=",
          "<>",
          "<",
          ">",
          "<=",
          ">=",
          "IN",
          "NOT IN"
        });
      else if (dataType == typeof (int) | dataType == typeof (DateTime))
        control.Items.AddRange(new object[6]
        {
          "=",
          "<>",
          "<",
          ">",
          "<=",
          ">="
        });
      control.SelectedIndex = control.FindStringExact(text);
    }

  private void cmbxConcatOperator_SelectedIndexChanged(object sender, EventArgs e)
  {
      if (!m_HandlersActive || ((ComboBox) sender).SelectedIndex == 0 || FindControl("cn" + StringType.FromInteger(checked (IntegerType.FromString(Strings.Mid(StringType.FromObject(((Control) sender).Tag), 3)) + 1))) != null)
        return;
      AddFilterRow();
    }

  private void frmFilterDesigner_Load(object sender, EventArgs e)
  {
      SetupMatchOperatorCB(cmbxColumnName1);
      cmbxColumnName1.SelectedIndexChanged += new EventHandler(cmbxColumnName_SelectedIndexChanged);
      cmbxConcatOperator1.SelectedIndexChanged += new EventHandler(cmbxConcatOperator_SelectedIndexChanged);
      btnRemove1.Click += new EventHandler(btnRemove_Click);
    }
}