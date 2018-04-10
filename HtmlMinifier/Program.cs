using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace HtmlMinifier
{
    public class Program
    {
        public static void Main(string[] args) => BuildWebHost(args).Run();

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .UseUrls("http://localhost:4990")
                   .UseStartup<Startup>()
                   .Build();
    }
}