using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace RazorPagesMovie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Host = CreateWebHostBuilder(args).Build();
            Host.Run();
            Host.WaitForShutdown();
            int x = 343;
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
