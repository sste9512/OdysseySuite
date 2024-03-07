// Decompiled with JetBrains decompiler
// Type: kotor_tool.clsBWM
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.API;

public class ClsBwm
{
    public float[] UnkSingles;
    public uint VertCount;
    public uint VertsOffset;
    public uint FaceCount;
    public uint FacesOffset;
    public int WalkTypeOffset;
    public int UnkXyzOffset;
    public int Unk3Offset;
    public int AabbOffset;
    public int Unk5Offset;
    public int Unk6Offset;
    public int Unk7Offset;
    private int _aabbCount;
    private int _unkInt321;
    private int _unk5Count;
    private int _unk6Count;
    private int _unk7Count;
    public int[] WalkTypes;
    public int[] Unk5;
    public float[] Unk2;
    public float[] Unk3;
    public float[] Unk4;
    public UnkIntPair[] Unk6;
    public Vert Position;
    public AabbNode[] AabbNodes;
    public Vert[] Verts;
    public Face[] Faces;
    private int _i;
    private int _gAbbbIndex;

    public ClsBwm()
    {
        UnkSingles = new float[14];
        _gAbbbIndex = 0;
    }

    public ClsBwm(Vert[] v, Face[] f)
    {
        UnkSingles = new float[14];
        _gAbbbIndex = 0;
        Verts = new Vert[checked(v.GetUpperBound(0) + 1)];
        Faces = new Face[checked(f.GetUpperBound(0) + 1)];
        Array.Copy(v, Verts, v.Length);
        Array.Copy(f, Faces, f.Length);
        VertCount = Convert.ToUInt32(Verts.Length);
        FaceCount = Convert.ToUInt32(Faces.Length);
    }

    public ClsBwm(string filepath)
        : this(new FileStream(filepath, FileMode.Open))
    {
    }

    public ClsBwm(byte[] Data)
    {
        UnkSingles = new float[14];
        _gAbbbIndex = 0;
        ReadFromStream(new MemoryStream(Data));
    }

    public ClsBwm(MemoryStream ms)
    {
        UnkSingles = new float[14];
        _gAbbbIndex = 0;
        ReadFromStream(ms);
    }

    public ClsBwm(FileStream fs)
    {
        UnkSingles = new float[14];
        _gAbbbIndex = 0;
        BinaryReader binaryReader = new BinaryReader(fs);
        byte[] numArray = new byte[checked((int)(fs.Length - 1L) + 1)];
        byte[] buffer = binaryReader.ReadBytes(checked((int)fs.Length));
        binaryReader.Close();
        ReadFromStream(new MemoryStream(buffer));
    }

