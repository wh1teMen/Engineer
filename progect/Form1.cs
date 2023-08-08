using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using progect.DataBase;
using static progect.BaseSetting.ReaderData;
using static progect.BaseSetting.Add;
using static progect.BaseSetting.Update;
using static progect.BaseSetting.CreateBaseSetting;
 using static progect.DataBase.GetSum;
using static progect.BaseSetting.GetCountRows;
using static progect.Global.GlobalParametrs;
using static progect.SettingForms.ViewLable;
using static progect.SettingForms.SettingWindow;
using static progect.ShowMessegeInfo.InfoMessege;


namespace progect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            size(this,325,190);
            CreateBase.CreateBaseIFnot();            
            CreateBaseIFnotSetting();            
            AddFerst();
            ReaderDataClient();
            
        }

        private void button_add_MouseClick(object sender, MouseEventArgs e)
        {
            Add f2=new Add();
            f2.ShowDialog();
        }

        private void button_setting_MouseClick(object sender, MouseEventArgs e)
        {
            FormSetting Fsetting=new FormSetting();
            Fsetting.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InfoMessegeCreateButton(button_add, "Добавление данных\nо выполненной работе");
            InfoMessegeCreateButton(button_show, "Просмотр Данных");
            InfoMessegeCreateButton(button_setting, "Настроика данных\nпо зарплате");
            InfoMessegeCreateCheckBox(checkBox_show, "Показать\\скрыть\nстатистические данные");
            InfoMessegeCreateLable(label_kartridg, "Количесвто заправленных\nкартриджей\nв текущем месяце");
            InfoMessegeCreateLable(label_SumBaraban, "Количесвто замененных барабанов\nв текущем месяце");
            InfoMessegeCreateLable(label_profit, "Зарплата\nв текущем месяце");
        }

        

        private void checkBox1_Click(object sender, EventArgs e)
        {

            if (checkBox_show.Checked)
            {
                RefreshLable(label_SumBaraban, label_kartridg, label_profit);
               
            }
            else
            {
                label_SumBaraban.Text = "*****";
                label_kartridg.Text = "*****";
                label_profit.Text = "*****";

            }

        }

        private void button_show_Click(object sender, EventArgs e)
        {
            FormShow formShow = new FormShow();
            formShow.ShowDialog();
        }
        
    }
}
