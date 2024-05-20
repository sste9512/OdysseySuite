using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using kotor_tool.API.AuroraParsers;

namespace KotOR_Files
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
