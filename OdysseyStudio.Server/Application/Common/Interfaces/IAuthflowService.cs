namespace OdysseyStudio.Server.Application.Common.Interfaces;

public interface IAuthflowService
{
     public Task<AuthorizationFlowType> FindFlowTypeAsync(string flowTypeName);
     
     
}

public sealed class AuthFlowService /*: IAuthflowService*/
{
    
    private readonly IApplicationDbContext _applicationDbContext;

   
    public AuthFlowService(IApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    /*public  Task<AuthorizationFlowType> FindFlowTypeAsync(string flowTypeName)
    {
         
          //var policy = await _applicationDbContext.AuthenticationEnforcementPolicies.FirstOrDefault()!;
            
          
        
    }*/
}
