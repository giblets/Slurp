using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString SqlFunction1()
    {
        // Put your code here
        //List<SqlString> retList = new List<SqlString>();
        //retList.Add("one");
        //retList.Add("two");
        //retList.Add("three");

        //return retList;

        return new SqlString("");
    }
}
