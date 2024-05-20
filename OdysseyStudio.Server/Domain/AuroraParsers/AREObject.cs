﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kotor_tool.API.AuroraParsers;

namespace KotOR_Files.AuroraParsers
{
    public class AREObject
    {

        AuroraFile file;
        BinaryReader Reader;

        public AREObject(AuroraFile file)
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
