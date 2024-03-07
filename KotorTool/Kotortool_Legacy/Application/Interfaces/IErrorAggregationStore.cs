namespace Kotortool_Legacy.Application.Interfaces;

public interface IErrorAggregationStore
{
    void AddError(string error, Exception exception, string[] reasons);
    void ClearErrors();
}