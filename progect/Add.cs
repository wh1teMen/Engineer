using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using progect.SettingFormsAdd;
using static progect.DataBase.InsertBD;
using static progect.ShowMessegeInfo.InfoMessege;
using static progect.Global.GlobalParametrs;


namespace progect
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            Key();
        }
        //Метод с настройкой полей ввода Формы "Add.cs"
        private void Key()
        {
            textBox_NumRemKarta.KeyPress += (object sender, KeyPressEventArgs e) => { SettingKey.KeyNumberPress(e);};
            textBox_ScoreKontrAgent.KeyPress+= (object sender, KeyPressEventArgs e) => { SettingKey.KeyNumberPress(e);};
            textBox_priseOfMaterials.KeyPress+= (object sender, KeyPressEventArgs e) => { SettingKey.KeyNumberPress(e);};
            textBox_ScoreBaraban.KeyPress+= (object sender, KeyPressEventArgs e) => { SettingKey.KeyNumberPress(e); };
            textBox_ScoreKartridg.KeyPress+= (object sender, KeyPressEventArgs e) => { SettingKey.KeyNumberPress(e); };
        }

        private void button_addRemKarta_MouseClick(object sender, MouseEventArgs e)
        {
            Insert_(textBox_NumRemKarta,textBox_KontrAgent,textBox_ScoreKontrAgent,textBox_priseOfMaterials,textBox_ScoreBaraban,textBox_ScoreKartridg);
        }

        private void Add_Load(object sender, EventArgs e)
        {
            InfoMessegeCreateTextbox(textBox_NumRemKarta, "Поле для ввода\nномера ремонтной краты");
            InfoMessegeCreateTextbox(textBox_KontrAgent, "Поле для ввода\nназвания контрагента");
            InfoMessegeCreateTextbox(textBox_ScoreKontrAgent, "Поле для ввода\nсчёта клиенту");
            InfoMessegeCreateTextbox(textBox_priseOfMaterials, "Поле для ввода\nсуммы за потраченные материалы");
            InfoMessegeCreateTextbox(textBox_ScoreBaraban, "Поле для ввода\nколичества потраченных барабанов");
            InfoMessegeCreateTextbox(textBox_ScoreKartridg, "Поле для ввода\nколичества картриджей");

        }
    }
}
