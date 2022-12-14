using ABPInterceptorDemo.Interceptor;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Auditing;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ABPInterceptorDemo;
[DependsOn(typeof(AbpAutofacModule))]
[DependsOn(typeof(AbpAuditingModule))]
public class ABPInterceptorDemoModule: AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.OnRegistred(opt =>
        {
            if(opt.ImplementationType.IsDefined(typeof(LogAttribute),true))
                opt.Interceptors.Add<Email>();
        });
    }
}