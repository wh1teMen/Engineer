using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace progect.View
{
    public class SettingDataGridView
    {
        public static void SettingDGW(DataGridView dgw)
        {
            dgw.RowHeadersVisible = false;
            dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgw.AllowUserToAddRows = false;
            dgw.Columns[0].Visible = false;
            dgw.Columns[1].Width = 40;
            dgw.Columns[1].HeaderText = "День";
            dgw.Columns[2].HeaderText = "Номер\nРем.Карты";      
            dgw.Columns[3].HeaderText = "Контрагент";           
            dgw.Columns[4].HeaderText = "Счет\nконтрагенту";      
            dgw.Columns[5].HeaderText = "Цена\nМатериалов";
            dgw.Columns[6].HeaderText = "Колич-во\nБарабанов";
            dgw.Columns[7].HeaderText = "Колич-во\nКартриджей";
            dgw.Columns[8].HeaderText = "Процент по\nзарплате";
            dgw.Columns[9].HeaderText = "Прибыль";


            dgw.Columns[1].ToolTipText = "День";
            dgw.Columns[2].ToolTipText = "Номер\nремонтной карты";
            dgw.Columns[3].ToolTipText = "Контрагент";
            dgw.Columns[4].ToolTipText = "Счет\nконтрагенту";
            dgw.Columns[5].ToolTipText = "Цена материалов";
            dgw.Columns[6].ToolTipText = "Количесвто\nфотобарабанов";
            dgw.Columns[7].ToolTipText = "Количесвто\nкартриджей";
            dgw.Columns[8].ToolTipText = "Процент\nпо зарплате";
            dgw.Columns[9].ToolTipText = "Прибыль\nс клиента";
            dgw.Refresh();

        }
    }
}
