using System.Collections;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.API;

public static class ChitinKeyValidators
{
    public static bool IsValid(Hashtable hashtableBiff, int index)
    {
        return index switch
        {
            0 => hashtableBiff.ContainsKey("data\\2da.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\2da.bif"], 431840, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\gui.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\gui.bif"], 1621224, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\items.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\items.bif"], 16362316, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\layouts.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\layouts.bif"], 141915, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\legacy.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\legacy.bif"], 196688, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\lightmaps.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\lightmaps.bif"], 3811348, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\lightmaps10.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\lightmaps10.bif"], 4945347, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\lightmaps11.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\lightmaps11.bif"], 6972364, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\lightmaps12.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\lightmaps12.bif"], 5192454, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\lightmaps13.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\lightmaps13.bif"], 23308504, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\lightmaps2.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\lightmaps2.bif"], 2177180, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\lightmaps3.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\lightmaps3.bif"], 3630567, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\lightmaps4.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\lightmaps4.bif"], 19326133, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\lightmaps5.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\lightmaps5.bif"], 9694141, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\lightmaps6.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\lightmaps6.bif"], 12061343, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\lightmaps7.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\lightmaps7.bif"], 7490884, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\lightmaps8.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\lightmaps8.bif"], 11259740, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\lightmaps9.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\lightmaps9.bif"], 4121097, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\models.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\models.bif"], 954052730, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\party.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\party.bif"], 6862196, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\player.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\player.bif"], 15791965, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\scripts.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\scripts.bif"], 4723499, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\sounds.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\sounds.bif"], 194679056, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\templates.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\templates.bif"], 6259440, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\_newbif.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\_newbif.bif"], 77337, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\textures.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\textures.bif"], 920772, false) == 0,
            1 => hashtableBiff.ContainsKey("data\\2da.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\2da.bif"], 908682, false) == 0 &&
                 !BooleanType.FromObject(BooleanType.FromObject(!hashtableBiff.ContainsKey("data\\dialogs.bif")) ||
                                         BooleanType.FromObject(ObjectType.BitAndObj(
                                             ObjectType.ObjTst(hashtableBiff["data\\dialogs.bif"], 12059157, false) !=
                                             0,
                                             ObjectType.ObjTst(hashtableBiff["data\\dialogs.bif"], 12061533, false) !=
                                             0))
                     ? true
                     : (object)false) && hashtableBiff.ContainsKey("data\\templates.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\templates.bif"], 4255689, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\lightmaps.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\lightmaps.bif"], 91195876, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\models.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\models.bif"], 866238402, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\textures.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\textures.bif"], 592529, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\gui.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\gui.bif"], 3163669, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\layouts.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\layouts.bif"], 153782, false) == 0 &&
                 hashtableBiff.ContainsKey("data\\legacy.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\legacy.bif"], 196688, false) == 0 && !BooleanType.FromObject(
                     BooleanType.FromObject(!hashtableBiff.ContainsKey("data\\scripts.bif")) || BooleanType.FromObject(
                         ObjectType.BitAndObj(
                             ObjectType.ObjTst(hashtableBiff["data\\scripts.bif"], 5412777, false) != 0,
                             ObjectType.ObjTst(hashtableBiff["data\\scripts.bif"], 5415098, false) != 0))
                         ? true
                         : (object)false) && hashtableBiff.ContainsKey("data\\sounds.bif") &&
                 ObjectType.ObjTst(hashtableBiff["data\\sounds.bif"], 259696688, false) == 0,
            _ => false
        };
    }
}