using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.Infrastructure.View.MainForm;

public static class Identification
{
    public static short GetIdForRsrcType(string type)
    {
        var sLeft = type;
        if (StringType.StrCmp(sLeft, "res", false) == 0)
            return 0;
        if (StringType.StrCmp(sLeft, "bmp", false) == 0)
            return 1;
        if (StringType.StrCmp(sLeft, "mve", false) == 0)
            return 2;
        if (StringType.StrCmp(sLeft, "tga", false) == 0)
            return 3;
        if (StringType.StrCmp(sLeft, "wav", false) == 0)
            return 4;
        if (StringType.StrCmp(sLeft, "plt", false) == 0)
            return 6;
        if (StringType.StrCmp(sLeft, "ini", false) == 0)
            return 7;
        if (StringType.StrCmp(sLeft, "mp3", false) == 0)
            return 8;
        if (StringType.StrCmp(sLeft, "mpg", false) == 0)
            return 9;
        if (StringType.StrCmp(sLeft, "txt", false) == 0)
            return 10;
        if (StringType.StrCmp(sLeft, "wma", false) == 0)
            return 11;
        if (StringType.StrCmp(sLeft, "wmv", false) == 0)
            return 12;
        if (StringType.StrCmp(sLeft, "xmv", false) == 0)
            return 13;
        if (StringType.StrCmp(sLeft, "plh", false) == 0)
            return 2000;
        if (StringType.StrCmp(sLeft, "tex", false) == 0)
            return 2001;
        if (StringType.StrCmp(sLeft, "mdl", false) == 0)
            return 2002;
        if (StringType.StrCmp(sLeft, "thg", false) == 0)
            return 2003;
        if (StringType.StrCmp(sLeft, "fnt", false) == 0)
            return 2005;
        if (StringType.StrCmp(sLeft, "lua", false) == 0)
            return 2007;
        if (StringType.StrCmp(sLeft, "slt", false) == 0)
            return 2008;
        if (StringType.StrCmp(sLeft, "nss", false) == 0)
            return 2009;
        if (StringType.StrCmp(sLeft, "ncs", false) == 0)
            return 2010;
        if (StringType.StrCmp(sLeft, "mod", false) == 0)
            return 2011;
        if (StringType.StrCmp(sLeft, "are", false) == 0)
            return 2012;
        if (StringType.StrCmp(sLeft, "set", false) == 0)
            return 2013;
        if (StringType.StrCmp(sLeft, "ifo", false) == 0)
            return 2014;
        if (StringType.StrCmp(sLeft, "bic", false) == 0)
            return 2015;
        if (StringType.StrCmp(sLeft, "wok", false) == 0)
            return 2016;
        if (StringType.StrCmp(sLeft, "2da", false) == 0)
            return 2017;
        if (StringType.StrCmp(sLeft, "tlk", false) == 0)
            return 2018;
        if (StringType.StrCmp(sLeft, "txi", false) == 0)
            return 2022;
        if (StringType.StrCmp(sLeft, "git", false) == 0)
            return 2023;
        if (StringType.StrCmp(sLeft, "bti", false) == 0)
            return 2024;
        if (StringType.StrCmp(sLeft, "uti", false) == 0)
            return 2025;
        if (StringType.StrCmp(sLeft, "btc", false) == 0)
            return 2026;
        if (StringType.StrCmp(sLeft, "utc", false) == 0)
            return 2027;
        if (StringType.StrCmp(sLeft, "dlg", false) == 0)
            return 2029;
        if (StringType.StrCmp(sLeft, "itp", false) == 0)
            return 2030;
        if (StringType.StrCmp(sLeft, "btt", false) == 0)
            return 2031;
        if (StringType.StrCmp(sLeft, "utt", false) == 0)
            return 2032;
        if (StringType.StrCmp(sLeft, "dds", false) == 0)
            return 2033;
        if (StringType.StrCmp(sLeft, "bts", false) == 0)
            return 2034;
        if (StringType.StrCmp(sLeft, "uts", false) == 0)
            return 2035;
        if (StringType.StrCmp(sLeft, "ltr", false) == 0)
            return 2036;
        if (StringType.StrCmp(sLeft, "gff", false) == 0)
            return 2037;
        if (StringType.StrCmp(sLeft, "fac", false) == 0)
            return 2038;
        if (StringType.StrCmp(sLeft, "bts", false) == 0)
            return 2039;
        if (StringType.StrCmp(sLeft, "ute", false) == 0)
            return 2040;
        if (StringType.StrCmp(sLeft, "btd", false) == 0)
            return 2041;
        if (StringType.StrCmp(sLeft, "utd", false) == 0)
            return 2042;
        if (StringType.StrCmp(sLeft, "btp", false) == 0)
            return 2043;
        if (StringType.StrCmp(sLeft, "utp", false) == 0)
            return 2044;
        if (StringType.StrCmp(sLeft, "dft", false) == 0)
            return 2045;
        if (StringType.StrCmp(sLeft, "gic", false) == 0)
            return 2046;
        if (StringType.StrCmp(sLeft, "gui", false) == 0)
            return 2047;
        if (StringType.StrCmp(sLeft, "css", false) == 0)
            return 2048;
        if (StringType.StrCmp(sLeft, "ccs", false) == 0)
            return 2049;
        if (StringType.StrCmp(sLeft, "btm", false) == 0)
            return 2050;
        if (StringType.StrCmp(sLeft, "utm", false) == 0)
            return 2051;
        if (StringType.StrCmp(sLeft, "dwk", false) == 0)
            return 2052;
        if (StringType.StrCmp(sLeft, "pwk", false) == 0)
            return 2053;
        if (StringType.StrCmp(sLeft, "btg", false) == 0)
            return 2054;
        if (StringType.StrCmp(sLeft, "utg", false) == 0)
            return 2055;
        if (StringType.StrCmp(sLeft, "jrl", false) == 0)
            return 2056;
        if (StringType.StrCmp(sLeft, "sav", false) == 0)
            return 2057;
        if (StringType.StrCmp(sLeft, "utw", false) == 0)
            return 2058;
        if (StringType.StrCmp(sLeft, "4pc", false) == 0)
            return 2059;
        if (StringType.StrCmp(sLeft, "ssf", false) == 0)
            return 2060;
        if (StringType.StrCmp(sLeft, "hak", false) == 0)
            return 2061;
        if (StringType.StrCmp(sLeft, "nwm", false) == 0)
            return 2062;
        if (StringType.StrCmp(sLeft, "bik", false) == 0)
            return 2063;
        if (StringType.StrCmp(sLeft, "ndb", false) == 0)
            return 2064;
        if (StringType.StrCmp(sLeft, "ptm", false) == 0)
            return 2065;
        if (StringType.StrCmp(sLeft, "ptt", false) == 0)
            return 2066;
        if (StringType.StrCmp(sLeft, "lyt", false) == 0)
            return 3000;
        if (StringType.StrCmp(sLeft, "vis", false) == 0)
            return 3001;
        if (StringType.StrCmp(sLeft, "rim", false) == 0)
            return 3002;
        if (StringType.StrCmp(sLeft, "pth", false) == 0)
            return 3003;
        if (StringType.StrCmp(sLeft, "lip", false) == 0)
            return 3004;
        if (StringType.StrCmp(sLeft, "bwm", false) == 0)
            return 3005;
        if (StringType.StrCmp(sLeft, "txb", false) == 0)
            return 3006;
        if (StringType.StrCmp(sLeft, "tpc", false) == 0)
            return 3007;
        if (StringType.StrCmp(sLeft, "mdx", false) == 0)
            return 3008;
        if (StringType.StrCmp(sLeft, "rsv", false) == 0)
            return 3009;
        if (StringType.StrCmp(sLeft, "sig", false) == 0)
            return 3010;
        if (StringType.StrCmp(sLeft, "xbx", false) == 0)
            return 3011;
        if (StringType.StrCmp(sLeft, "erf", false) == 0)
            return 9997;
        if (StringType.StrCmp(sLeft, "bif", false) == 0)
            return 9998;
        return StringType.StrCmp(sLeft, "key", false) == 0 ? (short)9999 : (short)-1;
    }

