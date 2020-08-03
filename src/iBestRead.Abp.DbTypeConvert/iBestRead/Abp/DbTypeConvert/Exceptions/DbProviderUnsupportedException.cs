using Volo.Abp;

namespace iBestRead.Abp.DbTypeConvert.Exceptions
{
    public class DbProviderUnsupportedException : BusinessException
    {
        public DbProviderUnsupportedException(string dbProviderType)
            : base("DBTC:000004", $"{dbProviderType} is not unsupported.")
        {

        }
    }
}