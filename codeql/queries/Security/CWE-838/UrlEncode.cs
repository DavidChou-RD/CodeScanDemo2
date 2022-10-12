using System;
using System.Web;
using System.Net;
using Microsoft.AspNetCore.Http;

public class UrlEncode
{
    public static void Bad(string value, HttpContext ctx)
    {
        var user = WebUtility.UrlDecode(ctx.Request.Query["user"]);
        ctx.Response.Redirect("?param=" + WebUtility.HtmlEncode(user));
    }

    public static void Good(string value, HttpContext ctx)
    {
        var user = WebUtility.UrlDecode(ctx.Request.Query["user"]);
        ctx.Response.Redirect("?param=" + WebUtility.UrlEncode(user));
    }
}
