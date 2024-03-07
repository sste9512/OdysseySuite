using Kotortool_Legacy.Application.Interfaces;

namespace Kotortool_Legacy.Application.Implementations;

public class BaseApplicationInfo : IApplicationInfo 
{
    public string ProductInfo { get; set; }
    public double ProductVersion { get; set; }
    public string RootPath { get; set; }


    public BaseApplicationInfo()
    {
            ProductInfo = "KotOR Tool";
            ProductVersion = 1.0;
            RootPath = AppDomain.CurrentDomain.BaseDirectory;
        }
}