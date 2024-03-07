namespace Kotortool_Legacy.API.AuroraParsers
{
    static class Global
    {

        public static Games Game = Games.KOTOR;

        public enum Games
        {
            KOTOR = 1,
            KOTOR2 = 2
        }

        public enum TexturePacks
        {
            TEXTURE_GUI = 0,
            TEXTURE_HIGH = 1,
            TEXTURE_MEDIUM = 2,
            TEXTURE_LOW = 3
        }

    }
}
