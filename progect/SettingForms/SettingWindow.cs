using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace progect.SettingForms
{
    public class SettingWindow
    {
        public static void size(Form f,int w,int h)
        {
            f.Width = w;
            f.Height = h;
            f.MinimumSize = f.MaximumSize = f.Size; 
        }
      
            

    }
}
