using progect.Global;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using static progect.Global.GlobalParametrs;

namespace progect.DataBase
{
    public class DeleteRow
    {
        public static void Delete(int NumremKarta)
        {
            var cmd_deliteRow = $"delete from  \"{TableName}\" where  RemKarta={NumremKarta};";
            SQLconnect.Open();
            SQLiteCommand command_del = new SQLiteCommand(cmd_deliteRow, SQLconnect);
            command_del.ExecuteNonQuery();
            SQLconnect.Close();
           
        }
    }
}
