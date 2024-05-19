// Decompiled with JetBrains decompiler
// Type: kotor_tool.Options
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

[Serializable]
public class Options
{
    private Point m_MainWindowLoc;
    private Size m_MainWindowSize;
    private int m_MainWindowSplitterPos;
    private string m_defaultImportLocation;
    private string m_defaultOverrideLocation;
    private string m_defaultKeyFileLocation;
    private string m_defaultSaveLocation;
    private string m_defaultKotORLocation;
    private string m_defaultModuleLocation;
    private string m_defaultDataLocation;
    private string m_ImageViewerLocation;
    private string m_defaultRimsLocation;
    private string m_defaultTexturePackLocation;
    private string m_ModelExportLocation;
    private string _ModuleExtractPath;
    private string _TextEditorSavePath;
    public string CurrentDataLocation;
    public string CurrentKotORLocation;
    public string CurrentModuleLocation;
    public string CurrentOverrideLocation;
    public string CurrentKeyFileLocation;
    public string CurrentRimsLocation;
    private string m_defaultKotORLocation2;
    private string m_defaultModuleLocation2;
    private bool _mBBuildBifFtreeOnStartup;
    private bool _mBAlwaysConvertTpc2Tga;
    private bool m_bDockImageViewer;
    private bool m_bTextEditorWordWrap;
    private bool m_bAlwaysUnknownGFFasText;
    private bool m_bShowModuleLocations;
    private bool m_bShowModuleDescriptions;
    private bool m_bBuildModelsBifNode;
    private bool _bProjMgrUseExternTxtEditor;
    private bool _bProjMgrUseExternDLGEditor;
    private string _projMgrDLGEditorPath;
    private string _projMgrTxtEditorPath;
    private Point m_ImageViewerWindowLoc;
    private Point m_frmGlobalVarEditorWindowLoc;
    private Size m_ImageViewerWindowSize;
    private Size m_frmGlobalVarEditorWindowSize;
    private Point m_ByteViewerWindowLoc;
    private Size m_ByteViewerWindowSize;
    private Point m_TextEditorWindowLoc;
    private Size m_TextEditorWindowSize;
    private Point m_ERFManagerWindowLoc;
    private Size m_ERFManagerWindowSize;
    private Point m_2DAEditorWindowLoc;
    private Size m_2DAEditorWindowSize;
    private Point m_UTCEditorWindowLoc;
    private Size m_UTCEditorWindowSize;
    private Point m_UTDEditorWindowLoc;
    private Size m_UTDEditorWindowSize;
    private Point m_UTIEditorWindowLoc;
    private Size m_UTIEditorWindowSize;
    private Point m_UTMEditorWindowLoc;
    private Size m_UTMEditorWindowSize;
    private Point m_UTPEditorWindowLoc;
    private Size m_UTPEditorWindowSize;
    private Point m_UTSEditorWindowLoc;
    private Size m_UTSEditorWindowSize;
    private Point m_UTTEditorWindowLoc;
    private Size m_UTTEditorWindowSize;
    private Point m_UTWEditorWindowLoc;
    private Size m_UTWEditorWindowSize;
    private Point m_ProjectManagerWindowLoc;
    private Size m_ProjectManagerWindowSize;
    private Point m_InventoryEditorWindowLoc;
    private Size m_InventoryEditorWindowSize;
    private Point m_ModuleEditorWindowLoc;
    private Size m_ModuleEditorWindowSize;
    private string m_Key;
    private string m_LastModuleEditedPath;
    private bool m_bModuleEditorShowLocatorRay;
    private bool m_bModuleEditorConfirmDeletes;
    private Decimal m_ModuleEditorModuleElementIndicatorSize;
    private ArrayList m_MRUMainFiles;
    private ArrayList m_TreeOpenPaths;
    private string m_LastClickedTVNodePath;
    private bool m_bCheckForUpdatesAtStartup;
    private bool m_bDownloadUpdatesAutomatically;
    private bool m_bRememberLastTreeNode;
    private bool m_bRememberTreeViewState;
    private bool m_bModelExtraction_ExtractAnimations;
    private bool m_bModelExtraction_ConvertSkinToTrimesh;
    private bool m_bModelExtraction_EachModelInOwnDirectory;
    private bool m_bModelExtraction_CleanWorkingDirectoryBeforeExport;
    private bool m_bUseOverrideFiles;

