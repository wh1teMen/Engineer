using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using static progect.Global.GlobalParametrs; 

namespace progect.View
{
    internal class GetCountTable
    {
        public static int CountTable (string nametable)
        {
            var cmd_reder = $"SELECT count() FROM sqlite_master WHERE type='table' AND name=\"{nametable}\";";
            SQLconnect.Open();
            SQLiteCommand command_red = new SQLiteCommand(cmd_reder, SQLconnect);
            int count = 0;
            var rider = command_red.ExecuteScalar();
            count = Convert.ToInt32(rider);
            SQLconnect.Close();
            return count;
        }
    }
}
