using Shouldly;
using Volo.Abp.Testing;
using Xunit;

namespace iBestRead.Abp.DbTypeConvert.Tests.iBestRead.Abp.DbTypeConvert
{
    public class MappingsLoader_Tests : AbpIntegratedTest<AbpDbTypeConvertTestModule>
    {
        private readonly IMappingsLoader _mappingsLoader;
        public MappingsLoader_Tests()
        {
            _mappingsLoader = GetRequiredService<IMappingsLoader>();
        }
        
        [Fact]
        public void Can_Get_SqlServer_Mapping()
        {
            var result = _mappingsLoader.Get(DbProvider.SqlServer);
        
            result.ShouldNotBeNull();
        }
        
    }
}