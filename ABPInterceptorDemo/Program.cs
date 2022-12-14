// See https://aka.ms/new-console-template for more information
using ABPInterceptorDemo;
using ABPInterceptorDemo.Interceptor;
using Microsoft.Extensions.DependencyInjection;

namespace ABPInterceptorDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            var build =  new ServiceCollection();
            build.AddApplication<ABPInterceptorDemoModule>();

            using (var provider = build.BuildServiceProvider())
            {
                var run = provider.GetService<Test>();
                var ok = provider.GetService<Email>();
                
                run.Show();
                run.Show2();
            }
        }
    }
}




