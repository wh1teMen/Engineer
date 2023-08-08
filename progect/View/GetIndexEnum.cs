using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace progect.View
{
    internal class GetIndexEnum
    {
       public static int GetIndexEnumSelect(ComboBox month)
        {
            int index = (int)Enum.Parse(typeof(Month.month), month.Text);
            return index;

        }
    }
}
