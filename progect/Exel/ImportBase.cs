using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace progect.Exel
{
   public class ImportBase
    {
        private int day;
        private int remKarta;
        private string kontragent;
        private decimal scoreKontragent;
        private decimal scoreMaterial;
        private int baraban;
        private int scoreKartridg;      
        private string profit;

        public int Day { get { return day; } set { day = value; } }
        public int RemKarta { get { return remKarta; } set { remKarta = value; } }
        public string Kontragent { get { return kontragent; } set { kontragent = value; } }
        public decimal ScoreKontragent { get { return scoreKontragent; } set { scoreKontragent = value; } }
        public decimal ScoreMaterial { get { return scoreMaterial; } set { scoreMaterial = value; } }
        public int Baraban { get { return baraban; } set { baraban = value; } }
        public int ScoreKartridg { get { return scoreKartridg; } set { scoreKartridg = value; } }      
        public string Profit { get { return profit; } set { profit = value; } } 

        
    }
}
