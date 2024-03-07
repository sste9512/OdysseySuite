namespace Kotortool_Legacy.API.AuroraParsers
{
    static class Utility
    {

        public static AuroraFile.ResourceTypes[] AsCollection()
        {
            return Enum.GetValues(typeof(AuroraFile.ResourceTypes))
                .Cast<AuroraFile.ResourceTypes>()
                .ToArray();
        }

        public static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        public static double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        public static float Clamp(float value, float min, float max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

    }
}
