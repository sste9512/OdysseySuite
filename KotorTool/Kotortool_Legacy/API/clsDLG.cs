using System.Collections;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.API;

public class clsDLG
{
    public ArrayList StartingList;
    public ClsGff dlgGff;
    public TreeView tv;
    private clsDialogTlk clsDialogTlk;
    public ArrayList EntryNodeList;
    public ArrayList ReplyNodeList;
    private Hashtable nodeHashtable;
    public Options CurrentSettings;
    private bool IsDebugMode;

    public override string ToString() => dlgGff.ToString();

    public clsDLG(int kotorVerIndex)
    {
        nodeHashtable = new Hashtable();
        IsDebugMode = false;
        CurrentSettings = UserSettings.GetSettings();
        clsDialogTlk = new clsDialogTlk(CurrentSettings.KotorLocation(kotorVerIndex) + "\\dialog.tlk");
    }

    public clsDLG(ref TreeView extTV, int KotorVerIndex)
        : this(KotorVerIndex)
    {
        tv = extTV;
        tv.Nodes.Add(new DLGConvListNode("Root"));
        ((DLGConvListNode)tv.Nodes[0]).IsReply = true;
        dlgGff = new ClsGff(KotorVerIndex);
        dlgGff.CreateList(string.Empty, "EntryList");
        dlgGff.CreateList(string.Empty, "ReplyList");
        dlgGff.CreateList(string.Empty, nameof(StartingList));
        dlgGff.CreateList(string.Empty, "StuntList");
    }

    public clsDLG(byte[] bytes, ref TreeView extTV, int KotorVerIndex)
        : this(KotorVerIndex)
    {
        dlgGff = new ClsGff(bytes, KotorVerIndex);
        tv = extTV;
        LoadAndProcess();
    }

    public clsDLG(FileStream fs, ref TreeView extTV, int KotorVerIndex)
        : this(KotorVerIndex)
    {
        dlgGff = new ClsGff(fs, KotorVerIndex);
    }

    public clsDLG(string filepath, ref TreeView extTV, int KotorVerIndex)
        : this(KotorVerIndex)
    {
        dlgGff = new ClsGff(new FileStream(filepath, FileMode.Open, FileAccess.Read), KotorVerIndex);
        tv = extTV;
        LoadAndProcess();
    }

