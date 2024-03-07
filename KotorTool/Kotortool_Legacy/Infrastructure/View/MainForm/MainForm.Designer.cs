using System.ComponentModel;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Kotortool_Legacy.Infrastructure.View.MainForm
{
    partial class MainForm
    {
        
         [AccessedThroughProperty("miAbout")]
    private ToolStripMenuItem _miAbout;
    /*[AccessedThroughProperty("MainMenu1")]
    private MainMenu _mainMenu1;*/
    [AccessedThroughProperty("btnExtractForModuleEditing")]
    private Button _btnExtractForModuleEditing;
    [AccessedThroughProperty("ToolStripMenuItem1")]
    private ToolStripMenuItem _ToolStripMenuItem1;
    [AccessedThroughProperty("btnCreateMapInfoBFD")]
    private Button _btnCreateMapInfoBfd;
    [AccessedThroughProperty("miOpenSSFEditor")]
    private ToolStripMenuItem _miOpenSsfEditor;
    [AccessedThroughProperty("ToolStripMenuItem10")]
    private ToolStripMenuItem _ToolStripMenuItem10;
    [AccessedThroughProperty("miOpenKey")]
    private ToolStripMenuItem _miOpenKey;
    [AccessedThroughProperty("btnExtract")]
    private Button _btnExtract;
    [AccessedThroughProperty("miOpenModuleEditor")]
    private ToolStripMenuItem _miOpenModuleEditor;
    [AccessedThroughProperty("ToolStripMenuItem3")]
    private ToolStripMenuItem _ToolStripMenuItem3;
    [AccessedThroughProperty("ToolStripMenuItem6")]
    private ToolStripMenuItem _ToolStripMenuItem6;
    [AccessedThroughProperty("ToolStripMenuItem4")]
    private ToolStripMenuItem _ToolStripMenuItem4;
    [AccessedThroughProperty("miOpenMapsFolder")]
    private ToolStripMenuItem _miOpenMapsFolder;
    [AccessedThroughProperty("miExtract")]
    private ToolStripMenuItem _miExtract;
    [AccessedThroughProperty("miBasicHelp")]
    private ToolStripMenuItem _miBasicHelp;
    [AccessedThroughProperty("ToolStripMenuItem7")]
    private ToolStripMenuItem _ToolStripMenuItem7;
    [AccessedThroughProperty("miOpenRIM")]
    private ToolStripMenuItem _miOpenRim;
    [AccessedThroughProperty("miShowSupportedModEditorMaps")]
    private ToolStripMenuItem _miShowSupportedModEditorMaps;
    [AccessedThroughProperty("miOpenPWKEditor")]
    private ToolStripMenuItem _miOpenPwkEditor;
    [AccessedThroughProperty("ToolStripMenuItem2")]
    private ToolStripMenuItem _ToolStripMenuItem2;
    [AccessedThroughProperty("miOpenDialogTlkViewer")]
    private ToolStripMenuItem _miOpenDialogTlkViewer;
    [AccessedThroughProperty("Button4")]
    private Button _button4;
    [AccessedThroughProperty("miManagePaths")]
    private ToolStripMenuItem _miManagePaths;
    [AccessedThroughProperty("Button1")]
    private Button _button1;
    [AccessedThroughProperty("btnHexViewer")]
    private Button _btnHexViewer;
    [AccessedThroughProperty("ToolStripMenuItem8")]
    private ToolStripMenuItem _ToolStripMenuItem8;
    [AccessedThroughProperty("miOpenWorkingDir")]
    private ToolStripMenuItem _miOpenWorkingDir;
    [AccessedThroughProperty("miOptions")]
    private ToolStripMenuItem _miOptions;
    [AccessedThroughProperty("miGlobalVariableEditor")]
    private ToolStripMenuItem _miGlobalVariableEditor;
    [AccessedThroughProperty("miOpen2DAEditor")]
    private ToolStripMenuItem _miOpen2DaEditor;
    [AccessedThroughProperty("miCheckForUpdates")]
    private ToolStripMenuItem _miCheckForUpdates;
    [AccessedThroughProperty("miOpenProjectManager")]
    private ToolStripMenuItem _miOpenProjectManager;
    [AccessedThroughProperty("miRecentFiles")]
    private ToolStripMenuItem _miRecentFiles;
    [AccessedThroughProperty("miFile")]
    private ToolStripMenuItem _miFile;
    [AccessedThroughProperty("cmiExtractForModuleEditing")]
    private ToolStripMenuItem _cmiExtractForModuleEditing;
    [AccessedThroughProperty("ToolStripMenuItem5")]
    private ToolStripMenuItem _ToolStripMenuItem5;
    [AccessedThroughProperty("miRefSearch")]
    private ToolStripMenuItem _miRefSearch;
    [AccessedThroughProperty("miOpenTextEditor")]
    private ToolStripMenuItem _miOpenTextEditor;
    [AccessedThroughProperty("imglstToolBar")]
    private ImageList _imglstToolBar;
    [AccessedThroughProperty("miCleanWorkingDir")]
    private ToolStripMenuItem _miCleanWorkingDir;
    [AccessedThroughProperty("miOpenGFFFile")]
    private ToolStripMenuItem _miOpenGffFile;
    /*[AccessedThroughProperty("tbbtnERFBuilder")]
    private ToolBarButton _tbbtnErfBuilder;*/
    [AccessedThroughProperty("TreeView")]
    private System.Windows.Forms.TreeView _treeView;
    /*[AccessedThroughProperty("tbbtnTextEditor")]
    private ToolBarButton _tbbtnTextEditor;*/
    [AccessedThroughProperty("miOpenERFBuilder")]
    private ToolStripMenuItem _miOpenErfBuilder;
    [AccessedThroughProperty("miViewGFFFiles")]
    private ToolStripMenuItem _miViewGffFiles;
    /*[AccessedThroughProperty("tbbtnConversationEditor")]
    private ToolBarButton _tbbtnConversationEditor;*/
    [AccessedThroughProperty("miQuit")]
    private ToolStripMenuItem _miQuit;
    /*[AccessedThroughProperty("tbbtn2DAEditor")]
    private ToolBarButton _tbbtn2DaEditor;*/
    [AccessedThroughProperty("miRegisterSoftware")]
    private ToolStripMenuItem _miRegisterSoftware;
    /*[AccessedThroughProperty("ToolBar1")]
    private ToolBar _toolBar1;*/
    [AccessedThroughProperty("miConversationEditor")]
    private ToolStripMenuItem _miConversationEditor;
    /*[AccessedThroughProperty("tvCMenu")]
    private ContextMenu _tvCMenu;*/
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            var resourceManager = new ResourceManager(typeof (FrmMain));
      TreeView = new System.Windows.Forms.TreeView();
      BtnHexViewer = new Button();
      BtnExtract = new Button();
      //MainMenu1 = new MainMenu();
      MiFile = new ToolStripMenuItem();
      MiManagePaths = new ToolStripMenuItem();
      MiOpenGffFile = new ToolStripMenuItem();
      MiViewGffFiles = new ToolStripMenuItem();
      MiOpenKey = new ToolStripMenuItem();
      MiOpenRim = new ToolStripMenuItem();
      ToolStripMenuItem5 = new ToolStripMenuItem();
      MiRecentFiles = new ToolStripMenuItem();
      ToolStripMenuItem6 = new ToolStripMenuItem();
      MiQuit = new ToolStripMenuItem();
      ToolStripMenuItem3 = new ToolStripMenuItem();
      MiExtract = new ToolStripMenuItem();
      MiOpenProjectManager = new ToolStripMenuItem();
      MiOpen2DaEditor = new ToolStripMenuItem();
      MiConversationEditor = new ToolStripMenuItem();
      MiOpenModuleEditor = new ToolStripMenuItem();
      MiOpenDialogTlkViewer = new ToolStripMenuItem();
      MiGlobalVariableEditor = new ToolStripMenuItem();
      MiOpenTextEditor = new ToolStripMenuItem();
      MiOpenPwkEditor = new ToolStripMenuItem();
      MiOpenSsfEditor = new ToolStripMenuItem();
      MiOpenErfBuilder = new ToolStripMenuItem();
      ToolStripMenuItem10 = new ToolStripMenuItem();
      MiRefSearch = new ToolStripMenuItem();
      ToolStripMenuItem4 = new ToolStripMenuItem();
      MiCleanWorkingDir = new ToolStripMenuItem();
      ToolStripMenuItem1 = new ToolStripMenuItem();
      MiOpenWorkingDir = new ToolStripMenuItem();
      ToolStripMenuItem8 = new ToolStripMenuItem();
      MiShowSupportedModEditorMaps = new ToolStripMenuItem();
      MiOpenMapsFolder = new ToolStripMenuItem();
      ToolStripMenuItem7 = new ToolStripMenuItem();
      MiOptions = new ToolStripMenuItem();
      ToolStripMenuItem2 = new ToolStripMenuItem();
      MiBasicHelp = new ToolStripMenuItem();
      MiCheckForUpdates = new ToolStripMenuItem();
      MiRegisterSoftware = new ToolStripMenuItem();
      MiAbout = new ToolStripMenuItem();
      /*TvCMenu = new ContextMenu();*/
      CmiExtractForModuleEditing = new ToolStripMenuItem();
      /*ToolBar1 = new ToolBar();
      Tbbtn2DaEditor = new ToolBarButton();
      TbbtnConversationEditor = new ToolBarButton();
      TbbtnTextEditor = new ToolBarButton();
      TbbtnErfBuilder = new ToolBarButton();*/
      this.ImglstToolBar = new ImageList(components);
      BtnExtractForModuleEditing = new Button();
      Button4 = new Button();
      BtnCreateMapInfoBfd = new Button();
      Button1 = new Button();
      SuspendLayout();
      TreeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TreeView.ImageIndex = -1;
      var treeView1 = TreeView;
      var point1 = new Point(16, 40);
      var point2 = point1;
      treeView1.Location = point2;
      TreeView.Name = "TreeView";
      TreeView.SelectedImageIndex = -1;
      var treeView2 = TreeView;
      var size1 = new Size(160, 400);
      var size2 = size1;
      treeView2.Size = size2;
      TreeView.TabIndex = 1;
      BtnHexViewer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnHexViewer.BackColor = SystemColors.Control;
      BtnHexViewer.Enabled = false;
      var btnHexViewer1 = BtnHexViewer;
      point1 = new Point(200, 176);
      var point3 = point1;
      btnHexViewer1.Location = point3;
      BtnHexViewer.Name = "btnHexViewer";
      var btnHexViewer2 = BtnHexViewer;
      size1 = new Size(88, 23);
      var size3 = size1;
      btnHexViewer2.Size = size3;
      BtnHexViewer.TabIndex = 0;
      BtnHexViewer.Text = "Hex Viewer";
      BtnExtract.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnExtract.BackColor = SystemColors.Control;
      BtnExtract.Enabled = false;
      var btnExtract1 = BtnExtract;
      point1 = new Point(200, 48);
      var point4 = point1;
      btnExtract1.Location = point4;
      BtnExtract.Name = "btnExtract";
      var btnExtract2 = BtnExtract;
      size1 = new Size(88, 56);
      var size4 = size1;
      btnExtract2.Size = size4;
      BtnExtract.TabIndex = 1;
      BtnExtract.Text = "Extract";
      /*MainMenu1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[3]
      {
        MiFile,
        ToolStripMenuItem3,
        ToolStripMenuItem2
      });*/
      /*MiFile.Index = 0;
      MiFile.ToolStripMenuItems.AddRange(new ToolStripMenuItem[9]
      {
        MiManagePaths,
        MiOpenGffFile,
        MiViewGffFiles,
        MiOpenKey,
        MiOpenRim,
        ToolStripMenuItem5,
        MiRecentFiles,
        ToolStripMenuItem6,
        MiQuit
      });*/
      MiFile.Text = "&File";
     // MiManagePaths.Index = 0;
      MiManagePaths.Text = "&Manage Paths...";
      //MiOpenGffFile.Index = 1;
      //MiOpenGffFile.Shortcut = Shortcut.CtrlO;
      MiOpenGffFile.Text = "Open &GFF Files...";
      //MiViewGffFiles.Index = 2;
      MiViewGffFiles.Text = "&View GFF Files as Text...";
      //MiOpenKey.Index = 3;
      //MiOpenKey.Shortcut = Shortcut.CtrlO;
      MiOpenKey.Text = "&Open Key file...";
      MiOpenKey.Visible = false;
      //MiOpenRim.Index = 4;
      //MiOpenRim.Shortcut = Shortcut.CtrlR;
      MiOpenRim.Text = "Open RIM file...";
      MiOpenRim.Visible = false;
     // ToolStripMenuItem5.Index = 5;
      ToolStripMenuItem5.Text = "-";
      //MiRecentFiles.Index = 6;
      MiRecentFiles.Text = "Recent &Files";
     // ToolStripMenuItem6.Index = 7;
      ToolStripMenuItem6.Text = "-";
      //MiQuit.Index = 8;
      //MiQuit.Shortcut = Shortcut.CtrlQ;
      MiQuit.Text = "&Quit";
      /*ToolStripMenuItem3.Index = 1;
      ToolStripMenuItem3.ToolStripMenuItems.AddRange(new ToolStripMenuItem[22]
      {
        MiExtract,
        MiOpenProjectManager,
        MiOpen2DaEditor,
        MiConversationEditor,
        MiOpenModuleEditor,
        MiOpenDialogTlkViewer,
        MiGlobalVariableEditor,
        MiOpenTextEditor,
        MiOpenPwkEditor,
        MiOpenSsfEditor,
        MiOpenErfBuilder,
        ToolStripMenuItem10,
        MiRefSearch,
        ToolStripMenuItem4,
        MiCleanWorkingDir,
        ToolStripMenuItem1,
        MiOpenWorkingDir,
        ToolStripMenuItem8,
        MiShowSupportedModEditorMaps,
        MiOpenMapsFolder,
        ToolStripMenuItem7,
        MiOptions
      });*/
      ToolStripMenuItem3.Text = "&Tools";
      MiExtract.Enabled = false;
      //MiExtract.Index = 0;
      MiExtract.Text = "(nothing selected)";
      MiExtract.Visible = false;
     // MiOpenProjectManager.Index = 1;
     // MiOpenProjectManager.Shortcut = Shortcut.Ctrl1;
      MiOpenProjectManager.Text = "Open Project Manager";
     // MiOpen2DaEditor.Index = 2;
     // MiOpen2DaEditor.Shortcut = Shortcut.Ctrl2;
      MiOpen2DaEditor.Text = "Open &2DA file editor";
      //MiConversationEditor.Index = 3;
      //MiConversationEditor.Shortcut = Shortcut.Ctrl3;
      MiConversationEditor.Text = "Open &Conversation editor";
      //MiOpenModuleEditor.Index = 4;
      //MiOpenModuleEditor.Shortcut = Shortcut.F1;
      MiOpenModuleEditor.Text = "Open &Module editor";
     // MiOpenDialogTlkViewer.Index = 5;
      MiOpenDialogTlkViewer.Text = "Open &Dialog.Tlk editor";
      //MiGlobalVariableEditor.Index = 6;
      MiGlobalVariableEditor.Text = "Open &Global Variable editor";
     // MiOpenTextEditor.Index = 7;
      MiOpenTextEditor.Text = "Open &Text editor";
     // MiOpenPwkEditor.Index = 8;
      MiOpenPwkEditor.Text = "Open &PWK/DWK editor";
     // MiOpenSsfEditor.Index = 9;
      MiOpenSsfEditor.Text = "Open &SSF editor";
     // MiOpenErfBuilder.Index = 10;
      MiOpenErfBuilder.Text = "Open &ERF/MOD builder";
     // ToolStripMenuItem10.Index = 11;
      ToolStripMenuItem10.Text = "-";
     // MiRefSearch.Index = 12;
     // MiRefSearch.Shortcut = Shortcut.CtrlF;
      MiRefSearch.Text = "Search for text in BIFs/RIMs";
     // ToolStripMenuItem4.Index = 13;
      ToolStripMenuItem4.Text = "-";
     // MiCleanWorkingDir.Index = 14;
      MiCleanWorkingDir.Text = "Clean Working Directory";
     // ToolStripMenuItem1.Index = 15;
      ToolStripMenuItem1.Text = "-";
     // MiOpenWorkingDir.Index = 16;
      MiOpenWorkingDir.Text = "Open Working Directory";
     // ToolStripMenuItem8.Index = 17;
      ToolStripMenuItem8.Text = "-";
     // MiShowSupportedModEditorMaps.Index = 18;
      MiShowSupportedModEditorMaps.Text = "Show Maps supported by Module editor";
     // MiOpenMapsFolder.Index = 19;
      MiOpenMapsFolder.Text = "Explore Maps folder";
     // ToolStripMenuItem7.Index = 20;
      ToolStripMenuItem7.Text = "-";
     // MiOptions.Index = 21;
      MiOptions.Text = "&Options...";
     // ToolStripMenuItem2.Index = 2;
      /*ToolStripMenuItem2.ToolStripMenuItems.AddRange(new ToolStripMenuItem[4]
      {
        MiBasicHelp,
        MiCheckForUpdates,
        MiRegisterSoftware,
        MiAbout
      });*/
      ToolStripMenuItem2.Text = "&Help";
      //MiBasicHelp.Index = 0;
      MiBasicHelp.Text = "Basic &Instructions...";
     // MiCheckForUpdates.Index = 1;
      MiCheckForUpdates.Text = "Check for program updates";
      //MiRegisterSoftware.Index = 2;
      MiRegisterSoftware.Text = "&Register...";
      MiRegisterSoftware.Visible = false;
     // MiAbout.Index = 3;
      MiAbout.Text = "&About...";
      /*TvCMenu.ToolStripMenuItems.AddRange(new ToolStripMenuItem[1]
      {
        CmiExtractForModuleEditing
      });*/
      //CmiExtractForModuleEditing.Index = 0;
      CmiExtractForModuleEditing.Text = "Extract for Module editing...";
      /*ToolBar1.Buttons.AddRange(new ToolBarButton[4]
      {
        Tbbtn2DaEditor,
        TbbtnConversationEditor,
        TbbtnTextEditor,
        TbbtnErfBuilder
      });*/
      /*var toolBar11 = ToolBar1;
      size1 = new Size(20, 20);
      var size5 = size1;
      toolBar11.ButtonSize = size5;
      ToolBar1.DropDownArrows = true;
      ToolBar1.ImageList = this.ImglstToolBar;
      var toolBar12 = ToolBar1;
      point1 = new Point(0, 0);
      var point5 = point1;
      toolBar12.Location = point5;
      ToolBar1.Name = "ToolBar1";
      ToolBar1.ShowToolTips = true;
      var toolBar13 = ToolBar1;
      size1 = new Size(296, 32);
      var size6 = size1;
      toolBar13.Size = size6;
      ToolBar1.TabIndex = 4;
      Tbbtn2DaEditor.ImageIndex = 0;
      Tbbtn2DaEditor.ToolTipText = "Open the 2DA Editor";
      TbbtnConversationEditor.ImageIndex = 1;
      TbbtnConversationEditor.ToolTipText = "Open the Conversation Editor";
      TbbtnTextEditor.ImageIndex = 2;
      TbbtnTextEditor.ToolTipText = "Open the Text Editor";
      TbbtnErfBuilder.ImageIndex = 3;
      TbbtnErfBuilder.ToolTipText = "Open the ERF File Builder";*/
      var imglstToolBar = this.ImglstToolBar;
      size1 = new Size(20, 20);
      var size7 = size1;
      imglstToolBar.ImageSize = size7;
     // this.ImglstToolBar.ImageStream = (ImageListStreamer) resourceManager.GetObject("imglstToolBar.ImageStream");
      this.ImglstToolBar.TransparentColor = Color.Transparent;
      BtnExtractForModuleEditing.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnExtractForModuleEditing.BackColor = SystemColors.Control;
      BtnExtractForModuleEditing.Enabled = false;
      var forModuleEditing1 = BtnExtractForModuleEditing;
      point1 = new Point(200, 120);
      var point6 = point1;
      forModuleEditing1.Location = point6;
      BtnExtractForModuleEditing.Name = "btnExtractForModuleEditing";
      var forModuleEditing2 = BtnExtractForModuleEditing;
      size1 = new Size(88, 32);
      var size8 = size1;
      forModuleEditing2.Size = size8;
      BtnExtractForModuleEditing.TabIndex = 5;
      BtnExtractForModuleEditing.Text = "Extract for Module Editing";
      Button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      Button4.BackColor = SystemColors.Control;
      var button41 = Button4;
      point1 = new Point(192, 312);
      var point7 = point1;
      button41.Location = point7;
      Button4.Name = "Button4";
      var button42 = Button4;
      size1 = new Size(96, 24);
      var size9 = size1;
      button42.Size = size9;
      Button4.TabIndex = 5;
      Button4.Text = "Parse NWScript";
      Button4.Visible = false;
      BtnCreateMapInfoBfd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnCreateMapInfoBfd.BackColor = SystemColors.Control;
      var createMapInfoBfd1 = BtnCreateMapInfoBfd;
      point1 = new Point(192, 408);
      var point8 = point1;
      createMapInfoBfd1.Location = point8;
      BtnCreateMapInfoBfd.Name = "btnCreateMapInfoBFD";
      var createMapInfoBfd2 = BtnCreateMapInfoBfd;
      size1 = new Size(96, 23);
      var size10 = size1;
      createMapInfoBfd2.Size = size10;
      BtnCreateMapInfoBfd.TabIndex = 5;
      BtnCreateMapInfoBfd.Text = "Create MapInfo";
      BtnCreateMapInfoBfd.Visible = false;
      Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      Button1.BackColor = SystemColors.Control;
      var button11 = Button1;
      point1 = new Point(192, 352);
      var point9 = point1;
      button11.Location = point9;
      Button1.Name = "Button1";
      var button12 = Button1;
      size1 = new Size(96, 24);
      var size11 = size1;
      button12.Size = size11;
      Button1.TabIndex = 5;
      Button1.Text = "Test Getktsi";
      Button1.Visible = false;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      BackColor = SystemColors.Control;
      size1 = new Size(296, 465);
      ClientSize = size1;
      Controls.Add(Button4);
      Controls.Add(BtnExtractForModuleEditing);
      //Controls.Add(ToolBar1);
      Controls.Add(TreeView);
      Controls.Add(BtnHexViewer);
      Controls.Add(BtnExtract);
      Controls.Add(BtnCreateMapInfoBfd);
      Controls.Add(Button1);
      //Icon = (Icon) resourceManager.GetObject("$this.Icon");
      //Menu = MainMenu1;
      size1 = new Size(304, 352);
      MinimumSize = size1;
      Name = nameof (FrmMain);
      SizeGripStyle = SizeGripStyle.Show;
      Text = "Kotor Tool";
      ResumeLayout(false);
        }

         internal virtual System.Windows.Forms.TreeView TreeView
    {
      get => _treeView;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_treeView != null)
        {
          _treeView.KeyPress -= new KeyPressEventHandler(TreeView_KeyPress);
          _treeView.MouseDown -= new MouseEventHandler(TreeView_MouseDown);
          _treeView.KeyUp -= new KeyEventHandler(TreeView_KeyUp);
          _treeView.BeforeCollapse -= new TreeViewCancelEventHandler(TreeView_BeforeCollapse);
          _treeView.BeforeExpand -= new TreeViewCancelEventHandler(TreeView_BeforeExpand);
          _treeView.AfterSelect -= new TreeViewEventHandler(TreeView_AfterSelect);
          _treeView.DoubleClick -= new EventHandler(TreeView_DoubleClick);
        }
        _treeView = value;
        if (_treeView == null)
          return;
        _treeView.KeyPress += new KeyPressEventHandler(TreeView_KeyPress);
        _treeView.MouseDown += new MouseEventHandler(TreeView_MouseDown);
        _treeView.KeyUp += new KeyEventHandler(TreeView_KeyUp);
        _treeView.BeforeCollapse += new TreeViewCancelEventHandler(TreeView_BeforeCollapse);
        _treeView.BeforeExpand += new TreeViewCancelEventHandler(TreeView_BeforeExpand);
        _treeView.AfterSelect += new TreeViewEventHandler(TreeView_AfterSelect);
        _treeView.DoubleClick += new EventHandler(TreeView_DoubleClick);
      }
    }

    internal virtual Button BtnExtract
    {
      get => _btnExtract;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnExtract != null)
          _btnExtract.Click -= new EventHandler(btnExtract_Click);
        _btnExtract = value;
        if (_btnExtract == null)
          return;
        _btnExtract.Click += new EventHandler(btnExtract_Click);
      }
    }

    /*internal virtual MainMenu MainMenu1
    {
      get => _mainMenu1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_mainMenu1 == null)
          ;
        _mainMenu1 = value;
        if (_mainMenu1 == null)
          ;
      }
    }*/

    internal virtual ToolStripMenuItem ToolStripMenuItem2
    {
      get => _ToolStripMenuItem2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_ToolStripMenuItem2 == null)
          ;
        _ToolStripMenuItem2 = value;
        if (_ToolStripMenuItem2 == null)
          ;
      }
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem3
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_ToolStripMenuItem3 == null)
          ;
        _ToolStripMenuItem3 = value;
        if (_ToolStripMenuItem3 == null)
          ;
      }
      get => _ToolStripMenuItem3;
    }

    internal virtual ToolStripMenuItem MiAbout
    {
      get => _miAbout;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miAbout != null)
          _miAbout.Click -= new EventHandler(miAbout_Click);
        _miAbout = value;
        if (_miAbout == null)
          return;
        _miAbout.Click += new EventHandler(miAbout_Click);
      }
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem5
    {
      get => _ToolStripMenuItem5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_ToolStripMenuItem5 == null)
          ;
        _ToolStripMenuItem5 = value;
        if (_ToolStripMenuItem5 == null)
          ;
      }
    }

    internal virtual ToolStripMenuItem MiOpenKey
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenKey == null)
          ;
        _miOpenKey = value;
        if (_miOpenKey == null)
          ;
      }
      get => _miOpenKey;
    }

    internal virtual ToolStripMenuItem MiQuit
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
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

    internal virtual ToolStripMenuItem MiExtract
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miExtract == null)
          ;
        _miExtract = value;
        if (_miExtract == null)
          ;
      }
      get => _miExtract;
    }

    internal virtual ToolStripMenuItem MiBasicHelp
    {
      get => _miBasicHelp;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miBasicHelp != null)
          _miBasicHelp.Click -= new EventHandler(miBasicHelp_Click);
        _miBasicHelp = value;
        if (_miBasicHelp == null)
          return;
        _miBasicHelp.Click += new EventHandler(miBasicHelp_Click);
      }
    }

    internal virtual ToolStripMenuItem MiOpenRim
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenRim == null)
          ;
        _miOpenRim = value;
        if (_miOpenRim == null)
          ;
      }
      get => _miOpenRim;
    }

    internal virtual ToolStripMenuItem MiManagePaths
    {
      get => _miManagePaths;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miManagePaths != null)
          _miManagePaths.Click -= new EventHandler(miManagePaths_Click);
        _miManagePaths = value;
        if (_miManagePaths == null)
          return;
        _miManagePaths.Click += new EventHandler(miManagePaths_Click);
      }
    }

    internal virtual Button BtnHexViewer
    {
      get => _btnHexViewer;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnHexViewer != null)
          _btnHexViewer.Click -= new EventHandler(btnHexViewer_Click);
        _btnHexViewer = value;
        if (_btnHexViewer == null)
          return;
        _btnHexViewer.Click += new EventHandler(btnHexViewer_Click);
      }
    }

    internal virtual ToolStripMenuItem MiOptions
    {
      get => _miOptions;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOptions != null)
          _miOptions.Click -= new EventHandler(miOptions_Click);
        _miOptions = value;
        if (_miOptions == null)
          return;
        _miOptions.Click += new EventHandler(miOptions_Click);
      }
    }

    internal virtual ToolStripMenuItem MiOpen2DaEditor
    {
      get => _miOpen2DaEditor;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpen2DaEditor != null)
          _miOpen2DaEditor.Click -= new EventHandler(miOpen2DAFile_Click);
        _miOpen2DaEditor = value;
        if (_miOpen2DaEditor == null)
          return;
        _miOpen2DaEditor.Click += new EventHandler(miOpen2DAFile_Click);
      }
    }

    internal virtual ToolStripMenuItem MiOpenTextEditor
    {
      get => _miOpenTextEditor;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenTextEditor != null)
          _miOpenTextEditor.Click -= new EventHandler(miOpenTextEditor_Click);
        _miOpenTextEditor = value;
        if (_miOpenTextEditor == null)
          return;
        _miOpenTextEditor.Click += new EventHandler(miOpenTextEditor_Click);
      }
    }

    internal virtual ToolStripMenuItem MiOpenGffFile
    {
      get => _miOpenGffFile;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenGffFile != null)
          _miOpenGffFile.Click -= new EventHandler(miOpenGFFFile_Click);
        _miOpenGffFile = value;
        if (_miOpenGffFile == null)
          return;
        _miOpenGffFile.Click += new EventHandler(miOpenGFFFile_Click);
      }
    }

    internal virtual ToolStripMenuItem MiOpenErfBuilder
    {
      get => _miOpenErfBuilder;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenErfBuilder != null)
          _miOpenErfBuilder.Click -= new EventHandler(miOpenERFBuilder_Click);
        _miOpenErfBuilder = value;
        if (_miOpenErfBuilder == null)
          return;
        _miOpenErfBuilder.Click += new EventHandler(miOpenERFBuilder_Click);
      }
    }

    internal virtual ToolStripMenuItem MiViewGffFiles
    {
      get => _miViewGffFiles;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miViewGffFiles != null)
          _miViewGffFiles.Click -= new EventHandler(miViewGFFFile_Click);
        _miViewGffFiles = value;
        if (_miViewGffFiles == null)
          return;
        _miViewGffFiles.Click += new EventHandler(miViewGFFFile_Click);
      }
    }

    internal virtual ToolStripMenuItem MiRegisterSoftware
    {
      get => _miRegisterSoftware;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miRegisterSoftware == null)
          ;
        _miRegisterSoftware = value;
        if (_miRegisterSoftware == null)
          ;
      }
    }

    /*internal virtual ContextMenu TvCMenu
    {
      get => _tvCMenu;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tvCMenu == null)
          ;
        _tvCMenu = value;
        if (_tvCMenu == null)
          ;
      }
    }*/

    internal virtual ToolStripMenuItem CmiExtractForModuleEditing
    {
      get => _cmiExtractForModuleEditing;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_cmiExtractForModuleEditing != null)
          _cmiExtractForModuleEditing.Click -= new EventHandler(cmiExtractForModuleEditing_Click);
        _cmiExtractForModuleEditing = value;
        if (_cmiExtractForModuleEditing == null)
          return;
        _cmiExtractForModuleEditing.Click += new EventHandler(cmiExtractForModuleEditing_Click);
      }
    }

    internal virtual ToolStripMenuItem MiConversationEditor
    {
      get => _miConversationEditor;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miConversationEditor != null)
          _miConversationEditor.Click -= new EventHandler(miConversationEditor_Click);
        _miConversationEditor = value;
        if (_miConversationEditor == null)
          return;
        _miConversationEditor.Click += new EventHandler(miConversationEditor_Click);
      }
    }

    /*internal virtual ToolBar ToolBar1
    {
      get => _toolBar1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_toolBar1 != null)
          _toolBar1.ButtonClick -= new ToolBarButtonClickEventHandler(ToolBar1_ButtonClick);
        _toolBar1 = value;
        if (_toolBar1 == null)
          return;
        _toolBar1.ButtonClick += new ToolBarButtonClickEventHandler(ToolBar1_ButtonClick);
      }
    }*/

    /*internal virtual ToolBarButton Tbbtn2DaEditor
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbbtn2DaEditor == null)
          ;
        _tbbtn2DaEditor = value;
        if (_tbbtn2DaEditor == null)
          ;
      }
      get => _tbbtn2DaEditor;
    }*/

    /*internal virtual ToolBarButton TbbtnConversationEditor
    {
      get => _tbbtnConversationEditor;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbbtnConversationEditor == null)
          ;
        _tbbtnConversationEditor = value;
        if (_tbbtnConversationEditor == null)
          ;
      }
    }*/

    /*internal virtual ToolBarButton TbbtnTextEditor
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbbtnTextEditor == null)
          ;
        _tbbtnTextEditor = value;
        if (_tbbtnTextEditor == null)
          ;
      }
      get => _tbbtnTextEditor;
    }*/

    /*internal virtual ToolBarButton TbbtnErfBuilder
    {
      get => _tbbtnErfBuilder;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbbtnErfBuilder == null)
          ;
        _tbbtnErfBuilder = value;
        if (_tbbtnErfBuilder == null)
          ;
      }
    }*/

    internal virtual ToolStripMenuItem ToolStripMenuItem4
    {
      get => _ToolStripMenuItem4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_ToolStripMenuItem4 == null)
          ;
        _ToolStripMenuItem4 = value;
        if (_ToolStripMenuItem4 == null)
          ;
      }
    }

    internal virtual ToolStripMenuItem MiCleanWorkingDir
    {
      get => _miCleanWorkingDir;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miCleanWorkingDir != null)
          _miCleanWorkingDir.Click -= new EventHandler(miCleanWorkingDir_Click);
        _miCleanWorkingDir = value;
        if (_miCleanWorkingDir == null)
          return;
        _miCleanWorkingDir.Click += new EventHandler(miCleanWorkingDir_Click);
      }
    }

    internal virtual ImageList ImglstToolBar
    {
      get => _imglstToolBar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_imglstToolBar == null)
          ;
        _imglstToolBar = value;
        if (_imglstToolBar == null)
          ;
      }
    }

    internal virtual ToolStripMenuItem MiRefSearch
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miRefSearch != null)
          _miRefSearch.Click -= new EventHandler(miRefSearch_Click);
        _miRefSearch = value;
        if (_miRefSearch == null)
          return;
        _miRefSearch.Click += new EventHandler(miRefSearch_Click);
      }
      get => _miRefSearch;
    }

    internal virtual ToolStripMenuItem MiFile
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miFile == null)
          ;
        _miFile = value;
        if (_miFile == null)
          ;
      }
      get => _miFile;
    }

    internal virtual ToolStripMenuItem MiRecentFiles
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miRecentFiles == null)
          ;
        _miRecentFiles = value;
        if (_miRecentFiles == null)
          ;
      }
      get => _miRecentFiles;
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem6
    {
      get => _ToolStripMenuItem6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_ToolStripMenuItem6 == null)
          ;
        _ToolStripMenuItem6 = value;
        if (_ToolStripMenuItem6 == null)
          ;
      }
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_ToolStripMenuItem1 == null)
          ;
        _ToolStripMenuItem1 = value;
        if (_ToolStripMenuItem1 == null)
          ;
      }
      get => _ToolStripMenuItem1;
    }

    internal virtual ToolStripMenuItem MiOpenProjectManager
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenProjectManager != null)
          _miOpenProjectManager.Click -= new EventHandler(miOpenProjectManager_Click);
        _miOpenProjectManager = value;
        if (_miOpenProjectManager == null)
          return;
        _miOpenProjectManager.Click += new EventHandler(miOpenProjectManager_Click);
      }
      get => _miOpenProjectManager;
    }

    internal virtual ToolStripMenuItem MiCheckForUpdates
    {
      get => _miCheckForUpdates;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miCheckForUpdates != null)
          _miCheckForUpdates.Click -= new EventHandler(miCheckForUpdates_Click);
        _miCheckForUpdates = value;
        if (_miCheckForUpdates == null)
          return;
        _miCheckForUpdates.Click += new EventHandler(miCheckForUpdates_Click);
      }
    }

    internal virtual ToolStripMenuItem MiGlobalVariableEditor
    {
      get => _miGlobalVariableEditor;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miGlobalVariableEditor != null)
          _miGlobalVariableEditor.Click -= new EventHandler(miGlobalVariableEditor_Click);
        _miGlobalVariableEditor = value;
        if (_miGlobalVariableEditor == null)
          return;
        _miGlobalVariableEditor.Click += new EventHandler(miGlobalVariableEditor_Click);
      }
    }

    internal virtual ToolStripMenuItem MiOpenWorkingDir
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenWorkingDir != null)
          _miOpenWorkingDir.Click -= new EventHandler(miOpenWorkingDir_Click);
        _miOpenWorkingDir = value;
        if (_miOpenWorkingDir == null)
          return;
        _miOpenWorkingDir.Click += new EventHandler(miOpenWorkingDir_Click);
      }
      get => _miOpenWorkingDir;
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem8
    {
      get => _ToolStripMenuItem8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_ToolStripMenuItem8 == null)
          ;
        _ToolStripMenuItem8 = value;
        if (_ToolStripMenuItem8 == null)
          ;
      }
    }

    internal virtual Button Button4
    {
      get => _button4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_button4 != null)
          _button4.Click -= new EventHandler(Read_NWScript_Click);
        _button4 = value;
        if (_button4 == null)
          return;
        _button4.Click += new EventHandler(Read_NWScript_Click);
      }
    }

    internal virtual ToolStripMenuItem MiOpenDialogTlkViewer
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenDialogTlkViewer != null)
          _miOpenDialogTlkViewer.Click -= new EventHandler(miOpenDialogTlkViewer_Click);
        _miOpenDialogTlkViewer = value;
        if (_miOpenDialogTlkViewer == null)
          return;
        _miOpenDialogTlkViewer.Click += new EventHandler(miOpenDialogTlkViewer_Click);
      }
      get => _miOpenDialogTlkViewer;
    }

    internal virtual ToolStripMenuItem MiOpenPwkEditor
    {
      get => _miOpenPwkEditor;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenPwkEditor != null)
          _miOpenPwkEditor.Click -= new EventHandler(miOpenPWKEditor_Click);
        _miOpenPwkEditor = value;
        if (_miOpenPwkEditor == null)
          return;
        _miOpenPwkEditor.Click += new EventHandler(miOpenPWKEditor_Click);
      }
    }

    internal virtual ToolStripMenuItem MiShowSupportedModEditorMaps
    {
      get => _miShowSupportedModEditorMaps;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miShowSupportedModEditorMaps != null)
          _miShowSupportedModEditorMaps.Click -= new EventHandler(miShowSupportedModEditorMaps_Click);
        _miShowSupportedModEditorMaps = value;
        if (_miShowSupportedModEditorMaps == null)
          return;
        _miShowSupportedModEditorMaps.Click += new EventHandler(miShowSupportedModEditorMaps_Click);
      }
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem7
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_ToolStripMenuItem7 == null)
          ;
        _ToolStripMenuItem7 = value;
        if (_ToolStripMenuItem7 == null)
          ;
      }
      get => _ToolStripMenuItem7;
    }

    internal virtual ToolStripMenuItem MiOpenMapsFolder
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenMapsFolder != null)
          _miOpenMapsFolder.Click -= new EventHandler(miOpenMapsFolder_Click);
        _miOpenMapsFolder = value;
        if (_miOpenMapsFolder == null)
          return;
        _miOpenMapsFolder.Click += new EventHandler(miOpenMapsFolder_Click);
      }
      get => _miOpenMapsFolder;
    }

    internal virtual ToolStripMenuItem MiOpenModuleEditor
    {
      get => _miOpenModuleEditor;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenModuleEditor != null)
          _miOpenModuleEditor.Click -= new EventHandler(miOpenModuleEditor_Click);
        _miOpenModuleEditor = value;
        if (_miOpenModuleEditor == null)
          return;
        _miOpenModuleEditor.Click += new EventHandler(miOpenModuleEditor_Click);
      }
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem10
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_ToolStripMenuItem10 == null)
          ;
        _ToolStripMenuItem10 = value;
        if (_ToolStripMenuItem10 == null)
          ;
      }
      get => _ToolStripMenuItem10;
    }

    internal virtual ToolStripMenuItem MiOpenSsfEditor
    {
      get => _miOpenSsfEditor;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenSsfEditor != null)
          _miOpenSsfEditor.Click -= new EventHandler(miOpenSSFEditor_Click);
        _miOpenSsfEditor = value;
        if (_miOpenSsfEditor == null)
          return;
        _miOpenSsfEditor.Click += new EventHandler(miOpenSSFEditor_Click);
      }
    }

    internal virtual Button BtnCreateMapInfoBfd
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnCreateMapInfoBfd != null)
          _btnCreateMapInfoBfd.Click -= new EventHandler(CreateMapInfoBFD_Click);
        _btnCreateMapInfoBfd = value;
        if (_btnCreateMapInfoBfd == null)
          return;
        _btnCreateMapInfoBfd.Click += new EventHandler(CreateMapInfoBFD_Click);
      }
      get => _btnCreateMapInfoBfd;
    }

    internal virtual Button Button1
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_button1 != null)
          _button1.Click -= new EventHandler(ReadTreeBFD_Click);
        _button1 = value;
        if (_button1 == null)
          return;
        _button1.Click += new EventHandler(ReadTreeBFD_Click);
      }
      get => _button1;
    }

    internal virtual Button BtnExtractForModuleEditing
    {
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnExtractForModuleEditing != null)
          _btnExtractForModuleEditing.Click -= new EventHandler(btnExtractForModuleEditing_Click);
        _btnExtractForModuleEditing = value;
        if (_btnExtractForModuleEditing == null)
          return;
        _btnExtractForModuleEditing.Click += new EventHandler(btnExtractForModuleEditing_Click);
      }
      get => _btnExtractForModuleEditing;
    }
        #endregion
    }
}