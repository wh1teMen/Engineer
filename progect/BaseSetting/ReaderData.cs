using progect.Global;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using static progect.Global.GlobalParametrs;
using static progect.BaseSetting.GetCountRows;
using System.Windows.Forms;

namespace progect.BaseSetting
{
    public class ReaderData
    {
        //метод считывает данные о ЗП из БД Setting, если они  default=1 просит внести даныне,
        //если нет создает глобальные экземпляр Dataclient 
        public static void ReaderDataClient()
        {
            
            string dataname = "Setting";
            try
            {
                SQLconnect.Open();
                var cmd_reder = $"select Persent,Salary,IncomeTax from  \"{dataname}\"";
                SQLiteCommand command_red = new SQLiteCommand(cmd_reder, SQLconnect);
                var rider = command_red.ExecuteReader();
                if (rider.HasRows)
                {
                    while (rider.Read())
                    {
                        dataClient.Persent = int.Parse(rider[0].ToString());
                        dataClient.Salary = int.Parse(rider[1].ToString());
                        dataClient.IncomeTax = int.Parse(rider[2].ToString());
                    }
                }
                SQLconnect.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            if (dataClient.Persent==1 && dataClient.Salary==1 && dataClient.IncomeTax == 1)
            {
                MessageBox.Show("Заполните данные о Зарплате\n Настройки->");
            }



        }
        

    }
}
