﻿using System.IO;

namespace kotor_tool.API.AuroraParsers
{
    public class GITObject
    {

        AuroraFile file;
        BinaryReader Reader;

        public GITObject(AuroraFile file)
        {
            this.file = file;
        }

        public void Read()
        {
            file.Open();
            Reader = file.GetReader();




            file.Close();
        }

    }
}
