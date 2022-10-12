using System;
using System.Web;
using System.Net;
using Microsoft.AspNetCore.Http;

namespace CWE838
{
    public class HtmlEncode
    {
        public static void Bad(HttpContext ctx)
        {
            var user = WebUtility.UrlDecode(ctx.Request.Query["user"]);
            ctx.Response.WriteAsync("Hello, " + WebUtility.UrlEncode(user));
        }

        public static void Good(HttpContext ctx)
        {
            var user = WebUtility.UrlDecode(ctx.Request.Query["user"]);
            ctx.Response.WriteAsync("Hello, " + WebUtility.HtmlEncode(user));
        }
    }
}
