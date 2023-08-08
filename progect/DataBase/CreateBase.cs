using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using progect.Global;
using static progect.Global.GlobalParametrs;

namespace progect.DataBase
{  
    public class CreateBase
        {           
            //Метод создает Базу данных если ее нету
            public static void CreateBaseIFnot()
            {                
                var SQL_command_create = $"CREATE TABLE IF NOT EXISTS \"{TableName}\"" +
                    $" (id INTEGER PRIMARY KEY   UNIQUE," +
                    $" Day INTEGER," +
                    $" RemKarta INTEGER," +
                    $" Kontragent VARCHAR (1, 100) NOT NULL," +
                    $" ScoreKontragent DECIMAL(1,100)," +
                    $"PriceMaterial DECIMAL," +
                    $"ScoreBaraban INTEGER," +
                    $"ScoreKartriges INTEGER," +               
                    $"Proc DOUBLE,"+
                    $"Profit varchar(1,100) as (ROUND(((ScoreKontragent-PriceMaterial)*Proc),2)));";
                    SQLconnect.Open();
                    SQLiteCommand command_create = new SQLiteCommand(SQL_command_create, SQLconnect);
                    command_create.ExecuteNonQuery();
                    SQLconnect.Close();            
            }    
        }
    
}
