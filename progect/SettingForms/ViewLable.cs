using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static progect.DataBase.GetSum;
using static progect.BaseSetting.GetCountRows;
using static progect.Global.GlobalParametrs;

namespace progect.SettingForms
{
    public class ViewLable
    {
        public static void RefreshLable(Label baraban,Label kartrig,Label profit)
        {
            if (CountID(TableName) == 0)
            {
                baraban.Text = "0";
                kartrig.Text = "0";
                profit.Text = "0";
            }
            if (CountID(TableName) > 0)
            {
                baraban.Text = (Sum("ScoreBaraban")).ToString()+" шт";
                kartrig.Text = (Sum("ScoreKartriges")).ToString()+" шт";
                profit.Text = (SumDouble("Profit")).ToString()+" руб";
            }

        }
    }
}
