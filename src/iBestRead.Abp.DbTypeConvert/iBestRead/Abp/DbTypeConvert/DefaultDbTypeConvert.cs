using System;
using System.Linq;
using iBestRead.Abp.DbTypeConvert.Exceptions;
using Volo.Abp;
using Volo.Abp.DependencyInjection;

namespace iBestRead.Abp.DbTypeConvert
{
    public class DefaultDbTypeConvert : IDbTypeConvert, ISingletonDependency
    {
        private readonly IMappingsLoader _mappingsLoader;

        public DefaultDbTypeConvert(IMappingsLoader mappingsLoader)
        {
            _mappingsLoader = mappingsLoader;
        }

        public string ToLanguageType(DbProviderType dbProviderType, LanguageType targetLanguage, string dbColumnType)
        {
            Check.NotNullOrEmpty(dbColumnType, nameof(dbColumnType));

            var providerMapping = _mappingsLoader.Get(dbProviderType);
            if (null == providerMapping)
                throw new DbProviderMappingUndefinedException(dbProviderType);

            var columnMapping = providerMapping.Columns
                .FirstOrDefault(e => e.Source == dbColumnType);

            if (null == columnMapping)
                throw new DbColumnTypeMappingUndefinedException(dbColumnType);

            var languageTypeMapping = columnMapping.Targets
                .FirstOrDefault(e => e.Language == targetLanguage.ToString());

            if (null == languageTypeMapping)
                throw new ColumnTypeLanguageMappingUndefinedException(targetLanguage, dbColumnType);

            return languageTypeMapping.TypeName;

        }

        public string ToLanguageType(string dbProviderType, LanguageType targetLanguage, string dbColumnType)
        {
            var canParse = Enum.TryParse<DbProviderType>(dbProviderType, out var providerType);

            if (!canParse)
                throw new DbProviderUnsupportedException(dbProviderType);
            return ToLanguageType(providerType, targetLanguage, dbColumnType);
        }
        
        
    }
}