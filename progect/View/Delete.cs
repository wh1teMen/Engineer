using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static progect.Global.GlobalParametrs;

namespace progect.View
{
    public class Delete

    {
        public static void Delete_(string NumRemKarta)
        {


            int indexTable = 0;
            indexTable = GetCountTable.CountTable(AlterTableName);
            if (indexTable == 1)
            {
                try
                {
                    var SQL_command_create = $"delete from \"{AlterTableName}\" where RemKarta={int.Parse(NumRemKarta)};";
                    SQLconnect.Open();
                    SQLiteCommand command_create = new SQLiteCommand(SQL_command_create, SQLconnect);
                    command_create.ExecuteNonQuery();
                    SQLconnect.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
            if (indexTable == 0)
            {
                try
                {
                    var SQL_command_create = $"delete from \"{TableName}\" where RemKarta={int.Parse(NumRemKarta)};";
                    SQLconnect.Open();
                    SQLiteCommand command_create = new SQLiteCommand(SQL_command_create, SQLconnect);
                    command_create.ExecuteNonQuery();
                    SQLconnect.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
           
        }
       

    }
}
