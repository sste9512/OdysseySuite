// Decompiled with JetBrains decompiler
// Type: kotor_tool.DLGConvListNode
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class DLGConvListNode : TreeNode
{
    public ArrayList Animlist;
    public string ActiveScript;
    public int CameraAngle;
    public int CameraID;
    public Decimal CamHeightOffset;
    public Decimal CamFieldOfView;
    public int CamVidEffect;
    public string Comment;
    public uint Delay;
    public int FadeType;
    public Decimal FadeDelay;
    public Decimal FadeLength;
    public GFFType17 FadeColor;
    public string InternalText;
    public string Listener;
    public int PlotIndex;
    public Decimal PlotXPPercentage;
    public string Quest;
    public uint QuestEntry;
    public string Script;
    public string Speaker;
    public string Sound;
    public int SoundExists;
    public Decimal TarHeightOffset;
    public string VO_ResRef;
    public int WaitFlags;
    public byte IsLink;
    public int LinkID;
    public int LinkedToIndex;
    public ArrayList LinkedNodesList;
    public DLGConvListNode LinkedToNode;
    private bool m_IsEntry;
    private bool m_IsReply;
    public string LinkDesc;
    public string NodeOriginalPath;

    public Color DialogColor
    {
        get
        {
                if (IsLink > 0)
                    return Color.Gray;
                return IsEntry ? Color.Red : Color.Blue;
            }
    }

    public bool IsEndDialog => IsReply & Nodes.Count == 0;

    public bool IsContinueDialog => StringType.StrCmp(InternalText, "", false) == 0 & Nodes.Count > 0;

    public string NodeDesc
    {
        get
        {
                string nodeDesc;
                if (IsContinueDialog)
                {
                    nodeDesc = "[CONTINUE]";
                }
                else
                {
                    string str = null;
                    if (IsEntry)
                        str = StringType.StrCmp(Speaker, "", false) != 0 ? "[" + Speaker + "] - " : "[OWNER] - ";
                    nodeDesc = str + InternalText;
                    if (IsLink > 0)
                        nodeDesc += " (Link)";
                    else if (IsEndDialog)
                        nodeDesc += " [END DIALOGUE]";
                }

                return nodeDesc;
            }
    }

    public bool IsReply
    {
        get => m_IsReply;
        set
        {
                m_IsReply = value;
                m_IsEntry = !value;
            }
    }

    public bool IsEntry
    {
        get => m_IsEntry;
        set
        {
                m_IsEntry = value;
                m_IsReply = !value;
            }
    }

    public bool HasLinkedNodes => LinkedNodesList != null && LinkedNodesList.Count > 0;

    public void UpdateLinkedNodesText()
    {
            if (!HasLinkedNodes)
                return;
            try
            {
                foreach (DLGConvListNode linkedNodes in LinkedNodesList)
                {
                    linkedNodes.InternalText = InternalText;
                    linkedNodes.Text = linkedNodes.NodeDesc;
                }
            }
            finally
            {
            }
        }

    public DLGConvListNode()
    {
            Script = "";
            Speaker = "";
            ActiveScript = "";
            InternalText = "";
            Comment = "";
            Sound = "";
            VO_ResRef = "";
            Listener = "";
            PlotIndex = -1;
            CamVidEffect = -1;
        }

    public DLGConvListNode(string NodeText)
        : base(NodeText)
    {
        }

    public DLGConvListNode Copy()
    {
            DLGConvListNode dlgConvListNode = new DLGConvListNode();
            dlgConvListNode.Speaker = Speaker;
            dlgConvListNode.ActiveScript = ActiveScript;
            dlgConvListNode.Text = Text;
            dlgConvListNode.InternalText = InternalText;
            dlgConvListNode.Script = Script;
            dlgConvListNode.Delay = Delay;
            dlgConvListNode.Comment = Comment;
            dlgConvListNode.Sound = Sound;
            dlgConvListNode.Quest = Quest;
            dlgConvListNode.QuestEntry = QuestEntry;
            dlgConvListNode.VO_ResRef = VO_ResRef;
            dlgConvListNode.PlotIndex = PlotIndex;
            dlgConvListNode.PlotXPPercentage = PlotXPPercentage;
            dlgConvListNode.Listener = Listener;
            dlgConvListNode.WaitFlags = WaitFlags;
            dlgConvListNode.CameraAngle = CameraAngle;
            dlgConvListNode.CamFieldOfView = CamFieldOfView;
            dlgConvListNode.FadeType = FadeType;
            dlgConvListNode.FadeDelay = FadeDelay;
            dlgConvListNode.FadeLength = FadeLength;
            dlgConvListNode.FadeColor = FadeColor;
            dlgConvListNode.TarHeightOffset = TarHeightOffset;
            dlgConvListNode.CamHeightOffset = CamHeightOffset;
            dlgConvListNode.SoundExists = SoundExists;
            if (LinkedNodesList != null)
                dlgConvListNode.LinkedNodesList = (ArrayList)LinkedNodesList.Clone();
            dlgConvListNode.LinkedToNode = LinkedToNode;
            dlgConvListNode.IsEntry = IsEntry;
            dlgConvListNode.IsReply = IsReply;
            dlgConvListNode.IsLink = IsLink;
            return dlgConvListNode;
        }
}