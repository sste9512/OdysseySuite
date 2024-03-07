using System.Reflection;

namespace Kotortool_Legacy.Infrastructure.View.MainForm;

public static class InjectionExtensions
{
    public static T GetPrivateProperty<T>(this object obj, string propertyName)
    {
        return (T) obj.GetType()
            .GetProperty(propertyName, BindingFlags.Instance | BindingFlags.NonPublic)
            .GetValue(obj);
    }

    public static void SetPrivateProperty<T>(this object obj, string propertyName, T value)
    {
        obj.GetType()
            .GetProperty(propertyName, BindingFlags.Instance | BindingFlags.NonPublic)
            .SetValue(obj, value);
    }
    
    public static bool HasProperty(this object obj, string propertyName)
    {
        return obj.GetType().GetProperty(propertyName) != null;
    }
}