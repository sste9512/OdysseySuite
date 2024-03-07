using System.Diagnostics;

namespace Kotortool_Legacy.API.AuroraParsers
{
    public sealed class ERFObject
    {

        //0xFFFF

        public struct _ERFHeader
        {
            public char[] FileType;                 //Char 4
            public char[] FileVersion;              //Char 4
            public Int32 LanguageCount;
            public Int32 LocalizedStringSize;
            public Int32 EntryCount;
            public Int32 OffsetToLocalizedString;
            public Int32 OffsetToKeyList;
            public Int32 OffsetToResourceList;
            public byte[] BuildYear;                //Byte 4
            public byte[] BuildDay;                 //Byte 4
            public byte[] DescriptionStrRef;        //Byte 4
            public byte[] Reserved;                 //Byte 116
        }

        public enum LanguageIDs
        {
            English = 0,
            French = 1,
            German = 2,
            Italian = 3,
            Spanish = 4,
            Polish = 5,
            Korean = 128,
            Chinese_Traditional = 129,
            Chinese_Simplified = 130,
            Japanese = 131
        }

        public struct _LocalizedString
        {
            public Int32 LanguageID;
            public Int32 StringSize;
            public String String;
        }

        public struct _ERFKey
        {
            public char[] ResRef;             //Char 16 NULL terminated
            public UInt32 ResID;              //Resource ID
            public UInt16 ResType;
            public UInt16 Unused;
        }

        public struct _ERFResource
        {
            public UInt32 OffsetToResource;
            public UInt32 ResourceSize;
        }

        private AuroraFile file;
        private BinaryReader Reader;
        private byte[] ByteBuffer;

        static _ERFHeader Header;
        static List<_LocalizedString> StringList = new List<_LocalizedString>();
        static List<_ERFKey> KeyList = new List<_ERFKey>();
        static List<_ERFResource> ResourceList = new List<_ERFResource>();

        public ERFObject(AuroraFile file)
        {
            this.file = file;
            Header = new _ERFHeader();
            StringList = new List<_LocalizedString>();
            KeyList = new List<_ERFKey>();
            ResourceList = new List<_ERFResource>();
        }

        //Opens the file
        public void Open()
        {
            file.Open();
            Reader = file.GetReader();
            Reader.BaseStream.Position = 0;
        }

        private void Seek(int bytes)
        {
            Reader.BaseStream.Position = bytes;
        }

        public AuroraFile GetFile()
        {
            return file;
        }

        public void Read()
        {
            Open();
            if (Reader != null)
            {
                Seek(56);
                ByteBuffer = Reader.ReadBytes((int)Reader.BaseStream.Length - 56);

                Seek(0);

                //Get HEADER Data

                Header = ReadHeader();

                //END HEADER

                /*Debug.WriteLine("[Header]");
                Debug.WriteLine(new string(Header.FileType));
                Debug.WriteLine(new string(Header.FileVersion));
                Debug.WriteLine(Header.LanguageCount);
                Debug.WriteLine(Header.LocalizedStringSize);
                Debug.WriteLine(Header.EntryCount);
                Debug.WriteLine(Header.OffsetToLocalizedString);
                Debug.WriteLine(Header.OffsetToKeyList);
                Debug.WriteLine(Header.OffsetToResourceList);
                Debug.WriteLine(BitConverter.ToInt32(Header.BuildYear, 0) + 1900);
                Debug.WriteLine(BitConverter.ToInt32(Header.BuildDay, 0));*/

                Seek(Header.OffsetToLocalizedString);

                Debug.WriteLine("[Language]");
                for (int i = 0; i!=Header.LanguageCount; i++)
                {
                    _LocalizedString str = new _LocalizedString();
                    str.LanguageID = Reader.ReadInt32();
                    str.StringSize = Reader.ReadInt32();
                    str.String = new string(Reader.ReadChars(str.StringSize));
                    StringList.Add(str);

                    //Debug.WriteLine(str.String);
                }

                Seek(Header.OffsetToKeyList);

                //Debug.WriteLine("[Keys]");
                for (int i = 0; i != Header.EntryCount; i++)
                {
                    var str = new _ERFKey
                    {
                        ResRef = Reader.ReadChars(16),
                        ResID = Reader.ReadUInt32(),
                        ResType = Reader.ReadUInt16(),
                        Unused = Reader.ReadUInt16()
                    };
                    KeyList.Add(str);

                    //Debug.WriteLine(new string(str.ResRef));
                }

                Seek(Header.OffsetToResourceList);

                //Debug.WriteLine("[Resources]");
                for (var i = 0; i != Header.EntryCount; i++)
                {
                    var str = new _ERFResource
                    {
                        OffsetToResource = Reader.ReadUInt32(),
                        ResourceSize = Reader.ReadUInt32()
                    };
                    ResourceList.Add(str);

                    //Debug.WriteLine(str.OffsetToResource + " : "+ str.ResourceSize);
                }

            }
            file.Close(); //Close the file because we are done reading data...

        }

        //Reads and sets the files header data
        private _ERFHeader ReadHeader()
        {

            var tmp = new _ERFHeader
            {
                FileType = Reader.ReadChars(4),
                FileVersion = Reader.ReadChars(4),
                LanguageCount = Reader.ReadInt32(),
                LocalizedStringSize = Reader.ReadInt32(),
                EntryCount = Reader.ReadInt32(),
                OffsetToLocalizedString = Reader.ReadInt32(),
                OffsetToKeyList = Reader.ReadInt32(),
                OffsetToResourceList = Reader.ReadInt32(),
                BuildYear = Reader.ReadBytes(4), //Byte 4
                BuildDay = Reader.ReadBytes(4), //Byte 4
                DescriptionStrRef = Reader.ReadBytes(4), //Byte 4
                Reserved = Reader.ReadBytes(116) //Byte 116
            };

            return tmp;
        }

        public List<_ERFKey> GetKeys()
        {
            return KeyList;
        }

        public List<_ERFResource> GetResources()
        {
            return ResourceList;
        }

        public byte[] GetRawResource(_ERFResource resource)
        {
            file.Open();
            Reader = file.GetReader();
            Reader.BaseStream.Position = resource.OffsetToResource;
            var bytes = Reader.ReadBytes((int)resource.ResourceSize);
            file.Close();
            return bytes;
        }

        public _ERFResource GetResourceByKey(String key, int restype)
        {

            Debug.WriteLine("Searching: " + file.GetFilename());
            foreach (_ERFKey _key in KeyList)
            {
                //Debug.WriteLine("Resource Name: " + new string(_key.ResRef));
                if (new string(_key.ResRef).Replace("\0", string.Empty) == key && _key.ResType == (ushort) restype)
                {
                    Debug.WriteLine("Resource Type: "+_key.ResType+ " ID: "+ _key.ResID);
                    return ResourceList[(int)_key.ResID];
                }
            }
            return new _ERFResource();
        }


    }

}
