using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace RestaurantAPI.Authorization
{
    public class MinimumAgeRequirementHandler : AuthorizationHandler<MinimumAgeRequirement>
    {
        private readonly ILogger<MinimumAgeRequirementHandler> _loger;

        public MinimumAgeRequirementHandler(ILogger<MinimumAgeRequirementHandler> loger)
        {
            _loger = loger;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimumAgeRequirement requirement)
        {
            var dateOfBirth = DateTime.Parse(context.User.FindFirst(c => c.Type == "DateOfBirth").Value);

            var userEmail = context.User.FindFirst(c => c.Type == ClaimTypes.Name).Value;

            _loger.LogInformation($"User: {userEmail} with date of birth: [{dateOfBirth}]");

            if (dateOfBirth.AddYears(requirement.MinimumAge) <= DateTime.Today)
            {
                _loger.LogInformation("Authorization succedded");
                context.Succeed(requirement);
            }
            else
            {
                _loger.LogInformation("Authorization failed");
            }

            return Task.CompletedTask;
        }
    }
}
