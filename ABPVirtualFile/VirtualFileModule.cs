using System.Reflection;
using ABPVirtualFile.Demo;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ABPVirtualFile
{
    [DependsOn(typeof(AbpAutofacModule))]
    [DependsOn(typeof(AbpVirtualFileSystemModule))]
    public class VirtualFileModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddScoped<Execuce>();
            Configure<AbpVirtualFileSystemOptions>(opt =>
            {
                opt.FileSets.AddEmbedded<VirtualFileModule>(
                    baseNamespace: typeof(VirtualFileModule).Namespace
                    );
            });
            Console.WriteLine("加载虚拟文件");
        }
    }

}


