using progect.Global;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using static progect.Global.GlobalParametrs;

namespace progect.BaseSetting
{
    public class GetCountRows
    {
        //получение количесвта строк в базе данных Setting
        public static int CountID(string nameTable)
        {          
            var cmd_reder = $"select count() from  \"{nameTable}\"";
            SQLconnect.Open();            
            SQLiteCommand command_red = new SQLiteCommand(cmd_reder, SQLconnect);
            int count = 0;
            var rider = command_red.ExecuteScalar();
            count =int.Parse(rider.ToString());
            SQLconnect.Close();
            return count;
        }
    }
}
