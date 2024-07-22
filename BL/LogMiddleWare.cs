using Microsoft.AspNetCore.Http;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class LogMiddleWare
    {
        private readonly RequestDelegate _next;
        private static int counterPost = 0;
        private static int counterPut = 0;
        private static int counterDelete = 0;
        private static int counterGet = 0;
        public LogMiddleWare(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Method == HttpMethods.Post)
            {
                counterPost++;
                Log.Information($"POST request made {counterPost} times.");
            }
            else if (context.Request.Method == HttpMethods.Put)
            {
                counterPut++;
                Log.Information($"PUT request made {counterPut} times.");
            }
            else if (context.Request.Method == HttpMethods.Delete)
            {
                counterDelete++;
                Log.Information($"DELETE request made {counterDelete} times.");
            }
            else if (context.Request.Method == HttpMethods.Get)
            {
                counterGet++;
                Log.Information($"GET request made {counterGet} times.");
            }
            await _next(context);
        }
    }
}
