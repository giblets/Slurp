using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.IO;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlByte File_FolderExists(SqlString FullDirecotryPath)
    {
        SqlByte _bReturn = 1;
        bool _boolReturn;
        _boolReturn = Directory.Exists(Convert.ToString(FullDirecotryPath));
        if (_boolReturn)
        {
            _bReturn = 1;
        }
        else
        {
            _bReturn = 0;
            //SqlContext.Pipe.Send(" was NOT found");
        }
        return _bReturn;
    }

    //[Microsoft.SqlServer.Server.SqlFunction(DataAccess = DataAccessKind.Read)]
    //public static SqlString File_FolderExists(SqlString FullDirecotryPath)
    //{
    //    return FullDirecotryPath.ToString();
    //}
}
