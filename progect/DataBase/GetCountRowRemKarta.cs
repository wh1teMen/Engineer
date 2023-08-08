using progect.Global;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using static progect.Global.GlobalParametrs;

namespace progect.DataBase
{
    public class GetCountRowRemKarta
    {
        
        public static int CountRow(int NumremKarta)
        {            
            var cmd_reder = $"select count() from  \"{TableName}\" where RemKarta={NumremKarta}";
            SQLconnect.Open();
            SQLiteCommand command_red = new SQLiteCommand(cmd_reder, SQLconnect);
            int count = 0;
            var rider = command_red.ExecuteScalar();
            count= int.Parse(rider.ToString());           
            SQLconnect.Close();
            return count;
        }
    }
}
