using Microsoft.AspNetCore.Authorization;

namespace RestaurantAPI.Authorization
{
    public enum ResourseOperation
    {
        Create,
        Read,
        Update,
        Delete
    }
    public class ResourseOperationRequirement : IAuthorizationRequirement
    {
        public ResourseOperationRequirement(ResourseOperation resourseOperation)
        {
            ResourseOperation = resourseOperation;
        }

        public ResourseOperation ResourseOperation { get; }
    }
}
