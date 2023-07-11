using Microsoft.AspNetCore.Authorization;
using RestaurantAPI.Entities;
using System.Security.Claims;

namespace RestaurantAPI.Authorization
{
    public class ResourseOperationRequirementHandler : AuthorizationHandler<ResourseOperationRequirement, Restaurant>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ResourseOperationRequirement requirement, Restaurant restaurant)
        {
            if (requirement.ResourseOperation == ResourseOperation.Read ||
                requirement.ResourseOperation == ResourseOperation.Create) 
            {
                context.Succeed(requirement);
            }

            var userId = context.User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier).Value;
            if(restaurant.CreatedById == int.Parse(userId))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
