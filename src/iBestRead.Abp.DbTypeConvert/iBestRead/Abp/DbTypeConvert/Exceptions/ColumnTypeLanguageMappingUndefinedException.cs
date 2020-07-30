using Volo.Abp;

namespace iBestRead.Abp.DbTypeConvert.Exceptions
{
    public class ColumnTypeLanguageMappingUndefinedException : BusinessException
    {
        public ColumnTypeLanguageMappingUndefinedException(
            LanguageType language,
            string dbColumnTypeName
            )
            : base("DBTC:000003", $"column type {dbColumnTypeName} map to {language.ToString()} is not defined.")
        {

        }
    }
}