    public Options(string mDefaultModuleLocation2)
    {
        m_defaultModuleLocation2 = mDefaultModuleLocation2;
        _ModuleExtractPath = "";
            _TextEditorSavePath = "";
            _bProjMgrUseExternTxtEditor = false;
            _bProjMgrUseExternDLGEditor = false;
            _projMgrDLGEditorPath = "";
            _projMgrTxtEditorPath = "";
            m_Key = "";
            m_LastModuleEditedPath = "";
            m_bModuleEditorShowLocatorRay = true;
            m_bModuleEditorConfirmDeletes = true;
            m_MRUMainFiles = new ArrayList();
            m_TreeOpenPaths = new ArrayList();
            m_bCheckForUpdatesAtStartup = true;
            m_bDownloadUpdatesAutomatically = true;
            m_bRememberLastTreeNode = true;
            m_bRememberTreeViewState = true;
            m_bModelExtraction_ExtractAnimations = false;
            m_bModelExtraction_ConvertSkinToTrimesh = false;
            m_bModelExtraction_EachModelInOwnDirectory = true;
            m_bModelExtraction_CleanWorkingDirectoryBeforeExport = true;
            m_bUseOverrideFiles = false;
        }

    public bool bProjMgrUseExternTxtEditor
    {
        get => _bProjMgrUseExternTxtEditor;
        set => _bProjMgrUseExternTxtEditor = value;
    }

    public bool bProjMgrUseExternDLGEditor
    {
        get => _bProjMgrUseExternDLGEditor;
        set => _bProjMgrUseExternDLGEditor = value;
    }

    public string ProjMgrDLGEditorPath
    {
        get => _projMgrDLGEditorPath;
        set => _projMgrDLGEditorPath = value;
    }

    public string ProjMgrTxtEditorPath
    {
        get => _projMgrTxtEditorPath;
        set => _projMgrTxtEditorPath = value;
    }

    public bool bModelExtraction_ExtractAnimations
    {
        get => m_bModelExtraction_ExtractAnimations;
        set => m_bModelExtraction_ExtractAnimations = value;
    }

    public bool bModelExtraction_ConvertSkinToTrimesh
    {
        get => m_bModelExtraction_ConvertSkinToTrimesh;
        set => m_bModelExtraction_ConvertSkinToTrimesh = value;
    }

    public bool bModelExtraction_EachModelInOwnDirectory
    {
        get => m_bModelExtraction_EachModelInOwnDirectory;
        set => m_bModelExtraction_EachModelInOwnDirectory = value;
    }

    public bool bModelExtraction_CleanWorkingDirectoryBeforeExport
    {
        get => m_bModelExtraction_CleanWorkingDirectoryBeforeExport;
        set => m_bModelExtraction_CleanWorkingDirectoryBeforeExport = value;
    }

    public bool bCheckForUpdatesAtStartup
    {
        get => m_bCheckForUpdatesAtStartup;
        set => m_bCheckForUpdatesAtStartup = value;
    }

    public bool bDownloadUpdatesAutomatically
    {
        get => m_bDownloadUpdatesAutomatically;
        set => m_bDownloadUpdatesAutomatically = value;
    }

    public bool bModuleEditorShowLocatorRay
    {
        get => m_bModuleEditorShowLocatorRay;
        set => m_bModuleEditorShowLocatorRay = value;
    }

    public bool bModuleEditorConfirmDeletes
    {
        get => m_bModuleEditorConfirmDeletes;
        set => m_bModuleEditorConfirmDeletes = value;
    }

    public Decimal ModuleEditorModuleElementIndicatorSize
    {
        get => m_ModuleEditorModuleElementIndicatorSize;
        set => m_ModuleEditorModuleElementIndicatorSize = value;
    }

    public int MainWindowSplitterPos
    {
        get => m_MainWindowSplitterPos;
        set => m_MainWindowSplitterPos = value;
    }

    public string KotorLocation(int index)
    {
            switch (index)
            {
                case 0:
                    return m_defaultKotORLocation;
                case 1:
                    return m_defaultKotORLocation2;
                default:
                    string str = null;
                    return str;
            }
        }

