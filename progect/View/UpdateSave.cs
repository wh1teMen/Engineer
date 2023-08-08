using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static progect.Global.GlobalParametrs; 

namespace progect.View
{
    public class UpdateSave
    {
        public static void Save(DataGridView dgw)
        {
            try
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = Refdataset.Tables[0];
                dgw.DataSource = bindingSource;
                SQLiteCommandBuilder sQLiteCommandBuilder = new SQLiteCommandBuilder(RefdataAdapter);
                RefdataAdapter.Update(Refdataset);
               
            }
            catch(Exception ) { MessageBox.Show("Проверте корректность данных "); }


        }
    }
}
