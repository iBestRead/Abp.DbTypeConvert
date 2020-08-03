# Abp VNext 数据库字段类型转换 模块

[![Build](https://github.com/iBestRead/Abp.DbTypeConvert/workflows/Build/badge.svg)](https://github.com/iBestRead/Abp.DbTypeConvert/actions?query=workflow%3A%22Build%22)
[![NuGetVersion](https://img.shields.io/nuget/v/iBestRead.Abp.DbTypeConvert)](https://www.nuget.org/packages/iBestRead.Abp.DbTypeConvert)
[![NuGet Download](https://img.shields.io/nuget/dt/iBestRead.Abp.DbTypeConvert.svg)](https://www.nuget.org/packages/iBestRead.Abp.DbTypeConvert)

# Type Mapping

- [ ] [SqlServer](doc/SqlServerMapping.md)
	- [x] To CSharp
	- [x] To MaxCompute
	- [ ] To PostgreSql
	- [ ] To MySql
- [ ] MySql
	- [ ] To CSharp
- [ ] Oracle
	- [ ] To CSharp
- [ ] PostgreSql
	- [ ] To CSharp
- [ ] Sqlitle
	- [ ] To CSharp




# 安装Nuget包

```shell
dotnet add package iBestRead.Abp.DbTypeConvert
```

# 使用

引用模块

```csharp
[DependsOn(typeof(AbpDbTypeConvertModule))]
public class DbTypeConvertTestModule : AbpModule
{
  
}
```

注入服务

```csharp
private readonly IDbTypeConvert _dbTypeConvert;
public YourApplicationService(IDbTypeConvert dbTypeConvert)
{
    _dbTypeConvert = dbTypeConvert;
}

public void SqlServer_To_CSharp()
{
		_dbTypeConvert.ToCSharpType(DbProvider.SqlServer, "varbinary"); // byte[]
		_dbTypeConvert.ToCSharpType(DbProvider.SqlServer, "text"); // string
		_dbTypeConvert.ToCSharpType(DbProvider.SqlServer, "uniqueidentifier"); // Guid
  	_dbTypeConvert.ToCSharpType(DbProvider.SqlServer, "smalldatetime"); // DateTime
  	_dbTypeConvert.ToCSharpType(DbProvider.SqlServer, "int"); // int
    // ...
}

public void SqlServer_To_MaxCompute()
{
    _dbTypeConvert.ToMaxComputeType(DbProvider.SqlServer, "varbinary"); // BINARY
    _dbTypeConvert.ToMaxComputeType(DbProvider.SqlServer, "text"); // STRING
    _dbTypeConvert.ToMaxComputeType(DbProvider.SqlServer, "uniqueidentifier"); // STRING
    _dbTypeConvert.ToMaxComputeType(DbProvider.SqlServer, "smalldatetime"); // DATETIME
    _dbTypeConvert.ToMaxComputeType(DbProvider.SqlServer, "int"); // INT
    // ...  
}

```



# 更多

请参考[单元测试](test/iBestRead.Abp.DbTypeConvert.Tests/iBestRead/Abp/DbTypeConvert)



