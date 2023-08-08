using progect.Global;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using static progect.Global.GlobalParametrs;

namespace progect.DataBase
{
    public class GetSum
    {
        public static int Sum(string titleColumn)
        {
            int sum = 0;
            try
            {
                var cmd_reder = $"select sum({titleColumn}) from  \"{TableName}\"";
                SQLconnect.Open();
                SQLiteCommand command_red = new SQLiteCommand(cmd_reder, SQLconnect);
                var rider = command_red.ExecuteScalar();
                sum = int.Parse(rider.ToString());               
                SQLconnect.Close();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            return sum;
        }

        public static double SumDouble(string titleColumn)
        {
            double sum = 0;
            try
            {
                var cmd_reder = $"select sum({titleColumn}) from  \"{TableName}\"";
                SQLconnect.Open();
                SQLiteCommand command_red = new SQLiteCommand(cmd_reder, SQLconnect);
                var rider = command_red.ExecuteScalar();
                sum = Convert.ToDouble(rider);                
                SQLconnect.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return sum;
        }

        public static double SumSave(string titleColumn,string nametable)
        {
           
            double sum = 0.0;
            try
            {
                var cmd_reder = $"select sum({titleColumn}) from  \"{nametable}\"";
                SQLconnect.Open();                
                SQLiteCommand command_red = new SQLiteCommand(cmd_reder, SQLconnect);
                var rider = command_red.ExecuteScalar();
                sum = Convert.ToDouble(rider);               
                SQLconnect.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return sum;
        }
    }
}
