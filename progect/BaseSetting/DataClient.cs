using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace progect.BaseSetting
{
    //Класс для хранения данных о зарплате, окладебподоходному налогу
    public class DataClient
    {
        private int persent;
        private int salary;
        private int incomeTax;
        //Процент с прибыли,идущий в зп
        public int Persent
        { get{ return persent;}                              
            set
            {
                if (value == 0) throw new Exception("Процент не может быть равен нулю");
                if (value < 0) throw new Exception("Процент не может быть меньше нуля");
                if (value >100) throw new Exception("Процент не может быть больше 100%");
                else
                persent = value; 
            } 
        } 
        //оклад
        public int Salary { get { return salary; }
            set
            {
                if (value == 0) throw new Exception("Зарплата не может быть равна нулю");
                if (value < 0) throw new Exception("Зарплата не может быть меньше нуля");
                else
                salary = value;
            } }
        //подоходный налог
        public int IncomeTax { get { return incomeTax; }
            set
            {
                if (value == 0) throw new Exception("Подоходный налог\n не может быть равен нулю");
                if (value < 0) throw new Exception("Подоходный налог\n не может быть меньше нуля");
                if (value > 100) throw new Exception("Подоходный налог\n не может быть больше 100%");
                else
                incomeTax = value; 
            } }
        
    }
}
