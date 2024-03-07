namespace Kotortool_Legacy.Application.Interfaces;

public interface IApplicationInfo
{
    string ProductInfo { get; set; }
    double ProductVersion { get; set; }
          
    string RootPath { get; set; }
}