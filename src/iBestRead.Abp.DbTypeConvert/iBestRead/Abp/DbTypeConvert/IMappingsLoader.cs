using iBestRead.Database.Consts;

namespace iBestRead.Abp.DbTypeConvert
{
    public interface IMappingsLoader
    {
        DbTypeMap Get(DbProviderType dbProviderType);
    }
}