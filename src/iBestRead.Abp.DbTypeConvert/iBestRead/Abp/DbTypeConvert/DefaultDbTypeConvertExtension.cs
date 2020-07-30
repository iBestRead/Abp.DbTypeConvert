namespace iBestRead.Abp.DbTypeConvert
{
    public static class DefaultDbTypeConvertExtension
    {
        public static string ToMaxComputeType(
            this IDbTypeConvert dbTypeConvert, 
            DbProvider dbProvider,
            string dbColumnType)
        {
            return dbTypeConvert.ToLanguageType(dbProvider, LanguageType.MaxCompute, dbColumnType);
        }

        public static string ToCSharpType(
            this IDbTypeConvert dbTypeConvert, 
            DbProvider dbProvider, 
            string dbColumnType)
        {
            return dbTypeConvert.ToLanguageType(dbProvider, LanguageType.CSharp, dbColumnType);
        }
    }
}