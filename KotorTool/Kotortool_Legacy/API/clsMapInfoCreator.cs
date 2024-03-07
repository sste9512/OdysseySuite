// Decompiled with JetBrains decompiler
// Type: kotor_tool.clsMapInfoCreator
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.API;

public sealed class clsMapInfoCreator
{
    private MapInfo mi;

    public clsMapInfoCreator() => mi = new MapInfo();

    public void Write(string InstalledAppPath)
    {
        mi.Version = "2005";
        mi.MapList = new ArrayList
        {
            new MapInfo.Map()
            {
                MapName = "m02aa",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Taris - South Apartments",
                L = true,
                S = true,
                LXMul = 26.93M,
                LYMul = 26.58M,
                LXOff = 1775,
                LYOff = 1857,
                SXMul = 12.47M,
                SYMul = 12.54M,
                SXOff = 813,
                SYOff = 799
            },
            new MapInfo.Map()
            {
                MapName = "m02ac",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Taris - Upper City South",
                L = true,
                S = true,
                LXMul = 26.82M,
                LYMul = 26.82M,
                LXOff = 1385,
                LYOff = 355,
                SXMul = 13.43M,
                SYMul = 13.43M,
                SXOff = 695,
                SYOff = 179
            },
            new MapInfo.Map()
            {
                MapName = "m08aa",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Taris - Davik's Estate",
                L = true,
                LXMul = 23.5M,
                LYMul = 23.5M,
                LXOff = 164,
                LYOff = 196
            },
            new MapInfo.Map()
            {
                MapName = "m10aa",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Taris - Black Vulkar Base 1",
                L = true,
                S = true,
                LXMul = 34.78M,
                LYMul = 34.78M,
                LXOff = 3268,
                LYOff = 1473,
                SXMul = 17.39M,
                SYMul = 17.39M,
                SXOff = 1634,
                SYOff = 737
            },
            new MapInfo.Map()
            {
                MapName = "m10ab",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Taris - Black Vulkar Base 2",
                L = true,
                S = true,
                LXMul = 43.88M,
                LYMul = 44M,
                LXOff = 1451,
                LYOff = 2644,
                SXMul = 21.94M,
                SYMul = 21.94M,
                SXOff = 719,
                SYOff = 1320
            },
            new MapInfo.Map()
            {
                MapName = "m10ac",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Taris - Black Vulkar Base 3",
                L = true,
                S = true,
                LXMul = 38.4M,
                LYMul = 38.4M,
                LXOff = 1188,
                LYOff = 1145,
                SXMul = 19.2M,
                SYMul = 19.2M,
                SXOff = 590,
                SYOff = 570
            },
            new MapInfo.Map()
            {
                MapName = "m11aa",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Taris - Hidden Bek Base 1",
                S = true,
                SXMul = 20.1M,
                SYMul = 20.1M,
                SXOff = 432,
                SYOff = 262
            },
            new MapInfo.Map()
            {
                MapName = "m16aa",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Dantooine - Sandral Estate",
                S = true,
                SXMul = 31.91M,
                SYMul = 31.91M,
                SXOff = 446,
                SYOff = 813
            },
            new MapInfo.Map()
            {
                MapName = "m42aa",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Unknown World - Elder Settlement",
                S = true,
                SXMul = 11.66M,
                SYMul = 11.66M,
                SXOff = 93,
                SYOff = 170
            },
            new MapInfo.Map()
            {
                MapName = "m43aa",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Unknown World - Rakatan Settlement",
                S = true,
                SXMul = 10.02M,
                SYMul = 10.02M,
                SXOff = 9,
                SYOff = 114,
                L = true,
                LXMul = 20.06M,
                LYMul = 20.5M,
                LXOff = 50,
                LYOff = 311
            },
            new MapInfo.Map()
            {
                MapName = "151har",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Harbinger - Command Deck",
                S = false,
                SXMul = 16.08M,
                SYMul = 16.08M,
                SXOff = -942,
                SYOff = -838,
                L = true,
                LXMul = 32.62M,
                LYMul = 32.62M,
                LXOff = -135,
                LYOff = 1139
            },
            new MapInfo.Map()
            {
                MapName = "201tel",
                S = true,
                MapAssembler = "T7Nowhere",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Citadel Station Docking Module",
                SXMul = 16.08M,
                SYMul = 16.08M,
                SXOff = -942,
                SYOff = -838,
                L = true,
                LXMul = 32.16M,
                LYMul = 32.16M,
                LXOff = -1884,
                LYOff = -1683
            },
            new MapInfo.Map()
            {
                MapName = "203tel",
                MapAssembler = "T7Nowhere",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Citadel Station Residential 082 East",
                S = true,
                SXMul = 14M,
                SYMul = 14M,
                SXOff = -696,
                SYOff = -752,
                L = true,
                LXMul = 27.98M,
                LYMul = 28.09M,
                LXOff = -1393,
                LYOff = -1505
            },
            new MapInfo.Map()
            {
                MapName = "204tel",
                MapAssembler = "T7Nowhere",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Citadel Station Residential 082 West",
                S = true,
                SXMul = 21.8M,
                SYMul = 21.8M,
                SXOff = -1861,
                SYOff = -1428,
                L = true,
                LXMul = 43.6M,
                LYMul = 43.6M,
                LXOff = -3722,
                LYOff = -2855
            },
            new MapInfo.Map()
            {
                MapName = "207tel",
                MapAssembler = "T7Nowhere",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Citadel Station Cantina",
                S = true,
                SXMul = 33.56M,
                SYMul = 33.56M,
                SXOff = -204,
                SYOff = -1406,
                L = true,
                LXMul = 67M,
                LYMul = 67M,
                LXOff = -408,
                LYOff = -2812
            },
            new MapInfo.Map()
            {
                MapName = "208tel",
                MapAssembler = "T7Nowhere",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Bumani Exchange Corp.",
                S = true,
                SXMul = 19.7M,
                SYMul = 19.7M,
                SXOff = -841,
                SYOff = -253,
                L = true,
                LXMul = 39.46M,
                LYMul = 39.46M,
                LXOff = -1686,
                LYOff = -509
            },
            new MapInfo.Map()
            {
                MapName = "502ond",
                MapAssembler = "Gsccc",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Onderon - Merchant Quarter",
                S = true,
                SXMul = 14.29M,
                SYMul = 14.29M,
                SXOff = -379,
                SYOff = -1521,
                L = true,
                LXMul = 28.6M,
                LYMul = 28.6M,
                LXOff = -757,
                LYOff = -3040
            },
            new MapInfo.Map()
            {
                MapName = "904mal",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Malachor V - Trayus Core",
                S = true,
                SXMul = 12.88M,
                SYMul = 12.88M,
                SXOff = -1603,
                SYOff = -1288,
                L = true,
                LXMul = 25M,
                LYMul = 25M,
                LXOff = -3103,
                LYOff = -2490
            },
            new MapInfo.Map()
            {
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Malachor V - Trayus Proving Grounds",
                MapName = "906mal",
                S = true,
                SXMul = 7.07M,
                SYMul = 7.07M,
                SXOff = 415,
                SYOff = -589,
                L = true,
                LXMul = 28.34M,
                LYMul = 28.36M,
                LXOff = 1669,
                LYOff = -2354
            },
            new MapInfo.Map()
            {
                MapName = "851nih",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Ravager - Command Deck",
                L = true,
                LXMul = 21.2473M,
                LYMul = 21.2747M,
                LXOff = -840,
                LYOff = -1173
            },
            new MapInfo.Map()
            {
                MapName = "101per",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Peragus - Administration Level",
                L = true,
                LXMul = 23.3M,
                LYMul = 23.3M,
                LXOff = -1125,
                LYOff = -3155
            },
            new MapInfo.Map()
            {
                MapName = "102per",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Peragus - Mines",
                L = true,
                LXMul = 21.61355M,
                LYMul = 21.63151M,
                LXOff = -1932,
                LYOff = -2016
            },
            new MapInfo.Map()
            {
                MapName = "503ond",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Onderon - Iziz Cantina",
                S = true,
                SXMul = 16.33915M,
                SYMul = 16.4017M,
                SXOff = 1598,
                SYOff = 1262,
                L = true,
                LXMul = 65.54648M,
                LYMul = 65.67685M,
                LXOff = 6348,
                LYOff = 5060
            },
            new MapInfo.Map()
            {
                MapName = "302nar",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Nar Shaddaa - Refugee Area",
                S = true,
                SXMul = 7.553093M,
                SYMul = 7.559947M,
                SXOff = -645,
                SYOff = 306,
                L = true,
                LXMul = 30.2465M,
                LYMul = 30.23979M,
                LXOff = -2586,
                LYOff = 1226
            },
            new MapInfo.Map()
            {
                MapName = "301nar",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Nar Shaddaa - Refugee Landing Pad",
                L = true,
                LXMul = 28.904M,
                LYMul = 28.8827M,
                LXOff = -4582,
                LYOff = -1818
            },
            new MapInfo.Map()
            {
                MapName = "303nar",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Nar Shaddaa - Docks",
                L = true,
                LXMul = 34.44209M,
                LYMul = 34.43863M,
                LXOff = -3112,
                LYOff = -1843
            },
            new MapInfo.Map()
            {
                MapName = "298tel",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - ???",
                S = true,
                SXMul = 14.33659M,
                SYMul = 14.33602M,
                SXOff = -1390,
                SYOff = 722,
                L = true,
                LXMul = 28.68834M,
                LYMul = 28.68133M,
                LXOff = -2782,
                LYOff = 1447
            },
            new MapInfo.Map()
            {
                MapName = "610dan",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Dantooine - Enclave Sublevel",
                L = true,
                LXMul = 18.0677M,
                LYMul = 18.06721M,
                LXOff = -1408,
                LYOff = -3437
            },
            new MapInfo.Map()
            {
                MapName = "001ebo",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Ebon Hawk - Interior",
                S = true,
                SXMul = 13.0136M,
                SYMul = 12.94298M,
                SXOff = 243,
                SYOff = 83,
                L = true,
                LXMul = 51.45989M,
                LYMul = 51.51605M,
                LXOff = 945,
                LYOff = 317
            },
            new MapInfo.Map()
            {
                MapName = "002ebo",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Ebon Hawk - Exterior",
                S = true,
                SXMul = 20.70314M,
                SYMul = 20.71898M,
                SXOff = -509,
                SYOff = -562,
                L = true,
                LXMul = 41.4488M,
                LYMul = 41.46269M,
                LXOff = -1033,
                LYOff = -1125
            },
            new MapInfo.Map()
            {
                MapName = "103per",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Peragus - Fuel Depot",
                S = true,
                SXMul = 7.28313M,
                SYMul = 7.259841M,
                SXOff = -746,
                SYOff = -528,
                L = true,
                LXMul = 29.09742M,
                LYMul = 29.07998M,
                LXOff = -2987,
                LYOff = -2106
            },
            new MapInfo.Map()
            {
                MapName = "105per",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Peragus - Dormitories",
                S = true,
                SXMul = 8.952945M,
                SYMul = 8.940107M,
                SXOff = -681,
                SYOff = -571,
                L = true,
                LXMul = 35.80223M,
                LYMul = 35.80211M,
                LXOff = -2704,
                LYOff = -2272
            },
            new MapInfo.Map()
            {
                MapName = "401dxn",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Dxun - Jungle Landing",
                S = true,
                SXMul = 7.528076M,
                SYMul = 7.580755M,
                SXOff = -1552,
                SYOff = -1328,
                L = true,
                LXMul = 15.065M,
                LYMul = 15.17198M,
                LXOff = -3106,
                LYOff = -2743
            },
            new MapInfo.Map()
            {
                MapName = "402dxn",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Dxun - Jungle",
                S = true,
                SXMul = 4.062005M,
                SYMul = 4.065509M,
                SXOff = -537,
                SYOff = -464,
                L = true,
                LXMul = 16.26198M,
                LYMul = 16.26204M,
                LXOff = -2151,
                LYOff = -1838
            },
            new MapInfo.Map()
            {
                MapName = "262tel",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Secret Academy",
                S = true,
                SXMul = 14.563M,
                SYMul = 14.42678M,
                SXOff = -1003,
                SYOff = -1984,
                L = true,
                LXMul = 18.01213M,
                LYMul = 17.84771M,
                LXOff = -1241,
                LYOff = -2427
            },
            new MapInfo.Map()
            {
                MapName = "853nih",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Ravager - cutscene",
                S = true,
                SXMul = 9.61601M,
                SYMul = 9.586327M,
                SXOff = -2408,
                SYOff = 100,
                L = true,
                LXMul = 38.50027M,
                LYMul = 38.50385M,
                LXOff = -9673,
                LYOff = 425
            },
            new MapInfo.Map()
            {
                MapName = "106per",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Peragus - Hangar Bay",
                S = true,
                SXMul = 13.735M,
                SYMul = 13.71459M,
                SXOff = -934,
                SYOff = -471,
                L = true,
                LXMul = 27.42084M,
                LYMul = 27.42918M,
                LXOff = -1870,
                LYOff = -932
            },
            new MapInfo.Map()
            {
                MapName = "202tel",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Citadel Station Entertainment 081",
                S = true,
                SXMul = 21.50936M,
                SYMul = 21.51281M,
                SXOff = -891,
                SYOff = -1471,
                L = true,
                LXMul = 43.01873M,
                LYMul = 43.04383M,
                LXOff = -1784,
                LYOff = -2934
            },
            new MapInfo.Map()
            {
                MapName = "231tel",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Restoration Zone",
                S = true,
                SXMul = 5.424731M,
                SYMul = 5.426398M,
                SXOff = 1165,
                SYOff = 901,
                L = true,
                LXMul = 10.85743M,
                LYMul = 10.8528M,
                LXOff = 2333,
                LYOff = 1819
            },
            new MapInfo.Map()
            {
                MapName = "232tel",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Underground Base",
                S = true,
                SXMul = 10.71395M,
                SYMul = 10.72112M,
                SXOff = -1072,
                SYOff = -125,
                L = true,
                LXMul = 21.45145M,
                LYMul = 21.44224M,
                LXOff = -2143,
                LYOff = -250
            },
            new MapInfo.Map()
            {
                MapName = "104per",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Peragus - Asteroid Exterior",
                S = true,
                SXMul = 11.79846M,
                SYMul = 11.78324M,
                SXOff = -635,
                SYOff = -2012,
                L = true,
                LXMul = 47.19384M,
                LYMul = 47.17387M,
                LXOff = -2543,
                LYOff = -8030,
                AltS = true,
                AltSXMul = 37.00609M,
                AltSYMul = 37.00414M,
                AltSXOff = -9,
                AltSYOff = 1058
            },
            new MapInfo.Map()
            {
                MapName = "233tel",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Czerka Site",
                S = true,
                SXMul = 9.043454M,
                SYMul = 9.017874M,
                SXOff = 4060,
                SYOff = 1566,
                L = true,
                LXMul = 18.08691M,
                LYMul = 18.03575M,
                LXOff = 8124,
                LYOff = 3137
            }
        };
        FileStream serializationStream1 = File.Create("MapInfo.bfd");
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(serializationStream1, mi);
        serializationStream1.Close();
        FileStream serializationStream2 = File.Create(InstalledAppPath + "MapInfo.bfd");
        binaryFormatter.Serialize(serializationStream2, mi);
        serializationStream2.Close();
        StreamWriter streamWriter = new StreamWriter(File.Create("maptable.txt"));
        ArrayList arrayList = new ArrayList();
        try
        {
            foreach (MapInfo.Map map in mi.MapList)
            {
                string str1 = map.MapName + "|" + map.ModuleName + "|" + map.MapAssembler + "|";
                string str2 = !map.S ? str1 + "n|" : str1 + "y|";
                string str3 = !map.L ? str2 + "n|" : str2 + "y|";
                arrayList.Add(str3);
            }
        }
        finally
        {
               
        }

        arrayList.Sort();
        try
        {
            foreach (object obj in arrayList)
            {
                string str = StringType.FromObject(obj);
                streamWriter.WriteLine(str);
            }
        }
        finally
        {
               
        }

        streamWriter.Close();
    }
}