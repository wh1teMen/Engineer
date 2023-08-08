using progect.Global;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using static progect.Global.GlobalParametrs;

namespace progect.BaseSetting
{
    public class CreateBaseSetting
    {
        //Создание БД Setting
        public static void CreateBaseIFnotSetting()
        {
            string dataname = "Setting";
            var SQL_command_create = $"CREATE TABLE IF NOT EXISTS \"{dataname}\"" +
                $" (id INTEGER PRIMARY KEY   UNIQUE," +
                $" Persent INTEGER," +
                $" Salary INTEGER," +
                $" IncomeTax INTEGER);";
            SQLconnect.Open();
            SQLiteCommand command_create = new SQLiteCommand(SQL_command_create,SQLconnect);
            command_create.ExecuteNonQuery();
            SQLconnect.Close();
        }
    }
        
}
