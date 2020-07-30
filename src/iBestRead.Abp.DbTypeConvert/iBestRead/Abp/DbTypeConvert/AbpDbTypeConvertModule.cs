using Volo.Abp.Json;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace iBestRead.Abp.DbTypeConvert
{
    [DependsOn(
        typeof(AbpVirtualFileSystemModule),
        typeof(AbpJsonModule)
        )]
    public class AbpDbTypeConvertModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AbpDbTypeConvertModule>();
            });
        }
    }
}