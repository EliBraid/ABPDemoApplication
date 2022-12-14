using ABPInterceptorDemo.Interceptor;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;

namespace ABPInterceptorDemo;

[Dependency(ServiceLifetime.Transient)]
public class Test
{
    public Test()
    {
        Console.WriteLine("Test");
    }
    [Log]
    public void Show()
    {
        Console.WriteLine("开始喽");
    }
    
    public void Show2()
    {
        Console.WriteLine("再次开始喽");
    }
}