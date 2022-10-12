using Microsoft.AspNetCore.Http;
using ServiceStack.Host;


namespace CWE798
{
    public class HardcodedHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext ctx)
        {
            string password = ctx.Request.Query["password"];

            // BAD: Inbound authentication made by comparison to string literal
            if (password == "myPa55word")
            {
                ctx.Response.Redirect("login");
            }

            string hashedPassword = LoadPasswordFromSecretConfig();

            // GOOD: the password is checked
            if (VerifyHashedPassword(hashedPassword, password))
            {
                ctx.Response.Redirect("login");
            }
        }

        public string LoadPasswordFromSecretConfig()
        {
            return null;
        }

        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            // API provided by System.Web.Helpers.Crypto.VerifyHashedPassword
            // but that assembly not available on Mono.
            return true;
        }
    }
}