namespace Authentication.Infrastructure.Attributes
{
    public class AuthorizeAttribute
    {
        [System.AttributeUsage(System.AttributeTargets.Class |System.AttributeTargets.Method)]

        public class AuthorizedAttribute:
            System.Attribute, Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter
        {
            public AuthorizedAttribute():base() { }

            public void onAuthorization(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context)
            {
                var user = context.HttpContext.Items["user"] as Models.User;

                if (user == null)
                {
                    context.Result = new Microsoft.AspNetCore.Mvc.JsonResult(new { message = "Uuauthorized" })
                    {
                        StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status401Unauthorized,
                    };
                }
            }
        }
    }
}
