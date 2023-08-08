using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using static progect.Global.GlobalParametrs;
using static progect.Exel.ReaderFromBase;
using Microsoft.Office.Interop.Excel;
using static progect.DataBase.GetSum;


namespace progect.Exel
{
    internal class SaveExel
    {
        public static void Save()
        {
            List<ImportBase> list = new List<ImportBase>();
            try
            {
                
                Reder(list);               
                var excel = new Excel.Application();
                var workBooks = excel.Workbooks;
                var workBook = workBooks.Add();
                var workSheet = (Excel.Worksheet)excel.ActiveSheet;        
                workSheet.Columns.ColumnWidth =12;              
                int sumBaraban = 0;
                int sumKartridg = 0;
                workSheet.Cells[1, "A"] = "День";
                workSheet.Cells[ 1, "B"] = "Ремонтная\nкарта";
                workSheet.Cells[ 1, "C"] = "Контрагент";
                workSheet.Cells[ 1, "D"] = "Счет\nклиенту";
                workSheet.Cells[ 1, "E"] = "Стоимость\nматериалов";
                workSheet.Cells[ 1, "F"] = "Количесвто\nбарабанов";
                workSheet.Cells[ 1, "G"] = "Количесвто\nкартриджей";
                workSheet.Cells[ 1, "H"] = "Прибыль";
                workSheet.Cells[1, "J"] = "Барабаны";
                workSheet.Cells[1, "K"] = "Всего\nКартриджей";
                workSheet.Cells[1, "L"] = "Зарплата";
                workSheet.Cells[1, "M"] = "На руки";

                for (int i = 0; i < list.Count; i++)
                {
                    workSheet.Cells[i+2 , "A"] = list[i].Day.ToString();
                    workSheet.Cells[i + 2, "B"] = list[i].RemKarta.ToString();
                    workSheet.Cells[i + 2, "C"] = list[i].Kontragent.ToString();
                    workSheet.Cells[i + 2, "D"] = list[i].ScoreKontragent.ToString();
                    workSheet.Cells[i + 2, "E"] = list[i].ScoreMaterial.ToString();
                    workSheet.Cells[i + 2, "F"] = list[i].Baraban.ToString();
                    workSheet.Cells[i + 2, "G"] = list[i].ScoreKartridg.ToString();                  
                    workSheet.Cells[i + 2, "H"] = list[i].Profit.ToString();                  
                    sumBaraban += list[i].Baraban;
                    sumKartridg += list[i].ScoreKartridg;
                }
                workSheet.Cells[2, "J"] = sumBaraban.ToString();
                workSheet.Cells[2, "K"] = sumKartridg.ToString();
                workSheet.Cells[2, "L"] = (SumSave("Profit", AlterTableName)).ToString();
                workSheet.Cells[2, "M"] = ((SumSave("Profit", AlterTableName))-
                    (double.Parse(dataClient.Salary.ToString())-(double.Parse(dataClient.Salary.ToString())
                    * (double.Parse(dataClient.IncomeTax.ToString()) / 100)))).ToString();
               workBook.SaveAs(FileName);              
               workBook.Close();
                MessageBox.Show("Экспортирование прошло успешно");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }
    }
}