    private void LoadAndProcess()
    {
        tv.Nodes.Add(new DLGConvListNode("Root"));
        ((DLGConvListNode)tv.Nodes[0]).IsReply = true;
        int num1 = checked(dlgGff.GetListItemCount("StartingList") - 1);
        int index = 0;
        while (index <= num1)
        {
            int int32 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dlgGff.GetNodeValue("StartingList(" + StringType.FromInteger(index) + ").Index")));
            GFFExoLocString nodeValue = (GFFExoLocString)dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Text");
            string str = nodeValue.StringRef != -1 ? clsDialogTlk.GetString(nodeValue.StringRef) : (nodeValue.StringCount <= 0 ? "" : ((GFFExoLocSubString)nodeValue.subStringArr[0]).value);
            DLGConvListNode node = new DLGConvListNode();
            node.LinkID = int32;
            node.LinkDesc = "S" + int32;
            nodeHashtable.Add("E" + int32, "");
            node.IsEntry = true;
            node.NodeOriginalPath = "StartingList(" + StringType.FromInteger(index) + ")";
            node.ForeColor = Color.Red;
            node.ActiveScript = StringType.FromObject(dlgGff.GetNodeValue("StartingList(" + StringType.FromInteger(index) + ").Active"));
            node.Comment = StringType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Comment"));
            node.Delay = (uint)(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Delay") ?? Activator.CreateInstance(typeof(uint)));
            node.InternalText = str;
            node.Quest = StringType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Quest"));
            node.Sound = StringType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Sound"));
            node.Script = StringType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Script"));
            node.Speaker = StringType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Speaker"));
            node.VO_ResRef = StringType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").VO_ResRef"));
            node.SoundExists = IntegerType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").SoundExists"));
            node.PlotIndex = IntegerType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").PlotIndex"));
            node.PlotXPPercentage = DecimalType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").PlotXPPercentage"));
            node.Listener = StringType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Listener"));
            node.WaitFlags = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").WaitFlags")));
            node.CameraAngle = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").CameraAngle")));
            node.CameraID = IntegerType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").CameraID"));
            node.CamVidEffect = IntegerType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").CamVidEffect"));
            node.FadeType = IntegerType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").FadeType"));
            node.FadeDelay = DecimalType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").FadeDelay"));
            node.FadeLength = DecimalType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").FadeLength"));
            node.TarHeightOffset = DecimalType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").TarHeightOffset"));
            node.CamHeightOffset = DecimalType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").CamHeightOffset"));
            node.FadeColor = (GFFType17)dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").FadeColor");
            node.CamFieldOfView = DecimalType.FromObject(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").CamFieldOfView"));
            if (dlgGff.VerifyNodeExists("EntryList(" + StringType.FromInteger(int32) + ").AnimList") && dlgGff.GetListItemCount("EntryList(" + StringType.FromInteger(int32) + ").AnimList") > 0)
            {
                node.Animlist = new ArrayList();
                int num2 = checked(dlgGff.GetListItemCount("EntryList(" + StringType.FromInteger(int32) + ").AnimList") - 1);
                int num3 = 0;
                while (num3 <= num2)
                {
                    node.Animlist.Add(new AnimListEntry()
                    {
                        Participant = RuntimeHelpers.GetObjectValue(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").AnimList(" + StringType.FromInteger(num3) + ").Participant")),
                        Animation = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").AnimList(" + StringType.FromInteger(num3) + ").Animation")))
                    });
                    checked
                    {
                        ++num3;
                    }
                }
            }

            node.Text = node.NodeDesc;
            tv.Nodes[0].Nodes.Add(node);
            BuildTV("EntryList(" + StringType.FromInteger(int32) + ")", (DLGConvListNode)tv.Nodes[0].Nodes[index]);
            checked
            {
                ++index;
            }
        }

        EntryNodeList = new ArrayList();
        ReplyNodeList = new ArrayList();
        ScanTVForEntryNodes((DLGConvListNode)tv.Nodes[0], "Root");
        ScanTreeViewForLinkNodes((DLGConvListNode)tv.Nodes[0], "Root");
    }

    public void BuildTV(string listItemPath, DLGConvListNode dlgNode)
    {
        string listName;
        string str1;
        if (listItemPath.StartsWith("EntryList"))
        {
            listName = "RepliesList";
            str1 = "ReplyList";
        }
        else
        {
            listName = "EntriesList";
            str1 = "EntryList";
        }

        int num1 = checked(dlgGff.GetListItemCount(listItemPath + "." + listName) - 1);
        int index = 0;
        while (index <= num1)
        {
            DLGConvListNode node = new DLGConvListNode();
            if (listItemPath.StartsWith("ReplyList"))
            {
                node.ForeColor = Color.Red;
                node.IsEntry = true;
            }
            else
            {
                node.ForeColor = Color.Blue;
                node.IsReply = true;
            }

            int num2 = IntegerType.FromObject(dlgGff.GetNodeValue(listItemPath + "." + listName + "(" + StringType.FromInteger(index) + ").IsChild"));
            int int32 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dlgGff.GetNodeValue(listItemPath + "." + listName + "(" + StringType.FromInteger(index) + ").Index")));
            node.LinkID = int32;
            node.NodeOriginalPath = listItemPath;
            if (listItemPath.StartsWith("ReplyList"))
            {
                node.LinkDesc = "E" + StringType.FromInteger(int32);
                if (num2 != 0)
                    node.LinkDesc += " (L)";
            }
            else
                node.LinkDesc = "R" + StringType.FromInteger(int32);

            GFFExoLocString nodeValue = (GFFExoLocString)dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Text");
            if (nodeValue.StringRef == -1)
            {
                if (nodeValue.StringCount > 0 && ((GFFExoLocSubString)nodeValue.subStringArr[0]).StringLength > 0)
                {
                    GFFExoLocSubString gffExoLocSubString = (GFFExoLocSubString)nodeValue.subStringArr[0];
                    node.InternalText = gffExoLocSubString.value;
                }
                else
                    node.InternalText = "";
            }
            else
                node.InternalText = clsDialogTlk.GetString(nodeValue.StringRef);

            string str2 = dlgGff.GetListItemCount(str1 + "(" + StringType.FromInteger(int32) + ")." + GetOppositeRepliesListName(listName)) != 0
                ? (node.InternalText.Length != 0 ? node.InternalText : "[CONTINUE]")
                : node.InternalText + "[END DIALOGUE]";
            node.ActiveScript = StringType.FromObject(dlgGff.GetNodeValue(listItemPath + "." + listName + "(" + StringType.FromInteger(index) + ").Active"));
            node.Comment = StringType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Comment"));
            node.Delay = (uint)(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Delay") ?? Activator.CreateInstance(typeof(uint)));
            node.Quest = StringType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Quest"));
            if (StringType.StrCmp(node.Quest, "", false) != 0)
                node.QuestEntry = (uint)(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").QuestEntry") ?? Activator.CreateInstance(typeof(uint)));
            node.Sound = StringType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Sound"));
            node.Script = StringType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Script"));
            node.Speaker = StringType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Speaker"));
            node.VO_ResRef = StringType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").VO_ResRef"));
            node.SoundExists = IntegerType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").SoundExists"));
            node.PlotIndex = IntegerType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").PlotIndex"));
            node.PlotXPPercentage = DecimalType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").PlotXPPercentage"));
            node.Listener = StringType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Listener"));
            node.WaitFlags = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").WaitFlags")));
            node.CameraAngle = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").CameraAngle")));
            node.CameraID = IntegerType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").CameraID"));
            node.CamVidEffect = IntegerType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").CamVidEffect"));
            node.FadeType = IntegerType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").FadeType"));
            node.FadeDelay = DecimalType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").FadeDelay"));
            node.FadeLength = DecimalType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").FadeLength"));
            node.TarHeightOffset = DecimalType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").TarHeightOffset"));
            node.CamHeightOffset = DecimalType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").CamHeightOffset"));
            node.FadeColor = (GFFType17)dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").FadeColor");
            node.CamFieldOfView = DecimalType.FromObject(dlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").CamFieldOfView"));
            bool flag = false;
            string str3 = !(!listItemPath.StartsWith("EntryList") & !flag) ? "" : (StringType.StrCmp(node.Speaker, "", false) != 0 ? "[" + node.Speaker + "] - " : "[OWNER] - ");
            if (num2 == 0)
            {
                node.Text = str3 + str2;
                node.IsLink = 0;
            }
            else
            {
                node.IsLink = 1;
                node.Text = str3 + str2 + " (Link)";
                node.LinkedToIndex = int32;
                node.ForeColor = Color.Gray;
            }

            dlgNode.Nodes.Add(node);
            if (num2 == 0)
            {
                if (IsDebugMode)
                    Console.WriteLine("Parent Node " + dlgNode.LinkDesc + " of Node " + node.LinkDesc + " is not a link, scanning children...");
                BuildTV(str1 + "(" + StringType.FromInteger(int32) + ")", (DLGConvListNode)dlgNode.Nodes[index]);
            }
            else if (IsDebugMode)
                Console.WriteLine("Node " + dlgNode.LinkDesc + " of Node " + node.LinkDesc + " is a link, scanning children skipped");

            checked
            {
                ++index;
            }
        }
    }

    private void ScanTVForEntryNodes(DLGConvListNode innode, string CurrNodeType)
    {
        foreach (DLGConvListNode node in innode.Nodes)
        {
            if (~node.IsLink > 0)
            {
                if (StringType.StrCmp(CurrNodeType, "Entry", false) == 0)
                {
                    ReplyNodeList.Add(node);
                    ScanTVForEntryNodes(node, "Reply");
                }
                else
                {
                    EntryNodeList.Add(node);
                    ScanTVForEntryNodes(node, "Entry");
                }
            }
        }
    }

    private void DumpLists()
    {
        DLGConvListNode dlgConvListNode;

        foreach (DLGConvListNode entryNode in EntryNodeList)
        {
            if (entryNode.LinkedNodesList != null)
            {
                foreach (DLGConvListNode linkedNodes in entryNode.LinkedNodesList)
                    dlgConvListNode = linkedNodes;
            }

            if (entryNode.IsLink != 1)
                ;
        }


        foreach (DLGConvListNode replyNode in ReplyNodeList)
        {
            if (replyNode.LinkedNodesList != null)
            {
                foreach (DLGConvListNode linkedNodes in replyNode.LinkedNodesList)
                    dlgConvListNode = linkedNodes;
            }

            if (replyNode.IsLink != 1)
                ;
        }
    }

    private void ScanTreeViewForLinkNodes(DLGConvListNode innode, string CurrNodeType)
    {
        foreach (DLGConvListNode node in innode.Nodes)
        {
            if (StringType.StrCmp(CurrNodeType, "Entry", false) == 0)
            {
                if (node.IsLink == 1)
                {
                    node.LinkedToNode = FindNodeInListByLinkId(ReplyNodeList, node.LinkedToIndex);
                    if (node.Text != null)
                        ;
                    if (node.LinkedToNode.LinkedNodesList == null)
                        node.LinkedToNode.LinkedNodesList = new ArrayList();
                    node.LinkedToNode.LinkedNodesList.Add(node);
                }

                ScanTreeViewForLinkNodes(node, "Reply");
            }
            else
            {
                if (node.IsLink == 1)
                {
                    node.LinkedToNode = FindNodeInListByLinkId(EntryNodeList, node.LinkedToIndex);
                    if (node.Text != null)
                        ;
                    if (node.LinkedToNode.LinkedNodesList == null)
                        node.LinkedToNode.LinkedNodesList = new ArrayList();
                    node.LinkedToNode.LinkedNodesList.Add(node);
                }

                ScanTreeViewForLinkNodes(node, "Entry");
            }
        }
    }

    private DLGConvListNode FindNodeInListByLinkId(ArrayList list, int id)
    {
        DLGConvListNode nodeInListByLinkId = null;

        foreach (DLGConvListNode dlgConvListNode in list)
        {
            if (dlgConvListNode.LinkID == id)
            {
                nodeInListByLinkId = dlgConvListNode;
                break;
            }
        }


        return nodeInListByLinkId;
    }

    private string GetOppositeMainListName(string listName) => StringType.StrCmp(listName, "EntryList", false) == 0 ? "ReplyList" : "EntryList";

    private string GetOppositeRepliesListName(string listName) => StringType.StrCmp(listName, "EntriesList", false) == 0 ? "RepliesList" : "EntriesList";
}