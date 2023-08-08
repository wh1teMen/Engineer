using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static progect.Global.GlobalParametrs;
using static progect.View.UpdateSave;
using static progect.View.SettingDataGridView;
using static progect.View.CreateNewNameTable;

namespace progect.View
{
     public class Refresh
    {
        public static void RefreshDataGrid(DataGridView dgw)
        {
            int indexTable = 0;
            indexTable = GetCountTable.CountTable(AlterTableName);
            if (indexTable == 1)
            {
                try
                {
                    SQLconnect.Open();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"select * from \"{AlterTableName}\"", SQLconnect);
                    RefdataAdapter = dataAdapter;
                    DataSet dataset = new DataSet();
                    Refdataset = dataset;
                    dataAdapter.Fill(dataset);
                    dgw.DataSource = dataset.Tables[0];
                    SettingDGW(dgw);
                    SQLconnect.Close();                    
                    return;

                }
                catch (Exception) { MessageBox.Show("Refresh 1"); }             
            }
            if (indexTable == 0)
            {
                MessageBox.Show("Записей по данному запросу не найдено!");
                return;
            }
                try
                {
                    SQLconnect.Open();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"select * from \"{TableName}\"", SQLconnect);
                    RefdataAdapter = dataAdapter;
                    DataSet dataset = new DataSet();
                    Refdataset = dataset;
                    dataAdapter.Fill(dataset);
                    dgw.DataSource = dataset.Tables[0];
                    SettingDGW(dgw);
                    SQLconnect.Close();
                }
                catch (Exception) { MessageBox.Show("Refresh 2"); }
            


        }
    }
}
