using System.Collections.Generic;
using iBestRead.Database.Consts;

namespace iBestRead.Abp.DbTypeConvert
{
    public class DbTypeMap
    {
        public DbProviderType DbProviderType { get; set; }

        public List<Column> Columns { get; set; }

        public DbTypeMap()
        {
            Columns = new List<Column>();
        }
    }

    public class Target
    {
        public string Language { get; set; }
        public string TypeName { get; set; }
    }

    public class Column
    {
        public string Source { get; set; }
        public List<Target> Targets { get; set; }

        public Column()
        {
            Targets = new List<Target>();
        }
    }
}