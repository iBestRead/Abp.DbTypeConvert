using iBestRead.Database.Consts;
using Shouldly;
using Volo.Abp.Testing;
using Xunit;

namespace iBestRead.Abp.DbTypeConvert
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
            var result = _mappingsLoader.Get(DbProviderType.SqlServer);
        
            result.ShouldNotBeNull();
        }
        
        [Fact]
        public void Can_Get_MySql_Mapping()
        {
            var result = _mappingsLoader.Get(DbProviderType.MySql);
        
            result.ShouldNotBeNull();
        }
    }
}