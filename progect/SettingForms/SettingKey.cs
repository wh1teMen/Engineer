using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace progect.SettingFormsAdd
{
    public class SettingKey
    {
        //Метод, позволяющий добавлять только цифры и Backspace в поле Textbox
        public static void KeyNumberPress(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

    }
}
