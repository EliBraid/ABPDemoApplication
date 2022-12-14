namespace ABPInterceptorDemo.Interceptor;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class LogAttribute: Attribute
{
    public LogAttribute()
    {
        
    }
}