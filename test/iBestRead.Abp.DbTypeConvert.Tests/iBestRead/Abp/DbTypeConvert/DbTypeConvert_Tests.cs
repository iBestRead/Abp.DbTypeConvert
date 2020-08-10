using iBestRead.Abp.DbTypeConvert.Exceptions;
using Shouldly;
using Volo.Abp.Testing;
using Xunit;

namespace iBestRead.Abp.DbTypeConvert
{
    public class DbTypeConvert_Tests: AbpIntegratedTest<AbpDbTypeConvertTestModule>
    {
        
        private readonly IDbTypeConvert _dbTypeConvert;
        public DbTypeConvert_Tests()
        {
            _dbTypeConvert = GetRequiredService<IDbTypeConvert>();
        }
        
        [Theory]
        [InlineData("sql_variant")]
        [InlineData("hierarchyid")]
        [InlineData("geometry")]
        [InlineData("geography")]
        public void Undefined_ColumnType_Throw_Exception(string dbColumnType)
        {
            Should.Throw<DbColumnTypeMappingUndefinedException>(() =>
                _dbTypeConvert.ToCSharpType(DbProviderType.SqlServer, dbColumnType));
        }
        
        [Theory]
        [InlineData("varbinary", "byte[]")]
        [InlineData("text", "string")]
        [InlineData("uniqueidentifier", "Guid")]
        [InlineData("smalldatetime", "DateTime")]
        [InlineData("int", "int")]
        public void SqlServer_To_CSharp(string dbColumnType, string languageType)
        {
            var result = _dbTypeConvert.ToCSharpType(DbProviderType.SqlServer, dbColumnType);
            result.ShouldBe(languageType);
        }
        
        [Theory]
        [InlineData("text", "STRING")]
        [InlineData("uniqueidentifier", "STRING")]
        [InlineData("smalldatetime", "DATETIME")]
        [InlineData("timestamp", "BINARY")]
        [InlineData("int", "BIGINT")]
        public void SqlServer_To_MaxCompute(string dbColumnType, string languageType)
        {
            var result = _dbTypeConvert.ToMaxComputeType(DbProviderType.SqlServer, dbColumnType);
            result.ShouldBe(languageType);
        }
        
        [Theory]
        [InlineData("text", "STRING")]
        [InlineData("uniqueidentifier", "STRING")]
        [InlineData("smalldatetime", "DATETIME")]
        [InlineData("timestamp", "BINARY")]
        [InlineData("int", "BIGINT")]
        public void Convert_By_DbProviderTypeName(string dbColumnType, string languageType)
        {
            var result = _dbTypeConvert.ToMaxComputeType("SqlServer", dbColumnType);
            result.ShouldBe(languageType);
        }
                
        [Theory]
        [InlineData("varbinary", "byte[]")]
        [InlineData("text", "string")]
        [InlineData("uniqueidentifier", "Guid")]
        [InlineData("smalldatetime", "DateTime")]
        [InlineData("int", "int")]
        public void MySql_To_CSharp(string dbColumnType, string languageType)
        {
            var result = _dbTypeConvert.ToCSharpType(DbProviderType.MySql, dbColumnType);
            result.ShouldBe(languageType);
        }
        
        [Theory]
        [InlineData("text", "STRING")]
        [InlineData("uniqueidentifier", "STRING")]
        [InlineData("smalldatetime", "DATETIME")]
        [InlineData("timestamp", "BINARY")]
        [InlineData("int", "BIGINT")]
        public void MySql_To_MaxCompute(string dbColumnType, string languageType)
        {
            var result = _dbTypeConvert.ToMaxComputeType(DbProviderType.MySql, dbColumnType);
            result.ShouldBe(languageType);
        }
    }
}