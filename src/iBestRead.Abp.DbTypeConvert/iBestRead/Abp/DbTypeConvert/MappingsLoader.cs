using System;
using System.Collections.Concurrent;
using Microsoft.Extensions.FileProviders;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Json;
using Volo.Abp.VirtualFileSystem;

namespace iBestRead.Abp.DbTypeConvert
{
    public class MappingsLoader : IMappingsLoader, ISingletonDependency
    {
        private readonly ConcurrentDictionary<DbProviderType, DbTypeMap> _mappings;
        
        private readonly IVirtualFileProvider _virtualFileProvider;
        private readonly IJsonSerializer _jsonSerializer;
        
        public MappingsLoader(
            IVirtualFileProvider virtualFileProvider, 
            IJsonSerializer jsonSerializer)
        {
            _virtualFileProvider = virtualFileProvider;
            _jsonSerializer = jsonSerializer;
            _mappings = new ConcurrentDictionary<DbProviderType, DbTypeMap>();
            Initial();
        }

        private void Initial()
        {
            var jsons = _virtualFileProvider
                .GetDirectoryContents("/iBestRead/Abp/DbTypeConvert/Mappings");

            foreach (var json in jsons)
            {
                var jsonContent = json.ReadAsString();
                var mapping = _jsonSerializer.Deserialize<DbTypeMap>(jsonContent);
                if(null == mapping)
                    continue;

                _mappings.TryAdd(mapping.DbProviderType, mapping);
            }
        }
        
        public DbTypeMap Get(DbProviderType dbProviderType)
        {
            _mappings.TryGetValue(dbProviderType, out var dbTypeMap);

            return dbTypeMap;
        }
    }
}