using Microsoft.SqlServer.Server;
using progect.BaseSetting;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static progect.Global.GlobalParametrs;

namespace progect.Exel
{
    public class ReaderFromBase
    {
        public static List<ImportBase> Reder(List<ImportBase> list)
        {
           
            try
            {                           

                SQLconnect.Open();
                var cmd_reder = $"select Day,RemKarta,Kontragent,ScoreKontragent,PriceMaterial,ScoreBaraban,ScoreKartriges,Profit from  \"{AlterTableName}\"";
                SQLiteCommand command_red = new SQLiteCommand(cmd_reder, SQLconnect);
                var rider = command_red.ExecuteReader();
                if (rider.HasRows)
                {
                    while (rider.Read())
                    {
                        var tmp = new ImportBase() {

                            Day = int.Parse(rider[0].ToString()),
                            RemKarta = int.Parse(rider[1].ToString()),
                            Kontragent = rider[2].ToString(),
                            ScoreKontragent = Convert.ToDecimal(rider[3].ToString()),
                            ScoreMaterial = Convert.ToDecimal(rider[4].ToString()),
                            Baraban = int.Parse(rider[5].ToString()),
                            ScoreKartridg = int.Parse(rider[6].ToString()),                            
                            Profit = rider[7].ToString()
                        };
                        list.Add(tmp);  
                    };
                       
                }
                
                SQLconnect.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }      
           return list;
        }
    }
}
