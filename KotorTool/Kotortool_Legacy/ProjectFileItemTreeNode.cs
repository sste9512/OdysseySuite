// Decompiled with JetBrains decompiler
// Type: kotor_tool.ProjectFileItemTreeNode
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

namespace Kotortool_Legacy;

public class ProjectFileItemTreeNode : TreeNode
{
  private string m_FilePath;

  public ProjectFileItemTreeNode(string NodeName)
    : base(NodeName)
  {
    }

  public ProjectFileItemTreeNode(string NodeName, ProjectFileItemTreeNode[] NodeArray)
    : base(NodeName, NodeArray)
  {
    }

  public override string ToString() => Text;

  public string Filename
  {
    get => Path.GetFileName(m_FilePath);
    set => m_FilePath = Path.GetDirectoryName(m_FilePath) + value;
  }

  public string FilePath
  {
    get => m_FilePath;
    set => m_FilePath = value;
  }
}