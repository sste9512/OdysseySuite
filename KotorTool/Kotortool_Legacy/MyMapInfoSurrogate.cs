// Decompiled with JetBrains decompiler
// Type: kotor_tool.MyMapInfoSurrogate
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class MyMapInfoSurrogate : ISerializationSurrogate, ISurrogateSelector
{
        
        
    private Assembly _assemblyToMigrate;

    public MyMapInfoSurrogate(Assembly assemblyToMigrate) => _assemblyToMigrate = assemblyToMigrate;

    public object SetObjectData(
        object obj,
        SerializationInfo info,
        StreamingContext context,
        ISurrogateSelector selector)
    {
            string empty = string.Empty;
            foreach (SerializationEntry serializationEntry in info)
            {
                string name = serializationEntry.Name;
                Type type;
                if (name.IndexOf("+") != -1)
                {
                    string[] strArray = name.Split("+".ToCharArray());
                    string sRight = strArray[0];
                    name = strArray[1];
                    type = obj.GetType();
                    while (StringType.StrCmp(type.Name, sRight, false) != 0)
                        type = type.BaseType;
                }
                else
                    type = obj.GetType();

                MemberInfo[] member = type.GetMember(name, MemberTypes.Field,
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (member.Length > 0)
                {
                    FieldInfo fieldInfo = (FieldInfo)member[0];
                    object objectValue = RuntimeHelpers.GetObjectValue(serializationEntry.Value);
                    if (objectValue != null &&
                        !fieldInfo.FieldType.IsInstanceOfType(RuntimeHelpers.GetObjectValue(objectValue)))
                        objectValue = RuntimeHelpers.GetObjectValue(
                            Convert.ChangeType(RuntimeHelpers.GetObjectValue(objectValue), fieldInfo.FieldType));
                    fieldInfo.SetValue(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(objectValue));
                }
            }

            return null;
        }

    public void GetObjectData(object entity, SerializationInfo info, StreamingContext context) =>
        throw new NotImplementedException();

    /*public ISerializationSurrogate GetSurrogate(
      Type type,
      StreamingContext context,
      ref ISurrogateSelector selector)
    {

    }*/

    public ISerializationSurrogate GetSurrogate(Type type, StreamingContext context,
        out ISurrogateSelector selector)
    {
            if (type.Assembly == _assemblyToMigrate)
            {
                selector = this;
                return this;
            }

            selector = null;
            return null;
        }

    public ISurrogateSelector GetNextSelector() => null;

    public void ChainSelector(ISurrogateSelector selector) =>
        throw new NotImplementedException("ChainSelector not supported");
}