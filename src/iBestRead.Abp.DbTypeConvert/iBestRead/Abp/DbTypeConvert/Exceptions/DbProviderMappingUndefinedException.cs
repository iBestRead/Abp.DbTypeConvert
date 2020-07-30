using Volo.Abp;

namespace iBestRead.Abp.DbTypeConvert.Exceptions
{
    public class DbProviderMappingUndefinedException : BusinessException
    {
        public DbProviderMappingUndefinedException(DbProvider dbProvider)
            : base("DBTC:000001", $"{dbProvider.ToString()} mapping is not defined.")
        {

        }
    }
}