    public string KeyFileLocation(int index)
    {
            switch (index)
            {
                case 0:
                    return m_defaultKotORLocation + "\\chitin.key";
                case 1:
                    return m_defaultKotORLocation2 + "\\chitin.key";
                default:
                    string str = null;
                    return str;
            }
        }

    public string ModelExportLocation
    {
        get => m_ModelExportLocation;
        set => m_ModelExportLocation = value;
    }

    public string ModuleExtractPath
    {
        get => _ModuleExtractPath;
        set => _ModuleExtractPath = value;
    }

    public string defaultKotORLocation
    {
        get => m_defaultKotORLocation;
        set => m_defaultKotORLocation = value;
    }

    public string defaultKotORLocation2
    {
        get => m_defaultKotORLocation2;
        set => m_defaultKotORLocation2 = value;
    }

    public string ImageViewerLocation
    {
        get => m_ImageViewerLocation;
        set => m_ImageViewerLocation = value;
    }

    public string defaultSaveLocation
    {
        get => m_defaultSaveLocation;
        set => m_defaultSaveLocation = value;
    }

    public string defaultImportLocation
    {
        get => m_defaultImportLocation;
        set => m_defaultImportLocation = value;
    }

    public string TextEditorSavePath
    {
        get => _TextEditorSavePath;
        set => _TextEditorSavePath = value;
    }

    public bool bUseOverrideFiles
    {
        get => m_bUseOverrideFiles;
        set => m_bUseOverrideFiles = value;
    }

    public string LastClickedTVNodePath
    {
        get => m_LastClickedTVNodePath;
        set => m_LastClickedTVNodePath = value;
    }

    public bool bRememberLastTreeNode
    {
        get => m_bRememberLastTreeNode;
        set => m_bRememberLastTreeNode = value;
    }

    public bool bRememberTreeViewState
    {
        get => m_bRememberTreeViewState;
        set => m_bRememberTreeViewState = value;
    }

    public bool bBuildModelsBifNode
    {
        get => m_bBuildModelsBifNode;
        set => m_bBuildModelsBifNode = value;
    }

    public bool bBuildBIFFtreeOnStartup
    {
        get => _mBBuildBifFtreeOnStartup;
        set => _mBBuildBifFtreeOnStartup = value;
    }

    public bool bAlwaysUnknownGFFasText
    {
        get => m_bAlwaysUnknownGFFasText;
        set => m_bAlwaysUnknownGFFasText = value;
    }

    public bool bAlwaysConvertTPC2TGA
    {
        get => _mBAlwaysConvertTpc2Tga;
        set => _mBAlwaysConvertTpc2Tga = value;
    }

    public bool bDockImageViewer
    {
        get => m_bDockImageViewer;
        set => m_bDockImageViewer = value;
    }

    public bool bTextEditorWordWrap
    {
        get => m_bTextEditorWordWrap;
        set => m_bTextEditorWordWrap = value;
    }

    public bool bShowModuleDescriptions
    {
        get => m_bShowModuleDescriptions;
        set => m_bShowModuleDescriptions = value;
    }

    public bool bShowModuleLocations
    {
        get => m_bShowModuleLocations;
        set => m_bShowModuleLocations = value;
    }

    public Point MainWindowLoc
    {
        get => m_MainWindowLoc;
        set => m_MainWindowLoc = value;
    }

    public Size MainWindowSize
    {
        get => m_MainWindowSize;
        set => m_MainWindowSize = value;
    }

    public Point TextEditorWindowLoc
    {
        get => m_TextEditorWindowLoc;
        set => m_TextEditorWindowLoc = value;
    }

    public Size TextEditorWindowSize
    {
        get => m_TextEditorWindowSize;
        set => m_TextEditorWindowSize = value;
    }

    public Point ImageViewerWindowLoc
    {
        get => m_ImageViewerWindowLoc;
        set => m_ImageViewerWindowLoc = value;
    }

    public Size ImageViewerWindowSize
    {
        get => m_ImageViewerWindowSize;
        set => m_ImageViewerWindowSize = value;
    }

    public Point ByteViewerWindowLoc
    {
        get => m_ByteViewerWindowLoc;
        set => m_ByteViewerWindowLoc = value;
    }

