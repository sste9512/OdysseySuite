// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmInventoryEditor
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Kotortool_Legacy;

public class frmInventoryEditor : Form
{
  [AccessedThroughProperty("ToolTip1")]
  private ToolTip _ToolTip1;
  [AccessedThroughProperty("pnlTrash")]
  private Panel _pnlTrash;
  [AccessedThroughProperty("pnlRWeaponBkgnd")]
  private Panel _pnlRWeaponBkgnd;
  [AccessedThroughProperty("pnlBeltBkgnd")]
  private Panel _pnlBeltBkgnd;
  [AccessedThroughProperty("pnlLWeaponBkgnd")]
  private Panel _pnlLWeaponBkgnd;
  [AccessedThroughProperty("TabPage2")]
  private TabPage _TabPage2;
  [AccessedThroughProperty("pnlRArmBkgnd")]
  private Panel _pnlRArmBkgnd;
  [AccessedThroughProperty("pnlArmorBkgnd")]
  private Panel _pnlArmorBkgnd;
  [AccessedThroughProperty("TabPage1")]
  private TabPage _TabPage1;
  [AccessedThroughProperty("pnlRoot")]
  private Panel _pnlRoot;
  [AccessedThroughProperty("TabControl1")]
  private TabControl _TabControl1;
  [AccessedThroughProperty("pnlRightSide")]
  private Panel _pnlRightSide;
  [AccessedThroughProperty("Splitter1")]
  private Splitter _Splitter1;
  [AccessedThroughProperty("pnlLArmBkgnd")]
  private Panel _pnlLArmBkgnd;
  [AccessedThroughProperty("pnlCreatureItem3Bkgnd")]
  private Panel _pnlCreatureItem3Bkgnd;
  [AccessedThroughProperty("pnlHandsBkgnd")]
  private Panel _pnlHandsBkgnd;
  [AccessedThroughProperty("pnlHeadBkgnd")]
  private Panel _pnlHeadBkgnd;
  [AccessedThroughProperty("TabPage3")]
  private TabPage _TabPage3;
  [AccessedThroughProperty("pnlImplantBkgnd")]
  private Panel _pnlImplantBkgnd;
  [AccessedThroughProperty("Panel8")]
  private Panel _Panel8;
  [AccessedThroughProperty("dgPackItems")]
  private DataGrid _dgPackItems;
  [AccessedThroughProperty("pnlBelt")]
  private InventoryPanel _pnlBelt;
  [AccessedThroughProperty("TabPage4")]
  private TabPage _TabPage4;
  [AccessedThroughProperty("pnlCreatureItem2Bkgnd")]
  private Panel _pnlCreatureItem2Bkgnd;
  [AccessedThroughProperty("pnlLWeapon")]
  private InventoryPanel _pnlLWeapon;
  [AccessedThroughProperty("pnlRWeapon")]
  private InventoryPanel _pnlRWeapon;
  [AccessedThroughProperty("pnlArmor")]
  private InventoryPanel _pnlArmor;
  [AccessedThroughProperty("pnlLArm")]
  private InventoryPanel _pnlLArm;
  [AccessedThroughProperty("cmEquippedItems")]
  private ContextMenu _cmEquippedItems;
  [AccessedThroughProperty("pnlRArm")]
  private InventoryPanel _pnlRArm;
  [AccessedThroughProperty("pnlHands")]
  private InventoryPanel _pnlHands;
  [AccessedThroughProperty("pnlHead")]
  private InventoryPanel _pnlHead;
  [AccessedThroughProperty("pnlImplant")]
  private InventoryPanel _pnlImplant;
  [AccessedThroughProperty("TreeView")]
  private TreeView _TreeView;
  [AccessedThroughProperty("cmiDropable")]
  private ToolStripMenuItem _cmiDropable;
  [AccessedThroughProperty("pnlCreatureItem1")]
  private InventoryPanel _pnlCreatureItem1;
  [AccessedThroughProperty("pnlCreatureItem1Bkgnd")]
  private Panel _pnlCreatureItem1Bkgnd;
  [AccessedThroughProperty("pnlCreatureItem3")]
  private InventoryPanel _pnlCreatureItem3;
  [AccessedThroughProperty("btnCollapseAll")]
  private Button _btnCollapseAll;
  [AccessedThroughProperty("TabControl2")]
  private TabControl _TabControl2;
  [AccessedThroughProperty("pnlCreatureItem2")]
  private InventoryPanel _pnlCreatureItem2;
  [AccessedThroughProperty("btnExpandAll")]
  private Button _btnExpandAll;
  [AccessedThroughProperty("pnlCreatureHide")]
  private InventoryPanel _pnlCreatureHide;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("pnlCreatureHideBkgnd")]
  private Panel _pnlCreatureHideBkgnd;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  private IContainer components;
  public Options CurrentSettings;
  public clsDialogTlk g_clsDialogTlk;
  public ArrayList ResRef2NameLookupList;
  private DataTable dt;
  private DataView DView;
  private long MouseDownTime;
  private object MouseDoubleClickTime;
  private int KotorVersionIndex;

  public frmInventoryEditor()
  {
      Load += new EventHandler(frmInventoryEditor_Load);
      Closing += new CancelEventHandler(frmInventoryEditor_Closing);
      ResRef2NameLookupList = new ArrayList();
      dt = new DataTable();
      MouseDoubleClickTime = LongType.FromObject(ObjectType.MulObj(Registry.CurrentUser.OpenSubKey("Control Panel\\mouse").GetValue("DoubleClickSpeed"), 10000));
      InitializeComponent();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual TreeView TreeView
  {
    get => _TreeView;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TreeView != null)
        {
          _TreeView.MouseDown -= new MouseEventHandler(TreeView1_MouseDown);
          _TreeView.ItemDrag -= new ItemDragEventHandler(TreeView_ItemDrag);
        }
        _TreeView = value;
        if (_TreeView == null)
          return;
        _TreeView.MouseDown += new MouseEventHandler(TreeView1_MouseDown);
        _TreeView.ItemDrag += new ItemDragEventHandler(TreeView_ItemDrag);
      }
  }

  internal virtual InventoryPanel pnlImplant
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlImplant != null)
        {
          _pnlImplant.MouseDown -= new MouseEventHandler(pnl_MouseDown);
          _pnlImplant.DoubleClick -= new EventHandler(pnlEquipped_DoubleClick);
          _pnlImplant.DragDrop -= new DragEventHandler(pnl_DragDrop);
          _pnlImplant.DragEnter -= new DragEventHandler(pnlImplant_DragEnter);
        }
        _pnlImplant = value;
        if (_pnlImplant == null)
          return;
        _pnlImplant.MouseDown += new MouseEventHandler(pnl_MouseDown);
        _pnlImplant.DoubleClick += new EventHandler(pnlEquipped_DoubleClick);
        _pnlImplant.DragDrop += new DragEventHandler(pnl_DragDrop);
        _pnlImplant.DragEnter += new DragEventHandler(pnlImplant_DragEnter);
      }
    get => _pnlImplant;
  }

  internal virtual InventoryPanel pnlHead
  {
    get => _pnlHead;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlHead != null)
        {
          _pnlHead.MouseDown -= new MouseEventHandler(pnl_MouseDown);
          _pnlHead.DoubleClick -= new EventHandler(pnlEquipped_DoubleClick);
          _pnlHead.DragDrop -= new DragEventHandler(pnl_DragDrop);
          _pnlHead.DragEnter -= new DragEventHandler(pnlHead_DragEnter);
        }
        _pnlHead = value;
        if (_pnlHead == null)
          return;
        _pnlHead.MouseDown += new MouseEventHandler(pnl_MouseDown);
        _pnlHead.DoubleClick += new EventHandler(pnlEquipped_DoubleClick);
        _pnlHead.DragDrop += new DragEventHandler(pnl_DragDrop);
        _pnlHead.DragEnter += new DragEventHandler(pnlHead_DragEnter);
      }
  }

  internal virtual InventoryPanel pnlHands
  {
    get => _pnlHands;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlHands != null)
        {
          _pnlHands.MouseDown -= new MouseEventHandler(pnl_MouseDown);
          _pnlHands.DoubleClick -= new EventHandler(pnlEquipped_DoubleClick);
          _pnlHands.DragDrop -= new DragEventHandler(pnl_DragDrop);
          _pnlHands.DragEnter -= new DragEventHandler(pnlHands_DragEnter);
        }
        _pnlHands = value;
        if (_pnlHands == null)
          return;
        _pnlHands.MouseDown += new MouseEventHandler(pnl_MouseDown);
        _pnlHands.DoubleClick += new EventHandler(pnlEquipped_DoubleClick);
        _pnlHands.DragDrop += new DragEventHandler(pnl_DragDrop);
        _pnlHands.DragEnter += new DragEventHandler(pnlHands_DragEnter);
      }
  }

  internal virtual InventoryPanel pnlRArm
  {
    get => _pnlRArm;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlRArm != null)
        {
          _pnlRArm.MouseDown -= new MouseEventHandler(pnl_MouseDown);
          _pnlRArm.DoubleClick -= new EventHandler(pnlEquipped_DoubleClick);
          _pnlRArm.DragDrop -= new DragEventHandler(pnl_DragDrop);
          _pnlRArm.DragEnter -= new DragEventHandler(pnlRArm_DragEnter);
        }
        _pnlRArm = value;
        if (_pnlRArm == null)
          return;
        _pnlRArm.MouseDown += new MouseEventHandler(pnl_MouseDown);
        _pnlRArm.DoubleClick += new EventHandler(pnlEquipped_DoubleClick);
        _pnlRArm.DragDrop += new DragEventHandler(pnl_DragDrop);
        _pnlRArm.DragEnter += new DragEventHandler(pnlRArm_DragEnter);
      }
  }

  internal virtual InventoryPanel pnlLArm
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlLArm != null)
        {
          _pnlLArm.MouseDown -= new MouseEventHandler(pnl_MouseDown);
          _pnlLArm.DoubleClick -= new EventHandler(pnlEquipped_DoubleClick);
          _pnlLArm.DragDrop -= new DragEventHandler(pnl_DragDrop);
          _pnlLArm.DragEnter -= new DragEventHandler(pnlLArm_DragEnter);
        }
        _pnlLArm = value;
        if (_pnlLArm == null)
          return;
        _pnlLArm.MouseDown += new MouseEventHandler(pnl_MouseDown);
        _pnlLArm.DoubleClick += new EventHandler(pnlEquipped_DoubleClick);
        _pnlLArm.DragDrop += new DragEventHandler(pnl_DragDrop);
        _pnlLArm.DragEnter += new DragEventHandler(pnlLArm_DragEnter);
      }
    get => _pnlLArm;
  }

  internal virtual InventoryPanel pnlArmor
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlArmor != null)
        {
          _pnlArmor.MouseDown -= new MouseEventHandler(pnl_MouseDown);
          _pnlArmor.DoubleClick -= new EventHandler(pnlEquipped_DoubleClick);
          _pnlArmor.DragDrop -= new DragEventHandler(pnl_DragDrop);
          _pnlArmor.DragEnter -= new DragEventHandler(pnlArmor_DragEnter);
        }
        _pnlArmor = value;
        if (_pnlArmor == null)
          return;
        _pnlArmor.MouseDown += new MouseEventHandler(pnl_MouseDown);
        _pnlArmor.DoubleClick += new EventHandler(pnlEquipped_DoubleClick);
        _pnlArmor.DragDrop += new DragEventHandler(pnl_DragDrop);
        _pnlArmor.DragEnter += new DragEventHandler(pnlArmor_DragEnter);
      }
    get => _pnlArmor;
  }

  internal virtual InventoryPanel pnlRWeapon
  {
    get => _pnlRWeapon;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlRWeapon != null)
        {
          _pnlRWeapon.MouseDown -= new MouseEventHandler(pnl_MouseDown);
          _pnlRWeapon.DoubleClick -= new EventHandler(pnlEquipped_DoubleClick);
          _pnlRWeapon.DragDrop -= new DragEventHandler(pnl_DragDrop);
          _pnlRWeapon.DragEnter -= new DragEventHandler(pnlRWeapon_DragEnter);
        }
        _pnlRWeapon = value;
        if (_pnlRWeapon == null)
          return;
        _pnlRWeapon.MouseDown += new MouseEventHandler(pnl_MouseDown);
        _pnlRWeapon.DoubleClick += new EventHandler(pnlEquipped_DoubleClick);
        _pnlRWeapon.DragDrop += new DragEventHandler(pnl_DragDrop);
        _pnlRWeapon.DragEnter += new DragEventHandler(pnlRWeapon_DragEnter);
      }
  }

  internal virtual InventoryPanel pnlLWeapon
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlLWeapon != null)
        {
          _pnlLWeapon.MouseDown -= new MouseEventHandler(pnl_MouseDown);
          _pnlLWeapon.DoubleClick -= new EventHandler(pnlEquipped_DoubleClick);
          _pnlLWeapon.DragDrop -= new DragEventHandler(pnl_DragDrop);
          _pnlLWeapon.DragEnter -= new DragEventHandler(pnlLWeapon_DragEnter);
        }
        _pnlLWeapon = value;
        if (_pnlLWeapon == null)
          return;
        _pnlLWeapon.MouseDown += new MouseEventHandler(pnl_MouseDown);
        _pnlLWeapon.DoubleClick += new EventHandler(pnlEquipped_DoubleClick);
        _pnlLWeapon.DragDrop += new DragEventHandler(pnl_DragDrop);
        _pnlLWeapon.DragEnter += new DragEventHandler(pnlLWeapon_DragEnter);
      }
    get => _pnlLWeapon;
  }

  internal virtual InventoryPanel pnlBelt
  {
    get => _pnlBelt;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlBelt != null)
        {
          _pnlBelt.MouseDown -= new MouseEventHandler(pnl_MouseDown);
          _pnlBelt.DoubleClick -= new EventHandler(pnlEquipped_DoubleClick);
          _pnlBelt.DragDrop -= new DragEventHandler(pnl_DragDrop);
          _pnlBelt.DragEnter -= new DragEventHandler(pnlBelt_DragEnter);
        }
        _pnlBelt = value;
        if (_pnlBelt == null)
          return;
        _pnlBelt.MouseDown += new MouseEventHandler(pnl_MouseDown);
        _pnlBelt.DoubleClick += new EventHandler(pnlEquipped_DoubleClick);
        _pnlBelt.DragDrop += new DragEventHandler(pnl_DragDrop);
        _pnlBelt.DragEnter += new DragEventHandler(pnlBelt_DragEnter);
      }
  }

  internal virtual ToolTip ToolTip1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolTip1 == null)
          ;
        _ToolTip1 = value;
        if (_ToolTip1 == null)
          ;
      }
    get => _ToolTip1;
  }

  internal virtual DataGrid dgPackItems
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_dgPackItems != null)
        {
          _dgPackItems.CurrentCellChanged -= new EventHandler(dgPackItems_CurrentCellChanged);
          _dgPackItems.DragDrop -= new DragEventHandler(dgPackItems_DragDrop);
          _dgPackItems.DragEnter -= new DragEventHandler(dgPackItems_DragEnter);
        }
        _dgPackItems = value;
        if (_dgPackItems == null)
          return;
        _dgPackItems.CurrentCellChanged += new EventHandler(dgPackItems_CurrentCellChanged);
        _dgPackItems.DragDrop += new DragEventHandler(dgPackItems_DragDrop);
        _dgPackItems.DragEnter += new DragEventHandler(dgPackItems_DragEnter);
      }
    get => _dgPackItems;
  }

  internal virtual Button btnOK
  {
    get => _btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
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

  internal virtual TabControl TabControl1
  {
    get => _TabControl1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabControl1 == null)
          ;
        _TabControl1 = value;
        if (_TabControl1 == null)
          ;
      }
  }

  internal virtual TabPage TabPage1
  {
    get => _TabPage1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPage1 == null)
          ;
        _TabPage1 = value;
        if (_TabPage1 == null)
          ;
      }
  }

  internal virtual TabPage TabPage2
  {
    get => _TabPage2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPage2 == null)
          ;
        _TabPage2 = value;
        if (_TabPage2 == null)
          ;
      }
  }

  internal virtual Panel Panel8
  {
    get => _Panel8;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Panel8 == null)
          ;
        _Panel8 = value;
        if (_Panel8 == null)
          ;
      }
  }

  internal virtual Panel pnlImplantBkgnd
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlImplantBkgnd == null)
          ;
        _pnlImplantBkgnd = value;
        if (_pnlImplantBkgnd == null)
          ;
      }
    get => _pnlImplantBkgnd;
  }

  internal virtual Panel pnlHeadBkgnd
  {
    get => _pnlHeadBkgnd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlHeadBkgnd == null)
          ;
        _pnlHeadBkgnd = value;
        if (_pnlHeadBkgnd == null)
          ;
      }
  }

  internal virtual Panel pnlHandsBkgnd
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlHandsBkgnd == null)
          ;
        _pnlHandsBkgnd = value;
        if (_pnlHandsBkgnd == null)
          ;
      }
    get => _pnlHandsBkgnd;
  }

  internal virtual Panel pnlLArmBkgnd
  {
    get => _pnlLArmBkgnd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlLArmBkgnd == null)
          ;
        _pnlLArmBkgnd = value;
        if (_pnlLArmBkgnd == null)
          ;
      }
  }

  internal virtual Panel pnlArmorBkgnd
  {
    get => _pnlArmorBkgnd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlArmorBkgnd == null)
          ;
        _pnlArmorBkgnd = value;
        if (_pnlArmorBkgnd == null)
          ;
      }
  }

  internal virtual Panel pnlRArmBkgnd
  {
    get => _pnlRArmBkgnd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlRArmBkgnd == null)
          ;
        _pnlRArmBkgnd = value;
        if (_pnlRArmBkgnd == null)
          ;
      }
  }

  internal virtual Panel pnlLWeaponBkgnd
  {
    get => _pnlLWeaponBkgnd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlLWeaponBkgnd == null)
          ;
        _pnlLWeaponBkgnd = value;
        if (_pnlLWeaponBkgnd == null)
          ;
      }
  }

  internal virtual Panel pnlBeltBkgnd
  {
    get => _pnlBeltBkgnd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlBeltBkgnd == null)
          ;
        _pnlBeltBkgnd = value;
        if (_pnlBeltBkgnd == null)
          ;
      }
  }

  internal virtual Panel pnlRWeaponBkgnd
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlRWeaponBkgnd == null)
          ;
        _pnlRWeaponBkgnd = value;
        if (_pnlRWeaponBkgnd == null)
          ;
      }
    get => _pnlRWeaponBkgnd;
  }

  internal virtual Panel pnlTrash
  {
    get => _pnlTrash;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlTrash != null)
        {
          _pnlTrash.DragDrop -= new DragEventHandler(pnlTrash_DragDrop);
          _pnlTrash.DragEnter -= new DragEventHandler(pnlTrash_DragEnter);
        }
        _pnlTrash = value;
        if (_pnlTrash == null)
          return;
        _pnlTrash.DragDrop += new DragEventHandler(pnlTrash_DragDrop);
        _pnlTrash.DragEnter += new DragEventHandler(pnlTrash_DragEnter);
      }
  }

  internal virtual TabControl TabControl2
  {
    get => _TabControl2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabControl2 == null)
          ;
        _TabControl2 = value;
        if (_TabControl2 == null)
          ;
      }
  }

  internal virtual TabPage TabPage3
  {
    get => _TabPage3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPage3 == null)
          ;
        _TabPage3 = value;
        if (_TabPage3 == null)
          ;
      }
  }

  internal virtual TabPage TabPage4
  {
    get => _TabPage4;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPage4 == null)
          ;
        _TabPage4 = value;
        if (_TabPage4 == null)
          ;
      }
  }

  internal virtual ContextMenu cmEquippedItems
  {
    get => _cmEquippedItems;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmEquippedItems == null)
          ;
        _cmEquippedItems = value;
        if (_cmEquippedItems == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem cmiDropable
  {
    get => _cmiDropable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiDropable != null)
          _cmiDropable.Click -= new EventHandler(cmiDropable_Click);
        _cmiDropable = value;
        if (_cmiDropable == null)
          return;
        _cmiDropable.Click += new EventHandler(cmiDropable_Click);
      }
  }

  internal virtual InventoryPanel pnlCreatureItem1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlCreatureItem1 != null)
        {
          _pnlCreatureItem1.MouseDown -= new MouseEventHandler(pnl_MouseDown);
          _pnlCreatureItem1.DragDrop -= new DragEventHandler(pnl_DragDrop);
          _pnlCreatureItem1.DragEnter -= new DragEventHandler(pnlCreatureItem_DragEnter);
        }
        _pnlCreatureItem1 = value;
        if (_pnlCreatureItem1 == null)
          return;
        _pnlCreatureItem1.MouseDown += new MouseEventHandler(pnl_MouseDown);
        _pnlCreatureItem1.DragDrop += new DragEventHandler(pnl_DragDrop);
        _pnlCreatureItem1.DragEnter += new DragEventHandler(pnlCreatureItem_DragEnter);
      }
    get => _pnlCreatureItem1;
  }

  internal virtual InventoryPanel pnlCreatureItem3
  {
    get => _pnlCreatureItem3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlCreatureItem3 != null)
        {
          _pnlCreatureItem3.MouseDown -= new MouseEventHandler(pnl_MouseDown);
          _pnlCreatureItem3.DragDrop -= new DragEventHandler(pnl_DragDrop);
          _pnlCreatureItem3.DragEnter -= new DragEventHandler(pnlCreatureItem_DragEnter);
        }
        _pnlCreatureItem3 = value;
        if (_pnlCreatureItem3 == null)
          return;
        _pnlCreatureItem3.MouseDown += new MouseEventHandler(pnl_MouseDown);
        _pnlCreatureItem3.DragDrop += new DragEventHandler(pnl_DragDrop);
        _pnlCreatureItem3.DragEnter += new DragEventHandler(pnlCreatureItem_DragEnter);
      }
  }

  internal virtual InventoryPanel pnlCreatureItem2
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlCreatureItem2 != null)
        {
          _pnlCreatureItem2.MouseDown -= new MouseEventHandler(pnl_MouseDown);
          _pnlCreatureItem2.DragDrop -= new DragEventHandler(pnl_DragDrop);
          _pnlCreatureItem2.DragEnter -= new DragEventHandler(pnlCreatureItem_DragEnter);
        }
        _pnlCreatureItem2 = value;
        if (_pnlCreatureItem2 == null)
          return;
        _pnlCreatureItem2.MouseDown += new MouseEventHandler(pnl_MouseDown);
        _pnlCreatureItem2.DragDrop += new DragEventHandler(pnl_DragDrop);
        _pnlCreatureItem2.DragEnter += new DragEventHandler(pnlCreatureItem_DragEnter);
      }
    get => _pnlCreatureItem2;
  }

  internal virtual InventoryPanel pnlCreatureHide
  {
    get => _pnlCreatureHide;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlCreatureHide != null)
        {
          _pnlCreatureHide.MouseDown -= new MouseEventHandler(pnl_MouseDown);
          _pnlCreatureHide.DragDrop -= new DragEventHandler(pnl_DragDrop);
          _pnlCreatureHide.DragEnter -= new DragEventHandler(pnlCreatureHide_DragEnter);
        }
        _pnlCreatureHide = value;
        if (_pnlCreatureHide == null)
          return;
        _pnlCreatureHide.MouseDown += new MouseEventHandler(pnl_MouseDown);
        _pnlCreatureHide.DragDrop += new DragEventHandler(pnl_DragDrop);
        _pnlCreatureHide.DragEnter += new DragEventHandler(pnlCreatureHide_DragEnter);
      }
  }

  internal virtual Panel pnlCreatureHideBkgnd
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlCreatureHideBkgnd == null)
          ;
        _pnlCreatureHideBkgnd = value;
        if (_pnlCreatureHideBkgnd == null)
          ;
      }
    get => _pnlCreatureHideBkgnd;
  }

  internal virtual Panel pnlCreatureItem1Bkgnd
  {
    get => _pnlCreatureItem1Bkgnd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlCreatureItem1Bkgnd == null)
          ;
        _pnlCreatureItem1Bkgnd = value;
        if (_pnlCreatureItem1Bkgnd == null)
          ;
      }
  }

  internal virtual Panel pnlCreatureItem2Bkgnd
  {
    get => _pnlCreatureItem2Bkgnd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlCreatureItem2Bkgnd == null)
          ;
        _pnlCreatureItem2Bkgnd = value;
        if (_pnlCreatureItem2Bkgnd == null)
          ;
      }
  }

  internal virtual Panel pnlCreatureItem3Bkgnd
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlCreatureItem3Bkgnd == null)
          ;
        _pnlCreatureItem3Bkgnd = value;
        if (_pnlCreatureItem3Bkgnd == null)
          ;
      }
    get => _pnlCreatureItem3Bkgnd;
  }

  internal virtual Splitter Splitter1
  {
    get => _Splitter1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Splitter1 == null)
          ;
        _Splitter1 = value;
        if (_Splitter1 == null)
          ;
      }
  }

  internal virtual Button btnCollapseAll
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnCollapseAll != null)
          _btnCollapseAll.Click -= new EventHandler(btnCollapseAll_Click);
        _btnCollapseAll = value;
        if (_btnCollapseAll == null)
          return;
        _btnCollapseAll.Click += new EventHandler(btnCollapseAll_Click);
      }
    get => _btnCollapseAll;
  }

  internal virtual Button btnExpandAll
  {
    get => _btnExpandAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnExpandAll != null)
          _btnExpandAll.Click -= new EventHandler(btnExpandAll_Click);
        _btnExpandAll = value;
        if (_btnExpandAll == null)
          return;
        _btnExpandAll.Click += new EventHandler(btnExpandAll_Click);
      }
  }

  internal virtual Panel pnlRightSide
  {
    get => _pnlRightSide;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlRightSide == null)
          ;
        _pnlRightSide = value;
        if (_pnlRightSide == null)
          ;
      }
  }

  internal virtual Panel pnlRoot
  {
    get => _pnlRoot;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlRoot == null)
          ;
        _pnlRoot = value;
        if (_pnlRoot == null)
          ;
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      components = new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (frmInventoryEditor));
      TreeView = new TreeView();
      pnlImplant = new InventoryPanel();
      cmEquippedItems = new ContextMenu();
      cmiDropable = new ToolStripMenuItem();
      pnlHead = new InventoryPanel();
      pnlHands = new InventoryPanel();
      pnlRArm = new InventoryPanel();
      Panel8 = new Panel();
      pnlLArm = new InventoryPanel();
      pnlArmor = new InventoryPanel();
      pnlRWeapon = new InventoryPanel();
      pnlLWeapon = new InventoryPanel();
      pnlBelt = new InventoryPanel();
      ToolTip1 = new ToolTip(components);
      btnCollapseAll = new Button();
      btnExpandAll = new Button();
      dgPackItems = new DataGrid();
      btnOK = new Button();
      this.btnCancel = new Button();
      TabControl1 = new TabControl();
      TabPage1 = new TabPage();
      pnlImplantBkgnd = new Panel();
      pnlHeadBkgnd = new Panel();
      pnlHandsBkgnd = new Panel();
      pnlLArmBkgnd = new Panel();
      pnlArmorBkgnd = new Panel();
      pnlRArmBkgnd = new Panel();
      pnlLWeaponBkgnd = new Panel();
      pnlBeltBkgnd = new Panel();
      pnlRWeaponBkgnd = new Panel();
      TabPage2 = new TabPage();
      pnlCreatureItem1 = new InventoryPanel();
      pnlCreatureItem3 = new InventoryPanel();
      pnlCreatureItem2 = new InventoryPanel();
      pnlCreatureHide = new InventoryPanel();
      pnlCreatureHideBkgnd = new Panel();
      pnlCreatureItem1Bkgnd = new Panel();
      pnlCreatureItem2Bkgnd = new Panel();
      pnlCreatureItem3Bkgnd = new Panel();
      pnlTrash = new Panel();
      TabControl2 = new TabControl();
      TabPage3 = new TabPage();
      TabPage4 = new TabPage();
      pnlRightSide = new Panel();
      pnlRoot = new Panel();
      Splitter1 = new Splitter();
      pnlRArm.SuspendLayout();
      dgPackItems.BeginInit();
      TabControl1.SuspendLayout();
      TabPage1.SuspendLayout();
      TabPage2.SuspendLayout();
      TabControl2.SuspendLayout();
      TabPage3.SuspendLayout();
      pnlRightSide.SuspendLayout();
      pnlRoot.SuspendLayout();
      SuspendLayout();
      TreeView.Dock = DockStyle.Fill;
      TreeView.HideSelection = false;
      TreeView.ImageIndex = -1;
      TreeView treeView1 = TreeView;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      treeView1.Location = point2;
      TreeView.Name = "TreeView";
      TreeView.SelectedImageIndex = -1;
      TreeView treeView2 = TreeView;
      Size size1 = new Size(184, 390);
      Size size2 = size1;
      treeView2.Size = size2;
      TreeView.TabIndex = 0;
      pnlImplant.AllowDrop = true;
      pnlImplant.BackgroundImage = (Image) resourceManager.GetObject("pnlImplant.BackgroundImage");
      InventoryPanel pnlImplant1 = pnlImplant;
      point1 = new Point(15, 14);
      Point point3 = point1;
      pnlImplant1.Location = point3;
      pnlImplant.Name = "pnlImplant";
      InventoryPanel pnlImplant2 = pnlImplant;
      size1 = new Size(64, 64);
      Size size3 = size1;
      pnlImplant2.Size = size3;
      pnlImplant.TabIndex = 2;
      cmEquippedItems.ToolStripMenuItems.AddRange(new ToolStripMenuItem[1]
      {
        cmiDropable
      });
      cmiDropable.Checked = true;
      cmiDropable.Index = 0;
      cmiDropable.Text = "Dropable";
      pnlHead.AllowDrop = true;
      pnlHead.BackgroundImage = (Image) resourceManager.GetObject("pnlHead.BackgroundImage");
      InventoryPanel pnlHead1 = pnlHead;
      point1 = new Point(90, 14);
      Point point4 = point1;
      pnlHead1.Location = point4;
      pnlHead.Name = "pnlHead";
      InventoryPanel pnlHead2 = pnlHead;
      size1 = new Size(64, 64);
      Size size4 = size1;
      pnlHead2.Size = size4;
      pnlHead.TabIndex = 2;
      pnlHands.AllowDrop = true;
      pnlHands.BackgroundImage = (Image) resourceManager.GetObject("pnlHands.BackgroundImage");
      InventoryPanel pnlHands1 = pnlHands;
      point1 = new Point(165, 14);
      Point point5 = point1;
      pnlHands1.Location = point5;
      pnlHands.Name = "pnlHands";
      InventoryPanel pnlHands2 = pnlHands;
      size1 = new Size(64, 64);
      Size size5 = size1;
      pnlHands2.Size = size5;
      pnlHands.TabIndex = 2;
      pnlRArm.AllowDrop = true;
      pnlRArm.BackgroundImage = (Image) resourceManager.GetObject("pnlRArm.BackgroundImage");
      pnlRArm.Controls.Add(Panel8);
      InventoryPanel pnlRarm1 = pnlRArm;
      point1 = new Point(165, 88);
      Point point6 = point1;
      pnlRarm1.Location = point6;
      pnlRArm.Name = "pnlRArm";
      InventoryPanel pnlRarm2 = pnlRArm;
      size1 = new Size(64, 64);
      Size size6 = size1;
      pnlRarm2.Size = size6;
      pnlRArm.TabIndex = 2;
      Panel8.AllowDrop = true;
      Panel8.BackgroundImage = (Image) resourceManager.GetObject("Panel8.BackgroundImage");
      Panel panel8_1 = Panel8;
      point1 = new Point(-144, -8);
      Point point7 = point1;
      panel8_1.Location = point7;
      Panel8.Name = "Panel8";
      Panel panel8_2 = Panel8;
      size1 = new Size(94, 70);
      Size size7 = size1;
      panel8_2.Size = size7;
      Panel8.TabIndex = 2;
      pnlLArm.AllowDrop = true;
      pnlLArm.BackgroundImage = (Image) resourceManager.GetObject("pnlLArm.BackgroundImage");
      InventoryPanel pnlLarm1 = pnlLArm;
      point1 = new Point(15, 88);
      Point point8 = point1;
      pnlLarm1.Location = point8;
      pnlLArm.Name = "pnlLArm";
      InventoryPanel pnlLarm2 = pnlLArm;
      size1 = new Size(64, 64);
      Size size8 = size1;
      pnlLarm2.Size = size8;
      pnlLArm.TabIndex = 2;
      pnlArmor.AllowDrop = true;
      pnlArmor.BackgroundImage = (Image) resourceManager.GetObject("pnlArmor.BackgroundImage");
      InventoryPanel pnlArmor1 = pnlArmor;
      point1 = new Point(90, 88);
      Point point9 = point1;
      pnlArmor1.Location = point9;
      pnlArmor.Name = "pnlArmor";
      InventoryPanel pnlArmor2 = pnlArmor;
      size1 = new Size(64, 64);
      Size size9 = size1;
      pnlArmor2.Size = size9;
      pnlArmor.TabIndex = 2;
      pnlRWeapon.AllowDrop = true;
      pnlRWeapon.BackgroundImage = (Image) resourceManager.GetObject("pnlRWeapon.BackgroundImage");
      InventoryPanel pnlRweapon1 = pnlRWeapon;
      point1 = new Point(165, 162);
      Point point10 = point1;
      pnlRweapon1.Location = point10;
      pnlRWeapon.Name = "pnlRWeapon";
      InventoryPanel pnlRweapon2 = pnlRWeapon;
      size1 = new Size(64, 64);
      Size size10 = size1;
      pnlRweapon2.Size = size10;
      pnlRWeapon.TabIndex = 2;
      pnlLWeapon.AllowDrop = true;
      pnlLWeapon.BackgroundImage = (Image) resourceManager.GetObject("pnlLWeapon.BackgroundImage");
      InventoryPanel pnlLweapon1 = pnlLWeapon;
      point1 = new Point(15, 162);
      Point point11 = point1;
      pnlLweapon1.Location = point11;
      pnlLWeapon.Name = "pnlLWeapon";
      InventoryPanel pnlLweapon2 = pnlLWeapon;
      size1 = new Size(64, 64);
      Size size11 = size1;
      pnlLweapon2.Size = size11;
      pnlLWeapon.TabIndex = 2;
      pnlBelt.AllowDrop = true;
      pnlBelt.BackgroundImage = (Image) resourceManager.GetObject("pnlBelt.BackgroundImage");
      InventoryPanel pnlBelt1 = pnlBelt;
      point1 = new Point(90, 162);
      Point point12 = point1;
      pnlBelt1.Location = point12;
      pnlBelt.Name = "pnlBelt";
      InventoryPanel pnlBelt2 = pnlBelt;
      size1 = new Size(64, 64);
      Size size12 = size1;
      pnlBelt2.Size = size12;
      pnlBelt.TabIndex = 2;
      ToolTip1.AutoPopDelay = 5000;
      ToolTip1.InitialDelay = 250;
      ToolTip1.ReshowDelay = 100;
      btnCollapseAll.Image = (Image) resourceManager.GetObject("btnCollapseAll.Image");
      Button btnCollapseAll1 = btnCollapseAll;
      point1 = new Point(5, 104);
      Point point13 = point1;
      btnCollapseAll1.Location = point13;
      btnCollapseAll.Name = "btnCollapseAll";
      Button btnCollapseAll2 = btnCollapseAll;
      size1 = new Size(24, 23);
      Size size13 = size1;
      btnCollapseAll2.Size = size13;
      btnCollapseAll.TabIndex = 12;
      btnCollapseAll.Text = "C";
      ToolTip1.SetToolTip(btnCollapseAll, "Collapse all nodes in the treeview");
      btnExpandAll.Image = (Image) resourceManager.GetObject("btnExpandAll.Image");
      Button btnExpandAll1 = btnExpandAll;
      point1 = new Point(5, 48);
      Point point14 = point1;
      btnExpandAll1.Location = point14;
      btnExpandAll.Name = "btnExpandAll";
      Button btnExpandAll2 = btnExpandAll;
      size1 = new Size(24, 23);
      Size size14 = size1;
      btnExpandAll2.Size = size14;
      btnExpandAll.TabIndex = 11;
      btnExpandAll.Text = "E";
      ToolTip1.SetToolTip(btnExpandAll, "Expand all nodes in the treeview");
      dgPackItems.AllowDrop = true;
      dgPackItems.DataMember = "";
      dgPackItems.HeaderForeColor = SystemColors.ControlText;
      DataGrid dgPackItems1 = dgPackItems;
      point1 = new Point(0, 296);
      Point point15 = point1;
      dgPackItems1.Location = point15;
      dgPackItems.Name = "dgPackItems";
      DataGrid dgPackItems2 = dgPackItems;
      size1 = new Size(352, 120);
      Size size15 = size1;
      dgPackItems2.Size = size15;
      dgPackItems.TabIndex = 4;
      btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnOK.DialogResult = DialogResult.OK;
      Button btnOk = btnOK;
      point1 = new Point(392, 440);
      Point point16 = point1;
      btnOk.Location = point16;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 5;
      btnOK.Text = "OK";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(488, 440);
      Point point17 = point1;
      btnCancel.Location = point17;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "Cancel";
      TabControl1.Controls.Add(TabPage1);
      TabControl1.Controls.Add(TabPage2);
      TabControl tabControl1_1 = TabControl1;
      point1 = new Point(16, 0);
      Point point18 = point1;
      tabControl1_1.Location = point18;
      TabControl1.Name = "TabControl1";
      TabControl1.SelectedIndex = 0;
      TabControl tabControl1_2 = TabControl1;
      size1 = new Size(256, 288);
      Size size16 = size1;
      tabControl1_2.Size = size16;
      TabControl1.TabIndex = 7;
      TabPage1.Controls.Add(pnlImplant);
      TabPage1.Controls.Add(pnlLWeapon);
      TabPage1.Controls.Add(pnlBelt);
      TabPage1.Controls.Add(pnlHead);
      TabPage1.Controls.Add(pnlHands);
      TabPage1.Controls.Add(pnlRArm);
      TabPage1.Controls.Add(pnlLArm);
      TabPage1.Controls.Add(pnlArmor);
      TabPage1.Controls.Add(pnlRWeapon);
      TabPage1.Controls.Add(pnlImplantBkgnd);
      TabPage1.Controls.Add(pnlHeadBkgnd);
      TabPage1.Controls.Add(pnlHandsBkgnd);
      TabPage1.Controls.Add(pnlLArmBkgnd);
      TabPage1.Controls.Add(pnlArmorBkgnd);
      TabPage1.Controls.Add(pnlRArmBkgnd);
      TabPage1.Controls.Add(pnlLWeaponBkgnd);
      TabPage1.Controls.Add(pnlBeltBkgnd);
      TabPage1.Controls.Add(pnlRWeaponBkgnd);
      TabPage tabPage1_1 = TabPage1;
      point1 = new Point(4, 22);
      Point point19 = point1;
      ((Control) tabPage1_1).Location = point19;
      TabPage1.Name = "TabPage1";
      TabPage tabPage1_2 = TabPage1;
      size1 = new Size(248, 262);
      Size size17 = size1;
      tabPage1_2.Size = size17;
      TabPage1.TabIndex = 0;
      TabPage1.Text = "Standard Items";
      pnlImplantBkgnd.AllowDrop = true;
      pnlImplantBkgnd.BackgroundImage = (Image) resourceManager.GetObject("pnlImplantBkgnd.BackgroundImage");
      Panel pnlImplantBkgnd1 = pnlImplantBkgnd;
      point1 = new Point(12, 11);
      Point point20 = point1;
      pnlImplantBkgnd1.Location = point20;
      pnlImplantBkgnd.Name = "pnlImplantBkgnd";
      Panel pnlImplantBkgnd2 = pnlImplantBkgnd;
      size1 = new Size(70, 70);
      Size size18 = size1;
      pnlImplantBkgnd2.Size = size18;
      pnlImplantBkgnd.TabIndex = 2;
      pnlHeadBkgnd.AllowDrop = true;
      pnlHeadBkgnd.BackgroundImage = (Image) resourceManager.GetObject("pnlHeadBkgnd.BackgroundImage");
      Panel pnlHeadBkgnd1 = pnlHeadBkgnd;
      point1 = new Point(87, 11);
      Point point21 = point1;
      pnlHeadBkgnd1.Location = point21;
      pnlHeadBkgnd.Name = "pnlHeadBkgnd";
      Panel pnlHeadBkgnd2 = pnlHeadBkgnd;
      size1 = new Size(70, 70);
      Size size19 = size1;
      pnlHeadBkgnd2.Size = size19;
      pnlHeadBkgnd.TabIndex = 2;
      pnlHandsBkgnd.AllowDrop = true;
      pnlHandsBkgnd.BackgroundImage = (Image) resourceManager.GetObject("pnlHandsBkgnd.BackgroundImage");
      Panel pnlHandsBkgnd1 = pnlHandsBkgnd;
      point1 = new Point(162, 11);
      Point point22 = point1;
      pnlHandsBkgnd1.Location = point22;
      pnlHandsBkgnd.Name = "pnlHandsBkgnd";
      Panel pnlHandsBkgnd2 = pnlHandsBkgnd;
      size1 = new Size(70, 70);
      Size size20 = size1;
      pnlHandsBkgnd2.Size = size20;
      pnlHandsBkgnd.TabIndex = 2;
      pnlLArmBkgnd.AllowDrop = true;
      pnlLArmBkgnd.BackgroundImage = (Image) resourceManager.GetObject("pnlLArmBkgnd.BackgroundImage");
      Panel pnlLarmBkgnd1 = pnlLArmBkgnd;
      point1 = new Point(12, 85);
      Point point23 = point1;
      pnlLarmBkgnd1.Location = point23;
      pnlLArmBkgnd.Name = "pnlLArmBkgnd";
      Panel pnlLarmBkgnd2 = pnlLArmBkgnd;
      size1 = new Size(70, 70);
      Size size21 = size1;
      pnlLarmBkgnd2.Size = size21;
      pnlLArmBkgnd.TabIndex = 5;
      pnlArmorBkgnd.AllowDrop = true;
      pnlArmorBkgnd.BackgroundImage = (Image) resourceManager.GetObject("pnlArmorBkgnd.BackgroundImage");
      Panel pnlArmorBkgnd1 = pnlArmorBkgnd;
      point1 = new Point(87, 85);
      Point point24 = point1;
      pnlArmorBkgnd1.Location = point24;
      pnlArmorBkgnd.Name = "pnlArmorBkgnd";
      Panel pnlArmorBkgnd2 = pnlArmorBkgnd;
      size1 = new Size(70, 70);
      Size size22 = size1;
      pnlArmorBkgnd2.Size = size22;
      pnlArmorBkgnd.TabIndex = 4;
      pnlRArmBkgnd.AllowDrop = true;
      pnlRArmBkgnd.BackgroundImage = (Image) resourceManager.GetObject("pnlRArmBkgnd.BackgroundImage");
      Panel pnlRarmBkgnd1 = pnlRArmBkgnd;
      point1 = new Point(162, 85);
      Point point25 = point1;
      pnlRarmBkgnd1.Location = point25;
      pnlRArmBkgnd.Name = "pnlRArmBkgnd";
      Panel pnlRarmBkgnd2 = pnlRArmBkgnd;
      size1 = new Size(70, 70);
      Size size23 = size1;
      pnlRarmBkgnd2.Size = size23;
      pnlRArmBkgnd.TabIndex = 3;
      pnlLWeaponBkgnd.AllowDrop = true;
      pnlLWeaponBkgnd.BackgroundImage = (Image) resourceManager.GetObject("pnlLWeaponBkgnd.BackgroundImage");
      Panel pnlLweaponBkgnd1 = pnlLWeaponBkgnd;
      point1 = new Point(12, 159);
      Point point26 = point1;
      pnlLweaponBkgnd1.Location = point26;
      pnlLWeaponBkgnd.Name = "pnlLWeaponBkgnd";
      Panel pnlLweaponBkgnd2 = pnlLWeaponBkgnd;
      size1 = new Size(70, 70);
      Size size24 = size1;
      pnlLweaponBkgnd2.Size = size24;
      pnlLWeaponBkgnd.TabIndex = 8;
      pnlBeltBkgnd.AllowDrop = true;
      pnlBeltBkgnd.BackgroundImage = (Image) resourceManager.GetObject("pnlBeltBkgnd.BackgroundImage");
      Panel pnlBeltBkgnd1 = pnlBeltBkgnd;
      point1 = new Point(87, 159);
      Point point27 = point1;
      pnlBeltBkgnd1.Location = point27;
      pnlBeltBkgnd.Name = "pnlBeltBkgnd";
      Panel pnlBeltBkgnd2 = pnlBeltBkgnd;
      size1 = new Size(70, 70);
      Size size25 = size1;
      pnlBeltBkgnd2.Size = size25;
      pnlBeltBkgnd.TabIndex = 7;
      pnlRWeaponBkgnd.AllowDrop = true;
      pnlRWeaponBkgnd.BackgroundImage = (Image) resourceManager.GetObject("pnlRWeaponBkgnd.BackgroundImage");
      Panel pnlRweaponBkgnd1 = pnlRWeaponBkgnd;
      point1 = new Point(162, 159);
      Point point28 = point1;
      pnlRweaponBkgnd1.Location = point28;
      pnlRWeaponBkgnd.Name = "pnlRWeaponBkgnd";
      Panel pnlRweaponBkgnd2 = pnlRWeaponBkgnd;
      size1 = new Size(70, 70);
      Size size26 = size1;
      pnlRweaponBkgnd2.Size = size26;
      pnlRWeaponBkgnd.TabIndex = 6;
      TabPage2.Controls.Add(pnlCreatureItem1);
      TabPage2.Controls.Add(pnlCreatureItem3);
      TabPage2.Controls.Add(pnlCreatureItem2);
      TabPage2.Controls.Add(pnlCreatureHide);
      TabPage2.Controls.Add(pnlCreatureHideBkgnd);
      TabPage2.Controls.Add(pnlCreatureItem1Bkgnd);
      TabPage2.Controls.Add(pnlCreatureItem2Bkgnd);
      TabPage2.Controls.Add(pnlCreatureItem3Bkgnd);
      TabPage tabPage2_1 = TabPage2;
      point1 = new Point(4, 22);
      Point point29 = point1;
      ((Control) tabPage2_1).Location = point29;
      TabPage2.Name = "TabPage2";
      TabPage tabPage2_2 = TabPage2;
      size1 = new Size(248, 262);
      Size size27 = size1;
      tabPage2_2.Size = size27;
      TabPage2.TabIndex = 1;
      TabPage2.Text = "Natural Items";
      pnlCreatureItem1.AllowDrop = true;
      pnlCreatureItem1.BackgroundImage = (Image) resourceManager.GetObject("pnlCreatureItem1.BackgroundImage");
      InventoryPanel pnlCreatureItem1_1 = pnlCreatureItem1;
      point1 = new Point(15, 14);
      Point point30 = point1;
      pnlCreatureItem1_1.Location = point30;
      pnlCreatureItem1.Name = "pnlCreatureItem1";
      InventoryPanel pnlCreatureItem1_2 = pnlCreatureItem1;
      size1 = new Size(64, 64);
      Size size28 = size1;
      pnlCreatureItem1_2.Size = size28;
      pnlCreatureItem1.TabIndex = 4;
      pnlCreatureItem3.AllowDrop = true;
      pnlCreatureItem3.BackgroundImage = (Image) resourceManager.GetObject("pnlCreatureItem3.BackgroundImage");
      InventoryPanel pnlCreatureItem3_1 = pnlCreatureItem3;
      point1 = new Point(165, 14);
      Point point31 = point1;
      pnlCreatureItem3_1.Location = point31;
      pnlCreatureItem3.Name = "pnlCreatureItem3";
      InventoryPanel pnlCreatureItem3_2 = pnlCreatureItem3;
      size1 = new Size(64, 64);
      Size size29 = size1;
      pnlCreatureItem3_2.Size = size29;
      pnlCreatureItem3.TabIndex = 3;
      pnlCreatureItem2.AllowDrop = true;
      pnlCreatureItem2.BackgroundImage = (Image) resourceManager.GetObject("pnlCreatureItem2.BackgroundImage");
      InventoryPanel pnlCreatureItem2_1 = pnlCreatureItem2;
      point1 = new Point(90, 14);
      Point point32 = point1;
      pnlCreatureItem2_1.Location = point32;
      pnlCreatureItem2.Name = "pnlCreatureItem2";
      InventoryPanel pnlCreatureItem2_2 = pnlCreatureItem2;
      size1 = new Size(64, 64);
      Size size30 = size1;
      pnlCreatureItem2_2.Size = size30;
      pnlCreatureItem2.TabIndex = 4;
      pnlCreatureHide.AllowDrop = true;
      pnlCreatureHide.BackgroundImage = (Image) resourceManager.GetObject("pnlCreatureHide.BackgroundImage");
      InventoryPanel pnlCreatureHide1 = pnlCreatureHide;
      point1 = new Point(90, 88);
      Point point33 = point1;
      pnlCreatureHide1.Location = point33;
      pnlCreatureHide.Name = "pnlCreatureHide";
      InventoryPanel pnlCreatureHide2 = pnlCreatureHide;
      size1 = new Size(64, 64);
      Size size31 = size1;
      pnlCreatureHide2.Size = size31;
      pnlCreatureHide.TabIndex = 4;
      pnlCreatureHideBkgnd.AllowDrop = true;
      pnlCreatureHideBkgnd.BackgroundImage = (Image) resourceManager.GetObject("pnlCreatureHideBkgnd.BackgroundImage");
      Panel creatureHideBkgnd1 = pnlCreatureHideBkgnd;
      point1 = new Point(87, 85);
      Point point34 = point1;
      creatureHideBkgnd1.Location = point34;
      pnlCreatureHideBkgnd.Name = "pnlCreatureHideBkgnd";
      Panel creatureHideBkgnd2 = pnlCreatureHideBkgnd;
      size1 = new Size(70, 70);
      Size size32 = size1;
      creatureHideBkgnd2.Size = size32;
      pnlCreatureHideBkgnd.TabIndex = 6;
      pnlCreatureItem1Bkgnd.AllowDrop = true;
      pnlCreatureItem1Bkgnd.BackgroundImage = (Image) resourceManager.GetObject("pnlCreatureItem1Bkgnd.BackgroundImage");
      Panel creatureItem1Bkgnd1 = pnlCreatureItem1Bkgnd;
      point1 = new Point(12, 11);
      Point point35 = point1;
      creatureItem1Bkgnd1.Location = point35;
      pnlCreatureItem1Bkgnd.Name = "pnlCreatureItem1Bkgnd";
      Panel creatureItem1Bkgnd2 = pnlCreatureItem1Bkgnd;
      size1 = new Size(70, 70);
      Size size33 = size1;
      creatureItem1Bkgnd2.Size = size33;
      pnlCreatureItem1Bkgnd.TabIndex = 6;
      pnlCreatureItem2Bkgnd.AllowDrop = true;
      pnlCreatureItem2Bkgnd.BackgroundImage = (Image) resourceManager.GetObject("pnlCreatureItem2Bkgnd.BackgroundImage");
      Panel creatureItem2Bkgnd1 = pnlCreatureItem2Bkgnd;
      point1 = new Point(87, 11);
      Point point36 = point1;
      creatureItem2Bkgnd1.Location = point36;
      pnlCreatureItem2Bkgnd.Name = "pnlCreatureItem2Bkgnd";
      Panel creatureItem2Bkgnd2 = pnlCreatureItem2Bkgnd;
      size1 = new Size(70, 70);
      Size size34 = size1;
      creatureItem2Bkgnd2.Size = size34;
      pnlCreatureItem2Bkgnd.TabIndex = 6;
      pnlCreatureItem3Bkgnd.AllowDrop = true;
      pnlCreatureItem3Bkgnd.BackgroundImage = (Image) resourceManager.GetObject("pnlCreatureItem3Bkgnd.BackgroundImage");
      Panel creatureItem3Bkgnd1 = pnlCreatureItem3Bkgnd;
      point1 = new Point(162, 11);
      Point point37 = point1;
      creatureItem3Bkgnd1.Location = point37;
      pnlCreatureItem3Bkgnd.Name = "pnlCreatureItem3Bkgnd";
      Panel creatureItem3Bkgnd2 = pnlCreatureItem3Bkgnd;
      size1 = new Size(70, 70);
      Size size35 = size1;
      creatureItem3Bkgnd2.Size = size35;
      pnlCreatureItem3Bkgnd.TabIndex = 6;
      pnlTrash.AllowDrop = true;
      pnlTrash.BackgroundImage = (Image) resourceManager.GetObject("pnlTrash.BackgroundImage");
      Panel pnlTrash1 = pnlTrash;
      point1 = new Point(288, 184);
      Point point38 = point1;
      pnlTrash1.Location = point38;
      pnlTrash.Name = "pnlTrash";
      Panel pnlTrash2 = pnlTrash;
      size1 = new Size(64, 64);
      Size size36 = size1;
      pnlTrash2.Size = size36;
      pnlTrash.TabIndex = 2;
      TabControl2.Controls.Add(TabPage3);
      TabControl2.Controls.Add(TabPage4);
      TabControl2.Dock = DockStyle.Left;
      TabControl tabControl2_1 = TabControl2;
      point1 = new Point(0, 0);
      Point point39 = point1;
      tabControl2_1.Location = point39;
      TabControl2.Name = "TabControl2";
      TabControl2.SelectedIndex = 0;
      TabControl tabControl2_2 = TabControl2;
      size1 = new Size(192, 416);
      Size size37 = size1;
      tabControl2_2.Size = size37;
      TabControl2.TabIndex = 8;
      TabPage3.Controls.Add(TreeView);
      TabPage tabPage3_1 = TabPage3;
      point1 = new Point(4, 22);
      Point point40 = point1;
      ((Control) tabPage3_1).Location = point40;
      TabPage3.Name = "TabPage3";
      TabPage tabPage3_2 = TabPage3;
      size1 = new Size(184, 390);
      Size size38 = size1;
      tabPage3_2.Size = size38;
      TabPage3.TabIndex = 0;
      TabPage3.Text = "Game Items";
      TabPage tabPage4_1 = TabPage4;
      point1 = new Point(4, 22);
      Point point41 = point1;
      ((Control) tabPage4_1).Location = point41;
      TabPage4.Name = "TabPage4";
      TabPage tabPage4_2 = TabPage4;
      size1 = new Size(184, 406);
      Size size39 = size1;
      tabPage4_2.Size = size39;
      TabPage4.TabIndex = 1;
      TabPage4.Text = "Custom Items";
      pnlRightSide.AutoScroll = true;
      pnlRightSide.Controls.Add(TabControl1);
      pnlRightSide.Controls.Add(pnlTrash);
      pnlRightSide.Controls.Add(dgPackItems);
      pnlRightSide.Dock = DockStyle.Fill;
      Panel pnlRightSide1 = pnlRightSide;
      point1 = new Point(192, 0);
      Point point42 = point1;
      pnlRightSide1.Location = point42;
      pnlRightSide.Name = "pnlRightSide";
      Panel pnlRightSide2 = pnlRightSide;
      size1 = new Size(352, 416);
      Size size40 = size1;
      pnlRightSide2.Size = size40;
      pnlRightSide.TabIndex = 9;
      pnlRoot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      pnlRoot.Controls.Add(Splitter1);
      pnlRoot.Controls.Add(pnlRightSide);
      pnlRoot.Controls.Add(TabControl2);
      Panel pnlRoot1 = pnlRoot;
      point1 = new Point(32, 16);
      Point point43 = point1;
      pnlRoot1.Location = point43;
      pnlRoot.Name = "pnlRoot";
      Panel pnlRoot2 = pnlRoot;
      size1 = new Size(544, 416);
      Size size41 = size1;
      pnlRoot2.Size = size41;
      pnlRoot.TabIndex = 10;
      Splitter splitter1_1 = Splitter1;
      point1 = new Point(192, 0);
      Point point44 = point1;
      splitter1_1.Location = point44;
      Splitter1.MinSize = 192;
      Splitter1.Name = "Splitter1";
      Splitter splitter1_2 = Splitter1;
      size1 = new Size(3, 416);
      Size size42 = size1;
      splitter1_2.Size = size42;
      Splitter1.TabIndex = 10;
      Splitter1.TabStop = false;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(600, 469);
      ClientSize = size1;
      Controls.Add(btnCollapseAll);
      Controls.Add(btnExpandAll);
      Controls.Add(pnlRoot);
      Controls.Add(btnOK);
      Controls.Add(this.btnCancel);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      size1 = new Size(608, 496);
      MinimumSize = size1;
      Name = nameof (frmInventoryEditor);
      SizeGripStyle = SizeGripStyle.Show;
      StartPosition = FormStartPosition.Manual;
      Text = "Inventory Editor - KotOR ";
      pnlRArm.ResumeLayout(false);
      dgPackItems.EndInit();
      TabControl1.ResumeLayout(false);
      TabPage1.ResumeLayout(false);
      TabPage2.ResumeLayout(false);
      TabControl2.ResumeLayout(false);
      TabPage3.ResumeLayout(false);
      pnlRightSide.ResumeLayout(false);
      pnlRoot.ResumeLayout(false);
      ResumeLayout(false);
    }

  public frmInventoryEditor(int KotorVerIndex)
    : this()
  {
      KotorVersionIndex = KotorVerIndex;
      if (KotorVerIndex == 0)
        Text += "I";
      else
        Text += "II";
      CurrentSettings = UserSettings.GetSettings();
      g_clsDialogTlk = new clsDialogTlk(CurrentSettings.KotorLocation(KotorVerIndex) + "\\dialog.tlk");
      SetEquippedPanelsToolTips();
      HidePanelIndicators();
      BuildTreeParents();
      BuildDataGrid();
    }

  private void TreeView_ItemDrag(object sender, ItemDragEventArgs e)
  {
      TreeNode treeNode = (TreeNode) e.Item;
      string str = treeNode.Text;
      if (ObjectType.ObjTst(treeNode.Tag, "", false) != 0)
        str = StringType.FromObject(ObjectType.StrCatObj(str, ObjectType.StrCatObj("|", treeNode.Tag)));
      int num = (int) DoDragDrop(str, DragDropEffects.Copy | DragDropEffects.Move);
    }

  private void pnlImplant_DragEnter(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      e.Effect = ShowDragEnterPermission(e, "0x00200");
    }

  private void pnlHead_DragEnter(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      e.Effect = ShowDragEnterPermission(e, "0x00001");
    }

  private void pnlHands_DragEnter(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      e.Effect = ShowDragEnterPermission(e, "0x00008");
    }

  private void pnlLArm_DragEnter(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      e.Effect = ShowDragEnterPermission(e, "0x00100,0x00180");
    }

  private void pnlArmor_DragEnter(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      e.Effect = ShowDragEnterPermission(e, "0x00002");
    }

  private void pnlRArm_DragEnter(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      e.Effect = ShowDragEnterPermission(e, "0x00080,0x00180");
    }

  private void pnlLWeapon_DragEnter(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      e.Effect = ShowDragEnterPermission(e, "0x00020,0x00030,0x1C030");
    }

  private void pnlBelt_DragEnter(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      e.Effect = ShowDragEnterPermission(e, "0x00400,0x20000");
    }

  private void pnlRWeapon_DragEnter(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      e.Effect = ShowDragEnterPermission(e, "0x00010,0x00030,0x1C030");
    }

  private void pnlCreatureHide_DragEnter(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      e.Effect = ShowDragEnterPermission(e, "0x20000");
    }

  private void pnlCreatureItem_DragEnter(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      e.Effect = ShowDragEnterPermission(e, "0x1C030");
    }

  private void dgPackItems_DragEnter(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      e.Effect = DragDropEffects.Copy;
    }

  private DragDropEffects ShowDragEnterPermission(
    DragEventArgs DragEventArgs,
    string AllowedSlotsString)
  {
      if (!DragEventArgs.Data.GetDataPresent(DataFormats.Text))
        return DragDropEffects.None;
      string[] strArray = Strings.Split(StringType.FromObject(DragEventArgs.Data.GetData(typeof (string))), "|");
      int num = Strings.InStr(AllowedSlotsString, Strings.Mid(strArray[2], 4));
      return strArray.Length > 2 && num > 0 ? DragDropEffects.Copy : DragDropEffects.None;
    }

  private void pnlTrash_DragEnter(object sender, DragEventArgs e)
  {
      if (!(e.Data.GetFormats().Length == 1 & e.Data.GetFormats()[0].ToString().EndsWith("InventoryPanel")))
        return;
      e.Effect = DragDropEffects.Move;
    }

  private void pnl_DragDrop(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      ManageEqInventory(StringType.FromObject(e.Data.GetData(typeof (string))), (InventoryPanel) sender, true);
    }

  private void dgPackItems_DragDrop(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      string[] strArray = Strings.Split(StringType.FromObject(e.Data.GetData(typeof (string))), "|");
      InsertToGridOrIncrement(strArray[0], strArray[1]);
    }

  private void pnlTrash_DragDrop(object sender, DragEventArgs e)
  {
      if (!(e.Data.GetFormats().Length == 1 & e.Data.GetFormats()[0].ToString().EndsWith("InventoryPanel")))
        return;
      InventoryPanel data = (InventoryPanel) e.Data.GetData("kotor_tool.InventoryPanel");
      ToolTip1.SetToolTip(data, "(empty)");
      data.Tag = null;
      data.IsEmpty = true;
      try
      {
        foreach (Control control in TabPage1.Controls)
        {
          if (StringType.StrCmp(control.Name, data.Name + "Bkgnd", false) == 0)
          {
            control.Visible = false;
            return;
          }
        }
      }
      finally
      {
        
      }
      try
      {
        foreach (Control control in TabPage2.Controls)
        {
          if (StringType.StrCmp(control.Name, data.Name + "Bkgnd", false) == 0)
          {
            control.Visible = false;
            break;
          }
        }
      }
      finally
      {
       
      }
    }

  public void ConfigureForPlaceableEditorUse()
  {
      TabControl1.Visible = false;
      TabControl1.Enabled = false;
      pnlTrash.Visible = false;
      pnlTrash.Enabled = false;
      dgPackItems.Dock = DockStyle.Fill;
      dgPackItems.CaptionText = "Object Inventory";
    }

  private void frmInventoryEditor_Load(object sender, EventArgs e) => PositionWindow();

  private void frmInventoryEditor_Closing(object sender, CancelEventArgs e) => SaveSettings();

  public void BuildDataTable()
  {
      dt.Columns.Add(new DataColumn("Name", typeof (string))
      {
        DefaultValue = ""
      });
      dt.Columns.Add(new DataColumn("ResRef", typeof (string))
      {
        DefaultValue = ""
      });
      dt.Columns.Add(new DataColumn("Qty", typeof (int))
      {
        DefaultValue = 1
      });
      dt.Columns.Add(new DataColumn("Dropable", typeof (bool))
      {
        DefaultValue = true
      });
    }

  public void BuildDataGrid()
  {
      BuildDataTable();
      DView = dt.DefaultView;
      DView.AllowDelete = true;
      DView.AllowNew = false;
      DView.AllowEdit = true;
      DataGridTableStyle table = new DataGridTableStyle();
      dgPackItems.TableStyles.Clear();
      table.MappingName = dt.TableName;
      table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
      DataGridTextBoxColumn column1 = new DataGridTextBoxColumn();
      column1.MappingName = "Name";
      column1.HeaderText = "Name";
      column1.NullText = "";
      column1.ReadOnly = true;
      table.GridColumnStyles.Add(column1);
      DataGridTextBoxColumn column2 = new DataGridTextBoxColumn();
      column2.MappingName = "ResRef";
      column2.HeaderText = "ResRef";
      column2.NullText = "";
      column2.TextBox.CharacterCasing = CharacterCasing.Lower;
      column2.TextBox.MaxLength = 16;
      table.GridColumnStyles.Add(column2);
      DataGridTextBoxColumn column3 = new DataGridTextBoxColumn();
      column3.MappingName = "Qty";
      column3.HeaderText = "Qty";
      column3.NullText = "";
      table.GridColumnStyles.Add(column3);
      DataGridBoolColumn column4 = new DataGridBoolColumn();
      column4.MappingName = "Dropable";
      column4.HeaderText = "Dropable";
      column4.NullValue = false;
      column4.AllowNull = false;
      table.GridColumnStyles.Add(column4);
      dgPackItems.TableStyles.Add(table);
      dgPackItems.SetDataBinding(DView, null);
      dgPackItems.CaptionText = "Pack Inventory";
      dgPackItems.CaptionFont = new Font("Microsoft Sans Serif", 9f);
    }

  private void TreeView1_MouseDown(object sender, MouseEventArgs e) => TreeView.SelectedNode = TreeView.GetNodeAt(new Point(e.X, e.Y));

  public void BuildTreeParents()
  {
      ChitinKey chitinKey = new ChitinKey(CurrentSettings.KeyFileLocation(KotorVersionIndex));
      string[] strArray1 = new string[2];
      FileStream fsin = new FileStream(CurrentSettings.KotorLocation(KotorVersionIndex) + "\\data\\templates.bif", FileMode.Open);
      BIFFArchive biffArchive = new BIFFArchive(fsin);
      bool flag1 = true;
      byte[] numArray = new byte[] { };
      if (CurrentSettings.bUseOverrideFiles)
      {
        string path = CurrentSettings.KotorLocation(KotorVersionIndex) + "\\override\\baseitems.2da";
        try
        {
          if (File.Exists(path))
          {
            FileStream fileStream = new FileStream(path, FileMode.Open);
            numArray = new byte[checked ((int) fileStream.Length + 1)];
            fileStream.Read(numArray, 0, checked ((int) fileStream.Length));
            fileStream.Close();
            flag1 = false;
            Console.WriteLine("Read baseitems.2da from override");
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Console.WriteLine("Could not load " + path + " in " + GetType().Name);
          ProjectData.ClearProjectError();
        }
      }
      if (flag1)
      {
        int resIdForResRef = chitinKey.FindResIdForResRef("baseitems", 2017);
        numArray = BIFFArchive.GetBIFFResource(CurrentSettings.KotorLocation(KotorVersionIndex) + "\\" + chitinKey.BiffList[resIdForResRef >> 20].Filename, resIdForResRef).Data;
        Console.WriteLine("Read baseitems.2da from 2da.bif");
      }
      ArrayList namesAndTypesList = new ClsBaseItems2Da(numArray).GetItemNamesAndTypesList(g_clsDialogTlk);
      int num1 = -1;
      try
      {
        foreach (TreeBaseItem treeBaseItem in namesAndTypesList)
        {
          if (StringType.StrCmp(treeBaseItem._itemtype, "****", false) != 0)
          {
            int int32 = Convert.ToInt32(treeBaseItem._itemtype);
            if (int32 > num1)
              num1 = int32;
          }
        }
      }
      finally
      {
        
      }
      int num2 = checked (num1 + 1);
      TreeView.BeginUpdate();
      TreeView.Nodes.Clear();
      int num3 = num2;
      int num4 = 0;
      while (num4 <= num3)
      {
        TreeView.Nodes.Add(StringType.FromInteger(num4));
        checked { ++num4; }
      }
      try
      {
        foreach (TreeBaseItem treeBaseItem in namesAndTypesList)
        {
          if (Information.IsNumeric(treeBaseItem._itemtype))
            TreeView.Nodes[IntegerType.FromString(treeBaseItem._itemtype)].Nodes.Add(new TreeNode(treeBaseItem._name)
            {
              Tag = "BI=" + StringType.FromInteger(treeBaseItem._index) + "|ES=" + treeBaseItem._slots
            });
          else if (treeBaseItem._name.StartsWith("Creature"))
            TreeView.Nodes[num2].Nodes.Add(new TreeNode(treeBaseItem._name)
            {
              Tag = "BI=" + StringType.FromInteger(treeBaseItem._index) + "|ES=" + treeBaseItem._slots
            });
        }
      }
      finally
      {
       
      }
      ArrayList keysforResourceType = chitinKey.GetKeysForResourceType(FrmMain.GetIdForRsrcType("uti"));
      FrmProgressMeter childForm = new FrmProgressMeter();
      childForm.StepAmount = 1;
      childForm.Maxvalue = keysforResourceType.Count;
      childForm.Message = "Getting Inventory from Warehouse";
      ((Control) childForm).Location = new utilWindowRelativePositioner(this, childForm).GetConcentric();
      childForm.Show();
      try
      {
        foreach (KeyEntry keyEntry in keysforResourceType)
        {
          // TODO: figure out how the chitin key can be iterated on the entire resource list
          ClsGff clsGff = new ClsGff(biffArchive.GetBiffResource(checked (keyEntry.ResId - keyEntry.ResId >> 20 << 20)).Data, KotorVersionIndex);
          GFFExoLocString nodeValue = (GFFExoLocString) clsGff.GetNodeValue("LocalizedName");
          string str = nodeValue.StringRef != -1 ? g_clsDialogTlk.GetString(nodeValue.StringRef) : "(no name)";
          childForm.Status = str;
          childForm.StepUp();
          TreeNode node1 = new TreeNode(str);
          node1.Tag = RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("TemplateResRef"));
          ResRef2NameLookupList.Add(new InventoryItem(str, StringType.FromObject(node1.Tag)));
          int num5 = IntegerType.FromObject(clsGff.GetNodeValue("BaseItem"));
          bool flag2 = false;
          int num6 = num2;
          int index = 0;
          while (index <= num6)
          {
            try
            {
              foreach (TreeNode node2 in TreeView.Nodes[index].Nodes)
              {
                string[] strArray2 = Strings.Split(StringType.FromObject(node2.Tag), "|");
                if (StringType.StrCmp(strArray2[0], "BI=" + StringType.FromInteger(num5), false) == 0)
                {
                  TreeNode treeNode = node1;
                  treeNode.Tag = ObjectType.StrCatObj(treeNode.Tag, "|" + strArray2[1]);
                  node2.Nodes.Add(node1);
                  flag2 = true;
                  break;
                }
              }
            }
            finally
            {
             
            }
            if (!flag2)
              checked { ++index; }
            else
              break;
          }
        }
      }
      finally
      {
      
      }
      childForm.Close();
      fsin.Close();
      AssignTreeParentTitles();
      if (KotorVersionIndex == 0)
        RemoveGoofyCreatureItems();
      RemoveEmptyTreeParents(num2);
      TreeView.EndUpdate();
    }

  public void RemoveEmptyTreeParents(int Limit)
  {
      int index = Limit;
      while (index >= 0)
      {
        if (TreeView.Nodes[index].Nodes.Count == 0)
          TreeView.Nodes.RemoveAt(index);
        checked { index += -1; }
      }
    }

  private void RemoveGoofyCreatureItems()
  {
      try
      {
        foreach (TreeNode node1 in TreeView.Nodes[48].Nodes)
        {
          try
          {
            foreach (TreeNode node2 in node1.Nodes)
            {
              if (node2.Tag.ToString().StartsWith("w_null"))
                node1.Nodes.Remove(node2);
              else if (node2.Tag.ToString().StartsWith("w_lghtsbr001"))
                node1.Nodes.Remove(node2);
              else if (node2.Tag.ToString().StartsWith("w_blhvy001"))
                node1.Nodes.Remove(node2);
            }
          }
          finally
          {
          
          }
        }
      }
      finally
      {
       
      }
    }

  private void AssignTreeParentTitles()
  {
      TreeView.Nodes[0].Text = "Handheld Weapons 1";
      TreeView.Nodes[1].Text = "Handheld Weapons 2";
      TreeView.Nodes[2].Text = "Handheld Weapons 3";
      TreeView.Nodes[3].Text = "Blasters";
      TreeView.Nodes[4].Text = "Rifles";
      TreeView.Nodes[5].Text = "Rep. Blasters";
      TreeView.Nodes[6].Text = "Grenades";
      TreeView.Nodes[12].Text = "Droid Utility";
      TreeView.Nodes[13].Text = "Droid Shields";
      TreeView.Nodes[14].Text = "Droid Spike";
      TreeView.Nodes[15].Text = "Droid Plating";
      TreeView.Nodes[16].Text = "Droid Sensors";
      TreeView.Nodes[18].Text = "Masks";
      TreeView.Nodes[19].Text = "Gauntlets";
      TreeView.Nodes[20].Text = "Forearm Bands";
      TreeView.Nodes[21].Text = "Belts";
      TreeView.Nodes[22].Text = "Implants";
      TreeView.Nodes[23].Text = "Credits";
      TreeView.Nodes[24].Text = "Datapads";
      TreeView.Nodes[25].Text = "Stims";
      TreeView.Nodes[26].Text = "Droid Repair";
      TreeView.Nodes[27].Text = "Spikes";
      TreeView.Nodes[28].Text = "Mines";
      TreeView.Nodes[29].Text = "Lighting Devices";
      TreeView.Nodes[30].Text = "Plot Items";
      TreeView.Nodes[31].Text = "Armor Type 1";
      TreeView.Nodes[32].Text = "Armor Type 2";
      TreeView.Nodes[33].Text = "Armor Type 3";
      TreeView.Nodes[34].Text = "Armor Type 4";
      TreeView.Nodes[35].Text = "Armor Type 5";
      TreeView.Nodes[36].Text = "Armor Type 6";
      TreeView.Nodes[37].Text = "Clothing/Disguises";
      TreeView.Nodes[38].Text = "Robes";
      TreeView.Nodes[39].Text = "Double-Bladed Light Sabers";
      TreeView.Nodes[40].Text = "Short Light Sabers";
      TreeView.Nodes[41].Text = "Light Sabers";
      TreeView.Nodes[42].Text = "Pazaak Decks";
      TreeView.Nodes[43].Text = "Pazaak Side Decks";
      TreeView.Nodes[44].Text = "Stealth Items";
      TreeView.Nodes[45].Text = "Medical";
      TreeView.Nodes[46].Text = "Light Saber Crystals";
      TreeView.Nodes[47].Text = "Super Stim Item";
      if (KotorVersionIndex == 0)
      {
        TreeView.Nodes[48].Text = "Creature Item";
      }
      else
      {
        if (KotorVersionIndex != 1)
          return;
        TreeView.Nodes[48].Text = "Wrist Items";
        TreeView.Nodes[49].Text = "Rockets";
        TreeView.Nodes[50].Text = "Chemicals";
        TreeView.Nodes[51].Text = "Components";
        TreeView.Nodes[52].Text = "Creature Item";
      }
    }

  public void SetEquippedPanelsToolTips()
  {
      ToolTip1.SetToolTip(pnlArmor, "(empty)");
      ToolTip1.SetToolTip(pnlBelt, "(empty)");
      ToolTip1.SetToolTip(pnlHands, "(empty)");
      ToolTip1.SetToolTip(pnlHead, "(empty)");
      ToolTip1.SetToolTip(pnlImplant, "(empty)");
      ToolTip1.SetToolTip(pnlLArm, "(empty)");
      ToolTip1.SetToolTip(pnlLWeapon, "(empty)");
      ToolTip1.SetToolTip(pnlRArm, "(empty)");
      ToolTip1.SetToolTip(pnlRWeapon, "(empty)");
      ToolTip1.SetToolTip(pnlCreatureHide, "(empty)");
      ToolTip1.SetToolTip(pnlCreatureItem1, "(empty)");
      ToolTip1.SetToolTip(pnlCreatureItem2, "(empty)");
      ToolTip1.SetToolTip(pnlCreatureItem3, "(empty)");
    }

  private void HidePanelIndicators()
  {
      pnlArmorBkgnd.Visible = false;
      pnlBeltBkgnd.Visible = false;
      pnlHandsBkgnd.Visible = false;
      pnlHeadBkgnd.Visible = false;
      pnlImplantBkgnd.Visible = false;
      pnlLArmBkgnd.Visible = false;
      pnlLWeaponBkgnd.Visible = false;
      pnlRArmBkgnd.Visible = false;
      pnlRWeaponBkgnd.Visible = false;
      pnlCreatureHideBkgnd.Visible = false;
      pnlCreatureItem1Bkgnd.Visible = false;
      pnlCreatureItem2Bkgnd.Visible = false;
      pnlCreatureItem3Bkgnd.Visible = false;
    }

  private void ManageEqInventory(string iteminfo, InventoryPanel sender, bool Dropable)
  {
      string[] strArray = Strings.Split(iteminfo, "|");
      ToolTip1.SetToolTip(sender, strArray[0] + " (" + strArray[1] + ")");
      sender.Tag = strArray[1];
      sender.Dropable = Dropable;
      sender.IsEmpty = false;
      try
      {
        foreach (Control control in TabPage1.Controls)
        {
          if (StringType.StrCmp(control.Name, sender.Name + "Bkgnd", false) == 0)
          {
            control.Visible = true;
            return;
          }
        }
      }
      finally
      {
       
      }
      try
      {
        foreach (Control control in TabPage2.Controls)
        {
          if (StringType.StrCmp(control.Name, sender.Name + "Bkgnd", false) == 0)
          {
            control.Visible = true;
            break;
          }
        }
      }
      finally
      {
       
      }
    }

  public void PositionWindow()
  {
      Point point1 = FrmMain.CurrentSettings.InventoryEditorWindowLoc;
      if (!point1.IsEmpty)
        ((Control) this).Location = FrmMain.CurrentSettings.InventoryEditorWindowLoc;
      if (FrmMain.CurrentSettings.InventoryEditorWindowSize.IsEmpty)
        return;
      Size size1 = FrmMain.CurrentSettings.InventoryEditorWindowSize;
      Rectangle workingArea;
      int height1 = 0;
      if (size1.Height > Screen.PrimaryScreen.WorkingArea.Height)
      {
        Point point2 = default;
        ref Point local1 = ref point2;
        point1 = ((Control) this).Location;
        int x = point1.X;
        int top = Screen.PrimaryScreen.WorkingArea.Top;
        local1 = new Point(x, top);
        ((Control) this).Location = point2;
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
      int width1 = FrmMain.CurrentSettings.InventoryEditorWindowSize.Width;
      workingArea = Screen.PrimaryScreen.WorkingArea;
      int width2 = workingArea.Width;
      int width3 = 0;
      if (width1 > width2)
      {
        point1 = new Point(Screen.PrimaryScreen.WorkingArea.Left, ((Control) this).Location.Y);
        ((Control) this).Location = point1;
        workingArea = Screen.PrimaryScreen.WorkingArea;
        width3 = workingArea.Width;
        size1 = new Size(width3, Size.Height);
        Size = size1;
      }
      if (!(width3 == 0 & height1 == 0))
        return;
      Size = FrmMain.CurrentSettings.InventoryEditorWindowSize;
    }

  public void SaveSettings()
  {
      FrmMain.CurrentSettings.InventoryEditorWindowLoc = ((Control) this).Location;
      FrmMain.CurrentSettings.InventoryEditorWindowSize = Size;
    }

  public void AutoSizeColumns()
  {
      int num1 = checked (dt.Columns.Count - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        dgPackItems.TableStyles[0].GridColumnStyles[num2].Width = GetColWidth(num2, dt.Columns[num2].Caption);
        checked { ++num2; }
      }
    }

  protected int GetColWidth(int col, string DisplayName)
  {
      int count = ((DataView) dgPackItems.DataSource).Count;
      Graphics graphics = Graphics.FromHwnd(Handle);
      StringFormat format = new StringFormat(StringFormat.GenericTypographic);
      float num1 = graphics.MeasureString(DisplayName, dgPackItems.Font, 500, format).Width;
      try
      {
        int num2 = checked (count - 1);
        int rowIndex = 0;
        while (rowIndex <= num2)
        {
          SizeF sizeF = graphics.MeasureString(dgPackItems[rowIndex, col].ToString(), dgPackItems.Font, 500, format);
          if (sizeF.Width > (double) num1)
            num1 = sizeF.Width;
          checked { ++rowIndex; }
        }
        graphics.Dispose();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        num1 = 75f;
        ProjectData.ClearProjectError();
      }
      return checked ((int) Math.Round(num1 + 10f));
    }

  private void InsertToGridOrIncrement(string Name, string ResRef, int Qty = 1, bool Dropable = true)
  {
      int num = checked (dt.Rows.Count - 1);
      int rowIndex1 = 0;
      while (rowIndex1 <= num)
      {
        if (ObjectType.ObjTst(this.dgPackItems[rowIndex1, 1], ResRef, false) == 0)
        {
          DataGrid dgPackItems = this.dgPackItems;
          DataGrid dataGrid = dgPackItems;
          int rowIndex2 = rowIndex1;
          int rowIndex3 = rowIndex2;
          int columnIndex1 = 2;
          int columnIndex2 = columnIndex1;
          object obj = ObjectType.AddObj(dgPackItems[rowIndex2, columnIndex1], Qty);
          dataGrid[rowIndex3, columnIndex2] = obj;
          if (!Dropable)
            return;
          this.dgPackItems[rowIndex1, 3] = true;
          return;
        }
        checked { ++rowIndex1; }
      }
      DataRow row = dt.NewRow();
      row[0] = Name;
      row[1] = ResRef;
      row[2] = Qty;
      row[3] = Dropable;
      dt.Rows.Add(row);
      AutoSizeColumns();
    }

  private string FindNameForResRef(string ResRef)
  {
      string name = null;
      try
      {
        foreach (InventoryItem resRef2NameLookup in ResRef2NameLookupList)
        {
          if (StringType.StrCmp(resRef2NameLookup._ResRef, ResRef, false) == 0)
          {
            name = resRef2NameLookup._Name;
            break;
          }
        }
      }
      finally
      {
       
      }
      return name;
    }

  public void AddPackItem(string ResRef, bool Dropable) => InsertToGridOrIncrement(FindNameForResRef(ResRef), ResRef, Dropable: Dropable);

  public void AddEquippedItem(string ResRef, int Slot, bool Dropable)
  {
      string iteminfo = FindNameForResRef(ResRef) + "|" + ResRef;
      switch (Slot)
      {
        case 1:
          ManageEqInventory(iteminfo, pnlHead, Dropable);
          break;
        case 2:
          ManageEqInventory(iteminfo, pnlArmor, Dropable);
          break;
        case 8:
          ManageEqInventory(iteminfo, pnlHands, Dropable);
          break;
        case 16:
          ManageEqInventory(iteminfo, pnlRWeapon, Dropable);
          break;
        case 32:
          ManageEqInventory(iteminfo, pnlLWeapon, Dropable);
          break;
        case 128:
          ManageEqInventory(iteminfo, pnlRArm, Dropable);
          break;
        case 256:
          ManageEqInventory(iteminfo, pnlLArm, Dropable);
          break;
        case 512:
          ManageEqInventory(iteminfo, pnlImplant, Dropable);
          break;
        case 1024:
          ManageEqInventory(iteminfo, pnlBelt, Dropable);
          break;
        case 16384:
          ManageEqInventory(iteminfo, pnlCreatureItem1, Dropable);
          break;
        case 32768:
          ManageEqInventory(iteminfo, pnlCreatureItem2, Dropable);
          break;
        case 65536:
          ManageEqInventory(iteminfo, pnlCreatureItem3, Dropable);
          break;
        case 131072:
          ManageEqInventory(iteminfo, pnlCreatureHide, Dropable);
          break;
      }
    }

  public ArrayList GetPackItemsList()
  {
      ArrayList packItemsList = new ArrayList();
      int num = checked (dt.Rows.Count - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        packItemsList.Add(new InventoryItem("", StringType.FromObject(dgPackItems[rowIndex, 1]), Quantity: IntegerType.FromObject(dgPackItems[rowIndex, 2]), Dropable: BooleanType.FromObject(dgPackItems[rowIndex, 3])));
        checked { ++rowIndex; }
      }
      return packItemsList;
    }

  public ArrayList GetEquippedItemsList() => new ArrayList()
  {
    new InventoryItem("", StringType.FromObject(pnlHead.Tag), StringType.FromInteger(1), Dropable: pnlHead.Dropable),
    new InventoryItem("", StringType.FromObject(pnlArmor.Tag), StringType.FromInteger(2), Dropable: pnlArmor.Dropable),
    new InventoryItem("", StringType.FromObject(pnlHands.Tag), StringType.FromInteger(8), Dropable: pnlHands.Dropable),
    new InventoryItem("", StringType.FromObject(pnlRWeapon.Tag), StringType.FromInteger(16), Dropable: pnlRWeapon.Dropable),
    new InventoryItem("", StringType.FromObject(pnlLWeapon.Tag), StringType.FromInteger(32), Dropable: pnlLWeapon.Dropable),
    new InventoryItem("", StringType.FromObject(pnlRArm.Tag), StringType.FromInteger(128), Dropable: pnlRArm.Dropable),
    new InventoryItem("", StringType.FromObject(pnlLArm.Tag), StringType.FromInteger(256), Dropable: pnlLArm.Dropable),
    new InventoryItem("", StringType.FromObject(pnlImplant.Tag), StringType.FromInteger(512), Dropable: pnlImplant.Dropable),
    new InventoryItem("", StringType.FromObject(pnlBelt.Tag), StringType.FromInteger(1024), Dropable: pnlBelt.Dropable),
    new InventoryItem("", StringType.FromObject(pnlCreatureItem1.Tag), StringType.FromInteger(16384), Dropable: pnlCreatureItem1.Dropable),
    new InventoryItem("", StringType.FromObject(pnlCreatureItem2.Tag), StringType.FromInteger(32768), Dropable: pnlCreatureItem2.Dropable),
    new InventoryItem("", StringType.FromObject(pnlCreatureItem3.Tag), StringType.FromInteger(65536), Dropable: pnlCreatureItem3.Dropable),
    new InventoryItem("", StringType.FromObject(pnlCreatureHide.Tag), StringType.FromInteger(131072), Dropable: pnlCreatureHide.Dropable)
  };

  public void SetFormName(string Name)
  {
      Text = "Inventory Editor - Kotor ";
      if (KotorVersionIndex == 0)
        Text += "I";
      else
        Text += "II";
      Text = Text + " - " + Name;
    }

  private void AskForNewCustomResRef(InventoryPanel panel)
  {
      frmPromptForString frmPromptForString = new frmPromptForString();
      frmPromptForString.Text = "Set custom item ResRef";
      frmPromptForString.lblMsg.Text = "Enter custom item ResRef:";
      frmPromptForString.tbValue.CharacterCasing = CharacterCasing.Lower;
      if (frmPromptForString.ShowDialog(this) != DialogResult.OK)
        return;
      ToolTip1.SetToolTip(panel, "Custom Item (" + Strings.Trim(frmPromptForString.tbValue.Text) + ")");
      panel.Tag = frmPromptForString.tbValue.Text;
      panel.IsEmpty = false;
      try
      {
        foreach (Control control in TabPage1.Controls)
        {
          if (StringType.StrCmp(control.Name, panel.Name + "Bkgnd", false) == 0)
          {
            control.Visible = true;
            break;
          }
        }
      }
      finally
      {
        
      }
    }

  private void pnlEquipped_DoubleClick(object sender, EventArgs e) => AskForNewCustomResRef((InventoryPanel) sender);

  private void pnl_MouseDown(object sender, MouseEventArgs e)
  {
      InventoryPanel inventoryPanel = (InventoryPanel) sender;
      if (MouseButtons == MouseButtons.Right)
      {
        if (inventoryPanel.IsEmpty)
          return;
        cmiDropable.Checked = ((InventoryPanel) sender).Dropable;
        cmEquippedItems.Show((Control) sender, (Point) (LateBinding.LateGet(sender, null, "PointToClient", new object[1]
        {
          MousePosition
        }, null, null) ?? Activator.CreateInstance(typeof (Point))));
      }
      else
        HandlePanelMouseDown((Panel) sender);
    }

  private void HandlePanelMouseDown(Panel sender)
  {
      long ticks = DateAndTime.Now.Ticks;
      if (ObjectType.ObjTst(checked (ticks - MouseDownTime), MouseDoubleClickTime, false) < 0)
        AskForNewCustomResRef((InventoryPanel) sender);
      else if (ObjectType.ObjTst(sender.Tag, "", false) != 0)
      {
        int num = (int) DoDragDrop(sender, DragDropEffects.Copy | DragDropEffects.Move);
      }
      MouseDownTime = ticks;
    }

  private void dgPackItems_CurrentCellChanged(object sender, EventArgs e)
  {
      try
      {
        foreach (DataRow row in (InternalDataCollectionBase) dt.Rows)
        {
          row.EndEdit();
          bool flag1 = false;
          bool flag2 = false;
          bool flag3 = false;
          if (row[1] == DBNull.Value)
            flag1 = true;
          if (row[2] == DBNull.Value)
            flag2 = true;
          if (ObjectType.ObjTst(row[2], 1, false) < 0)
            flag3 = true;
          row.ClearErrors();
          if (flag1)
            row.SetColumnError(1, "You must enter a ResRef for this item");
          if (flag2)
            row.SetColumnError(2, "You must enter a Quantity for this item");
          if (flag3)
            row.SetColumnError(2, "You must enter a Quantity >=1 for this item");
        }
      }
      finally
      {
      
      }
    }

  private void cmiDropable_Click(object sender, EventArgs e)
  {
      InventoryPanel inventoryPanel = (InventoryPanel) LateBinding.LateGet(LateBinding.LateGet(sender, null, "parent", new object[0], null, null), null, "sourcecontrol", new object[0], null, null);
      inventoryPanel.Dropable = !inventoryPanel.Dropable;
    }

  private void btnExpandAll_Click(object sender, EventArgs e)
  {
      TreeView.ExpandAll();
      TreeView.SelectedNode = TreeView.Nodes[0];
    }

  private void btnCollapseAll_Click(object sender, EventArgs e) => TreeView.CollapseAll();
}