    private void ReadFromStream(MemoryStream ms)
    {
        BinaryReader binaryReader = new BinaryReader(ms);
        binaryReader.BaseStream.Seek(8L, SeekOrigin.Begin);
        this._i = 0;
        do
        {
            UnkSingles[_i] = binaryReader.ReadSingle();
            checked
            {
                ++_i;
            }
        } while (this._i <= 12);

        Position.X = binaryReader.ReadSingle();
        Position.Y = binaryReader.ReadSingle();
        Position.Z = binaryReader.ReadSingle();
        VertCount = binaryReader.ReadUInt32();
        VertsOffset = binaryReader.ReadUInt32();
        FaceCount = binaryReader.ReadUInt32();
        FacesOffset = binaryReader.ReadUInt32();
        WalkTypeOffset = binaryReader.ReadInt32();
        UnkXyzOffset = binaryReader.ReadInt32();
        Unk3Offset = binaryReader.ReadInt32();
        _aabbCount = binaryReader.ReadInt32();
        AabbOffset = binaryReader.ReadInt32();
        _unkInt321 = binaryReader.ReadInt32();
        _unk5Count = binaryReader.ReadInt32();
        Unk5Offset = binaryReader.ReadInt32();
        _unk6Count = binaryReader.ReadInt32();
        Unk6Offset = binaryReader.ReadInt32();
        _unk7Count = binaryReader.ReadInt32();
        Unk7Offset = binaryReader.ReadInt32();
        Verts = new Vert[checked(Convert.ToInt32(VertCount) - 1 + 1)];
        binaryReader.BaseStream.Seek(Convert.ToInt64(VertsOffset), SeekOrigin.Begin);
        int num1 = checked(Convert.ToInt32(VertCount) - 1);
        this._i = 0;
        while (this._i <= num1)
        {
            Verts[_i].X = binaryReader.ReadSingle();
            Verts[_i].Y = binaryReader.ReadSingle();
            Verts[_i].Z = binaryReader.ReadSingle();
            checked
            {
                ++_i;
            }
        }

        Faces = new Face[checked(Convert.ToInt32(FaceCount) - 1 + 1)];
        binaryReader.BaseStream.Seek(Convert.ToInt64(FacesOffset), SeekOrigin.Begin);
        int num2 = checked(Convert.ToInt32(FaceCount) - 1);
        this._i = 0;
        while (this._i <= num2)
        {
            Faces[_i].V1 = binaryReader.ReadInt32();
            Faces[_i].V2 = binaryReader.ReadInt32();
            Faces[_i].V3 = binaryReader.ReadInt32();
            checked
            {
                ++_i;
            }
        }

        WalkTypes = new int[checked(Convert.ToInt32(FaceCount) - 1 + 1)];
        binaryReader.BaseStream.Seek(WalkTypeOffset, SeekOrigin.Begin);
        int num3 = checked(Convert.ToInt32(FaceCount) - 1);
        this._i = 0;
        while (this._i <= num3)
        {
            WalkTypes[_i] = binaryReader.ReadInt32();
            checked
            {
                ++_i;
            }
        }

        AabbNodes = new AabbNode[checked(_aabbCount - 1 + 1)];
        binaryReader.BaseStream.Seek(AabbOffset, SeekOrigin.Begin);
        int num4 = checked(_aabbCount - 1);
        this._i = 0;
        while (this._i <= num4)
        {
            int i = this._i;
            AabbNodes[i].BBoxMin.X = binaryReader.ReadSingle();
            AabbNodes[i].BBoxMin.Y = binaryReader.ReadSingle();
            AabbNodes[i].BBoxMin.Z = binaryReader.ReadSingle();
            AabbNodes[i].BBoxMax.X = binaryReader.ReadSingle();
            AabbNodes[i].BBoxMax.Y = binaryReader.ReadSingle();
            AabbNodes[i].BBoxMax.Z = binaryReader.ReadSingle();
            AabbNodes[i].LeafFacePartNumber = binaryReader.ReadInt32();
            AabbNodes[i].Always4 = binaryReader.ReadInt32();
            AabbNodes[i].MostSignifPlane = binaryReader.ReadInt32();
            AabbNodes[i].LeftNodeArrayIndex = binaryReader.ReadInt32();
            AabbNodes[i].RightNodeArrayIndex = binaryReader.ReadInt32();
            checked
            {
                ++this._i;
            }
        }
    }

