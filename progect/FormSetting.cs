using progect.DataBase;
using progect.SettingFormsAdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using progect.BaseSetting;
using static progect.SettingFormsAdd.SettingKey;
using static progect.BaseSetting.Add;
using static progect.BaseSetting.Update;
using static progect.BaseSetting.CreateBaseSetting;
using static progect.SettingForms.SettingWindow;

namespace progect
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            
            InitializeComponent();
            size(this, 240, 205);
            Key();           
        }
        private void Key()
        {
            textBox_percent.KeyPress+= (object sender, KeyPressEventArgs e) => { KeyNumberPress(e); };
            textBox_incomeTax.KeyPress+= (object sender, KeyPressEventArgs e) => {KeyNumberPress(e);};
            textBox_salary.KeyPress+= (object sender, KeyPressEventArgs e) => { KeyNumberPress(e); };          
        }

        private void button_UpdateSetting_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateSetting(textBox_percent, textBox_salary, textBox_incomeTax);
        }
    }
}
