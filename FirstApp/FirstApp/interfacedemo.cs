using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    //interface will have definitions for methods,properties,events,indexer
    interface   DataAccess
    {
        string ReadData(string connectionName);
        string WriteData(string connectionName);
        int DataConnection { get; set; }
    }
    class SQLDataAccess : DataAccess
    {
        public int DataConnection { get; set; }

        public string ReadData(string connectionName)
        {
            Console.WriteLine("Reading data from SQL Server");
            return "SQL Data";
        }

        public void WriteData(string connectionName)
        {
            Console.WriteLine("Writing data to SQL Server");
        }
    }
    class interfacedemo
    {
        static void Main(string[] args)
        {
            SQLDataAccess access = new SQLDataAccess();
            access.ReadData("sql");
            access.WriteData("sql");
        }
    }
}
