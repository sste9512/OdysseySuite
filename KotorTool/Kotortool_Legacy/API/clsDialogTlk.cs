// Decompiled with JetBrains decompiler
// Type: kotor_tool.clsDialogTlk
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.Text;
using Microsoft.VisualBasic;

namespace Kotortool_Legacy.API;

public class clsDialogTlk
{
    private FileStream _fileStream; // mobilization
    private BinaryReader _binaryReader; // mobilization
    private StreamReader _streamReader; // mobilization
    public readonly int StringCount; // data
    private readonly int _stringEntriesOffset; // data
    private readonly MemoryStream _memoryStream; // mobilization
    private byte[] _bytes; // data
    private ArrayList _talkEntryList; // data

    public clsDialogTlk()
    {
    }

    public clsDialogTlk(string path, bool memoryResident = false)
    {
        _fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        _binaryReader = new BinaryReader(_fileStream, Encoding.ASCII);
        _fileStream.Seek(12L, SeekOrigin.Begin);
        StringCount = _binaryReader.ReadInt32();
        _stringEntriesOffset = _binaryReader.ReadInt32();
        if (!memoryResident)
            return;
        _fileStream.Seek(0L, SeekOrigin.Begin);
        _bytes = new byte[checked((int)(_fileStream.Length - 1L) + 1)];
        _bytes = _binaryReader.ReadBytes(checked((int)_fileStream.Length));
        _binaryReader.Close();
        _memoryStream = new MemoryStream(_bytes, false);
        _binaryReader = new BinaryReader(_memoryStream, Encoding.ASCII);
    }

    public void Close() => _fileStream.Close();

    public string GetString(int stringReference)
    {
        if (stringReference > checked(StringCount - 1))
            return string.Empty;
        _binaryReader.BaseStream.Seek(checked(20 + stringReference * 40), SeekOrigin.Begin);
        if ((_binaryReader.ReadInt32() & 1) == 0)
            return string.Empty;
        var stringBuilder = new StringBuilder();
        _binaryReader.BaseStream.Seek(24L, SeekOrigin.Current);
        var num = _binaryReader.ReadInt32();
        var count = _binaryReader.ReadInt32();
        _binaryReader.BaseStream.Seek(checked(_stringEntriesOffset + num), SeekOrigin.Begin);
        stringBuilder.Append(_binaryReader.ReadChars(count));
        return stringBuilder.ToString();
    }

    public string GetSoundResRef(int stringReference)
    {
        if (stringReference > checked(StringCount - 1))
            return string.Empty;
        _binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
        _binaryReader.BaseStream.Seek(checked(20 + stringReference * 40), SeekOrigin.Begin);
        if ((_binaryReader.ReadInt32() & 2) == 0)
            return string.Empty;
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(_binaryReader.ReadChars(16));
        int index = 0;
        while (Strings.Asc(stringBuilder[index]) != 0)
        {
            checked
            {
                ++index;
            }

            if (index > 15)
                break;
        }

        stringBuilder.Length = index;
        return stringBuilder.ToString();
    }

    public float GetSoundLength(int stringReference)
    {
        if (stringReference > checked(StringCount - 1))
            return 0.0f;
        _fileStream.Seek(0L, SeekOrigin.Begin);
        _fileStream.Seek(checked(20 + stringReference * 40), SeekOrigin.Begin);
        if ((_binaryReader.ReadInt32() & 4) == 0)
            return 0.0f;
        _fileStream.Seek(28L, SeekOrigin.Current);
        return _binaryReader.ReadSingle();
    }

    public DialogTlkStrDataElement GetStringDataElement(int stringReference)
    {
        if (stringReference > checked(StringCount - 1))
            return null;
        int offset = checked(20 + stringReference * 40);
        _binaryReader.BaseStream.Seek(offset, SeekOrigin.Begin);
        DialogTlkStrDataElement stringDataElement = new DialogTlkStrDataElement();
        stringDataElement.Flags = _binaryReader.ReadInt32();
        if (stringReference == 31483)
            ;
        if ((stringDataElement.Flags & 2) != 0)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(_binaryReader.ReadChars(16));
            int index = 0;
            while (Strings.Asc(stringBuilder[index]) != 0)
            {
                checked
                {
                    ++index;
                }

                if (index > 15)
                    break;
            }

            stringBuilder.Length = index;
            stringDataElement.SoundResRef = stringBuilder.ToString();
        }

        if ((stringDataElement.Flags & 4) != 0)
        {
            _binaryReader.BaseStream.Seek(checked(offset + 36), SeekOrigin.Begin);
            stringDataElement.SoundLength = _binaryReader.ReadSingle();
        }

        if ((stringDataElement.Flags & 1) != 0)
        {
            StringBuilder stringBuilder = new StringBuilder();
            _binaryReader.BaseStream.Seek(checked(offset + 28), SeekOrigin.Begin);
            int num = _binaryReader.ReadInt32();
            int count = _binaryReader.ReadInt32();
            _binaryReader.BaseStream.Seek(checked(_stringEntriesOffset + num), SeekOrigin.Begin);
            stringBuilder.Append(_binaryReader.ReadChars(count));
            stringDataElement.Text = stringBuilder.ToString();
        }

        return stringDataElement;
    }

    public void BuildTalkEntryList()
    {
    }

    public void AddTalkEntry(DialogTlkStrDataElement talkEntry)
    {
        if (_talkEntryList == null)
            _talkEntryList = new ArrayList();
        _talkEntryList.Add(talkEntry);
    }

    public void AddTalkEntry(int flags, string text, string soundResourceReference, float soundLength = 0.0f)
    {
        if (_talkEntryList == null)
            _talkEntryList = new ArrayList();
        _talkEntryList.Add(new DialogTlkStrDataElement(flags, text, soundResourceReference, soundLength));
    }

    public void ClearTalkEntryList()
    {
        if (_talkEntryList == null)
            return;
        _talkEntryList.Clear();
    }

    public void WriteListToFile(string path)
    {
        BinaryWriter binaryWriter = new BinaryWriter(new FileStream(path, FileMode.Create));
        int num1 = checked(20 + _talkEntryList.Count * 40);
        int offset = num1;
        binaryWriter.Write("TLK V3.0".ToCharArray());
        binaryWriter.Write(Convert.ToInt32(0));
        binaryWriter.Write(Convert.ToInt32(_talkEntryList.Count));
        binaryWriter.Write(Convert.ToInt32(offset));
        int num2 = checked(_talkEntryList.Count - 1);
        int index = 0;
        while (index <= num2)
        {
            binaryWriter.Seek(checked(20 + index * 40), SeekOrigin.Begin);
            DialogTlkStrDataElement talkEntry = (DialogTlkStrDataElement)_talkEntryList[index];
            binaryWriter.Write(talkEntry.Flags);
            binaryWriter.Write(talkEntry.SoundResRef.PadRight(16, char.MinValue).ToCharArray());
            binaryWriter.Write(Convert.ToInt32(0));
            binaryWriter.Write(Convert.ToInt32(0));
            if ((talkEntry.Flags & 1) != 0)
                binaryWriter.Write(checked(offset - num1));
            else
                binaryWriter.Write(Convert.ToInt32(0));
            binaryWriter.Write(Convert.ToInt32(talkEntry.Text.Length));
            binaryWriter.Write(talkEntry.SoundLength);
            binaryWriter.Seek(offset, SeekOrigin.Begin);
            binaryWriter.Write(talkEntry.Text.ToCharArray());
            checked
            {
                offset += talkEntry.Text.Length;
            }

            checked
            {
                ++index;
            }
        }

        binaryWriter.Close();
    }
}