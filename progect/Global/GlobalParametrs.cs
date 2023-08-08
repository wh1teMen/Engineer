using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using progect.BaseSetting;

namespace progect.Global
{
    public static class GlobalParametrs
    {
        public static string BaseName= "DataBase.db";
        public static SQLiteConnection SQLconnect = new SQLiteConnection(string.Format("Data Source={0};",BaseName));
        public static DataClient dataClient = new DataClient();
        public static string TableName = (DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString());
        public static string AlterTableName;
        public static DataSet Refdataset = new DataSet();
        public static SQLiteDataAdapter RefdataAdapter;
        public static string FileName;
    }
}
