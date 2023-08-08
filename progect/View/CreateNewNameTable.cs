using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static progect.View.GetIndexEnum;
namespace progect.View
{
    internal class CreateNewNameTable
    {
        public static string CreateNameTable(ComboBox month, TextBox year)
        {
            string index = string.Empty;
            string result=string.Empty;
            
                index = (GetIndexEnumSelect(month)).ToString(); 
                result =index + year.Text;                   
            return result;
        }
    }
}