    public Size ByteViewerWindowSize
    {
        get => m_ByteViewerWindowSize;
        set => m_ByteViewerWindowSize = value;
    }

    public Point ERFManagerWindowLoc
    {
        get => m_ERFManagerWindowLoc;
        set => m_ERFManagerWindowLoc = value;
    }

    public Size ERFManagerWindowSize
    {
        get => m_ERFManagerWindowSize;
        set => m_ERFManagerWindowSize = value;
    }

    public Point TwoDAEditorWindowLoc
    {
        get => m_2DAEditorWindowLoc;
        set => m_2DAEditorWindowLoc = value;
    }

    public Size TwoDAEditorWindowSize
    {
        get => m_2DAEditorWindowSize;
        set => m_2DAEditorWindowSize = value;
    }

    public Point UTCEditorWindowLoc
    {
        get => m_UTCEditorWindowLoc;
        set => m_UTCEditorWindowLoc = value;
    }

    public Size UTCEditorWindowSize
    {
        get => m_UTCEditorWindowSize;
        set => m_UTCEditorWindowSize = value;
    }

    public Point UTDEditorWindowLoc
    {
        get => m_UTDEditorWindowLoc;
        set => m_UTDEditorWindowLoc = value;
    }

    public Size UTdEditorWindowSize
    {
        get => m_UTDEditorWindowSize;
        set => m_UTDEditorWindowSize = value;
    }

    public Point UTIEditorWindowLoc
    {
        get => m_UTIEditorWindowLoc;
        set => m_UTIEditorWindowLoc = value;
    }

    public Size UTIEditorWindowSize
    {
        get => m_UTIEditorWindowSize;
        set => m_UTIEditorWindowSize = value;
    }

    public Point UTMEditorWindowLoc
    {
        get => m_UTMEditorWindowLoc;
        set => m_UTMEditorWindowLoc = value;
    }

    public Size UTMEditorWindowSize
    {
        get => m_UTMEditorWindowSize;
        set => m_UTMEditorWindowSize = value;
    }

    public Point UTPEditorWindowLoc
    {
        get => m_UTPEditorWindowLoc;
        set => m_UTPEditorWindowLoc = value;
    }

    public Size UTPEditorWindowSize
    {
        get => m_UTPEditorWindowSize;
        set => m_UTPEditorWindowSize = value;
    }

    public Point UTSEditorWindowLoc
    {
        get => m_UTSEditorWindowLoc;
        set => m_UTSEditorWindowLoc = value;
    }

    public Size UTSEditorWindowSize
    {
        get => m_UTSEditorWindowSize;
        set => m_UTSEditorWindowSize = value;
    }

    public Point UTTEditorWindowLoc
    {
        get => m_UTTEditorWindowLoc;
        set => m_UTTEditorWindowLoc = value;
    }

    public Size UTTEditorWindowSize
    {
        get => m_UTTEditorWindowSize;
        set => m_UTTEditorWindowSize = value;
    }

    public Point UTWEditorWindowLoc
    {
        get => m_UTWEditorWindowLoc;
        set => m_UTWEditorWindowLoc = value;
    }

    public Size UTWEditorWindowSize
    {
        get => m_UTWEditorWindowSize;
        set => m_UTWEditorWindowSize = value;
    }

    public Point ProjectManagerWindowLoc
    {
        get => m_ProjectManagerWindowLoc;
        set => m_ProjectManagerWindowLoc = value;
    }

    public Size ProjectManagerWindowSize
    {
        get => m_ProjectManagerWindowSize;
        set => m_ProjectManagerWindowSize = value;
    }

    public Point InventoryEditorWindowLoc
    {
        get => m_InventoryEditorWindowLoc;
        set => m_InventoryEditorWindowLoc = value;
    }

    public Size InventoryEditorWindowSize
    {
        get => m_InventoryEditorWindowSize;
        set => m_InventoryEditorWindowSize = value;
    }

    public Point ModuleEditorWindowLoc
    {
        get => m_ModuleEditorWindowLoc;
        set => m_ModuleEditorWindowLoc = value;
    }

    public Size ModuleEditorWindowSize
    {
        get => m_ModuleEditorWindowSize;
        set => m_ModuleEditorWindowSize = value;
    }

