namespace IdentityService.API.Model.Authentication
{
    public class TenantOperationClaims:Entity
    {
        public int TenantId { get; set; }

        public int OperationClaimId { get; set; }
    }
}
