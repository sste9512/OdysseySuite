namespace OdysseyStudio.Server.Application.Infrastructure;

public abstract class EndpointGroupBase
{
    //private WebApplication _app = null!;
    public abstract void Map(WebApplication app);
    
    /*public void OnMap(WebApplication app)
    {
        _app = app;
        Map(app);
    }*/
}
