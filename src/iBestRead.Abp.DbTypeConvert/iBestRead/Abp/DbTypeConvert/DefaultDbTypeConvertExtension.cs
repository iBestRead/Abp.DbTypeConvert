namespace iBestRead.Abp.DbTypeConvert
{
    public static class DefaultDbTypeConvertExtension
    {
        public static string ToMaxComputeType(
            this IDbTypeConvert dbTypeConvert, 
            DbProviderType dbProviderType,
            string dbColumnType)
        {
            return dbTypeConvert.ToLanguageType(dbProviderType, LanguageType.MaxCompute, dbColumnType);
        }

        public static string ToMaxComputeType(
            this IDbTypeConvert dbTypeConvert, 
            string dbProviderType,
            string dbColumnType)
        {
            return dbTypeConvert.ToLanguageType(dbProviderType, LanguageType.MaxCompute, dbColumnType);
        }
        
        public static string ToCSharpType(
            this IDbTypeConvert dbTypeConvert, 
            DbProviderType dbProviderType, 
            string dbColumnType)
        {
            return dbTypeConvert.ToLanguageType(dbProviderType, LanguageType.CSharp, dbColumnType);
        }
        
        public static string ToCSharpType(
            this IDbTypeConvert dbTypeConvert, 
            string dbProviderType, 
            string dbColumnType)
        {
            return dbTypeConvert.ToLanguageType(dbProviderType, LanguageType.CSharp, dbColumnType);
        }
    }
}