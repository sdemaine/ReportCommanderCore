﻿using Microsoft.AspNetCore.Http;
using ReportCommander.Infrastructure;

namespace ReportCommander.Application;

public static class HttpHelper
{
    private static IHttpContextAccessor _accessor;
    
    public static void Configure(IHttpContextAccessor httpContextAccessor)
    {
        _accessor = httpContextAccessor;
    }

    public static HttpContext HttpContext => _accessor.HttpContext;
}