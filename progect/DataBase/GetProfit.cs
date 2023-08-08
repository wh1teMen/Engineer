using progect.BaseSetting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static progect.Global.GlobalParametrs;

namespace progect.DataBase
{
    //получение суммы заработанной с клиента
     public class GetProfit
    {
        public static string getProfit(decimal scoreKontragent, decimal scoreMaterial)
        {
            var resultProfit = Math.Round(((double.Parse(scoreKontragent.ToString()) - double.Parse(scoreMaterial.ToString())) * ((double.Parse(dataClient.Persent.ToString()))) / 100), 2);
            return resultProfit.ToString();

        }
    }
}
