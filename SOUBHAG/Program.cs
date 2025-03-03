using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SOUBHAG
{
    public class Program
    {
        
            public static void Main(string[] args)
            {
                var host = CreateWebHostBuilder(args).Build();
                host.Run();
            }

            public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                    .UseStartup<Startup>()
                    .UseUrls("http://*:8054"); // Listen on all IPs (localhost & external)
        }
    }