    public Size get_WindowSize(string FormClassName)
    {
            string sLeft = FormClassName;
            if (StringType.StrCmp(sLeft, "frmInventoryEditor", false) == 0)
                return m_InventoryEditorWindowSize;
            if (StringType.StrCmp(sLeft, "frmUTC_Editor", false) == 0)
                return m_UTCEditorWindowSize;
            if (StringType.StrCmp(sLeft, "frmUTD_Editor", false) == 0)
                return m_UTDEditorWindowSize;
            if (StringType.StrCmp(sLeft, "frmUTI_Editor", false) == 0)
                return m_UTIEditorWindowSize;
            if (StringType.StrCmp(sLeft, "frmUTM_Editor", false) == 0)
                return m_UTMEditorWindowSize;
            if (StringType.StrCmp(sLeft, "frmUTP_Editor", false) == 0)
                return m_UTPEditorWindowSize;
            if (StringType.StrCmp(sLeft, "frmUTS_Editor", false) == 0)
                return m_UTSEditorWindowSize;
            if (StringType.StrCmp(sLeft, "frmUTT_Editor", false) == 0)
                return m_UTTEditorWindowSize;
            if (StringType.StrCmp(sLeft, "frmUTW_Editor", false) == 0)
                return m_UTWEditorWindowSize;
            if (StringType.StrCmp(sLeft, "frmGlobalVar_Editor", false) == 0)
                return m_frmGlobalVarEditorWindowSize;
            if (StringType.StrCmp(sLeft, "frmProjectManager", false) == 0)
                return m_ProjectManagerWindowSize;
            if (StringType.StrCmp(sLeft, "frmERFManager", false) == 0)
                return m_ERFManagerWindowSize;
            Size size = default;
            return StringType.StrCmp(sLeft, "frmModule_Editor", false) == 0 ? m_ModuleEditorWindowSize : size;
        }

    public void set_WindowSize(string FormClassName, Size Value)
    {
            string sLeft = FormClassName;
            if (StringType.StrCmp(sLeft, "frmInventoryEditor", false) == 0)
                m_InventoryEditorWindowSize = Value;
            else if (StringType.StrCmp(sLeft, "frmUTC_Editor", false) == 0)
                m_UTCEditorWindowSize = Value;
            else if (StringType.StrCmp(sLeft, "frmUTD_Editor", false) == 0)
                m_UTDEditorWindowSize = Value;
            else if (StringType.StrCmp(sLeft, "frmUTI_Editor", false) == 0)
                m_UTIEditorWindowSize = Value;
            else if (StringType.StrCmp(sLeft, "frmUTM_Editor", false) == 0)
                m_UTMEditorWindowSize = Value;
            else if (StringType.StrCmp(sLeft, "frmUTP_Editor", false) == 0)
                m_UTPEditorWindowSize = Value;
            else if (StringType.StrCmp(sLeft, "frmUTS_Editor", false) == 0)
                m_UTSEditorWindowSize = Value;
            else if (StringType.StrCmp(sLeft, "frmUTT_Editor", false) == 0)
                m_UTTEditorWindowSize = Value;
            else if (StringType.StrCmp(sLeft, "frmUTW_Editor", false) == 0)
                m_UTWEditorWindowSize = Value;
            else if (StringType.StrCmp(sLeft, "frmGlobalVar_Editor", false) == 0)
                m_frmGlobalVarEditorWindowSize = Value;
            else if (StringType.StrCmp(sLeft, "frmProjectManager", false) == 0)
                m_ProjectManagerWindowSize = Value;
            else if (StringType.StrCmp(sLeft, "frmERFManager", false) == 0)
            {
                m_ERFManagerWindowSize = Value;
            }
            else
            {
                if (StringType.StrCmp(sLeft, "frmModule_Editor", false) != 0)
                    return;
                m_ModuleEditorWindowSize = Value;
            }
        }

