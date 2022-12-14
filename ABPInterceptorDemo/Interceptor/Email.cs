
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;
using Volo.Abp.DynamicProxy;

namespace ABPInterceptorDemo.Interceptor;

[Dependency(ServiceLifetime.Transient)]
public class Email: AbpInterceptor
{
    public Email()
    {
        Console.WriteLine("创建成功");
    }
    public async override Task InterceptAsync(IAbpMethodInvocation invocation)
    {
        Console.WriteLine("动态代理启动");
        
        await invocation.ProceedAsync();
        
        Console.WriteLine("日志服务启动");
    }
}