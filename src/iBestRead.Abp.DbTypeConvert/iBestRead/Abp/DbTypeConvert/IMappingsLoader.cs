namespace iBestRead.Abp.DbTypeConvert
{
    public interface IMappingsLoader
    {
        DbTypeMap Get(DbProviderType dbProviderType);
    }
}