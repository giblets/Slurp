using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{

    [Microsoft.SqlServer.Server.SqlFunction(
        IsDeterministic = false,
           DataAccess = DataAccessKind.None,
        TableDefinition = "filename nvarchar(256), size int",
        FillRowMethodName = "GetTempValues_fill"
        )]
    public static System.Collections.IEnumerable File_GetDirectoryListing2()
    {

        var dt = new DataTable();

        DataColumn col1 = new DataColumn("filename");
        col1.DataType = System.Type.GetType("System.String");
        dt.Columns.Add(col1);

        DataColumn col2 = new DataColumn("size");
        col2.DataType = System.Type.GetType("System.Int32");
        dt.Columns.Add(col2);

        DataRow myNewRow = dt.NewRow();
        myNewRow["filename"] = "Item Name";
        myNewRow["size"] = 2147483647;
        dt.Rows.Add(myNewRow);

        DataRow myNewRow2 = dt.NewRow();
        myNewRow2["filename"] = "MyFile";
        myNewRow2["size"] = 111;
        dt.Rows.Add(myNewRow2);

        //var adapter = new SqlDataAdapter();
        //adapter.Fill(dt);

        return dt.Rows;

        // Put your code here
        //List<string> mylist = new List<string>();
        //mylist.Add("one");
        //mylist.Add("two");
        //mylist.Add("three");

        //SqlContext.Pipe.SendResultsEnd();
        //return mylist;
        //return new SqlString (string.Empty);
    }

    public static void GetTempValues_fill(
        object o,
        out SqlString col1,
        out SqlInt32 col2)
    {
        var dr = (DataRow)o;
        col1 = new SqlString((string)dr[0]);
        col2 = new SqlInt32((int)dr[1]);
    }
}
