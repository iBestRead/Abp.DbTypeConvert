using iBestRead.Database.Consts;
using Volo.Abp;

namespace iBestRead.Abp.DbTypeConvert.Exceptions
{
    public class DbProviderMappingUndefinedException : BusinessException
    {
        public DbProviderMappingUndefinedException(DbProviderType dbProviderType)
            : base("DBTC:000001", $"{dbProviderType.ToString()} mapping is not defined.")
        {

        }
    }
}