    public static string GetRsrcTypeForId(int id)
    {
        return id switch
        {
            0 => "res",
            1 => "bmp",
            2 => "mve",
            3 => "tga",
            4 => "wav",
            6 => "plt",
            7 => "ini",
            8 => "mp3",
            9 => "mpg",
            10 => "txt",
            11 => "wma",
            12 => "wmv",
            13 => "xmv",
            2000 => "plh",
            2001 => "tex",
            2002 => "mdl",
            2003 => "thg",
            2005 => "fnt",
            2007 => "lua",
            2008 => "slt",
            2009 => "nss",
            2010 => "ncs",
            2011 => "mod",
            2012 => "are",
            2013 => "set",
            2014 => "ifo",
            2015 => "bic",
            2016 => "wok",
            2017 => "2da",
            2018 => "tlk",
            2022 => "txi",
            2023 => "git",
            2024 => "bti",
            2025 => "uti",
            2026 => "btc",
            2027 => "utc",
            2029 => "dlg",
            2030 => "itp",
            2031 => "btt",
            2032 => "utt",
            2033 => "dds",
            2034 => "bts",
            2035 => "uts",
            2036 => "ltr",
            2037 => "gff",
            2038 => "fac",
            2039 => "bts",
            2040 => "ute",
            2041 => "btd",
            2042 => "utd",
            2043 => "btp",
            2044 => "utp",
            2045 => "dft",
            2046 => "gic",
            2047 => "gui",
            2048 => "css",
            2049 => "ccs",
            2050 => "btm",
            2051 => "utm",
            2052 => "dwk",
            2053 => "pwk",
            2054 => "btg",
            2055 => "utg",
            2056 => "jrl",
            2057 => "sav",
            2058 => "utw",
            2059 => "4pc",
            2060 => "ssf",
            2061 => "hak",
            2062 => "nwm",
            2063 => "bik",
            2064 => "ndb",
            2065 => "ptm",
            2066 => "ptt",
            3000 => "lyt",
            3001 => "vis",
            3002 => "rim",
            3003 => "pth",
            3004 => "lip",
            3005 => "bwm",
            3006 => "txb",
            3007 => "tpc",
            3008 => "mdx",
            3009 => "rsv",
            3010 => "sig",
            3011 => "xbx",
            9997 => "erf",
            9998 => "bif",
            9999 => "key",
            _ => "Unk (" + StringType.FromInteger(id) + ")"
        };
    }
}