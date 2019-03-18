using System;
using System.Data;

namespace SlurpCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



        }

        public DataTable SlurpFileToDataTable(string fileNameWithPath)
        {

            DataTable dt = new DataTable("SlurpFile");
            dt.Columns.Add("text", typeof(string));

            string line;
            System.IO.StreamReader file =
                new System.IO.StreamReader(fileNameWithPath);
            while ((line = file.ReadLine()) != null)
            {
                dt.Rows.Add(line);
            }
            file.Close();

            return dt;
        }
    }
}
