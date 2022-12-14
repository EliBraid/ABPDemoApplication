using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Volo.Abp.DependencyInjection;
using Volo.Abp.VirtualFileSystem;

namespace ABPVirtualFile.Demo;

public class Execuce
{
    private readonly IVirtualFileProvider _virtualFileProvider;

    public Execuce(IVirtualFileProvider virtualFileProvider)
    {
        _virtualFileProvider = virtualFileProvider;
        Console.WriteLine("加载文件");
    }

    public void PrintfFile()
    {
        Console.WriteLine("输出");

        var file = _virtualFileProvider.GetFileInfo("/File/test.txt");
        Console.WriteLine(file.Name);
        Console.WriteLine(file.Exists);

        Console.WriteLine(file.ReadAsString());
    }
}