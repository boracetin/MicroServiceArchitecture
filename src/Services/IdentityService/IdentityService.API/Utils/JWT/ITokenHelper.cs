using IdentityService.API.Model.Authentication;

namespace IdentityService.API.Utils.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(Tenant tenant,List<OperationClaims> operationClaims);
    }
}
