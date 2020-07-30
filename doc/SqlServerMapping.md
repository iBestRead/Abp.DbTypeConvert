# SqlServer映射

[json映射文件](../src/iBestRead.Abp.DbTypeConvert/iBestRead/Abp/DbTypeConvert/Mappings/SqlServer.json)

| Source           | CSharp         | MaxCompute |
| ---------------- | -------------- | ---------- |
| image            | byte[]         | BINARY     |
| binary           | byte[]         | -          |
| varbinary        | byte[]         | -          |
| text             | string         | STRING     |
| ntext            | string         | STRING     |
| varchar          | string         | STRING     |
| nvarchar         | string         | STRING     |
| varchar2         | string         | STRING     |
| nvarchar2        | string         | STRING     |
| xml              | string         | STRING     |
| uniqueidentifier | Guid           | STRING     |
| date             | DateTime       | DATETIME   |
| smalldatetime    | DateTime       | DATETIME   |
| datetime         | DateTime       | DATETIME   |
| datetime2        | DateTime       | DATETIME   |
| time             | TimeSpan       | -          |
| datetimeoffset   | DateTimeOffset | -          |
| tinyint          | byte           | TINYINT    |
| smallint         | short          | SMALLINT   |
| int              | int            | INT        |
| bigint           | long           | BIGINT     |
| bit              | bool           | BOOLEAN    |
| char             | string         | STRING     |
| nchar            | string         | STRING     |
| uniqueide        | Guid           | STRING     |
| numeric          | decimal        | DECIMAL    |
| integer          | int            | INT        |
| money            | decimal        | DECIMAL    |
| real             | float          | FLOAT      |
| blob             | byte[]         | -          |
| single           | float          | FLOAT      |
| smallmoney       | decimal        | DECIMAL    |
| decimal          | decimal        | DECIMAL    |
| bfile            | byte[]         | -          |
| float            | double         | DOUBLE     |
| binary           | byte[]         | -          |
| number           | decimal        | DECIMAL    |
| varbinary        | byte[]         | -          |
| boolean          | bool           | BOOLEAN    |
| longtext         | string         | STRING     |
| timestamp        | DateTime       | BINARY     |