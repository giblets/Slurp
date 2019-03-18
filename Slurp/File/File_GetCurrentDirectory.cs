using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString File_GetCurrentDirectory(SqlString FullDirecotryPath)
    {
        // Put your code here
        string curDir = Path.GetDirectoryName(FullDirecotryPath.ToString());

        return new SqlString (curDir);
    }
}