    public void WriteBinary(string filepath)
    {
        BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filepath, FileMode.Create));
        binaryWriter.Write("BWM V1.0".ToCharArray());
        int index1 = 0;
        do
        {
            binaryWriter.Write(UnkSingles[index1]);
            checked
            {
                ++index1;
            }
        } while (index1 <= 12);

        binaryWriter.Write(Position.X);
        binaryWriter.Write(Position.Y);
        binaryWriter.Write(Position.Z);
        binaryWriter.Write(Verts.Length);
        binaryWriter.Write(Convert.ToUInt32(136));
        binaryWriter.Write(Faces.Length);
        binaryWriter.Write(Convert.ToUInt32(0));
        binaryWriter.Seek(136, SeekOrigin.Begin);
        int num1 = checked(Verts.Length - 1);
        int index2 = 0;
        while (index2 <= num1)
        {
            binaryWriter.Write(Verts[index2].X);
            binaryWriter.Write(Verts[index2].Y);
            binaryWriter.Write(Verts[index2].Z);
            checked
            {
                ++index2;
            }
        }

        FacesOffset = Convert.ToUInt32(binaryWriter.BaseStream.Position);
        int num2 = checked(Faces.Length - 1);
        int index3 = 0;
        while (index3 <= num2)
        {
            binaryWriter.Write(Faces[index3].V1);
            binaryWriter.Write(Faces[index3].V2);
            binaryWriter.Write(Faces[index3].V3);
            checked
            {
                ++index3;
            }
        }

        WalkTypeOffset = Convert.ToInt32(binaryWriter.BaseStream.Position);
        int num3 = checked(Faces.Length - 1);
        int index4 = 0;
        while (index4 <= num3)
        {
            binaryWriter.Write(Convert.ToInt32(WalkTypes[index4]));
            checked
            {
                ++index4;
            }
        }

        UnkXyzOffset = Convert.ToInt32(binaryWriter.BaseStream.Position);
        int num4 = checked(Faces.Length - 1);
        int num5 = 0;
        while (num5 <= num4)
        {
            binaryWriter.Write(Convert.ToInt32(0));
            binaryWriter.Write(Convert.ToInt32(0));
            binaryWriter.Write(Convert.ToInt32(0));
            checked
            {
                ++num5;
            }
        }

        Unk3Offset = Convert.ToInt32(binaryWriter.BaseStream.Position);
        int num6 = checked(Faces.Length - 1);
        int num7 = 0;
        while (num7 <= num6)
        {
            binaryWriter.Write(Convert.ToInt32(0));
            checked
            {
                ++num7;
            }
        }

        binaryWriter.Seek(84, SeekOrigin.Begin);
        binaryWriter.Write(FacesOffset);
        binaryWriter.Write(WalkTypeOffset);
        binaryWriter.Write(UnkXyzOffset);
        binaryWriter.Write(Unk3Offset);
        binaryWriter.Close();
    }

    public void ParseAsciiWalkMesh(string filepath)
    {
        StreamReader streamReader = new StreamReader(new FileStream(filepath, FileMode.Open));
        if (streamReader.ReadLine().StartsWith("BWM"))
        {
            streamReader.Close();
            throw new Exception("Not an ASCII file");
        }

        string str1;
        do
        {
            str1 = streamReader.ReadLine();
            Console.WriteLine(str1);
            string[] strArray1 = RemoveExcessWhitespace(str1.Trim()).Split(' ');
            string lower = strArray1[0].ToLower();
            if (StringType.StrCmp(lower, "position", false) == 0)
            {
                if (strArray1.Length != 4)
                {
                    Console.WriteLine("Wrong number of values for Position: " +
                                      StringType.FromInteger(checked(strArray1.Length - 1)));
                }
                else
                {
                    Position.X = Convert.ToSingle(strArray1[1]);
                    Position.Y = Convert.ToSingle(strArray1[2]);
                    Position.Z = Convert.ToSingle(strArray1[3]);
                }
            }
            else if (StringType.StrCmp(lower, "verts", false) == 0)
            {
                if (strArray1.Length != 2)
                    Console.WriteLine("Wrong number of values for Verts header: " +
                                      StringType.FromInteger(checked(strArray1.Length - 1)));
                else if (!Information.IsNumeric(strArray1[1]))
                {
                    Console.WriteLine("Value for Verts count non-numeric");
                }
                else
                {
                    Verts = new Vert[checked(Convert.ToInt32(strArray1[1]) - 1 + 1)];
                    int num = checked(Convert.ToInt32(strArray1[1]) - 1);
                    int index = 0;
                    while (index <= num)
                    {
                        str1 = streamReader.ReadLine();
                        Console.WriteLine(str1);
                        string[] strArray2 = RemoveExcessWhitespace(str1.Trim()).Split(' ');
                        Verts[index].X = Convert.ToSingle(strArray2[0]);
                        Verts[index].Y = Convert.ToSingle(strArray2[1]);
                        Verts[index].Z = Convert.ToSingle(strArray2[2]);
                        checked
                        {
                            ++index;
                        }
                    }
                }
            }
            else if (StringType.StrCmp(lower, "faces", false) == 0)
            {
                if (strArray1.Length != 2)
                    Console.WriteLine("Wrong number of values for Faces header: " +
                                      StringType.FromInteger(checked(strArray1.Length - 1)));
                else if (!Information.IsNumeric(strArray1[1]))
                {
                    Console.WriteLine("Value for Faces count non-numeric");
                }
                else
                {
                    Faces = new Face[checked(Convert.ToInt32(strArray1[1]) - 1 + 1)];
                    WalkTypes = new int[checked(Convert.ToInt32(strArray1[1]) - 1 + 1)];
                    int num = checked(Convert.ToInt32(strArray1[1]) - 1);
                    int index = 0;
                    while (index <= num)
                    {
                        str1 = streamReader.ReadLine();
                        Console.WriteLine(str1);
                        string[] strArray3 = RemoveExcessWhitespace(str1.Trim()).Split(' ');
                        Faces[index].V1 = Convert.ToInt32(strArray3[0]);
                        Faces[index].V2 = Convert.ToInt32(strArray3[1]);
                        Faces[index].V3 = Convert.ToInt32(strArray3[2]);
                        WalkTypes[index] = Convert.ToInt32(strArray3[7]);
                        checked
                        {
                            ++index;
                        }
                    }
                }
            }
            else if (StringType.StrCmp(lower, "aabb", false) == 0)
            {
                AabbNodes = new AabbNode[100];
                int num1 = 0;
                int index1 = num1;
                AabbNodes[index1].BBoxMin.X = SingleType.FromString(strArray1[1]);
                AabbNodes[index1].BBoxMin.Y = SingleType.FromString(strArray1[2]);
                AabbNodes[index1].BBoxMin.Z = SingleType.FromString(strArray1[3]);
                AabbNodes[index1].BBoxMax.X = SingleType.FromString(strArray1[4]);
                AabbNodes[index1].BBoxMax.Y = SingleType.FromString(strArray1[5]);
                AabbNodes[index1].BBoxMax.Z = SingleType.FromString(strArray1[6]);
                AabbNodes[index1].Always4 = 4;
                AabbNodes[index1].LeafFacePartNumber = IntegerType.FromString(strArray1[7]);
                checked
                {
                    ++num1;
                }

                string[] strArray4;
                do
                {
                    string str2 = streamReader.ReadLine();
                    Console.WriteLine(str2);
                    strArray4 = RemoveExcessWhitespace(str2.Trim()).Split(' ');
                    if (Information.IsNumeric(strArray4[0]))
                    {
                        int index2 = num1;
                        AabbNodes[index2].BBoxMin.X = SingleType.FromString(strArray4[0]);
                        AabbNodes[index2].BBoxMin.Y = SingleType.FromString(strArray4[1]);
                        AabbNodes[index2].BBoxMin.Z = SingleType.FromString(strArray4[2]);
                        AabbNodes[index2].BBoxMax.X = SingleType.FromString(strArray4[3]);
                        AabbNodes[index2].BBoxMax.Y = SingleType.FromString(strArray4[4]);
                        AabbNodes[index2].BBoxMax.Z = SingleType.FromString(strArray4[5]);
                        AabbNodes[index2].LeafFacePartNumber = IntegerType.FromString(strArray4[6]);
                        AabbNodes[index2].Always4 = 4;
                        checked
                        {
                            ++num1;
                        }

                        if (num1 == AabbNodes.Length)
                            AabbNodes =
                                (AabbNode[])Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(AabbNodes,
                                    new AabbNode[checked(AabbNodes.Length + 100 + 1)]);
                    }
                    else
                        break;
                } while (Information.IsNumeric(strArray4[0]));

                int num2 = checked(AabbNodes.Length - 1);
                int index3 = 0;
                while (index3 <= num2 && AabbNodes[index3].Always4 != 0)
                    checked
                    {
                        ++index3;
                    }

                if (index3 < AabbNodes.Length)
                    AabbNodes =
                        (AabbNode[])Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(AabbNodes,
                            new AabbNode[checked(index3 - 1 + 1)]);
                _gAbbbIndex = 0;
                SetAabbNode(ref AabbNodes[0], AabbNodes);
                str1 = null;
            }
            else if (StringType.StrCmp(lower, "endnode", false) == 0)
                break;
        } while (str1 != null);

        streamReader.Close();
    }

    public void WriteAscii(string filepath, string parentname = "walk_parent")
    {
        StreamWriter streamWriter = new StreamWriter(new FileStream(filepath, FileMode.Create), Encoding.ASCII);
        Path.GetFileNameWithoutExtension(filepath);
        //streamWriter.WriteLine("# Written by Kotor Tool v" + Application.ProductVersion);
        streamWriter.WriteLine("# Written by Kotor Tool v" + null);
        streamWriter.WriteLine("node trimesh PWK");
        streamWriter.WriteLine("  parent " + parentname);
        streamWriter.WriteLine("  position " + StringType.FromSingle(Position.X) + " " +
                               StringType.FromSingle(Position.Y) + " " + StringType.FromSingle(Position.Z));
        streamWriter.WriteLine("  orientation 1.0 0.0 0.0 0.0");
        streamWriter.WriteLine("  wirecolor 0.694118 0.580392 0.101961");
        streamWriter.WriteLine("  multimaterial 20");
        streamWriter.WriteLine("    Dirt");
        streamWriter.WriteLine("    Obscuring");
        streamWriter.WriteLine("    Grass");
        streamWriter.WriteLine("    Stone");
        streamWriter.WriteLine("    Wood");
        streamWriter.WriteLine("    Water");
        streamWriter.WriteLine("    Nonwalk");
        streamWriter.WriteLine("    Transparent");
        streamWriter.WriteLine("    Carpet");
        streamWriter.WriteLine("    Metal");
        streamWriter.WriteLine("    Puddles");
        streamWriter.WriteLine("    Swamp");
        streamWriter.WriteLine("    Mud");
        streamWriter.WriteLine("    Leaves");
        streamWriter.WriteLine("    Lava");
        streamWriter.WriteLine("    BottomlessPit");
        streamWriter.WriteLine("    DeepWater");
        streamWriter.WriteLine("    Door");
        streamWriter.WriteLine("    Snow");
        streamWriter.WriteLine("    Sand");
        streamWriter.WriteLine("  ambient 0.588 0.588 0.588");
        streamWriter.WriteLine("  diffuse 0.705882 0.0 1.0");
        streamWriter.WriteLine("  specular 0.0 0.0 0.0");
        streamWriter.WriteLine("  selfillumcolor 0.0 0.0 0.0");
        streamWriter.WriteLine("  bitmap NULL");
        streamWriter.WriteLine("  verts " + StringType.FromInteger(Verts.Length));
        int num1 = checked(Verts.Length - 1);
        _i = 0;
        while (_i <= num1)
        {
            streamWriter.WriteLine("  " + StringType.FromSingle(Verts[_i].X) + " " +
                                   StringType.FromSingle(Verts[_i].Y) + " " + StringType.FromSingle(Verts[_i].Z));
            checked
            {
                ++_i;
            }
        }

        streamWriter.WriteLine("  faces " + StringType.FromInteger(Faces.Length));
        int num2 = checked(Faces.Length - 1);
        _i = 0;
        while (_i <= num2)
        {
            streamWriter.WriteLine("  " + StringType.FromInteger(Faces[_i].V1) + " " +
                                   StringType.FromInteger(Faces[_i].V2) + " " + StringType.FromInteger(Faces[_i].V3) +
                                   " 1 0 0 0 " + StringType.FromInteger(WalkTypes[_i]));
            checked
            {
                ++_i;
            }
        }

        streamWriter.WriteLine("endnode");
        streamWriter.Close();
    }

    private void SetAabbNode(ref AabbNode node, AabbNode[] aabbArray)
    {
        if (_gAbbbIndex > aabbArray.Length)
            return;
        if (node.LeafFacePartNumber == -1)
        {
            checked
            {
                ++_gAbbbIndex;
            }

            node.LeftNodeArrayIndex = _gAbbbIndex;
            SetAabbNode(ref aabbArray[_gAbbbIndex], aabbArray);
            checked
            {
                ++_gAbbbIndex;
            }

            node.RightNodeArrayIndex = _gAbbbIndex;
            SetAabbNode(ref aabbArray[_gAbbbIndex], aabbArray);
        }
        else
        {
            node.LeftNodeArrayIndex = -1;
            node.RightNodeArrayIndex = -1;
        }
    }

    private string RemoveExcessWhitespace(string src)
    {
        int num = checked(src.Length - 1);
        int startIndex = 0;
        string str = null;
        while (startIndex <= num)
        {
            string sLeft = src.Substring(startIndex, 1);
            bool flag = false;
            if (StringType.StrCmp(sLeft, " ", false) != 0)
            {
                flag = false;
                str += sLeft;
            }
            else if (!flag)
            {
                flag = true;
                str += sLeft;
            }

            checked
            {
                ++startIndex;
            }
        }

        return str;
    }

    public struct Vert
    {
        public float X;
        public float Y;
        public float Z;
    }

    public struct Face
    {
        public int V1;
        public int V2;
        public int V3;
    }

    public struct UnkIntPair
    {
        public int Int1;
        public int Int2;
    }

    public struct AabbNode
    {
        public Vert BBoxMin;
        public Vert BBoxMax;
        public int LeafFacePartNumber;
        public int LeftNodeArrayIndex;
        public int RightNodeArrayIndex;
        public int Always4;
        public int MostSignifPlane;
    }
}