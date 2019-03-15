using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void File_GetDirectoryListing()
    {
        // Create a record object that represents an individual row, including it's metadata.
        SqlDataRecord record = new SqlDataRecord(new SqlMetaData("stringcol", SqlDbType.NVarChar, 128));

        // Populate the record.
        record.SetSqlString(0, "Hello World!");

        // Send the record to the client.
        SqlContext.Pipe.Send(record);
    }

}


