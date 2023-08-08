using progect.Global;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static progect.Global.GlobalParametrs;
using static progect.SettingForms.ViewLable;



namespace progect.BaseSetting
{
     public class Update
    {
        public static void UpdateSetting(TextBox persent,TextBox salary,TextBox incomeTax)
        {
            string dataname = "Setting";
            //dataClient = new DataClient();
            try
            {
                if (persent.Text.Length == 0) { MessageBox.Show("Заполните поле: Процент ЗП"); return; }
                else
                {
                    dataClient.Persent=int.Parse(persent.Text);
                    if (salary.Text.Length == 0) { MessageBox.Show("Заполните поле:Окладная часть"); return; }
                    else
                    {
                        dataClient.Salary=int.Parse(salary.Text);
                        if (incomeTax.Text.Length == 0) { MessageBox.Show("Заполните поле: Подоходный налог"); return; }
                        else
                        {
                            dataClient.IncomeTax=int.Parse(incomeTax.Text);
                        } 
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ОШИБКА"); return; }
            if (persent != null && salary != null && incomeTax != null)
            {
                try
                {
                    SQLconnect.Open();
                    var SQLCommand_update = $"update \"{dataname}\"" +
                        $" set Persent={dataClient.Persent}," +
                        $"Salary={dataClient.Salary}," +
                        $"IncomeTax={dataClient.IncomeTax} where id=1";
                    SQLiteCommand command = new SQLiteCommand(SQLCommand_update, SQLconnect);
                    command.ExecuteNonQuery();
                    SQLconnect.Close();
                    MessageBox.Show("Изменения прошли успешно");

                }
                catch (Exception ex) { MessageBox.Show(ex.Message);return; }

            }
            

        }
    }
}
