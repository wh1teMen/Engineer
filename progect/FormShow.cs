using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static progect.Global.GlobalParametrs;
using static progect.View.SettingDataGridView;
using static progect.View.UpdateSave;
using static progect.View.Delete;
using progect.SettingFormsAdd;
using static progect.View.Refresh;
using static progect.View.GetIndexEnum;
using progect.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.WindowsAPICodePack.Dialogs;
using static progect.Exel.GetPath;
using progect.Exel;
using static progect.ShowMessegeInfo.InfoMessege;

namespace progect
{
    public partial class FormShow : Form
    {
        public FormShow()
        {
            InitializeComponent();
            textBox_remcard.KeyPress+= (object sender, KeyPressEventArgs e) => { SettingKey.KeyNumberPress(e); };
            textBox_year.KeyPress+= (object sender, KeyPressEventArgs e) => { SettingKey.KeyNumberPress(e); };
            dataGridView.DataError += new DataGridViewDataErrorEventHandler(DataGridView_DataError);
            AddMonthtoCombobox();
        }

        private void button_refresh_MouseClick(object sender, MouseEventArgs e)
        {
            if(comboBox_month.Text==""&& textBox_year.Text == "")
            {
                AlterTableName=TableName;
            }

            if (comboBox_month.Text != "" && textBox_year.Text != "")
            {
                AlterTableName = CreateNewNameTable.CreateNameTable(comboBox_month, textBox_year);
            }
           
            RefreshDataGrid(dataGridView);
            
          



        }

        private void button_save_MouseClick(object sender, MouseEventArgs e)
        {
            
            Save(dataGridView);            
            RefreshDataGrid(dataGridView);
            MessageBox.Show("Изменения, успешно сохранены");
          
        }
       

        private void button_delete_Click(object sender, EventArgs e)
        {
            Delete_(textBox_remcard.Text);
            RefreshDataGrid(dataGridView);
            MessageBox.Show($"Ремонтная карта: {textBox_remcard.Text}\nУспешно удалена");

        }
        public void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Ошибка ввода!");
            anError.ThrowException = false;
        }
        public void AddMonthtoCombobox()
        {             
            var values = Enum.GetValues(typeof(Month.month));
            foreach (var item in values)
            {
                comboBox_month.Items.Add(item);              
            }
        }


        private void button_Shows_Click(object sender, EventArgs e)
        {
            
            int index=GetIndexEnumSelect(comboBox_month);            
            if (comboBox_month == null & textBox_year.Text == "") { AlterTableName = "00"; }
            else
            {
                AlterTableName = CreateNewNameTable.CreateNameTable(comboBox_month, textBox_year);               
                int ind = GetCountTable.CountTable(AlterTableName);                
                RefreshDataGrid(dataGridView);
            }
          


        }
        private void MessegeInfo()
        {
            InfoMessegeCreateButton(button_delete, "Удаление по номеру ремонтной карты");
            InfoMessegeCreateTextbox(textBox_remcard, "Поле для ввода номера ремонтной карты\nкоторую необходимо удалить");
            InfoMessegeCreateButton(button_refresh, "Обновить данные таблицы");
            InfoMessegeCreateButton(button_save, "Сохранить изменения,\nвнесенные в таблицу");
            InfoMessegeCreateButton(button_folder, "Экспортировать отчет за выбранный период в Exel файл");
            InfoMessegeCreateButton(button_Shows, "Показать данные за выбранный период");
        }

        private void FormShow_Load(object sender, EventArgs e)
        {
            MessegeInfo();
            if (comboBox_month.Text == "" && textBox_year.Text == "")
            {
                button_Shows.Enabled = false;
                button_Shows.Text = "";
            }
          
            textBox_year.KeyPress+=(object senders, KeyPressEventArgs es)=>
            {

                if (textBox_year.Text.Length == 3) { button_Shows.Enabled = true; button_Shows.Text = "ПОКАЗАТЬ"; }
                else { button_Shows.Enabled = false; button_Shows.Text = ""; }
                
            };


          


        }

        private void button_folder_Click(object sender, EventArgs e)
        {

            if (AlterTableName == null) { AlterTableName = TableName; }
            FileName = Path() + "\\" + AlterTableName+".xlsx";
            SaveExel.Save();
            //MessageBox.Show(FileName);
        }
        
    }
}
