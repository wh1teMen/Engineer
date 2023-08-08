using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace progect.ShowMessegeInfo
{
    public class InfoMessege
    {
        //Добавление всплывающего сообщения с подсказкой при наведении на кнопку
        public static void InfoMessegeCreateButton(Button other,string textInfo)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.InitialDelay = 1200;//задержка 
            tooltip.AutomaticDelay = 500;
            tooltip.AutoPopDelay = 6000;//время просмотра
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.ShowAlways = true;//всегда показывать
            tooltip.ToolTipTitle = "Информация";//заголовок
            tooltip.IsBalloon = true;//комиксный вид
            tooltip.SetToolTip(other, textInfo);//сообщение              
        }
        public static void InfoMessegeCreateCheckBox(CheckBox other, string textInfo)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.InitialDelay = 1200;//задержка 
            tooltip.AutomaticDelay = 500;
            tooltip.AutoPopDelay = 6000;//время просмотра
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.ShowAlways = true;//всегда показывать
            tooltip.ToolTipTitle = "Информация";//заголовок
            tooltip.IsBalloon = true;//комиксный вид
            tooltip.SetToolTip(other, textInfo);//сообщение              
        }
        public static void InfoMessegeCreateLable(Label other, string textInfo)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.InitialDelay = 1200;//задержка 
            tooltip.AutomaticDelay = 500;
            tooltip.AutoPopDelay = 6000;//время просмотра
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.ShowAlways = true;//всегда показывать
            tooltip.ToolTipTitle = "Информация";//заголовок
            tooltip.IsBalloon = true;//комиксный вид
            tooltip.SetToolTip(other, textInfo);//сообщение              
        }
        public static void InfoMessegeCreateTextbox(TextBox other, string textInfo)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.InitialDelay = 600;//задержка 
            tooltip.AutomaticDelay = 500;
            tooltip.AutoPopDelay = 6000;//время просмотра
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.ShowAlways = true;//всегда показывать
            tooltip.ToolTipTitle = "Информация";//заголовок
            tooltip.IsBalloon = true;//комиксный вид
            tooltip.SetToolTip(other, textInfo);//сообщение              
        }

    }
}
