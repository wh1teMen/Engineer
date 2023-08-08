using progect.Global;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static progect.Global.GlobalParametrs;
using static progect.BaseSetting.GetCountRows;

namespace progect.BaseSetting
{
    public  class Add
    {
        //метод для добавления изначальных значений в базу данных Setting
        public static void AddFerst()
        {
            if (CountID("Setting") == 0)
            {
                string dataname = "Setting";
                try
                {
                   SQLconnect.Open();
                    var cmd_insert_value = $"insert into  \"{dataname}\"(Persent,Salary,IncomeTax)values(@Persent,@Salary,@IncomeTax)";
                    SQLiteCommand insert = new SQLiteCommand(cmd_insert_value, SQLconnect);
                    insert.Parameters.Add(new SQLiteParameter("Persent", 1));
                    insert.Parameters.Add(new SQLiteParameter("Salary", 1));
                    insert.Parameters.Add(new SQLiteParameter("IncomeTax",1));                   
                    insert.ExecuteNonQuery();
                    SQLconnect.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

        }
    }
}
