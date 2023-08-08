using progect.BaseSetting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static progect.Global.GlobalParametrs;

namespace progect.DataBase
{
    public class DataAddBase
    {
        private int day;
        private int remKarta;
        private string kontragent;
        private decimal scoreKontragent;
        private decimal scoreMaterial;
        private int baraban;
        private int scoreKartridg;
        private double proc;
        public int Day { get { return day; } set { day = value; } }       
        public double Proc { get { return proc; } set { proc = value; } }
        public int Remkarta
        {
            get => remKarta;
            set
            {
                if (value == 0) throw new Exception("Номер ремонтной карты\nне может быть равен нулю");
                if (value < 0) throw new Exception("Номер ремонтной карты\nне может быть меньше нуля");              
                else remKarta = value;
            }
        }
        public string Kontragent
        {
            get => kontragent;
            set
            {
                if (value.Length < 3) throw new Exception("Имя Контрагента не\nможет быть меньше 3 букв!!");
                if (value.Length == 0) throw new Exception("Введите имя Контрагента");
                else kontragent = value;
            }
        }
        public decimal ScoreKontragent
        {
            get => scoreKontragent;
            set
            {
                if (value < 0) throw new Exception("Счёт клиенту не может\nбыть меньше нуля!!!!");
                if (value == 0) throw new Exception("Счёт клиенту не может\nбыть равным нулю!!!");               
                else scoreKontragent = value;
            }
        }
        public decimal ScoreMaterial
        {
            get => scoreMaterial;
            set
            {
                if (value < 0) throw new Exception("Цена за материалы\nне может быть меньше нуля!!!");              
                if (value > scoreKontragent ) throw new Exception("Цена за материалы не может быть\nбольше суммы счета клиенту!!!");
                else scoreMaterial = value;
            }
        }
        public int Baraban
        {
            get => baraban;
            set
            {
                if (value < 0) throw new Exception("Ошибка!!! Количество замененных\nфотобарабанов не может быть меньше нуля!!");             
                else baraban = value;
            }
        }
        public int ScoreKartridg
        {
            get => scoreKartridg;
            set
            {
                if (value == 0) throw new Exception("Общее количесвто картриджей\nне может быть равным нулю!!!");
                if (value < 0) throw new Exception("Общее количество картриджей\nне может быть меньше нуля!!!");
                else scoreKartridg = value;
            }
        }
        public DataAddBase()
        {
            try
            {
                day = ((DateTime.Now).Day);
                remKarta = 0;
                kontragent = "NonameKontragent";
                baraban = 0;
                scoreKartridg = 0;
                scoreKontragent = 0;
                scoreMaterial = 0;
                proc = (double.Parse(dataClient.Persent.ToString()) / 100);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

    }
}
