
using ABPVirtualFile;
using ABPVirtualFile.Demo;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ABPVirtualFile
{
    class Program
    {
        public static void Main(string[] args)
        {
            var build = Host.CreateApplicationBuilder();
            build.Services.AddApplication<VirtualFileModule>();
            using (var provider = build.Services.BuildServiceProvider())
            {
                var ex = provider.GetService<Execuce>();
                ex.PrintfFile();
            }
        }
    }
// var app = build.Build();
//
// app.Run();

}

