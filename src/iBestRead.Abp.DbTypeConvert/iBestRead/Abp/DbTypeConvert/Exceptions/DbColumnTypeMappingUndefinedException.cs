using Volo.Abp;

namespace iBestRead.Abp.DbTypeConvert.Exceptions
{
    public class DbColumnTypeMappingUndefinedException : BusinessException
    {
        public DbColumnTypeMappingUndefinedException(string dbColumnTypeName)
            : base("DBTC:000002", $"column type {dbColumnTypeName} mapping is not defined.")
        {

        }
    }
}