    public Point get_WindowLoc(string FormClassName)
    {
            string sLeft = FormClassName;
            if (StringType.StrCmp(sLeft, "frmInventoryEditor", false) == 0)
                return m_InventoryEditorWindowLoc;
            if (StringType.StrCmp(sLeft, "frmUTC_Editor", false) == 0)
                return m_UTCEditorWindowLoc;
            if (StringType.StrCmp(sLeft, "frmUTD_Editor", false) == 0)
                return m_UTDEditorWindowLoc;
            if (StringType.StrCmp(sLeft, "frmUTI_Editor", false) == 0)
                return m_UTIEditorWindowLoc;
            if (StringType.StrCmp(sLeft, "frmUTM_Editor", false) == 0)
                return m_UTMEditorWindowLoc;
            if (StringType.StrCmp(sLeft, "frmUTP_Editor", false) == 0)
                return m_UTPEditorWindowLoc;
            if (StringType.StrCmp(sLeft, "frmUTS_Editor", false) == 0)
                return m_UTSEditorWindowLoc;
            if (StringType.StrCmp(sLeft, "frmUTT_Editor", false) == 0)
                return m_UTTEditorWindowLoc;
            if (StringType.StrCmp(sLeft, "frmUTW_Editor", false) == 0)
                return m_UTWEditorWindowLoc;
            if (StringType.StrCmp(sLeft, "frmGlobalVar_Editor", false) == 0)
                return m_frmGlobalVarEditorWindowLoc;
            if (StringType.StrCmp(sLeft, "frmProjectManager", false) == 0)
                return m_ProjectManagerWindowLoc;
            if (StringType.StrCmp(sLeft, "frmERFManager", false) == 0)
                return m_ERFManagerWindowLoc;
            Point point = default;
            return StringType.StrCmp(sLeft, "frmModule_Editor", false) == 0 ? m_ModuleEditorWindowLoc : point;
        }

    public void set_WindowLoc(string FormClassName, Point Value)
    {
            string sLeft = FormClassName;
            if (StringType.StrCmp(sLeft, "frmInventoryEditor", false) == 0)
                m_InventoryEditorWindowLoc = Value;
            else if (StringType.StrCmp(sLeft, "frmUTC_Editor", false) == 0)
                m_UTCEditorWindowLoc = Value;
            else if (StringType.StrCmp(sLeft, "frmUTD_Editor", false) == 0)
                m_UTDEditorWindowLoc = Value;
            else if (StringType.StrCmp(sLeft, "frmUTI_Editor", false) == 0)
                m_UTIEditorWindowLoc = Value;
            else if (StringType.StrCmp(sLeft, "frmUTM_Editor", false) == 0)
                m_UTMEditorWindowLoc = Value;
            else if (StringType.StrCmp(sLeft, "frmUTP_Editor", false) == 0)
                m_UTPEditorWindowLoc = Value;
            else if (StringType.StrCmp(sLeft, "frmUTS_Editor", false) == 0)
                m_UTSEditorWindowLoc = Value;
            else if (StringType.StrCmp(sLeft, "frmUTT_Editor", false) == 0)
                m_UTTEditorWindowLoc = Value;
            else if (StringType.StrCmp(sLeft, "frmUTW_Editor", false) == 0)
                m_UTWEditorWindowLoc = Value;
            else if (StringType.StrCmp(sLeft, "frmGlobalVar_Editor", false) == 0)
                m_frmGlobalVarEditorWindowLoc = Value;
            else if (StringType.StrCmp(sLeft, "frmProjectManager", false) == 0)
                m_ProjectManagerWindowLoc = Value;
            else if (StringType.StrCmp(sLeft, "frmERFManager", false) == 0)
            {
                m_ERFManagerWindowLoc = Value;
            }
            else
            {
                if (StringType.StrCmp(sLeft, "frmModule_Editor", false) != 0)
                    return;
                m_ModuleEditorWindowLoc = Value;
            }
        }

    public string Key
    {
        get => m_Key;
        set => m_Key = value;
    }

    public string LastModuleEditedPath
    {
        get => m_LastModuleEditedPath;
        set => m_LastModuleEditedPath = value;
    }

    [XmlArrayItem(typeof(string))]
    [XmlArray]
    public ArrayList MRUMainFiles
    {
        get => m_MRUMainFiles;
        set => m_MRUMainFiles = value;
    }

    [XmlArrayItem(typeof(string))]
    [XmlArray]
    public ArrayList TreeOpenPaths
    {
        get => m_TreeOpenPaths;
        set => m_TreeOpenPaths = value;
    }
}