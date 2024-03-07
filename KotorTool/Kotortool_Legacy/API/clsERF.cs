using System.Collections;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.API;

public class ClsErf
{
    private readonly TpcResourceHeaderConstant _tpcResourceHeaderConstant = new();
        
    public int EntryCount;
    public int OffKeyList;
    public int OffsetResList;
    public ArrayList KeyEntryList;
    private byte[] _keyData;
    private readonly byte[] _resInfoData;
    private FileStream _fstream;

    public ClsErf(
        string outputFilePath,
        string FileType,
        uint DescriptionStrRef,
        ERFLocalizedString[] erfLocalizedStringList,
        string[] inputFileList)
    {
        var output = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write);
        var binaryWriter = new BinaryWriter(output, Encoding.ASCII);
        char[] chars1 = new char[16];
        //Span<char> chars1 = stackalloc char[16];
            
        binaryWriter.Write((Strings.UCase(Strings.Trim(FileType)) + " V1.0").ToCharArray());
            
        var num1 = 0;
        if (erfLocalizedStringList != null && erfLocalizedStringList.Length > 0)
        {
            var num2 = !(StringType.StrCmp(Strings.LCase(FileType), "erf", false) == 0 |
                         StringType.StrCmp(Strings.LCase(FileType), "hak", false) == 0)
                ? 0
                : 1;
            var num3 = checked(erfLocalizedStringList.Length - 1);
            var index = 0;
            while (index <= num3)
            {
                checked
                {
                    num1 += 8 + erfLocalizedStringList[index].StringSize + num2;
                }

                checked
                {
                    ++index;
                }
            }

            binaryWriter.Write(erfLocalizedStringList.Length);
        }
        else
            binaryWriter.Write(0);

        binaryWriter.Write(num1);
        binaryWriter.Write(inputFileList.Length);
        binaryWriter.Write(160);
        binaryWriter.Write(checked(num1 + 160));
        binaryWriter.Write(checked(num1 + inputFileList.Length * 24 + 160));
        binaryWriter.Write(checked(DateAndTime.Year(DateAndTime.Now) - 1900));
        binaryWriter.Write(checked((int)DateAndTime.DateDiff(DateInterval.DayOfYear,
            DateType.FromString("1/1/" + StringType.FromInteger(DateAndTime.Year(DateAndTime.Now))),
            DateAndTime.Now)));
        binaryWriter.Write(DescriptionStrRef);
        var num4 = 1;
        do
        {
            binaryWriter.Write(0);
            checked
            {
                ++num4;
            }
        } while (num4 <= 29);

        output.Seek(160L, SeekOrigin.Begin);
        if (erfLocalizedStringList is { Length: > 0 })
        {
            var num5 = !(StringType.StrCmp(Strings.LCase(FileType), "erf", false) == 0 |
                         StringType.StrCmp(Strings.LCase(FileType), "hak", false) == 0)
                ? 0
                : 1;
            var num6 = checked(erfLocalizedStringList.Length - 1);
            var index1 = 0;
            while (index1 <= num6)
            {
                    
                binaryWriter.Write(erfLocalizedStringList[index1].LanguageId);
                binaryWriter.Write(erfLocalizedStringList[index1].StringSize);
                var chars2 = new char[checked(erfLocalizedStringList[index1].StringSize + num5 - 1 + 1)];
                Array.Clear(chars2, 0, chars2.Length);
                    
                    
                var num7 = checked(erfLocalizedStringList[index1].StringSize - 1);
                var index2 = 0;
                while (index2 <= num7)
                {
                    chars2[index2] = erfLocalizedStringList[index1].StringText[index2];
                    checked
                    {
                        ++index2;
                    }
                }

                binaryWriter.Write(chars2);
                checked
                {
                    ++index1;
                }
            }
        }

        output.Seek(checked(num1 + 160), SeekOrigin.Begin);
        var num8 = checked(inputFileList.Length - 1);
        var index3 = 0;
        while (index3 <= num8)
        {
            var index4 = 0;
            do
            {
                chars1[index4] = char.MinValue;
                checked
                {
                    ++index4;
                }
            } while (index4 <= 15);

            var withoutExtension = Path.GetFileNameWithoutExtension(inputFileList[index3]);
            var num9 = checked(withoutExtension.Length - 1);
            var index5 = 0;
            while (index5 <= num9)
            {
                chars1[index5] = withoutExtension[index5];
                checked
                {
                    ++index5;
                }
            }

            binaryWriter.Write(chars1);
            binaryWriter.Write(index3);
            binaryWriter.Write(FrmMain.GetIdForRsrcType(Strings.Mid(Path.GetExtension(inputFileList[index3]), 2)));
            binaryWriter.Write((byte)0);
            binaryWriter.Write((byte)0);
            checked
            {
                ++index3;
            }
        }

        var uint321 = Convert.ToUInt32(checked(output.Position + inputFileList.Length * 8));
        var num10 = checked(inputFileList.Length - 1);
        var index6 = 0;
        while (index6 <= num10)
        {
            binaryWriter.Write(uint321);
            var uint322 = Convert.ToUInt32(new FileInfo(inputFileList[index6]).Length);
            binaryWriter.Write(uint322);
            uint321 = Convert.ToUInt32(checked(Convert.ToInt64(uint321) + Convert.ToInt64(uint322)));
            checked
            {
                ++index6;
            }
        }

