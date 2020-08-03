
namespace iBestRead.Abp.DbTypeConvert
{
    public interface IDbTypeConvert
    {
        /// <summary>
        /// Convert 
        /// 指定数据库字段类型=>指定语言的类型.
        /// eg:
        /// SqlServer varchar  => csharp string
        /// SqlServer uniqueidentifier => csharp guid
        /// 详细映射参见 /Mappings/*.json
        /// </summary>
        /// <param name="dbProviderType">数据库类型</param>
        /// <param name="targetLanguage">指定的语言类型</param>
        /// <param name="dbColumnType">数据库字段类型</param>
        /// <returns>与之对应的语言的类型</returns>
        string ToLanguageType(DbProviderType dbProviderType, LanguageType targetLanguage, string dbColumnType);
        
        /// <summary>
        /// Convert 
        /// 指定数据库字段类型=>指定语言的类型.
        /// eg:
        /// SqlServer varchar  => csharp string
        /// SqlServer uniqueidentifier => csharp guid
        /// 详细映射参见 /Mappings/*.json
        /// </summary>
        /// <param name="dbProviderType">数据库类型</param>
        /// <param name="targetLanguage">指定的语言类型</param>
        /// <param name="dbColumnType">数据库字段类型</param>
        /// <returns>与之对应的语言的类型</returns>
        string ToLanguageType(string dbProviderType, LanguageType targetLanguage, string dbColumnType);
    }
}