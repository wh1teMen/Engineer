using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static progect.Global.GlobalParametrs;
using static progect.DataBase.GetProfit;
using static progect.DataBase.GetCountRowRemKarta;
using static progect.DataBase.DeleteRow;
using System.Drawing;

namespace progect.DataBase
{
    //Добавление данных о работе
    public  class InsertBD
    {
        public static void Insert_(TextBox remKarta,TextBox kontragent,TextBox scoreKontragent,
            TextBox priceMaterial,TextBox scoreBaraban,TextBox scoreKartridg)
        {         
            DataAddBase dataAddBase = new DataAddBase();
            try
            {
                if (remKarta.Text.Length == 0) { MessageBox.Show("Заполните поле: Ремонтная карта"); return; }
                    else
                    {                    
                        dataAddBase.Remkarta = int.Parse(remKarta.Text);
                        if (kontragent.Text.Length == 0) { MessageBox.Show("Заполните поле: Контрагент"); return; }
                        else
                        {
                            dataAddBase.Kontragent = kontragent.Text;
                                if (scoreKontragent.Text.Length == 0) { MessageBox.Show("Заполните поле: Счет клиенту"); return; }
                                else
                                {
                                    dataAddBase.ScoreKontragent = Math.Round(Convert.ToDecimal(scoreKontragent.Text), 2);
                                    if (priceMaterial.Text.Length == 0) { dataAddBase.ScoreMaterial = 0; }
                                    else
                                    {
                                        dataAddBase.ScoreMaterial = Math.Round(Convert.ToDecimal(priceMaterial.Text), 2);
                                        if (scoreBaraban.Text.Length == 0)
                                        {
                                             dataAddBase.Baraban = 0;                                            
                                              if (scoreKartridg.Text.Length == 0) { MessageBox.Show("Заполните поле: Количесвто картриджей"); return; }
                                                    else
                                                    {
                                                        dataAddBase.ScoreKartridg = int.Parse(scoreKartridg.Text);
                                                    }
                                        }
                                        
                                        if (scoreBaraban.Text.Length > 0)
                                        {
                                            dataAddBase.Baraban = int.Parse(scoreBaraban.Text);
                                            if (scoreKartridg.Text.Length == 0) { MessageBox.Show("Заполните поле: Количесвто картриджей"); return; }
                                                    else
                                                    {
                                                          dataAddBase.ScoreKartridg = int.Parse(scoreKartridg.Text);
                                                    }

                                        }
                                    }
                                }
                        }                            
                    }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ОШИБКА");return; }

            int tmpCountRow = CountRow(dataAddBase.Remkarta);
            if (tmpCountRow == 1)
            {
                
                if(MessageBox.Show($"Работы по ремонтной карте: {dataAddBase.Remkarta} уже заведены!\nЗаменить?",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                {
                    Delete(dataAddBase.Remkarta);
                }
                else
                {
                    return;
                }              
            }

            try
            {
                SQLconnect.Open();
                var cmd_insert_value = $"insert into  \"{TableName}\"" +
                    $"(Day,RemKarta,Kontragent,ScoreKontragent,PriceMaterial,ScoreBaraban,ScoreKartriges,Proc)" +
                    $"values(@Day,@RemKarta,@Kontragent,@ScoreKontragent,@PriceMaterial,@ScoreBaraban,@ScoreKartriges,@Proc)";               
                SQLiteCommand insert = new SQLiteCommand(cmd_insert_value, SQLconnect);
                insert.Parameters.Add(new SQLiteParameter("Day", dataAddBase.Day));
                insert.Parameters.Add(new SQLiteParameter("RemKarta", dataAddBase.Remkarta));
                insert.Parameters.Add(new SQLiteParameter("Kontragent", dataAddBase.Kontragent));
                insert.Parameters.Add(new SQLiteParameter("ScoreKontragent", dataAddBase.ScoreKontragent));
                insert.Parameters.Add(new SQLiteParameter("PriceMaterial", dataAddBase.ScoreMaterial));
                insert.Parameters.Add(new SQLiteParameter("ScoreBaraban", dataAddBase.Baraban));
                insert.Parameters.Add(new SQLiteParameter("ScoreKartriges", dataAddBase.ScoreKartridg));
                insert.Parameters.Add(new SQLiteParameter("Proc",dataAddBase.Proc));
                insert.ExecuteNonQuery();
                SQLconnect.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            MessageBox.Show($" ДОБАВЛЕНО!!!\n с Клиента: {dataAddBase.Kontragent}\nзаработанно:"+
                $"{getProfit(dataAddBase.ScoreKontragent, dataAddBase.ScoreMaterial)} руб.");

        }
    }
}