        var num11 = checked(inputFileList.Length - 1);
        var index7 = 0;
        while (index7 <= num11)
        {
            var binaryReader =
                new BinaryReader(new FileStream(inputFileList[index7], FileMode.Open, FileAccess.Read));
            output.Write(binaryReader.ReadBytes(checked((int)new FileInfo(inputFileList[index7]).Length)), 0,
                checked((int)new FileInfo(inputFileList[index7]).Length));
            binaryReader.Close();
            checked
            {
                ++index7;
            }
        }

        binaryWriter.Close();
    }

    public ClsErf(FileStream fileStream)
    {
        var binaryReader = new BinaryReader(fileStream, Encoding.ASCII);
        var asciiEncoding = new ASCIIEncoding();
        var stringBuilder = new StringBuilder();
        _fstream = fileStream;
        fileStream.Seek(16L, SeekOrigin.Begin);
        EntryCount = binaryReader.ReadInt32();
        fileStream.Seek(4L, SeekOrigin.Current);
        OffKeyList = binaryReader.ReadInt32();
        OffsetResList = binaryReader.ReadInt32();
        KeyEntryList = new ArrayList(EntryCount);
        fileStream.Seek(OffKeyList, SeekOrigin.Begin);
        _keyData = binaryReader.ReadBytes(checked(24 * EntryCount));
        _resInfoData = binaryReader.ReadBytes(checked(16 * EntryCount));
           
            
            
        var num1 = checked(EntryCount - 1);
        var index = 0;
        while (index <= num1)
        {
            stringBuilder.Append(asciiEncoding.GetString(_keyData, checked(index * 24), 16));
            var num2 = 0;
            while (_keyData[checked(num2 + index * 24)] != 0)
            {
                checked
                {
                    ++num2;
                }

                if (num2 > 15)
                    break;
            }

            stringBuilder.Length = num2;
            var resourceName = stringBuilder.ToString();
            stringBuilder.Length = 0;
            var resourceId = checked((int)Math.Round(_keyData[checked(index * 24 + 16)] +
                                                     _keyData[checked(index * 24 + 17)] * 256.0 +
                                                     _keyData[checked(index * 24 + 18)] * 65536.0 +
                                                     _keyData[checked(index * 24 + 19)] * 16777216.0));
            var resType =
                checked((short)Math.Round(_keyData[checked(index * 24 + 20)] +
                                          _keyData[checked(index * 24 + 21)] * 256.0));
            var offset = checked((int)Math.Round(_resInfoData[checked(index * 8)] +
                                                 _resInfoData[checked(index * 8 + 1)] * 256.0 +
                                                 _resInfoData[checked(index * 8 + 2)] * 65536.0 +
                                                 _resInfoData[checked(index * 8 + 3)] * 16777216.0));
              
                
            var length = checked((int)Math.Round(_resInfoData[checked(index * 8 + 4)] +
                                                 _resInfoData[checked(index * 8 + 5)] * 256.0 +
                                                 _resInfoData[checked(index * 8 + 6)] * 65536.0 +
                                                 _resInfoData[checked(index * 8 + 7)] * 16777216.0));
                
            KeyEntryList.Add(new ERFKeyEntry(resourceName, resType, resourceId, offset, length, index));
            checked
            {
                ++index;
            }
        }
    }

    public byte[] GetErfResource(int index)
    {
        var binaryReader = new BinaryReader(_fstream, Encoding.ASCII);
        var keyEntry = (ERFKeyEntry)KeyEntryList[index];
        var numArray = new byte[checked(keyEntry._Length - 1 + 1)];
        _fstream.Seek(keyEntry._Offset, SeekOrigin.Begin);
        return binaryReader.ReadBytes(keyEntry._Length);
    }

    public byte[] GetErfResource(string ResRef, int ResType) => GetErfResource(FindIndexForResRef(ResRef, ResType));

    public int FindIndexForResRef(string ResRef, int ResType)
    {
        var index = 0;
        try
        {
            foreach (ERFKeyEntry keyEntry in KeyEntryList)
            {
                if (StringType.StrCmp(Strings.LCase(keyEntry._ResourceName), Strings.LCase(ResRef), false) == 0 &&
                    keyEntry._ResType == ResType)
                {
                    index = keyEntry._Index;
                    break;
                }
            }
        }
        finally
        {
        }

        return index;
    }

    // TODO  : Figure out how this works with DOTNEXT Vectors
    private sealed class TpcResourceHeaderConstant 
    { 
        //public TpcResourceHeaderConstant() : base(16) { }
    }

    public byte[] GetErfTpcResourceHeader(int index)
    {
        var binaryReader = new BinaryReader(_fstream, Encoding.ASCII);
            
        var keyEntry = (ERFKeyEntry)KeyEntryList[index];

        var numArray = new byte[16];
        //var numArray = new byte[_tpcResourceHeaderConstant];
            
        _fstream.Seek(keyEntry._Offset, SeekOrigin.Begin);

        return binaryReader.ReadBytes(16);
            
       // return binaryReader.ReadBytes(_tpcResourceHeaderConstant);
    }
}